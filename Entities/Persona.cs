namespace Entidades
{
    using System;

    public class Persona
    {
        private int _varIdPersona;
        private string _varNombre;
        private string _varApellido1;
        private string _varApellido2;
        private string _varCedula;
        private InformacionPersonal _varOtraInformacion;

        public Persona()
        {
            this.OtraInformacion = new InformacionPersonal();
        }

        public int IdPersona
        {
            get => 
                this._varIdPersona;
            set => 
                this._varIdPersona = value;
        }

        public string Nombre
        {
            get => 
                this._varNombre;
            set => 
                this._varNombre = value;
        }

        public string PrimerApellido
        {
            get => 
                this._varApellido1;
            set => 
                this._varApellido1 = value;
        }

        public string SegundoApellido
        {
            get => 
                this._varApellido2;
            set => 
                this._varApellido2 = value;
        }

        public string Cedula
        {
            get => 
                this._varCedula;
            set => 
                this._varCedula = value;
        }

        public InformacionPersonal OtraInformacion
        {
            get => 
                this._varOtraInformacion;
            set => 
                this._varOtraInformacion = value;
        }
    }
}

