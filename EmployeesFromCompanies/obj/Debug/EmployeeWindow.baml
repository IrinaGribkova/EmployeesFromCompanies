   M S B A M L   `   `   `  ����Q  MEmployeesFromCompanies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:EmployeesFromCompaniesEmployeesFromCompanies  5   	   +    %EmployeesFromCompanies.EmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:EmployeesFromCompanies     5   	     � Title$  Adding an employee��5   	    � Icon$ images/edit.png��6$   $��407.659��6;   $��917.177��6L    � 
ResizeMode$ NoResize=�6\    � WindowStartupLocation$ CenterScreen=�6r    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5
   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      � ���	#FFE8F4FF � RowDefinitions 5   
   �� 5      $	��60* �6   �� 5      $	��60* �6   �� 5      $	��60* �6   �� 5      $	��60* �6   �� 5      $	��60* �6   �� 5      $	��60* �6   �� 5      $	��60* �6   	 � ColumnDefinitions	 5   
   �� 5      $	��155 �6   �� 5      .+�5   
   �� $��Center=�6   $��
Full Name:��61   $��1��6C   $��Georgia)�6P   $��20(�6e   �� 5    
   $��Center=�6   $��Address:��61   $��2��6A   $��Georgia)�6N   $��20(�6c   �� 5!   
   $��Center=�6   $��Phone number:��61   $��3��6F   $��Georgia)�6S   $��20(�6h   �� 5"   
   $��Center=�6   $��	Position:��61   $��4��6B   $��Georgia)�6O   $��20(�6d   �� 5#   
   $��Center=�6   $��Work Place:��61   $��5��6D   $��Georgia)�6Q   $��20(�6f   �� 5$   
   -   5        $
��Name��5$      $��1��68   $��1��6H   $��Georgia)�6U   $��20(�6j   ��6   �� *
FullName+6j   �� 5%   
   -   5        $��Address��5%      $��1��6:   $��2��6J   $��Georgia)�6W   $��20(�6l   ��6!   �� *	Address+6l   �� 5&   
   -   5        $��Number��5&      $��1��6=   $��3��6M   $��Georgia)�6Z   $��20(�6o   ��6    �� *PhoneNumber+6o   �� 5'   
   -   5        $��Position��5'      $��1��6<   $��4��6L   $��Georgia)�6Y   $��20(�6n   ��6"   �� *
Position+6n   �� 5(   
   -   5        $
��Work��5(      $��1��69   $��5��6I   $��Georgia)�6V   $��20(�6k   ��6   �� *	WorkPlace+6k   �� 5*   
   $��Center=�6   
 �� Orientation$
 
Horizontal=�62   $��6��6K   $��1��6X   $��127,0,235,0q�6h   $	��392��6}   .+�5+      �� -   5         �� 	IsDefault . $��60��5+   ;   $��5q�6I   $	��183��6T   $��Georgia)�6`   $��20(�6u   
�������.��6�   Save6�   �� 5,      -   5        $
��Back��5,       �� IsCancel . $��60��61   $��5q�6?   $
��Back��6J   $	��183��6Y   $��Georgia)�6e   $��20(�6z   
�������6�   5-      �� 5.   
   $��The new employee:��6   $��1��6,   $
��Left=�6<   $��
200,10,0,0q�6W   $	��Top=�6k   $	��229��6�   $��Georgia)�6�   $��22(�6�   $
��Bold"�6�   5/      50      