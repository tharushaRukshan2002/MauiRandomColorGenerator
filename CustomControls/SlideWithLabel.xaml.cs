using System.ComponentModel;

namespace MauiApp01.CustomControls;

public partial class SlideWithLabel : ContentView
{
    public static readonly BindableProperty LabelTextProperty =
            BindableProperty.Create(nameof(LabelText), typeof(string), typeof(SlideWithLabel), default(string));
 
    public string LabelText
    {
        get { return (string)GetValue(LabelTextProperty); }
        set { SetValue(LabelTextProperty, value); }
    }

    public static readonly BindableProperty ValueOfTheSliderProperty =
            BindableProperty.Create(nameof(ValueOfTheSlider), typeof(int), typeof(SlideWithLabel), default(int));


    public int ValueOfTheSlider
    {
        get { return (int)GetValue(ValueOfTheSliderProperty); }
        set 
        { 
            SetValue(ValueOfTheSliderProperty, value);
        }
    }

    public SlideWithLabel() 
    { 
		InitializeComponent();
	}
}