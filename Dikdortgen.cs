using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpLabOdev5
{
    public class Dikdortgen : Sekiller
    {



        public int genislik;
        public int yukseklik;

        
        public Dikdortgen()
        {
            
            genislik = 0;
            yukseklik = 0;
        }

        public Dikdortgen(int genislik, int yukseklik , bool doluMu)
        {
            
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.doluMu = doluMu;
        }

        
        public double AlanHesapla()
        {
            
            return this.yukseklik * this.genislik;
        }

        public double CevreHesapla()
        {
            
            return 2 * (genislik + yukseklik);
        }

        public void SetGenislik(int genislik)
        {
            
            this.genislik = genislik;
        }

        public int GetGenislik()
        {
            
            return this.genislik;
        }


        public void SetYukseklik(int yukseklik)
        {
            
            this.yukseklik = yukseklik;
        }

        public int GetYukseklik()
        {
            
            return this.yukseklik;
        }

        public void Ciz()
        {
            if (doluMu)
            {
                DikdortgenDoluCiz();
            }
            else
            {
                DikdortgenBosCiz();
            }
        }

        private void DikdortgenDoluCiz()
        {
            for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    Console.Write(sembol);
                }
                Console.WriteLine();
            }
        }

        private void DikdortgenBosCiz()
        {
            for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    if (i == 0 || i == yukseklik - 1 || j == 0 || j == genislik - 1)
                    {
                        Console.Write(sembol);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }


        public string OzellikYazdir()
        {

            
            return $"{olusturulmaTarihi} tarihinde olusturulan diktortgen sınıfı" +
                $" --> Genislik:{genislik} Yükseklik:{yukseklik}" +
                $" Alan:{AlanHesapla()} Cevre:{CevreHesapla()}";

        }
    }

}




