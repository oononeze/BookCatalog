   M S B A M L   `   `   `  ����B  >BooksUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BooksUI.ViewsBooksUI.Views  5      #    BooksUI.Views.BookDetailsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:BooksUI.Views     5      .��5
   
   � 
����Zj�  � RowDefinitions  5      �� 5      $��2* �6    �� 5      $��1* �6    �� 5      $��3* �6     � ColumnDefinitions 5      �� 5      $
��1.5* �6#   �� 5      $��4* �6#   .+�5      �� -   5        $��	bookImage��5   r   $��0��6   $��0��6$   $$�� ..\Images\BookPlaceHolder.jpg��61   $	��100��6Y   $	��100��6f   $
��Left=�6�   $��10q�6�   6�   � 5      $��1��6   $��0��6#     5      �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   .+�5      �� -   5        $
��name��5   =   $��0��6   
���������6I   ��  �� Source$ bn�� �� Path$
 Name��� 5      -   5        $��author��5   =   $��1��6   
���������6K   �� *Author+�� 5      -   5        $��	publisher��5   >   $��2��6   
���������6O   �� *	Publisher+5       �� 5#      $��1��6   $��0��6&   $��5q�67   
�������$��Bottom=�6U   Description:6~   �� 5$      -   5        $��DescriptionTextBox��5$   /   $	��150��6   $	��500��6#   $
��Left=�6J   $	��Top=�6e   $��2��6}   $��2��6�   $��5q�6�   ��6�   �� *Description+5'      5(      