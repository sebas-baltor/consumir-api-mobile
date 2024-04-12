namespace mobile;
using HTTPupt;

public partial class MainPage : ContentPage
{
	private readonly HttpClient _cliente = new HttpClient();
	private const string ApiUrl = "http://localhost:5276/api";

    PeticionHTTP PeticionHTTP = new PeticionHTTP("http://localhost:5276/");

	public MainPage()
	{
		InitializeComponent();
	}

    private async void ConsumirApiBtn_Clicked(object sender, EventArgs e)
    {
		try{
			HttpResponseMessage res = await _cliente.GetAsync($"{ApiUrl}/Concatenar?concatenacion={ConcatenarText.Text}");
			if (res.IsSuccessStatusCode)
			{
				string content = await res.Content.ReadAsStringAsync();
				LabelOne.Text = content;
			}
			else {
				LabelOne.Text = "algo no salio como se esperaba";
			}
		}
        catch (Exception ex)
        {
            // Manejar cualquier error de red u otros errores
            await DisplayAlert("Error", $"Un error ha ocurrido: {ex.Message}", "OK");
        }
  //      PeticionHTTP.PedirComunicacion("/api/Concatenar?concatenacion="+ConcatenarText.Text,MetodoHTTP.GET,TipoContenido.JSON);
		//string respuesta = PeticionHTTP.ObtenerJson();
		//if (respuesta != null)
		//{
		//	LabelOne.Text = respuesta;
		//}
		//else { LabelOne.Text = "al consumir la api algo sucedio mal"; }
    }
}

