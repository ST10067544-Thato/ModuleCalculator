   M S B A M L   `   `   `  ����K  GModuleCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ModuleCalculator.MVVM.ViewModuleCalculator.MVVM.View  5      )    #ModuleCalculator.MVVM.View.HomeView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ModuleCalculator.MVVM.View     5      .��5	      �� .+�5
   
   � .+�5      �� $4��.Select Your Modules and First Week Start Date:��6   $��20(�5      $��15,5,0,0q�5      ���#F3798E$��/Fonts/#GGX88)�5      $
��Bold"�5      $��Center=�5      $��	Underline{�5      5      �� 5      -   5          ��Name$  PROGcheckBox��5      $b��\ Programming 2B 
 - Module Code: PROG6212 
 - Module Credits: 15 
 - Class hours per week: 5��5      $��15(�5      $��15,55,0,-22q�5      $��/Fonts/#GGX88)�5      
������� � Cursor$
 Hand��5      �� 5      -   5        $  ADDBcheckBox��5      $f��` Advanced Databases 
 - Module Code: ADDB7311 
 - Module Credits: 15 
 - Class hours per week: 5��5      $��15(�5      $��15,147,0,-72q�5       $��/Fonts/#GGX88)�5!      
�������$
 Hand��5#      �� 5%      -   5        $  SOENcheckBox��5%      $h��b Software Engineering 
 - Module Code: SOEN6222 
 - Module Credits: 15 
 - Class hours per week: 5��5&      $��15(�5'      $��15,237,0,-122q�5(      $��/Fonts/#GGX88)�5)      
�������$
 Hand��5+      �� 5-      -   5        $  CLDVcheckBox��5-      $i��c Cloud Development 2B 
 - Module Code:  CLDV6212 
 - Module Credits: 15 
 - Class hours per week: 5��5.      $��15(�5/      $��15,330,0,-170q�50      $��/Fonts/#GGX88)�51      
�������$
 Hand��53      �� 56      $	��400��6   $	��200��57       �� CornerRadius$ 10��58      $��
340,55,0,0q�59      
������ ���	#FF13819F._�5=      �� .+�5>      �� $'��!Select the first week start date:��6    $��15(�5?       
�������$��/Fonts/#GGX88)�5A       $
��Left=�5B       $��2,0,0,0q�5C       $��	Underline{�5D       5E      (  "System.Windows.Controls.DatePicker  5F      -   5          Name$ WeeksDatePicker��5F   !   ���#F3798E$��0,10,0,0q�5I   !   $
��Left=�5J   !   $	��300��5K   !   ���#084E62��5H   !   Z� 5L   !   �� 5O      $3��-Enter in the number of weeks in the semester:��6    $��15(�5P       
�������$��/Fonts/#GGX88)�5R       $
��Left=�5S       $��2,50,0,0q�5T       $��	Underline{�5U       5V      �� 5^      $ 10��6   ���#F3798E$	��300��5`      $
��Left=�5a      $��0,15,0,0q�5b      ._�5c      �� -   5         ��Name$ WeeksTextBox2��5c   "   $
��Left=�5d      $	��300��5e      $��30��5f      
������ $��0,0,0,0q�5h      ���#CFCFCF$��Center=�5j      $��0q�5k      $��5q�5l      $ IBeam��5m      5n      5p      5q      5t      �� 5w      $	��400��6   $	��200��5x      $ 10��5y      $��	340,0,0,0q�5z      
������ ���	#FF13819F._�5}      &   System.Windows.Controls.DataGrid  -   5          Name$ userModulesDataGrid��5}      5~      �� 5�   
   -   5         ��Name$ SubmitButton��5�      $��Submit��5�      $��Center=�5�      $	��100��5�      $��2,20,0,0q�5�      $��25��5�      $��0q�5�      5�      5�      5�      