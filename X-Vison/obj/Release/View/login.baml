   M S B A M L   `   `   `  ���� I  ECenter_Maneger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Center_Maneger.ViewCenter_Maneger.View      Center_Maneger.View.login   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2wpf"http://schemas.fontawesome.com/wpf     3local!clr-namespace:Center_Maneger.View     4fa%http://schemas.fontawesome.com/icons/     -     � Title$  login��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�
������  � AllowsTransparency . .����  �� CornerRadius$ 33������  �� ImageSource$ /img/BackGround.png��._��� $ 30�����	#D809094A���	#FF0F7394$��5q� J� Opacity$ 1Q�._��  � RowDefinitions �� $��30 ��� .+�� 	 � ColumnDefinitions	 �� �� $��30 ��� $��30 ��� $��10 �.+��� $�� Login �����#0df6f2$��Center=�$��18(�$
��Bold"�$��15 5 0 0q��� -   
 ��Name$
 Minimize��
�������$��-��$��18(�$��Times New Roman)� � Cursor$
 Hand��$��1������  �� 
TargetType" ��.���  �� Property � �� �� Value �	#FF00BCF9 �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#278BEF����  �� 
TargetType" ��.R��� $��20��$��25��$ 10��#��z��._��� $��Center=�$��Center=��� -   $
 ShutDown_Win��
�������$��x��$��18(�$��Arial)�$
 Hand��$��2������ " ��.���  � �� �#FF81AE P�  �@J�IsMouseOver . . ���  � �� �	#FFEB1E9C���� " ��.R��� $��20��$��25��$ 10��#��z��._��� $��Center=�$��Center=��� $	��300��$��1��$��	30 10 0 0q�$
��Left=�.+���    TextBlockStyle#��[  $�� Welcome To ��$��Center=����#0df6f2$
��Bold"�$��18(�$��0 20 0 0q�$��Arial)��� $��/img/logo.png��$��60��$
��0 15q��� $��Username�����#0df6f2$��12(�$��Medium"�$��
Montserrat)�$��0,5,0,0q�� 	 �� $��22.416 ��� $��17.584 ��� .+��� -    ��Name$ txtUser��  RoundedTextBox#��[ $��13(�$��Medium"�$��Arial)�
���   � �� 
CaretBrush
 �   ����#FF81AE$��2,2,2,2q�$��28��$��Center=�$��0,11,0,1q�$��5,0,0,0q�$��2��.���� ���#EEE$ 30��$��0��$��30��$��30��$��	0 10 10 0q����#1EA5AE$��2,2,2,2q�$��2��._��� $��/img/user-icon.png��$
��None=��� $��Password�����#0df6f2$��12(�$��Medium"�$��Arial)�$��0,35,0,0q�� 	 �� $��40 ��� $��3* ��� $	��10* �.+�G� -    G�Name$ user_password��  RoundedPassBox#��[ $��13(�$��Medium"�$��Arial)�
���   � G� 
CaretBrush
 �   ����#FF81AE$��2,2,2,2q�$��28��$��Center=�$��0,11,0,1q�$��5,0,0,0q�$��1��$��2���� ���#EEE$ 30��$��0��$��30��$��30��$��	0 10 10 0q����#1EA5AE$��2,2,2,2q�._��� $��/img/key-icon.png��$
��None=��� -   $��loginbtn�� �� 	IsDefault . $��0 30 0 0q�$	��120��$��50�����#0df6f2$��18(�$��Arial)�$
 Hand��$
��Bold"�$��Center=�$��Center=�
������   
Roundedbtn#��[ .����  �� Orientation$ 
Horizontal=�$��RightToLeft=�.+��� #��[  ���#0df6f2$��Login��$��Center=��� $��/img/login2.png���� $!��/img/Computer login-bro.png��$��1��$��Right=�$��0 0 20 0q�$
 0.99Q�