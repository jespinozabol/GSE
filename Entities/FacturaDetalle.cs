namespace Entidades
{
    using System;

    public class FacturaDetalle
    {
        private int _varIdFacturaDet;
        private int _varNumFactura;
        private int _varIdProducto;
        private string _varDescripcion;
        private double _varPrecioUnitario;
        private double _varCantidad;
        private double _varImpuesto;
        private double _varDescuento;
        private double _varTimpuesto;
        private double _varTdescuento;

        public int IdFacturaDet
        {
            get => 
                this._varIdFacturaDet;
            set => 
                this._varIdFacturaDet = value;
        }

        public int NumFactura
        {
            get => 
                this._varNumFactura;
            set => 
                this._varNumFactura = value;
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

        public double Cantidad
        {
            get => 
                this._varCantidad;
            set => 
                this._varCantidad = value;
        }

        public double Impuesto
        {
            get => 
                this._varImpuesto;
            set => 
                this._varImpuesto = value;
        }

        public double Descuento
        {
            get => 
                this._varDescuento;
            set => 
                this._varDescuento = value;
        }

        public double Timpuesto
        {
            get => 
                this._varTimpuesto;
            set => 
                this._varTimpuesto = value;
        }

        public double Tdescuento
        {
            get => 
                this._varTdescuento;
            set => 
                this._varTdescuento = value;
        }
    }
}

