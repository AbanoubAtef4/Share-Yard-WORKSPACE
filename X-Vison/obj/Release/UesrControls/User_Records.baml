   M S B A M L   `   `   `  ����   Center_Maneger.    (Center_Maneger.UesrControls.User_Records   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -      bguc#��[  .���   � RowDefinitions  �� $��0.25* ��� $
��0.3* ��� $��0.05* ��� $��0.36* �.+��� $��0��.+��� $	��0 5q�$	��160��  	Whitetext#��[ ���	#FF10D07C �� CornerRadius$ 7��$��5q�._���   TextBlockStyle#��[ $#��بيانات الشيفتات��$��18(�$
��Bold"�  text#��[ $��Center=��� $
��0 25q� �� Orientation$ 
Horizontal=�$��Center=�$��RightToLeft=�.+��� $��0 0 20 0q�#��[ $��من تاريخ��$��Center=�(  "System.Windows.Controls.DatePicker  -   $��fromDate��$��2q� 	 bgtab#��[ $��16(�$	��180��$��RightToLeft=�$��Center=��� #��[ $��Center=�$
��30 0q�$��الي تاريخ��  -   $��toDate��$��2q�#��[ $	��180��$��Center=�$��16(�$��0 0 30 0q��� -     
Roundedbtn#��[ $��0q�$	��100��$��40��$��16(�$
��Bold"�
������ .���� $ 
Horizontal=�.+��� $��/img/show.png��$��40��$��35���� #��[ $��عرض��$��Center=��� -   $��searchTB��$��50 0 0 0q�$��30��$	��200��  RoundedTextBox#��[ $��4q��� -    ��Name$ 	searchbtn��$��0 0 20 0q� �� 	IsDefault . 
������ $��50��$	��100��#��[ .���� $ 
Horizontal=�.+��� $��/img/search (2).png��$��40���� $��بحث��#��[ $��Center=��� $��2��$��RightToLeft=�
���   �$��1q�._��� $��Right=�$ 
Horizontal=�.+��� -   $��totalReservationCost��#��[ $��12(�$#��اجمالي التكلفة =��$��Center=��� -   $��totalKitchenCost��#��[ $��12(�$#��اجمالي البوفيه =��$��Center=�$
��30 0q��� -	   $��total��#��[ $��12(�$��الاجمالي =��$��Center=��� -
   $��	totalPaid��#��[ $��12(�$#��اجمالي المدفوع =��$��Center=�$
��30 0q�&   System.Windows.Controls.DataGrid  -     Name$ 	data_grid��$��RightToLeft=�   
IsReadOnly . $��16(�$��1��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * � $��3��$��RightToLeft=� � ColumnDefinitions �� $	��37* ��� $
��313* ��� $
��350* �  �� $��0.86* ��� $��0.14* �.+�  -   $ offers_grid��$��0��$��0��$��RightToLeft=� . $��16(�$ * $��2���� $��1��$��0��$��RightToLeft=�
���   �$��1q�$��2��._��� $��Right=�$ 
Horizontal=�.+��� -   $��
totalOffer��#��[ $��12(�$#��اجمالي الباقات =��$��Center=�$
��30 0q�  -   $ kitchen_grid��$��0��$��2��$��RightToLeft=� . $��16(�$ * �� $��1��$��2��$��RightToLeft=�
���   �$��1q�._��� $��Right=�$ 
Horizontal=�.+��� -   $��totalKitchen��#��[ $��12(�$#��اجمالي البوفيه =��$��Center=�$
��30 0q�