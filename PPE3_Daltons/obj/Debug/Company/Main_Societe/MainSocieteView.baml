   M S B A M L   `   `   `  ����G  CPPE3_Daltons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:PPE3_Daltons.Company.Compte_rendu_Societe)PPE3_Daltons.Company.Compte_rendu_Societe  5      e7clr-namespace:PPE3_Daltons.Company.Intervention_Societe)PPE3_Daltons.Company.Intervention_Societe  5      7    1PPE3_Daltons.Company.Main_Societe.MainSocieteView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Gsdk9http://schemas.microsoft.com/netfx/2009/xaml/presentation    5      TCompteRenduSociete7clr-namespace:PPE3_Daltons.Company.Compte_rendu_Societe    5      UInterventionSociete7clr-namespace:PPE3_Daltons.Company.Intervention_Societe    5      b ^Telerik.Windows.Data, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.Controls.VirtualGrid, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GridView, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Data, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l	 hTelerik.Windows.Controls.Input, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7s
 oTelerik.Windows.Controls.ScheduleView, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f bTelerik.Windows.Controls, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Navigation, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Documents.Proofing.RadGridView, Version=2017.3.1018.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Otelerik1http://schemas.telerik.com/2008/xaml/presentation	     	 
    5	      .��5      �   � RowDefinitions  5      �� 5      $
��Auto �6   �� 5      $��* �6   .+�5      � $��0��6	   $��0��6   $��2��6&     5      �� 5      $
��Auto �6   �� 5      .+�5      *  $Telerik.Windows.Controls.RadGridView  8  2Telerik.Windows.Controls.GridView.BaseItemsControl   GroupRenderMode$
 Flat=�6   ;  5Telerik.Windows.Controls.GridView.GridViewDataControl   AutoGenerateColumns .  $��10q�5#   	   $��0��5$         ShowGroupPanel .     ActionOnLostFocus$
 None=�5&   	      CanUserFreezeColumns .     RowIndicatorVisibility$ 	Collapsed=�5(   	   *  $Telerik.Windows.Controls.DataControl   ItemsSource 5    	   �� *DataSociete+   SelectedItem 5!   	   �� *SelectedSociete+	   Columns	 5*      1  +Telerik.Windows.Controls.GridViewDataColumn  5+      6  0Telerik.Windows.Controls.GridViewBoundColumnBase
   Header$	
 Nom��6#   -  'Telerik.Windows.Controls.GridViewColumn   IsFilterable .    ShowFieldFilters .     DataMemberBinding 6]   �� *Nom_societe+  5,      $
 Adresse��62      Width?  9Telerik.Windows.Controls.GridView.GridViewLengthConverter$ * 6r    6C   �� *Adresse_societe+6r     5-      $
 CP��6#    6/   �� *
Cp_societe+  5.      $
 Ville��6#    62   �� *Ville_societe+  5/      $
 	Telephone��6#    66   �� *Tel_societe+  50      $
 Email��6#    62   �� *Email_societe+52      �� 53      $��1��6   .+�54      �� $��	Supprimer��6/   ��6   �� *DeleteSociete+6/   �� 55      $��Modifier��6/   ��6   �� *UpdateSociete+6/   57      58      � 59      $��1��6	   $��0��6   .+�5:      �  � ColumnDefinitions 5;      �� 5<      $
��Auto �6   �� 5=      $��* �6'     5?      �� 5@      �� 5A      �� 5B      �� 5C      �� 5D      �� 5E      �� 5F      �� 5G      .+�5J      �� $��Ajouter un client��6   $
��Left=�6(   $��2��6C   $��0��6W   $��0��6g   $	��Top=�6u   �� 5L      $��Nom Société��6   $
��Left=�6"   $	��Top=�6>   $��0��6V   $��1��6f   �� 5M      $
��Left=�6   $��23��65    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U    �� 	MaxLength$ 75��6n   $	��550��6~   $��1��6�   $��1��6�   ��5N      �� *Nom_societe+�� 5P      $��Adresse��6   $
��Left=�6   $	��Top=�6:   $��0��6R   $��2��6b   �� 5Q      $
��Left=�6   $��23��6)   $
 Wrap=�65   $	��Top=�6I   $ 75��6b   $	��550��6q   $��1��6}   $��2��6�   ��5R      �� *Adresse_societe+�� 5T      $��Code Postale��6   $
��Left=�6#   $	��Top=�6?   $��0��6W   $��3��6g   �� 5U      $
��Left=�6   $��23��6)   $
 Wrap=�65   $	��Top=�6I   $ 75��6b   $	��550��6q   $��1��6}   $��3��6�   ��5V      �� *
Cp_societe+�� 5X      $��Ville��6   $
��Left=�6   $	��Top=�68   $��0��6P   $��4��6`   �� 5Y      $
��Left=�6   $��23��6)   $
 Wrap=�66   $	��Top=�6J   $ 75��6c   $	��550��6r   $��1��6~   $��4��6�   ��5Z      �� *Ville_societe+�� 5\      $��	Telephone��6   $
��Left=�6    $	��Top=�6=   $��0��6U   $��5��6e   �� 5]      $
��Left=�6   $��23��6)   $
 Wrap=�66   $	��Top=�6J   $ 75��6c   $	��550��6r   $��1��6~   $��5��6�   ��5^      �� *Tel_societe+�� 5`      $��Email��6   $
��Left=�6   $	��Top=�69   $��0��6Q   $��6��6a   �� 5a      $
��Left=�6   $��23��6)   $
 Wrap=�65   $	��Top=�6I   $ 75��6b   $	��550��6q   $��1��6}   $��6��6�   ��5b      �� *Email_societe+�� 5d      $��Ajouter��6   $��0��6>   $��2��6N   $��7��6b   ��6   �� *
AddSociete+6b   5e      5f      5g      5h      