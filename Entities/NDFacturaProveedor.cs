namespace Entidades
{
    using System;

    public class NDFacturaProveedor
    {
        private int varIdND;
        private int _varIdDocPorPagar;
        private int _varNumND;
        private double _varTotal;
        private double _varIV;
        private string _varMotivo;
        private int _varBoleta;
        private DateTime _varFecha;
        private DateTime _varFechaBoleta;
        private double _varSubTotalIV;
        private double _varSubTotalEx;

        public int IdND
        {
            get => 
                this.varIdND;
            set => 
                this.varIdND = value;
        }

        public int IdDocPorPagar
        {
            get => 
                this._varIdDocPorPagar;
            set => 
                this._varIdDocPorPagar = value;
        }

        public int NumND
        {
            get => 
                this._varNumND;
            set => 
                this._varNumND = value;
        }

        public double Total
        {
            get => 
                this._varTotal;
            set => 
                this._varTotal = value;
        }

        public double IV
        {
            get => 
                this._varIV;
            set => 
                this._varIV = value;
        }

        public string Motivo
        {
            get => 
                this._varMotivo;
            set => 
                this._varMotivo = value;
        }

        public int Boleta
        {
            get => 
                this._varBoleta;
            set => 
                this._varBoleta = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public DateTime FechaBoleta
        {
            get => 
                this._varFechaBoleta;
            set => 
                this._varFechaBoleta = value;
        }

        public double SubTotalIV
        {
            get => 
                this._varSubTotalIV;
            set => 
                this._varSubTotalIV = value;
        }

        public double SubTotalEx
        {
            get => 
                this._varSubTotalEx;
            set => 
                this._varSubTotalEx = value;
        }
    }
}

