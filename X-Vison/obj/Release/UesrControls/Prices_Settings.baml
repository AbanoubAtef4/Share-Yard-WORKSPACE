   M S B A M L   `   `   `  ����   Center_Maneger1    +Center_Maneger.UesrControls.Prices_Settings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008        bguc#��[  .���   � RowDefinitions  �� $
��0.4* ��� $	��.6* �.+��� $��0��.+��� .+��� $	��0 5q�$	��150��  	Whitetext#��[ ���	#FF10D07C �� CornerRadius$ 7��$��5q�._���   TextBlockStyle#��[ $!��أسعار الزيارات��$��18(�$
��Bold"�  text#��[ $��Center=��� $
��0 35q� �� Orientation$ 
Horizontal=�$��Right=�$��RightToLeft=�.+��� #��[ $��بداية الفترة: ��$��Right=�$��Center=�$��20(�$
��Bold"�$
��20 0q��� -   $��start_date_price_input��  RoundedTextBox#��[ $��70��$��Right=�$��20(�$	��2 0q��� #��[ $��نهاية الفترة:��$��Center=�$��20(�$
��Bold"�$
��20 0q��� -   $��end_date_price_input��#��[ $��70��$��Right=�$��20(�$	��2 0q��� #��[ $��تكلفة الفترة:��$��Center=�$��20(�$
��Bold"�$
��20 0q��� -   $��cost_price_input��#��[ $	��150��$��Right=�$��20(�$	��2 0q��� $ 
Horizontal=�$��Center=�.+��� -     
Roundedbtn#��[ $��0q�$	��100��$��40��$��16(�$
��Bold"����	#00DDDDDD.���� $ 
Horizontal=�.+��� $��/img/trash.png��$��40��$��35���� $��حذف��$��Center=��� -   #��[ $��0q�$	��100��$��40��$
��70 0q�$��16(�$
��Bold"����	#00DDDDDD.���� $ 
Horizontal=�.+��� $��/img/save.png��$��40��$��35���� $��حفظ��$��Center=��� -   #��[ $��0q�$	��100��$��40��$��16(�$
��Bold"����	#00DDDDDD.���� $ 
Horizontal=�.+��� $��/img/correct.png��$��40��$��35���� $��جديد��$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ 	data_grid��$��RightToLeft=�   
IsReadOnly . $��16(�$��1��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 