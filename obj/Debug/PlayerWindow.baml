   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MonoReadMonoRead  5   	       MonoRead.PlayerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MonoRead     5   	   -   5          � Title$  PlayerWindow��5   	   $	��490��6   $	��800��6+   ���	#FF151515 � WindowStyle$
 None=�5	   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�66   .��5
      � $��0,0,0,0q�6   .+�5   
   �� -   5         ��Name$ DisplayLabel��5      $��Press Play to Begin��6&   $��Arial Rounded MT Bold)�6D   $��Center=�6g   $��Center=�6�   $��Center=�6�   $��86��6�   $	��780��6�   
�������$��48(�6�   �� 5   
   -   5        $
��Left=�5      $��38��6/   $	��Top=�6;   $	��708��6S   ���	#FF1515156   �� 5   
   -   5         ��Name$ CloseButton��5   7      CloseButton#���   6   $��X��6L   $
��Left=�6X   $��	757,1,0,0q�6s   $	��Top=�6�   $��38��6�   $��44��6�   ���	#FFFF5D5D
���   ���6�   Z� 6�   �� 5   
   -   5        $ MinimiseButton��5   :     MinimiseButton#���  6   $��-��6R   $
��Left=�6^   $	��Top=�6y   $��38��6�   $��44��6�   ���	#FF151515
�������$��	713,1,0,0q�6  ��6�   Z� 6  �� 5   
   -   5         ��Name$ PositionSlider��5      $��Center=�6)   $��	0,370,0,0q�6F   $	��Top=�6Y   $	��714��6q   6  �� 5   
   -   5        $ 
RateSlider��5      $
��Left=�6%   $��
93,426,0,0q�6@   $	��Top=�6T   $	��199��6l    � Minimum$	 200Q�6x    � Maximum$	 500Q�6�   	 � Value$		 300Q�6�   
 � SmallChange$
 1Q�6�   6�   �� 5   
   -   5        $ 	RateLabel��5      $	��300��6#   $��Center=�61   $
��Left=�6U   $��173,449,0,0q�6p   $	��Top=�6�   $��31��6�   $��39��6�   $��Normal$�6�   $��Arial Rounded MT Bold)�6�   
�������$��16(�6�   �� 5   
   -	   5         ��Name$ 	PlayPause��5      $��Center=�6$   $	��100��6A   $��	0,386,0,0q�6N   $	��Top=�6a   $	��100��6y   $��PlayIcon.png��6�   6�   5      5      