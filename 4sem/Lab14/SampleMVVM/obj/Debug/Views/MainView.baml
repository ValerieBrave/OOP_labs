   M S B A M L   `   `   `  ����E  ASampleMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SampleMVVM.CommandsSampleMVVM.Commands  5          SampleMVVM.Views.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      /c!clr-namespace:SampleMVVM.Commands     5        � Title$
  MVVM��5      $	��400��6   $	��435��6   .��5      �  � ColumnDefinitions 5   
   �� 5	      �� 5
      .+�5   
   �� $ �� IsSynchronizedWithCurrentItem$
 TrueY�6=   ��6   �� *ConsultationsList+��5      �� 5      .R�5      �� 
�������$��1q�62   $��10q�6F   ._�5      �� $��10q�6%   .+�5      �� $
��Bold"�6=   ��6(   �� *FIO+6=   �� 5      ��6(   �� *	Subject+�� 5      ��6(   �� *	DateShort+ �� Mode$ OneWay=��� 5      ��6(   �� *	StartTime+�� 5       �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $
��Bold"�6Z   $
��10,0q�6l   $��0,1,0,0q�6z   
���   �
���   �$
��Left=�6�   $	��Top=�6  $	��100��6  ��6*   �� *IsRecordedToSting+$ OneWay=� �� SelectionBrush 6�   Z� ��6�   Z� 6  5      5      5      5      5      �� 5   
   $��1��6   ��6)   �� *ConsultationsList+��5       �� 5!      .R�5"      �� 
�������$��1q�62   $��10q�6F   ._�5#      �� $��10q�6%   .+�5$      �� $
��FIO:��6(   �� 5%      $��0,0,0,10q�6`   ��6&   �� *FIO+ �� UpdateSourceTrigger$ PropertyChanged=�6`   �� 5'      $��Subject:��6(   �� 5(      $��0,0,0,10q�6d   ��6&   �� *	Subject+$ PropertyChanged=�6d   �� 5)      $��Date:��6(   �� 5*      $��0,0,0,10q�6s   ��6&   �� *	DateShort+$ OneWay=�$ PropertyChanged=�6s   �� 5+      $��
StartTime:��6(   �� 5,      $��0,0,0,10q�6f   ��6&   �� *	StartTime+$ PropertyChanged=�6f   �� 5.      $ 
Horizontal=�6)   .+�5/   "   �� $��Записаться��6)   $
��10,0q�6a   ��6>   �� *GetItemCommand+6a   �� 50   "   $��Отменить��6)   $
��10,0q�6`   ��6<   �� *GiveItemCommand+6`   51      52      53      54      56      57      58      