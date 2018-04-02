namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class Recibo
    {
        private int _varNumRecibo;
        private int _varIdClienteCredito;
        private bool _varAnulado;
        private double _varMonto;
        private DateTime _varFecha;
        private ListaConcepto _varConcepto;
        private double _varTotalCheques;
        private double _varTotalTransferencias;
        private double _varTotalEfectivo;
        private string _varObservaciones;
        private double _varSaldoActual;
        private List<Entidades.ReciboDetalle> _varReciboDetalle;

        public Recibo()
        {
            this.ReciboDetalle = new List<Entidades.ReciboDetalle>();
        }

        public int NumRecibo
        {
            get => 
                this._varNumRecibo;
            set => 
                this._varNumRecibo = value;
        }

        public int IdClienteCredito
        {
            get => 
                this._varIdClienteCredito;
            set => 
                this._varIdClienteCredito = value;
        }

        public bool Anulado
        {
            get => 
                this._varAnulado;
            set => 
                this._varAnulado = value;
        }

        public double Monto
        {
            get => 
                this._varMonto;
            set => 
                this._varMonto = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public ListaConcepto Concepto
        {
            get => 
                this._varConcepto;
            set => 
                this._varConcepto = value;
        }

        public double TotalCheques
        {
            get => 
                this._varTotalCheques;
            set => 
                this._varTotalCheques = value;
        }

        public double TotalTransferencias
        {
            get => 
                this._varTotalTransferencias;
            set => 
                this._varTotalTransferencias = value;
        }

        public double TotalEfectivo
        {
            get => 
                this._varTotalEfectivo;
            set => 
                this._varTotalEfectivo = value;
        }

        public string Observaciones
        {
            get => 
                this._varObservaciones;
            set => 
                this._varObservaciones = value;
        }

        public double SaldoActual
        {
            get => 
                this._varSaldoActual;
            set => 
                this._varSaldoActual = value;
        }

        public List<Entidades.ReciboDetalle> ReciboDetalle
        {
            get => 
                this._varReciboDetalle;
            set => 
                this._varReciboDetalle = value;
        }

        public enum ListaConcepto
        {
            Cancelacion = 1,
            CancelacionAbono = 2,
            Abono = 3
        }
    }
}

