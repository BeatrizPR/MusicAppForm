using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Entities;
using BusinessLogic;

namespace AplicacionMusica
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtBoxId.TextLength >= 1)
            {
                ShowDataId();
                ShowDataAlbum();
            }
            if (txtBoxNombre.TextLength >= 1)
            {
                ShowDataName();
                ShowDataAlbum();
            }
            
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {
            EnableText();
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {
            EnableText();
        }

        private void radioBtnId_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxId.Enabled = true;
        }

        private void radioBtnNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxNombre.Enabled = true;
        }

        private void desplegableAlbum_SelectedValueChanged(object sender, EventArgs e)
        {
            //ShowDataTrack();
        }

        #endregion Events

        private void EnableText()
        {
           if(radioBtnId.Checked == true)
            {
                txtBoxNombre.Enabled = false;
            } else if (radioBtnNombre.Enabled == true)
            {
                txtBoxId.Enabled = false;
            }
        }

        private void ShowDataId()
        {
            
            try
            {
                int artistID = Convert.ToInt32(txtBoxId.Text);
                //string artistNAME = txtBoxNombre.Text;

                ArtistBusinessLogic artistBL = new ArtistBusinessLogic();

                Artist artistsDetails = artistBL.GetArtistInfo(artistID);

                //txtBoxId = artistsDetails.ID;
                txtBoxNombre.Text = artistsDetails.Name;
                 
            }
            catch
            {
                throw;
            }
            
            
        }


        private void ShowDataName()
        {
            try
            {
                string artistNAME = txtBoxNombre.Text;
                ArtistBusinessLogic artistBL = new ArtistBusinessLogic();

                Artist artistsDetails = artistBL.GetArtistInfo(artistNAME);

                txtBoxId.Text = artistsDetails.ID.ToString();
                txtBoxNombre.Text = artistsDetails.Name;
            }
            catch
            {
                throw;
            }
        }

        private void ShowDataAlbum()
        {
            try
            {
                int artistID = Convert.ToInt32(txtBoxId.Text);
                AlbumTrackBusinessLogic albumBL = new AlbumTrackBusinessLogic();

                List<Album> albumDataL = new List<Album>();
                albumDataL = albumBL.GetDataAlbum(artistID);

                desplegableAlbum.DataSource = albumDataL;
                desplegableAlbum.DisplayMember = "Title";
                desplegableAlbum.ValueMember = "ID";


            }
            catch 
            {
                throw;
            }
        }

        private void ShowDataTrack()
        {
            try
            {
                //int artistID = Convert.ToInt32(txtBoxId.Text);
                int albumID = Convert.ToInt32(desplegableAlbum.ValueMember);
                TrackBusinessLogic trackBL = new TrackBusinessLogic();

                List<Track> trackDataBL = new List<Track>();
                trackDataBL = trackBL.GetDataTrack(albumID);

                desplegableAlbum.DataSource = trackDataBL;

                
                //desplegableAlbum.DisplayMember = "Title";
                //desplegableAlbum.ValueMember = "ID";


            }
            catch
            {
                throw;
            }
        }

       
    }
}
