   M S B A M L   `   `   `  ���� E  AMonoReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MonoReadMonoRead      MonoRead.PlayerWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:MonoRead     -     � Title$  PlayerWindow��$	��490��$	��800�����	#FF151515 � WindowStyle$
 None=� � AllowsTransparency .  � 
ResizeMode$ NoResize=�.��� $��0,0,0,0q�.+��� -    ��Name$ DisplayLabel��$��Press Play to Begin��$��Arial Rounded MT Bold)�$��Center=�$��Center=�$��Center=�$��86��$	��780��
�������$��48(��� -   $
��Left=�$��38��$	��Top=�$	��708�����	#FF151515�� -    ��Name$ CloseButton��   CloseButton#���   $��X��$
��Left=�$��	757,1,0,0q�$	��Top=�$��38��$��44�����	#FFFF5D5D
���   ���Z� �� -   $ MinimiseButton��  MinimiseButton#���  $��-��$
��Left=�$	��Top=�$��38��$��44�����	#FF151515
�������$��	713,1,0,0q���Z� �� -    ��Name$ PositionSlider��$��Center=�$��	0,370,0,0q�$	��Top=�$	��714���� -   $ 
RateSlider��$
��Left=�$��
93,426,0,0q�$	��Top=�$	��199�� � Minimum$	 200Q� � Maximum$	 500Q�	 � Value$		 300Q�
 � SmallChange$
 1Q��� -   $ 	RateLabel��$	��300��$��Center=�$
��Left=�$��173,449,0,0q�$	��Top=�$��31��$��39��$��Normal$�$��Arial Rounded MT Bold)�
�������$��16(��� -	    ��Name$ 	PlayPause��$��Center=�$	��100��$��	0,386,0,0q�$	��Top=�$	��100��$��PlayIcon.png��