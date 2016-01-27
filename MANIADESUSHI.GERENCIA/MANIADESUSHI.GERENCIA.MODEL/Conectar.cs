using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MANIADESUSHI.GERENCIA.MODEL
{
    /// <summary>
    /// Connexion avec donnés de base
    /// </summary>
    public class LaConnexion
    {

        /// <summary>
        /// String de la Connexion
        /// </summary>
        private string stringDeLaConnexion;

        /// <summary>
        /// objet pour la connexion
        /// </summary>
        private SqlConnection objConexao = null;

        /// <summary>
        /// Connexion avec donnés de base
        /// </summary>
        /// <param name="stringDeLaConnexion">String de la Connexion </param>
        public LaConnexion(string stringDeLaConnexion)
        {
            this.stringDeLaConnexion = stringDeLaConnexion;
        }

        /// <summary>
        /// Conectez avec le Base de données Sql Server
        /// </summary>
        /// <param name="stringDeLaConnexion">String de la connexion</param>
        public void ouvertConnexion()
        {
            // objet pour la connexion avec le Base de données Sql Server
            objConexao = new SqlConnection(stringDeLaConnexion);

            //String de la connexion pour connectez avec le Base de donnés Sql Server
            //objConexaoSqlClient.ConnectionString = stringDeLaConnexion;

            try
            {
                // ouvert la connexion.
                objConexao.Open();

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Fermer la Connexion
        /// </summary>
        public void fermerLaConnexion()
        {
            objConexao.Close();
        }

        /// <summary>
        /// Il a inséré un donné de client dans le Base de données
        /// </summary>
        /// <param name="tableBD">table du Base de donnés</param>
        public void insererClient(string tableBD, Cliente objCliente)
        {

            try
            {
                // Objet pour l'exécution d'une commande SQL.
                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "INSERT INTO " + tableBD + " VALUES ('" + objCliente.Nome + "','" + objCliente.Email + "','" + objCliente.Contato1 + "','" + objCliente.Contato2 + "','" + objCliente.Contato3 + "')";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                objComandoSQL.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }

        }



        public int retounerCodeClient(string tableBD, Cliente objCliente)
        {
            try
            {
                SqlCommand objComandoSQL = new SqlCommand();

                int code;

                objComandoSQL.CommandText = "SELECT cli_id FROM " + tableBD + " WHERE cli_email = '" + objCliente.Email + "'";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                //// Objet créé pour lire les donné de base
                SqlDataReader DR;

                // Effectue la lecture de retourner un objet SqlDataReader
                DR = objComandoSQL.ExecuteReader();
                DR.Read();
                code = DR.GetInt32(0);

                //DR.Close();
                
                return code;

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Il a inséré un donné du Adresse du client dans le Base de données
        /// </summary>
        /// <param name="tableBD">table du Base de donnés</param>
        public void insererLogradouro(string tableBD, Adresse objAdresse)
        {

            try
            {
                // Objet pour l'exécution d'une commande SQL.
                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "INSERT INTO " + tableBD + " VALUES ('" + objAdresse.Cep + "','" + objAdresse.UF + "','" + objAdresse.Cidade + "','" + objAdresse.TipoLogradouro + "','" + objAdresse.Logradouro + "','" + objAdresse.Bairro + "')";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                objComandoSQL.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }

        }


        public int retounerCodeLogradouro(string tableBD, Adresse objAdresse)
        {
            try
            {
                SqlCommand objComandoSQL = new SqlCommand();

                int code;

                objComandoSQL.CommandText = "SELECT log_id FROM " + tableBD + " WHERE tb_frete_fre_bairro = '" + objAdresse.Bairro + "'";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                //// Objet créé pour lire les donné de base
                SqlDataReader DR;

                // Effectue la lecture de retourner un objet SqlDataReader
                DR = objComandoSQL.ExecuteReader();

                DR.Read();

                code = DR.GetInt32(0);

                DR.Close();

                return code;

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void insererAdresse(string tableBD, Adresse objAdresse, int codeLogradouro)
        {
            try
            {
                // Objet pour l'exécution d'une commande SQL.
                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "INSERT INTO " + tableBD + " VALUES ('" + objAdresse.Numero + "','" + objAdresse.Complemento + "'," + objAdresse.CodeClient + "," + codeLogradouro + ")";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                objComandoSQL.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<string> returnerLogradouro(string tableBD, string cep)
        {
            try
            {
                List<string> registerLogradouro = new List<string>();

                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "SELECT log_cep, log_uf, log_cidade, log_tipo_logradouro, log_logradouro, tb_frete_fre_bairro FROM " + tableBD + " WHERE log_cep = '" + cep + "'";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                //// Objet créé pour lire les donné de base. Il ne besoin pas de faire la instaciation
                SqlDataReader DR;

                // Effectue la lecture de retourner un objet SqlDataReader
                DR = objComandoSQL.ExecuteReader();

                // faire la lecture du première register et aprés saut pour la prochaine ligne.


                if (DR.Read())
                {
                    registerLogradouro.Add(DR.GetString(0));
                    registerLogradouro.Add(DR.GetString(1));
                    registerLogradouro.Add(DR.GetString(2));
                    registerLogradouro.Add(DR.GetString(3));
                    registerLogradouro.Add(DR.GetString(4));
                    registerLogradouro.Add(DR.GetString(5));
                }


                DR.Close();

                return registerLogradouro;
                

            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable selectionnerTable(string tableBD)
        {
            try
            {

                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "SELECT * FROM " + tableBD;

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                //// Objet créé pour lire les donné de base. Il ne besoin pas de faire la instaciation
                DataTable dt = new DataTable();
                SqlDataReader DR;

                // Effectue la lecture de retourner un objet SqlDataReader
                DR = objComandoSQL.ExecuteReader();
                //DR.Read();
                // faire la lecture du première register et aprés saut pour la prochaine ligne.

                

                dt.Load(DR);

                DR.Close();

                return dt;

                
        
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}