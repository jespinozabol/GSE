namespace Entidades
{
    using System;

    public class Referencia : Persona
    {
        private int _varIdReferencia;
        private bool _varActivo;
        private DateTime _varUltimoCalculo;

        public int IdReferencia
        {
            get => 
                this._varIdReferencia;
            set => 
                this._varIdReferencia = value;
        }

        public bool Activo
        {
            get => 
                this._varActivo;
            set => 
                this._varActivo = value;
        }

        public DateTime UltimoCalculo
        {
            get => 
                this._varUltimoCalculo;
            set => 
                this._varUltimoCalculo = value;
        }
    }
}

