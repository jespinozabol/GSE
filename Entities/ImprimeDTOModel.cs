namespace Entidades
{
    using System;

    public class ImprimeDTOModel
    {
        private int _codigo;
        private string _descripcion;
        private double _exist;
        private double _pedir;

        public int Codigo
        {
            get => 
                this._codigo;
            set => 
                this._codigo = value;
        }

        public string Descripcion
        {
            get => 
                this._descripcion;
            set => 
                this._descripcion = value;
        }

        public double Exist
        {
            get => 
                this._exist;
            set => 
                this._exist = value;
        }

        public double Pedir
        {
            get => 
                this._pedir;
            set => 
                this._pedir = value;
        }
    }
}

