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
        public bool insererClient(string tableBD, Cliente objCliente)
        {

            try
            {
                
                // Objet pour l'exécution d'une commande SQL.
                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "SELECT cli_id FROM " + tableBD + " WHERE cli_email = '" + objCliente.Email + "'";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                int codClient = Convert.ToInt32( objComandoSQL.ExecuteScalar());

                if (codClient.Equals(0))
                {

                    objComandoSQL.CommandText = "INSERT INTO " + tableBD + " VALUES ( @cli_nome , @cli_email , @cli_contato1 , @cli_contato2 , @cli_contato3 )";

                    objComandoSQL.Parameters.Clear();

                    objComandoSQL.Parameters.Add(new SqlParameter("@cli_nome", objCliente.Nome));
                    objComandoSQL.Parameters.Add(new SqlParameter("@cli_email", objCliente.Email));
                    objComandoSQL.Parameters.Add(new SqlParameter("@cli_contato1", objCliente.Contato1));
                    objComandoSQL.Parameters.Add(new SqlParameter("@cli_contato2", objCliente.Contato2));
                    objComandoSQL.Parameters.Add(new SqlParameter("@cli_contato3", objCliente.Contato3));

                    objComandoSQL.CommandType = CommandType.Text;

                    objComandoSQL.Connection = objConexao;

                    objComandoSQL.ExecuteNonQuery();

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        
        /// <summary>
        /// Il retourne le code du client Courant
        /// </summary>
        /// <param name="tableBD">table client</param>
        /// <param name="objCliente">object client</param>
        /// <returns></returns>
        public int retounerCodeClient(string tableBD, Cliente objCliente)
        {
            try
            {
                SqlCommand objComandoSQL = new SqlCommand();

                //int code;

                objComandoSQL.CommandText = "SELECT cli_id FROM " + tableBD + " WHERE cli_email = '" + objCliente.Email + "'";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                //// Objet créé pour lire les donné de base
                //SqlDataReader DR;

                // Effectue la lecture de retourner un objet SqlDataReader
                //DR = objComandoSQL.ExecuteReader();
                //DR.Read();
                //code = DR.GetInt32(0);

                //DR.Close();
                
                return Convert.ToInt32( objComandoSQL.ExecuteScalar());

            }
            catch (Exception)
            {

                throw;
            }
        }
        
        /// <summary>
        /// Il enregistre le logradouro du client courant dans le Base de données
        /// </summary>
        /// <param name="tableBD">table du Base de donnés</param>
        public void insererLogradouro(string tableBD, Adresse objAdresse)
        {
            
            try
            {
                // Objet pour l'exécution d'une commande SQL.
                SqlCommand objComandoSQL = new SqlCommand();
                
                objComandoSQL.CommandText = "INSERT INTO " + tableBD + " VALUES ( @log_cep , @log_uf , @log_cidade , @log_tipo_logradouro , @log_logradouro , @tb_frete_fre_bairro )";
              
                objComandoSQL.Parameters.Clear();

                objComandoSQL.Parameters.Add(new SqlParameter("@log_cep", objAdresse.Cep));
                objComandoSQL.Parameters.Add(new SqlParameter("@log_uf", objAdresse.UF));
                objComandoSQL.Parameters.Add(new SqlParameter("@log_cidade", objAdresse.Cidade));
                objComandoSQL.Parameters.Add(new SqlParameter("@log_tipo_logradouro", objAdresse.TipoLogradouro));
                objComandoSQL.Parameters.Add(new SqlParameter("@log_logradouro", objAdresse.Logradouro));
                objComandoSQL.Parameters.Add(new SqlParameter("@tb_frete_fre_bairro", objAdresse.Bairro));

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                objComandoSQL.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Il retourne le code du logradouro du client Courant
        /// </summary>
        /// <param name="tableBD">table logradouro</param>
        /// <param name="objAdresse">Object Adresse</param>
        /// <returns></returns>
        public int retounerCodeLogradouro(string tableBD, Adresse objAdresse)
        {
            try
            {
                SqlCommand objComandoSQL = new SqlCommand();

                //int code;

                objComandoSQL.CommandText = "SELECT log_id FROM " + tableBD + " WHERE tb_frete_fre_bairro = '" + objAdresse.Bairro + "'";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                //// Objet créé pour lire les donné de base
                //SqlDataReader DR;

                // Effectue la lecture de retourner un objet SqlDataReader
                //DR = objComandoSQL.ExecuteReader();

                //DR.Read();

                //code = DR.GetInt32(0);

                //DR.Close();

                return Convert.ToInt32(objComandoSQL.ExecuteScalar());

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Il enregistre le Adresse du client courant dans le Base de données
        /// </summary>
        /// <param name="tableBD">table du Base de donnés</param>
        /// <param name="objAdresse">Adresse complet du client courant</param>
        /// <param name="codeLogradouro">code du logradouro du client courant</param>
        public void insererAdresse(string tableBD, Adresse objAdresse, int codeLogradouro)
        {
            try
            {
                // Objet pour l'exécution d'une commande SQL.
                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "INSERT INTO " + tableBD + " VALUES ( @end_numero , @end_complemento , @tb_cliente_cli_id , @tb_logradouro_log_id)";

                objComandoSQL.Parameters.Clear();

                objComandoSQL.Parameters.Add(new SqlParameter("@end_numero", objAdresse.Numero));
                objComandoSQL.Parameters.Add(new SqlParameter("@end_complemento", objAdresse.Complemento));
                objComandoSQL.Parameters.Add(new SqlParameter("@tb_cliente_cli_id", objAdresse.CodeClient));
                objComandoSQL.Parameters.Add(new SqlParameter("@tb_logradouro_log_id", codeLogradouro));

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                objComandoSQL.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Il retourne une liste avec les reingsenement de un registre de la table logradouro
        /// </summary>
        /// <param name="tableBD"></param>
        /// <param name="cep"></param>
        /// <returns></returns>
        public List<string> returnerLogradouro(string tableBD, string cep)
        {
            try
            {
                List<string> registerLogradouro = new List<string>();

                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "SELECT * FROM " + tableBD + " WHERE log_cep = '" + cep + "'";

                objComandoSQL.CommandType = CommandType.Text;

                objComandoSQL.Connection = objConexao;

                //// Objet créé pour lire les donné de base. Il ne besoin pas de faire la instaciation
                SqlDataReader DR;

                // Effectue la lecture de retourner un objet SqlDataReader
                DR = objComandoSQL.ExecuteReader();

                // faire la lecture du première register et aprés saut pour la prochaine ligne.


                if (DR.Read())
                {
                    registerLogradouro.Add(Convert.ToString(DR.GetInt32(0)));
                    registerLogradouro.Add(DR.GetString(1));
                    registerLogradouro.Add(DR.GetString(2));
                    registerLogradouro.Add(DR.GetString(3));
                    registerLogradouro.Add(DR.GetString(4));
                    registerLogradouro.Add(DR.GetString(5));
                    registerLogradouro.Add(DR.GetString(6));
                }


                DR.Close();

                return registerLogradouro;
                

            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Il Selectionne la table qu'est passé par paramètre.
        /// </summary>
        /// <param name="tableBD"> table </param>
        /// <returns>Data Table de la table qu'est passé par paramètre</returns>
        public DataTable selectionnerTable(string tableBD)
        {
            try
            {

                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "SELECT cli_id Código, cli_nome Nome, cli_email 'E-mail', cli_contato1 Contato, cli_contato3 Contato, cli_contato3 Contato FROM " + tableBD;

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



        public DataTable retournerAdresseComplet(string codClient)
        {
            try
            {
                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "SELECT LOGR.log_cep Cep, LOGR.log_uf UF, LOGR.log_cidade Cidade, LOGR.log_tipo_logradouro 'Tipo Logradouro', LOGR.log_logradouro Logradouro, LOGR.tb_frete_fre_bairro Bairro, ENDER.end_numero Numero, ENDER.end_complemento Complemento " +
                                            "FROM tb_logradouro LOGR " +
                                            "JOIN tb_endereco ENDER ON ENDER.tb_logradouro_log_id = LOGR.log_id " + 
                                                "WHERE ENDER.tb_cliente_cli_id =" + codClient;

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

        public DataTable produit()
        {
            try 
            {	        

                SqlCommand objComandoSQL = new SqlCommand();

                objComandoSQL.CommandText = "SELECT TP.tpro_nome Produto, SP.spro_nome 'Cod - Sabor', SP.spro_descricao Descrição, VP.vpro_tam_qtde Tamanho, VP.vpro_valor Valor " +
                                            "FROM tb_tipo_produto as TP , tb_sabor_produto as SP, tb_valor_produto as VP " +
                                            "WHERE TP.tpro_id = SP.tb_tipo_produto_tpro_id " +
                                            "AND SP.spro_id = VP.tb_sabor_produto_pro_id";
                
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