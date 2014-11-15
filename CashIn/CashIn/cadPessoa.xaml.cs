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
    /// Interaction logic for cadPessoa.xaml
    /// </summary>
    public partial class cadPessoa : UserControl
    {
        public TabControl TabPai { get; set; }
        public TabItem Tab { get; set; }
        CashinDB context = new CashinDB();
        Pessoa novaPessoa;
        Endereco novoEndereco;

        public cadPessoa()
        {
            InitializeComponent();            
        }

        public cadPessoa(TabItem tab)
        {
            InitializeComponent();
            context.Log = Console.Out;
            novaPessoa = new Pessoa();
            novoEndereco = new Endereco();            
            Tab = tab;
            TabPai = (TabControl)tab.Parent;
            tab.Content = this;
            tab.IsSelected = true;
            tab.Name = "telaCadPessoa";
            tab.Header = "Cadastrar Pessoa";            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {            
            cbUf.ItemsSource = context.Uf;
            Grid1.DataContext = novaPessoa;
            gridEndereco.DataContext = novoEndereco;            
        }

        private void cbUf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Uf uf = (Uf)cbUf.SelectedItem;
            cbCidade.ItemsSource = uf.Cidade.ToList<Cidade>();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            novoEndereco.Cidade = (Cidade)cbCidade.SelectedItem;
            novaPessoa.Endereco.Add(novoEndereco);
            context.Pessoa.InsertOnSubmit(novaPessoa);
            context.SubmitChanges();
            gridCadastro.IsEnabled = false;
            gridNovo.IsEnabled = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            novaPessoa = new Pessoa();
            novoEndereco = new Endereco();
            Grid1.DataContext = novaPessoa;
            gridCadastro.IsEnabled = true;
            gridNovo.IsEnabled = false;
        }
    }        
}
