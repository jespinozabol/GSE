namespace Entidades
{
    using System;

    public class Devolucion
    {
        private int _varIdDevolucion;
        private int _varIdProveedor;
        private string _varFactura;
        private DateTime _varFecha;
        private string _varBoleta;
        private double _varCantidad;
        private string _varProducto;
        private int _varCodigo;
        private string _varMotivo;
        private string _varObservaciones;

        public int IdDevolucion
        {
            get => 
                this._varIdDevolucion;
            set => 
                this._varIdDevolucion = value;
        }

        public int IdProveedor
        {
            get => 
                this._varIdProveedor;
            set => 
                this._varIdProveedor = value;
        }

        public string Factura
        {
            get => 
                this._varFactura;
            set => 
                this._varFactura = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public string Boleta
        {
            get => 
                this._varBoleta;
            set => 
                this._varBoleta = value;
        }

        public double Cantidad
        {
            get => 
                this._varCantidad;
            set => 
                this._varCantidad = value;
        }

        public string Producto
        {
            get => 
                this._varProducto;
            set => 
                this._varProducto = value;
        }

        public int Codigo
        {
            get => 
                this._varCodigo;
            set => 
                this._varCodigo = value;
        }

        public string Motivo
        {
            get => 
                this._varMotivo;
            set => 
                this._varMotivo = value;
        }

        public string Observaciones
        {
            get => 
                this._varObservaciones;
            set => 
                this._varObservaciones = value;
        }
    }
}

