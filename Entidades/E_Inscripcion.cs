using System;

namespace ClubDeportivo.Entidades
{
    public class E_Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdCliente { get; set; }
        public int IdActividad { get; set; }
        private bool pagado;

        public bool Pagado
        {
            get { return pagado; }
            private set { pagado = value; }
        }

        public void RegistrarPago()
        {
            Pagado = true; // Permite marcar como pagado de forma controlada
        }

        public E_Inscripcion()
        {
            Pagado = false;
        }
    }
}

