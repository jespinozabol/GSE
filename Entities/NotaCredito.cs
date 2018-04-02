namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class NotaCredito
    {
        private int _varIdNC;
        private int _varNumFactura;
        private DateTime _varFecha;
        private double _varMonto;
        private ListaEstado _varEstado;
        private List<NotaCreditoDetalle> _varNCDetalles;

        public NotaCredito()
        {
            this.NCDetalles = new List<NotaCreditoDetalle>();
        }

        public int IdNC
        {
            get => 
                this._varIdNC;
            set => 
                this._varIdNC = value;
        }

        public int NumFactura
        {
            get => 
                this._varNumFactura;
            set => 
                this._varNumFactura = value;
        }

        public DateTime Fecha
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

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public List<NotaCreditoDetalle> NCDetalles
        {
            get => 
                this._varNCDetalles;
            set => 
                this._varNCDetalles = value;
        }

        public enum ListaEstado
        {
            Pendiente,
            Aplicada,
            Anulada
        }
    }
}

