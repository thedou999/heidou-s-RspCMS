   M S B A M L   `   `   `  ����>  :CMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CMS.Views	CMS.Views  5      /clr-namespace:CMS.ConvertersCMS.Converters  5	          CMS.Views.RecordView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      #localclr-namespace:CMS.Views  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $cclr-namespace:CMS.Converters  5	        � DataContext  5      ��    Locator �� Source# [   �� Path$ Record� � 	Resources 5        TextBlockStyle �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value  TextBlockStyleInline'   !CMS.Converters.InOrOutBitToString  InOrOutBitToStringConvert��%�  &	       &	 Y    &	 �    �� 5   
   " ��6'    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$	 26(�61   �� 5       �@�Cursor$
	 Hand��6/   �� 5       � ��
	 �����63   5      P� 5       �@J�IsMouseOver .  . �5      ��  � ��$	 24(�61   �� 5       � ��
	 �����63   5      5      �� 5   
   " ��6-    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��$	 26(�61   �� 5       �@�Cursor$
	 Hand��6/   �� 5        � ��
	 �����63   5!      P� 5"       �@J�IsMouseOver .  . �5#      ��  � ��$	 24(�61   �� 5$       � ��
	 �   �63   5%      5'        5)   
   6   5*      .��5-      � 
 � RowDefinitions
 5.   
   �� 5/      $��60 �6   �� 50      .+�53   
   �� ���#383839$��0,0,0,1q�6'   ._�54      �� $��Center=�6   $��Center=�65   $��24(�55      
�������$��出入库管理��56      57      � 5:   
   $��1��6   
 5;      �� 5<      �� 5=      $	��100 �6    .+�5@      &   System.Windows.Controls.DataGrid  $��0��6      AutoGenerateColumns .     CanUserAddRows .     MinRowHeight$ 30Q�5C      ��5B      �� *	Records+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Id+6@     5F      $ 	出入库��6~    6)   �� *
InOrOutBit+ �� 	Converter# [ 6~     5G      $ 物资名称��6G    6)   �� *	CargoName+6G     5H      $ 数量��6v    6)   �� *Number+$ TwoWay=�$ PropertyChanged=�6v     5I      $ 备注��6s    6)   �� *Tag+$ TwoWay=�$ PropertyChanged=�6s     5J      $ 插入日期��6H    6)   �� *
InsertDate+6H     5K      $ 	登录员��6H    6)   �� *
MemberName+6H   4  .System.Windows.Controls.DataGridTemplateColumn  5L      $ 操作��6-      CellTemplate 5M      �� 5N      .R�5O   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5S   &   �� $��0,0,10,0q�60   $��Right=�6B   $��Center=�5T   0   
������   FontAwesome#���  5U   0   #���  5V   0   $	����5W   0   .  (System.Windows.Interactivity.Interaction   Triggers 5X   *   /  )System.Windows.Interactivity.EventTrigger  5Y   .      	EventName$ MouseUp��6=   .	  (System.Windows.Interactivity.TriggerBase 	  Actions. 5Z   2   6
  0System.Windows.Interactivity.InvokeCommandAction
   
  Command 6H   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ local:RecordViewL�$% DataContext.DeleteRecordCommand� 
  CommandParameter 6�   �� 5[   /   5]   '   5^   #   5_      5a      5c      �� 5e      $��1��6   $ 
Horizontal=�6&   .+�5f      �� $��18(�6   
�������$��	统计：��5g      �� 5h      $��18(�6   
���������5i      �� *Records.Count+5j      5k      5o      5p      