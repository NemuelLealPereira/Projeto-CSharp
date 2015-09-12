using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MANIADESUSHI.GERENCIA.MODEL
{

    /// <summary>
    /// Define propriedade do cliente.
    /// </summary>
    public class Cliente
    {
        private string nome;
        private string email;
        private string contato1;
        private string contato2;
        private string contato3;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="nome">nome do cliente</param>
        /// <param name="email">email do cliente</param>
        /// <param name="contato1">contato principal do cliente</param>
        /// <param name="contato2">contato secundário do cliente</param>
        /// <param name="contato3">contato adicional do cliente</param>
        public Cliente(string nome, string email, string contato1, string contato2, string contato3)
        {
            this.nome = nome;
            this.email = email;
            this.contato1 = contato1;
            this.contato2 = contato2;
            this.contato3 = contato3;

        }

        public Cliente()
        {
            // TODO: Complete member initialization
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contato1
        {
            get { return contato1; }
            set { contato1 = value; }
        }

        public string Contato2
        {
            get { return contato2; }
            set { contato2 = value; }
        }

        public string Contato3
        {
            get { return contato3; }
            set { contato3 = value; }
        }

        
    }
}
