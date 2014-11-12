﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
	// comentário erik

    //sbruble
    public partial class MainWindow : Window
    {
        public Usuario UsuarioLogado { get; set; }

        public MainWindow(Usuario user)
        {
            InitializeComponent();
            UsuarioLogado = user;
            this.Title = "CashIn - Logado como " + user.Pessoa.Nome;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //dataGrid1.ItemsSource = UsuarioLogado.Orcamento.ToList();
            //Orcamento orc = (Orcamento)dataGrid1.SelectedItem;            
        }

        private void tabCadPessoa(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tabControl1.Items.Add(tab);
            tab.Content = new cadPessoa(tab);
        }
    }
}
