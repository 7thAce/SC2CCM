using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC2CCM_Updater_Form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //System.Threading.Thread.Sleep(500);
            if (File.Exists(@"SC2CCM.exe"))
            {
                File.Delete(@"SC2 Custom Campaign Manager.exe");
                File.Move(@"SC2CCM.exe", @"SC2 Custom Campaign Manager.exe");
            }
            //System.Threading.Thread.Sleep(500);
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"SC2 Custom Campaign Manager.exe";
            MessageBox.Show("Update Successful, press OK to Launch!", "StarCraft 2 Custom Campaign Manager", MessageBoxButtons.OK);
            Process.Start(start);
            Environment.Exit(0);
            //Application.Run(new Form1());
        }
    }
}
