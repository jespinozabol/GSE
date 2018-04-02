namespace Entidades
{
    using System;
    using System.Collections.Generic;

    public class Pedido
    {
        private int _varIdPedido;
        private DateTime _varFecha;
        private int _varIdProveedor;
        private string _varNombreProveedor;
        private bool _varModificado;
        private string _varTransporte;
        private List<Entidades.PedidoDetalle> _varPedidoDetalle;
        private List<Entidades.ImprimeDTOModel> _varImprimeDTOModel;

        public Pedido()
        {
            this.PedidoDetalle = new List<Entidades.PedidoDetalle>();
            this.ImprimeDTOModel = new List<Entidades.ImprimeDTOModel>();
        }

        public int IdPedido
        {
            get => 
                this._varIdPedido;
            set => 
                this._varIdPedido = value;
        }

        public DateTime Fecha
        {
            get => 
                this._varFecha;
            set => 
                this._varFecha = value;
        }

        public int IdProveedor
        {
            get => 
                this._varIdProveedor;
            set => 
                this._varIdProveedor = value;
        }

        public string NombreProveedor
        {
            get => 
                this._varNombreProveedor;
            set => 
                this._varNombreProveedor = value;
        }

        public bool Modificado
        {
            get => 
                this._varModificado;
            set => 
                this._varModificado = value;
        }

        public string Transporte
        {
            get => 
                this._varTransporte;
            set => 
                this._varTransporte = value;
        }

        public List<Entidades.PedidoDetalle> PedidoDetalle
        {
            get => 
                this._varPedidoDetalle;
            set => 
                this._varPedidoDetalle = value;
        }

        public List<Entidades.ImprimeDTOModel> ImprimeDTOModel
        {
            get => 
                this._varImprimeDTOModel;
            set => 
                this._varImprimeDTOModel = value;
        }
    }
}

