   M S B A M L   `   `   `  ����R  NAnalizadorPracticaCorta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:AnalizadorPracticaCortaAnalizadorPracticaCorta  5   	   (    "AnalizadorPracticaCorta.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:AnalizadorPracticaCorta     5   	     � Title$R  LAnalizador Lexico - Lenguajes formales y de programacion- 201931344 DavidLux��5   	   $	��424��6^   $	��784��6k   .��5	      � $��0,0,0,2q�6    � ColumnDefinitions 5
   
   �� 5      $
��571* �6   �� 5      $
��147* �6   ��5   
   �� 5       �� ImageSource$ 
Fondo4.jpg��6   .+�5   
   �� $��ingrese una oración
��6   $
��Left=�68   $��	38,60,0,0q�6S   $	��Top=�6f    J� RenderTransformOrigin$ -6.664,-2.505&�6~   $��36��6�   $��18(�6�   $	��205��6�   $
��Bold"�6�    � IsSharedSizeScope . ���	#FFECDFDF6�   �� 5   
   $��
Resultados��6   $
��Left=�6%   $��
381,62,0,0q�6@   $	��Top=�6T   $��18(�6l   $
��Bold"�6z   ���	#FFF7F1F16�   �� 5   
   -   5         ��Name$ 
txbOracion��5      $
��Left=�6&   $��97��6A   $��
38,109,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��303��6�   �� 5   
   -   5         ��Name$ Analizar��5      $��Analizar��6#   $
��Left=�66   $��
79,221,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $��Limpiar��5      $
��Left=�6#   $��190,221,0,0q�6>   $	��Top=�6S   $��75��6k   6v   �� 5   
   $��Analizador de Léxico��6   $
��Left=�6/   $��
282,19,0,0q�6J   $	��Top=�6^   $��16(�6v   $
��Bold"�6�   ���	#FFFDF8F86�   �� 5   
   -   5         ��Name$ lVresultados��5      $
��Left=�6)   $	��234��6D   $��381,109,0,0q�6Q   $	��Top=�6f   $	��328��6~   $��2��6�   	 �� View	 5      �� 5      .P�5      �� 5      5      �� 5   
   -   5        $ lbInfo��5      $��Información��6!   $
��Left=�67   $��	27,10,0,0q�6R   $	��Top=�6e   $��87��6}   $��1��6�   $��52��6�   $
��Bold"�6�   $��14(�6�   ��5      �� 5       $ loupe_78956.png��6   5"      5$      5%      