﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Ez a rész azért szükséges, hogy a tesztelő láthassa
// A védett osztályokat vagy objektumokat
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("StaticFunctionExercises.Test")]

namespace StaticFunctionExercises
{
    internal class MySolution
    {
    //Készítsen olyan statikus metódust, amely egy pozitív egész számot vesz át érték szerint és 
    //visszaadja, hogy ennek a számnak hány pozitív osztója van. Függvény neve legyen OsztokSzama.
        public static int OsztokSzama(int szam)
        {
            int db=0;
            for(int x=1; x<=szam; x++)
            {
                if (szam%x==1)
                {
                    db++;
                }
            }
            return db;
        }
    }
}
