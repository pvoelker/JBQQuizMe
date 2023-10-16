using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace JBQQuizMeApp;

/// <summary>
/// This is an alternate implementation to the standard MAUI button.
/// 
/// -There is a known issue on iOS/MacOS (Catalyst) with sizing of buttons in a CollectionView with the MeasureAllItems sizing strategy.
/// -There is a known issue on Windows where multi-line buttons just don't work. Issue: https://github.com/dotnet/maui/issues/9277
/// </summary>
public partial class BetterButton : ContentView
{
	public BetterButton()
	{
        BindingContext = this;
        
        InitializeComponent();
	}

    public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(BetterButton), "OpenSansRegular");
    public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(nameof(FontSize), typeof(double), typeof(BetterButton), 24.0);
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(BetterButton), String.Empty);
    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(BetterButton), Colors.Purple);
    public static new readonly BindableProperty BackgroundColorProperty = BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(BetterButton), Colors.Pink);
    public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(BetterButton), null);

    public event EventHandler Clicked;

    public string FontFamily
    {
        get => (string)GetValue(FontFamilyProperty);
        set => SetValue(FontFamilyProperty, value);
    }

    public double FontSize
    {
        get => (double)GetValue(FontSizeProperty);
        set => SetValue(FontSizeProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public new Color BackgroundColor
    {
        get => (Color)GetValue(BackgroundColorProperty);
        set => SetValue(BackgroundColorProperty, value);
    }

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    private ICommand ClickCommand
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (Clicked != null)
        {
            Clicked(this, EventArgs.Empty);
        }

        if (Command != null)
        {
            if (Command.CanExecute(this))
            {
                Command.Execute(null);
            }
        }
    }
}