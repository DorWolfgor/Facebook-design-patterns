using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormGroups : Form
    {
        private readonly ConnectedUser m_ConnectedUser;
    
        public FormGroups(ConnectedUser i_LoggedInUser )
        {
            InitializeComponent();
            m_ConnectedUser = i_LoggedInUser;
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchGroups);
            thread.Start();
        }

        private void fetchGroups()
        {
            listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Clear()));
            listBoxGroups.Invoke(new Action(() => listBoxGroups.DisplayMember = "Name"));

            try
            {
                FacebookObjectCollection<Group> groups = m_ConnectedUser.GetGroups();
                foreach (Group group in groups)
                {
                    listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No Groups found");
            }
        }

        private void listBoxGroups_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Group selectedGroup;

            if (1 == listBoxGroups.SelectedItems.Count)
            {
                selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }
    }
}
