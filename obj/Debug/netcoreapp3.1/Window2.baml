   M S B A M L   `   `   `  ����C  ?MoviesDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MoviesDBMoviesDB  5   	       MoviesDB.Window2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MoviesDB     5   	     � Title$  Add (Edit) Cinema��5   	   $	��450��6#   $	��500��60    � WindowStartupLocation$ CenterScreen=�6<    � Icon$ /и4.PNG��6a   .��5	      � ���	#FF9FC5B5.+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��10,30q�6.   $	��Top=�6=   .+�5      �� $��Cinema Name��6   $��20(�6+   $	��130��69   $��30��6E   $��10,10q�6R   �� 5      -   5        $��textbox1��5      $��30��6&   $��20(�62   $	��300��6@   $��10,10,10,10q�6L    � ForceCursor$
 True��6a   5      �� 5   
   $ 
Horizontal=�6   $��10,10,10,230q�6.   $��Center=�6D   .+�5      �� $��Place count��6   $��20(�6+   $	��130��69   $��30��6E   $��10q�6R   �� 5      -   5         ��Name$ textbox2��5      $��20(�6(   $	��150��66   $��10q�6B   5      �� 5   
   $��10,150,10,80q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	datagrid1��5      $	��190��6*      
IsReadOnly$
 True��67      AlternatingRowBackground �	#FFB8D8CB	   AutoGenerateColumns$	 False��6n   $
 True��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Movie_Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6;      	FontStyle$ Italic$�6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Y   �� *	MovieId+  5      $ 
Movie_Name��6)   $ Italic$�6=    6P   �� *
Movie_Name+  5      $ Start_datetime��6)   $ Italic$�6A   $	 130 6T    6`   �� *start_datetime+5      5      �� 5   
   $��10,40,10,20q�6   $��Bottom=�6*   $ 
Horizontal=�6E   .+�5      �� -   5         ��Name$ 	buttonAdd��5      $
��Save��6@   $��90��6P   $��20,10,10,10q�6[   �� 5      -   5        $ cancel��5      $��Cancel��6:   $��90��6L   $��10,10,10,10q�6W   �� 5      -   5        $ addmovie��5      $��AddMovie��6>   $��20,10,10,10q�6Q   $��90��6f   �� 5      -   5        $ delmovie��5      $��RemoveMovie��6>   $��10,10,10,10q�6T   $��90��6i   5       5"      5#      