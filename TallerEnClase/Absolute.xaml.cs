namespace TallerEnClase;

public partial class Absolute : ContentPage
{
	public Absolute()
	{
		InitializeComponent();
	}
    private void Button_Clicked_Stack(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stack());

    }

    private void Button_Clicked_Grid(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gird());

    }
    private void Button_Clicked_Flex(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flex());

    }
}