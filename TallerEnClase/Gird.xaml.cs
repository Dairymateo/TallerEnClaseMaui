namespace TallerEnClase;

public partial class Gird : ContentPage
{
	public Gird()
	{
		InitializeComponent();
	}

    private void Button_Clicked_Stack(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Stack());

    }

    private void Button_Clicked_Flex(object sender, EventArgs e) 
    {
        Navigation.PushAsync(new Flex());
    
    }
    private void Button_Clicked_Absolute(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Absolute());

    }
}