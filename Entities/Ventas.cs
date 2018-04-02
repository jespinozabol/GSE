namespace Entidades
{
    using System;

    public class Ventas
    {
        private int varIdProducto;
        private int varMes;
        private int varAño;
        private double varCantidad;

        public int IdProducto
        {
            get => 
                this.varIdProducto;
            set => 
                this.varIdProducto = value;
        }

        public int Mes
        {
            get => 
                this.varMes;
            set => 
                this.varMes = value;
        }

        public int Año
        {
            get => 
                this.varAño;
            set => 
                this.varAño = value;
        }

        public double Cantidad
        {
            get => 
                this.varCantidad;
            set => 
                this.varCantidad = value;
        }
    }
}

