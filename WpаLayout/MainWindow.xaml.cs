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

namespace WpfLayout
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

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            CanvasWindow dlg = new CanvasWindow();
            dlg.ShowDialog();
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow dlgDockPanel = new DockPanelWindow();
            dlgDockPanel.ShowDialog();
        }
    }
}
