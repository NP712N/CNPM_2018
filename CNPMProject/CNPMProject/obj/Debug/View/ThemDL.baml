   M S B A M L   `   `   `  ����F  BCNPMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CNPMProjectCNPMProject  5   	   1clr-namespace:CNPMProject.VMLCNPMProject.VML  5   	   =#clr-namespace:CNPMProject.ViewModelCNPMProject.ViewModel  5   	       CNPMProject.ThemDL   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CNPMProject     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   'vmlclr-namespace:CNPMProject.VML  5   	   3	viewModel#clr-namespace:CNPMProject.ViewModel  5   	      MaterialDesignBody#���   5      $��Regular"�5	      $��18(�5
      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   &    CNPMProject.VML.ViewModelLocator   AutoHookedUpViewModel .  � Title$ Quản lý đại lý��5   	   $	��450��6    $	��600��6-   ���#ECC3A2.��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      .+�5      � $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6+   ���#EB6D4A.��5       ]� .+�5!      �� $��Right=�6%   
������  �� Orientation$ 
Horizontal=�6V   	 � 	Resources	 5"      
 �� 
TargetType �� Property �� Value��%�   '��       �� 5#   "   "
 ��6(   .�5$   &   ��  � ��$ 2 4 2 4q�6?   6Q   �� 5%   &    � ��$ 40��6>   6K   5&   #   5'      .+�5(      �� -   5        $��button_closewindow��5(   %    c� OverflowMode$ AsNeeded=�5)      
��� E����5(   ?   �� *CloseWindowCommand+.��5*   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�6:   5+      5,      �� 5.      $
��Left=�6%   $ 
Horizontal=�6;   .+�5/      �� $��Center=�6(   $��16 0 0 0q�6C   ��6U   �� *Tag+ �� ElementName$ ucControlBar��6�   50      �� 51      $��Center=�52      $��16 0 0 0q�53      $
��Bold"�6   Thêm55      56      57      58      � 59      $��1��6   .+�5j      �� $��
Đại lý��5k        MaterialDesignGroupBox#���  5l      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5m      $	��580��5n      $	��320��5o      $	��Top=�5p       � UseLayoutRounding .  J� SnapsToDevicePixels . $��
10,10,10,0q�5r       .��5s      #  MaterialDesignThemes.Wpf.Card  $	��300��6*   .��5t      � .+�5u      � $��0��6#    � ColumnDefinitions 5v   "   �� 5w   &   �� 5x   &   .+�5z   "   �� -   5        $��txt_madaily��5{   !   $	��Top=�5|      $
��Left=�5~      $	��100��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã đại lý��5�       % !MaterialDesignFloatingHintTextBox#��[ 5�      $��	28,10,0,0q�6>   �� 5�   "   -   5        $��txt_mahopdong��5�   !   $	��Top=�5�      $
��Left=�5�      $	��127��5�      $ Mã hợp đồng��5�      #��[ 5�      $��	29,53,0,0q�6>   �� 5�   "   -   5        $��txt_cmnd��5�   !   $	��Top=�5�      $
��Left=�5�      $	��120��5�      $
 CMND��5�      #��[ 5�      $��
31,140,0,0q�6>   �� 5�   "   -   5        $��txt_hotenchudaily��5�   %   $	��Top=�5�      $
��Left=�5�      $	��170��5�      $  Họ tên chủ đại lý��5�      #��[ 5�      $��
29,185,0,0q�6>   �� 5�   "   -   5        $��txt_tendaily��5�   %   $	��Top=�5�      $
��Left=�5�      $	��150��5�      $ Tên đại lý��5�      #��[ 5�      $��1��6?   $��29.8,11,0,0q�6O   �� 5�   "   -   5        $��txt_cap��5�       $	��Top=�5�      $
��Left=�5�      $	��120��5�      $ Cấp đại lý��5�      #��[ 5�      $��1��6>   $��31.2,138,0,0q�6N   .��6d   5�   #   (	  "System.Windows.Controls.DatePicker	  5�   "   -   5        $��
dp_ngaylap��5�   %   $	��Top=�5�   !   $
��Left=�5�      $	��120��5�      $ Ngày lập��5�       ( $MaterialDesignFloatingHintDatePicker#��[ 5�      $��29.8,95,0,0q�6A   $��1��6V   	  5�   "   -	   5        $��dp_ngaysinh��5�   %   $	��Top=�5�   !   $
��Left=�5�      $	��120��5�      $ 
Ngày sinh��5�      #��[ 5�      $��29.8,52,0,0q�6A   $��1��6W   �� 5�   "   -
   5         ��Name$ cb_madinhmuc��5�   %    �� DisplayMemberPath$ CapDaiLy��5�   $   $	��Top=�5�   %   $
��Left=�5�   %   $	��128��5�   %   $ Mã định mức��5�   %    & "MaterialDesignFloatingHintComboBox#��[ 5�   %   $��	31,97,0,0q�6a   ��5�   %   ��  �� Path$ DINHMUCS� �� SelectedItem 5�   %   �� *	MaDinhMuc+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5�   a   5�      � 5�      $��1��6#   .+�5�   "   �� -   5        $��txt_noidung��5�   %   $	��Top=�5�      $	��200��5�   %   $ 
Nội dung��5�      #��[ 5�      $��313,184,48.6,0q�6>   5�      5�      5�      5�      5�      � 5�      $��2��6    5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $��
button_add��5�      $��0��5�      $��1��6-   ���#609194 # MaterialDesignRaisedLightButton#��[ 5�      $��40��5�      $	��100��5�      ��5�      �� *
AddCommand+.��5�      Thêm5�      �� 5�      -   5        $��button_update��5�      $��1��5�      $��1��6-   ���#609194#��[ 5�      $��40��5�      $	��100��5�      .��6   
Làm mới5�      �� 5�      -   5        $��button_delete��5�      $��2��5�      $��1��6-   ���#609194#��[ 5�      $��40��5�      $	��100��5�      .��6   Thoát5�      5�      5�      5     5     