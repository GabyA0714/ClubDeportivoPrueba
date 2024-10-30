using System;

namespace ClubDeportivo.Entidades
{
    public class E_NoSocio : E_Cliente
    {
        public override float CalcularDescuento()
        {
            return 0; // No se aplica descuento para no socios
        }
    }
}

