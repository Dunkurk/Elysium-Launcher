using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElysiumLaunhcer
{
    public class Launcher
    {
       
        public Boolean firstSetup { get; set; }
        public Double VersionNo { get; set; }
        public String wowLocation { get; set; }
        
        public Launcher()
        {
            firstSetup = false;
            VersionNo = 1.0;
        }

        public Launcher(string firstSetupIn, string wowLoactionIn)
        {
           if(firstSetupIn == "1")
            {
                this.firstSetup = true;
                this.wowLocation = wowLoactionIn;
            }
            else
            {
                this.firstSetup = false;
            }
        }
    }
}
