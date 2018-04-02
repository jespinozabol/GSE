namespace Entidades
{
    using System;

    public class Telefonos_Cliente
    {
        private int varId_Persona;
        private int varPrioridad;
        private string varTelefono;
        private string varDetalle;

        public int Id_Persona
        {
            get => 
                this.varId_Persona;
            set => 
                this.varId_Persona = value;
        }

        public int Prioridad
        {
            get => 
                this.varPrioridad;
            set => 
                this.varPrioridad = value;
        }

        public string Telefono
        {
            get => 
                this.varTelefono;
            set => 
                this.varTelefono = value;
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

