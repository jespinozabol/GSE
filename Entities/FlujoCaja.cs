namespace Entidades
{
    using System;

    public class FlujoCaja
    {
        private DateTime _varFecha;
        private double _varEfectivo;
        private double _varCheques;
        private double _varTransferencia;
        private double _varTarjeta;
        private double _varEquiDolaresColones;
        private double _varRedondeo;
        private double _varVales;
        private double _varCreditos;
        private double _varVuelto;

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public double Efectivo
        {
            get => 
                this._varEfectivo;
            set => 
                this._varEfectivo = value;
        }

        public double Cheques
        {
            get => 
                this._varCheques;
            set => 
                this._varCheques = value;
        }

        public double Transferencia
        {
            get => 
                this._varTransferencia;
            set => 
                this._varTransferencia = value;
        }

        public double Tarjeta
        {
            get => 
                this._varTarjeta;
            set => 
                this._varTarjeta = value;
        }

        public double DolaresColones
        {
            get => 
                this._varEquiDolaresColones;
            set => 
                this._varEquiDolaresColones = value;
        }

        public double Redondeo
        {
            get => 
                this._varRedondeo;
            set => 
                this._varRedondeo = value;
        }

        public double Vale
        {
            get => 
                this._varVales;
            set => 
                this._varVales = value;
        }

        public double Creditos
        {
            get => 
                this._varCreditos;
            set => 
                this._varCreditos = value;
        }

        public double Vuelto
        {
            get => 
                this._varVuelto;
            set => 
                this._varVuelto = value;
        }
    }
}

