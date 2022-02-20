using System;
using System.Diagnostics;
using System.Windows.Forms;

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
                DialogResult result = MessageBox.Show($"Invalid Args: args[0] = {args[0]}, args[1] = {args[1]}. \nExpected: SkyrimSKSELauncher.exe \"X:\\Modding\\Tools\\SkyrimSE\\Mod Organizer 2\\ModOrganizer.exe\" \"\"\"X:\\Modding\\SteamLibrary\\steamapps\\common\\Skyrim Special Edition\\skse64_loader.exe\"\"\" ",
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                    Environment.Exit(1);
            }
            else
            {
                string application = args[0];
                string command_args = args[1];

                Process.Start(application, command_args);

                Environment.Exit(0);
            }
        }
    }
}
