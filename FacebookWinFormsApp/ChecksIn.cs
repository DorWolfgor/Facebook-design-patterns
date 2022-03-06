using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class ChecksIn
    {
        private readonly ConnectedUser m_ConnectedUser;
        private string m_SelectedCheckInToSearch;
        public event Action<User> m_AddFriendInLocation;
        public event Action<Checkin> m_AddLocationsFriends;


        public ChecksIn(ConnectedUser i_LoggedUser)
        {
            m_ConnectedUser = i_LoggedUser;
        }

        public void FetchChecksInOfFriends()
        {
            if(m_ConnectedUser.GetFriends() != null)
            {
                FacebookObjectCollection<User> friends = m_ConnectedUser.GetFriends();
                foreach (User friend in friends)
                {
                    if(friend.Checkins != null)
                    {
                        foreach (Checkin checkIn in friend.Checkins)
                        {
                            if (checkIn.Place != null)
                            {
                                on_m_AddLocationsFriends(checkIn);
                            }
                        }
                    }
                }
            }
        }
        private void on_m_AddLocationsFriends(Checkin i_Checkin)
        {
            if (m_AddLocationsFriends != null)
            {
                m_AddLocationsFriends.Invoke(i_Checkin);
            }
        }
        private void  on_FindFriendInLocation(User i_Friend)
        {
            if(m_AddFriendInLocation != null)
            {
                m_AddFriendInLocation.Invoke(i_Friend);
            }
        }
        public void FetchFriendsInlocationEqualCheckin(string[] i_LocationInput)
        {  
            if (m_ConnectedUser.GetFriends() != null)
            {
                FacebookObjectCollection<User> friends = m_ConnectedUser.GetFriends();
                foreach (User friend in friends)
                {
                    if (friend.Checkins != null)
                    {
                        foreach (Checkin checkin in friend.Checkins)
                        {
                            if(checkin.Place != null && checkEqualCheckin(i_LocationInput, checkin))
                            {
                                m_SelectedCheckInToSearch = checkin.Place.Name;
                                on_FindFriendInLocation(friend);

                            }
                        }
                    }
                }               
            }
        }

        public void LoadCheckInInformation(string i_SelectedFriendName, ref User io_SelectedFriend, ref Checkin io_SelectedCheckIn)
        {
            FacebookObjectCollection<User> friends = m_ConnectedUser.GetFriends();
            foreach (User friend in friends)
            {
                if (friend.Name == i_SelectedFriendName)
                {
                    foreach (Checkin checkin in friend.Checkins)
                    {
                        if(checkin.Place != null)
                        {
                            if (checkin.Place.Name == m_SelectedCheckInToSearch)
                            {
                                io_SelectedFriend = friend;
                                io_SelectedCheckIn = checkin;
                            }

                        }
                    }
                }
            }
        }

        private bool checkEqualCheckin(string[] i_Location, Checkin i_Checkin)
        {
            bool isCheckinsEqual = false;

            if (i_Checkin.Place == null || i_Checkin.Place.Name == null)
            {
                isCheckinsEqual = false;
            }
            else
            {
                string[] inputCheckinString = i_Checkin.Place.Name.ToUpper().Split();
                isCheckinsEqual = checkEqual(i_Location, inputCheckinString);
            }

            return isCheckinsEqual;
        }

        private bool checkEqual(string[] i_Strings, string[] i_InputStrings)
        {
            bool isEqual = false;

            foreach (string word in i_InputStrings)
            {
                foreach (string str in i_Strings)
                {
                    if (str.Equals(word))
                    {
                        isEqual = true;
                        break;
                    }
                }
            }

            return isEqual;
        }
    }
}
