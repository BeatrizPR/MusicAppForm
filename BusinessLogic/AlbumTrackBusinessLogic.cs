using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace BusinessLogic
{
    public class AlbumTrackBusinessLogic
    {

        private AlbumTrackDataAccess _albumDataAccess;

        public AlbumTrackBusinessLogic() 
        {
            _albumDataAccess = new AlbumTrackDataAccess();

        }


         public List<Album> GetDataAlbum(int artistId)
         {
            
            return _albumDataAccess.GetDataAlbum(artistId);


         }




    }
}
