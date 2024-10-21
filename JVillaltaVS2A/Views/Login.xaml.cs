namespace JVillaltaVS2A.Views;

public partial class Login : ContentPage
{
    //Vector guarda la contrase�a del arreglo 
    private string[] user = {"Juan Carlos Villalta Villalta",
                              "Carlos",
                                "Ana",
                               "Jose" };

    private string[] password = {"12345zapotillo",
                                "carlos123",
                                 "ana123",
                                "jose123" };

    
    public Login()
    {
        InitializeComponent();
    }

    //Cosntructor inicia la views
    public Login(string usuario,
                 string contrasena)
    {
        InitializeComponent();

    }






    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        //Variables que inician sesi�n
        string usuario = txtUsuario.Text;
        string contrasena = txtContrase�a.Text;

        //L�gica
        //Busca el indice dentro del arreglo 
        //Metodo Array

        int index = Array.IndexOf(user,
                                  usuario);

        

        //L�gica de Autenticaci�n


        if (index >= 0 && password[index] == contrasena)
        {

            // Mensaje
            DisplayAlert("Bienvenido", $"Hola, {usuario}!", "Cerrar");
            //Llama a la carpeta y Operaciones.xaml
            Navigation.PushAsync(new Views.Home());

        }


        else
        {
            DisplayAlert("ERROR", "Usuario/Contrase�a Incorrectos", "Cerrar");
        }



    }



    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}