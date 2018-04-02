namespace Entidades
{
    using System;

    public class ReciboDetalle
    {
        private ListaTipo _varTipo;
        private int _varNumRecibo;
        private int _varDoc;
        private string _varFecha;
        private double _varMonto;

        public ListaTipo Tipo
        {
            get => 
                this._varTipo;
            set => 
                this._varTipo = value;
        }

        public int NumRecibo
        {
            get => 
                this._varNumRecibo;
            set => 
                this._varNumRecibo = value;
        }

        public int Doc
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

        public enum ListaTipo
        {
            Cancelacion = 1,
            FactAbono = 2,
            Abono = 3,
            NotaCredito = 4,
            NCGeneral = 5,
            NDGeneral = 6,
            SaldoActual = 7
        }
    }
}

