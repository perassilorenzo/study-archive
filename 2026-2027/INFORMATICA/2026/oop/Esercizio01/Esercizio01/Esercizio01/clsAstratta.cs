using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01
{
    public abstract class clsAstratta
    {

        // Metodi Astratti che può essere in overried nelle 
        // varie Classi che ereditano clsAstratta
        public abstract string visualizzaVeicolo();

        public abstract double calcolaBollo();

    }
}
