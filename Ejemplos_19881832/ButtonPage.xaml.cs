namespace Ejemplos_19881832;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)

    {

        (sender as Button).Text = "Presioname de nuevo";

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        
    }
}