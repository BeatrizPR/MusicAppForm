using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
// para hacer conexión a bd
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class TrackDataAccess : DataAccessBase
    {
        public List<Track> GetDataTrack(int albumId)
        {
            var trackDataList = new List<Track>();

            SqlConnection connection = new SqlConnection(base.Connec);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                StringBuilder queryArtist = new StringBuilder();

                queryArtist.Append("   Select Name, Title, Track, TrackId from view_data   ");
                queryArtist.Append("   where AlbumId =  @albumtId  ");

                SqlCommand cmd = new SqlCommand(queryArtist.ToString(), connection);

                SqlParameter paramId = new SqlParameter("@albumId", albumId);
                cmd.Parameters.Add(paramId);

                cmd.Connection = connection;
                cmd.CommandText = queryArtist.ToString();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    trackDataList.Add(new Track()
                    {
                        ID = Convert.ToInt32(reader["Id"]),
                        TrackName = reader["TrackName"].ToString()
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

            return trackDataList;
        }

    }
}
