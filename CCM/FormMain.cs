using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModManager.StarCraft.Base;
using ModManager.StarCraft.Base.Enums;
using ModManager.StarCraft.Services;

namespace Starcraft_Mod_Manager
{
    public partial class FormMain : Form
    {
        // modLists contains the mods for each campaign (WoL, HotS, LotV, NCO, none)
        //That should be Dictionary<Capaign, List<Mod>> to avoid uninteded duplicates that can slip through testing. Leaving for now. -MajorKaza
        List<Mod>[] modLists = new List<Mod>[5];
        private PathUtils pathUtils;
        private string importMod = "";

        ZipService zipService;

        public FormMain()
        {
            InitializeComponent();
            zipService = new ZipService(logBoxWriteLine); //TODO: Propper logger
        }

        private void SC2MM_Load(object sender, EventArgs e)
        {
            copyUpdater();
            pathUtils = new PathUtils(Path.GetDirectoryName(GetOrDerivePathForStarcraft2Exe()));
            pathUtils.VerifyDirectories();
            zipService.unzipZips(pathUtils.PathForStarcraft2);
            handleDependencies();
        }
        private void SC2MM_Shown(object sender, EventArgs e)
        {
            populateModLists();
            populateDropdowns();
            setInfoBoxes();
            logBoxWriteLine("Loaded SC2CCM.");
        }

        private void checkForCampaignUpdates()
        {
            // Not gonna do this until it migrates off discord.
        }

        private void copyUpdater()
        {
            if (File.Exists("SC2CCMU.exe"))
            {
                try
                {
                    File.Delete("SC2CCM Updater.exe");
                    File.Move("SC2CCMU.exe", "SC2CCM Updater.exe");
                } catch (IOException e)
                {
                    MessageBox.Show("Failed to delete/move the Updater!");
                }
            }
        }

        /* Pulls the StarCraft II directory from whatever program .SC2Save files are opened with (it's often SC2!)
         * If that turns up invalid for some reason or SC2CCM.txt is deleted, it'll ask the user to find it for us.
         * An issue I found that's more common than expected is multiple copies of SC2 being installed.
         * This will only find one of them and it may not be the one that gets launched, leading to "no mods"
         * when mods are selected.
         */
        /// <summary>
        /// Pulls the StarCraft II directory from whatever program .SC2Save files are opened with (it's often SC2!)
        /// </summary>
        public string GetOrDerivePathForStarcraft2Exe()
        {
            string pathForStarcraft2Exe;

            if (!File.Exists(PathUtils.PathForCcmConfig))
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(PathUtils.PathForCcmConfig));
                }
                catch (IOException e)
                {
                    MessageBox.Show("Unable to create configuration file/folder\nTry running this as administrator.", "StarCraft II Custom Campaign Manager");
                    Application.Exit();
                }
                try
                {
                    pathForStarcraft2Exe = PathUtils.PathForStarcraft2Exe();
                    File.WriteAllText(PathUtils.PathForCcmConfig, pathForStarcraft2Exe);
                } catch (Exception)
                {
                    //If we have any issues and need to exit, make the file and force a default path.  We can handle that just ahead.
                    File.WriteAllText(PathUtils.PathForCcmConfig, CommonPath.DefaultStarcraft2Exe);
                }
            }

            if (!File.Exists(PathUtils.PathForCcmConfig)) //If we have any unknown issues and the file doesn't exist, make it and force a default path.
            {
                File.WriteAllText(PathUtils.PathForCcmConfig, CommonPath.DefaultStarcraft2Exe);
            }

            pathForStarcraft2Exe = File.ReadLines(PathUtils.PathForCcmConfig).FirstOrDefault();
            if (!File.Exists(pathForStarcraft2Exe))
            {
                MessageBox.Show("It looks like StarCraft II isn't in the default spot!\nPlease use the file browser and select Starcraft II.exe", "StarCraft II Custom Campaign Manager");
                if (findSC2Dialogue.ShowDialog() == DialogResult.OK)
                {
                    //I don't do a check for the filename because I don't know if it appears different in other languages.
                    pathForStarcraft2Exe = findSC2Dialogue.FileName;
                    File.WriteAllText(PathUtils.PathForCcmConfig, pathForStarcraft2Exe);
                } else
                {
                    Application.Exit();
                }
            }

            return pathForStarcraft2Exe;
        }

        /* Moves all the .SC2Mod files and folders into the Mods folder. 
         * If a .SC2Mod file exists and a .SC2Mod folder is moved in (if the dev updates the method),
         * then an error would occur.  This is handled here.
         */
        public void handleDependencies()
        {
            string[] files = Directory.GetFiles(pathUtils.PathForCustomCampaign(null), "*.SC2Mod", SearchOption.AllDirectories);
            foreach (string filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                // Folder with same name as file check
                if (Directory.Exists(pathUtils.PathForMod(fileName)))
                {
                    Directory.Delete(pathUtils.PathForMod(fileName), true);
                }
                if (File.Exists(pathUtils.PathForMod(fileName)))
                {
                    try
                    {
                        File.Delete(pathUtils.PathForMod(fileName));
                        File.Move(filePath, pathUtils.PathForMod(fileName));
                        logBoxWriteLine("Moved " + fileName + " to Dependencies folder.");
                    } catch (IOException e)
                    {
                        logBoxWriteLine("ERROR: Could not replace " + fileName + " - exit StarCraft II and hit \"Reload\" to fix install properly.");
                    }
                } else
                {
                    try
                    {
                        File.Move(filePath, pathUtils.PathForMod(fileName));
                        logBoxWriteLine("Moved " + fileName + " to Dependencies folder.");
                    } catch (IOException e)
                    {
                        logBoxWriteLine("ERROR: Could not move " + fileName + " - is it open somewhere?");
                    }
                }
            }

            foreach (string dirPath in Directory.GetDirectories(pathUtils.PathForCustomCampaign(null), "*.SC2Mod", SearchOption.AllDirectories))
            {
                string dirName = Path.GetFileName(dirPath);
                // File with name name as folder check
                if (File.Exists(pathUtils.PathForMod(dirName)))
                {
                    File.Delete(pathUtils.PathForMod(dirName));
                }
                if (Directory.Exists(pathUtils.PathForMod(dirName)))
                {
                    try
                    {
                        Directory.Delete(pathUtils.PathForMod(dirName), true);
                        Directory.Move(dirPath, pathUtils.PathForMod(dirName));
                        logBoxWriteLine("Moved " + dirName + " to Dependencies folder.");

                    }
                    catch (IOException e)
                    {
                        logBoxWriteLine("ERROR: Could not replace " + dirName + " - exit StarCraft II and hit \"Reload\" to fix install properly.");
                    }
                } else
                {
                    Directory.Move(dirPath, pathUtils.PathForMod(dirName));
                    logBoxWriteLine("Moved " + dirName + " to Dependencies folder.");
                }
            }
        }

        /* Builds the modLists array  based on the folders that exist in the customcampaigns folder. 
         * If a mod does not have a campaign specified in the metadata file, it is assigned to None.
         */
        public void populateModLists()
        {
            //Clean out old mods to start fresh.
            for (int i = 0; i < modLists.Length; i++)
            {
                modLists[i] = new List<Mod>();
            }

            // Search in each directory
            foreach (string dir in Directory.GetDirectories(pathUtils.PathForCustomCampaign(null), "*", SearchOption.TopDirectoryOnly))
            {
                // for a metadata.txt file
                string[] files = Directory.GetFiles(dir, "metadata.txt", SearchOption.AllDirectories);
                if (files.Length == 0)
                {
                    logBoxWriteLine("FAILED TO LOAD: Unable to find metadata.txt for: " + Path.GetFileName(dir));
                    continue;
                }
                if (files.Length >= 2)
                {
                    logBoxWriteLine("WARNING: Multiple metadata.txt found for: " + dir);
                }

                Mod currentMod = new Mod();
                foreach (string line in File.ReadLines(files[0]))
                {
                    processLine(line, currentMod);
                }
                currentMod.Path = Path.GetDirectoryName(files[0]);
                modLists[(int)currentMod.Campaign].Add(currentMod);
            }
        }

        /* Adds the mods to the dropdowns menu on the form.
         * Also does a slightly hideous check of comparing the new item to the mod most recently imported.
         * If so, it calls the new mod prompt function.
         */
        public void populateDropdowns()
        {
            wolSelectBox.Items.Clear();
            hotsSelectBox.Items.Clear();
            lotvSelectBox.Items.Clear();
            ncoSelectBox.Items.Clear();

            foreach (Mod mod in modLists[1])
            {
                wolSelectBox.Items.Add(mod.Title);
                if (mod.Path.Contains(@"\" + importMod + @"\") && importMod.Length > 0)
                {
                    promptNewMod(mod.Title, mod.Campaign);
                }
            }
            foreach (Mod mod in modLists[2])
            {
                hotsSelectBox.Items.Add(mod.Title);
                if (mod.Path.Contains(@"\" + importMod + @"\") && importMod.Length > 0)
                {
                    promptNewMod(mod.Title, mod.Campaign);
                }
            }
            foreach (Mod mod in modLists[3])
            {
                lotvSelectBox.Items.Add(mod.Title);
                if (mod.Path.Contains(@"\" + importMod + @"\") && importMod.Length > 0)
                {
                    promptNewMod(mod.Title, mod.Campaign);
                }
            }
            foreach (Mod mod in modLists[4])
            {
                ncoSelectBox.Items.Add(mod.Title);
                if (mod.Path.Contains(@"\" + importMod + @"\") && importMod.Length > 0)
                {
                    promptNewMod(mod.Title, mod.Campaign);
                }
            }
        }

        /* Populates the dropdowns of only a specific campaign.
         * This is called specifically after deleting a campaign.
         */
        public void populateDropdowns(int index)
        {
            if (index == 1)
            {
                wolSelectBox.Items.Clear();
                wolSetButton.Enabled = false;
                wolDeleteButton.Enabled = false;
                foreach (Mod mod in modLists[index])
                {
                    wolSelectBox.Items.Add(mod.Title);
                }
            }

            if (index == 2)
            {
                hotsSelectBox.Items.Clear();
                hotsSetButton.Enabled = false;
                hotsDeleteButton.Enabled = false;
                foreach (Mod mod in modLists[index])
                {
                    hotsSelectBox.Items.Add(mod.Title);
                }
            }

            if (index == 3)
            {
                lotvSelectBox.Items.Clear();
                lotvSetButton.Enabled = false;
                lotvDeleteButton.Enabled = false;
                foreach (Mod mod in modLists[index])
                {
                    lotvSelectBox.Items.Add(mod.Title);
                }
            }

            if (index == 4)
            {
                ncoSelectBox.Items.Clear();
                ncoSetButton.Enabled = false;
                ncoDeleteButton.Enabled = false;
                foreach (Mod mod in modLists[index])
                {
                    ncoSelectBox.Items.Add(mod.Title);
                }
            }
        }

        /* Asks if the user wants to set the single newly imported mod to active.  */
        public void promptNewMod(string modName, Campaign campaign)
        {
            DialogResult dialogResult = MessageBox.Show("Import of " + modName + " successful, would you like to make it the active campaign?", "StarCraft II Custom Campaign Manager", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (campaign == Campaign.WoL)
                {
                    wolSelectBox.SelectedIndex = wolSelectBox.FindStringExact(modName);
                    wolSetButton_Click(null, null);
                }
                else if (campaign == Campaign.HotS)
                {
                    hotsSelectBox.SelectedIndex = hotsSelectBox.FindStringExact(modName);
                    hotsSetButton_Click(null, null);
                }
                else if (campaign == Campaign.LotV)
                {
                    lotvSelectBox.SelectedIndex = lotvSelectBox.FindStringExact(modName);
                    lotvSetButton_Click(null, null);
                }
                else if (campaign == Campaign.NCO)
                {
                    ncoSelectBox.SelectedIndex = ncoSelectBox.FindStringExact(modName);
                    ncoSetButton_Click(null, null);
                }
            }
        }

        /* Sets the display boxes (Title, Author, Version) for the active mod.
         * Sets to a default if no metadata.txt is found. 
         */
        public void setInfoBoxes()
        {
            string wolMetadataPath = pathUtils.PathForMetadata(CommonPath.Campaign);
            if (File.Exists(wolMetadataPath))
            {
                Mod activeMod = new Mod();
                foreach (string line in File.ReadLines(wolMetadataPath))
                {
                    processLine(line, activeMod);
                }
                wolTitleBox.Text = activeMod.Title;
                wolAuthorBox.Text = activeMod.Author;
                wolVersionBox.Text = activeMod.Version;
            }
            else
            {
                wolTitleBox.Text = "Default Campaign";
                wolAuthorBox.Text = "Blizzard";
                wolVersionBox.Text = "N/A";
            }

            string hotsMetadataPath = pathUtils.PathForMetadata(CommonPath.Campaign_HotS);
            if (File.Exists(hotsMetadataPath))
            {
                Mod activeMod = new Mod();
                foreach (string line in File.ReadLines(hotsMetadataPath))
                {
                    processLine(line, activeMod);
                }
                hotsTitleBox.Text = activeMod.Title;
                hotsAuthorBox.Text = activeMod.Author;
                hotsVersionBox.Text = activeMod.Version;
            }
            else
            {
                hotsTitleBox.Text = "Default Campaign";
                hotsAuthorBox.Text = "Blizzard";
                hotsVersionBox.Text = "N/A";
            }

            string lotvMetadataPath = pathUtils.PathForMetadata(CommonPath.Campaign_LotV);
            if (File.Exists(lotvMetadataPath))
            {
                Mod activeMod = new Mod();
                foreach (string line in File.ReadLines(lotvMetadataPath))
                {
                    processLine(line, activeMod);
                }
                lotvTitleBox.Text = activeMod.Title;
                lotvAuthorBox.Text = activeMod.Author;
                lotvVersionBox.Text = activeMod.Version;
            }
            else
            {
                lotvTitleBox.Text = "Default Campaign";
                lotvAuthorBox.Text = "Blizzard";
                lotvVersionBox.Text = "N/A";
            }

            string ncoMetadataPath = pathUtils.PathForMetadata(CommonPath.Campaign_Nco);
            if (File.Exists(ncoMetadataPath))
            {
                Mod activeMod = new Mod();
                foreach (string line in File.ReadLines(ncoMetadataPath))
                {
                    processLine(line, activeMod);
                }
                ncoTitleBox.Text = activeMod.Title;
                ncoAuthorBox.Text = activeMod.Author;
                ncoVersionBox.Text = activeMod.Version;
            }
            else
            {
                ncoTitleBox.Text = "Default Campaign";
                ncoAuthorBox.Text = "Blizzard";
                ncoVersionBox.Text = "N/A";
            }
        }

        /* Handles a line pulled from metadata.txt and stores it in the mod object. */
        private void processLine(string line, Mod mod)
        {
            String[] lineParts = line.Split(new[] { '=' }, 2);
            if (lineParts[0].ToLower() == "title") mod.Title = lineParts[1];
            if (lineParts[0].ToLower() == "desc") mod.Description = lineParts[1];
            if (lineParts[0].ToLower() == "campaign") mod.SetCampaign(lineParts[1]);
            if (lineParts[0].ToLower() == "version") mod.Version = lineParts[1];
            if (lineParts[0].ToLower() == "author") mod.Author = lineParts[1];
            //if (lineParts[0].ToLower() == "lotvprologue") mod.SetPrologue(lineParts[1]);
        }



        private void wolSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            wolSetButton.Enabled = true;
            wolDeleteButton.Enabled = true;
        }

        private void hotsSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotsSetButton.Enabled = true;
            hotsDeleteButton.Enabled = true;
        }

        private void lotvSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lotvSetButton.Enabled = true;
            lotvDeleteButton.Enabled = true;
        }

        private void ncoSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ncoSetButton.Enabled = true;
            ncoDeleteButton.Enabled = true;
        }

        private void logBoxWriteLine(string message)
        {
            logBox.Text += message;
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
            logBox.Text += "\n";
        }

        private void displayBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        /* 
         * I've opted to keep all of these as separate functions instead of passing them into a larger "handleSetButton" function.
         * Because the directory structure is a little wonky, I'd probably have to pass in the directory and some string helpers as well.
         * To avoid this, I'd probably have to make a whole set of extra helper functions and change some of my setup, which I don't have time to do.
         * It is probably easier to maintain as one larger function, but I'm not at the point where I can really do that.
         */
        private void wolSetButton_Click(object sender, EventArgs e)
        {
            if (wolSelectBox.SelectedIndex < 0) return;
            Mod selectedMod = modLists[1][wolSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaign, logBoxWriteLine))
            {
                PathUtils.CopyFilesAndFolders(modPath, pathUtils.PathForCampaign);
                setInfoBoxes();
                logBoxWriteLine("Set Wings Campaign to " + selectedMod.Title + "!");
                hideWarningImg(wolWarningImg);
            } else
            {
                logBoxWriteLine("ERROR: Could not set Wings campaign - SC2 files in use.");
                showWarningImg(wolWarningImg);
            }
        }

        private void wolDeleteButton_Click(object sender, EventArgs e)
        {
            Mod selectedMod = modLists[1][wolSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + selectedMod.Title + "?", "StarCraft II Custom Campaign Manager", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                while (!Path.GetDirectoryName(modPath).EndsWith("CustomCampaigns"))
                {
                    modPath = Path.GetDirectoryName(modPath);
                }
                if (PathUtils.TryClearDirectory(modPath, logBoxWriteLine))
                {
                    Directory.Delete(modPath);
                    populateModLists();
                    populateDropdowns((int)Campaign.WoL);
                    setInfoBoxes();
                    logBoxWriteLine("Deleted " + selectedMod.Title + " from local storage.");
                }
                else
                {
                    logBoxWriteLine("ERROR: Could not delete " + selectedMod.Title + " - a file may be open somewhere.");
                }
            }
        }

        private void wolRestoreButton_Click(object sender, EventArgs e)
        {
            logBoxWriteLine("Resetting Wings Campaign to default.");
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaign, logBoxWriteLine))
            {
                logBoxWriteLine("Clear successful!");
                setInfoBoxes();
                hideWarningImg(wolWarningImg);
            } else
            {
                logBoxWriteLine("ERROR: Could not set Wings campaign - SC2 files in use.");
                showWarningImg(wolWarningImg);
            }
        }


        private void hotsSetButton_Click(object sender, EventArgs e)
        {
            if (hotsSelectBox.SelectedIndex < 0) return;
            Mod selectedMod = modLists[2][hotsSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaignHotS, logBoxWriteLine))
            {
                PathUtils.CopyFilesAndFolders(modPath, pathUtils.PathForCampaignHotS);
                setInfoBoxes();
                logBoxWriteLine("Set Swarm Campaign to " + selectedMod.Title + "!");
                hideWarningImg(hotsWarningImg);
            }
            else
            {
                logBoxWriteLine("ERROR: Could not set Swarm campaign - SC2 files in use.");
                showWarningImg(hotsWarningImg);
            }
        }

        private void hotsDeleteButton_Click(object sender, EventArgs e)
        {
            Mod selectedMod = modLists[2][hotsSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + selectedMod.Title + "?", "StarCraft II Custom Campaign Manager", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                while (!Path.GetDirectoryName(modPath).EndsWith("CustomCampaigns"))
                {
                    modPath = Path.GetDirectoryName(modPath);
                }
                if (PathUtils.TryClearDirectory(modPath, logBoxWriteLine))
                {
                    Directory.Delete(modPath);
                    populateModLists();
                    populateDropdowns((int)Campaign.HotS);
                    setInfoBoxes();
                    logBoxWriteLine("Deleted " + selectedMod.Title + " from local storage.");
                }
                else
                {
                    logBoxWriteLine("ERROR: Could not delete " + selectedMod.Title + " - a file may be open somewhere.");
                }
            }
        }

        private void hotsRestoreButton_Click(object sender, EventArgs e)
        {
            logBoxWriteLine("Resetting Swarm Campaign to default.");
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaignHotS, logBoxWriteLine)
                && PathUtils.TryClearDirectory(pathUtils.PathForCampaignHotSEvolution, logBoxWriteLine))
            {
                logBoxWriteLine("Clear complete!");
                setInfoBoxes();
                hideWarningImg(hotsWarningImg);
            }
            else
            {
                logBoxWriteLine("ERROR: Could not set Swarm campaign - SC2 files in use.");
                showWarningImg(hotsWarningImg);
            }
        }

        private void lotvSetButton_Click(object sender, EventArgs e)
        {
            if (lotvSelectBox.SelectedIndex < 0) return;
            Mod selectedMod = modLists[3][lotvSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaignLotV, logBoxWriteLine))
            {
                PathUtils.CopyFilesAndFolders(modPath, pathUtils.PathForCampaignLotV);
                setInfoBoxes();
                logBoxWriteLine("Set Void Campaign to " + selectedMod.Title + "!");
                hideWarningImg(lotvWarningImg);
            }
            else
            {
                logBoxWriteLine("ERROR: Could not set Void campaign - SC2 files in use.");
                showWarningImg(lotvWarningImg);
            }
        }

        private void lotvDeleteButton_Click(object sender, EventArgs e)
        {
            Mod selectedMod = modLists[3][lotvSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + selectedMod.Title + "?", "StarCraft II Custom Campaign Manager", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                while (!Path.GetDirectoryName(modPath).EndsWith("CustomCampaigns"))
                {
                    modPath = Path.GetDirectoryName(modPath);
                }
                if (PathUtils.TryClearDirectory(modPath, logBoxWriteLine))
                {
                    Directory.Delete(modPath);
                    populateModLists();
                    populateDropdowns((int)Campaign.LotV);
                    setInfoBoxes();
                    logBoxWriteLine("Deleted " + selectedMod.Title + " from local storage.");
                }
                else
                {
                    logBoxWriteLine("ERROR: Could not delete " + selectedMod.Title + " - a file may be open somewhere.");
                }
            }
        }

        private void lotvRestoreButton_Click(object sender, EventArgs e)
        {
            logBoxWriteLine("Resetting Void Campaign to default.");
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaignLotV, logBoxWriteLine))
            {
                logBoxWriteLine("Clear complete!");
                setInfoBoxes();
                hideWarningImg(lotvWarningImg);
            }
            else
            {
                logBoxWriteLine("ERROR: Could not set Void campaign - SC2 files in use.");
                showWarningImg(lotvWarningImg);
            }
        }

        private void ncoSetButton_Click(object sender, EventArgs e)
        {
            if (ncoSelectBox.SelectedIndex < 0) return;
            Mod selectedMod = modLists[4][ncoSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaignNco, logBoxWriteLine))
            {
                PathUtils.CopyFilesAndFolders(modPath, pathUtils.PathForCampaignNco);
                setInfoBoxes();
                logBoxWriteLine("Set Nova Campaign to " + selectedMod.Title + "!");
                hideWarningImg(ncoWarningImg);
            }
            else
            {
                logBoxWriteLine("ERROR: Could not set Nova campaign - SC2 files in use.");
                showWarningImg(ncoWarningImg);
            }
        }

        private void ncoDeleteButton_Click(object sender, EventArgs e)
        {
            Mod selectedMod = modLists[4][ncoSelectBox.SelectedIndex];
            string modPath = selectedMod.Path;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + selectedMod.Title + "?", "StarCraft II Custom Campaign Manager", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                while (!Path.GetDirectoryName(modPath).EndsWith("CustomCampaigns"))
                {
                    modPath = Path.GetDirectoryName(modPath);
                }
                if (PathUtils.TryClearDirectory(modPath, logBoxWriteLine))
                {
                    Directory.Delete(modPath);
                    populateModLists();
                    populateDropdowns((int)Campaign.NCO);
                    setInfoBoxes();
                    logBoxWriteLine("Deleted " + selectedMod.Title + " from local storage.");
                }
                else
                {
                    logBoxWriteLine("ERROR: Could not delete " + selectedMod.Title + " - a file may be open somewhere.");
                }
            }
        }

        private void ncoRestoreButton_Click(object sender, EventArgs e)
        {
            logBoxWriteLine("Resetting Nova Campaign to default.");
            if (PathUtils.TryClearDirectory(pathUtils.PathForCampaignNco, logBoxWriteLine))
            {
                logBoxWriteLine("Clear complete!");
                setInfoBoxes();
                hideWarningImg(ncoWarningImg);
            }
            else
            {
                logBoxWriteLine("ERROR: Could not set Nova campaign - SC2 files in use.");
                showWarningImg(ncoWarningImg);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Install a Custom Campaign:\n" +
                "1. Drag and drop the mod .zip file onto the Custom Campaign Manager\n" +
                "2. Select the custom campaign from the dropdown list and hit \"Set to Active Campaign\"", "Starcraft II Custom Campaign Manager");
        }
        private void importButton_Click(object sender, EventArgs e)
        {
            string[] targetFilePaths;
            selectFolderDialogue.Filter = "zip archives (*.zip)|*.zip";
            if (selectFolderDialogue.ShowDialog() == DialogResult.OK)
            {
                targetFilePaths = selectFolderDialogue.FileNames.ToArray<String>();
                importFiles(targetFilePaths);
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            SC2MM_Load(null, null);
            SC2MM_Shown(null, null);
        }

        private void SC2CCM_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            importFiles(filePaths);
        }

        /* Copies all files from the specified folder into idfk lets do this tomorrow
         * TODO 
         */
        private void importFiles(string[] filePaths)
        {
            int importCount = 0;

            foreach (String filePath in filePaths)
            {
                if (filePath.ToLower().EndsWith(".zip"))
                {
                    importCount++;
                    // This is NOT a good solution, but it should work.
                    if (importCount >= 2)
                    {
                        importMod = "";
                    }
                    else
                    {
                        importMod = Path.GetFileNameWithoutExtension(filePath);
                    }
                    File.Copy(filePath, pathUtils.PathForCustomCampaign(Path.GetFileName(filePath)), true);
                }
                else
                {
                    if (Path.GetExtension(filePath).Length == 0)
                    {
                        importCount++;
                        // This is NOT a good solution, but it should work.
                        if (importCount >= 2)
                        {
                            importMod = "";
                        }
                        else
                        {
                            importMod = Path.GetFileNameWithoutExtension(filePath);
                        }
                        string targetDir = Path.Combine(pathUtils.PathForCustomCampaign(Path.GetFileName(filePath)));
                        if (!Directory.Exists(targetDir))
                        {
                            Directory.CreateDirectory(targetDir);
                        }
                        PathUtils.CopyFilesAndFolders(filePath, targetDir);
                        Directory.Delete(filePath, true);
                    }
                }
            }
            SC2MM_Load(null, null);
            SC2MM_Shown(null, null);
        }

        private void SC2CCM_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            bool valid;
            valid = GetFilename(out filename, e);

            if (valid)
            {
                e.Effect = DragDropEffects.Move;
            } else
            {
                logBoxWriteLine("Debug: Drag Enter with fn " + filename + " invalid.");
                e.Effect = DragDropEffects.None;
            }
            
        }

        private void SC2CCM_DragLeave(object sender, EventArgs e)
        {
            //e.Effect = DragDropEffects.Move;
        }

        private void SC2CCM_DragOver(object sender, DragEventArgs e)
        {
            string filename;
            bool valid;
            valid = GetFilename(out filename, e);

            if (valid)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        protected bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileName") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        Console.WriteLine("Ext: " + ext);
                        if (ext == ".zip" || ext == "")
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        private void handleWarningHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip((PictureBox)sender, "Warning: Active campaign may have missing or inconsistent files.\nThis usually due to changing campaigns while in a mission or menu.\nPlease exit to the menu in SC2 and set an active mod to clear this.");
        }

        private void showWarningImg(PictureBox warningImg)
        {
            warningImg.Visible = true;
        }

        private void hideWarningImg(PictureBox warningImg)
        {
            warningImg.Visible = false;
        }

        private void logBox_KeyDown(object sender, KeyEventArgs e)
        {
            //e.SuppressKeyPress = true;
        }
    }
}
