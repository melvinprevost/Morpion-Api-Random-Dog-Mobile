namespace MorpionAndApi;

public partial class CounterPage : ContentPage
{
    int countJoueur1 = 0;
    int countJoueur2 = 0;
    public CounterPage()
    {
        InitializeComponent();
    }

    private void Joueur1_Clicked(object sender, EventArgs e)
    {
        countJoueur1++;
        Joueur1.Text = $"Joueur 1 : {countJoueur1}";

        if (countJoueur1 == 5)
        {
            DisplayAlert("Alert", "Le joueur 1 a gagné !", "OK");
            countJoueur1 = 0;
            countJoueur2 = 0;
            Joueur1.Text = $"Joueur 1 : {countJoueur1}";
            Joueur2.Text = $"Joueur 2 : {countJoueur2}";
        }
    }

    private void Joueur2_Clicked(object sender, EventArgs e)
    {
        countJoueur2++;
        Joueur2.Text = $"Joueur 2 : {countJoueur2}";

        if (countJoueur2 == 5)
        {
            DisplayAlert("Alert", "Le joueur 2 a gagné !", "OK");
            countJoueur1 = 0;
            countJoueur2 = 0;
            Joueur1.Text = $"Joueur 1 : {countJoueur1}";
            Joueur2.Text = $"Joueur 2 : {countJoueur2}";
        }
    }
}