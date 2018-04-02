namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class ReciboDocPorPagar
    {
        private int _varNumRecibo;
        private int _varIdProveedor;
        private bool _varAnulado;
        private double _varMonto;
        private DateTime _varFecha;
        private ListaConcepto _varConcepto;
        private double _varTotalCheques;
        private double _varTotalTransferencias;
        private double _varTotalEfectivo;
        private double _varTotalDolares;
        private string _varObservaciones;
        private double _varSaldoActual;
        private string _varNumReciboProveedor;
        private List<ReciboDocPorPagarDetalle> _varReciboDetalle;
        private DateTime _varFechaReciboProveedor;

        public ReciboDocPorPagar()
        {
            this.ReciboDetalle = new List<ReciboDocPorPagarDetalle>();
        }

        public int NumRecibo
        {
            get => 
                this._varNumRecibo;
            set => 
                this._varNumRecibo = value;
        }

        public int IdProveedor
        {
            get => 
                this._varIdProveedor;
            set => 
                this._varIdProveedor = value;
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

        public double TotalDolares
        {
            get => 
                this._varTotalDolares;
            set => 
                this._varTotalDolares = value;
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

        public string NumReciboProveedor
        {
            get => 
                this._varNumReciboProveedor;
            set => 
                this._varNumReciboProveedor = value;
        }

        public List<ReciboDocPorPagarDetalle> ReciboDetalle
        {
            get => 
                this._varReciboDetalle;
            set => 
                this._varReciboDetalle = value;
        }

        public DateTime FechaReciboProveedor
        {
            get => 
                this._varFechaReciboProveedor;
            set => 
                this._varFechaReciboProveedor = value;
        }

        public enum ListaConcepto
        {
            Cancelacion = 1,
            CancelacionAbono = 2,
            Abono = 3
        }
    }
}

