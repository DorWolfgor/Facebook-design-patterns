using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.COF
{
   public class ChangeDescriptionManager
    {
        string m_Text;
        string m_Message = string.Empty;

        public string Message
        {
            get
            {
                return m_Message;
            }
        }

        public ChangeDescriptionManager(string i_Text)
        {
            m_Text = i_Text;
        }
        private void handleFilter()
        {  
            IHandler profanity = new ProfanityChecker();
            IHandler grammer = new GrammerChecker();
            profanity.SetNextHandler(grammer);
            profanity.Handle(m_Text, ref m_Message);
        }

        public bool Run()
        { 
            handleFilter();
            return m_Message == string.Empty;
        }


    }
}
