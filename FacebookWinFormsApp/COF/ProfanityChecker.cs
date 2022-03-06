using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfanityFilter;
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

namespace BasicFacebookFeatures.COF
{
    public class ProfanityChecker : Checker
    {
        private ProfanityFilter.ProfanityFilter m_ProfanityFilter;

        public ProfanityChecker()
        {
            m_ProfanityFilter = new ProfanityFilter.ProfanityFilter();
        }

        public override void Handle(string i_Text, ref string io_Message)
        {
            ReadOnlyCollection<string> words = m_ProfanityFilter.DetectAllProfanities(i_Text, true);
            bool isFirst = true;
            foreach (string word in words)
            {
                if(isFirst)
                {
                    if(io_Message != string.Empty)
                    {
                        io_Message += Environment.NewLine;
                    }
                    io_Message += "Inappropriate words found:";
                }
                io_Message += string.Format(" {0}", word);
            }

            base.Handle(i_Text,ref io_Message);
        }
    }
}
