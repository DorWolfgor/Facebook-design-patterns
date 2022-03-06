using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FilteredAlbums
    {
        private FacebookObjectCollection<Photo> m_Photos = new FacebookObjectCollection<Photo>();
        private Func<Photo, bool> m_MethodFilterPhoto;
        private readonly ConnectedUser m_ConnectedUser;

        internal FilteredAlbums(Func<Photo, bool> i_MethodFilterPhotos, ConnectedUser i_LogedInUser)
        {
            m_MethodFilterPhoto = i_MethodFilterPhotos;
            m_ConnectedUser = i_LogedInUser;
        }

        internal FacebookObjectCollection<Photo> FilterAlbums()
        {
            m_Photos.Clear();
            FacebookObjectCollection<Album> albums = m_ConnectedUser.GetAlbums();
            foreach (Album album in albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (m_MethodFilterPhoto(photo))
                    {
                        m_Photos.Add(photo);
                    }
                }
            }
            return m_Photos;
        }

        public FacebookObjectCollection<Photo> GetPhotos()
        {
            return m_Photos;
        }


        public class FilterStats
        {
            public int FromYear { get; set; }

            public int ToYear { get; set; }

            public int MinComments { get; set; }

        }
    }
}
