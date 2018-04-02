namespace Entidades
{
    using System;

    public class Bodega
    {
        private int _varIdProducto;
        private double _varExistBodega;
        private double _varMaximoCaja;

        public int Id_Producto
        {
            get => 
                this._varIdProducto;
            set => 
                this._varIdProducto = value;
        }

        public double ExistBodega
        {
            get => 
                this._varExistBodega;
            set => 
                this._varExistBodega = value;
        }

        public double MaximoCaja
        {
            get => 
                this._varMaximoCaja;
            set => 
                this._varMaximoCaja = value;
        }
    }
}

