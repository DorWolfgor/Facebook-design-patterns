
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
    public class GrammerChecker : Checker
    {
        public override void Handle(string i_Text, ref string io_Message)
        {
            using (Hunspell hunspell = new Hunspell())
            {
                bool isFirst = true;
                hunspell.Load("../../../en_US.aff", "../../../en_US.dic");
                string[] words = i_Text.Split(' ');
                foreach (string word in words)
                {
                    if (!hunspell.Spell(word))
                    {
                        if(isFirst)
                        {
                           if(io_Message != string.Empty)
                           {
                                io_Message += Environment.NewLine;
                           }
                            io_Message += "Spell mistake:";

                            isFirst = false;
                        }
                        io_Message += string.Format(" {0}",word);
                    }
                }
            }
            
            base.Handle(i_Text, ref io_Message);
        }
    }
}
