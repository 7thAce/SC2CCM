using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starcraft_Mod_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            LogEventLevel level = LogEventLevel.Information;

            // Allow command line options to change file logging level
            if (args.Length > 1)
            {
                switch (args[1].ToUpper())
                {
                    case "FATAL": level = LogEventLevel.Fatal; break;
                    case "ERROR": level = LogEventLevel.Error; break;
                    case "WARNING": level = LogEventLevel.Warning; break;
                    case "INFORMATION": level = LogEventLevel.Information; break;
                    case "DEBUG": level = LogEventLevel.Debug; break;
                    case "VERBOSE": level = LogEventLevel.Verbose; break;
                }
            }

            string logFile = initLogFile();

            // Initialize our logger
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                    logFile,
                    fileSizeLimitBytes: 2 * 1024 * 1024, // 2MB
                    restrictedToMinimumLevel: level
                )
                .WriteTo.Console(LogEventLevel.Verbose) // Log everything to console
                .CreateLogger();
            Console.WriteLine($"Log file {logFile}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SC2CCM());
        }

        static string initLogFile()
        {

            // Select our log file
            string logFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                Path.Combine("SC2CCM", "mod_manager.log"));

            // Rotate away the old log file (keep a history of 1)
            try
            {
                if (File.Exists(logFile))
                {
                    var oldLogFile = $"{logFile}.old";
                    if (File.Exists(oldLogFile))
                    {
                        File.Delete(oldLogFile);
                    }
                    File.Move(logFile, oldLogFile);
                }
                return logFile;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to rotate logs! " + e.Message);
                return null;
            }
        }
    }
}
