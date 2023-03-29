namespace MorpionAndApi;

public partial class MainPage : ContentPage
{
    int ligne1 = 0;
    int ligne2 = 0;
    int ligne3 = 0;

    int colonne1 = 0;
    int colonne2 = 0;
    int colonne3 = 0;

    int diagonale1 = 0;
    int diagonale2 = 0;

    int joueur = 0;

    int scoreJoueur1 = 0;
    int scoreJoueur2 = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnClickButton1_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button1.Text = "X";
            ligne1 = ligne1 + 3;
            colonne1 = colonne1 + 3;
            diagonale1 = diagonale1 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button1.Text = "O";
            ligne1 = ligne1 + 5;
            colonne1 = colonne1 + 5;
            diagonale1 = diagonale1 + 5;

            joueur = 0;
        }
        Button1.IsEnabled = false;
        CalculScore();
    }

    private void OnClickButton2_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button2.Text = "X";
            ligne1 = ligne1 + 3;
            colonne2 = colonne2 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button2.Text = "O";
            ligne1 = ligne1 + 5;
            colonne2 = colonne2 + 5;

            joueur = 0;
        }
        Button2.IsEnabled = false;
        CalculScore();
    }

    private void OnClickButton3_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button3.Text = "X";
            ligne1 = ligne1 + 3;
            colonne3 = colonne3 + 3;
            diagonale2 = diagonale2 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button3.Text = "O";
            ligne1 = ligne1 + 5;
            colonne3 = colonne3 + 5;
            diagonale2 = diagonale2 + 5;

            joueur = 0;
        }
        Button3.IsEnabled = false;
        CalculScore();

    }

    private void OnClickButton4_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button4.Text = "X";
            ligne2 = ligne2 + 3;
            colonne1 = colonne1 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button4.Text = "O";
            ligne2 = ligne2 + 5;
            colonne1 = colonne1 + 5;

            joueur = 0;
        }
        Button4.IsEnabled = false;
        CalculScore();
    }

    private void OnClickButton5_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button5.Text = "X";
            ligne2 = ligne2 + 3;
            colonne2 = colonne2 + 3;
            diagonale1 = diagonale1 + 3;
            diagonale2 = diagonale2 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button5.Text = "O";
            ligne2 = ligne2 + 5;
            colonne2 = colonne2 + 5;
            diagonale1 = diagonale1 + 5;
            diagonale2 = diagonale2 + 5;

            joueur = 0;
        }
        Button5.IsEnabled = false;
        CalculScore();
    }

    private void OnClickButton6_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button6.Text = "X";
            ligne2 = ligne2 + 3;
            colonne3 = colonne3 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button6.Text = "O";
            ligne2 = ligne2 + 5;
            colonne3 = colonne3 + 5;

            joueur = 0;
        }
        Button6.IsEnabled = false;
        CalculScore();
    }

    private void OnClickButton7_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button7.Text = "X";
            ligne3 = ligne3 + 3;
            colonne1 = colonne1 + 3;
            diagonale2 = diagonale2 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button7.Text = "O";
            ligne3 = ligne3 + 5;
            colonne1 = colonne1 + 5;
            diagonale2 = diagonale2 + 5;

            joueur = 0;
        }
        Button7.IsEnabled = false;
        CalculScore();
    }

    private void OnClickButton8_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button8.Text = "X";
            ligne3 = ligne3 + 3;
            colonne2 = colonne2 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button8.Text = "O";
            ligne3 = ligne3 + 5;
            colonne2 = colonne2 + 5;

            joueur = 0;
        }
        Button8.IsEnabled = false;
        CalculScore();
    }

    private void OnClickButton9_Clicked(object sender, EventArgs e)
    {
        if (joueur == 0)
        {
            Button9.Text = "X";
            ligne3 = ligne3 + 3;
            colonne3 = colonne3 + 3;
            diagonale1 = diagonale1 + 3;

            joueur = 1;
        }
        else if (joueur == 1)
        {
            Button9.Text = "O";
            ligne3 = ligne3 + 5;
            colonne3 = colonne3 + 5;
            diagonale1 = diagonale1 + 5;

            joueur = 0;
        }
        Button9.IsEnabled = false;
        CalculScore();
    }

    private void Reset_Clicked(object sender, EventArgs e)
    {
        scoreJoueur1 = 0;
        Joueur1.Text = $"J1 - Score : {scoreJoueur1}";

        scoreJoueur2 = 0;
        Joueur2.Text = $"J2 - Score : {scoreJoueur2}";

        EmptyAll();

        EnabledAll();

        EmptyRowColumnAll();
    }

    private void CalculScore()
    {
        if (ligne1 == 9 | ligne2 == 9 || ligne3 == 9 || colonne1 == 9 || colonne2 == 9 || colonne3 == 9 || diagonale1 == 9 || diagonale2 == 9)
        {
            DisplayAlert("Alert", "Les X ont gagnés", "OK");
            scoreJoueur1 = scoreJoueur1 + 1;
            Joueur1.Text = $"J1 - Score : {scoreJoueur1}";

            EmptyRowColumnAll();

            EmptyAll();

            EnabledAll();
        }
        else if (ligne1 == 15 | ligne2 == 15 || ligne3 == 15 || colonne1 == 15 || colonne2 == 15 || colonne3 == 15 || diagonale1 == 15 || diagonale2 == 15)
        {
            DisplayAlert("Alert", "Les O ont gagnés", "OK");
            scoreJoueur2 = scoreJoueur2 + 1;
            Joueur2.Text = $"J2 - Score : {scoreJoueur2}";

            EmptyRowColumnAll();

            EmptyAll();

            EnabledAll();
        }
        else if (Button1.IsEnabled == false && Button2.IsEnabled == false && Button3.IsEnabled == false && Button4.IsEnabled == false && Button5.IsEnabled == false && Button6.IsEnabled == false && Button7.IsEnabled == false && Button8.IsEnabled == false && Button9.IsEnabled == false)
        {
            DisplayAlert("Alert", "Egalité", "OK");

            EmptyAll();

            EnabledAll();
        }
    }

    private void EnabledAll()
    {
        Button1.IsEnabled = true;
        Button2.IsEnabled = true;
        Button3.IsEnabled = true;
        Button4.IsEnabled = true;
        Button5.IsEnabled = true;
        Button6.IsEnabled = true;
        Button7.IsEnabled = true;
        Button8.IsEnabled = true;
        Button9.IsEnabled = true;
    }

    private void EmptyAll()
    {
        Button1.Text = "";
        Button2.Text = "";
        Button3.Text = "";
        Button4.Text = "";
        Button5.Text = "";
        Button6.Text = "";
        Button7.Text = "";
        Button8.Text = "";
        Button9.Text = "";
    }

    private void EmptyRowColumnAll()
    {
        ligne1 = 0;
        ligne2 = 0;
        ligne3 = 0;
        colonne1 = 0;
        colonne2 = 0;
        colonne3 = 0;
        diagonale1 = 0;
        diagonale2 = 0;
    }
}

