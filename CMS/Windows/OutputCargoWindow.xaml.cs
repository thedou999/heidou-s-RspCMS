using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace CMS.Windows
{
    /// <summary>
    /// OutputCargoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OutputCargoWindow : MetroWindow
    {
        public OutputCargoWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) =>
            {
                AppData.Instance.ShowMarkLayer(true);
            };
            this.Closing += (s, e) =>
            {
                AppData.Instance.ShowMarkLayer(false);
            };
        }
    }
}
