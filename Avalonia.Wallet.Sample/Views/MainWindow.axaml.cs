using Avalonia.Controls;
using Avalonia.Input;

namespace Avalonia.Wallet.Sample.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    
    private void MoveWindow_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        BeginMoveDrag(e);
    }
}