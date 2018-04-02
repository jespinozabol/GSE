namespace Entidades
{
    using System;

    public class ProductoRelacionado
    {
        private long _varIdProducto;
        private int _varPrioridad;
        private long _varRelacion;
        private string _varObservacion;

        public long Id_Producto
        {
            get => 
                this._varIdProducto;
            set => 
                this._varIdProducto = value;
        }

        public int Prioridad
        {
            get => 
                this._varPrioridad;
            set => 
                this._varPrioridad = value;
        }

        public long Relacion
        {
            get => 
                this._varRelacion;
            set => 
                this._varRelacion = value;
        }

        public string Observacion
        {
            get => 
                this._varObservacion;
            set => 
                this._varObservacion = value;
        }
    }
}

