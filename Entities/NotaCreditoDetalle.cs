namespace Entidades
{
    using System;

    public class NotaCreditoDetalle
    {
        private int _varIdNC;
        private double _varCantidad;
        private int _varIdProducto;
        private string _varDescripcion;
        private double _varPrecioUnitario;
        private double _varDescuento;
        private double _varImpuesto;
        private double _varTTdescuento;
        private double _varTTimpuesto;

        public int IdNC
        {
            get => 
                this._varIdNC;
            set => 
                this._varIdNC = value;
        }

        public double Cantidad
        {
            get => 
                this._varCantidad;
            set => 
                this._varCantidad = value;
        }

        public int Id_Producto
        {
            get => 
                this._varIdProducto;
            set => 
                this._varIdProducto = value;
        }

        public string Descripcion
        {
            get => 
                this._varDescripcion;
            set => 
                this._varDescripcion = value;
        }

        public double PrecioUnitario
        {
            get => 
                this._varPrecioUnitario;
            set => 
                this._varPrecioUnitario = value;
        }

        public double Descuento
        {
            get => 
                this._varDescuento;
            set => 
                this._varDescuento = value;
        }

        public double Impuesto
        {
            get => 
                this._varImpuesto;
            set => 
                this._varImpuesto = value;
        }

        public double Tdescuento
        {
            get => 
                this._varTTdescuento;
            set => 
                this._varTTdescuento = value;
        }

        public double Timpuesto
        {
            get => 
                this._varTTimpuesto;
            set => 
                this._varTTimpuesto = value;
        }
    }
}

