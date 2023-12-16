using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpLabOdev5
{
    class EskenarUcgen : Sekiller
    {
        public int kenar;
        public EskenarUcgen()
        {
            kenar = 0;
        }
        public EskenarUcgen(int kenar , bool doluMu)
        {
            this.kenar = kenar;
            this.doluMu = doluMu;
        }
        public double AlanHesapla()
        {
            return (this.kenar * this.kenar) * Math.Sqrt(3) /4;
        }
        public double CevreHesapla()
        {
            return this.kenar * 3;
        }
        public void SetKenar(int kenar)
        {
            this.kenar = kenar;
        }
        public int GetKenar()
        {
            return this.kenar;
        }
        public void Ciz()
        {
            if (doluMu == true)
            {
               EskenarUcgenDoluCiz();
            }
            else if (doluMu == false)
            {
                EskenarUcgenBosCiz();
            }

        }
        private void EskenarUcgenDoluCiz()
        {
            for (int i = 1; i <= kenar; i++)
            {
                for (int j = 1; j <= kenar - i; j++)
                    Console.Write(" ");

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        private void EskenarUcgenBosCiz()
        {
            for (int i = 1; i <= kenar; i++)
            {
                Console.WriteLine();
                if (i == 1 || i == kenar)
                {
                    for (int j = 1; j <= (kenar - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(sembol);
                        Console.Write(" ");
                    }
                }
                else
                {
                    for (int j = 1; j <= (kenar - i); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(sembol);
                    for (int j = 1; j <= (2 * i - 3); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(sembol);
                }
            }
         }
        public string OzellikYazdir()
        {


            return $"{olusturulmaTarihi} tarihinde olusturulan diktortgen sınıfı" +
                $" --> Kenar:{kenar}"+
                $" Alan:{AlanHesapla()} Cevre:{CevreHesapla()}";

        }

    }
}
