   M S B A M L   `   `   `  ����>  :CMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CMS.WindowsCMS.Windows  5      "    CMS.Windows.InputCargoWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:CMS.Windows     5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  InputCargoWindow��5      $	��800��6+   $	��450��5	       � WindowStartupLocation$ CenterScreen=�5       � DataContext 5
      ��    Locator �� Source# [   �� Path$ InputOrOutputCargo�.��5      � $��100,50q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�5      $��36(�6/   $��物资入库��5      �� 5   
   $��1��6   $��10,0,0,0q�6"   $��Center=�5       �� Orientation$ 
Horizontal=�60   .+�5      �� $��80��6   $��50,0,0,0q�6#   $��18(�5      $��物资名称��6&   �� 5      $	��200��6   $��10,0,0,0q�6$   {�.  ��5      �� *
Cargo.Name+5       �� 5!   
   $��2��6   $��10,0,0,0q�6"   $��Center=�5"      $ 
Horizontal=�60   .+�5#      �� $��80��6   $��50,0,0,0q�6#   $��18(�5$      $��数量��6&   �� 5%      $	��200��6   $��10,0,0,0q�6"   ��5&      �� *Record.Number+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5'      $
��auto��6   $��10,0,0,0q�6%   $��Center=�5(      $��当前库存数量为��63   �� 5)      $
��auto��6   $��2,0,0,0q�6%   $��Center=�5*      ��5+      �� *Cargo.Number+5,      �� 5-   
   $��3��6   $��10,0,0,0q�6"   $��Center=�5.      $ 
Horizontal=�60   .+�5/      �� $��80��6   $��50,0,0,0q�6#   $��18(�50      $��备注��6&   �� 51      $	��200��6   $��10,0,0,0q�6"   ��52      �� *
Record.Tag+$ TwoWay=�$ PropertyChanged=�53      �� 54   
   $��4��6   $��80,0,0,0q�6"   $��Center=�55      $ 
Horizontal=�60   .+�56      �� $��80��6   $��操作��59      ��57      �� *InputCargoCommand+��58      �� 	 �� RelativeSource	 �� 
 �� Mode$
 FindAncestor=� �� AncestorType$ mah:MetroWindowL�59      �� 5:      $��80��6   $��80,0,0,0q�6    $��取消��5=      ��5;      �� *CloseCommand+��5<      �� 	 �� $
 FindAncestor=�$ mah:MetroWindowL�5=      5>      5B      5C      