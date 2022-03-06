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
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormFriendsChecksIn : Form
    {
        private readonly ConnectedUser m_ConnectedUser;
        private readonly ChecksIn m_ChecksInOfUser;
       
        public FormFriendsChecksIn(ConnectedUser i_LoggedInUser)
        {
            InitializeComponent();
            m_ConnectedUser = i_LoggedInUser;
            m_ChecksInOfUser = new ChecksIn(m_ConnectedUser);
            m_ChecksInOfUser.m_AddFriendInLocation += AddFriendToFriendsListBox;
            m_ChecksInOfUser.m_AddLocationsFriends += AddLocationToCheckinsListBox;
        }

        private void FormFriendsChecksIn_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchChecksIns);
            thread.Start();
            MessageBox.Show("The CheckIns Are Loading");
        }
        private void fetchChecksIns()
        {
            m_ChecksInOfUser.FetchChecksInOfFriends();
        }
        private void buttonSearchLocation_Click(object sender, EventArgs e)
        {
            resetCheckInInfo();
            fetchFriendsInlocationEqualCheckin();
        }

        public void AddFriendToFriendsListBox(User i_Friend)
        {
            if (!ListBoxFriendsInLocation.Items.Contains(i_Friend.Name))
            {
                ListBoxFriendsInLocation.Items.Add(i_Friend.Name);
            }
        }

        public void AddLocationToCheckinsListBox(Checkin i_Checkin)
        {
            listBoxCheckIns.Invoke(new Action(()=> listBoxCheckIns.Items.Add(i_Checkin.Place.Name)));
            //listBoxCheckIns.Items.Add(i_Checkin.Place.Name);
        }

        private void fetchFriendsInlocationEqualCheckin()
        {
            string[] locationInput = textBoxLocation.Text.ToUpper().Split();
            m_ChecksInOfUser.FetchFriendsInlocationEqualCheckin(locationInput);
        }

        private void listBoxCheckIns_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxLocation.Text = listBoxCheckIns.SelectedItem.ToString();
            ListBoxFriendsInLocation.Items.Clear();

        }

        private void resetCheckInInfo()
        {
            ListBoxFriendsInLocation.Items.Clear();
            labelName.Text = "Friend Name: ";
            labelLocation.Text = "Location: ";
            labelDate.Text = "Date and Time: ";
            labelStatus.Text = "Status: ";
            pictureBoxCheckinFriendPicture.Image = null;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetCheckInInfo();
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            loadCheckInInformation();
        }

        private void loadCheckInInformation()
        {
            User selectedFriend = new User();
            Checkin selectedCheckIn = new Checkin();

            if (ListBoxFriendsInLocation.SelectedItem != null)
            {
                string selectedFriendName = ListBoxFriendsInLocation.SelectedItem.ToString();
                m_ChecksInOfUser.LoadCheckInInformation(selectedFriendName, ref selectedFriend, ref selectedCheckIn);
                fetchCheckInInfo(selectedFriend, selectedCheckIn);
            }
            else
            {
                MessageBox.Show("Please choose a friend first!");
            }
        }

        private void fetchCheckInInfo(User i_SelectedFriend, Checkin i_SelectedCheckIn)
        {
            try
            {
                labelName.Text += "  " + i_SelectedFriend.Name;
                labelLocation.Text += "  " + i_SelectedCheckIn.Place.Name;
                labelDate.Text += "  " + i_SelectedCheckIn.UpdateTime.ToString();
                
                if(i_SelectedCheckIn.Message != null)
                {
                    labelStatus.Text += i_SelectedCheckIn.Message.ToString();
                }

                if(i_SelectedCheckIn.PictureURL != null)
                {
                    pictureBoxCheckinFriendPicture.Load(i_SelectedCheckIn.PictureURL);
                }
                else
                {
                    pictureBoxCheckinFriendPicture.Image = pictureBoxCheckinFriendPicture.ErrorImage;
                }
            }
            catch
            {
                MessageBox.Show("There is no information!");
            }
        }
    }
}
