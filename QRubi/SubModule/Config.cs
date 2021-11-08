using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QRubi
{
    /// <summary>
    /// ファイルパス関係
    /// </summary>
    public class ConfigClass
    {
        public static string DefaultLoadFilePath = ConfigurationManager.AppSettings["DefaultLoadFilePath"];
        public static string DefaultSaveFolderPath = ConfigurationManager.AppSettings["DefaultSaveFolderPath"];

        public string LoadFilePath { get; set; } = DefaultLoadFilePath;
        public string SaveFolderPath { get; set; } = DefaultSaveFolderPath;
    }
}
