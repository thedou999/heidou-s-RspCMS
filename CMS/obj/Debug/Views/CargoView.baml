   M S B A M L   `   `   `  ����>  :CMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CMS.Views	CMS.Views  5      clr-namespace:ModelsModels  64       CMS.Views.CargoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      #localclr-namespace:CMS.Views  5      mclr-namespace:Models  64   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � DataContext  5	      ��    Locator �� Source# [   �� Path$ Cargo� � 	Resources 5        TextBlockStyle �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value  TextBlockStyleInline��%�  &	       &	 Y    �� 5   
   " ��6'    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$	 26(�61   �� 5       �@�Cursor$
	 Hand��6/   �� 5       � ��
	 �����63   5      P� 5       �@J�IsMouseOver .  . �5      ��  � ��$	 24(�61   �� 5       � ��
	 �����63   5      5      �� 5   
   " ��6-    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$	 26(�61   �� 5       �@�Cursor$
	 Hand��6/   �� 5       � ��
	 �����63   5       P� 5!       �@J�IsMouseOver .  . �5"      ��  � ��$	 24(�61   �� 5#       � ��
	 �   �63   5$      5&      5'      .��5*      � 
 � RowDefinitions
 5+   
   �� 5,      $��60 �6   �� 5-      .+�50   
   �� ���#383839$��0,0,0,1q�6'   ._�51      �� $��Center=�6   $��Center=�65   $��24(�52      
�������$��物资管理��53      54      �� 55   
   $��0,0,25,0q�6   $��Right=�6&   $��Center=�56      
������   FontAwesome#���  57      #���  58      $	����59      .  (System.Windows.Interactivity.Interaction   Triggers 5:      /  )System.Windows.Interactivity.EventTrigger  5;         	EventName$ MouseUp��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5<      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *OpenAddCargoWindow+5=      5?      � 5A   
   $��1��6   
 5B      �� 5C      �� 5D      $	��100 �6    .+�5I      &   System.Windows.Controls.DataGrid  $��0��6      AutoGenerateColumns .     CanUserAddRows .     MinRowHeight$ 30Q�5L      ��5K      �� *Cargos+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5M      0  *System.Windows.Controls.DataGridTextColumn  5N      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Id+6@     5O      $ 物资名称��6B    6)   �� *Name+6B   4	  .System.Windows.Controls.DataGridComboBoxColumn	  5P      $ 物资类型��6-    	  ElementStyle 5Q      �� 5R      " ��6$   .�5S   "   ��  � ��	 6@   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ local:CargoViewL�$ DataContext.CargoTypes��� 5T   "    �@��SelectedValuePath$
	 Name��6F   �� 5U   "    �@��DisplayMemberPath$
	 Name��6F   �� 5V   "    �@��SelectedValue	 6B   �� *
TypeName+5W       	  EditingElementStyle 5Y      �� 5Z      " ��6$   .�5[   "   ��  � ��	 6@   ��  �� $ FindAncestor=�$ local:CargoViewL�$ DataContext.CargoTypes��� 5\   "    �@��SelectedValuePath$
	 Name��6F   �� 5]   "    �@��DisplayMemberPath$
	 Name��6F   �� 5^   "    �@��SelectedValue	 6B   �� *
TypeName+$ TwoWay=�$ PropertyChanged=�5_      5a        5b      $ 数量��6v    6)   �� *Number+$ TwoWay=�$ PropertyChanged=�6v     5c      $ 单价��6u    6)   �� *Price+$ TwoWay=�$ PropertyChanged=�6u   	  5d      $ 单位��6-    5e      �� 5f      " ��6$   .�5g   "   ��  � ��	 6@   ��  �� $ FindAncestor=�$ local:CargoViewL�$ DataContext.UnitTypes��� 5h   "    �@��SelectedValuePath$
	 Name��6F   �� 5i   "    �@��DisplayMemberPath$
	 Name��6F   �� 5j   "    �@��SelectedValue	 6B   �� *
UnitName+5k       5m      �� 5n      " ��6$   .�5o   "   ��  � ��	 6@   ��  �� $ FindAncestor=�$ local:CargoViewL�$ DataContext.UnitTypes��� 5p   "    �@��SelectedValuePath$
	 Name��6F   �� 5q   "    �@��DisplayMemberPath$
	 Name��6F   �� 5r   "    �@��SelectedValue	 6B   �� *
UnitName+$ TwoWay=�$ PropertyChanged=�5s      5u        5v      $ 备注��6s    6)   �� *Tag+$ TwoWay=�$ PropertyChanged=�6s     5w      $ 插入日期��6H    6)   �� *
InsertDate+6H     5x      $ 	登录员��6H    6)   �� *
MemberName+6H   4
  .System.Windows.Controls.DataGridTemplateColumn
  5z      $ 操作��6-    
  CellTemplate 5{      �� 5|      .R�5}   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5~   &   �� $��0,0,10,0q�60   $��Right=�6B   $��Center=�5   0   
������ #���  5�   0   #���  5�   0   $	����5�   0    5�   *     5�   .   $ MouseUp��6=   . 5�   2      6H   ��  �� $ FindAncestor=�$ local:CargoViewL�$" DataContext.EditCargoCommand�   CommandParameter 6�   �� 5�   /   5�   '   �� 5�   &   $��0,0,10,0q�60   $��Right=�6B   $��Center=�5�   0   
������ #���  5�   0   #���  5�   0   $	����5�   0    5�   *     5�   .   $ MouseUp��6=   . 5�   2      6H   ��  �� $ FindAncestor=�$ local:CargoViewL�$- 'DataContext.OpenInputCargoWindowCommand� 6�   �� 5�   /   5�   '   �� 5�   &   $��0,0,10,0q�60   $��Right=�6B   $��Center=�5�   0   
������ #���  5�   0   #���  5�   0   $	����5�   0    5�   *     5�   .   $ MouseUp��6=   . 5�   2      6H   ��  �� $ FindAncestor=�$ local:CargoViewL�$. (DataContext.OpenOutputCargoWindowCommand� 6�   �� 5�   /   5�   '   �� 5�   &   $��0,0,10,0q�60   $��Right=�6B   $��Center=�5�   0   
������ #���  5�   0   #���  5�   0   $	����5�   0    5�   *     5�   .   $ MouseUp��6=   . 5�   2      6H   ��  �� $ FindAncestor=�$ local:CargoViewL�$$ DataContext.DeleteCargoCommand� 6�   �� 5�   /   5�   '   5�   #   5�      5�      5�      �� 5�      $��1��6   $ 
Horizontal=�6&   .+�5�      �� $��18(�6   
�������$��	统计：��5�      �� 5�      $��18(�6   
���������5�      �� *Cargos.Count+5�      5�      5�      5�      