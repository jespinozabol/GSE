namespace Entidades
{
    using System;

    public class DevolucionPorPaquete
    {
        private int varIdDevolucion;
        private int varIdPaquete;

        public int IdDevolucion
        {
            get => 
                this.varIdDevolucion;
            set => 
                this.varIdDevolucion = value;
        }

        public int IdPaquete
        {
            get => 
                this.varIdPaquete;
            set => 
                this.varIdPaquete = value;
        }
    }
}

