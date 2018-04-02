namespace Entidades
{
    using System;

    public class LineaReciboDocPorPagar : LineaRecibo
    {
        private string _varIdDoc;

        public string IdDoc
        {
            get => 
                this._varIdDoc;
            set => 
                this._varIdDoc = value;
        }
    }
}

