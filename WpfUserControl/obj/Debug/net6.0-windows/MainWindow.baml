   M S B A M L   `   `   `  ????I  EWpfUserControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfUserControlWpfUserControl  5   	   I)clr-namespace:WpfUserControl.UserControlsWpfUserControl.UserControls  5   	   E'clr-namespace:WpfUserControl.ViewModelsWpfUserControl.ViewModels  5   	       WpfUserControl.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfUserControl     5   	   8uc)clr-namespace:WpfUserControl.UserControls     5   	   6vm'clr-namespace:WpfUserControl.ViewModels     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors  5	   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? DataContext 5      .   (WpfUserControl.ViewModels.MainViewModels  5   
   6   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   6,   ?? 5      6   ?? 5      $	??100 ?6   6+   .+?5   
   ?? $??0??6   .+?5      ?? $??Click Me Again??6   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ Click??6-   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True??5   8      Command 5   8   ?? *ShowWelcomeDialogCommand+5       5!      5#      5$      ?? 5'   
   $??1??6   
???????$	??800??66   $	??600??6B   $
??Auto=?6O   $
??Auto=?6t   .??5(      (?  (? Stretch$ UniformToFill=?6   $??Center=?6.   $??Center=?6I   .??5)      ? .+?5*      ?? 
????  ?$??2q?60   6F   ?? 5+      $
??Fill=?6   ??6+   ?? *	ImagePath+ 5,        5-      $ 	MouseDown??65   . 5.   "     $
 True??5/   @    5.   @   ?? *MouseDownCommand+50   #   51        52      $ 	MouseMove??65   . 53   "     $
 True??54   @    53   @   ?? *MouseMoveCommand+55   #   56        57      $ 
MouseWheel??65   . 58   "     $
 True??59   @    58   @   ?? *MouseWheelCommand+5:   #   5;      5=      ?? 5>      .+?5?      ?? 
???  ??$??1??5D   $   	 ?? Left	 5?   $   ?? *	Start.X+

 ?? Top
 5@   $   ?? *	Start.Y+??5A   $   ?? *Width+??5B   $   ?? *Height+5E      5F      5G       ? LayoutTransform 5H      ?? 5I       ?? ScaleX 6%   ?? *	ZoomLevel+ ?? ScaleY 5J   %   ?? *	ZoomLevel+5L      5M      ? 5O   
   $	??200??6   $	??100??6   $??2??6(   .+?5P      ?? 
????  ?$??2q?6(   6>   ?? 5Q      $
??Fill=?6   ??6#   ?? *	ImagePath+ 5R        5S      $ 	MouseDown??6-   . 5T        $
 True??5U   8    5T   8   ?? *MouseDownCommand+5V      5W        5X      $ 	MouseMove??6-   . 5Y        $
 True??5Z   8    5Y   8   ?? *MouseMoveCommand+5[      5\      5_      ?? 5`      .+?5a      ?? 
???  ??$??1??5f      	 5a      ?? *	Start.X+
 5b      ?? *	Start.Y+??5c      ?? *Width+??5d      ?? *Height+5g      5h      5i      5k      5l      