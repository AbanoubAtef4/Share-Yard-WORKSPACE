   M S B A M L   `   `   `  ���� I  ECenter_Maneger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Center_Maneger.UesrControlsCenter_Maneger.UesrControls  2    ,Center_Maneger.UesrControls.Faculty_Settings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Center_Maneger.UesrControls        bguc#��[  .���   � RowDefinitions  �� $
��0.4* ��� $	��.6* �.+��� $��0��.+��� $	��0 5q�$	��150��  	Whitetext#��[ ���	#FF10D07C �� CornerRadius$ 7��$��5q�._���   TextBlockStyle#��[ $��الكليات��$��18(�$
��Bold"�  text#��[ $��Center=��� $
��0 35q� �� Orientation$ 
Horizontal=�$��Right=�$��RightToLeft=�.+��� #��[ $��اسم الكلية : ��$��Right=�$��Center=�$��20(�$
��Bold"�$
��20 0q��� -   $��name_of_faculty_input��  RoundedTextBox#��[ $	��200��$��Right=�$��20(�$	��2 0q��� $ 
Horizontal=�$��Center=�.+��� -     
Roundedbtn#��[ $��0q�$	��100��$��40��$��16(�$
��Bold"����	#00DDDDDD.���� $ 
Horizontal=�.+��� $��/img/trash.png��$��40��$��35���� $��حذف��$��Center=��� -   #��[ $��0q�$	��100��$��40��$
��70 0q�$��16(�$
��Bold"����	#00DDDDDD.���� $ 
Horizontal=�.+��� $��/img/save.png��$��40��$��35���� $��حفظ��$��Center=��� -   #��[ $��0q�$	��100��$��40��$��16(�$
��Bold"����	#00DDDDDD.���� $ 
Horizontal=�.+��� $��/img/correct.png��$��40��$��35���� $��جديد��$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ 	data_grid��$��RightToLeft=�   
IsReadOnly . $��16(�$��1��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 