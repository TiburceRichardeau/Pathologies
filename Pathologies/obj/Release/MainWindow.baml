   M S B A M L   `   `   `  ���� F  BPathologies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PathologiesPathologies      Pathologies.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Pathologies       � Title$  Pathologies v1.0 - by AD��$	��652��$
��1209�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=�$	��450��$	��700��.��� .+�`� $	��Top=�$��28��$	��Top=�$��Stretch=�.�c� -    c�Name$ toolBar��$
��Left=� `� IsLocked . $	��Top=�$��28��$	��228��$��	0,0,-20,0q�.@��� -    ��Name$ but_ajouter��$��	0,-2,0,-3q�$
��Left=�$	��Top=�$��28��.����  �� Orientation$ 
Horizontal=�$	��149��.+��� $��img/report_add.png��$��16��$��16��$��0,0,10,0q��� $��Ajouter une pathologie��$��Center=��� �� -   $��but_bug�� � ToolTip$ Signaler un bug.��$��Right=�.���� $��img/bug.png���� -    ��Name$ imj_maj��$��16��$	��Top=�$��16��$��10,4,0,0q�� -   $��grid_bottom��$��Stretch=�$��32��$��	0,287,0,0q�$��Bottom=����	#FFEEEEEE.+��� -   	 ��Name$	 	lb_nb_pat��$�� ��$
��Left=�$��12,3,0,0q�$	��Top=�$	��397���� -   $��
lb_version��$��Italic$�$
��Bold"�$��Right=�$��Right=�$��Bottom=�$��32��$	��105��&   System.Windows.Controls.DataGrid  -   
  Name$
 dataGrid��$��Stretch=�   AutoGenerateColumns .     
IsReadOnly . $��335,56,19,51q�$��Stretch=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *nom+  $ Causes��$
 Auto  �� *causes+  $ 	Symptomes��$
 Auto  �� *	symptomes+  $ Approche Alimentaire��$
 Auto  �� *approche_alimentaire+  $ Compléments Alimentaires��$
 Auto  �� *complements_alimentaires+  $ Autre Approche��$ *  �� *autre_approche+ � ContextMenu �� .@�m� -	   $��	supprimer��$��	Supprimer�� m� Icon �� $��img/delete.png��m� -
   $��modifier��$��Modifier�� �� $��img/edit.png���� -   $	 label1��$��
Rechercher��$
��Left=�$��
31,112,0,0q�$	��Top=��� -    ��Name$ tb_recherche��$
��Left=�$��29��$��
31,138,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��195���� -    ��Name$ groupBox��$��Options��$
��Left=�$��
17,191,0,0q�$	��Top=�$	��144��$	��261��	� -    	�Name$ rb_all��$��Toutes les colonnes�� 	� 	GroupName$ options�� d� 	IsChecked$
 TrueY�$
��Left=�$��
31,215,0,0q�$	��Top=�	� -   $ rb_cause��$��Causes��$ options��$
��Left=�$��
31,246,0,0q�$	��Top=�	� -   $ rb_symptomes��$��
Symptômes��$ options��$
��Left=�$��
31,263,0,0q�$	��Top=�	� -   $ rb_app_alimentaire��$��Approche Alimentaire��$ options��$
��Left=�$��
31,280,0,0q�$	��Top=�	� -   $ rb_compl_alimentaire��$��Compléments Alimentaires��$ options��$
��Left=�$��
31,298,0,0q�$	��Top=�	� -   $ rb_autre��$��Autre Approche��$ options��$
��Left=�$��
31,315,0,0q�$	��Top=�	� -   $ rb_nom��$��Nom Pathologie��$ options��$
��Left=�$��
31,230,0,0q�$	��Top=�