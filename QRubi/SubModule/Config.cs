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
    public static class ConfigClass
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        //app.configから取得
        public static string DefaultLoadFilePath = ConfigurationManager.AppSettings["DefaultLoadFilePath"];
        public static string DefaultLoadFolderPath = ConfigurationManager.AppSettings["DefaultLoadFolderPath"];
        public static string DefaultSaveFolderPath = ConfigurationManager.AppSettings["DefaultSaveFolderPath"];
        public static string BfLoadFilePath = ConfigurationManager.AppSettings["BfLoadFilePath"];
        public static string BfLoadFolderPath = ConfigurationManager.AppSettings["BfLoadFolderPath"];
        public static string BfSaveFolderPath = ConfigurationManager.AppSettings["BfSaveFolderPath"];
        public static string Chk1 = ConfigurationManager.AppSettings["Chk1"];
        public static string Chk2 = ConfigurationManager.AppSettings["Chk2"];

        public static string Dic1 = ConfigurationManager.AppSettings["Dic"];

        public static string LoadFilePath { get; set; } = BfLoadFilePath != "" ? BfLoadFilePath : DefaultLoadFilePath;
        public static string LoadFolderPath { get; set; } = BfLoadFolderPath != "" ? BfLoadFolderPath : DefaultLoadFolderPath;
        public static string SaveFolderPath { get; set; } = BfSaveFolderPath != "" ? BfSaveFolderPath : DefaultSaveFolderPath;

        public static bool IsChk1 { get; set; } = Chk1 == "" ? false : Convert.ToBoolean(Chk1);
        public static bool IsChk2 { get; set; } = Chk2 == "" ? false : Convert.ToBoolean(Chk2);

        public static IEnumerable<string> DicPath()
        {
            string s = ConfigurationManager.AppSettings["Dic"];
            if (s == null || s == "")
                return new string[] { "" };
            else
                return s.Split('\r');
        }

        public static void WriteValue(Dictionary<string,string> keyvalues)
        {
            foreach (var c in keyvalues)
            {
                config.AppSettings.Settings[c.Key].Value = c.Value;
            }
            config.Save();

            return;
        }
    }
}
