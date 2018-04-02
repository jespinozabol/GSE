namespace Entidades
{
    using System;

    public class Tipo_Credito
    {
        private string varTipo;
        private int varDias;
        private double varLimite;
        private int varDiasAtraso;

        public string Tipo
        {
            get => 
                this.varTipo;
            set => 
                this.varTipo = value;
        }

        public int Dias
        {
            get => 
                this.varDias;
            set => 
                this.varDias = value;
        }

        public double Limite
        {
            get => 
                this.varLimite;
            set => 
                this.varLimite = value;
        }

        public int DiasAtraso
        {
            get => 
                this.varDiasAtraso;
            set => 
                this.varDiasAtraso = value;
        }
    }
}

