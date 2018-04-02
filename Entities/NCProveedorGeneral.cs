namespace Entidades
{
    using System;

    public class NCProveedorGeneral
    {
        private int _varIdNcg;
        private int _varIdProveedor;
        private int _varNumNC;
        private double _varTotal;
        private double _varIV;
        private string _varMotivo;
        private int _varBoleta;
        private DateTime _varFecha;
        private DateTime _varFechaBoleta;
        private double _varSubTotalIV;
        private double _varSubTotalEx;
        private bool _varPorDescuento;
        private ListaEstado _varEstado;

        public int IdNcg
        {
            get => 
                this._varIdNcg;
            set => 
                this._varIdNcg = value;
        }

        public int IdProveedor
        {
            get => 
                this._varIdProveedor;
            set => 
                this._varIdProveedor = value;
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

        public bool PorDescuento
        {
            get => 
                this._varPorDescuento;
            set => 
                this._varPorDescuento = value;
        }

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public enum ListaEstado
        {
            Pendiente,
            Aplicado,
            Anulado
        }
    }
}

