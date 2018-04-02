namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class Proveedor
    {
        private ushort _varIdProveedor;
        private string _varNombre;
        private string _varCentralTelefonica;
        private string _varFaxPrincipal;
        private string _varDireccion;
        private string _varCorreo;
        private string _varCedula;
        private string _varCc;
        private string _varNCuenta;
        private List<Agente> _varAgentes;
        private List<Encargado> _varEncargados;

        public Proveedor()
        {
            this.Agentes = new List<Agente>();
            this.Encargados = new List<Encargado>();
        }

        public ushort IdProveedor
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

        public string CentralTelefonica
        {
            get => 
                this._varCentralTelefonica;
            set => 
                this._varCentralTelefonica = value;
        }

        public string FaxPrincipal
        {
            get => 
                this._varFaxPrincipal;
            set => 
                this._varFaxPrincipal = value;
        }

        public string Direccion
        {
            get => 
                this._varDireccion;
            set => 
                this._varDireccion = value;
        }

        public string Correo
        {
            get => 
                this._varCorreo;
            set => 
                this._varCorreo = value;
        }

        public string Cedula
        {
            get => 
                this._varCedula;
            set => 
                this._varCedula = value;
        }

        public string CC
        {
            get => 
                this._varCc;
            set => 
                this._varCc = value;
        }

        public string NCuenta
        {
            get => 
                this._varNCuenta;
            set => 
                this._varNCuenta = value;
        }

        public List<Agente> Agentes
        {
            get => 
                this._varAgentes;
            set => 
                this._varAgentes = value;
        }

        public List<Encargado> Encargados
        {
            get => 
                this._varEncargados;
            set => 
                this._varEncargados = value;
        }
    }
}

