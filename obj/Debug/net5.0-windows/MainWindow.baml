   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  $��2��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6B      AutoGenerateColumns$ False��6R   ��6$   �� *Users+ �� SelectedItem 6n   �� *User+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Login+  5      $ Пароль��6%    65   �� *
Password+5      �� 5   
   $��1��62   $��Center=�6B   	 � DataContext	 6   �� *User+.+�5      �� 
���   �$��0 0 0 1q�6)   ._�5      �� $	��CUD��6   5      �� 5      $��
Логин��6   �� 5      ��6   �� *Login+�� 5      $��Пароль��6   �� 5      ��6   �� *
Password+5       �� 5"   
   $��1��6   $��1��6%   .+�5#      �� $��Изменить��6   ��6(   �� *UpdateCommand+�� 5$      $)��#Новый пользователь��6   ��62   �� *CreateCommand+�� 5%      $��Добавить��6   ��6(   �� *
AddCommand+�� 5&      $��Удалить��6   ��6'   �� *DeleteCommand+5'      5)      5*      