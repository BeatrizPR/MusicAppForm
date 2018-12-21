using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace BusinessLogic
{

    public class TrackBusinessLogic
    {

        private TrackDataAccess _TrackDataAccess;

        public TrackBusinessLogic()
        {
            _TrackDataAccess = new TrackDataAccess();
        }

        public List<Track> GetDataTrack(int albumId)
        {

            return _TrackDataAccess.GetDataTrack(albumId);


        }
    }
}
