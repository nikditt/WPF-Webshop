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


namespace navigation
{
    /// <summary>
    /// Interaktionslogik für Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            // Binding auf die Listview
            //CustomItems.ItemsSource = myList;  Funktioniert noch nicht
        }

     

        private void Button_right_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));
        }

        private void Button_left_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        } 

        private void Button_help_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("https://www.google.com/"));
        }

        //Benutzerdaten:
        //Funktion zum Öffnen von Dateien
        private void btn_open_Click(object sender, RoutedEventArgs e)
        {
            /*  OpenFileDialog meinDialog = new OpenFileDialog();
              meinDialog.InitialDirectory = "";
              meinDialog.Multiselect = true; // erlaubt mehrere Dateien zu öffnen
              meinDialog.Filter = "Alle Dateien | *.*" +  
                                  "|jpg | *.jpg" +
                                  "|png | *.png" +
                                  "|txt | *.txt";
              meinDialog.ShowDialog();
              for (int i = 0; i < meinDialog.FileNames.Length; i++) 
              {
                  string file = meinDialog.FileNames[i];
                  listbox.Items.Add(file);
              }*/
            MessageBox.Show("Button wurde im Menü ausgelagert. Bitte prüfe den Code.");
        }


        //Funktion zum Speichern von Textdateien

        private void Button_open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog meinDialog = new OpenFileDialog();
            meinDialog.InitialDirectory = "";
            meinDialog.Multiselect = true; // erlaubt mehrere Dateien zu öffnen
            meinDialog.Filter = "Alle Dateien | *.*" +
                                "|txt | *.txt";
            meinDialog.ShowDialog();
            for (int i = 0; i < meinDialog.FileNames.Length; i++)
            {
                string file = meinDialog.FileNames[i];
                ListView_content.Items.Add(file);
            }
        }

        private void Button_save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = "";
            save.ShowDialog();
            if (save.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(save.OpenFile()))
                {
                    sw.Write(TextBox_user.Text);
                }
            }
        }

        private void ListView_content_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object o = ListView_content.SelectedItem;
            string extension = System.IO.Path.GetExtension((string)o);
            if (extension == ".txt")
            {
                TextBox_user.Text = File.ReadAllText((string)o);
            }
            else
            {
                MessageBox.Show("Please select a text file.");
            }

        }
    }
}
