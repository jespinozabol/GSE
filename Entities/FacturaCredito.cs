namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class FacturaCredito : Factura
    {
        private double _varMonto;
        private int _varNumDias;
        private int _varIdCredito;
        private List<Abono> _varAbonos;
        private List<NotaCredito> _varNotasCredito;
        private ListaEstado _varEstado;

        public FacturaCredito()
        {
            this.Abonos = new List<Abono>();
            this.NotasCredito = new List<NotaCredito>();
        }

        public double Monto
        {
            get => 
                this._varMonto;
            set => 
                this._varMonto = value;
        }

        public int NumDias
        {
            get => 
                this._varNumDias;
            set => 
                this._varNumDias = value;
        }

        public int IdCredito
        {
            get => 
                this._varIdCredito;
            set => 
                this._varIdCredito = value;
        }

        public List<Abono> Abonos
        {
            get => 
                this._varAbonos;
            set => 
                this._varAbonos = value;
        }

        public List<NotaCredito> NotasCredito
        {
            get => 
                this._varNotasCredito;
            set => 
                this._varNotasCredito = value;
        }

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public enum ListaEstado
        {
            Pendiente,
            Aplicada,
            Anulada
        }
    }
}

