   M S B A M L   `   `   `  ����G  CPPE3_Daltons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:PPE3_Daltons.Employees.Compte_Rendu_Intervention0PPE3_Daltons.Employees.Compte_Rendu_Intervention  5      o<clr-namespace:PPE3_Daltons.Employees.Intervention_technicien.PPE3_Daltons.Employees.Intervention_technicien  5      ?    9PPE3_Daltons.Employees.Main_technicien.MainTechnicienView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Gsdk9http://schemas.microsoft.com/netfx/2009/xaml/presentation    5      ^CompteRenduTechnicien>clr-namespace:PPE3_Daltons.Employees.Compte_Rendu_Intervention    5      ]InterventionTechnicien<clr-namespace:PPE3_Daltons.Employees.Intervention_technicien    5      b ^Telerik.Windows.Data, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.Controls.VirtualGrid, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GridView, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Data, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l	 hTelerik.Windows.Controls.Input, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s
 oTelerik.Windows.Controls.ScheduleView, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f bTelerik.Windows.Controls, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Navigation, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Documents.Proofing.RadGridView, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Otelerik1http://schemas.telerik.com/2008/xaml/presentation	     	 
    5	      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   $��2��6     5      �� 5      $
��Auto �6    �� 5      .+�5      *  $Telerik.Windows.Controls.RadGridView  -   5          Name$ RadGridView1��5   "   8  2Telerik.Windows.Controls.GridView.BaseItemsControl   GroupRenderMode$
 Flat=�68   ;  5Telerik.Windows.Controls.GridView.GridViewDataControl   SelectionMode$ Extended=�5   	      AutoGenerateColumns .  $��0,5,0,0q�5   	   $��0��5    	      ShowGroupPanel .     ActionOnLostFocus$
 None=�5"   	   *  $Telerik.Windows.Controls.DataControl$   IsSynchronizedWithCurrentItem$
 TrueY�5#   "   	   CanUserFreezeColumns	 .  
   RowIndicatorVisibility$
 	Collapsed=�5%   	      ItemsSource 5   	   �� *DataTechnicien+   SelectedItem 5   
   �� *SelectedItem+   Columns 5&      1  +Telerik.Windows.Controls.GridViewDataColumn  5'      6  0Telerik.Windows.Controls.GridViewBoundColumnBase   Header$	 Nom��62   -  'Telerik.Windows.Controls.GridViewColumn   IsFilterable .    ShowFieldFilters .     DataMemberBinding 6?   �� *Nom+6u     5(      $ Prenom��62    .  .   6V   �� *Prenom+6{     5)      $ 	Telephone��62    6E   �� *Tel+  5*      $ Id_Materiel��62      Width?  9Telerik.Windows.Controls.GridView.GridViewLengthConverter$ * 6q    6G   �� *Id_Materiel+6q   5,      �� 5-      $��1��6   .+�5.      �� $��	Supprimer��6>   ��6   �� *DeleteTechnicien+6>   �� 5/      $��Modifier��6>   ��6   �� *UpdateTechnicien+6>   51      52      � 53   
   $��1��6   $��0��6    55      �� 56      $
��Auto �6#   �� 57      $	��550 �6#     59      �� 5:      �� 5;      �� 5<      �� 5=      �� 5>      �� 5?      .+�5B      �� $��Ajouter un client��6   $
��Left=�60   $��2��6K   $��0��6_   $��0��6o   $	��Top=�6}   �� 5D      $	��Nom��6   $
��Left=�6"   $	��Top=�6>   $��0��6V   $��1��6f   �� 5E      $
��Left=�6   $��23��61    �� TextWrapping$
 Wrap=�6=   $	��Top=�6Q    �� 	MaxLength$ 75��6j   $	��550��6z   $��1��6�   $��1��6�   ��5F      �� *Nom+�� 5H      $��Prénom��6   $
��Left=�6%   $	��Top=�6A   $��0��6Y   $��2��6i   �� 5I      $
��Left=�6   $��23��61   $
 Wrap=�6=   $	��Top=�6Q   $ 75��6j   $	��550��6y   $��1��6�   $��2��6�   ��5J      �� *Prenom+�� 5L      $��Téléphone��6   $
��Left=�6(   $	��Top=�6D   $��0��6\   $��3��6l   �� 5M      $
��Left=�6   $��23��61   $
 Wrap=�6=   $	��Top=�6Q   $ 75��6j   $	��550��6y   $��1��6�   $��3��6�   ��5N      �� *Tel+�� 5P      $��Id_matériel��6   $
��Left=�6*   $	��Top=�6F   $��0��6^   $��4��6n   �� 5Q      $
��Left=�6   $��23��61   $
 Wrap=�6>   $	��Top=�6R   $ 75��6k   $	��550��6z   $��1��6�   $��4��6�   ��5R      �� *Id_Materiel+�� 5T      $��Ajouter��6   $��0��6I   $��2��6Y   $��5��6m   ��6'   �� *AddTechnicien+6m   5V      � 5W   
   $��1��6   $��1��6   .+�5X        -   5        $ RadGridView2��5X   "   $
 Flat=�68   $ Extended=�5Z   	    .  $��0,5,0,0q�5\   	   $��0��5]   	    .  $
 None=�5_   	   	 .  $
 	Collapsed=�5a   	    5Y   	   �� *DataMateriel+ 5b        5c      $ Id_Materiel��62    .   6G   �� *Id_Materiel+6q     5d      $ Modèle��62    .  .   6V   �� *Modele+6{     5e      $ Numéro de Série��62    .   6K   �� *	Num_serie+6s   5g      5h      5i      5j      