   M S B A M L   `   `   `  ����J  FDesktopApp_3935, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DesktopApp_3935DesktopApp_3935  5   	        DesktopApp_3935.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DesktopApp_3935     5   	   
������   � WindowStyle$
  None=�5	   	    � AllowsTransparency$
 True��5
   	    � Title$ Main Dashboard��5   	   $	��500��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � DataContext 5      "   DesktopApp_3935.MainWindowVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1.45* �6   6/   �� 5      $��1* �6   6,   .+�5   
   ��  �� CornerRadius$ 
50 0 00 50��6   
����� �._�5      � .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� .+�5      �� $��Student List��6$   $��Center=�6:   $��Center=�6U   $��20(�6r   $
��Bold"�6�    �� Padding$ 6 ,  6, 6, 6q�6�   $
��Wrap=�6�   
����p��$��9q�6�   �� 5      ��6#   �� *
Students+	 �� SelectedItem	 6D   �� *SelectedStudent+
 �� UpdateSourceTrigger$
 PropertyChanged=���5      �� 5   "   .R�5   &   �� 
���W�.�$��2q�6D   $ 8��6X   $	��400��6i   ._�5   *   �� $ 
Horizontal=�65   .+�5   .   �� $��50��6P   $��50��6[   ��64   �� *
ImageURL+6[   �� 5    .   $ 10q�6S   $��10q�6`   $��50��6l   ��68   �� *	FirstName+6l   �� 5!   .   $ 10q�6R   $��10q�6_   $	��100��6k   ��68   �� *
LastName+6k   �� 5"   .   $ 10q�6M   $��10q�6Z   $��50��6f   ��68   �� *Age+6f   �� 5#   .   $ 10q�6M   $��10q�6Z   $��50��6f   ��68   �� *DoB+6f   �� 5$   .   $ 10q�6R   $��10q�6_   $��50��6k   ��68   �� *
GPAValue+6k   5%   +   5&   '   5'   #   5)      5+      5,      5-      5.      �� 50   
   $ 	0 50 50 0��6   $��1��6+   
�����f�._�51      �� .+�52      ��    
mainButton#��[  6   $	��Add��53      $��	5 65 5 15q�54      ��52   =   �� *AddStudentCommand+54      �� 55      #��[  6   $
��Edit��56      ��55   >   �� *EditStudentCommand+56      �� 59      #��[  6   $��Delete��5:      ��59   >   �� *DeleteStudentCommand+5:      �� 5<        
exitButton#��[ 6   $��X��5=      ��5<   >   �� *ExitCommand+5=      5A      5B      5F      5G      