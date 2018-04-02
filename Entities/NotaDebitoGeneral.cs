namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class NotaDebitoGeneral
    {
        private int _varIdND;
        private DateTime _varFecha;
        private int _varIdClienteCredito;
        private double _varMonto;
        private string _varMotivo;
        private double _varImpuesto;
        private ListaEstado _varEstado;
        private int varNumDias;
        private List<Abono> _varAbonos;

        public int IdND
        {
            get => 
                this._varIdND;
            set => 
                this._varIdND = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public int IdClienteCredito
        {
            get => 
                this._varIdClienteCredito;
            set => 
                this._varIdClienteCredito = value;
        }

        public double Monto
        {
            get => 
                this._varMonto;
            set => 
                this._varMonto = value;
        }

        public string Motivo
        {
            get => 
                this._varMotivo;
            set => 
                this._varMotivo = value;
        }

        public double Impuesto
        {
            get => 
                this._varImpuesto;
            set => 
                this._varImpuesto = value;
        }

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public int NumDias
        {
            get => 
                this.varNumDias;
            set => 
                this.varNumDias = value;
        }

        public List<Abono> Abonos
        {
            get => 
                this._varAbonos;
            set => 
                this._varAbonos = value;
        }

        public enum ListaEstado
        {
            NoAplicada,
            Aplicada,
            Anulada
        }
    }
}

