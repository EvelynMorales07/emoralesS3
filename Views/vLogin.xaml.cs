namespace emoralesS3.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}
    //string user;
    //string password;

    int[] vector = new int[5]; // declara un vector de 5 elementos de tipo entero

    // inicializa el vector con valores

    public vLogin(string usuario, string contrasena)
    {
        InitializeComponent();
        //user = usuario;
        // password = contrasena;
        vector[0] = new Usuario("");
        vector[1] = 2;
        vector[2] = 3;
        vector[3] = 4;
        vector[4] = 5;
        foreach (int elemento in vector)
        {
            Console.WriteLine(elemento);
        }
    }
  

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (vector == txtUsuario.Text && password== txtContraseña.Text)
        {
            Navigation.PushAsync(new vHome(vector));
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO Y CONTRASEÑA SON INCORRECTOS","OK");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());
    }
}