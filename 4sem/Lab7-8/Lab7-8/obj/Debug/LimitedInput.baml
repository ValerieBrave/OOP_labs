   M S B A M L   `   `   `  ����A  =Lab7-8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab7_8Lab7_8  5      %    Lab7_8.usercontrol.LimitedInput   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Lab7_8     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� ��6   �� *Title+�� 5   
   $��1��6   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� ��6   ��  �� ElementName$ txtLimitedInput�� �� Path$ Text.Length��� 5      $��/��6   �� 5      ��6   �� *	MaxLength+5      5      �� 5   
   -   5        $��txtLimitedInput��5   i   $��1��6H   $��2��6U   $
��Auto=�6�    �� TextWrapping$
 Wrap=�6�    �� 	MaxLength 6   �� *	MaxLength+��62   �� *Text+6�   5      5      