namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class Producto
    {
        private int _varIdProducto;
        private string _varDescripcion;
        private double _varPrecioUnitario;
        private double _varGanancia;
        private double _varExistencias;
        private bool _varImpuesto;
        private double _varMinimo;
        private double _varMaximo;
        private bool _varActivo;
        private bool _varConsignacion;
        private double _varMaxVendido;
        private List<ProductoPorProveedor> _varProveedores;
        private List<ProductoRelacionado> _varRelacionados;
        private Entidades.Bodega _varBodega;
        private bool _varPrincipal;

        public Producto()
        {
            this.ListaProveedores = new List<ProductoPorProveedor>();
            this.ListaRelacionados = new List<ProductoRelacionado>();
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

        public double Ganancia
        {
            get => 
                this._varGanancia;
            set => 
                this._varGanancia = value;
        }

        public double Existencias
        {
            get => 
                this._varExistencias;
            set => 
                this._varExistencias = value;
        }

        public bool Impuesto
        {
            get => 
                this._varImpuesto;
            set => 
                this._varImpuesto = value;
        }

        public double Minimo
        {
            get => 
                this._varMinimo;
            set => 
                this._varMinimo = value;
        }

        public double Maximo
        {
            get => 
                this._varMaximo;
            set => 
                this._varMaximo = value;
        }

        public bool Activo
        {
            get => 
                this._varActivo;
            set => 
                this._varActivo = value;
        }

        public bool Consignacion
        {
            get => 
                this._varConsignacion;
            set => 
                this._varConsignacion = value;
        }

        public double MaxVendido
        {
            get => 
                this._varMaxVendido;
            set => 
                this._varMaxVendido = value;
        }

        public List<ProductoPorProveedor> ListaProveedores
        {
            get => 
                this._varProveedores;
            set => 
                this._varProveedores = value;
        }

        public List<ProductoRelacionado> ListaRelacionados
        {
            get => 
                this._varRelacionados;
            set => 
                this._varRelacionados = value;
        }

        public Entidades.Bodega Bodega
        {
            get => 
                this._varBodega;
            set => 
                this._varBodega = value;
        }

        public bool Principal
        {
            get => 
                this._varPrincipal;
            set => 
                this._varPrincipal = value;
        }
    }
}

