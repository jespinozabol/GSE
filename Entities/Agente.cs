namespace Entidades
{
    using System;

    public class Agente
    {
        private short _varIdAgente;
        private short _varIdProveedor;
        private string _varNombre;
        private string _varTelefono1;
        private string _varTelefono2;
        private string _varFax;
        private string _varCorreo;

        public short IdAgente
        {
            get => 
                this._varIdAgente;
            set => 
                this._varIdAgente = value;
        }

        public short IdProveedor
        {
            get => 
                this._varIdProveedor;
            set => 
                this._varIdProveedor = value;
        }

        public string Nombre
        {
            get => 
                this._varNombre;
            set => 
                this._varNombre = value;
        }

        public string Telefono1
        {
            get => 
                this._varTelefono1;
            set => 
                this._varTelefono1 = value;
        }

        public string Telefono2
        {
            get => 
                this._varTelefono2;
            set => 
                this._varTelefono2 = value;
        }

        public string Fax
        {
            get => 
                this._varFax;
            set => 
                this._varFax = value;
        }

        public string Correo
        {
            get => 
                this._varCorreo;
            set => 
                this._varCorreo = value;
        }
    }
}

