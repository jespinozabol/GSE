namespace Entidades
{
    using System;

    public class Bitacora
    {
        private int _varIdCredito;
        private string _varFechaHora;
        private string _varDescripcion;

        public int IdCredito
        {
            get => 
                this._varIdCredito;
            set => 
                this._varIdCredito = value;
        }

        public string FechaHora
        {
            get => 
                this._varFechaHora;
            set => 
                this._varFechaHora = value;
        }

        public string Descripcion
        {
            get => 
                this._varDescripcion;
            set => 
                this._varDescripcion = value;
        }
    }
}

