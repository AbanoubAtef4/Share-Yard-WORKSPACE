   M S B A M L   `   `   `  ���� I  ECenter_Maneger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Center_Maneger.UesrControlsCenter_Maneger.UesrControls  /    )Center_Maneger.UesrControls.admin_setting   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Center_Maneger.UesrControls     -      bguc#��[  .��� $��RightToLeft=�  � ColumnDefinitions  �� $
��0.5* ��� $
��0.5* �.+��� $��0��$��0�� 	 bgtab#��[ $��3q�$��10 70q�$��18(�$
��Bold"�$&�� Amiri, Cairo, 'Segoe UI', Tahoma)�
���   �����  �� Orientation$ 
Horizontal=�.+�	� -   $��
cp_setting��{�.  	� 	GroupName$ admin����   TextBlockStyle#��[ $<��6تغير كلمة مرور اعدادات النظام��.��� -   $��cp_setting_grid�� � RowDefinitions �� $
��0.8* ��� $
��0.2* �.+�� $��0�� �� $
��0.3* ��� $
��0.3* ��� $
��0.3* �  �� $
��0.4* ��� $
��0.6* �.+��� #��[ $&�� كلمة السر القديمة��$��0��$��0��$��Center=��� #��[ $&�� كلمة السر الجديدة��$��1��$��0��$��Center=��� #��[ $"��تاكيد كلمة السر��$��2��$��0��$��Center=�G� -   $��
op_setting��  RoundedPassBox#��[ $��0��$��1��$��2q�$	��150��$��25��$
��15 0q�G� -   $��
np_setting��#��[ $��1��$��1��$��2q�$	��150��$��25��$
��15 0q�G� -   $��cnp_setting��#��[ $��2��$��1��$��2q�$	��150��$��25��$
��15 0q��� -   $��0 0 0 15q�$��1��$	��130��  
Roundedbtn#��[ 
������ .���� $ 
Horizontal=�.+��� $��Center=�#��[ $��حفظ���� $��/img/done.png���� $��0��$��1��#��[ $��3q�$��10 70q�$��18(�$
��Bold"�$&�� Amiri, Cairo, 'Segoe UI', Tahoma)�
���   ����� $ 
Horizontal=�.+�	� -   $��cp_login��$ admin���� #��[ $8��2تغير كلمة مرور تسجيل الدخول��.��� -	   $��cp_login_grid�� �� $
��0.8* ��� $
��0.2* �.+�� $��0�� �� $
��0.3* ��� $
��0.3* ��� $
��0.3* ��� $
��0.3* �  �� $
��0.4* ��� $
��0.6* �.+��� #��[ $��اسم المسئول��$��0��$��0��$��Center=��� #��[ $&�� كلمة السر القديمة��$��1��$��0��$��Center=��� #��[ $&�� كلمة السر الجديدة��$��2��$��0��$��Center=��� #��[ $"��تاكيد كلمة السر��$��3��$��0��$��Center=��� -
   $��	AdminName��  RoundedTextBox#��[ $��0��$��1��$��2q�$	��150��$��25��$
��15 0q�G� -   $��op_login��#��[ $��1��$��1��$��2q�$	��150��$��25��$
��15 0q�G� -   $��np_login��#��[ $��2��$��1��$��2q�$	��150��$��25��$
��15 0q�G� -   $��	cnp_login��#��[ $��3��$��1��$��2q�$	��150��$��25��$
��15 0q��� -   $��1��$	��130��$��0 0 0 15q�#��[ 
������ .���� $ 
Horizontal=�.+��� $��Center=�#��[ $��حفظ���� $��/img/done.png��