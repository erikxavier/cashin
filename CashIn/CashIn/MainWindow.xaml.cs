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
using System.Globalization;
using System.Reflection;
using System.Threading;

namespace CashIn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
	// comentário erik

    //sbruble
    public partial class MainWindow : Window
    {
        public Usuario UsuarioLogado { get; set; }
        public ControleTabs Controle;            

        public MainWindow(Usuario user)
        {
            InitializeComponent();
            UsuarioLogado = user;
            this.Title = "CashIn - Logado como " + user.Pessoa.Nome;
            Controle = new ControleTabs(this, tabControl1);
           
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Controle.tabDash();
        }

        private void tabCadPessoa(object sender, RoutedEventArgs e)
        {
            Controle.tabPessoa();
        }

        private void tabCadOrcamento(object sender, RoutedEventArgs e)
        {
            Controle.tabOrcamento();
        }

    }
}
