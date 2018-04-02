namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class Factura
    {
        private int _varNumFactura;
        private int _varIdPersona;
        private ushort _varIdReferencia;
        private bool _varContado;
        private DateTime _varFecha;
        private bool _varAnulada;
        private double _varGanancia;
        private List<FacturaDetalle> _varFacturaDetalles;

        public Factura()
        {
            this.FacturaDetalles = new List<FacturaDetalle>();
        }

        public int NumFactura
        {
            get => 
                this._varNumFactura;
            set => 
                this._varNumFactura = value;
        }

        public int IdPersona
        {
            get => 
                this._varIdPersona;
            set => 
                this._varIdPersona = value;
        }

        public ushort IdReferencia
        {
            get => 
                this._varIdReferencia;
            set => 
                this._varIdReferencia = value;
        }

        public bool Contado
        {
            get => 
                this._varContado;
            set => 
                this._varContado = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public bool Anulada
        {
            get => 
                this._varAnulada;
            set => 
                this._varAnulada = value;
        }

        public double Ganancia
        {
            get => 
                this._varGanancia;
            set => 
                this._varGanancia = value;
        }

        public List<FacturaDetalle> FacturaDetalles
        {
            get => 
                this._varFacturaDetalles;
            set => 
                this._varFacturaDetalles = value;
        }
    }
}

