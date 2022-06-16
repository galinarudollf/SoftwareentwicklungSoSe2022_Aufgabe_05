using System;
using System.Collections.Generic;
using System.Text;

namespace Evolution
{
    class Tiger
    {
        public int Registriernummer
        {
            get;
        }

        public double Umfang
        {
            get;set;
        }
         public int Festigkeit
         {
             get;set;
         }
         
         public virtual int GesamtFestigkeit()
         {
             return Festigkeit;
         }
         
         public Tiger(int registriernummer,double umfang,int festigkeit)
        {
            Registriernummer = registriernummer;
            Umfang = umfang;
            Festigkeit = festigkeit;
        }
        public override string ToString() 
        {
            return "Tiger " + Umfang.ToString() +" "+Festigkeit.ToString();
        }


}
}
