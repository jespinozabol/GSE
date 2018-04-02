namespace Entidades
{
    using System;

    public class Vale
    {
        private int varNum_Vale;
        private DateTime varFecha;
        private string varHora;
        private double varMonto;
        private int varSolicitante;
        private int varAutorizado;
        private string varObservaciones;

        public int Num_Vale
        {
            get => 
                this.varNum_Vale;
            set => 
                this.varNum_Vale = value;
        }

        public DateTime Fecha
        {
            get => 
                this.varFecha;
            set => 
                this.varFecha = value;
        }

        public string Hora
        {
            get => 
                this.varHora;
            set => 
                this.varHora = value;
        }

        public double Monto
        {
            get => 
                this.varMonto;
            set => 
                this.varMonto = value;
        }

        public int Solicitante
        {
            get => 
                this.varSolicitante;
            set => 
                this.varSolicitante = value;
        }

        public int Autorizado
        {
            get => 
                this.varAutorizado;
            set => 
                this.varAutorizado = value;
        }

        public string Observaciones
        {
            get => 
                this.varObservaciones;
            set => 
                this.varObservaciones = value;
        }
    }
}

