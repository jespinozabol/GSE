namespace Entidades
{
    using System;

    public class AbonoFacturaProveedor
    {
        private int _varIdAbono;
        private int _varIdFacturaProveedor;
        private DateTime _varFecha;
        private double _varMonto;
        private string _varMotivo;
        private ListaEstado _varEstado;
        private string _varNumAbono;

        public int IdAbono
        {
            get => 
                this._varIdAbono;
            set => 
                this._varIdAbono = value;
        }

        public int IdFacturaProveedor
        {
            get => 
                this._varIdFacturaProveedor;
            set => 
                this._varIdFacturaProveedor = value;
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

        public string Motivo
        {
            get => 
                this._varMotivo;
            set => 
                this._varMotivo = value;
        }

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public string NumAbono
        {
            get => 
                this._varNumAbono;
            set => 
                this._varNumAbono = value;
        }

        public enum ListaEstado
        {
            Pendiente,
            Aplicado,
            Anulado
        }
    }
}

