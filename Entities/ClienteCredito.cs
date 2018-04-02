namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class ClienteCredito : Persona
    {
        private int _varIdCredito;
        private double _varLimite;
        private ListaEstado _varEstado;
        private ListaTipo _varTipo;
        private double _varTotalCreditos;
        private bool _varEnteFisico;
        private int _varDiasAtrasado;
        private double _varTotalAtrasado;
        private string _varNombreReal;
        private DateTime _varFechaCreacion;
        private List<Bitacora> _varListaBitacoras;
        private bool varBloqueo;
        private bool varIncluirEnCobro;
        private List<EncargadoClienteCredito> _varEncargados;

        public ClienteCredito()
        {
            this.ListaBitacora = new List<Bitacora>();
        }

        public int IdCredito
        {
            get => 
                this._varIdCredito;
            set => 
                this._varIdCredito = value;
        }

        public double Limite
        {
            get => 
                this._varLimite;
            set => 
               this._varLimite = value;
        }

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public ListaTipo Tipo
        {
            get => 
                this._varTipo;
            set => 
                this._varTipo = value;
        }

        public double TotalCreditos
        {
            get => 
                this._varTotalCreditos;
            set => 
                this._varTotalCreditos = value;
        }

        public bool EnteFisico
        {
            get => 
                this._varEnteFisico;
            set => 
                this._varEnteFisico = value;
        }

        public int DiasAtrasado
        {
            get => 
                this._varDiasAtrasado;
            set => 
                this._varDiasAtrasado = value;
        }

        public double TotalAtrasado
        {
            get => 
                this._varTotalAtrasado;
            set => 
                this._varTotalAtrasado = value;
        }

        public string NombreReal
        {
            get => 
                this._varNombreReal;
            set => 
                this._varNombreReal = value;
        }

        public DateTime FechaCreacion
        {
            get => 
                this._varFechaCreacion;
            set => 
                this._varFechaCreacion = value;
        }

        public List<Bitacora> ListaBitacora
        {
            get => 
                this._varListaBitacoras;
            set => 
                this._varListaBitacoras = value;
        }

        public bool Bloqueo
        {
            get => 
                this.varBloqueo;
            set => 
                this.varBloqueo = value;
        }

        public bool IncluirEnCobro
        {
            get => 
                this.varIncluirEnCobro;
            set => 
                this.varIncluirEnCobro = value;
        }

        public List<EncargadoClienteCredito> Encargados
        {
            get => 
                this._varEncargados;
            set => 
                this._varEncargados = value;
        }

        public enum ListaEstado
        {
            Cerrado,
            Abierto,
            Congelado
        }

        public enum ListaTipo
        {
            Preferencial = 1,
            Normal = 2,
            Prueba = 3
        }
    }
}

