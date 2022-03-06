using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IHandler
    {
        void SetNextHandler(IHandler i_NextHandler);

        void Handle(string i_Text, ref string io_Message);
    }
}
