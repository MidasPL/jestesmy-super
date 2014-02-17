﻿using System;
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
namespace xml
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();       
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog okienko = new Microsoft.Win32.OpenFileDialog();
            // filtr tylko na .xml
            if (okienko.ShowDialog() == true)
            {
                MessageBox.Show("Wybrano plik: " + okienko.FileName);
            }
            else
                MessageBox.Show("Wybrano nieodpowiedni plik");
            XML lista = new XML();
            XmlData xml1 = new XmlData(okienko.FileName);
            List<XmlData> troll = new List<XmlData>();
            troll.Add(xml1);
            lista.XMLfiles = troll;
            WrapUpXmltree heh = new WrapUpXmltree(lista);
            XmlTrees.ItemsSource = heh.tree.tree;
        }
    }
}
