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
        ControleTabs Controle;
        public TabItem Tab { get; set; }
        CashinDB DB;
        Pessoa novaPessoa;
        Endereco novoEndereco;

        public cadPessoa()
        {
            InitializeComponent();            
        }

        public cadPessoa(TabItem tab, ControleTabs control)
        {
            InitializeComponent();                  
            Tab = tab;
            this.Controle = control;            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            novoCadastro();
                       
        }

        private void cbUf_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbUf.SelectedIndex != -1)
            {
                Uf uf = (Uf)cbUf.SelectedItem;
                cbCidade.ItemsSource = uf.Cidade.ToList<Cidade>();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            novoEndereco.Cidade = (Cidade)cbCidade.SelectedItem;
            novaPessoa.Endereco.Add(novoEndereco);

            using (DB = new CashinDB())
            {
                if (rbCliente.IsChecked == true)
                {
                    Cliente novoCliente = new Cliente();
                    novoCliente.Pessoa = novaPessoa;
                    DB.Cliente.InsertOnSubmit(novoCliente);
                }
                else if (rbUser.IsChecked == true)
                {
                    if (!DB.Usuario.Where(u => u.User == tbUser.Text).Any())
                    {
                        Usuario novoUsuario = new Usuario();                                                
                        novoUsuario.User = tbUser.Text;
                        novoUsuario.Pass = tbPass.Password;
                        novaPessoa.Usuario.Add(novoUsuario);
                        DB.Usuario.InsertOnSubmit(novoUsuario);
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário já existente!", "Erro");
                        return;
                    }
                }    
            }         
            DB.SubmitChanges();
            gridCadastro.IsEnabled = false;
            gridNovo.IsEnabled = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            novoCadastro();
        }

        private void novoCadastro()
        {
            novaPessoa = new Pessoa();
            novoEndereco = new Endereco();
            Grid1.DataContext = novaPessoa;
            gridCadastro.IsEnabled = true;
            gridNovo.IsEnabled = false;

            using (DB = new CashinDB())
            {
                cbUf.ItemsSource = DB.Uf; 
            }
            cbUf.SelectedIndex = -1;
            cbCidade.ItemsSource = null;
            Grid1.DataContext = novaPessoa;
            gridEndereco.DataContext = novoEndereco;             
        }

       
    }        
}
