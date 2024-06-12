namespace emoralesS3.Views;

public partial class vHome : ContentPage
{
	public vHome(string nombre)
	{
		InitializeComponent();
		lblNombre.Text = "Bienvenido " + nombre;
	}
}