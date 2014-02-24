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
using System.Xml;
using xml.Model;
using xml.Data;
using xmlData.Model;
using System.Collections.ObjectModel;

namespace xml
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<XmlData> troll = new List<XmlData>();
        public xmlTree actualItem { get; set; }
        public XML lista = new XML();

        public MainWindow()
        {

            InitializeComponent();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog okienko = new Microsoft.Win32.OpenFileDialog();
            okienko.Filter = "XML file|*.xml";
            okienko.Multiselect = true;
            if (okienko.ShowDialog() == false)
                return; // jesli nie zostal otwarty plik
            
            foreach (string file in okienko.FileNames)
            {
                XmlData xml1 = new XmlData(file);
                xml1.path = file;
                troll.Add(xml1);
                lista.XMLfiles = troll;
            }
            WrapUpXmltree heh = new WrapUpXmltree(lista);
            XmlTrees.ItemsSource = heh.tree.tree;
        }
         private void Save(object sender, RoutedEventArgs e)
        {
             if (this.lista.XMLfiles != null)
             {
                 this.lista.save();
             }
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            xmlTree dd = e.NewValue as xmlTree;
                               
            this.actualItem = dd;
            if(dd.URIVerdict != null)
            {
                procedurebox.Text = dd.URIVerdict.Value;
                procedurebox.Visibility = System.Windows.Visibility.Visible;
                new TextRange(procedure.Document.ContentStart, procedure.Document.ContentEnd).Text = dd.Title;
                new TextRange(ID.Document.ContentStart, ID.Document.ContentEnd).Text = "";
            }
            else
            {
                procedurebox.Visibility = System.Windows.Visibility.Hidden;
                new TextRange(procedure.Document.ContentStart, procedure.Document.ContentEnd).Text = "";
                new TextRange(ID.Document.ContentStart, ID.Document.ContentEnd).Text = "";
            }
                
            

          
        }
        private void verdictchange(object sender, EventArgs e)
        {
            if(this.actualItem.URIVerdict.Value != procedurebox.Text)
            {
                this.actualItem.URIVerdict.Value = procedurebox.Text;
                if (this.actualItem.URIVerdictOveride != null)
                {
                    this.actualItem.URIVerdictOveride.Value = "true";
                }
               
            }
            
                        
        }

    }

}
