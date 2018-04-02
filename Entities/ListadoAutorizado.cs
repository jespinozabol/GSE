namespace Entidades
{
    using System;

    public class ListadoAutorizado
    {
        private int _varIdAutorizado;
        private int _varIdListado;
        private string _varNombre;
        private string _varTelefono;
        private bool _varActivo;

        public int IdAutorizado
        {
            get => 
                this._varIdAutorizado;
            set => 
                this._varIdAutorizado = value;
        }

        public int IdListado
        {
            get => 
                this._varIdListado;
            set => 
                this._varIdListado = value;
        }

        public string Nombre
        {
            get => 
                this._varNombre;
            set => 
                this._varNombre = value;
        }

        public string Telefono
        {
            get => 
                this._varTelefono;
            set => 
                this._varTelefono = value;
        }

        public bool Activo
        {
            get => 
                this._varActivo;
            set => 
                this._varActivo = value;
        }
    }
}

