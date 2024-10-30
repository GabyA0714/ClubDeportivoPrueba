using System;

namespace ClubDeportivo.Entidades
{
    public class E_Socio : E_Cliente
    {
        public override float CalcularDescuento()
        {
            return 0.1f; // Descuento del 10% para socios
        }
    }
}

