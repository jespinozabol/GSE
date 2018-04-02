namespace Entidades
{
    using System;

    public class ReciboDocPorPagarDetalle
    {
        private ListaTipo _varTipo;
        private int _varNumRecibo;
        private int _varIdDoc;

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

        public int IdDoc
        {
            get => 
                this._varIdDoc;
            set => 
                this._varIdDoc = value;
        }

        public enum ListaTipo
        {
            Cancelacion = 1,
            FactAbono = 2,
            Abono = 3,
            NotaCredito = 4,
            NotaDebito = 5,
            NotaCreditoGeneral = 6
        }
    }
}

