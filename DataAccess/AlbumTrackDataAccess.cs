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
    public class AlbumTrackDataAccess : DataAccessBase
    {
        public List<Album> GetDataAlbum(int artistId)
        {
            // Declaro la lista de albumes
            var albumDataList = new List<Album>();

            //Album albumData = new Album();

            SqlConnection connection = new SqlConnection(base.Connec);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                StringBuilder queryArtist = new StringBuilder();

                queryArtist.Append("   Select distinct AlbumId, Title from view_data  ");
                queryArtist.Append(" where ArtistId = @artistId  ");

                SqlCommand cmd = new SqlCommand(queryArtist.ToString(), connection);

                SqlParameter paramId = new SqlParameter("@artistId", artistId);
                cmd.Parameters.Add(paramId);

                cmd.Connection = connection;
                cmd.CommandText = queryArtist.ToString();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    albumDataList.Add(new Album() {
                        ID = Convert.ToInt32(reader["AlbumId"]),
                        Title = reader["Title"].ToString()
                    });

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

            return albumDataList;
        }

    }
}
