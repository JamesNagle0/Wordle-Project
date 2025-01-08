namespace Wordle_Project;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
    }

    //Button to go back to game page
    private async void Back_to_Game_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(), true);
    }

    //Button to make everything dark
    private void Dark_Mode_Clicked(object sender, EventArgs e)
    {
        Settings_Page.Background = new SolidColorBrush(Colors.Black);
        Small.Background = new SolidColorBrush(Colors.Black);
        Medium.Background = new SolidColorBrush(Colors.Black);
        Large.Background = new SolidColorBrush(Colors.Black);
        Back_to_Game.Background = new SolidColorBrush(Colors.Black);
    }

    //Button to make everything light
    private void Light_Mode_Clicked(object sender, EventArgs e)
    {
        Settings_Page.Background = new SolidColorBrush(Colors.White);
        Small.Background = new SolidColorBrush(Colors.White);
        Medium.Background = new SolidColorBrush(Colors.White);
        Large.Background = new SolidColorBrush(Colors.White);
        Back_to_Game.Background = new SolidColorBrush(Colors.White);
    }
}