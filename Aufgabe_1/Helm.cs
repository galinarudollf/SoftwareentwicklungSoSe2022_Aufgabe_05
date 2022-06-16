using System;
using System.Collections.Generic;
using System.Text;

namespace Evolution
{
    class Helm
    {

        public double Durchmesser
        {
            get; //private set;
        }
        public int Festigkeit
        {
            get;
        }
        public Helm(double durchmesser, int festigkeit)
        {
            Durchmesser = durchmesser; Festigkeit = festigkeit;
        }
        public override string ToString()
        {
            return "Helm " + Durchmesser.ToString() + " " + Festigkeit.ToString();
        }


    }
}
