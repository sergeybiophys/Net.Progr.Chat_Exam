   M S B A M L   `   `   `  ����E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ChatClient.ViewsChatClient.Views  5   	   !    ChatClient.Views.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ChatClient.Views     5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5	   	     MaterialDesignFont#���  5
   	    � Title$	 ICQ��5   	   $	��450��6   $	��550��6"   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��70* �6   �� 5      $	��30* �6    � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $��8* �6   �� 5      $��2* �6   .+�5   
   �� $��Center=�6   $��Center=�62   $��0 5 0 0q�6M   y�5       �� *ConnectIsVisible+.+�5!      ��  �� Orientation$ 
Horizontal=�6   .+�5"      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��5$       % !MaterialDesignFloatingHintTextBox#��[ 5%      $	��100��5&      $��40��6$   ��5#      �� *
Username+5&   $   �� 5'      $��Connect��6   $��30��5(      $	��100��6!   $��	10 10 0 0q�5)      
��� � ���5+      �� *ConnectCommand+6:   5,      �� 5-      $��Oblique$�5.      
�������$
��Left=�50      $��Center=�6/   $%��username has already been taken��51      52      �� 54   
   $ 
Horizontal=�6   $��15 5 0 0q�6.   $��Center=�55   >   y�6   �� *WarningVisibility+.+�56      �� 
���������6   �� *
Username+62   �� 57      $��, ��6   
�������6"   �� 58      
�������$
��Bold"�6D   ��6   �� *
Receiver+6D   �� 59      $!�� will receive your messages��6   
�������6;   5:      �� 5>   
   $��1��6   $��0��6   $��Center=�5?      $��Disabled=�5@      $��	0,0,300,0q�5B      $��2��6%   ��5A      �� *MessagessItems+��5C      �� 5D       �� 
TargetType" ��6   .�5E      ��  �� Property � |�	 �� Value	 .  62   �� 5F       � {�	 .  62   5G      ��5I      �� 5J      .R�5K      ]� $��2q�6    ��.  $	��450��6A   .+�5L      � 
 � Orientation$
 
Horizontal=�6$   ��6=   �� *Align+.+�5M      �� $
��Bold"�5O   $   ��5M   (   �� *Sender+��5N   $   �� *	FontStyle+��5P   $   �� *Color+�� 5Q      $��WrapWithOverflow=�5T   $   ��5Q   (   �� *	Message+��5R   $   �� *Color+��5S   $   �� *	FontStyle+5T   $   5V      5W      5X      5Z      �� 5^   
   $��2��6   $��0��6"   $ 
Horizontal=�5_      $��Center=�5`      $��Center=�5a      ���#fafafa$��0,10,0,0q�5b   *   $	��515��5c      $��53��6!   .+�5d      �� $	��350��6   $��40��6"   $��13 0 0 0q�5e      $ Your Message��5f      #��[ 5g      $��Center=�5h      {�5i      �� *SendIsEnable+��5j      �� *TextMessage+5l      �� 5n   
   $��3��6   $��20 0 0 0q�6   $	��100��5o      $��30��6!   
��� � �$
��Send��5s      {�5p      �� *SendIsEnable+��5q      �� *SendCommand+5s      �� 5v   
   $��0��6   $��1��6   $��3��5w      $	��277��5y      
��� � �
�������$��Right=�5|      {�5x      �� *SendIsEnable+��5}      �� *Users+ �� SelectedItem 5~      �� *SelectedUser+5�      5�      