   M S B A M L   `   `   `  ����  Center_Maneger1    +Center_Maneger.UesrControls.Prices_Settings   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5         bguc#��[  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��0.4* �6   �� 5      $	��.6* �6   .+�5   
   �� $��0��6   .+�5      �� .+�5      �� $	��0 5q�6   $	��150��6&     	Whitetext#��[ 62     hoverbtn#��[ 6[    �� CornerRadius$ 7��6�   $��5q�6�   ._�5      ��   TextBlockStyle#��[ 6    $!��أسعار الزيارات��6H   $��18(�6^   $
��Bold"�6l     text#��[ 6~   $��Center=�6�   5      5      �� 5      $
��0 35q�6    �� Orientation$ 
Horizontal=�6'   $��Right=�6@   $��RightToLeft=�6\   .+�5      �� #��[ 6   $��بداية الفترة: ��6D   $��Right=�6[   $��Center=�6r   $��16(�5      $
��Bold"�6*   $
��20 0q�6<   �� 5      -   5        $��start_date_price_input��5   B     RoundedTextBox#��[ 6   $��70��6`   $��Right=�6l   $��16(�5      $	��2 0q�6)   �� 5      #��[ 6   $��نهاية الفترة:��6D   $��Center=�6Z   $��16(�5      $
��Bold"�6*   $
��20 0q�6<   �� 5      -   5        $��end_date_price_input��5   B   #��[ 6   $��70��6^   $��Right=�6j   $��16(�5       $	��2 0q�6(   �� 5"      #��[ 6   $��تكلفة الفترة:��6D   $��Center=�6Z   $��16(�5#      $
��Bold"�6*   $
��20 0q�6<   �� 5%      -   5        $��cost_price_input��5%   B   #��[ 6   $	��150��6Z   $��Right=�6g   $��16(�5&      $	��2 0q�6)   5(      �� 5*      $ 
Horizontal=�6   $��Center=�62   .+�5+      �� -   5          
Roundedbtn#��[ 5+      $��0q�6=   $	��100��6m   $��40��6y   $��16(�6�   $
��Bold"�6�   ���	#00DDDDDD.��5,      �� $ 
Horizontal=�6!   .+�5-      �� $��/img/trash.png��6    $��40��68   $��35��6C   �� 5.      $��حذف��6$   $��Center=�6/   5/      50      �� 51      -   5        #��[ 51      $��0q�6=   $	��100��6k   $��40��6w   $
��70 0q�6�   $��16(�6�   $
��Bold"�6�   ���	#00DDDDDD.��52      �� $ 
Horizontal=�6!   .+�53      �� $��/img/save.png��6    $��40��67   $��35��6B   �� 54      $��حفظ��6$   $��Center=�6/   55      56      �� 57      -   5        #��[ 57      $��0q�6=   $	��100��6Q   $��40��6]   $��16(�6�   $
��Bold"�6�   ���	#00DDDDDD.��58      �� $ 
Horizontal=�6!   .+�59      �� $��/img/correct.png��6    $��40��6:   $��35��6E   �� 5:      $��جديد��6$   $��Center=�60   5;      5<      5=      5?      &   System.Windows.Controls.DataGrid  5@   
   -   5          Name$ 	data_grid��5@   �   $��RightToLeft=�6�      
IsReadOnly . $��16(�6�   $��1��6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 6�      Columns 5A      4  .System.Windows.Controls.DataGridTemplateColumn  5B      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6)      
IsReadOnly . 	   Width$	 40 6F   
   CellTemplate
 5C      �� 5D      .R�5E      �� ��6(   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL� �� Path$ Header�5F      5H      5K      5L      5M      