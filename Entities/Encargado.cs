﻿namespace Entidades
{
    using System;

    public class Encargado
    {
        private short _varIdEncargado;
        private short _varIdProveedor;
        private string _varNombre;
        private string _varServicio;
        private string _varTelefono1;
        private string _varTelefono2;
        private string _varExt1;
        private string _varExt2;
        private string _varFax;
        private string _varCorreo;

        public short IdEncargado
        {
            get => 
                this._varIdEncargado;
            set => 
                this._varIdEncargado = value;
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

        public string Servicio
        {
            get => 
                this._varServicio;
            set => 
                this._varServicio = value;
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

        public string Ext1
        {
            get => 
                this._varExt1;
            set => 
                this._varExt1 = value;
        }

        public string Ext2
        {
            get => 
                this._varExt2;
            set => 
                this._varExt2 = value;
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

