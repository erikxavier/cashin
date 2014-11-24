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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CashIn
{
    /// <summary>
    /// Interaction logic for TabModel.xaml
    /// </summary>
    public partial class TabModel : UserControl
    {
        public ControleTabs Control;
        public TabItem Tab { get; set; }
        public MainWindow App;
        public TabModel()
        {
            InitializeComponent();
        }

        public TabModel(TabItem tab, ControleTabs control)
        {
            InitializeComponent();
            Tab = tab;
            Control = control;
            App = control.App;
        }
    }
}
