   M S B A M L   `   `   `  ����K  GModuleCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ModuleCalculator.MVVM.ViewModuleCalculator.MVVM.View  5      0    *ModuleCalculator.MVVM.View.ModuleHoursView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ModuleCalculator.MVVM.View     5      .��5	      �� .+�5
   
   � .+�5      �� $-��'Calculate Your Total Hours Spent Below:��6   $��20(�5      $��15,5,0,0q�5      
��� ���$��/Fonts/#GGX88)�5      $
��Bold"�5      $��Center=�5      $��	Underline{�5      5      �� 5      -   5          ��Name$  PROGcheckBox��5      $ �� Programming 2B (PROG6212)��5      $��15(�5      $��15,55,0,-22q�5      $��/Fonts/#GGX88)�5      
������� � Cursor$
 Hand��5      �� 5      -   5        $  ADDBcheckBox��5      $$�� Advanced Databases (ADDB7311)��5      $��15(�5      $��15,147,0,-72q�5       $��/Fonts/#GGX88)�5!      
�������$
 Hand��5#      �� 5%      -   5        $  SOENcheckBox��5%      $&��  Software Engineering (SOEN6222)��5&      $��15(�5'      $��15,237,0,-122q�5(      $��/Fonts/#GGX88)�5)      
�������$
 Hand��5+      �� 5-      -   5        $  CLDVcheckBox��5-      $&��  Cloud Development 2B (CLDV6212)��5.      $��15(�5/      $��15,330,0,-170q�50      $��/Fonts/#GGX88)�51      
�������$
 Hand��53      �� 56      $	��400��6   $	��200��57       �� CornerRadius$ 10��58      $��
340,55,0,0q�59      
������ ���	#FF13819F._�5=      �� .+�5>      �� $��Select the date:��6    $��15(�5?      
�������$��/Fonts/#GGX88)�5A      $
��Left=�5B      $��2,0,0,0q�5C      $��	Underline{�5D      5E      (  "System.Windows.Controls.DatePicker  5F      -   5          Name$ HoursDatePicker��5F   !   
��� ���$��0,10,0,0q�5I      $
��Left=�5J      $	��300��5K      
���   ���5H      Z� 5L      �� 5O      $6��0Enter in the number of hours you've spent on it:��6    $��15(�5P      
�������$��/Fonts/#GGX88)�5R      $
��Left=�5S      $��2,50,0,0q�5T      $��	Underline{�5U      5V      �� 5_      $ 10��6   
��� ���$	��300��5a      $
��Left=�5b      $��0,15,0,0q�5c      ._�5d      �� -   5         ��Name$ HoursTextBox2��5d   "   $
��Left=�5e   "   $	��300��5f   "   $��30��5g   "   
������ $��0,0,0,0q�5i   "   ���#CFCFCF$��Center=�5k   "   $��0q�5l   "   $��5q�5m   "   $ IBeam��5n   "   5o      5q      5r      5u      �� 5x   
   $	��400��6   $	��200��5y      $ 10��5z      $��	340,0,0,0q�5{      
������ ���	#FF13819F._�5~      &   System.Windows.Controls.DataGrid  -   5          Name$ userModulesDataGrid��5~      5      �� 5�   
   -   5         ��Name$ SubmitButton��5�      $��Submit��5�      $��Center=�5�      $	��100��5�      $��2,20,0,0q�5�      $��25��5�      $��0q�5�      5�      5�      5�      