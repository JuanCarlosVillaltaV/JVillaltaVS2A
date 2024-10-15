namespace JVillaltaVS2A.Views;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    private void Nota_Clicked(object sender, EventArgs e)
    {
        // Obtener las notas
        if (double.TryParse(notaSeguimiento1.Text, out double nota1) &&
            double.TryParse(examen1.Text, out double examenes1) &&
            double.TryParse(notaSeguimiento2.Text, out double nota2) &&
            double.TryParse(examen2.Text, out double examenes2))
          



        {
            


            // Validar rangos
            if 
                (IsValid(nota1) && 
                IsValid(examenes1) && 
                IsValid(nota2) && 
                IsValid(examenes2))
               

            {
                // Calcular notas parciales
                double parcial1 = (nota1 * 0.3) + (examenes1 * 0.2);
                double parcial2 = (nota2 * 0.3) + (examenes2 * 0.2);
                double notaFinal = parcial1 + parcial2;

                // Determinar 
                string estado = GetEstado(notaFinal);
                string fecha = dFechas.Date.ToString("d"); // Formato de fecha
              

                

                // Mostrar los resultados en un DisplayAlert
                string message = $"Su nota 1: {nota1}\n" +
                                 $"Su examen 1: {examenes1}\n" +
                                 $"Su nota 2: {nota2}\n" +
                                 $"Su examen 2: {examenes2}\n" +
                                 $"Su nota final: {notaFinal:F2}\n" +
                                 $"Estado: {estado}\n" +
                                 $"Fecha: {fecha}";

                DisplayAlert("Alert", message, "Cerrar");






                // Mostrar resultado
                resultadoLabel.Text = $"Nota Final: {notaFinal:F2} - Estado: {estado}";
            }
            else
            {
                DisplayAlert("Error", "Las notas deben estar entre 0 y 10.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingrese valores numéricos válidos.", "OK");

        }
        
       
    }

    

    private bool IsValid(double value)
    {
        return value >= 0 && value <= 10;
    }

    private string GetEstado(double notaFinal)
    {
        if (notaFinal >= 7)
            return "Aprobado";
        else if (notaFinal >= 5 && notaFinal < 7)
            return "Complementario";
        else
            return "REPROBADO";
    }


}