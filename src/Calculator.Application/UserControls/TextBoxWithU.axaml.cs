using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Calculator.Application.UserControls;

public partial class TextBoxWithU : TextBox
{
    
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}