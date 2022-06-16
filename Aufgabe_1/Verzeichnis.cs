using System;

namespace Evolution
{
    class Verzeichnis
    {
        private Tiger[] AlleTigerFeld;
        public Tiger[] AlleTiger
        {
            get { return AlleTigerFeld; }
        }

        public Tiger this[int i]
        {
            get { return AlleTigerFeld[i]; }
            set { AlleTigerFeld[i] = value; }
        }
        public Verzeichnis(int anzahl=10)
        {
            AlleTigerFeld = new Tiger[anzahl];
        }
        public Tiger Suchen(int registriernummer)
        {

            foreach (Tiger tiger in AlleTiger)
                if (tiger!=null)
                    if (tiger.Registriernummer.Equals(registriernummer))
                        return tiger;
            return null;
        }
        static void Main(string[] args)
        {
  //          Tiger[] tt = new Tiger[5];
  //          tt[0] = new Tiger(90, 5);
  //          tt[1] = new Tiger(100, 6);
  //          tt[2] = new HelmTiger(90, 5, new Helm(35,1));
  //          tt[3] = new HelmTiger(90, 5, new Helm(20, 1));
  //          tt[4] = new HelmTiger(90, 5, new Helm(35, 1));
  //          foreach (Tiger tiger in tt) Console.WriteLine(tiger);
  //          foreach(var tiger in tt)
  //          {
                ////a
                ////if (tiger is HelmTiger)
                ////{
                ////    Console.WriteLine((tiger as HelmTiger).GesamtFestigkeit());
                ////}
                ////
  //              Console.WriteLine(tiger.GesamtFestigkeit());
  //          }

            
            Verzeichnis tt = new Verzeichnis();
            tt[0] = new Tiger(11,90, 5);
            tt[1] = new Tiger(12,100, 6);
            tt[2] = new HelmTiger(101,90, 5, new Helm(35, 1));
            tt[3] = new HelmTiger(102,90, 5, new Helm(20, 1));
            tt[4] = new HelmTiger(103,90, 5, new Helm(35, 1));
            foreach (Tiger tiger in tt.AlleTiger)
                if (tiger!=null) Console.WriteLine(tiger);
            Console.WriteLine(tt.Suchen(11));
            Console.WriteLine(tt.Suchen(22));
            //double x=0;
            //Console.WriteLine(2/x);
        }
        
    }
}
