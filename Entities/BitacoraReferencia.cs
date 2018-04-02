namespace Entidades
{
    using System;

    public class BitacoraReferencia
    {
        private int _varIdReferencia;
        private string _varLinea1;
        private string _varLinea2;

        public int IdReferencia
        {
            get => 
                _varIdReferencia;
            set => 
                _varIdReferencia = value;
        }

        public string Linea1
        {
            get => 
                this._varLinea1;
            set => 
                this._varLinea1 = value;
        }

        public string Linea2
        {
            get => 
                this._varLinea2;
            set => 
                this._varLinea2 = value;
        }
    }
}

