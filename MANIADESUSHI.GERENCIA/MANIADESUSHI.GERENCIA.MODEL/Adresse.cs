using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MANIADESUSHI.GERENCIA.MODEL
{
    public class Adresse
    {
        private string cep;
        private object cidade;
        private object uf;
        private string bairro;
        private string tipoLogradouro;
        private string logradouro;
        private string numero;
        private string complemento;

        public Adresse(string cep, object cidade, object uf, string bairro, string tipoLogradouro, string logradouro, string numero, string complemento)
        {
            this.cep = cep;
            this.cidade = cidade;
            this.uf = uf;
            this.bairro = bairro;
            this.tipoLogradouro = tipoLogradouro;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
        }
        
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public object Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public object UF 
        { 
            get { return uf; } 
            set { uf = value; } 
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string TipoLogradouro
        {
            get { return tipoLogradouro; }
            set { tipoLogradouro = value; }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public string Numero
        { 
            get { return numero; }
            set { numero = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        

        
    }
}
