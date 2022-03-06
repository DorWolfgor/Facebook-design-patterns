using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPosts : Form
    {
        private readonly ConnectedUser m_ConnectedUser;

        public FormPosts(ConnectedUser i_LoggedInUser_)
        {
            InitializeComponent();
            m_ConnectedUser = i_LoggedInUser_;
        }

        private void FormPosts_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchPosts);
            thread.Start();
            
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));

            foreach (Post post in m_ConnectedUser.m_User.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                }  
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_ConnectedUser.m_User.Posts[listBoxPosts.SelectedIndex];
           
            try
            {
                listBoxPostComments.DisplayMember = "Message";
                listBoxPostComments.DataSource = selected.Comments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_ConnectedUser.m_User.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

  
    }
}
