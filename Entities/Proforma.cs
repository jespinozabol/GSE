namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class Proforma
    {
        private int _varNumProforma;
        private string _varNombreCliente;
        private DateTime _varFecha;
        private int _varIdReferencia;
        private string _varTelefono;
        private List<ProformaDetalle> _varProformaDetalles;

        public Proforma()
        {
            this.ProformaDetalles = new List<ProformaDetalle>();
        }

        public int NumProforma
        {
            get => 
                this._varNumProforma;
            set => 
                this._varNumProforma = value;
        }

        public string Cliente
        {
            get => 
                this._varNombreCliente;
            set => 
                this._varNombreCliente = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public int IdReferencia
        {
            get => 
                this._varIdReferencia;
            set => 
                this._varIdReferencia = value;
        }

        public string Telefono
        {
            get => 
                this._varTelefono;
            set => 
                this._varTelefono = value;
        }

        public List<ProformaDetalle> ProformaDetalles
        {
            get => 
                this._varProformaDetalles;
            set => 
                this._varProformaDetalles = value;
        }
    }
}

