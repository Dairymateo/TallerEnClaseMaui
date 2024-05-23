namespace TallerEnClase;

public partial class Flex : ContentPage
{
	public Flex()
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
    private void Button_Clicked_Absolute(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Absolute());

    }
}