﻿using System.Windows.Input;

using WpfApp.View.Page.Reporst;

namespace WpfApp.View.Page
{
    /// <summary>
    ///     Логика взаимодействия для SelectReport.xaml
    /// </summary>
    public partial class SelectReport : System.Windows.Controls.Page
    {
        public static RoutedCommand NavigateReport3_1 = new();
        public static RoutedCommand NavigateReport3_3 = new();
        public static RoutedCommand NavigateReport3_4 = new();

        private void CommandBinding_OnExecuted_Report3_1(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow.FrameMainWindow.Navigate(new Report3_1());
        }

        private void CommandBinding_OnExecuted_Report3_3(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow.FrameMainWindow.Navigate(new Report3_3());
        }

        private void CommandBinding_OnExecuted_Report3_4(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow.FrameMainWindow.Navigate(new Report3_4());
        }

        public SelectReport()
        {
            InitializeComponent();
        }
    }
}