using System;

namespace Servicio
{
    public class Banco
    {
        private Time tiempo;
        public Time time { get => tiempo; set => tiempo = value; }
        private string responsabilidad;
        public string disclaimer { get => responsabilidad; set => responsabilidad = value; }
        private string monedaCrypto;
        public string chartName { get => monedaCrypto; set => monedaCrypto = value; }
        private Bpi banco;
        public Bpi bpi { get => banco; set => banco = value; }
    }

    public class Time
    {
        private string Updated;
        private string UpdatedISO;
        private string UpdatedUK;
        public string updated { get => Updated; set => Updated = value; }
        public string updatedISO { get => UpdatedISO; set => UpdatedISO = value; }
        public string updateduk { get => UpdatedUK; set => UpdatedUK = value; }
    }

    public class Bpi
    {
        private Moneda dolar;
        private Moneda libra;
        private Moneda euro;
        public Moneda USD { get => dolar; set => dolar = value; }
        public Moneda GBP { get => libra; set => libra = value; }
        public Moneda EUR { get => euro; set => euro = value; }
    }

    public class Moneda
    {
        private string codigo;
        public string code { get => codigo; set => codigo = value; }
        private string simbolo;
        public string symbol { get => simbolo; set => simbolo = value; }
        private string valor;
        public string rate { get => valor; set => valor = value; }
        private string descripcion;
        public string description { get => descripcion; set => descripcion = value; }
        private float valorFloat;
        public float rate_float { get => valorFloat; set => valorFloat = value; }
    }
}