using System;

namespace Aufgabe_2
{
    class Zahl
    {
        private int wert;
        public string Wert {
            get
            {
                //string s = "";
                //for (int i = 0; i < wert; i++, s += "I") ;
                //return s;
                return new String('I',wert);
            }
            set
            {
                foreach (char c in value)
                {
                    if (c != 'I') throw new FormatException();                   
                }
                wert = value.Length;
            } 
        }
        public Zahl(string _wert)
        {
            Wert = _wert;
        }
        public Zahl()
        {
            Wert = "";
        }
        public static Zahl operator+ (Zahl a,Zahl b)
        {
            Zahl erg = new Zahl();
            erg.wert = a.wert + b.wert;
            return erg;
        }

 /*       public static Zahl operator +(Zahl a, int b)
        {
            Zahl erg = new Zahl();
            erg.wert = a.wert + b;
            return erg;
        }
        
        public static int operator+(Zahl a, int b)
        {
            Zahl erg = new Zahl();
            erg.wert = a.wert + b;
            return erg.wert;
        }
        public static int operator +(int b, Zahl a)
        {
            Zahl erg = new Zahl();
            erg.wert = a.wert + b;
            return erg.wert;
        }
*/
        public static Zahl operator- (Zahl a, Zahl b)
        {
            Zahl erg = new Zahl();
            erg.wert = a.wert - b.wert>0 ? a.wert - b.wert :0;
            return erg;
        }
        public static Zahl operator/ (Zahl a, Zahl b)
        {
            Zahl erg = new Zahl();
            erg.wert = a.wert / b.wert;
            return erg;
        }

        public static bool operator== (Zahl a, Zahl b)
        {
            return a.wert==b.wert;
        }
        public static bool operator!= (Zahl a, Zahl b)
        {
            return a.wert != b.wert;
        }
        public static bool operator< (Zahl a, Zahl b)
        {
            return a.wert < b.wert;
        }
        public static bool operator> (Zahl a, Zahl b)
        {
            return a.wert > b.wert;
        }

        public override string ToString()
        {
            return Wert;
        }
        public override bool Equals(object o)
        {
            return (o as Zahl)?.wert == wert;
            //return true;
        }

        public override int GetHashCode()
        {
            return Wert.GetHashCode();
        }

        //unäre + und -
        //public static Zahl operator +(Zahl self) => self; //z.B. +a
        /*public static Zahl operator -(Zahl self)          //z.B. -a
        {
            if (self.wert == 0) { return self; }
            else
            {
                throw new Exception();
            }
        }
        */
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Zahl a = new Zahl("III");
                Zahl b = new Zahl("IIIII");
                Zahl c;
                c = a + b;
                //int i = 5;
                //i = 5 + a;
                //Console.WriteLine(i);
                //Zahl d = 5 + a;
                //Console.WriteLine(d);
                Console.WriteLine(c - new Zahl("II")-a);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
            }


        }
        
    }
}
