namespace Entidades
{
    using System;

    public class ProformaDetalle
    {
        private int _varNumProforma;
        private int _varIdProducto;
        private double _varPrecioUnitario;
        private double _varCantidad;
        private double _varImpuesto;
        private double _varDescuento;
        private double _varTTimpuesto;
        private double _varTTdescuento;

        public int NumProforma
        {
            get => 
                this._varNumProforma;
            set => 
                this._varNumProforma = value;
        }

        public int IdProducto
        {
            get => 
                this._varIdProducto;
            set => 
                this._varIdProducto = value;
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
                this._varTTimpuesto;
            set => 
                this._varTTimpuesto = value;
        }

        public double Tdescuento
        {
            get => 
                this._varTTdescuento;
            set => 
                this._varTTdescuento = value;
        }
    }
}

