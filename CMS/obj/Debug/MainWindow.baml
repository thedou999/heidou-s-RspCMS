   M S B A M L   `   `   `  ����>  :CMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CMSCMS  5      %clr-namespace:CMS.Views	CMS.Views  5	      -clr-namespace:CMS.ViewModelCMS.ViewModel  64       CMS.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      localclr-namespace:CMS  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      vclr-namespace:CMS.Views  5	      $vmclr-namespace:CMS.ViewModel  64   $
��1200��5      $	��700��6   ���#2B2c31  � Title  5
      �� *AppData.SystemName+ � DataContext 5      ��    Locator �� Source# [   �� Path$
 Main� � 	Resources 5        
OnChecked1 �� 
TargetName �� TargetProperty W� From	 W� To	 g� Duration
 W� EasingFunction.  (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  OnUnchecked1��%�  &	       &	 �     �� 5   
   .��5      W� $ 
leftBorder��6   $ Width�6A   $	 200X�5      $ 40X�6)   $	 	00:00:0.5D�5      
 5        5      $ EaseOut=�6    5      5      �� 5   
   .��5      W� $ 
leftBorder��6   $ Width�6A   $ 40X�5      $	 200X�6(   $	 	00:00:0.5D�5      
 5        5      $ EaseOut=�6    5       5!      5#       � Triggers 5%      :� 5&   
    :� RoutedEvent$ ToggleButton.Checked��6    :� 
SourceName$ PART_ToggleButton��6:   .[�5'      �� #��[ 6   5(      :� 5)   
   $ ToggleButton.Unchecked��6   $ PART_ToggleButton��6<   .[�5*      �� #��[ 6   5+      .��5/      � .+�50   
   � -   5         �Name$ 	MarkLayer��50       K� ZIndex$	 999��6"   
���   � J� Opacity$	 0.8Q�51   "   $y�Hidden=�52      � 54   
    � ColumnDefinitions 55      �� 56      $
��auto �6#   �� 57      .+�5:      �� -   5         ��Name$ 
leftBorder��5:      ���#2b2c31$��0,0,1,0q�5;       J� Effect 5<      3  -System.Windows.Media.Effects.DropShadowEffect  5=         
BlurRadius$ 10Q�6'      Opacity$	 0.5Q�67      ShadowDepth$ 0Q�5>   '      Color$ Black��67   ._�5A      �  � RowDefinitions 5B      �� 5C      $
��auto �6(   �� 5D      .+�5F      �� $��0��6!   $��	0,15,0,15q�6.    �� Orientation$ 
Horizontal=�5G   !    5H        5I      $ 10Q�6/   $ 1Q�6?   $ 0Q�5J   /   $ Black��6?   .+�5L      �� $��10q�6$     FontAwesome#��[ 5M   $   $��20(�5N   $   ���#297790$	����5O   $   �� 5P      $��10q�6$   $��Center=�60   #��[ 5Q   $   $��20(�5R   $   
�������$��CargoSystem��5S   $   5T      �� 5U      $��1��6!   .+�5V      	� $	��200��6&   $��50��62   $
��Left=�5W   &   $��首页��6A   $��18(�5X   &   
�������  RadioButtonManuStyle#��[ 5Y   &   
 � Tag$	 ��5Z   &   .  (System.Windows.Interactivity.Interaction   Triggers 5[      /  )System.Windows.Interactivity.EventTrigger  5\   "      	EventName$ Checked��61   .  (System.Windows.Interactivity.TriggerBase   Actions. 5]   &   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6<   �� *SelectViewCommand+    CommandParameter  6b   �� ! �� RelativeSource! �� " �� Mode$" FindAncestor=�# �� AncestorType$# RadioButtonL�5^   #   5a      	� 5b      $	��200��6&   $��50��62   $
��Left=�5c   &   $��	出入库��6A   $��18(�5d   &   
�������#��[ 5e   &   $	 ��5f   &    5g        5h   "   $ Checked��61   . 5i   &      6<   �� *SelectViewCommand+  6b   �� ! �� $" FindAncestor=�$# RadioButtonL�5j   #   5l      	� 5m      $	��200��6&   $��50��62   $
��Left=�5n   &   $��物资管理��6A   $��18(�5o   &   
�������#��[ 5p   &   $	 ��5q   &    5r        5s   "   $ Checked��61   . 5t   &      6<   �� *SelectViewCommand+  6b   �� ! �� $" FindAncestor=�$# RadioButtonL�5u   #   5w      	� 5x      $	��200��6&   $��50��62   $
��Left=�5y   &   $��用户管理��6A   $��18(�5z   &   
�������#��[ 5{   &   $	 ��5|   &    5}        5~   "   $ Checked��61   . 5   &      6<   �� *SelectViewCommand+  6b   �� ! �� $" FindAncestor=�$# RadioButtonL�5�   #   5�      	� 5�      $	��200��6&   $��50��62   $
��Left=�5�   &   $��类型设置��6A   $��18(�5�   &   
�������#��[ 5�   &   $	 ��5�   &    5�        5�   "   $ Checked��61   . 5�   &      6<   �� *SelectViewCommand+  6b   �� ! �� $" FindAncestor=�$# RadioButtonL�5�   #   5�      	� 5�      $	��200��6&   $��50��62   $
��Left=�5�   &   $��单位设置��6A   $��18(�5�   &   
�������#��[ 5�   &   $	 ��5�   &    5�        5�   "   $ Checked��61   . 5�   &      6<   �� *SelectViewCommand+  6b   �� ! �� $" FindAncestor=�$# RadioButtonL�5�   #   5�      5�      5�      5�      � 5�      $��1��6   .+�5�      d� -   5        $ d�Name$$ PART_ToggleButton��5�      $��10q�6:   $
��Left=�5�      $	��Top=�6:   $	 999��5�      $	����62   #��[ 5�      $��20(�5�      
�������  ToggleButtonStyle#���  5�      �� 5�      -   5        % ��Name$% PART_Container��5�   !   5�      5�      5�      5�      