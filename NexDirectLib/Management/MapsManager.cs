﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NexDirectLib.Management
{
    public static class MapsManager
    {
        public static IEnumerable<string> Maps;

        private static string songsFolder;

        public static void Init(string sf)
        {
            songsFolder = sf;
            Reload();
        }

        public static void Reload()
        {
            string[] folders = Directory.GetDirectories(songsFolder);

            string[] _files = Directory.GetFiles(songsFolder);
            var files = new List<string>();
            foreach (string file in _files)
                if (file.Contains(".osz")) files.Add(file);

            Maps = folders.Concat(files);
        }
    }
}
