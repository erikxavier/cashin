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
using CashIn;
using MySql.Data.MySqlClient;

namespace CashIn
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            validaUsuario(tbUser.Text, tbPass.Password);
        }

        private void validaUsuario(string user, string pass)
        {
            try
            {
                CashinDB context = new CashinDB(new MySqlConnection("server=localhost;uid=root;database=cashin"));
                context.Log = Console.Out;
                var options = new DbLinq.Data.Linq.DataLoadOptions();
                options.LoadWith<Usuario>(u => u.Pessoa);
                MessageBox.Show("Loading enabled ? "+context.DeferredLoadingEnabled.ToString());

                context.LoadOptions = options;
                var query = (from u in context.Usuario
                             where u.User == user
                             && u.Pass == pass
                             select new Usuario {
                                User = u.User,
                                Pass = u.Pass,
                                Pessoa = u.Pessoa
                             }
                             );
                if (query.Any())
                {                    
                    Usuario usuario = query.Single<Usuario>();                    
                    MessageBox.Show(usuario.Pessoa.Nome);
                    //MainWindow window = new MainWindow(usuario);
                    //window.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
                context.Dispose();
            }
            catch
            {
                MessageBox.Show("Algum problema ocorreu!", "Erro!");
            }            
        }
    }
}
