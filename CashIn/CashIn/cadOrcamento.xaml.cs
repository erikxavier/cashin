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
using System.ComponentModel;

namespace CashIn
{
    /// <summary>
    /// Interaction logic for cadOrcamento.xaml
    /// </summary>
    public partial class cadOrcamento : UserControl
    {
        public ControleTabs Controle;
        public TabItem Tab { get; set; }
        public MainWindow App { get; set; }
        public Orcamento Orcamento;       
        public List<Itensorcamento> ItensOrcamento;

        public decimal Total
        {
            get
            {
                return ItensOrcamento.Sum(i => (decimal)i.Valor);                
            }
        }

        CashinDB DB = new CashinDB();

        public cadOrcamento()
        {
            InitializeComponent();
        }

        public cadOrcamento(TabItem tab, ControleTabs controle)
        {
            InitializeComponent();
            this.Controle = controle;
            Tab = tab;
            App = controle.App;      
        }

        public void novoOrcamento()
        {
            Orcamento = new Orcamento();
            gridItens.ItemsSource = Orcamento.Itensorcamento;
            Orcamento.Usuario = App.UsuarioLogado;
            Orcamento.Data = System.DateTime.Now;
            Orcamento.Validade = DateTime.Now.AddMonths(1);
            mainGrid.DataContext = Orcamento;                        
            cbCliente.ItemsSource = DB.Cliente;
            cbItensPadrao.ItemsSource = App.UsuarioLogado.Itenspadrao;            
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Orcamento.InsertOnSubmit(Orcamento);
                DB.SubmitChanges();
                MessageBox.Show("Orcamento Adicionado com Sucesso!", "Aviso");
                zeraCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema ao Adicionar");                
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void mainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            novoOrcamento();
        }

        private void btnItensPadrao_Click(object sender, RoutedEventArgs e)
        {
            Itenspadrao item = (Itenspadrao)cbItensPadrao.SelectedItem;
            Itensorcamento novoItem = new Itensorcamento();
            novoItem.Nome = item.Descricao;
            novoItem.Valor = item.Valor;
            ItensOrcamento.Add(
                novoItem
            );
            gridItens.Items.Refresh();
            //gridItens.ItemsSource = Orcamento.Itensorcamento; 
        }

        private void zeraCampos()
        {
            cbCliente.SelectedIndex = -1;
            cbItensPadrao.SelectedItem = -1;
            ItensOrcamento = null;
            gridItens.ItemsSource = ItensOrcamento;
            dtData.SelectedDate = null;
            dtValidade.SelectedDate = null;
        }

        private void gridItens_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void gridItens_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gridItens_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            
        }
    }
}
