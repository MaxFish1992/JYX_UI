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
using ZdfFlatUI.UserControls;

namespace ZdfFlatUI.Test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            PdfViewerWindow pdfViewer = new PdfViewerWindow
            {
                Owner = this,
                Topmost = true,
                Height = 1080,
                Width = 1920,
                Top = 0,
                WindowStartupLocation = WindowStartupLocation.Manual,
            };
            pdfViewer.OpenPDF(@"F:\项目管理\智慧抚州\Exception Handling, VSTO.pdf");
            pdfViewer.Show();
        }
    }
}
