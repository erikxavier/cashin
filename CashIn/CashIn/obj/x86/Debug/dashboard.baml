   M S B A M L   `   `   `  ����A  =CashIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CashIn.ConvertersCashIn.Converters  5          CashIn.dashboard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6
convertersclr-namespace:CashIn.Converters     5        � 	Resources  5	      %  CashIn.Converters.DecimalToReal   realConverter��%   &	          5
   
   6#   5      .��5      � -   5        $	��403��5       .+�5   
   �� -   5        $��label1��5   t   $(��"Orçamentos aguardando aprovação��6   $��28��6:   $
��Left=�6F   $��	22,21,0,0q�6a   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��gridOrcAguardando��5   �      
IsReadOnly .    SelectionUnit$ FullRow=�6%      SelectionMode$ Single=�6=      AutoGenerateColumns .  $	��667��6p   $	��296��6|   $
��Left=�6�   $��	22,44,0,0q�6�   $	��Top=�6�   {�.    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6%      Header$ Cliente��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Cliente.Pessoa.Nome+  5      $
 auto 6%   $
 Data��62    6@   �� *Data+	 �� StringFormat$	 {0:dd/MM/yyyy}��  5      $
 auto 6%   $ Validade��62    6D   �� *
Validade+$	 {0:dd/MM/yyyy}��  5      $ Valor Total��6%    6:   �� *Total+
 �� 	Converter#
 [     RowDetailsTemplate 5      �� 5      .R�5         .  .  ��6M   �� *Itensorcamento+ 5        5      $
 Item��61    6?   �� *Nome+  5      $ Valor��61    6@   �� *Valor+#
 [  5      5      5      5       5!      