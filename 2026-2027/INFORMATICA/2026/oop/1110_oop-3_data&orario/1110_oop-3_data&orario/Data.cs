using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110_oop_3_data_orario
{

    public class Data
    {
        private int giorno;
        private int mese;
        private int anno;
        
        public Data()
        {
            giorno = 1;
            mese = 1;
            anno = 1900;
        }

        public Data(int g, int m, int a)
        {
            giorno = g;
            mese = m;
            anno = a;
        }
        public virtual string ToString()
        {
            return giorno + "/" + mese + "/" + anno;
        }
        
        public virtual bool Bisestile()
        {
            if (anno % 400 == 0)
                return true;

            if (anno % 100 == 0)
                return false;

            if (anno % 4 == 0)
                return true;

            return false;
        }

        public virtual void Leggi(int g, int m, int a)
        {
            giorno = g;
            mese = m;
            anno = a;
        }

        public virtual void Scrivi(out int g, out int m, out int a)
        {
            g = giorno;
            m = mese;
            a = anno;
        }

        public virtual void Domani()
        {
            giorno++;

            int giorniMese = 31;

            if (mese == 4 || mese == 6 || mese == 9 || mese == 11)
                giorniMese = 30;
            else if (mese == 2)
            {
                if (Bisestile())
                    giorniMese = 29;
                else
                    giorniMese = 28;
            }

            if (giorno > giorniMese)
            {
                giorno = 1;
                mese++;

                if (mese > 12)
                {
                    mese = 1;
                    anno++;
                }
            }
        }

        public virtual void Ieri()
        {
            giorno--;

            if (giorno < 1)
            {
                mese--;

                if (mese < 1)
                {
                    mese = 12;
                    anno--;
                }

                if (mese == 4 || mese == 6 || mese == 9 || mese == 11)
                    giorno = 30;
                else if (mese == 2)
                {
                    if (Bisestile())
                        giorno = 29;
                    else
                        giorno = 28;
                }
                else
                    giorno = 31;
            }
        }

        public virtual string Giorno()
        {
            DateTime data = new DateTime(anno, mese, giorno);

            return data.DayOfWeek.ToString();
        }
    }
}
