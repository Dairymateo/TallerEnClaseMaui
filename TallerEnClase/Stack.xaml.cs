namespace TallerEnClase;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}
    private void Button_Clicked_Flex(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Flex());

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