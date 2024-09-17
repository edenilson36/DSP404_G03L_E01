namespace BancoAdajet
{
    public class Cuenta
    {
        // Atributos
        private string numeroCuenta;
        private string duiCliente;
        private double saldoActual;
        private double interesAnual;

        // Constructor
        public Cuenta(string dui, double saldoInicial, double interes)
        {
            duiCliente = dui;
            saldoActual = saldoInicial;
            interesAnual = interes;
            numeroCuenta = GenerarNumeroCuenta();
        }

        // Propiedades
        public string NumeroCuenta => numeroCuenta;
        public string DuiCliente => duiCliente;
        public double SaldoActual => saldoActual;

        // Método para actualizar el saldo aplicando el interés diario
        public void ActualizarSaldo()
        {
            double interesDiario = interesAnual / 365;
            saldoActual += saldoActual * (interesDiario / 100);
        }

        // Método para ingresar una cantidad a la cuenta
        public void Ingresar(double cantidad)
        {
            saldoActual += cantidad;
        }

        // Método para retirar una cantidad de la cuenta
        public bool Retirar(double cantidad)
        {
            if (cantidad <= saldoActual)
            {
                saldoActual -= cantidad;
                return true;
            }
            return false;
        }

        // Método para mostrar todos los datos de la cuenta
        public string MostrarDatos()
        {
            return $"Número de cuenta: {numeroCuenta}\nDUI: {duiCliente}\nSaldo actual: {saldoActual:C}\nInterés anual: {interesAnual}%";
        }

        // Método para generar el número de cuenta con el formato DDMMYYYY-XXXXXX
        private string GenerarNumeroCuenta()
        {
            string fecha = DateTime.Now.ToString("ddMMyyyy");
            Random random = new Random();
            string correlativo = random.Next(1000001, 9999999).ToString("D6");
            return $"{fecha}-{correlativo}";
        }

    }
}
