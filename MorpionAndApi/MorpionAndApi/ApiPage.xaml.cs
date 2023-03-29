using System;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Maui.Controls;
namespace MorpionAndApi;

public partial class ApiPage : ContentPage
{
	public ApiPage()
	{
		InitializeComponent();
	}
    private async void Dog_Clicked(object sender, EventArgs e)
    {
        try
        {
            var apiUrl = "https://dog.ceo/api/breeds/image/random";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<DogApiResponse>(content);

                var dogImageUrl = result.message;

                DogImage.Source = dogImageUrl;
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alert", "Une erreur est survenue lors de l'utilisation de l'API" + ex, "OK");
        }
    }

    public class DogApiResponse
    {
        public string message { get; set; }
        public string status { get; set; }
    }
}