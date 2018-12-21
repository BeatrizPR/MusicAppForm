using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace DataAccess
{
    public class ArtistDataAccess : DataAccessBase
    {

        
        public Artist getArtistName(int artistId)
        {
            Artist artistData = new Artist();

            SqlConnection connection = new SqlConnection(base.Connec);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                StringBuilder queryArtist = new StringBuilder();

                queryArtist.Append("   Select ArtistId, Name from view_data   ");
                queryArtist.Append(" where ArtistId = @artistId  ");

                SqlCommand cmd = new SqlCommand(queryArtist.ToString(), connection);

                SqlParameter paramId = new SqlParameter("@artistId", artistId);
                cmd.Parameters.Add(paramId);

                cmd.Connection = connection;
                cmd.CommandText = queryArtist.ToString();

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    artistData.ID = Convert.ToInt32(reader["ArtistId"]);
                    artistData.Name = reader["Name"].ToString();
                }



            }
            catch
            {
                throw;
            }
            finally{
                if(connection != null)
                {
                    connection.Close();
                }
            }

            return artistData;
        }

        public Artist getArtistName(string artistName)
        {
            Artist artisData = new Artist();

            SqlConnection connection = new SqlConnection(base.Connec);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                StringBuilder queryArtist = new StringBuilder();

                queryArtist.Append("   Select Name, ArtistId from view_data   ");
                queryArtist.Append("   where Name = @artistName  ");
                SqlCommand cmd = new SqlCommand(queryArtist.ToString(), connection);

                SqlParameter paramName = new SqlParameter("@artistName", artistName);
                cmd.Parameters.Add(paramName);
                cmd.Connection = connection;
                cmd.CommandText = queryArtist.ToString();

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    artisData.ID = Convert.ToInt32(reader["ArtistId"]);
                    artisData.Name = reader["Name"].ToString();
                }

            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return artisData;
        }













    }
}
