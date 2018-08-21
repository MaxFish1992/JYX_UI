using MoonPdfLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZdfFlatUI.UserControls
{
    /// <summary>
    /// PdfViewerWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PdfViewerWindow : Window
    {
        private MoonPdfPanel moonPdfPanel = null;
        public PdfViewerWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 打开pdf文件
        /// </summary>
        /// <param name="fileName">文件完整路径</param>
        public void OpenPDF(string fileName)
        {
            if (moonPdfPanel == null)
            {
                moonPdfPanel = new MoonPdfPanel();

                moonPdfPanel.ViewType = ViewType.SinglePage;
                moonPdfPanel.Loaded += moonPdfPanel_Loaded;
                this.grid.Children.Add(moonPdfPanel);
            }
            moonPdfPanel.OpenFile(fileName);
        }

        void moonPdfPanel_Loaded(object sender, RoutedEventArgs e)
        {
            moonPdfPanel.ZoomToHeight();
            moonPdfPanel.PageRowDisplay = PageRowDisplayType.ContinuousPageRows;
            moonPdfPanel.PageMargin = new Thickness(0, 2, 0, 2);
        }
    }
}
