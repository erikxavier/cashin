   M S B A M L   `   `   `  ����A  =CashIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CashIn.ConvertersCashIn.Converters  5          CashIn.cadOrcamento   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6
convertersclr-namespace:CashIn.Converters     5      -   5          � 	Resources  5	      %  CashIn.Converters.DecimalToReal   realConverter��%   &	          5
   
   6#   5      .��5      � -   5        $��mainGrid��5      .+�5   
   �� -   5        $��	cbCliente��5   �    �� DisplayMemberPath$ Pessoa.Nome��65   $��25��6U   $
��Left=�6a   $��	24,39,0,0q�6|   $	��Top=�6�   $	��590��6�    �� SelectedValue 6   �� *	Cliente+6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dtData��5   m   $��25��63   $
��Left=�6?   $��	24,96,0,0q�6Z   $	��Top=�6{   $	��115��6�      SelectedDate 6   �� *Data+6�     5   
   -   5        $��
dtValidade��5   s   $��25��67   $��Right=�6C   $��
0,96,423,0q�6_   $	��Top=�6�   $	��115��6�    6   �� *
Validade+6�   �� 5   
   -   5        $��label1��5   \   $��Cliente��6   $��28��6"   $
��Left=�6.   $��	24,15,0,0q�6I   $	��Top=�6j   �� 5   
   -   5        $��label2��5   Y   $
��Data��6   $��28��6   $
��Left=�6+   $��	24,70,0,0q�6F   $	��Top=�6g   �� 5   
   -   5        $��label3��5   ^   $��Validade��6   $��28��6#   $
��Left=�6/   $��
152,70,0,0q�6J   $	��Top=�6l   �� 5   
   -	   5        $��label4��5   h   $��Itens do Orcamento��6   $��28��6-   $
��Left=�69   $��
24,127,0,0q�6T   $	��Top=�6v   &   System.Windows.Controls.DataGrid  5   
   -
   5        $��	gridItens��5   k      AutoGenerateColumns .  $	��200��6/   $
��Left=�6<   $��
28,156,0,0q�6W   $	��Top=�6|   $	��586��6�      CanUserResizeColumns .     CanUserSortColumns .     CanUserReorderColumns .     CanUserAddRows . 	   CanUserDeleteRows	 . 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6&      Header$
 Item��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *Nome+  5      $	 320 6%   $ 	Descricao��61    6D   �� *	Descricao+  5      $ 80 6%   $ Valor��60    6?   �� *Valor+ �� 	Converter# [  5      �� 5   
   -   5        $��label5��5   b   $��Itens Comuns��6   $��28��6'   $
��Left=�63   $��
273,70,0,0q�6N   $	��Top=�6p   �� 5   
   -   5        $��cbItensPadrao��5   l   $ 	Descricao��6   $��23��61   $
��Left=�6=   $��
273,98,0,0q�6X   $	��Top=�6�   $	��276��6�   �� 5   
   -   5        $��btnItensPadrao��5   `   $��	Adicionar��6   $��23��6%   $
��Left=�61   $��
555,98,0,0q�6L   $	��Top=�6v   $��59��6�   6�   �� 5   
   -   5        $��	btnSalvar��5   ^   $��Salvar��6   $��23��6"   $
��Left=�6.   $��539,384,0,0q�6I   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5        $��label6��5   \   $��Total��6   $��28��6    $
��Left=�6,   $��497,357,0,0q�6G   $	��Top=�6j   �� 5    
   -   5        $��lbTotal��5    �   $��28��6S   $
��Left=�6_   $��539,357,0,0q�6z   $	��Top=�6�   $��75��6�   ��6   �� *Total+# [  6�   5!      5"      