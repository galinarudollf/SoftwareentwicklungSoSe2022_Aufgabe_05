using System;
using System.Collections.Generic;
using System.Text;

namespace Evolution
{
    class HelmTiger:Tiger
    {
        private Helm HelmFeld;
        public Helm EigenHelm
        {
            get { return HelmFeld; }
            set 
            { 
                if (value.Durchmesser>=Umfang/Math.PI)
                {
                    HelmFeld = value;
                }
                else HelmFeld = null;
            }
        }
        
        //public int GesamtFestigkeit()
        public override int GesamtFestigkeit()
        {
            if (HelmFeld != null)
                return base.Festigkeit + EigenHelm.Festigkeit;
            else
                return base.Festigkeit;
        }
         
        public HelmTiger(int registriernummer,double durchmesser, int festigkeit, Helm helm):
            base(registriernummer,durchmesser,festigkeit)
        {
            EigenHelm = helm;
        }
        /*
        public HelmTiger():base()
        {
            EigenHelm = null;
        }
        */
        public override string ToString()
        {
            return "Tiger " + Umfang.ToString() + " " + Festigkeit.ToString() + " " + HelmFeld;
        }

    }
}
