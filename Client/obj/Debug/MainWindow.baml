   M S B A M L   `   `   `  ����
  Client    Client.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	Generator��5   	   $	��480��6   $	��640��6(   
������� � 
ResizeMode$ 	CanResize=�6G   .��5      � 
�������.+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      � $
��Left=�6   .+�5	      �� $ 
Horizontal=�6   .+�5
      �� $.��(Choisir le(s) fichier(s) à décrypter :��6   �� 5      -   5        $��Parcourir...��5      $
��Left=�64   $��83��6O   $��27��6v   5      5      ]� 5      .+�5      �� $
��Left=�6   .+�5      �� -   5         ��Name$ 	lst_files��5      ��62   �� *	docList+ �� View 5      �� 5      .P�5   "   ��  �� Width$	 100��61   $��Document��6=    �� DisplayMemberBinding 6O   �� *Name+�� 5   "   $	 100��61   $��Statut��6=    6M   �� *Status+5      5      � 5      .+�5      �� -   5         ��Name$ btn_envoyer��5   !   $��Envoyer��6b   y�66   �� *BtnEnvoyerVisibility+6t   � 5      -   5         �Name$ progressBar��5   &   	 � IsIndeterminate	 . y�6;   �� *ProgressBarVisibility+6h   5      �� 5      $ 
Horizontal=�6!   .+�5       �� 
���   �$��Document : ��63   �� 5!      -   5        
 ��Name$
 tb_resultName��5!   $   $��Right=�6;   $
��Wrap=�6R   
���   ���6y   �� *TextResultName+5"      �� 5#      $ 
Horizontal=�6!   .+�5$      �� 
���   �$��Clé de décryptage : ��63   �� 5%      -   5        $
 tb_resultKey��5%   $   $��Right=�6:   $
��Wrap=�6Q   
���   ���6x   �� *TextResultKey+5&      �� 5'      $ 
Horizontal=�6!   .+�5(      �� 
���   �$��Email : ��63   �� 5)      -   5        $
 tb_resultMail��5)   $   $��Right=�6;   $
��Wrap=�6R   
���   ���6y   �� *TextResultMail+5*      �� 5+      $ 
Horizontal=�6!   .+�5,      �� 
���   �$��Taux de confiance : ��63   �� 5-      -   5        $
 tb_resultTaux��5-   $   $��Right=�6;   $
��Wrap=�6R   
���   ���6y   �� *TextResultTaux+5.      5/      �� 51      .+�52      �� $��Visible=�6#   .��53      �� -	   5        $
 tb_resultContent��53   $   $	��400��6>   $��Right=�6K   $
��Wrap=�6b   
���   ���6�   �� *TextResultContent+54      55      56      58      5:      5;      