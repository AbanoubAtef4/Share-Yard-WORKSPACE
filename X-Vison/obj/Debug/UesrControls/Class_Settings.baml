   M S B A M L   `   `   `  ����I  ECenter_Maneger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Center_Maneger.UesrControlsCenter_Maneger.UesrControls  5      0    *Center_Maneger.UesrControls.Class_Settings   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Center_Maneger.UesrControls     5         bguc#��[  5	      .��5
      �   � RowDefinitions  5   
   �� 5      $
��0.4* �6   �� 5      $	��.6* �6   .+�5   
   �� $��0��6   .+�5      �� .+�5      �� $	��0 5q�6   $	��150��6&     	Whitetext#��[ 62     hoverbtn#��[ 6[    �� CornerRadius$ 7��6�   $��5q�6�   ._�5      ��   TextBlockStyle#��[ 6    $��بيانات الغرف��6H   $��18(�6\   $
��Bold"�6j     text#��[ 6|   $��Center=�6�   5      5      �� 5      $
��0 35q�6    �� Orientation$ 
Horizontal=�6'   $��Right=�6@   $��RightToLeft=�6\   .+�5      �� #��[ 6   $��اسم الغرفة : ��6D   $��Right=�6Z   $��Center=�6q   $��16(�5      $
��Bold"�6*   $
��20 0q�6<   �� 5      -   5        $��name_of_class_input��5   B     RoundedTextBox#��[ 6   $	��200��6]   $��Right=�6j   $��16(�5      $	��2 0q�6)   �� 5      #��[ 6   $��تكلفة الساعة :��6D   $��Center=�6[   $��16(�5      $
��Bold"�6*   $
��20 0q�6<   �� 5       -   5        $��cost_of_class_input��5    B   #��[ 6   $	��200��6]   $��Right=�6j   $��16(�5!      $	��2 0q�6)   5$      �� 5&      $ 
Horizontal=�6   $��Center=�63   .+�5'      �� -   5          
Roundedbtn#��[ 5'      $��0q�6=   $	��100��6m   $��40��6y   $��16(�6�   $
��Bold"�6�   ���	#00DDDDDD.��5(      �� $ 
Horizontal=�6!   .+�5)      �� $��/img/trash.png��6    $��40��68   $��35��6C   �� 5*      $��حذف��6$   $��Center=�6/   5+      5,      �� 5-      -   5        #��[ 5-      $��0q�6=   $	��100��6k   $��40��6w   $
��70 0q�6�   $��16(�6�   $
��Bold"�6�   ���	#00DDDDDD.��5.      �� $ 
Horizontal=�6!   .+�5/      �� $��/img/save.png��6    $��40��67   $��35��6B   �� 50      $��حفظ��6$   $��Center=�6/   51      52      �� 53      -   5        #��[ 53      $��0q�6=   $	��100��6Q   $��40��6]   $��16(�6�   $
��Bold"�6�   ���	#00DDDDDD.��54      �� $ 
Horizontal=�6!   .+�55      �� $��/img/correct.png��6    $��40��6:   $��35��6E   �� 56      $��جديد��6$   $��Center=�60   57      58      59      5;      &   System.Windows.Controls.DataGrid  5<   
   -   5          Name$ 	data_grid��5=   O   $��RightToLeft=�6      
IsReadOnly . $��16(�6A   $��1��6c      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 6p      Columns 5>      4  .System.Windows.Controls.DataGridTemplateColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6)      
IsReadOnly . 	   Width$	 40 6F   
   CellTemplate
 5@      �� 5A      .R�5B      �� ��6(   ��  �� RelativeSource ��  �� AncestorType$ DataGridRowL� �� Path$ Header�5C      5E      5H      5I      5J      