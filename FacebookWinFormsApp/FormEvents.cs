using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormEvents : Form
    {
        private readonly ConnectedUser m_ConnectedUser;
       
        public FormEvents(ConnectedUser i_LoggedInUser)
        {
            InitializeComponent();
            m_ConnectedUser = i_LoggedInUser;
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
                eventDateStartTime.Text = selectedEvent.StartTime.ToString();
                eventLocaition.Text = selectedEvent.Location.ToString();
            }
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(fetchEvents);
            thread.Start();
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Clear()));
            listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
            FacebookObjectCollection<Event> events = m_ConnectedUser.GetEvents();
            foreach (Event myEvent in events)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(myEvent)));
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to show");
            }
        }
    }
}
