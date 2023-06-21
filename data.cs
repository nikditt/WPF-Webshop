using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;

namespace navigation
{
    public class data
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string currency { get; set; }
        public string img { get; set; }

        //public static string url = File.ReadAllText(@"c\Repositories\wpf_navigation\navigation\text_files_for_testing\product.json");

        //private List<data> myList = JsonConvert.DeserializeObject<List<data>>(url);

        public static string Url = @"c:\Repositories\wpf_navigation\navigation\text_files_for_testing\product.json";

        public List<data> myList;

        public data()
        {
            string json = File.ReadAllText(Url);
            myList = JsonConvert.DeserializeObject<List<data>>(json);
        }
    }

    
}
