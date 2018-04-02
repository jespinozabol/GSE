namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class Listado
    {
        private int _varIdListado;
        private string _varNombreCliente;
        private string _varTelefono;
        private double _varTotalListado;
        private DateTime _varFecha;
        private DateTime _varFechaImpreso;
        private bool _varBloqueo;
        private List<ListadoAutorizado> _varListadoAutorizado;
        private List<ListadoResumen> _varListadoResumen;
        private List<ListadoHistorial> _varListaHistorial;

        public Listado()
        {
            this.ListaAutorizados = new List<ListadoAutorizado>();
            this.ListaResumen = new List<ListadoResumen>();
            this.ListaHistorial = new List<ListadoHistorial>();
        }

        public int IdListado
        {
            get => 
                this._varIdListado;
            set => 
                this._varIdListado = value;
        }

        public string NombreCliente
        {
            get => 
                this._varNombreCliente;
            set => 
                this._varNombreCliente = value;
        }

        public string Telefono
        {
            get => 
                this._varTelefono;
            set => 
                this._varTelefono = value;
        }

        public double TotalListado
        {
            get => 
                this._varTotalListado;
            set => 
                this._varTotalListado = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public DateTime NewProperty
        {
            get => 
                this._varFechaImpreso;
            set => 
                this._varFechaImpreso = value;
        }

        public bool Bloqueo
        {
            get => 
                this._varBloqueo;
            set => 
                this._varBloqueo = value;
        }

        public List<ListadoAutorizado> ListaAutorizados
        {
            get => 
                this._varListadoAutorizado;
            set => 
                this._varListadoAutorizado = value;
        }

        public List<ListadoResumen> ListaResumen
        {
            get => 
                this._varListadoResumen;
            set => 
                this._varListadoResumen = value;
        }

        public List<ListadoHistorial> ListaHistorial
        {
            get => 
                this._varListaHistorial;
            set => 
                this._varListaHistorial = value;
        }
    }
}

