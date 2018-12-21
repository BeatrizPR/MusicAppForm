using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class ArtistBusinessLogic
    {
        private ArtistDataAccess _artistDataAccess;


        public ArtistBusinessLogic()
        {
            _artistDataAccess = new ArtistDataAccess();
        }
        

        public Artist GetArtistInfo (int artistId)
        {
                                          // llamo al metodo de la base de datos
            Artist ArtistDataInfo = _artistDataAccess.getArtistName(artistId);

            return ArtistDataInfo;
        }

        public Artist GetArtistInfo(string artistName)
        {
            // llamo al metodo de la base de datos
            Artist ArtistDataInfo = _artistDataAccess.getArtistName(artistName);

            return ArtistDataInfo;
        }

    }
}
