namespace Entidades
{
    using System;

    public class ListadoResumen
    {
        private int _varIdListado;
        private int _varIdProducto;
        private double _varCantidad;

        public int IdListado
        {
            get => 
                this._varIdListado;
            set => 
                this._varIdListado = value;
        }

        public int Id_Producto
        {
            get => 
                this._varIdProducto;
            set => 
                this._varIdProducto = value;
        }

        public double Cantidad
        {
            get => 
                this._varCantidad;
            set => 
                this._varCantidad = value;
        }
    }
}

