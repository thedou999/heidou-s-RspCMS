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
using System.Windows.Shapes;
using MahApps;
using MahApps.Metro.Controls;

namespace CMS.Windows
{
    /// <summary>
    /// InputCargoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class InputCargoWindow : MetroWindow
    {
        public InputCargoWindow()
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
