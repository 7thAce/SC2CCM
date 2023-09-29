using EnsureThat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModManager.StarCraft.Services
{
    /// <summary>
    /// Service that contains directory manipulation functions
    /// </summary>
    public class DirectoryManagementService
    {
        private Action<string> Logger;

        public DirectoryManagementService(Action<string> logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Clears a directively recursively.
        /// </summary>
        /// <param name="dir">Directory to be cleared</param>
        /// <returns></returns>
        public bool ClearDirectory(string dir)
        {
            bool retVal = true;
            try
            {
                Ensure.That(Directory.Exists(dir), "Directory").Is(true);
                foreach (var file in Directory.GetFiles(dir))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (IOException)
                    {
                        Logger.Invoke("ERROR: Could not delete campaign file " + Path.GetFileNameWithoutExtension(file) + " - please exit the campaign and try again.");
                        retVal = false;
                    }
                }

                //TODO: Fix the evo missions
                foreach (string subdir in Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly))
                {
                    if (!(subdir.Contains(@"Campaign\swarm") || subdir.Contains(@"Campaign\void") || subdir.Contains(@"Campaign\nova")))
                    {
                        Directory.Delete(subdir, true);
                    }
                }
            }
            catch (ArgumentException)
            {
                Logger.Invoke("ERROR: Did not find directory " + dir + " to clear.");
                retVal = false;
            }
            
            return retVal;
        }
    }
}
