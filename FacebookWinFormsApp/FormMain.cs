using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures;
using BasicFacebookFeatures.Properties;
using Singelton;
using NHunspell;


namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private ConnectedUser m_ConnectedUser = Singelton<ConnectedUser>.Instance;
        
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            loginAndInit();
        }

        private void loginAndInit()
        {

            LoginResult loginResult = m_ConnectedUser.Login();

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
            }
            
            buttonLogin.Text = m_ConnectedUser.GetUserName();
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_ConnectedUser.GetProfilePicture());
            labelUserBirthday.Text = "Birthday:" + m_ConnectedUser.GetBirthdayDate();
            labelUserGender.Text = "Gender:"+ m_ConnectedUser.GetGender();
            labelUserRelationshipStatus.Text = "Relationships Status:" + m_ConnectedUser.GetRelationshipStatus();
            groupBoxIntroUser.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_ConnectedUser.Logout();
			buttonLogin.Text = "Login";
		}

        private void showForm(Form i_FormToShow, object sender)
        {
            i_FormToShow.TopLevel = false;
            i_FormToShow.TopMost = true; 
            i_FormToShow.FormBorderStyle = FormBorderStyle.None;
            i_FormToShow.Dock = DockStyle.Fill;
            this.panelDekstop.Controls.Add(i_FormToShow);
            i_FormToShow.BringToFront();
            i_FormToShow.Show();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            FormEvents events = m_ConnectedUser.GetFormEvents();

            if (events != null)
            {             
                showForm(events, sender);
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            FormGroups groups = m_ConnectedUser.GetFormGroups();

            if (groups != null)
            {        
                showForm(groups, sender);
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums albums = m_ConnectedUser.GetFormAlbums();
          
            if (albums != null)
            {
                showForm(albums, sender);
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            FormLikedPages likedPages = m_ConnectedUser.GetFormLikedPages(); 

            if (likedPages != null)
            {
                showForm(likedPages, sender);
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            FormPosts posts = m_ConnectedUser.GetFormPosts();

            if (posts != null)
            {
                showForm(posts, sender);
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }

        private void buttonFriendsChecksIn_Click(object sender, EventArgs e)
        {
            FormFriendsChecksIn ChecksIns = m_ConnectedUser.GetFormFriendsChecksIn();

            if (ChecksIns != null)
            {
                showForm(ChecksIns, sender);
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }
       
        private void buttonActivity_Click(object sender, EventArgs e)
        {
            FormActivity activity = m_ConnectedUser.GetFormActivity();

            if (activity != null)
            {
                showForm(activity, sender);
            }
            else
            {
                MessageBox.Show("Please login first");
            }
        }
    }
}
