namespace Entidades
{
    using System;

    public class NotaCreditoGeneral
    {
        private int _varIdNC;
        private DateTime _varFecha;
        private int _varIdClienteCredito;
        private double _varMonto;
        private string _varMotivo;
        private double _varImpuesto;
        private ListaEstado _varEstado;

        public int IdNC
        {
            get => 
                this._varIdNC;
            set => 
                this._varIdNC = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public int IdClienteCredito
        {
            get => 
                this._varIdClienteCredito;
            set => 
                this._varIdClienteCredito = value;
        }

        public double Monto
        {
            get => 
                this._varMonto;
            set => 
                this._varMonto = value;
        }

        public string Motivo
        {
            get => 
                this._varMotivo;
            set => 
                this._varMotivo = value;
        }

        public double Impuesto
        {
            get => 
                this._varImpuesto;
            set => 
                this._varImpuesto = value;
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
            Aplicada,
            Anulada
        }
    }
}

