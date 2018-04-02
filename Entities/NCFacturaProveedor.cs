namespace Entidades
{
    using System;

    public class NCFacturaProveedor
    {
        private int varIdNC;
        private int _varIdDocPorPagar;
        private int _varNumNC;
        private double _varTotal;
        private double _varIV;
        private string _varMotivo;
        private int _varBoletaDev;
        private DateTime _varFecha;
        private DateTime _varFechaBoleta;
        private double _varSubTotalIV;
        private double _varSubTotalEx;
        private bool _varPorDescuento;

        public int IdNC
        {
            get => 
                this.varIdNC;
            set => 
                this.varIdNC = value;
        }

        public int IdDocPorPagar
        {
            get => 
                this._varIdDocPorPagar;
            set => 
                this._varIdDocPorPagar = value;
        }

        public int NumNC
        {
            get => 
                this._varNumNC;
            set => 
                this._varNumNC = value;
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

        public int BoletaDev
        {
            get => 
                this._varBoletaDev;
            set => 
                this._varBoletaDev = value;
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

        public bool PorDescuento
        {
            get => 
                this._varPorDescuento;
            set => 
                this._varPorDescuento = value;
        }
    }
}

