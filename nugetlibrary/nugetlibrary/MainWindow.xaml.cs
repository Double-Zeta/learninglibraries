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

namespace nugetlibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            


            try
            {
                MessageBox.Show(TxtURL.Text);
                var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
                htmlToPdf.GeneratePdfFromFile(TxtURL.Text, null, "export.pdf");
            }
            catch (Exception TxtURL)
            {
                MessageBox.Show("The URL you have entered is invalid" + TxtURL.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);

                

            }
        }



    }
}
