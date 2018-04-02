namespace Entidades
{
    using System;

    public class EmailCliente
    {
        private int varId_Persona;
        private string varEmail;
        private string varDetalle;

        public int Id_Persona
        {
            get => 
                this.varId_Persona;
            set => 
                this.varId_Persona = value;
        }

        public string Email
        {
            get => 
                this.varEmail;
            set => 
                this.varEmail = value;
        }

        public string Detalle
        {
            get => 
                this.varDetalle;
            set => 
                this.varDetalle = value;
        }
    }
}

