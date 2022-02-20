using System;
using System.Diagnostics;

namespace SteamProcessLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = Process.Start(@"""X:\Modding\Tools\SkyrimVR\Mod Organizer 2\ModOrganizer.exe""", @"""X:\Modding\SteamLibrary\steamapps\common\SkyrimVR\skse64_loader.exe""");

            Environment.Exit(0);
        }
    }
}
