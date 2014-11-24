using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace CashIn
{
    public class ControleTabs
    {
        public MainWindow App { get; set; }
        public TabControl ControleTab { get; set; }


        public ControleTabs(MainWindow app, TabControl control)
        {
            App = app;
            ControleTab = control;
        }

        public TabItem newTab()
        {
            TabItem tab = new TabItem();
            ControleTab.Items.Add(tab);
            tab.IsSelected = true;
            return tab;
        }
        public void tabOrcamento()
        {
            TabItem tab = newTab();
            tab.Header = "Orçamento";
            tab.Content = new cadOrcamento(tab, this);
        }


        public void tabDash()
        {
            TabItem tab = newTab();
            tab.Header = "Principal";
            tab.Content = new dashboard(tab, this);
        }

        public void tabPessoa()
        {
            TabItem tab = newTab();
            tab.Header = "Pessoa";
            tab.Content = new cadPessoa(tab, this);
        }
        public void closeTab(TabItem tab)
        {
            ControleTab.Items.Remove(tab);
        }
    }
}