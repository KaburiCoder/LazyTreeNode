   M S B A M L   `   `   `  ����J  FWpfLazyTreeNode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfLazyTreeNode.ViewsWpfLazyTreeNode.Views  5   	   ?$clr-namespace:WpfLazyTreeNode.ModelsWpfLazyTreeNode.Models  5   	   $    WpfLazyTreeNode.Views.MainView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfLazyTreeNode.Views     5   	   7models$clr-namespace:WpfLazyTreeNode.Models     5   	     � Title$  MainView��5	   	   $	��450��6   $	��800��6'   .��5
      � .+�5      R� $��20(�61   ��6   �� *	PathNodes+ � 	Resources 5       �� 
TargetType �� Property �� Value �� Mode��%y   'Q�       �� 5   
   " Q�6   .�5      ��  �@Q�
IsExpanded 6)   �� *
IsExpanded+$ TwoWay=�5      5   	   ��5      �� 5   
    �� DataType)   #WpfLazyTreeNode.Models.LazyTreeNode"  6#    �� ItemsSource 6K   �� *
Children+.R�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� 	 ��Name$	 	treeImage��6   $��24��6'   $��24��62   ��6>   �� *ClosedImage+�� 5      ��6   �� *Text+5      
 �� Triggers
 5      �� 5       �� Value$
 True��69    �� Binding 6   �� *
IsExpanded+.a�5      ��  �� 
TargetName$ 	treeImage��6    5      �� *OpenedImage+ � ��5      5       5"      5#      5$      