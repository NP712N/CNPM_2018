   M S B A M L   `   `   `  ����F  BCNPMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CNPMProjectCNPMProject  5   	   =#clr-namespace:CNPMProject.ViewModelCNPMProject.ViewModel  5   	       CNPMProject.Daily   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CNPMProject     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      3	viewModel#clr-namespace:CNPMProject.ViewModel  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
      $��18(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � Title$ Quản lý đại lý��5   	   $	��600��6    $	��800��6-   ���#AFBFAE.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6'   ���#EB6D4A.��5      ]� .+�5      �� $��Right=�6!   
������  �� Orientation$ 
Horizontal=�6R    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%�   '��       �� 5      "	 ��6$   .�5   "   �� 
 � ��$ 2 4 2 4q�6;   6M   �� 5    "   
 � ��$ 40��6:   6G   5!      5"      .+�5#      �� -   5        $��button_closewindow��5#   !    c� OverflowMode$ AsNeeded=�5$      
��� E����5#   ;   �� *CloseWindowCommand+.��5%      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�66   5&      5'      �� 5)      $
��Left=�6!   $ 
Horizontal=�67   .+�5*      �� $��Center=�6$   $��16 0 0 0q�6?   ��6Q   �� *Tag+ �� ElementName$ ucControlBar��6�   5+      d� 5,       ' #MaterialDesignHamburgerToggleButton#���  5-      �� 5.      $��Center=�5/      $��16 0 0 0q�50      $
��Bold"�6   Quản lý đại lý52      53      54      55      � 56   
   $��1��6   .+�5�      �  5�      �� 5�      �� 5�      $
��auto �6$   �� 5�      $	��250 �6$   .+�5�      � $��0��6   .+�5�      �� $��
Đại lý��5�        MaterialDesignGroupBox#���  5�      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$
 Dark=�5�      $	��230��5�      $	��780��6"   $��Center=�5�       � UseLayoutRounding .  J� SnapsToDevicePixels . .��5�      #  MaterialDesignThemes.Wpf.Card  $	��180��6.   .��5�      � .+�5�   "   � $��0��6'    � ColumnDefinitions 5�   &   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   .+�5�   &   � $��0��6+    5�   *   �� 5�   .   $��20 �6?   �� 5�   .    5�   *   �� 5�   .   �� 5�   .   �� 5�   .   .+�5�   *   �� -   5        $��txt_madaily��5�   !   $	��Top=�5�      $
��Left=�5�      $	��100��5�      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã đại lý��5�       % !MaterialDesignFloatingHintTextBox#��[ 5�      $��1��6>   �� 5�   *   -   5        $��txt_mahopdong��5�   !   $	��Top=�5�      $
��Left=�5�      $	��127��5�      $ Mã hợp đồng��5�      #��[ 5�      $��1��6>   $��1��6K   �� 5�   *   -   5         ��Name$ cb_madinhmuc��5�   %    �� DisplayMemberPath$ CapDaiLy��5�   $   $	��Top=�5�   %   $
��left=�5�   %   $	��128��5�   %   $ Mã định mức��5�   %    & "MaterialDesignFloatingHintComboBox#��[ 5�   %   $��2��6a   $��1��6n   5�   '   � 5�   &   $��1��6+    5�   *   �� 5�   .   �� 5�   .   �� 5�   .   .+�5�   *   �� -   5        $��txt_hotenchudaily��5�   %   $	��Top=�5�      $
��Left=�5�      $	��170��5�      $  Họ tên chủ đại lý��5�      #��[ 5�      $��0��6>   �� 5�   *   -   5        $��txt_tendaily��5�   %   $	��Top=�5�      $
��Left=�5�      $	��150��5�      $ Tên đại lý��5�      #��[ 5�      $��1��6>   �� 5�   *   -   5        $��txt_cap��5�       $	��Top=�5�      $
��Left=�5�      $	��120��5�      $ Cấp đại lý��5�      #��[ 5�      $��2��6>   .��6K   5�   +   5�   '   � 5�   &   $��2��6+    5�   *   �� 5�   .   �� 5�   .   �� 5�   .   .+�5�   *   (  "System.Windows.Controls.DatePicker  -   5        $��
dp_ngaylap��5�   -   $	��Top=�5�   -   {�.  $
��Left=�5�   -   $	��120��5�   -   $ Ngày lập��5�   -    ( $MaterialDesignFloatingHintDatePicker#��[ 5�   -   $��0��6k     5�   *   -	   5        $��dp_ngaysinh��5�   %   $	��Top=�5�   !   $
��Left=�5�      $	��120��5�      $ 
Ngày sinh��5�      #��[ 5�      $��1��6A   �� 5�   *   -
   5        $��txt_cmnd��5�   !   $	��Top=�5�      $
��Left=�5�      $	��120��5�      $
 CMND��5�      #��[ 5      $��2��6>   5  '   � 5  &   $��3��6+    5  *   �� 5  .   �� 5  .   �� 5  .   .+�5	  *   �� -   5        $��txt_noidung��5  %   $	��Top=�5	  2   $
��Left=�5
     $	��150��5  %   $ 
Nội dung��5     #��[ 5     $��1��6>   5  '   5  #   5     5!     5$     5&     � 5'     $��1��6    5(     �� 5)     $	��400 �6+   �� 5*     .+�5.       $��0��6/   $��Bottom=�5/  /   $��70��50  /   ���#AFBFAE.��52     ]� .+�54     �� $ 
Horizontal=�55  !   +	  %MaterialDesignThemes.Wpf.RippleAssist 	  
IsCentered . .+�58  "     $��Center=�59  %   $��8 4 8 4q�5:  %      CornerRadius$ 2��5;  %    K� ZIndex$ 1��5<  %   $��16 0 0 0q�5=  %   +
  %MaterialDesignThemes.Wpf.ShadowAssist 
  ShadowDepth$ Depth1=�5>  %   $��1��5?  %   .��5A  &   �  5B  *   �� 5C  .   $
��Auto �5D  1   �� 5E  .   $��* �5F  1   �� 5G  .   $
��Auto �5H  1   .+�5J  *   �� -   5        $��button_search��5K  -     MaterialDesignToolButton#���  5L  -   $
��Auto��6`   .��5M  .     $ Magnify=�5O  1   5Q  +   �� 5S  *   -   5        $��txtsearchDaiLy��5U  -   $��1��5T  -   $��8 0 0 0q�5V  -   $��16(�5W  -   $ Search��5X  -   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5Y  -   $��0q�5Z  -   $	��200��5[  -   $��Center=�5\  -   �� 5]  *   -   5        $��button_refresh��5^  -   #���  5_  -   $
��Auto��6`   $��Right=�6n   $��Center=�6�   $��1��6�   .��5`  .     $ Reload=�5b  1   5d  +   5e  '   5f  #   5g     5h     5i     � 5�     $��1��6    5�     �� 5�     �� 5�     �� 5�     .+�5�     �� -   5        $��
button_add��5�     $��0��5�     $��1��6-   ���#609194 # MaterialDesignRaisedLightButton#��[ 5�     $��40��5�     $	��100��5�     
�������$��18(�5�     
�������$��Center=�5�     .��6Q   Thêm5�     �� 5�     -   5        $��button_update��5�     $��1��5�     $��1��6-   ���#609194#��[ 5�     $��40��5�     $	��100��5�     
�������$��18(�5�     
�������$��Center=�5�     .��6T   Sửa5�     �� 5�     -   5        $��
btn_delete��5�     $��2��5�     $��1��6-   ���#609194#��[ 5�     $��40��5�     $	��100��6)   
�������$��18(�5�     
�������$��Center=�5�     .��6Q   Xóa5�     5�     5�       5�     $��2��6&   $	��240��63   $	��770��6@   .��5�     &   System.Windows.Controls.DataGrid  -   5        $��ds_daily��5�        CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  $
��auto��5�        Columns 5�     0  *System.Windows.Controls.DataGridTextColumn  5�     ,  &System.Windows.Controls.DataGridColumn   Header$ Mã đại lý��5�  !    0	 ,MaterialDesignDataGridTextColumnEditingStyle1  +System.Windows.Controls.DataGridBoundColumn    EditingElementStyle#  [	 5�  !   !   Binding! 5�  !   �� *	MaDaiLy+5�  !   9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5�     $ Mã hợp đồng��5�  !    5
 1MaterialDesignDataGridTextColumnPopupEditingStyle#  [
 5�  !   ! 5�  !   �� *	MaHopDong+5�  !     5�     $ Ngày lập��5�     #  [
 5�     ! 5�     �� *	NgayLap+5�       5�     $
 CMND��5�     #  [
 5�     ! 5�     �� *CMND+5�       5�     $  Họ tên chủ đại lý��5�     #  [
 5�     ! 5�     �� *HoTenChuDaiLy+5�       5�     $ 
Ngày sinh��5�     #  [
 5�     ! 5�     �� *
NgaySinh+5�       5�     $ Cấp đại lý��5�     #  [
 5�     ! 5�     �� *
CapDaiLy+5�       5�     $ Tên đại lý��5�     #  [
 5�     ! 5�     �� *
TenDaiLy+5�       5�     $  Họ tên chủ đại lý��5�     #  [
 5�     ! 5�     �� *HoTenChuDaiLy+5�       5�     $ 
Nội dung��5�     #  [
 5�     ! 5�     �� *	NoiDung+5�     5�     5�     5�     5�     5	     5
     