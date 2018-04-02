namespace Entidades
{
    using System;

    public class EmpleadoOtro : Persona
    {
        private string _varTipo;
        private int _varIdEmpleado;

        public string Tipo
        {
            get => 
                this._varTipo;
            set => 
                this._varTipo = value;
        }

        public int IdEmpleado
        {
            get => 
                this._varIdEmpleado;
            set => 
                this._varIdEmpleado = value;
        }
    }
}

