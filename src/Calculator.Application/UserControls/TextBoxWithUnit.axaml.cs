using System.Net.Mime;
using Avalonia;
using Avalonia.Controls.Primitives;

namespace Calculator.Application.UserControls;

public class TextBoxWithUnit : TemplatedControl
{
    private static readonly StyledProperty<string> UnitProperty
        = AvaloniaProperty.Register<TextBoxWithUnit, string>(nameof(Unit));

    public string Unit
    {
        get => GetValue(UnitProperty);
        set => SetValue(UnitProperty, value);
    }
}