using System;
using System.IO;
using System.IO.Compression;

namespace ModManager.StarCraft.Services
{
    public static class ZipArchiveExtensions
    {
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite)
        {
            if (!overwrite)
            {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }

            DirectoryInfo di = Directory.CreateDirectory(destinationDirectoryName);
            string destinationDirectoryFullPath = di.FullName;
            foreach (ZipArchiveEntry file in archive.Entries)
            {
                //MessageBox.Show("ZAE file: " + file);
                string completeFileName = Path.GetFullPath(Path.Combine(destinationDirectoryFullPath, file.FullName));

                if (!completeFileName.StartsWith(destinationDirectoryFullPath, StringComparison.OrdinalIgnoreCase))
                {
                    throw new IOException("Trying to extract file outside of destination directory. See this link for more info: https://snyk.io/research/zip-slip-vulnerability");
                }

                if (file.Name == "")
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                }
                else
                {

                    string targetDir = Path.GetDirectoryName(completeFileName);
                    if (!Directory.Exists(targetDir))
                    {
                        Directory.CreateDirectory(targetDir);
                    }
                    //MessageBox.Show("Extracting " + completeFileName + "\nTo " + targetDir);
                    file.ExtractToFile(completeFileName, true);
                }
            }
        }
    }
}
