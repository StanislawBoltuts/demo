   M S B A M L   `   `   `  ����?  ;Lab3, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Lab3WPF.ViewModelsLab3WPF.ViewModels  5      (    "Lab3WPF.Views.SortStudentsFormView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7
viewModels clr-namespace:Lab3WPF.ViewModels     5        � 	Resources  5	       �� 
TargetType �� Property �� Value��%�   '��       '�� �     �� 5
   
   " ��6   .�5      ��  � ��$
 10 4q�6'   �� 5       � ��$ Right=�64   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6   .�5      ��  � ��$	 0 3q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5    
   �� $��0��6   $��0��6!   $��Sort by��61   �� 5!   
   $��0��6   $��1��6    ��60   �� *SortByPropertyNames+ �� Text 5"      �� *SelectedSortByProperty+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . �� 5$   
   $��1��6   $��1��6    $��invert?��60   $	��0 8q�6B   	 d� 	IsChecked	 5%      �� *	IsAscSort+�� 5'   
   $��2��6   $��0��6!   $��Count��61   �� 5(   
   $��2��6   $��1��6   ��5)      �� *Count+$ PropertyChanged=� . �� 5+   
   $��3��6   $��0��6!   $��2��61   $��Center=�6\   $	��0 4q�6y   ��6E   �� *Error+6y   �� 5-   
   $��4��6   $��1��6   $��Submit��6.   ��6?   �� *SubmitCommand+5.      5/      