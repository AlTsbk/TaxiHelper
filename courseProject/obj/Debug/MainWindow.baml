   M S B A M L   `   `   `  ����H  DcourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:courseProjectcourseProject  5   	       courseProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:courseProject     5   	     � Title$  
MainWindow��5   	    � WindowStyle$
 None=�6    � WindowState$ 	Maximized=�60   $	��700��6H   $
��1400��6X   $��5 5 5 0q�6h   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      CaptionHeight$ 35Q�6   6-   .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      $��* �6   6)   .+�5   
   � $��0��6   ���#2a282b$��0q�61   .+�5      �� $��
img\Th.png��6      Icon#��[  6(   $��25��6F   $��25��6Q   $��Center=�6]   6z   �� 5      -   5         ��Name$ AutorizeName��5   >     AutorizeName#��[ 6   6V   �� 5      -   5           IsHitTestVisibleInChrome .   CloseBt#��[ 5   B   $��0 5 5 0q�6z     closeBt#���  6�   ��6�   Z� .��5      F� -   5         F�Name$ Pt��5      =����        �@ @ � 5  5 �@  5 � 5 @ �@B @B 		 �� Stretch$	 Uniform=�6Y   ���#6C7367$��2��6|   $��20��6�   $��Center=�6�   5      5      � 5   
   $��1��6   
 � ColumnDefinitions
 5      �� 5      $	��77* �6#   �� 5      $
��177* �6#   .+�5      �   Content#��[ 6   $��2��64   
 5      �� 5      $
��350* �6'   66   �� 5       $��1500* �6'   67   .+�5"      � -   5         �Name$ ForAdminAndManager��5"   H   $��0��6     SideBar#��[ 6'    5#      �� 5$      $
��250* �6(   68   �� 5%      $	��80* �6(   67   �� 5&      $	��80* �6(   67   �� 5'      $	��80* �6(   67   �� 5(      $	��80* �6(   67   �� 5)      $
��230* �6(   68   .+�5+      � $��0��6   .+�5,      �� -   5         ��Name$ 	UserImage��5,       $��img\Manager-Photo.png��63   $	��170��6R   $	��170��6^   6m   5-      �� 5.      -   5        $
��Home��5.   t   $��1��6     buttonStyle#��[ 6*   #���  6O   .��5/      ��  �� Orientation$ 
Horizontal=�6%   .+�50      ��   	IconStyle#��[ 6(   $	����6K   6V   �� 51        MenuTextStyle#��[ 6(   $��Главная��6O   6`   52      53      �� 55      -   5        $��Trips��55   t   $��2��6   #��[ 6*   #���  6O   .��56      �� $ 
Horizontal=�6%   .+�57      �� #��[ 6(   $	����6K   6V   �� 58      #��[ 6(   $��Поездки��6O   6`   59      5:      �� 5;      -   5        $��CompanyAssets��5;   t   $��3��6   #��[ 6*   #���  6O   .��5<      �� $ 
Horizontal=�6%   .+�5=      �� #��[ 6(   $	����6K   6V   �� 5>      #��[ 6(   $#��Активы компании��6O   6h   5?      5@      �� 5A      -	   5        $��
AdminPanel��5A   t   $��3��6   #��[ 6*   #���  6O   $y�Hidden=�6�   .��5B      �� $ 
Horizontal=�6%   .+�5C      �� #��[ 6(   $	����6K   6V   �� 5D      #��[ 6(   $��Панель админа��6O   6f   5E      5F      �� 5G      -
   5        $��4��5G      #��[ 6*   #���  6d   .��5H      �� $ 
Horizontal=�6%   .+�5I      �� #��[ 6(   $	����6K   6V   �� 5J      #��[ 6(   $��
Выход��6O   6^   5K      5L      � 5N      $��6��6   .+�5O      �� $ 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5P      �� $
��Taxi��6(    	 Logo#��[	 65   ���#ffde006j   �� 5Q      $��Helper��6(   #��[	 67   ���#ffffff6l   5R      5S      5U      � 5V      -   5        $ 	ForDivers��5V   H   $��0��6   #��[ 6'   $y�Hidden=�6[    5W      �� 5X      $
��250* �6(   68   �� 5Y      $	��80* �6(   67   �� 5Z      $	��80* �6(   67   �� 5[      $	��80* �6(   67   �� 5\      $
��310* �6(   68   .+�5^      � $��0��6   .+�5_      �� -   5        $ 
UserImageD��5_       $��img\Driver-Photo.png��64   $	��170��6R   $	��170��6^   6m   5`      �� 5a      -   5        $��Profile��5a   t   $��1��6   #��[ 6*   #���  6O   .��5b      �� $ 
Horizontal=�6%   .+�5c      �� #��[ 6(   $	����6K   6V   �� 5d      #��[ 6(   $��Профиль��6O   6`   5e      5f      �� 5h      -   5        $��DriversTrips��5h   t   $��2��6   #��[ 6*   #���  6O   .��5i      �� $ 
Horizontal=�6%   .+�5j      �� #��[ 6(   $	����6K   6V   �� 5k      #��[ 6(   $��Поездки��6O   6`   5l      5m      �� 5o      -   5        $��3��5o      #��[ 6*   #���  6d   .��5p      �� $ 
Horizontal=�6%   .+�5q      �� #��[ 6(   $	����6K   6V   �� 5r      #��[ 6(   $��
Выход��6O   6^   5s      5t      � 5v      $��6��6   .+�5w      �� $ 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5x      �� $
��Taxi��6(   #��[	 65   ���#ffde006j   �� 5y      $��Helper��6(   #��[	 67   ���#ffffff6l   5z      5{      5}      � 5~      -   5        $ ContentField��5~   '   $��1��6   .+�5       � -   5          �Name$ myFrame��5      6/   5�      5�      5�      5�      5�      