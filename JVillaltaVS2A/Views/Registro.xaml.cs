namespace JVillaltaVS2A.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string contrasena = txtContraseña.Text;

		Navigation.PushAsync(new Views.Login(usuario,
			                                 contrasena));
    }
}