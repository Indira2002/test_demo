   M S B A M L   `   `   `  ����C  ?ToursApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToursAppToursApp  5          ToursApp.HotelsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:ToursApp     5      -   5          N� Title$  
HotelsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��188* �6   �� 5      $	��37* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridHotels��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6V     5      $ CuponNum��6%   $	 250 6U    67   �� *	CouponNum+6c     5      $
 Data��6%   $	 250 6L    63   �� *Data+6Z     5      $
 Cost��6%   $	 250 6L    63   �� *Cost+6Z     5      $ Diagnos��6%   $	 250 6V    66   �� *Diagno.Name+6d     5      $ Doctor��6%   $	 250 6U    65   �� *Doctor1.Fio+6c     5      $ Patient��6%   $	 250 6W    66   �� *Patient1.Fio+6e   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $��BtnEdit��6i   -   5        $ ��Редактировать��5   Q   ��6%   �� *DailyReception+6�   5      5      5!      �� 5"   
   -   5        $��BtnAdd��5"   L   $��Добавить��6   $��1��6$   $
��Left=�61   $
��Auto��6o   $��489,26,0,25.6q�6}   $	��140��6�   6�   �� 5#   
   -   5        $��	BtnDelete��5#   L   $��Удалить��6   $��1��6#   $��Right=�60   $
��Auto��6u   $��0,26,10,25.6q�6�   $	��140��6�   6�   �� 5$   
   -   5        $��checkbox��5$      $$��Фильтр по врачам��6#   $
��Left=�6>   $��	32,30,0,0q�6Y   $��1��6l   $	��Top=�6y   $��15��6�   $	��137��6�   6�   �� 5%   
   -   5        $��combofilter��5%      
 �� DisplayMemberPath$	
 Fio��6�   $
��Left=�6�   $��
198,26,0,0q�6�   $��1��6�   $	��Top=�6�   $	��209��6�    �� SelectedIndex$ 0��6+   �� SelectedItem 6'   �� *	Doctor1+{�6H   ��  �� ElementName$ checkbox�� �� Path$ 	IsChecked�6+  5&      5'      