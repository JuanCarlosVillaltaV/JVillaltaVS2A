namespace JVillaltaVS2A.Views;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();
    }

    private void Nota_Clicked(object sender, EventArgs e)
    {
        // Validación de las notas 
        if (double.TryParse(txtSeguimiento1.Text, out double nota1) &&
            double.TryParse(txtexamen1.Text, out double examenes1) &&
            double.TryParse(txtSeguimiento2.Text, out double nota2) &&
            double.TryParse(txtexamen2.Text, out double examenes2))  
        {
            // Validaciones
            if 
                (IsValid(nota1) && 
                IsValid(examenes1) && 
                IsValid(nota2) && 
                IsValid(examenes2))
               

            {
                // Se cálcula notas parciales
                double par1 = (nota1 * 0.3) + (examenes1 * 0.2);
                double par2 = (nota2 * 0.3) + (examenes2 * 0.2);
                double notaFinal = par1 + par2;

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






               //PresentationMode el resultado
                resultadoLabel.Text = $"Nota Final: {notaFinal:F2} - Estado: {estado}";
            }
            else
            {
                DisplayAlert("Error", "Las notas deben estar entre 0 y 10.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingrese valores que sean numéricos válidos.", "OK");

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