using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpLabOdev5
{
    public class EskenarDortgen : Sekiller
    {
        public int yukseklik;
        public int genislik;
        public EskenarDortgen()
        {
            yukseklik = 0;
            genislik = 0;
        }
        public EskenarDortgen(int yukseklik , int genislik , bool doluMu)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.doluMu = doluMu;
        }
        public void Ciz()
        {
            
            if ((genislik == yukseklik) && (genislik%2 == 1 && yukseklik%2 == 1))
            {
                if (doluMu == true)
                {
                    EskenarDortgenDoluCiz();
                }
                else if (doluMu == false)
                {
                    EskenarDortgenBosCiz();
                }
            }
            else
            {
                Console.WriteLine("Cizim Yapilamiyor");
            }
        }
        private void EskenarDortgenDoluCiz()
        {
            for (int i = 1; i <= genislik; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= (yukseklik - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(sembol);
                    Console.Write(" ");
                }
            }
            for (int i = (genislik - 1); i >= 1; i--)
            {
                Console.WriteLine();
                for (int j = 1; j <= (genislik - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(sembol);
                    Console.Write(" ");
                }
            }

        }
        private void EskenarDortgenBosCiz()
        {
            for (int i = 1; i <= genislik; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= (yukseklik - i); j++)
                {
                    Console.Write(" ");
                }
                if (i != 1) { Console.Write(sembol); }
                for (int j = 1; j <= (2 * i - 3); j++)
                {
                    Console.Write(" ");
                }
                Console.Write(sembol);
            }

            for (int i = (genislik - 1); i >= 1; i--)
            {
                Console.WriteLine();
                for (int j = 1; j <= (genislik - i); j++)
                {
                    Console.Write(" ");
                }
                Console.Write(sembol);
                for (int j = 1; j <= (2 * i - 3); j++)
                {
                    Console.Write(" ");
                }
                if (i != 1) { Console.Write(sembol); }
            }

        }
        public double AlanHesapla()
        {
            return (this.genislik * this.yukseklik) / 2;
        }
        
        public void YukseklikDegistir(int yukseklik)
        {
            this.yukseklik = yukseklik;
        }
        public int YukseklikAl()
        {
            return this.yukseklik;
        }
        public string OzellikYazdir()
        {
            return $"{olusturulmaTarihi} tarihinde olusturulan EskenarDortgen sınıfı" +
                $" --> Genislik:{genislik} Yükseklik:{yukseklik}" +
                $" Alan:{AlanHesapla()}";
        }
        public void GenislikDegistir(int genislik)
        {
            this.genislik = genislik;
        }
        public int GenislikAl()
        {
            return this.genislik;
        }
      

    }
}
