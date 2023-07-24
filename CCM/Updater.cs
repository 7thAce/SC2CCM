using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

public class Updater
{

	public Updater()
	{
        int needsUpdate = CheckForUpdates();
        if (needsUpdate > 0) RunUpdater(needsUpdate);
    }

    /* Fucntion that goes out to github to check if a new version number has been posted.
     * If so, downloads the files that are new and then runs the updater program in order to update itself.
     * Otherwise, we'd get a file in use error.
     * 
     * This is also the jankiest, worst updater in the history of updaters.
     * I've never written an updater before because I haven't needed to - it's not my line of work.
     * This is *not* a good solution and I at least mostly regret the way I've done it.
     * However, I don't have enough time to rewrite it so yeah.  
     */
    private int CheckForUpdates()
    {
        Log.Information("Checking for updates");
        int retVar = 0;
        //Sets up the file if it hasn't been made before.
        handleFiles();

        //Pull github version history
        string apiResponse = "";
        try
        {
            apiResponse = Get("https://api.github.com/repos/7thace/SC2CCM/releases");
        }
        catch (Exception e)
        {
            //Failed to connect, do not update.
            Log.Error("Unable to check for updates. Error: {Error}", e.Message);
            return 0;
        }

        if (apiResponse.ToString().Contains("API rate limit exceeded"))
        {
            Log.Warning("Unable to check for updates, API rate limit exceeded!");
            return 0;
        }

        //Get both local and remote versions.
        List<dynamic> mostRecentReleases = handleApi(JsonConvert.DeserializeObject(apiResponse));
        List<int> localVersions = getLocalVersionNumbers();

        Console.WriteLine("SC2CCM Local: " + localVersions[0] + " vs. Remote: " + mostRecentReleases[0].id);
        Console.WriteLine("Updater Local: " + localVersions[1] + " vs. Remote: " + mostRecentReleases[1].id);

        if ((int)mostRecentReleases[0].id != localVersions[0] || (int)mostRecentReleases[1].id != localVersions[1])
        {
            DialogResult dialogResult = MessageBox.Show("It looks like you need an update!\nWould you like to download it?", "StarCraft II Custom Campaign Manager", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
            {
                Log.Information("Updates ignored by user");
                return 0;
            }
        }

        //Compare what to do and download if needed
        if ((int)mostRecentReleases[1].id != localVersions[1])
        {
            Log.Debug("Looks like the Updater needs an update!  Ironic.");
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile((string)mostRecentReleases[1].assets[0].browser_download_url, "SC2CCM Updater.exe");
                    retVar = -1;
                }
                catch (Exception e)
                {
                    Log.Error("Failed to download Updater. Error: {Error}", e.Message);
                    return 0;
                }
                localVersions[1] = (int)mostRecentReleases[1].id;
            }
        }

        if ((int)mostRecentReleases[0].id != localVersions[0])
        {
            Log.Debug("Looks like the Custom Campaign Manager needs an update!");
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile((string)mostRecentReleases[0].assets[0].browser_download_url, "SC2CCM.exe");
                    retVar = 1;
                }
                catch (Exception e)
                {
                    Log.Error("Failed to download SC2CCM. Error: {Error}", e.Message);
                    return 0;
                }
                localVersions[0] = (int)mostRecentReleases[0].id;
            }
        }

        handleFiles(localVersions);  // We're committed.
        Log.Verbose("Updates ready for installation");
        return retVar; //1 = we need to close and install the new update.
    }

    static private List<int> getLocalVersionNumbers()
    {
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"SC2CCM\SC2CCMU.txt");
        int[] array = { 0, 0 };
        List<int> ids = new List<int>(array);

        if (File.Exists(filePath))
        {
            foreach (string line in File.ReadLines(filePath))
            {
                if (line.ToLower().StartsWith("sc2ccm="))
                {
                    ids[0] = Int32.Parse(line.Split('=')[1]);
                }
                if (line.ToLower().StartsWith("sc2ccmu="))
                {
                    ids[1] = Int32.Parse(line.Split('=')[1]);
                }
            }
        }
        else
        {
            File.CreateText(filePath);
        }
        return ids;
    }

    static private void handleFiles()
    {
        var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var filePath = Path.Combine(roamingDirectory, @"SC2CCM\SC2CCMU.txt");
        if (!File.Exists(filePath))
        {
            try
            {
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("SC2CCM=0");
                    sw.WriteLine("SC2CCMU=0");
                }
            }
            catch (IOException e)
            {
                return;
            }
        }
    }

    static private void handleFiles(List<int> versionIDs)
    {
        //MessageBox.Show("we do be handlin' files");
        var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var filePath = Path.Combine(roamingDirectory, @"SC2CCM\SC2CCMU.txt");
        if (File.Exists(filePath))
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("SC2CCM=" + versionIDs[0]);
                    sw.WriteLine("SC2CCMU=" + versionIDs[1]);
                }
            }
            catch (IOException e)
            {
                Environment.Exit(0);
            }
        }
    }

    private void RunUpdater(int updateCode)
    {
        Log.Information("Running Updater");
        //MessageBox.Show("firing and shutting down");
        //System.Threading.Thread.Sleep(1000);
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = @"SC2CCM Updater.exe";
        Process.Start(start);
        Environment.Exit(0);
    }

    static private List<dynamic> handleApi(dynamic apiResp)
    {
        dynamic[] array = { "", "" };
        List<dynamic> recentVersionAPI = new List<dynamic>(array);

        int sc2ccmID = 0;
        int sc2ccmuID = 0;

        int i = 0;
        string[] releases = ((IEnumerable)apiResp).Cast<object>().Select(x => x.ToString()).ToArray();
        int releaseCount = releases.Length;

        while (i < releases.Length && (sc2ccmID == 0 || sc2ccmuID == 0))
        {
            Console.WriteLine(i + ": " + apiResp[i].tag_name);
            if (apiResp[i].tag_name == "SC2CCM")
            {
                if (sc2ccmID == 0)
                {
                    sc2ccmID = apiResp[i].id;
                    recentVersionAPI[0] = apiResp[i];
                }
            }
            if (apiResp[i].tag_name == "Updater")
            {
                if (sc2ccmuID == 0)
                {
                    sc2ccmuID = apiResp[i].id;
                    recentVersionAPI[1] = apiResp[i];
                }
            }
            i++;
        }
        return recentVersionAPI;
    }

    static public string Get(string uri)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        request.UserAgent = "SC2CCMU";
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
    }
}
