namespace Entidades
{
    using System;

    public class Consecutivo
    {
        private int _varConsecutivo;
        private bool _varBloqueo;
        private string _varTabla;

        public int Valor
        {
            get => 
                this._varConsecutivo;
            set => 
                this._varConsecutivo = value;
        }

        public bool Bloqueo
        {
            get => 
                this._varBloqueo;
            set => 
                this._varBloqueo = value;
        }

        public string Tabla
        {
            get => 
                this._varTabla;
            set => 
                this._varTabla = value;
        }
    }
}

