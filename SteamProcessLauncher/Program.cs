using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;

/// <summary>
/// Application that will launch a given process with a given set of arguments
/// e.g SkyrimSKSELauncher.exe """X:\Modding\Tools\SkyrimSE\Mod Organizer 2\ModOrganizer.exe""" """X:\Modding\SteamLibrary\steamapps\common\Skyrim Special Edition\skse64_loader.exe"""
/// </summary>

namespace SkyrimSKSELauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                DialogResult result = MessageBox.Show($"Invalid Arguments \nUsage: CMD -> SteamProcessLaucher.exe application.exe arg1 arg2 \n Example: CMD -> SteamProcessLauncher.exe \"\"\"X:\\Modding\\Tools\\SkyrimSE\\Mod Organizer 2\\ModOrganizer.exe\"\"\" \"\"\"X:\\Modding\\SteamLibrary\\steamapps\\common\\Skyrim Special Edition\\skse64_loader.exe\"\"\"",
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(1);
            }
            else
            {
                string application = args[0];
                StringBuilder arguments = new StringBuilder();

                for (int i = 1; i < args.Length; i++)
                {
                    arguments.Append(args[i] + " ");
                }
                

                ProcessStartInfo start_info = new ProcessStartInfo(application);
                start_info.Arguments = arguments.ToString().Trim();
                _ = Process.Start(start_info);

                Environment.Exit(0);
            }
        }
    }
}
