   M S B A M L   `   `   `  ����H  DcourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:courseProjectcourseProject  5   	       courseProject.login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:courseProject     5   	     � Title$  Login��5   	   $	��600��6   $	��400��6%    � 
ResizeMode$ NoResize=�61    � WindowStyle$
 None=�5	   	    	  Login#��[  5
   	   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 35Q�6   6-   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��30 �6    6.   �� 5      $
��400* �6    60   �� 5      $
��200* �6    60   �� 5      $
��200* �6    60   �� 5      $
��200* �6    60   �� 5      $
��300* �6    60   .+�5      � $��0��6      IsHitTestVisibleInChrome . .+�5      �� -   5          CloseBt#��[ 5        closeBt#���  6Q   ���#3F3B40.��5      F� -   5         F�Name$ Pt��5      =����        �@ @ � 5  5 �@  5 � 5 @ �@B @B 	 �� Stretch$ Uniform=�6]   ���#6C7367$��2��6�   $��20��6�   $��Center=�6�   5      5      � 5      $��1��6   .+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5       �� $
��Taxi��6      Logo#��[ 6-   ���#ffde006b   �� 5!      $��Helper��6    #��[ 6/   ���#ffffff6d   5"      5#      � 5$      $��2��6   .+�5%      �� $��login��6     
loginLabel#��[ 6(   6N   �� 5&      -   5        
 ��Name$
 LoginBox��5&        loginBox#��[ 6,   6P   5'      � 5(      $��3��6   .+�5)      �� $��Password��6   #��[ 6,   6R   G� 5*      -   5         G�Name$ PasswordBox��5*        PasswordBox#��[ 63   6Z   5+      � 5,      $��4��6   .+�5-      �� -   5        $��
Войти��5-        LoginButton#��[ 6)     sumbitBt#���  6i   6�   5.      � 50      $��5��6   .+�51      �� -   5         ��Name$ WarningMessage��51       	 WarningMessage#��[	 64   6^   52      53      54      55      