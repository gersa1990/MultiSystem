   M S B A M L   `   `   `  ����F  BMultiSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:MultiSystem.app.Library.Views.Controls&MultiSystem.app.Library.Views.Controls  5   	   _4clr-namespace:MultiSystem.app.Library.Views.Controls&MultiSystem.app.Library.Views.Controls  5      2    ,MultiSystem.app.Biblioteca.Views.LibraryHome   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   DAdd4clr-namespace:MultiSystem.app.Library.Views.Controls     5   	   K
searchBook4clr-namespace:MultiSystem.app.Library.Views.Controls     5      -   5          �Name$  windowLibraryHome��5   	    � Title$ 
Biblioteca��5   	   $
��1024��5	      $	��608��5
       � Left$ 0��5       � WindowStartupLocation$ CenterScreen=�5   	   
 � Top$ 0��5   	   .��5      � -   5         �Name$ gridMainLibrary��5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      �� 5      $��32 �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ rectangleTop��5      $��0��6*   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ 	#FFD60000��6#    � Offset$ 0Q�65   � 5      $ 	#FF830000��6#   $ 1Q�65   5      5       �� 5"   
   -   5         ��Name$ controlMain��5"      $
��auto��6*   $��1��68   $
��auto��6E    �� TabStripPlacement$
 Left=�6R   .@�5$      �� $��Agregar��6   .��5%      � ���	#FFE5E5E5.+�5&      4   .MultiSystem.app.Library.Views.Controls.AddBook  5'      5(      �� 5*      $��Editar y Eliminar��6   .��5+      � ���	#FFE5E5E5.+�5,      >   8MultiSystem.app.Library.Views.Controls.EditAndDeleteBook  5-      5.      �� 50      $��Solicitar préstamo��6   .��51      � ���	#FFE5E5E5.+�52      1   +MultiSystem.app.Library.Views.Controls.Loan  53      54      �� 56      $��Devolución��6   .��57      � ���	#FFE5E5E5.+�58        59      5:      �� 5=      $��Imprimir formatos��6   .��5>      � ���	#FFE5E5E5 5?      �� 5@      $
��217* �6(   �� 5A      $
��132* �6(   .+�5C      B   <MultiSystem.app.Library.Views.Controls.PrinterLibraryFormats  5D      5E      5G      �� 5H   
   -   5        $ rectangleBottom��5H      
���   �
���   �$
��auto��6I   $��2��6V   $��0,0,0,-3q�6c   �� 5I   
   -   5         ��Name$ clockBottom��5I      $��Derechos reservados 2014
��6%   
�������$��14(�6`   $��2��6n   $��Right=�6|   $��Center=�6�   $��32��6�   $	��382��6�   �� 5J   
   -   5        $ 	nameAdmin��5J      $��2��6   $��Label��60   $
��Left=�6@   $��Center=�6\   $	��398��6w   $��32��6�   
������� J� RenderTransformOrigin$ 
0.527,0.25&�6�   $��14(�6�   �� 5L   
   $��Center=�6   $��286,20,53,10q�61   $
��Wrap=�6G   $��Center=�6[   $��70��6v   $��24(�6�   
�������$��Arial Black)�6�   $	��421��6�   �� 6�   $8�2       HOSPITAL INTEGRAL COMUNITARIO DE LA HUACANA��6�   6
  �� 5M   
   $��michoacan.png��6   $��0��6'   $
��Left=�64   $��90��6O   $��Center=�6[   $��90��6v   $��10,5,0,5q�6�   �� 5N   
   $��secretaria.jpg��6   $��0��6(   $��Right=�65   $��90��6Q   $��Center=�6]   $	��172��6x   $��0,5,7,5q�6�   5P      5Q      