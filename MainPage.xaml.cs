namespace mchuquinT1
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
        }
        private void btnCalculo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            double aporte = (sueldo * 9.45) / 100;
            DisplayAlert("ALERTA", "Bienvenido " + nombre + " " + apellido + "\n Tienes " + edad + " años " + "\n Tu aporte es de " + aporte, "Cerrar");


        }
    }

}
