using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;
using BasicFacebookFeatures.COF;

namespace BasicFacebookFeatures
{
    public partial class FormAlbums : Form
    {
        private readonly ConnectedUser m_ConnectedUser;
        private int m_PictureNum;

        public FormAlbums(ConnectedUser i_LoggedInUser)
        {
            InitializeComponent();
            m_ConnectedUser = i_LoggedInUser;
            m_PictureNum = 0;
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            albumBindingSource.DataSource = m_ConnectedUser.m_User.Albums;
        }
     
        private void nextImage_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
           
            if(selectedAlbum.Photos.Count == 0)
            {
                MessageBox.Show("No Photos to see");
                return;
            }

            m_PictureNum++;
            if (m_PictureNum == selectedAlbum.Photos.Count)
            {
                m_PictureNum = 0;
            }
           
            Photo photo = selectedAlbum.Photos[m_PictureNum];
            pictureAlbumURLPictureBox.LoadAsync(photo.PictureAlbumURL);
            textBoxDescription.Text = photo.Message;
        }

        private void previousImage_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            
            if (selectedAlbum.Photos.Count == 0)
            {
                MessageBox.Show("No Photos to see");
                return;
            }

            m_PictureNum--;
            if (m_PictureNum == -1)
            {
                m_PictureNum += selectedAlbum.Photos.Count;
            }
       
            Photo photo = selectedAlbum.Photos[m_PictureNum];
            pictureAlbumURLPictureBox.LoadAsync(photo.PictureAlbumURL);
            textBoxDescription.Text = photo.Message;
        }

        private void ButtonDescription_Click(object sender, EventArgs e)
        {
           if(pictureAlbumURLPictureBox.Image == pictureAlbumURLPictureBox.ErrorImage)
           {
                MessageBox.Show("No image found");
                return;
           }

            string textToSet = textBoxDescription.Text;
            ChangeDescriptionManager changeDescription =
                new ChangeDescriptionManager(textToSet);

            bool isOk = changeDescription.Run();
            if(!isOk)
            {
                string message = "CANT CHANGE THE DESCRIPTION!" + Environment.NewLine;
                message += changeDescription.Message;
                MessageBox.Show(message);
            }
            else
            {
                if (textBoxDescription.Text != "")
                {
                    changePhotoDescription();
                    MessageBox.Show("Changed description succefully");
                }
            }
        }

        private void changePhotoDescription()
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            Photo photo = selectedAlbum.Photos[m_PictureNum];
            photo.Message = textBoxDescription.Text;
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

            if (selectedAlbum.Photos.Count != 0)
            {
                m_PictureNum = 0;
                pictureAlbumURLPictureBox.LoadAsync(selectedAlbum.Photos[m_PictureNum].PictureAlbumURL);
                textBoxDescription.Text = selectedAlbum.Photos[m_PictureNum].Message;
                nextImage.Visible = true;
                previousImage.Visible = true;
            }
            else
            {
                textBoxDescription.Text = string.Empty;
                pictureAlbumURLPictureBox.Image = pictureAlbumURLPictureBox.ErrorImage;
            }
        }
    }
}