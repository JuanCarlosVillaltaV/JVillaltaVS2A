namespace JVillaltaVS2A.Views;

public partial class Login : ContentPage
{
    string user,
           password;
	public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrasena)
                
        {
        user = usuario;
        password = contrasena;
    }






    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContraseña.Text;
        //Valido caja de texto
        if (usuario==user && contrasena==password )
            

        {

           Navigation.PushAsync(new Views.Home());
        }
        else
        {
            DisplayAlert("ERROR", "Usuario/Contrasena Incorreatos", "Cerrar");
        }


    }

   

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}