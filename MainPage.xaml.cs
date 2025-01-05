namespace Wordle_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }

        private void Word_Generator_Clicked(object sender, EventArgs e)
        {

        }
    }
}
