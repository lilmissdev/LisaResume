using System;
using System.Diagnostics;
using System.Windows;

using LisaResume.Back_End_Code.Classes;
using LisaResume.Pages;

namespace LisaResume.Windows
{
    /// <summary>
    /// Interaction logic for SampleCodeWindow.xaml
    /// </summary>
    public partial class SampleCodeWindow : Window
    {
        private Singleton singleton = Singleton.GetSingleton();

        private Process pDocked;
        private IntPtr hWndOriginalParent;
        private IntPtr hWndDocked;
        public string FilePath { get; set; }
        public SampleCodeWindow()
        {
            InitializeComponent();
            SampleWindow.Content = new SampleCodePage("");
        }
    }


}
