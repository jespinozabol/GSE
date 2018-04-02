namespace Entidades
{
    using System;

    public class Paquete
    {
        private int varIdPaqute;
        private int varIdProveedor;
        private string varNombreProveedor;

        public int IdPaquete
        {
            get => 
                this.varIdPaqute;
            set => 
                this.varIdPaqute = value;
        }

        public int IdProveedor
        {
            get => 
                this.varIdProveedor;
            set => 
                this.varIdProveedor = value;
        }

        public string NombreProveedor
        {
            get => 
                this.varNombreProveedor;
            set => 
                this.varNombreProveedor = value;
        }
    }
}

