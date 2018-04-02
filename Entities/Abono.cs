namespace Entities
{
    using System;

    public class Abono
    {
        private int _varIdAbono;
        private long _varNumDoc;
        private DateTime _varFecha;
        private double _varMonto;
        private string _varObservaciones;
        private ListaEstado _varEstado;
        private ListaTipoDoc _varTipoDoc;

        public int IdAbono
        {
            get => 
                this._varIdAbono;
            set => 
                this._varIdAbono = value;
        }

        public long NumDoc
        {
            get => 
                this._varNumDoc;
            set => 
                this._varNumDoc = value;
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

        public string Observaciones
        {
            get => 
                this._varObservaciones;
            set => 
                this._varObservaciones = value;
        }

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public ListaTipoDoc TipoDoc
        {
            get => 
                this._varTipoDoc;
            set => 
                this._varTipoDoc = value;
        }

        public enum ListaEstado
        {
            Pendiente,
            Aplicado,
            Anulado
        }

        public enum ListaTipoDoc
        {
            FACT,
            NDG
        }
    }
}

