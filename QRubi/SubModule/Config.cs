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
        //app.configから取得
        public static string DefaultLoadFilePath = ConfigurationManager.AppSettings["DefaultLoadFilePath"];
        public static string DefaultLoadFolderPath = ConfigurationManager.AppSettings["DefaultLoadFolderPath"];
        public static string DefaultSaveFolderPath = ConfigurationManager.AppSettings["DefaultSaveFolderPath"];
        public static string BfLoadFilePath = ConfigurationManager.AppSettings["BfLoadFilePath"];
        public static string BfLoadFolderPath = ConfigurationManager.AppSettings["BfLoadFolderPath"];
        public static string BfSaveFolderPath = ConfigurationManager.AppSettings["BfSaveFolderPath"];
        public static string Chk1 = ConfigurationManager.AppSettings["Chk1"];
        public static string Chk2 = ConfigurationManager.AppSettings["Chk2"];

        public string LoadFilePath { get; set; } = BfLoadFilePath != "" ? BfLoadFilePath : DefaultLoadFilePath;
        public string LoadFolderPath { get; set; } = BfLoadFolderPath != "" ? BfLoadFolderPath : DefaultLoadFolderPath;
        public string SaveFolderPath { get; set; } = BfSaveFolderPath != "" ? BfSaveFolderPath : DefaultSaveFolderPath;

        public bool IsChk1 { get; set; } = Chk1 == "" ? false : Convert.ToBoolean(Chk1);
        public bool IsChk2 { get; set; } = Chk2 == "" ? false : Convert.ToBoolean(Chk2);
    }
}
