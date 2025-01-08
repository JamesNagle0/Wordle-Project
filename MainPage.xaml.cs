using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace Wordle_Project
{
    public partial class MainPage : ContentPage
    {
        Random Random_Num = new Random();
        int Word_Gen;
        String Generated_Word = "";

        public MainPage()
        {
            InitializeComponent();
        }

        String[,] Possible_Words =
        {
            {"C", "L", "O", "S", "E"},
            {"C", "O", "B", "R", "A"},
            {"P", "I", "Z", "Z", "A"},
            {"R", "O", "C", "K", "S"},
            {"F", "I", "E", "L", "D"},
            {"A", "P", "P", "L", "E"},
            {"D", "R", "I", "N", "K"},
            {"P", "E", "A", "C", "H"},
            {"C", "R", "A", "Z", "Y"},
            {"C", "H", "A", "W", "K"},
            {"B", "O", "O", "T", "S"},
            {"W", "H", "A", "C", "K"},
            {"D", "I", "Z", "Z", "Y"},
            {"F", "I", "Z", "Z", "Y"},
            {"J", "U", "N", "K", "Y"},
            {"Z", "I", "P", "P", "Y"},
            {"J", "U", "M", "P", "Y"},
            {"C", "R", "O", "A", "K"},
            {"C", "R", "A", "Z", "Y"},
            {"J", "U", "I", "C", "Y"}
        };

        String[,] Input_Words =
        {
            {"", "", "", "", ""},
            {"", "", "", "", ""},
            {"", "", "", "", ""},
            {"", "", "", "", ""},
            {"", "", "", "", ""},
            {"", "", "", "", ""}
        };

        String[,] Word =
        {
            {"", "", "", "", ""}
        };

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Settings(), true);
        }

        private void Word_Generator_Clicked(object sender, EventArgs e)
        {
            if (Word_Generator.Text.Contains("Start Game"))
            {
                Word_Generator.Text = "Restart";

                Confirm.Text = "Confirm 1st Attempt";

                Word_Gen = Random_Num.Next(1, 21);

                switch (Word_Gen)
                {
                    case 1:
                        Word[0, 0] = Possible_Words[0, 0];
                        Word[0, 1] = Possible_Words[0, 1];
                        Word[0, 2] = Possible_Words[0, 2];
                        Word[0, 3] = Possible_Words[0, 3];
                        Word[0, 4] = Possible_Words[0, 4];
                        break;
                    case 2:
                        Word[0, 0] = Possible_Words[1, 0];
                        Word[0, 1] = Possible_Words[1, 1];
                        Word[0, 2] = Possible_Words[1, 2];
                        Word[0, 3] = Possible_Words[1, 3];
                        Word[0, 4] = Possible_Words[1, 4];
                        break;
                    case 3:
                        Word[0, 0] = Possible_Words[2, 0];
                        Word[0, 1] = Possible_Words[2, 1];
                        Word[0, 2] = Possible_Words[2, 2];
                        Word[0, 3] = Possible_Words[2, 3];
                        Word[0, 4] = Possible_Words[2, 4];
                        break;
                    case 4:
                        Word[0, 0] = Possible_Words[3, 0];
                        Word[0, 1] = Possible_Words[3, 1];
                        Word[0, 2] = Possible_Words[3, 2];
                        Word[0, 3] = Possible_Words[3, 3];
                        Word[0, 4] = Possible_Words[3, 4];
                        break;
                    case 5:
                        Word[0, 0] = Possible_Words[4, 0];
                        Word[0, 1] = Possible_Words[4, 1];
                        Word[0, 2] = Possible_Words[4, 2];
                        Word[0, 3] = Possible_Words[4, 3];
                        Word[0, 4] = Possible_Words[4, 4];
                        break;
                    case 6:
                        Word[0, 0] = Possible_Words[5, 0];
                        Word[0, 1] = Possible_Words[5, 1];
                        Word[0, 2] = Possible_Words[5, 2];
                        Word[0, 3] = Possible_Words[5, 3];
                        Word[0, 4] = Possible_Words[5, 4];
                        break;
                    case 7:
                        Word[0, 0] = Possible_Words[6, 0];
                        Word[0, 1] = Possible_Words[6, 1];
                        Word[0, 2] = Possible_Words[6, 2];
                        Word[0, 3] = Possible_Words[6, 3];
                        Word[0, 4] = Possible_Words[6, 4];
                        break;
                    case 8:
                        Word[0, 0] = Possible_Words[7, 0];
                        Word[0, 1] = Possible_Words[7, 1];
                        Word[0, 2] = Possible_Words[7, 2];
                        Word[0, 3] = Possible_Words[7, 3];
                        Word[0, 4] = Possible_Words[7, 4];
                        break;
                    case 9:
                        Word[0, 0] = Possible_Words[8, 0];
                        Word[0, 1] = Possible_Words[8, 1];
                        Word[0, 2] = Possible_Words[8, 2];
                        Word[0, 3] = Possible_Words[8, 3];
                        Word[0, 4] = Possible_Words[8, 4];
                        break;
                    case 10:
                        Word[0, 0] = Possible_Words[9, 0];
                        Word[0, 1] = Possible_Words[9, 1];
                        Word[0, 2] = Possible_Words[9, 2];
                        Word[0, 3] = Possible_Words[9, 3];
                        Word[0, 4] = Possible_Words[9, 4];
                        break;
                    case 11:
                        Word[0, 0] = Possible_Words[10, 0];
                        Word[0, 1] = Possible_Words[10, 1];
                        Word[0, 2] = Possible_Words[10, 2];
                        Word[0, 3] = Possible_Words[10, 3];
                        Word[0, 4] = Possible_Words[10, 4];
                        break;
                    case 12:
                        Word[0, 0] = Possible_Words[11, 0];
                        Word[0, 1] = Possible_Words[11, 1];
                        Word[0, 2] = Possible_Words[11, 2];
                        Word[0, 3] = Possible_Words[11, 3];
                        Word[0, 4] = Possible_Words[11, 4];
                        break;
                    case 13:
                        Word[0, 0] = Possible_Words[12, 0];
                        Word[0, 1] = Possible_Words[12, 1];
                        Word[0, 2] = Possible_Words[12, 2];
                        Word[0, 3] = Possible_Words[12, 3];
                        Word[0, 4] = Possible_Words[12, 4];
                        break;
                    case 14:
                        Word[0, 0] = Possible_Words[13, 0];
                        Word[0, 1] = Possible_Words[13, 1];
                        Word[0, 2] = Possible_Words[13, 2];
                        Word[0, 3] = Possible_Words[13, 3];
                        Word[0, 4] = Possible_Words[13, 4];
                        break;
                    case 15:
                        Word[0, 0] = Possible_Words[14, 0];
                        Word[0, 1] = Possible_Words[14, 1];
                        Word[0, 2] = Possible_Words[14, 2];
                        Word[0, 3] = Possible_Words[14, 3];
                        Word[0, 4] = Possible_Words[14, 4];
                        break;
                    case 16:
                        Word[0, 0] = Possible_Words[15, 0];
                        Word[0, 1] = Possible_Words[15, 1];
                        Word[0, 2] = Possible_Words[15, 2];
                        Word[0, 3] = Possible_Words[15, 3];
                        Word[0, 4] = Possible_Words[15, 4];
                        break;
                    case 17:
                        Word[0, 0] = Possible_Words[16, 0];
                        Word[0, 1] = Possible_Words[16, 1];
                        Word[0, 2] = Possible_Words[16, 2];
                        Word[0, 3] = Possible_Words[16, 3];
                        Word[0, 4] = Possible_Words[16, 4];
                        break;
                    case 18:
                        Word[0, 0] = Possible_Words[17, 0];
                        Word[0, 1] = Possible_Words[17, 1];
                        Word[0, 2] = Possible_Words[17, 2];
                        Word[0, 3] = Possible_Words[17, 3];
                        Word[0, 4] = Possible_Words[17, 4];
                        break;
                    case 19:
                        Word[0, 0] = Possible_Words[18, 0];
                        Word[0, 1] = Possible_Words[18, 1];
                        Word[0, 2] = Possible_Words[18, 2];
                        Word[0, 3] = Possible_Words[18, 3];
                        Word[0, 4] = Possible_Words[18, 4];
                        break;
                    case 20:
                        Word[0, 0] = Possible_Words[19, 0];
                        Word[0, 1] = Possible_Words[19, 1];
                        Word[0, 2] = Possible_Words[19, 2];
                        Word[0, 3] = Possible_Words[19, 3];
                        Word[0, 4] = Possible_Words[19, 4];
                        break;
                }

                for (int i = 0; i < Word.GetLength(0); i++)
                {
                    for (int j = 0; j < Word.GetLength(1); j++)
                    {
                        Generated_Word = Generated_Word + Word[i, j];
                    }
                }

                //Debug1.Text = $"{Generated_Word}";
            }
            else if (Word_Generator.Text.Contains("Restart"))
            {
                Restart(sender, e);
            }

        }

        private void Confirm_Clicked(object sender, EventArgs e)
        {
            if (Confirm.Text.Contains("Confirm 1st Attempt"))
            {
                Confirm.Text = "Confirm 2nd Attempt";

                for (int i = 1; i <= 5; i++)
                {
                    var inputcontrol = (Entry)this.FindByName($"Input_1_{i}");
                    var outputcontrol = (Label)this.FindByName($"Output_1_{i}");

                    Input_Words[0, i - 1] = inputcontrol.Text;
                    outputcontrol.Text = Input_Words[0, i - 1];
                    inputcontrol.IsVisible = false;
                    outputcontrol.IsVisible = true;
                }

                for (int i = 0; i <= 4; i++)
                {
                    if (Input_Words[0, i] == Word[0, i])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 1}");

                        frame.Background = new SolidColorBrush(Colors.Green);
                    }
                    else if (Input_Words[0, i] == Word[0, 0] || Input_Words[0, i] == Word[0, 1] || Input_Words[0, i] == Word[0, 2] || Input_Words[0, i] == Word[0, 3] || Input_Words[0, i] == Word[0, 4])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 1}");

                        frame.Background = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 1}");

                        frame.Background = new SolidColorBrush(Colors.Red);
                    }
                }

                if (Input_Words[0, 0] == Word[0, 0] && Input_Words[0, 1] == Word[0, 1] && Input_Words[0, 2] == Word[0, 2] && Input_Words[0, 3] == Word[0, 3] && Input_Words[0, 4] == Word[0, 4])
                {
                    Win(sender, e);
                }
            }
            else if (Confirm.Text.Contains("Confirm 2nd Attempt"))
            {
                Confirm.Text = "Confirm 3rd Attempt";

                for (int i = 1; i <= 5; i++)
                {
                    var inputcontrol = (Entry)this.FindByName($"Input_2_{i}");
                    var outputcontrol = (Label)this.FindByName($"Output_2_{i}");

                    Input_Words[1, i - 1] = inputcontrol.Text;
                    outputcontrol.Text = Input_Words[1, i - 1];
                    inputcontrol.IsVisible = false;
                    outputcontrol.IsVisible = true;
                }

                for (int i = 0; i <= 4; i++)
                {
                    if (Input_Words[1, i] == Word[0, i])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 6}");

                        frame.Background = new SolidColorBrush(Colors.Green);
                    }
                    else if (Input_Words[1, i] == Word[0, 0] || Input_Words[1, i] == Word[0, 1] || Input_Words[1, i] == Word[0, 2] || Input_Words[1, i] == Word[0, 3] || Input_Words[1, i] == Word[0, 4])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 6}");

                        frame.Background = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 6}");

                        frame.Background = new SolidColorBrush(Colors.Red);
                    }
                }

                if (Input_Words[1, 0] == Word[0, 0] && Input_Words[1, 1] == Word[0, 1] && Input_Words[1, 2] == Word[0, 2] && Input_Words[1, 3] == Word[0, 3] && Input_Words[1, 4] == Word[0, 4])
                {
                    Win(sender, e);
                }
            }
            else if (Confirm.Text.Contains("Confirm 3rd Attempt"))
            {
                Confirm.Text = "Confirm 4th Attempt";

                for (int i = 1; i <= 5; i++)
                {
                    var inputcontrol = (Entry)this.FindByName($"Input_3_{i}");
                    var outputcontrol = (Label)this.FindByName($"Output_3_{i}");

                    Input_Words[2, i - 1] = inputcontrol.Text;
                    outputcontrol.Text = Input_Words[2, i - 1];
                    inputcontrol.IsVisible = false;
                    outputcontrol.IsVisible = true;
                }

                for (int i = 0; i <= 4; i++)
                {
                    if (Input_Words[2, i] == Word[0, i])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 11}");

                        frame.Background = new SolidColorBrush(Colors.Green);
                    }
                    else if (Input_Words[2, i] == Word[0, 0] || Input_Words[2, i] == Word[0, 1] || Input_Words[2, i] == Word[0, 2] || Input_Words[2, i] == Word[0, 3] || Input_Words[2, i] == Word[0, 4])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 11}");

                        frame.Background = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 11}");

                        frame.Background = new SolidColorBrush(Colors.Red);
                    }
                }

                if (Input_Words[2, 0] == Word[0, 0] && Input_Words[2, 1] == Word[0, 1] && Input_Words[2, 2] == Word[0, 2] && Input_Words[2, 3] == Word[0, 3] && Input_Words[2, 4] == Word[0, 4])
                {
                    Win(sender, e);
                }
            }
            else if (Confirm.Text.Contains("Confirm 4th Attempt"))
            {
                Confirm.Text = "Confirm 5th Attempt";

                for (int i = 1; i <= 5; i++)
                {
                    var inputcontrol = (Entry)this.FindByName($"Input_4_{i}");
                    var outputcontrol = (Label)this.FindByName($"Output_4_{i}");

                    Input_Words[3, i - 1] = inputcontrol.Text;
                    outputcontrol.Text = Input_Words[3, i - 1];
                    inputcontrol.IsVisible = false;
                    outputcontrol.IsVisible = true;
                }

                for (int i = 0; i <= 4; i++)
                {
                    if (Input_Words[3, i] == Word[0, i])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 16}");

                        frame.Background = new SolidColorBrush(Colors.Green);
                    }
                    else if (Input_Words[3, i] == Word[0, 0] || Input_Words[3, i] == Word[0, 1] || Input_Words[3, i] == Word[0, 2] || Input_Words[3, i] == Word[0, 3] || Input_Words[3, i] == Word[0, 4])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 16}");

                        frame.Background = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 16}");

                        frame.Background = new SolidColorBrush(Colors.Red);
                    }
                }

                if (Input_Words[3, 0] == Word[0, 0] && Input_Words[3, 1] == Word[0, 1] && Input_Words[3, 2] == Word[0, 2] && Input_Words[3, 3] == Word[0, 3] && Input_Words[3, 4] == Word[0, 4])
                {
                    Win(sender, e);
                }
            }
            else if (Confirm.Text.Contains("Confirm 5th Attempt"))
            {
                Confirm.Text = "Confirm 6th Attempt";

                for (int i = 1; i <= 5; i++)
                {
                    var inputcontrol = (Entry)this.FindByName($"Input_5_{i}");
                    var outputcontrol = (Label)this.FindByName($"Output_5_{i}");

                    Input_Words[4, i - 1] = inputcontrol.Text;
                    outputcontrol.Text = Input_Words[4, i - 1];
                    inputcontrol.IsVisible = false;
                    outputcontrol.IsVisible = true;
                }

                for (int i = 0; i <= 4; i++)
                {
                    if (Input_Words[4, i] == Word[0, i])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 21}");

                        frame.Background = new SolidColorBrush(Colors.Green);
                    }
                    else if (Input_Words[4, i] == Word[0, 0] || Input_Words[4, i] == Word[0, 1] || Input_Words[4, i] == Word[0, 2] || Input_Words[4, i] == Word[0, 3] || Input_Words[4, i] == Word[0, 4])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 21}");

                        frame.Background = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 21}");

                        frame.Background = new SolidColorBrush(Colors.Red);
                    }
                }

                if (Input_Words[4, 0] == Word[0, 0] && Input_Words[4, 1] == Word[0, 1] && Input_Words[4, 2] == Word[0, 2] && Input_Words[4, 3] == Word[0, 3] && Input_Words[4, 4] == Word[0, 4])
                {
                    Win(sender, e);
                }
            }
            else if (Confirm.Text.Contains("Confirm 6th Attempt"))
            {
                Confirm.Text = "Restart";

                for (int i = 1; i <= 5; i++)
                {
                    var inputcontrol = (Entry)this.FindByName($"Input_6_{i}");
                    var outputcontrol = (Label)this.FindByName($"Output_6_{i}");

                    Input_Words[5, i - 1] = inputcontrol.Text;
                    outputcontrol.Text = Input_Words[5, i - 1];
                    inputcontrol.IsVisible = false;
                    outputcontrol.IsVisible = true;
                }

                for (int i = 0; i <= 4; i++)
                {
                    if (Input_Words[5, i] == Word[0, i])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 26}");

                        frame.Background = new SolidColorBrush(Colors.Green);
                    }
                    else if (Input_Words[5, i] == Word[0, 0] || Input_Words[5, i] == Word[0, 1] || Input_Words[5, i] == Word[0, 2] || Input_Words[5, i] == Word[0, 3] || Input_Words[5, i] == Word[0, 4])
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 26}");

                        frame.Background = new SolidColorBrush(Colors.Yellow);
                    }
                    else
                    {
                        var frame = (Frame)this.FindByName($"Frame{i + 26}");

                        frame.Background = new SolidColorBrush(Colors.Red);
                    }
                }

                if (Input_Words[5, 0] == Word[0, 0] && Input_Words[5, 1] == Word[0, 1] && Input_Words[5, 2] == Word[0, 2] && Input_Words[5, 3] == Word[0, 3] && Input_Words[5, 4] == Word[0, 4])
                {
                    Win(sender, e);
                }
            }
            else if (Confirm.Text.Contains("Restart") || Confirm.Text.Contains("You've Won! You Guessed the Word! (Press to Restart)"))
            {
                Restart(sender, e);
            }
        }

        private void Restart(object sender, EventArgs e)
        {
            Word_Generator.Text = "Start Game";

            Word[0, 0] = " ";
            Word[0, 1] = " ";
            Word[0, 2] = " ";
            Word[0, 3] = " ";
            Word[0, 4] = " ";

            Generated_Word = "";

            Confirm.Text = "Press 'Start Game' to Begin!";

            //Debug1.Text = "";

            for (int j = 1; j <= 6; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    var inputcontrol = (Entry)this.FindByName($"Input_{j}_{i}");
                    var outputcontrol = (Label)this.FindByName($"Output_{j}_{i}");

                    inputcontrol.Text = string.Empty;
                    inputcontrol.IsVisible = true;
                    outputcontrol.IsVisible = false;
                }
            }

            for (int i = 1; i <= 30; i++)
            {
                var frame = (Frame)this.FindByName($"Frame{i}");

                frame.Background = new SolidColorBrush(Colors.Black);
            }
        }

        private void Win(object sender, EventArgs e)
        {
            Confirm.Text = "You've Won! You Guessed the Word! (Press to Restart)";
        }
    }
}
