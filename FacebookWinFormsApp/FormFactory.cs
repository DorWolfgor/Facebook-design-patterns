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
    public class FormFactory
    {
        public enum eFormType
        {
            FormActivity,
            FormAlbums,
            FormEvents,
            FormFriendsCheckIn,
            FormGroup,
            FormLikedPages,
            FormPosts
        }
        public static Form CreateForm(eFormType i_FormType, ConnectedUser i_ConnectedUser)
        {
            Form newForm = null;
            if (i_ConnectedUser != null)
            {
                switch (i_FormType)
                {
                    case eFormType.FormActivity:
                        {
                            newForm = new FormActivity(i_ConnectedUser);
                            break;
                        }
                    case eFormType.FormAlbums:
                        {
                            newForm = new FormAlbums(i_ConnectedUser);
                            break;
                        }
                    case eFormType.FormEvents:
                        {
                            newForm = new FormEvents(i_ConnectedUser);
                            break;
                        }
                    case eFormType.FormFriendsCheckIn:
                        {
                            newForm = new FormFriendsChecksIn(i_ConnectedUser);
                            break;
                        }
                    case eFormType.FormGroup:
                        {
                            newForm = new FormGroups(i_ConnectedUser);
                            break;
                        }
                    case eFormType.FormLikedPages:
                        {
                            newForm = new FormLikedPages(i_ConnectedUser);
                            break;
                        }
                    case eFormType.FormPosts:
                        {
                            newForm = new FormPosts(i_ConnectedUser);
                            break;
                        }
                }
            }
     
            return newForm;
        }
        //public static FormActivity GetFormActivity(ConnectedUser i_ConnectedUser)
        //{
        //    if (i_ConnectedUser.m_User != null)
        //    {
        //        return new FormActivity(i_ConnectedUser);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public static FormAlbums GetFormAlbums(ConnectedUser i_ConnectedUser)
        //{
        //    if (i_ConnectedUser.m_User != null)
        //    {
        //        return new FormAlbums(i_ConnectedUser);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public static FormEvents GetFormEvents(ConnectedUser i_ConnectedUser)
        //{
        //    if (i_ConnectedUser.m_User != null)
        //    {
        //        return new FormEvents(i_ConnectedUser);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public static FormFriendsChecksIn GetFormFriendsChecksIn(ConnectedUser i_ConnectedUser)
        //{
        //    if (i_ConnectedUser.m_User != null)
        //    {
        //        return new FormFriendsChecksIn(i_ConnectedUser);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public static FormGroups GetFormGroups(ConnectedUser i_ConnectedUser)
        //{
        //    if (i_ConnectedUser.m_User != null)
        //    {
        //        return new FormGroups(i_ConnectedUser);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public static FormLikedPages GetFormLikedPages(ConnectedUser i_ConnectedUser)
        //{
        //    if (i_ConnectedUser.m_User != null)
        //    {
        //        return new FormLikedPages(i_ConnectedUser);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        
        //public static FormPosts GetFormPosts(ConnectedUser i_ConnectedUser)
        //{
        //    if (i_ConnectedUser.m_User != null)
        //    {
        //        return new FormPosts(i_ConnectedUser);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        
    }
}
