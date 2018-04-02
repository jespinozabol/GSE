namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class ResumenPedido
    {
        private string _proveedor;
        private bool _imprime;
        private bool _enviarEmail;
        private bool _pedir;
        private List<string> _email;
        private string _transporte;

        public string Proveedor
        {
            get => 
                this._proveedor;
            set => 
                this._proveedor = value;
        }

        public bool Imprime
        {
            get => 
                this._imprime;
            set => 
                this._imprime = value;
        }

        public bool EnviarEmail
        {
            get => 
                this._enviarEmail;
            set => 
                this._enviarEmail = value;
        }

        public bool Pedir
        {
            get => 
                this._pedir;
            set => 
                this._pedir = value;
        }

        public List<string> Email
        {
            get => 
                this._email;
            set => 
                this._email = value;
        }

        public string Transporte
        {
            get => 
                this._transporte;
            set => 
                this._transporte = value;
        }
    }
}

