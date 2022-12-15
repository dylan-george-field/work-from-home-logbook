﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace wfh_log_wpf.Settings
{
    public class HomeNetworkSettings
    {
        public List<string> HomeNetworks = new();
        internal readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            + "\\wfh-log"; // duplicate with base log
        private const string filename = "settings.txt";

        public HomeNetworkSettings()
        {
            ReadHomeNetworksFromFile();
        }

        public void ReadHomeNetworksFromFile()
        {
            if (!File.Exists(path + "\\" + filename))
            {
                Directory.CreateDirectory(path);
                var filestream = File.Create(path + "\\" + filename);
                filestream.Dispose();
            }

            var file = File.ReadAllText(path + "\\" + filename);

            SetHomeNetworks(file);
        }

        public void SetHomeNetworks(string list)
        {
            var networks = list.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            foreach (var item in networks)
            {
                HomeNetworks.Add(item);
            }
        }

        public string GetHomeNetworkString()
        {
            var stringBuilder = new StringBuilder();

            foreach(var network in HomeNetworks)
            {
                stringBuilder.Append(network);
                stringBuilder.Append(';');
            }

            return stringBuilder.ToString();
        }
    }
}
