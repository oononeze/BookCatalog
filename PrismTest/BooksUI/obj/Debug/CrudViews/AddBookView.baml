   M S B A M L   `   `   `  ����B  >BooksUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BooksUI.CrudViewsBooksUI.CrudViews  5   	   #    BooksUI.CrudViews.AddBookView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BooksUI.CrudViews     5   	     � Title$  AddBook��5      $	��400��6   $	��400��6%   .��5	      � .+�5
   
   �� .+�5      �� $��5q�6   
Book Name:6/   �� 5      -   5        $��BookNameTextbox��5   U   $��5q�6   $��25��6"   $	��300��6.   $
��Left=�6:   6n   �� 5      $��5q�6   Book Author:62   �� 5      -   5        $��AuthorTextBox��5   U   $��5q�6   $��25��6"   $	��300��6.   $
��Left=�6:   6l   �� 5      $��5q�6   Book Publisher:65   �� 5      -   5        $��PublishersTextbox��5   "   $��5q�6   $��25��6;   $	��300��6G   $
��Left=�6S   6p   �� 5      $��5q�6   Book Category:64   �� 5      -   5        $��CategoryTextbox��5   "   $��5q�6   $��25��69   $	��300��6E   $
��Left=�6Q   6n   �� 5      $��5q�6   Book Description:67   �� 5      -   5        $��DescriptionTextbox��5   "   $��5q�6   $��25��6<   $	��300��6H   $
��Left=�6T   6q   �� 5      -   5        $��imageUri��5      
���<��6?   �� 5      -   5        $��AddImageButton��5   H   $
��Left=�6   $��30��60   $��5q�6=   
���������5      �� 5       �� EndPoint$ 
0.15,0.327&�6*    �� 
StartPoint$ 
1.14,0.559&�6@   .��5      �  � Color$ White��6'    � Offset$ 0Q�65   � 5      $
 Teal��6'   $ 0Q�64   5      .��5   %   Browse Image5      �� 5       -   5        $��AddBookButton��5    U   $��Center=�6   $��30��62   $	��100��6>   $��5q�6J   
���������5!      �� 5"      $ 
0.15,0.327&�6*   $ 
1.14,0.559&�6@   .��5#      � $ White��6'   $ 0Q�65   � 5$      $
 Teal��6'   $ 0Q�64   5%      .��5&   %   
Add Book5'      5(      5)      5*      