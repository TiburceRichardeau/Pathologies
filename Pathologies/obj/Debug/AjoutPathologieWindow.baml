   M S B A M L   `   `   `  ����F  BPathologies, Version=1.1.1.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PathologiesPathologies  5   	   '    !Pathologies.AjoutPathologieWindow   5   	   U QMaterialDesignThemes.Wpf, Version=2.2.1.750, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Pathologies     5   	   -   5           MaterialDesignBody#���   5   	     � Title$  AjoutPathologieWindow��5
   	   $	��440��6'   $��633.028��64    � 
ResizeMode$ NoResize=�6D    � WindowStartupLocation$ CenterScreen=�6Z   .��5      � .+�5   
   �� -   5         ��Name$ label��5      $��Ajouter une Pathologie��6   $
��Left=�6@   $��	214,0,0,0q�6[   $	��Top=�6n   $
��Bold"�6�   $��16(�6�   $��Italic$�6�   �� 5   
   -   5        $ label1��5      $��Pathologie :��6    $
��Left=�67   $��	10,60,0,0q�6R   $	��Top=�6e   �� 5   
   -   5         ��Name$ tb_pathologie��5      $
��Left=�6)   $��69��6D   $��	87,63,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��206��6�   �� 5   
   $
��Left=�6   $��21��6/   $��173,183,0,0q�6;   $	��Top=�6P   $	��270��6h    J� RenderTransformOrigin$ 0.5,0.5&�6t   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 90Q�6&   T� 5      5      5      �� 5   
   -   5        $ label2��5      $��Causes :��6    $
��Left=�63   $��
10,160,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ 	tb_causes��5      $
��Left=�6%   $��69��6@   $��
87,162,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��206��6�   �� 5   
   -   5        $ label2_Copy��5      $��Symptomes :��6%   $
��Left=�6;   $��
10,255,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $ tb_symptomes��5      $
��Left=�6(   $��69��6C   $��
87,257,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��206��6�   �� 5   
   -	   5        $ label1_Copy��5      $��Approche
 Alimentaire :��6%   $
��Left=�6P   $��
315,63,0,0q�6k   $	��Top=�6   $��81��6�   �� 5   
   -
   5        $ tb_app_alimentaire��5      $
��Left=�6.   $��69��6I   $��
401,63,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��206��6�   �� 5    
   -   5        $ label2_Copy1��5       $"��Compléments
Alimentaires :��6&   $
��Left=�6T   $��312,162,0,0q�6o   $	��Top=�6�   �� 5!   
   -   5        $ tb_complement_ali��5!      $
��Left=�6-   $��69��6H   $��401,162,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��206��6�   �� 5"   
   -   5        $ label2_Copy2��5"      $��Autres 
Approches :��6&   $
��Left=�6M   $��315,255,0,0q�6h   $	��Top=�6}   �� 5#   
   -   5        $ tb_autres_approches��5#      $
��Left=�6/   $��69��6J   $��401,257,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��206��6�   �� 5$   
   -   5        $��but_valider��5$   6   $
��Auto��6   $��271,353,266,10q�6   .��5%      ��  �� Orientation$ 
Horizontal=�6   $��70��62   .+�5&      �� $��Ajouter��6   $��Center=�6+   5'      5(      5*      5+      