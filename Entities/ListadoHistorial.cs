namespace Entidades
{
    using System;

    public class ListadoHistorial
    {
        private int _varIdListado;
        private int _varIdProducto;
        private double _varCantidad;
        private DateTime _varFecha;
        private string _varRetiro;
        private string _varHora;

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

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public string Retira
        {
            get => 
                this._varRetiro;
            set => 
                this._varRetiro = value;
        }

        public string Hora
        {
            get => 
                this._varHora;
            set => 
                this._varHora = value;
        }
    }
}

