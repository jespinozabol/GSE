namespace Entidades
{
    using System;

    public class ProductoPorProveedor
    {
        private int _varIdProducto;
        private ushort _varIdProveedor;
        private byte _varPrioridad;
        private string _varNombreProveedor;

        public int Id_Producto
        {
            get => 
                this._varIdProducto;
            set => 
                this._varIdProducto = value;
        }

        public ushort IdProveedor
        {
            get => 
                this._varIdProveedor;
            set => 
                this._varIdProveedor = value;
        }

        public byte Prioridad
        {
            get => 
                this._varPrioridad;
            set => 
                this._varPrioridad = value;
        }

        public string NombreProveedor
        {
            get => 
                this._varNombreProveedor;
            set => 
                this._varNombreProveedor = value;
        }
    }
}

