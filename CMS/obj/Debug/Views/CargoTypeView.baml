   M S B A M L   `   `   `  ����>  :CMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CMSCMS  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fZ=clr-namespace:MahApps.Metro.Converters;assembly=MahApps.MetroMahApps.Metro.Converters 5      %clr-namespace:CMS.Views	CMS.Views  5          CMS.Views.CargoTypeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      !cmsclr-namespace:CMS     5      T
converters=clr-namespace:MahApps.Metro.Converters;assembly=MahApps.Metro     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      #localclr-namespace:CMS.Views  5      6mah,http://metro.mahapps.com/winfx/xaml/controls  5	      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5
      
������   � DataContext  5      ��    Locator �� Source# [   �� Path$ 	CargoType� � 	Resources 5        TextBlockStyle �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value  TextBlockStyleInline��%�  &	       &	 Y    �� 5   
   " ��6'    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$	 26(�61   �� 5       �@�Cursor$
	 Hand��6/   �� 5       � ��
	 �����63   5      P� 5       �@J�IsMouseOver .  . �5      ��  � ��$	 24(�61   �� 5       � ��
	 �����63   5      5      �� 5   
   " ��6-    5      P� 5       �@J�IsMouseOver . . �5       ��  � ��$	 26(�61   �� 5!       �@�Cursor$
	 Hand��6/   �� 5"       � ��
	 �����63   5#      P� 5$       �@J�IsMouseOver .  . �5%      ��  � ��$	 24(�61   �� 5&       � ��
	 �   �63   5'      5)      5*      .��5,      � 
 � RowDefinitions
 5-   
   �� 5.      $��60 �6   �� 5/      .+�52   
   �� ���#383839$��0,0,0,1q�6'   ._�53      �� $��Center=�6   $��Center=�65   $��24(�54      
�������$��物资类型定义��55      56      �� 57   
   $��0,0,25,0q�6   $��Right=�6&   $��Center=�58      
������   FontAwesome#���  59      #���  5:      $	����5;      .  (System.Windows.Interactivity.Interaction   Triggers 5<      /  )System.Windows.Interactivity.EventTrigger  5=         	EventName$ MouseUp��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5>      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *OpenAddCargoTypeWindow+5?      5A      � 5C   
   $��1��6   
 5D      �� 5E      �� 5F      $	��100 �6    .+�5I      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     CanUserAddRows .     MinRowHeight$ 30Q�5K      ��5J      �� *
CargoTypes+   Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Id+6@     5N      $ 物资编号��6B    6)   �� *Name+6B     5O      $ 备注��6A    6)   �� *Tag+6A     5P      $ 插入日期��6H    6)   �� *
InsertDate+6H     5Q      $ 	登录员��6H    6)   �� *
MemberName+6H   4	  .System.Windows.Controls.DataGridTemplateColumn	  5R      $ 操作��6-    	  CellTemplate 5S      �� 5T      .R�5U   "   �� $��0,0,10,0q�6,   $��Right=�6>   $��Center=�5V   ,   
������ #���  5W   ,   #���  5X   ,   $	����5Y   ,    5Z   &     5[   *   $ MouseUp��69   . 5\   .      6D   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ local:CargoTypeViewL�$) #DataContext.DeleteCargoTypesCommand�   CommandParameter 6�   �� 5]   +   5_   #   5`      5b      5d      �� 5g      $��1��6   $��5q�6&    �� Orientation$ 
Horizontal=�5h      .+�5i      �� $��18(�6   
�������$��	统计：��5j      �� 5k      $��18(�6   
���������5l      �� *CargoTypes.Count+5m      5n      5r      5s      