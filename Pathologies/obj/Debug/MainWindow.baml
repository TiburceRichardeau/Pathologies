   M S B A M L   `   `   `  ����F  BPathologies, Version=1.1.1.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PathologiesPathologies  5   	       Pathologies.MainWindow   5   	   U QMaterialDesignThemes.Wpf, Version=2.2.1.750, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Pathologies     5   	      MaterialDesignBody#���   5   	     � Title$  Pathologies v1.0��5
   	   $	��652��6"   $
��1209��6/    � WindowStartupLocation$ CenterScreen=�6<    � WindowState$ 	Maximized=�6a   $	��450��6y   $	��700��6�   .��5      � .+�5   
   � -   5        $��grid_bottom��5      $��Stretch=�6"   $��	0,589,0,0q�6@   .+�5      �� -   5         ��Name$ 	lb_nb_pat��5      $�� ��6'   $
��Left=�62   $��12,3,0,0q�6M   $��Bottom=�6_   $	��397��6z   �� 5      -   5        $��
lb_version��5      $��Italic$�6&   $
��Bold"�69   $��Right=�6K   $��Right=�6g   $��Bottom=�6�   $��32��6�   $	��105��6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $��Stretch=�6%      AutoGenerateColumns .     
IsReadOnly . $��335,56,19,51q�6q   $��Stretch=�6�      SelectionMode$ Single=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 Nom��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 Auto 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *nom+6J     5      $	 Causes��6%   $

 Auto 6P    65   �� *causes+6P     5      $	 	Symptomes��6%   $

 Auto 6V    68   �� *	symptomes+6V     5      $	 Approche Alimentaire��6%   $

 Auto 6l    6C   �� *approche_alimentaire+6l     5      $	 Compléments Alimentaires��6%   $

 Auto 6t    6G   �� *complements_alimentaires+6t     5      $	 Autre Approche��6%   $
 * 6`    6=   �� *autre_approche+6`    � ContextMenu 5       �� 5!      .@�5"      m� -   5        $��	supprimer��5"   2   $��	Supprimer��6    m� Icon 5#      �� 5$      $��img/delete.png��6$   5&      m� 5'      -   5        $��modifier��5'   1   $��Modifier��6    5(      �� 5)      $��img/edit.png��6$   5+      5,      5.      �� 5/   
   -   5        $ label1��5/      $��
Rechercher��6    $
��Left=�65   $��
31,112,0,0q�6P   $	��Top=�6d   �� 50   
   -   5         ��Name$ tb_recherche��50      $
��Left=�6(   $��29��6C   $��
31,138,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��195��6�   6�   �� 51   
   -	   5         ��Name$ groupBox��51      $��Options��6%   $
��Left=�66   $��
17,182,0,0q�6Q   $	��Top=�6e   $	��180��6}   $	��261��6�   	� 53   
   -
   5         	�Name$ rb_all��53      $��Toutes les colonnes��6&    	� 	GroupName$ options��6D    d� 	IsChecked$
 TrueY�6X   $
��Left=�6i   $��
31,227,0,0q�6�   $	��Top=�6�   6�   	� 55   
   -   5        $ rb_cause��55      $��Causes��6(   $ options��69   $
��Left=�6M   $��
31,260,0,0q�6h   $	��Top=�6|   6�   	� 56   
   -   5        $ rb_symptomes��56      $��
Symptômes��6,   $ options��6@   $
��Left=�6T   $��
31,277,0,0q�6o   $	��Top=�6�   6�   	� 57   
   -   5        $ rb_app_alimentaire��57      $��Approche Alimentaire��62   $ options��6Q   $
��Left=�6e   $��
31,294,0,0q�6�   $	��Top=�6�   6�   	� 58   
   -   5        $ rb_compl_alimentaire��58      $��Compléments Alimentaires��64   $ options��6W   $
��Left=�6k   $��
31,312,0,0q�6�   $	��Top=�6�   6�   	� 59   
   -   5        $ rb_autre��59      $��Autre Approche��6(   $ options��6A   $
��Left=�6U   $��
31,329,0,0q�6p   $	��Top=�6�   6�   	� 5:   
   -   5        $ rb_nom��5:      $��Nom Pathologie��6&   $ options��6?   $
��Left=�6S   $��
31,244,0,0q�6n   $	��Top=�6�   6�   �� 5=   
   -   5         ��Name$ but_ajouter��5=      $
��Left=�6@   $	��Top=�6[   $��28��6s   $��109,424,0,0q�6   $��Ajouter��6�   �� 5?   
   -   5        $��but_bug��5?       � ToolTip$ Signaler un bug��6    $
��Left=�6:   $	��Top=�6k   $��
20,0,0,589q�6�   .��5@      �� $��img/bug.png��6   5A      5D      5E      