   M S B A M L   `   `   `  ����Q  MEmployeesFromCompanies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EmployeesFromCompaniesEmployeesFromCompanies  5   	   '    !EmployeesFromCompanies.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EmployeesFromCompanies     5   	     � Title$  List of employees��5   	    � Icon$ images/edit.png��6#   $	��472��6:   $	��924��6G    � WindowStartupLocation$ CenterScreen=�6S    � 
ResizeMode$ NoResize=�6x   $��Georgia)�6�   $��20(�6�   .��5	      � ���	#FFDBEEFF � RowDefinitions 5
   
   �� 5      $	��50* �6   �� 5      $
��321* �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ employeesList��5      $��Georgia)�6A   $��18(�6V   
�������$��6,10,217,10q�6w   $��1��6�   ��6)   �� ��5      �� 5      .R�5      �� .+�5      �� $��16(�6>   $��Georgia)�6L   $
��Bold"�6a   ��6$   �� *
FullName+6a   �� 5      $��13(�6=   $��Georgia)�6K   ��6$   �� *	Address+6K   �� 5      $��13(�6A   $��Georgia)�6O   ��6$   �� *PhoneNumber+6O   �� 5      $��13(�6>   $��Georgia)�6L   ��6$   �� *
Position+6L   �� 5      $��13(�6?   $��Georgia)�6M   ��6$   �� *	WorkPlace+6M   5      5      5      ]� 5   
   $��0��6   ���	#FFA7D5FF$��0,0,0,1q�68   .+�5      �� ���	#FF818181$��1q�6.   $	��918��6B   ._�5      ��  �� Orientation$ 
Horizontal=�6   $��0,0,-2,0q�66   .+�5      �� $��0��6!   $ 
Horizontal=�6.   $��Center=�6G   $	��903��6d   .+�5       �� $��Select the company:��6    $��7,7,7,10q�6>   $��Georgia)�6P   $��20(�6e   $	��190��6s   �� 5!      -   5         ��Name$ 	Companies��5!   #   $��7q�66   $	��256��6A   
�������$��Georgia)�6a   $��20(�6v   ��5"      �� 5#   "    �� EndPoint$	 0,1&�66   	 �� 
StartPoint$		 0,0&�6E   .��5$   &   � 
 � Color$
 	#FFF0F0F0��63    � Offset$ 0Q�6E   � 5%   &   $
 White��63   $ 1Q�6A   5&   #   5(      �� 5)      -   5         ��Name$
 Load��5)   �   $��Load employees��6!   $��7q�6�   $	��210��6�   $��Georgia)�6�   $��20(�6�   
���������6:   ��  �� ElementName$ employeesList�� �� Path$ SelectedItem���6�   �� *LoadCommand+6�   �� 5*      -   5        $��LoadCompanies��5*   u   $��Load companies��6!   $��7,7,7,10q�6c   $	��185��6�   $��Georgia)�6�   $��20(�6�   
���������6:   �� *LoadCompaniesCommand+6�   5+      5,      5-      �� 5.      $ 
Horizontal=�6   $��Bottom=�62   $��25��6J   5/      ]� 50   
   $��2��6   ���	#FFA7D5FF.+�51      �� ���	#FF818181$��1q�6.   $	��918��6B   ._�52      �� $ 
Horizontal=�6   $��0,0,-2,0q�66   .+�53      �� -   5        $	��Add��53      $��Center=�6G   $	��Add��6d   $��7q�6r   $	��165��6�   $��Georgia)�6�   $��20(�6�   
���������6(   �� *
AddCommand+6�   �� 54      -   5        $
��Edit��54      $��Right=�6�   $
��Edit��6�   $��7q�6�   $	��160��6�   $��Georgia)�6�   $��20(�6�   
���������6)   �� $ employeesList��$ SelectedItem���6s   �� *EditCommand+6  �� 55      -   5        $��Delete��55      $��Delete��6�   $��7q�6�   $
��Left=�6�   $	��160��6�   $��Georgia)�6�   $��20(�6  
���������6+   �� $ employeesList��$ SelectedItem���6u   �� *DeleteCommand+6  �� 56      -   5        $ ClearCompanies��56      $��Right=�6_   $��Clear list with companies��6{   $��7q�6�   $	��244��6�   
���������65   �� *ClearCompaniesCommand+6�   �� 57      -	   5        $
��Exit��57   =   $
��Exit��6I   $��7q�6X   $��99��6c   ���	#FF3373E2
���������6   �� *ExitCommand+6�   58      59      �� 5:      $ 
Horizontal=�6   $��Bottom=�62   $��25��6J   5<      �� 5=   
   -
   5        $��listComanies��5=      $
��Left=�6'   $	��312��6B   $��
706,10,0,0q�6O   $��1��6c   $	��Top=�6p   $	��186��6�   5?      5A      5B      