using System;

namespace ClubDeportivo.Entidades
{
    public class E_Cliente
    {
        private int idCliente;
        private string? nombre;
        private string? apellido;

        public int IdCliente
        {
            get { return idCliente; }
            private set { idCliente = value; } // El valor solo puede ser asignado dentro de la clase
        }

        public string? Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value)) nombre = value;
            }
        }

        public string? Apellido
        {
            get { return apellido; }
            set
            {
                if (!string.IsNullOrEmpty(value)) apellido = value;
            }
        }

        public string? TipoDoc { get; set; }
        public int Documento { get; set; }
        public bool AptoFisico { get; set; }

        // Método virtual que se puede sobreescribir en clases derivadas
        public virtual float CalcularDescuento()
        {
            return 0; // Sin descuento por defecto
        }
    }
}
