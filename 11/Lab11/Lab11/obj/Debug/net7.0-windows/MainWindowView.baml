   M S B A M L   `   `   `  ����@  <Lab11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab11Lab11  5   	       Lab11.MainWindowView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab11     5   	     � Title$  MainWindowView��5   	   $	��450��6    $	��750��6-    � DataContext 5	         Lab11.MainWindowViewModel  5
   
   6&   .��5      � 
�������.+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ StudGrid��5   0   $	��250��6   $	��280��6#   ��6B   �� *
Students+6e     5      -   5        $ 
CourseGrid��5   0   $	��250��6   $	��280��6#   ��6D   �� *	Courses+6f     5      -   5        $ LecturerGrid��5   0   $	��250��6   $	��280��6#   ��6F   �� *	Lecturers+6j   5      �� 5   
   $ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6I   .+�5      �� $��40��6   $	��170��6!   $��	0 0 40 40q�6-   
�������$��Лекторы��5      $��24(�6'   
��� d �$��3q�6M   ��5   S   �� * EditLecturersWindowShowCommand+5      �� 5      $��40��6   $	��170��6!   $��	40 0 0 40q�6-   
�������$#��Запись студента��5      $��20(�6/   
��� d �$��3q�6U   ��5   S   �� *AddStudentsWindowShowCommand+5   k   5      5      5      