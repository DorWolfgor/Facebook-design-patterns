using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLikedPages : Form
    {
        
        private readonly ConnectedUser m_ConnectedUser;
       
        public FormLikedPages(ConnectedUser i_LoggedInUser)
        {
            InitializeComponent();
            m_ConnectedUser = i_LoggedInUser;
        }

        private void FormLikedPages_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchLikedPages);
            thread.Start();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Clear()));
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.DisplayMember = "Name"));

            try
            {
                FacebookObjectCollection<Page> likedPages = m_ConnectedUser.GetLikedPages();
                foreach (Page page in likedPages)
                {
                    listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (0 == listBoxLikedPages.Items.Count)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (1 == listBoxLikedPages.SelectedItems.Count)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }
    }
}
