   M S B A M L   `   `   `  ����S  ORestaurantBillCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RestaurantBillCalculatorRestaurantBillCalculator  5   	   )    #RestaurantBillCalculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:RestaurantBillCalculator     5   	   -   5          � Title$  
Restaurant��5   	   $��651.09��6   $��1115.123��6,    � WindowStartupLocation$ CenterScreen=�6T   .��5	      � -   5         �Name$ 
restaurant��5	      ���	#FFCCCAD1.+�5
   
   �� -   5         ��Name$ beverageComboBox��5
      $
��Left=�6-   $��
43,150,0,0q�6H   $	��Top=�6\   $	��120��6t   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ itemsDataGrid��5      $
��Left=�6*   $	��378��6E   $��
495,24,0,0q�6R   $	��Top=�6f   $	��589��6~    J� RenderTransformOrigin$ 0.527,-0.105&�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property	 �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
	 �  ��63   �� 5       � ��$	 SemiBold"�63   �� 5       � ��$	 0,0,1,2q�68   �� 5       � ��
	 �   �64   5      5      
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Name+6N     5      $ 	 Category��6%   $ * 6U    68   �� *
Category+6U     5      $ 	 Quantity��6%   $ * 6U    68   �� *
Quantity+6U     5      $  Price��6%   $ * 6O    65   �� *Price+6O   5      �� 5   
   -   5        $ appetizerComboBox��5      $
��Left=�6.   $��255,150,0,0q�6I   $	��Top=�6^   $	��120��6v   6�   �� 5   
   -   5        $ mainCourseComboBox��5      $
��Left=�6/   $��
43,352,0,0q�6J   $	��Top=�6^   $	��120��6v   6�   �� 5    
   -   5        $ dessertComboBox��5       $
��Left=�6,   $��255,352,0,0q�6G   $	��Top=�6\   $	��120��6t   6�   �� 5!   
   -   5         ��Name$ spider��5!      $�� ��6    $
��Left=�6+   $��163,224,0,0q�6F   $	��Top=�6[   $	��100��6s   �� 5"   
   -	   5         ��Name$ clearButton��5"      $��Clear��6&   $
��Left=�66   $��220,540,0,0q�6Q   $	��Top=�6f   $	��155��6~   $��46��6�   $
��Bold"�6�   $��16(�6�   6�   �� 5#   
   $��Total:��6   $
��Left=�6!   $��495,477,0,0q�6<   $	��Top=�6Q   $��16(�6i   �� 5$   
   -
   5         ��Name$ totalTextBlock��5$      $
��Left=�6,   $��547,482,0,0q�6G   $
��Wrap=�6\   $��$0.00��6p   $	��Top=�6}   $��16(�6�   $	��117��6�   
�������6�   �� 5%   
   -   5        $ centennialLogoButton��5%      $�� ��6/   $
��Left=�6:   $��935,499,0,0q�6U   $	��Top=�6j   $	��136��6�   $	��105��6�   $��0q�6�   ��5&      �� 5'       �� ImageSource$! Centennial-College-Logo.png��6   ��5)      �� 5*      5,      �� 5-   
   $
��Tax:��6   $
��Left=�6   $��495,431,0,0q�6:   $	��Top=�6O   $��16(�6g   �� 5.   
   -   5        $ taxBlock��5.      $
��Left=�6&   $��547,438,0,0q�6A   $
��Wrap=�6V   $��$0.00��6j   $	��Top=�6w   $��16(�6�   $	��117��6�   
�������6�   �� 5/   
   $��Owner: Abdul Moeed Saqib��6   $
��Left=�63   $��906,462,0,0q�6N   $	��Top=�6c   $
��Bold"�6{   $��14(�6�   $��Italic$�6�   �� 50   
   $��Beverage��6   $
��Left=�6#   $��
54,116,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   $��24(�6|   $��
Tekton Pro)�6�   $��34��6�   �� 51   
   $��	Appetizer��6   $
��Left=�6$   $��267,116,0,0q�6?   $	��Top=�6T   $
��Bold"�6l   $��24(�6~   $��
Tekton Pro)�6�   $��34��6�   �� 52   
   $��Main Course��6   $
��Left=�6&   $��
34,318,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   $��24(�6   $��
Tekton Pro)�6�   $��34��6�   �� 53   
   $��Dessert��6   $
��Left=�6"   $��267,318,0,0q�6=   $	��Top=�6R   $
��Bold"�6j   $��24(�6|   $��
Tekton Pro)�6�   $��34��6�   �� 54   
   $��SAQIUS Restaurant��6   $
��Left=�6,   $��
109,24,0,0q�6G   $	��Top=�6[   $
��Bold"�6s   $��36(�6�   $��Palatino Linotype)�6�   $��62��6�   $	��353��6�   ���	#FF0D55646�   �� 55   
   $
��Left=�6   $��92��6+   $��9,5,0,0q�67   $	��Top=�6H   $	��100��6`   $ 	0.19,0.33&�6l   $��SAQIUSlogo - Copy.png��6�    J� OpacityMask 56      �� 57      $ SAQIUSlogo - Copy.png��6   59      �� 5:   
   -   5        $ finishButton��5:      $��Finish��6'   $
��Left=�68   $��
34,540,0,0q�6S   $	��Top=�6g   $	��155��6   $��46��6�   $
��Bold"�6�   $��16(�6�   6�   5;      5<      