   M S B A M L   `   `   `  ����   Center_Maneger#    Center_Maneger.View.Add_Order   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  اضافة طلب��$	��700��$
��1200�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�   bguc#��[  .��� $
��15 0q� � RowDefinitions �� $
��.15* ��� $
��.75* ��� $	��.1* �.+��� $��0��$��RightToLeft=�.+��� $	��0 5q�$	��200��  	Whitetext#��[   hoverbtn#��[  �� CornerRadius$ 7��$��5q�._��� $��اضافة طلب��$��18(�$
��Bold"�  text#��[ $��Center=��� $��0 20 0 0q�.+��  � ColumnDefinitions �� $	��.5* ��� $	��.5* �.+��� $��0�� �� Orientation$ 
Horizontal=�.+��� $��Center=�$��0 0 30 0q�$��اسم العضو:��  TextBlockStyle#��[ �� -   $��username_label��$��Center=�#��[ �� $��1��$ 
Horizontal=�$
��Left=�.+��� -   $��chair_class��$��Center=�$��0 0 30 0q�$��رقم المقعد:��#��[ �� -   $��chair��$��Center=�#��[ � $��1�� �� $
��117* ��� $
��429* ��� $
��328* ��� $	��23* ��� $
��267* �.+��� $��0��$��RightToLeft=�.���� .+��� -   $��allproduct_btn��
 � Tag$  ��$��5q�$��90��  
Roundedbtn#��[ .���� .+��� $��/img/street-food.png��$��40���� $
��Wrap=�$��جميع المنتجات��#��[ �� -   $��hotdrink_btn��$ مشروبات ساخنة��$��5q�$��90��#��[ .���� .+��� $(��"/img/مشروبات ساخنة.png��$��45���� $
��Wrap=�$��مشروبات ساخنة��#��[ �� -   $��colddrink_btn��$ مشروبات باردة��$��5q�$��90��#��[ .���� .+��� $(��"/img/مشروبات باردة.png��$��45���� $
��Wrap=�$��مشروبات باردة��#��[ �� -   $��
snacks_btn��$ باتيه و بسكوت��$��5q�$��90��#��[ .���� .+��� $'��!/img/باتيه و بسكوت.png��$��40���� $
��Wrap=�$��باتيه و بسكوت��#��[ �� -	   $��	chips_btn��$ 
شيبسي��$��5q�$��90��#��[ .���� .+��� $��/img/شيبسي.png��$��50���� $
��Wrap=�$��
شيبسي��#��[ �� -
   $��otherproduct_btn��$ منتجات اخرى��$��5q�$��90��#��[ .���� .+��� $$��/img/منتجات اخرى.png��$��40���� $
��Wrap=�$��منتجات اخرى��#��[ �� $��المنتجات��$��1��$��RightToLeft=�$��16(�$
��Bold"� 	 bgtab#��[ $��2q�$��2��.���� $��LeftToRight=�$
��Auto=�$��10q�.��� -   $��products_grid��$	��Top=�$��LeftToRight=��� $��المشتريات��$��4��$��RightToLeft=�$��16(�$
��Bold"�#��[ $��2q�.���� $��LeftToRight=�$
��Auto=�.���� -   $��bought_stack���� -   $��2��#��[ $
��Bold"�
������ $��50��$��Center=�$��5q�$
��0 10q�.���� $ 
Horizontal=�$��RightToLeft=�.+��� $��اضافة الطلب��#��[ $��Center=��� $��/img/save.png��