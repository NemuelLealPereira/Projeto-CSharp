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
        private SqlConnection objConexaoSqlClient = null;

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
            objConexaoSqlClient = new SqlConnection(stringDeLaConnexion);

            //String de la connexion pour connectez avec le Base de donnés Sql Server
            //objConexaoSqlClient.ConnectionString = stringDeLaConnexion;

            try
            {
                // ouvert la connexion.
                objConexaoSqlClient.Open();

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
                objConexaoSqlClient.Close();
        }
        
        /// <summary>
        /// Il a inséré un donné dans le Base de données
        /// </summary>
        /// <param name="tableBD">table du Base de donnés</param>
        public void inserer(string tableBD, Cliente objCliente)
        {

            try
            {
                // Objet pour l'exécution d'une commande SQL.
                SqlCommand objComandoSQL = new SqlCommand();
                 
                objComandoSQL.CommandText = "INSERT INTO " + tableBD + " VALUES ('" + objCliente.Nome + "','" + objCliente.Email + "','" + objCliente.Contato1 + "','" + objCliente.Contato2 + "','" + objCliente.Contato3 + "')";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexaoSqlClient;

                objComandoSQL.ExecuteNonQuery();

                //// Il interprète le type de commande SQL.
                //objComandoSQL.CommandType = CommandType.Text;

                //// SQLConnection
                //objComandoSQL.Connection = objConexaoSqlClient;

                //// Objet créé pour lire les donné de base
                //SqlDataReader DR;

                //// Effectue la lecture de retourner un objet SqlDataReader
                //DR = objComandoSQL.ExecuteReader();

                //DR.Read();

                //txtContato.Text = DR.GetString(2);
                //txtTipoLogradouro.Text = DR.GetString(3);
                //textLogradouro.Text = DR.GetString(4);
            }
            catch (Exception) 
            {
                throw;
            }

        }
        
    }
}


