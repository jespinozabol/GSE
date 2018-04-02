namespace Entidades
{
    using System;

    public class LineaRecibo
    {
        private string _varTipo;
        private string _varDoc;
        private string _varFecha;
        private double _varMonto;

        public string Tipo
        {
            get => 
                this._varTipo;
            set => 
                this._varTipo = value;
        }

        public string Doc
        {
            get => 
                this._varDoc;
            set => 
                this._varDoc = value;
        }

        public string Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public double Monto
        {
            get => 
                this._varMonto;
            set => 
                this._varMonto = value;
        }
    }
}

