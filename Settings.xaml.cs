namespace Wordle_Project;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
    }

    private async void Back_to_Game_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(), true);
    }

    private void Dark_Mode_Clicked(object sender, EventArgs e)
    {

    }

    private void Light_Mode_Clicked(object sender, EventArgs e)
    {

    }

    private void Small_Clicked(object sender, EventArgs e)
    {

    }

    private void Medium_Clicked(object sender, EventArgs e)
    {

    }

    private void Large_Clicked(object sender, EventArgs e)
    {

    }

    private void Timer_On_Clicked(object sender, EventArgs e)
    {

    }

    private void Timer_Off_Clicked(object sender, EventArgs e)
    {

    }

    private void Hints_On_Clicked(object sender, EventArgs e)
    {

    }

    private void Hints_Off_Clicked(object sender, EventArgs e)
    {

    }
}