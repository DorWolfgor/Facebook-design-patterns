using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class Checker : IHandler
    {
        protected IHandler m_NextHandler;

        public virtual void Handle(string i_Text, ref string io_Message)
        {
            if (m_NextHandler != null)
            {
                m_NextHandler.Handle(i_Text, ref io_Message);
            }
        }

        public void SetNextHandler(IHandler i_NextHandler)
        {
            m_NextHandler = i_NextHandler;
        }
    }
}
