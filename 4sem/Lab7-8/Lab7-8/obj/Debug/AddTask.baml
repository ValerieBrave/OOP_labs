   M S B A M L   `   `   `  ����A  =Lab7-8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab7_8Lab7_8  5   	   7 clr-namespace:Lab7_8.usercontrolLab7_8.usercontrol  5   	       Lab7_8.AddTask   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Lab7_8     5   	   X TXceed.Wpf.Toolkit, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   )uc clr-namespace:Lab7_8.usercontrol  5   	     � Title$  AddTask��5
   	    � 
ResizeMode$ NoResize=�6   $	��700��6/   $	��450��6<    � Icon$ Icon.ico��6H   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      $	��100 �6   6+   �� 5      $��40 �6   6+    � ColumnDefinitions 5   
   �� 5      6"   �� 5      6"   .+�5   
   �� -   5        $��taskName��5   t   $��2��6   $
��Left=�6&   $��36��6A   $��	38,48,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $�� ��6�   $	��Top=�6�   $	��372��6�   $��Yu Gothic Medium)�6�   $��16(�6�   6�   &   Xceed.Wpf.Toolkit.DateTimeUpDown  5   
   -   5        $��	taskStart��5   A   $��1��6   $��10,42,12,10q�6,   $	��200��6R   $��37��6^     5   
   -   5        $��taskEnd��5   Q   $��1��6   $��10,42,12,10q�6,   $��1��6A   $	��200��6`   $��37��6l   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text 6x   ��  �� ElementName$ 	taskStart�� �� Path$
 Text�	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 OneWay=��� 5   
   -   5        $��taskPrio��5   '   $��2��6   $
��Left=�67   $��	70,54,0,0q�6R   $��2��6e   $	��Top=�6r   $	��300��6�   $��30��6�   .@�5      	� $��super important��6   	� 5      $��	important��6   	� 5       $��can wait��6   	� 5!      $��unsignificant��6   5"      �� 5#   
   -   5        $��taskFreq��5#   '   $��2��6   $
��Left=�67   $��	70,55,0,0q�6R   $��3��6e   $	��Top=�6r   $	��300��6�   $��30��6�   .@�5$      	� $
��Once��6   	� 5%      $��Daily��6   	� 5&      $��Weekly��6   	� 5'      $��Monthly��6   	� 5(      $��Annually��6   5)      �� 5*   
   -   5        $��taskCat��5*   '   $��2��6   $
��Left=�66   $��	70,49,0,0q�6Q   $��4��6d   $	��Top=�6q   $	��300��6�   $��30��6�   .@�5+      �� $	��JOB��6   �� 5,      $��HEALTH��6   �� 5-      $
��HOME��6   �� 5.      $��STUDY��6   �� 5/      $��RELAX��6   �� 50      $��OTHER��6   51      �� 52   
   -   5        $��taskStat��52   '   $��2��6   $
��Left=�67   $��	70,47,0,0q�6R   $��5��6e   $	��Top=�6r   $	��300��6�   $��30��6�   .@�53      	� $��Undone��6   	� 54      $
��Done��6   	� 55      $��Delayed��6   56      %   Lab7_8.usercontrol.LimitedInput  58   
   -   5          Name$ 	ExtraInfo��58      $��2��6-   $��6��6A      Title$  дополнительно��6N      	MaxLength$	 267��6d   �� 59   
   -	   5        $��2��59      $	��Add��6%   $
��Left=�63   $��	154,0,0,0q�6N   $��7��6a   $	��Top=�6n   $	��134��6�   $��30��6�   ���	#FF5353FF
�������$��14(�6�   6�   �� 5:   
   -
   5         ��Name$ 
name_label��5:      $
��Left=�6(   $��	38,19,0,0q�6C   $
��Wrap=�6V   $��Name your task��6j   $	��Top=�6�   $	��372��6�   $��24��6�   $��18(�6�   $��	Yu Gothic)�6�   ���	#FF0051FF$��2��6�   �� 5;   
   -   5        $ 
help_start��5;      $
��Left=�6(   $��	10,15,0,0q�6C   $��1��6V   $
��Wrap=�6c   $��Begins��6w   $	��Top=�6�   $	��199��6�   $��21��6�   ���	#FF0051FF$��	Yu Gothic)�6�   $��14(�6�   �� 5<   
   -   5        $ help_end��5<      $��1��6&   $
��Left=�66   $��2,15,0,0q�6Q   $��1��6c   $
��Wrap=�6p   $
��Ends��6�   $	��Top=�6�   $��21��6�   $	��201��6�   ���	#FF0051FF$��	Yu Gothic)�6�   $��14(�6�   �� 5=   
   -   5        $ 	help_prio��5=      $
��Left=�6'   $��	70,24,0,0q�6B   $��2��6U   $
��Wrap=�6b   $��Choose priority��6v   $	��Top=�6�    J� RenderTransformOrigin$ 	0.5,0.531&�6�   $	��300��6�   $��25��6�   $��16(�6�   $��	Yu Gothic)�6�   ���	#FF0051FF$��2��6  �� 5>   
   -   5        $ 	help_freq��5>      $
��Left=�6'   $��	70,25,0,0q�6B   $��3��6U   $
��Wrap=�6b   $��Choose frequency��6v   $	��Top=�6�   $	��300��6�   $��20��6�   $��	Yu Gothic)�6�   $��16(�6�   ���	#FF0046FF$ 0.503,0.525&�6�   $��2��6  �� 5?   
   -   5        $ help_cat��5?      $
��Left=�6&   $��	70,19,0,0q�6A   $��4��6T   $
��Wrap=�6a   $��Choose cathegory��6u   $	��Top=�6�   $	��300��6�   $��25��6�   ���	#FF0051FF$��	Yu Gothic)�6�   $��16(�6�   $��2��6�   �� 5@   
   -   5        $ 	help_stat��5@      $
��Left=�6'   $��	70,20,0,0q�6B   $��5��6U   $
��Wrap=�6b   $��Choose status��6v   $	��Top=�6�   $	��300��6�   $��27��6�   $��	Yu Gothic)�6�   $��16(�6�   ���	#FF0051FF$��2��6�   5A      5B      