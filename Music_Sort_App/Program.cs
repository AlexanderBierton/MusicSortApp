using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace Music_Sort_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class mainFunc
    {
        public static List<string> remList = new List<string>();
        public static List<string> curList = new List<string>();
        public static List<string> renList = new List<string>();
        public static string remDir;
        public static string numToRemove;
        

        public void ListItems(List<string> itms) => remList = itms;

        public List<string> GetList() => remList;

        public void ClearItems()
        {
            remList.Clear();
            curList.Clear();
            renList.Clear();
        }

        public void SetPath(string dir) => remDir = dir;

        public string GetPath() => remDir;

        public bool HasStartNumber(string input)
        {
            string GetData;

            if (Regex.IsMatch(input, @"^\d*-\d*"))
            {
                Regex pattern = new Regex(@"^\d*-\d*");
                Match match = pattern.Match(input);

                GetData = match.Value;
                numToRemove = GetData;
                return true;
            }
            else if (Regex.IsMatch(input, @"^-\d*"))
            {
                Regex pattern = new Regex(@"^-\d*");
                Match match = pattern.Match(input);

                GetData = match.Value;
                numToRemove = GetData;
                return true;
            }
            else if (Regex.IsMatch(input, @"^\d+"))
            {
                Regex pattern = new Regex(@"^\d+");
                Match match = pattern.Match(input);

                GetData = match.Value;
                numToRemove = GetData;
                return true;
            }
            else
                return false;
            
        }
        public bool HasEndNumber(string input)
        {
            string GetData;

            if (Regex.IsMatch(input, @"(\d*).mp3"))
            {
                Regex pattern = new Regex(@"(\d*).mp3");
                Match match = pattern.Match(input);

                GetData = match.Value;
                numToRemove = GetData;
                return true;
            }
            else
                return false;
        }
    }
}
