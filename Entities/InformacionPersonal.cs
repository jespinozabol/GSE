namespace Entidades
{
    using System;

    public class InformacionPersonal
    {
        private int _varIdPersona;
        private string _varDireccion;
        private string _varObservaciones;
        private string _varTelefonoPrincipal;
        private string _varOtroTelefono;
        private string _varFaxPrincipal;
        private string _varEmail;
        private string _varSitioWeb;

        public int IdPersona
        {
            get => 
                this._varIdPersona;
            set => 
                this._varIdPersona = value;
        }

        public string Direccion
        {
            get => 
                this._varDireccion;
            set => 
                this._varDireccion = value;
        }

        public string Observaciones
        {
            get => 
                this._varObservaciones;
            set => 
                this._varObservaciones = value;
        }

        public string TelefonoPrincipal
        {
            get => 
                this._varTelefonoPrincipal;
            set => 
                this._varTelefonoPrincipal = value;
        }

        public string OtroTelefono
        {
            get => 
                this._varOtroTelefono;
            set => 
                this._varOtroTelefono = value;
        }

        public string FaxPrincipal
        {
            get => 
                this._varFaxPrincipal;
            set => 
                this._varFaxPrincipal = value;
        }

        public string Email
        {
            get => 
                this._varEmail;
            set => 
                this._varEmail = value;
        }

        public string SitioWeb
        {
            get => 
                this._varSitioWeb;
            set => 
                this._varSitioWeb = value;
        }
    }
}

