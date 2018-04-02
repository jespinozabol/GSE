namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class FacturaProveedor
    {
        private int _varIdDocPagar;
        private int _varIdProveedor;
        private DateTime _varFecha;
        private string _varNumFactura;
        private double _varSubTotalIV;
        private double _varSubTotalEx;
        private double _varIV;
        private double _varTotal;
        private ListaEstado _varEstado;
        private DateTime _varFechaCancelacion;
        private DateTime _varFechaIngreso;
        private ListaMes _varMesTributo;
        private int _varDias;
        private string _varMotivo;
        private bool _varContado;
        private List<NCFacturaProveedor> _varListaNC;
        private List<NDFacturaProveedor> _varListaND;
        private List<AbonoFacturaProveedor> _varListaAbonos;
        private int _varAñoTributado;

        public FacturaProveedor()
        {
            this.ListaNC = new List<NCFacturaProveedor>();
            this.ListaND = new List<NDFacturaProveedor>();
            this.ListaAbonos = new List<AbonoFacturaProveedor>();
        }

        public int IdDocPagar
        {
            get => 
                this._varIdDocPagar;
            set => 
                this._varIdDocPagar = value;
        }

        public int IdProveedor
        {
            get => 
                this._varIdProveedor;
            set => 
                this._varIdProveedor = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public string NumFactura
        {
            get => 
                this._varNumFactura;
            set => 
                this._varNumFactura = value;
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

        public double IV
        {
            get => 
                this._varIV;
            set => 
                this._varIV = value;
        }

        public double Total
        {
            get => 
                this._varTotal;
            set => 
                this._varTotal = value;
        }

        public ListaEstado Estado
        {
            get => 
                this._varEstado;
            set => 
                this._varEstado = value;
        }

        public DateTime FechaCancelacion
        {
            get => 
                this._varFechaCancelacion;
            set => 
                this._varFechaCancelacion = value;
        }

        public DateTime FechaIngreso
        {
            get => 
                this._varFechaIngreso;
            set => 
                this._varFechaIngreso = value;
        }

        public ListaMes MesTributo
        {
            get => 
                this._varMesTributo;
            set => 
                this._varMesTributo = value;
        }

        public int Dias
        {
            get => 
                this._varDias;
            set => 
                this._varDias = value;
        }

        public string Motivo
        {
            get => 
                this._varMotivo;
            set => 
                this._varMotivo = value;
        }

        public bool Contado
        {
            get => 
                this._varContado;
            set => 
                this._varContado = value;
        }

        public List<NCFacturaProveedor> ListaNC
        {
            get => 
                this._varListaNC;
            set => 
                this._varListaNC = value;
        }

        public List<NDFacturaProveedor> ListaND
        {
            get => 
                this._varListaND;
            set => 
                this._varListaND = value;
        }

        public List<AbonoFacturaProveedor> ListaAbonos
        {
            get => 
                this._varListaAbonos;
            set => 
                this._varListaAbonos = value;
        }

        public int AñoTributado
        {
            get => 
                this._varAñoTributado;
            set => 
                this._varAñoTributado = value;
        }

        public enum ListaEstado
        {
            Pendiente,
            Cancelada,
            Anulada
        }

        public enum ListaMes
        {
            Enero,
            Febrero,
            Marzo,
            Abril,
            Mayo,
            Junio,
            Julio,
            Agosto,
            Septiembre,
            Octubre,
            Noviembre,
            Diciembre
        }
    }
}

