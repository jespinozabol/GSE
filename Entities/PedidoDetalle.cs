namespace Entidades
{
    using System;

    public class PedidoDetalle
    {
        private int _varIdPedido;
        private int _varIdProducto;
        private double _varCantidad;
        private double _varCantidadRecibida;

        public int IdPedido
        {
            get => 
                this._varIdPedido;
            set => 
                this._varIdPedido = value;
        }

        public int IdProducto
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

        public double CantidadRecibida
        {
            get => 
                this._varCantidadRecibida;
            set => 
                this._varCantidadRecibida = value;
        }
    }
}

