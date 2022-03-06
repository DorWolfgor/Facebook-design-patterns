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

namespace BasicFacebookFeatures
{
    public partial class FormActivity : Form
    {
        private readonly ConnectedUser m_ConnectedUser;
        private FilteredAlbums m_FilteredPhotos { get; set; }
        private FilteredAlbums.FilterStats m_FilterStats = new FilteredAlbums.FilterStats();
        private int m_PictureNum;

        public FormActivity(ConnectedUser i_LoggedInUser)
        {
            m_ConnectedUser = i_LoggedInUser;
            InitializeComponent();
            initialOptions();
        }

        private void initialOptions()
        {
            for (int i = 2000; i <= 2021; i++)
            {
                startYear.Items.Add(i.ToString());
            }
            for (int i = 0; i <= 20; i++)
            {
                comboBoxComments.Items.Add(i.ToString());
            }
            endYear.Enabled = false;
            comboBoxComments.Enabled = false;
            comboBoxComments.Visible = false;
            filterByComments.Visible = false;
            commentsLabel.Visible = false;
        }

        private void startYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            endYear.Items.Clear();
            for (int i = Int32.Parse(startYear.SelectedItem.ToString()); i <= 2021; i++)
            {
                endYear.Items.Add(i.ToString());
            }
            endYear.Enabled = true;
        }

        private bool noOptionChooesed()
        {
            return !(picturesByYear.Checked || postsByYear.Checked);
        }

        private bool noFilterChoosed()
        {
            return !(filterByYear.Checked || filterByComments.Checked);
        }

        private void startYearActivity_Click(object sender, EventArgs e)
        {
            if (startYearActivity.Text == "Start")
            {
                if (noOptionChooesed())
                {
                    MessageBox.Show("You need to select at least one option of pictures or posts.");
                }
                else
                {
                    if (noFilterChoosed())
                    {
                        MessageBox.Show("You need to select at least one filter.");
                    }
                    else
                    {
                        if ((endYear.SelectedItem == null || Int32.Parse(startYear.SelectedItem.ToString()) > Int32.Parse(endYear.SelectedItem.ToString())) && filterByYear.Checked)
                        {
                            MessageBox.Show("start year need to be equal or smaller than end year");
                        }
                        else
                        {
                            if (comboBoxComments.SelectedItem == null && filterByComments.Checked)
                            {
                                MessageBox.Show("Please select number of minimum comments");
                            }
                            else
                            {
                                pushStartButton();
                            }
                        }
                    }

                }
            }
            else
            {
                pushBackButton();
            }
        }

        private void initialStats()
        {
            if (filterByYear.Checked)
            {
                m_FilterStats.FromYear = Int32.Parse(startYear.SelectedItem.ToString());
                m_FilterStats.ToYear = Int32.Parse(endYear.SelectedItem.ToString());
            }
            if (filterByComments.Checked)
            {
                m_FilterStats.MinComments = Int32.Parse(comboBoxComments.SelectedItem.ToString());
            }
        }

        private void pushStartButton()
        {
            initialStats();
            startYearActivity.Text = "Back";
            startYear.Enabled = false;
            endYear.Enabled = false;
            picturesByYear.Enabled = false;
            postsByYear.Enabled = false;
            comboBoxComments.Enabled = false;
            filterByComments.Enabled = false;
            filterByYear.Enabled = false;
            if (picturesByYear.Checked == true)
            {
                showFilteredPics();
            }
            if (postsByYear.Checked == true)
            {
                showFilteredPosts();
            }
        }

        private void pushBackButton()
        {
            startYearActivity.Text = "Start";
            startYear.Enabled = true;
            picturesByYear.Enabled = true;
            postsByYear.Enabled = true;
            comboBoxComments.Enabled = true;
            filterByComments.Enabled = true;
            filterByYear.Enabled = true;
            if (picturesByYear.Checked == true)
            {
                nextImage.Visible = false;
                previousImage.Visible = false;
                pictureBoxAlbum.Visible = false;
            }
            if (postsByYear.Checked == true)
            {
                listBoxPosts.Visible = false;
            }
        }

        private void showFilteredPosts()
        {
            listBoxPosts.Items.Clear();
            FacebookObjectCollection<Post> posts = m_ConnectedUser.GetPosts();
            foreach (Post post in posts)
            {
                if (post.CreatedTime.Value.Year >= Int32.Parse(startYear.SelectedItem.ToString()) &&
                    post.CreatedTime.Value.Year <= Int32.Parse(endYear.SelectedItem.ToString()))
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }
            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                listBoxPosts.Visible = true;
            }
        }


        private bool filterPhotoByYear(Photo photo)
        {
            return photo.CreatedTime.Value.Year >= m_FilterStats.FromYear &&
                        photo.CreatedTime.Value.Year <= m_FilterStats.ToYear;
        }

        private bool filterPhotoByMinComments(Photo photo)
        {
            return photo.Comments.Count >= m_FilterStats.MinComments;
        }

        private void showFilteredPics()
        {
            if (filterByComments.Checked && filterByYear.Checked)
            {
                m_FilteredPhotos = new FilteredAlbums((photo) =>
                {
                    return filterPhotoByMinComments(photo) &&
                    filterPhotoByYear(photo);
                }, m_ConnectedUser);
            }
            else
            {
                if (filterByComments.Checked)
                {
                    m_FilteredPhotos = new FilteredAlbums((photo) =>
                    {
                        return filterPhotoByMinComments(photo);
                    }, m_ConnectedUser);
                }
                else
                {
                    m_FilteredPhotos = new FilteredAlbums((photo) =>
                    {
                        return filterPhotoByYear(photo);
                    }, m_ConnectedUser);
                }
            }
            FacebookObjectCollection<Photo> filteredPhotos = m_FilteredPhotos.FilterAlbums();
            if (filteredPhotos.Count == 0)
            {
                MessageBox.Show("No Photos to retrieve :(");
            }
            else
            {
                m_PictureNum = 0;
                pictureBoxAlbum.LoadAsync(filteredPhotos[m_PictureNum].PictureAlbumURL);
                nextImage.Visible = true;
                previousImage.Visible = true;
                pictureBoxAlbum.Visible = true;
            }
        }

        private void nextImage_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Photo> filteredPhotos = m_FilteredPhotos.GetPhotos();
            if (filteredPhotos.Count != 0)
            {
                m_PictureNum++;
                if (m_PictureNum == filteredPhotos.Count)
                {
                    m_PictureNum = 0;
                }
            }
            pictureBoxAlbum.LoadAsync(filteredPhotos[m_PictureNum].PictureAlbumURL);
        }

        private void previousImage_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Photo> filteredPhotos = m_FilteredPhotos.GetPhotos();
            if (filteredPhotos.Count != 0)
            {
                m_PictureNum--;
                if (m_PictureNum == -1)
                {
                    m_PictureNum += filteredPhotos.Count;
                }
                pictureBoxAlbum.LoadAsync(filteredPhotos[m_PictureNum].PictureAlbumURL);
            }
        }

        private void filterByComments_CheckedChanged(object sender, EventArgs e)
        {
            if (filterByComments.Checked)
            {
                comboBoxComments.Enabled = true;
            }
            else
            {
                comboBoxComments.Enabled = false;
            }
        }

        private void picturesByYear_CheckedChanged(object sender, EventArgs e)
        {
            if (picturesByYear.Checked)
            {
                comboBoxComments.Visible = true;
                filterByComments.Visible = true;
                commentsLabel.Visible = true;
                filterByComments.Checked = false;
                comboBoxComments.Enabled = false;
            }
            else
            {
                comboBoxComments.Visible = false;
                filterByComments.Visible = false;
                commentsLabel.Visible = false;
            }
        }
    }
}
