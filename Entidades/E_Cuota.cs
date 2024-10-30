using System;

namespace ClubDeportivo.Entidades
{
    public class E_Cuota
    {
        private float monto;

        public int IdCuota { get; set; }
        public int IdCliente { get; set; }
        public string? FormaPago { get; set; }
        public DateTime Fecha { get; private set; } // Solo puede asignarse en el constructor

        public float Monto
        {
            get { return monto; }
            set
            {
                if (value > 0) monto = value;
            }
        }

        public E_Cuota()
        {
            Fecha = DateTime.Now;
            monto = 10000;
        }
    }
}
