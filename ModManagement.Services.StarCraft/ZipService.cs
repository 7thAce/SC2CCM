using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModManager.StarCraft.Services
{
    public class ZipService
    {
        private Action<string> Logger;

        public ZipService(Action<string> logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Unzips any .zip files found in the custom campaigns directory.
        /// This is called on reload (on button, on drag, or on start).
        /// </summary>
        /// <param name="sc2BasePath"></param>
        /// <returns></returns>
        public void unzipZips(string sc2BasePath)
        {
            foreach (string file in Directory.GetFiles(Path.Combine(sc2BasePath, @"Maps\CustomCampaigns")))
            {
                if (file.EndsWith(".zip"))
                {
                    string modFolderName = Path.GetFileNameWithoutExtension(file);
                    File.SetAttributes(file, FileAttributes.Normal);
                    using (FileStream zipToOpen = new FileStream(file, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            archive.ExtractToDirectory(Path.Combine(sc2BasePath, @"Maps\CustomCampaigns", modFolderName), true);
                            Logger.Invoke("Unzipped " + Path.GetFileNameWithoutExtension(modFolderName) + ".");
                        }
                    }
                    string[] subdirs = Directory.GetDirectories(Path.Combine(sc2BasePath, @"Maps\CustomCampaigns", modFolderName), "lotvprologue", SearchOption.AllDirectories);
                    foreach (string dir in subdirs)
                    {
                        Directory.Move(dir, Path.Combine(sc2BasePath, @"Maps\Campaign\voidprologue"));
                        Logger.Invoke("Moved a lotv prologue thing to the proper place");
                    }
                    try
                    {
                        File.Delete(file);
                    }
                    catch (IOException)
                    {
                        Logger.Invoke($"Could not delete zip file {file} - file in use.");
                    }

                }
                string[] files = Directory.GetFiles(Path.Combine(sc2BasePath, @"Maps\CustomCampaigns"), "*.SC2Mod", SearchOption.AllDirectories); //right here
            }
        }
    }
}
