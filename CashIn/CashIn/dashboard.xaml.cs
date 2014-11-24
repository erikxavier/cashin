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
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : UserControl
    {
        public ControleTabs Controle;
        public TabItem Tab { get; set; }
        public MainWindow App { get; set; }

        public dashboard()
        {
            InitializeComponent();
        }

        public dashboard(TabItem tab, ControleTabs controle)
        {
            InitializeComponent();
            Tab = tab;
            Controle = controle;
            App = controle.App;
        }

        private void atualizaTela()
        {
            //var orcamentosAguardando = App.UsuarioLogado.Orcamento.Where(o => !o.Projeto.Any());
            //gridOrcAguardando.ItemsSource = orcamentosAguardando;
            gridOrcAguardando.ItemsSource = App.UsuarioLogado.Orcamento.Where(o => !o.Projeto.Any());
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            atualizaTela();
        }
    }
}
