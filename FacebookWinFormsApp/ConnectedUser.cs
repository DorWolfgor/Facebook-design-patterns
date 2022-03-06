using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class ConnectedUser
    {
        public User m_User { get; set; }
        private LoginResult m_LoginResult { get; set; }
        private ConnectedUser()
        {

        }

        public LoginResult Login()
        {
            m_LoginResult = FacebookService.Login(
                    "320248612767444",
                /// requested permissions:
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
                );
            m_User = m_LoginResult.LoggedInUser;
            return m_LoginResult;
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI();
        }

        public string GetProfilePicture()
        {
            return m_User.PictureNormalURL;
        }

        public string GetUserName()
        {
            return $"Logged in as {m_LoginResult.LoggedInUser.Name}";
        }

        public string GetGender()
        {
            return m_User.Gender.ToString();
        }

        public string GetRelationshipStatus()
        {
            return m_User.RelationshipStatus.ToString();
        }

        public string GetBirthdayDate()
        {
            return m_User.Birthday.ToString();
        }

        public FormActivity GetFormActivity()
        {
            return FormFactory.CreateForm(FormFactory.eFormType.FormActivity, this) as FormActivity;
        }

        public FormAlbums GetFormAlbums()
        {
            return FormFactory.CreateForm(FormFactory.eFormType.FormAlbums, this) as FormAlbums;
        }

        public FormEvents GetFormEvents()
        {
            return FormFactory.CreateForm(FormFactory.eFormType.FormEvents, this) as FormEvents;
        }

        public FormFriendsChecksIn GetFormFriendsChecksIn()
        {
            return FormFactory.CreateForm(FormFactory.eFormType.FormFriendsCheckIn, this) as FormFriendsChecksIn;
        }

        public FormGroups GetFormGroups()
        {
            return FormFactory.CreateForm(FormFactory.eFormType.FormGroup, this) as FormGroups;
        }

        public FormLikedPages GetFormLikedPages()
        {
            return FormFactory.CreateForm(FormFactory.eFormType.FormLikedPages, this) as FormLikedPages;
        }

        public FormPosts GetFormPosts()
        {
            return FormFactory.CreateForm(FormFactory.eFormType.FormPosts, this) as FormPosts;
        }

        public FacebookObjectCollection<Group> GetGroups()
        {
            if (m_User != null)
            {
                return m_User.Groups;
            }
            else
            {
                return null;
            }
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            if (m_User != null)
            {
                return m_User.Friends;
            }
            else
            {
                return null;
            }
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            if (m_User != null)
            {
                return m_User.Posts;
            }
            else
            {
                return null;
            }
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            if (m_User != null)
            {
                return m_User.Albums;
            }
            else
            {
                return null;
            }
        }

        public FacebookObjectCollection<Event> GetEvents()
        {
            if (m_User != null)
            {
                return m_User.Events;
            }
            else
            {
                return null;
            }
        }

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            if (m_User != null)
            {
                return m_User.LikedPages;
            }
            else
            {
                return null;
            }
        }
    }
}
