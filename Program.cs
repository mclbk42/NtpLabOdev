using System;

namespace NtpLabOdev5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int secim = 9;

            while ((secim == 9) || (secim == 8))
            {
                Console.WriteLine("1-) Dikdörtgen ");
                Console.WriteLine("2-) Eşkenar Üçgen ");
                Console.WriteLine("3-) Eşkenar Dörtgen ");
                Console.WriteLine("4-) Çıkış ");
                Console.Write("Seciminiz : ");
                int secim1 = Convert.ToInt32(Console.ReadLine());

                switch (secim1)
                {
                    case 1:
                        int gen, yuk;
                        bool doluSecim;
                        Console.Write("Dikdörtgenin genişliğini giriniz >> ");
                        gen = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Dikdörtgenin yüksekliğini giriniz >> ");
                        yuk = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dikdörtgenin içi Dolu olsun diyorsanız (true) , Boş olsun diyorsanız (false) giriniz");
                        doluSecim = Convert.ToBoolean(Console.ReadLine());
                        Dikdortgen dikdortgen = new Dikdortgen(gen, yuk, doluSecim);

                        do
                        {
                            Console.WriteLine("1-) Alan Hesapla");
                            Console.WriteLine("2-) Çevre Hesapla");
                            Console.WriteLine("3-) Çiz");
                            Console.WriteLine("4-) Genişlik Değiştir");
                            Console.WriteLine("5-) Yükseklik Değiştir");
                            Console.WriteLine("6-) Karakter Değiştir");
                            Console.WriteLine("7-) Dolumu Değiştir");
                            Console.WriteLine("8-) Bilgileri Yazdır");
                            Console.WriteLine("9-) Üst Menü");
                            Console.WriteLine("10-) Çıkış");
                            Console.Write("Seciminiz : ");
                            secim = Convert.ToInt32(Console.ReadLine());

                            switch (secim)
                            {
                                case 1:
                                    Console.WriteLine("\nAlan : " + dikdortgen.AlanHesapla()+"\n");
                                    
                                    break;
                                case 2:
                                    Console.WriteLine("\nÇevre : " + dikdortgen.CevreHesapla()+"\n");
                                    break;
                                case 3:
                                    Console.WriteLine();
                                    dikdortgen.Ciz();
                                    Console.WriteLine();
                                    break;
                                case 4:
                                    Console.Write("Dikdörtgenin yeni genişliğini giriniz : ");
                                    int yenigenislik = Convert.ToInt32(Console.ReadLine());
                                    dikdortgen.SetGenislik(yenigenislik);
                                    break;
                                case 5:
                                    Console.Write("Dikdortgenin yeni yüksekliğini giriniz : ");
                                    int yeniyukseklik = Convert.ToInt32(Console.ReadLine());
                                    dikdortgen.SetYukseklik(yeniyukseklik);
                                    break;
                                case 6:
                                    Console.WriteLine("Yeni sembolunuzu giriniz : ");
                                    char yeniSembol = Convert.ToChar(Console.ReadLine());
                                    dikdortgen.SetSembol(yeniSembol);
                                    break;
                                case 7:
                                    Console.WriteLine();
                                    Console.Write("Dikdörtgenin dolumunu değiştirmek istiyor musunuz? (true/false) : ");
                                    bool yeniDolumDurumu = Convert.ToBoolean(Console.ReadLine());
                                    dikdortgen.SetDoluMu(yeniDolumDurumu);
                                    Console.WriteLine("Dolum durumu güncellendi!\n");
                                    break;
                                    
                                case 8:
                                      Console.WriteLine("\n"+dikdortgen.OzellikYazdir()+"\n");
                                  break;
                                case 9:
                                    break; 
                                case 10:
                                    Environment.Exit(0);
                                    break; 
                                default:
                                    Console.WriteLine("Geçersiz seçenek!");
                                    break;
                            }
                        } while (secim != 9 && secim != 10); // 9 veya 10 seçilene kadar döngüyü sürdür
                        break;
                    case 2:
                        int ken;
                        bool dolusecimi;
                        Console.Write("Eskenar Ucgenin kenarını giriniz >> ");
                        ken = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Eskenar Ucgenin içi Dolu olsun diyorsanız (true) , Boş olsun diyorsanız (false) giriniz");
                        dolusecimi = Convert.ToBoolean(Console.ReadLine());
                        EskenarUcgen eskenarUcgen = new EskenarUcgen(ken, dolusecimi);

                        do
                        {
                            Console.WriteLine("1-) Alan Hesapla");
                            Console.WriteLine("2-) Çevre Hesapla");
                            Console.WriteLine("3-) Çiz");
                            Console.WriteLine("4-) Kenar Değiştir");
                            Console.WriteLine("5-) Karakter Değiştir");
                            Console.WriteLine("6-) Dolumu Değiştir");
                            Console.WriteLine("7-) Bilgileri Yazdır");
                            Console.WriteLine("8-) Üst Menü");
                            Console.WriteLine("9-) Çıkış");
                            Console.Write("Seciminiz : ");
                            secim = Convert.ToInt32(Console.ReadLine());

                            switch (secim)
                            {
                                case 1:
                                    Console.WriteLine("\nAlan : " + eskenarUcgen.AlanHesapla() + "\n");
                                    break;
                                case 2:
                                    Console.WriteLine("\nÇevre : " + eskenarUcgen.CevreHesapla() + "\n");
                                    break;
                                case 3:
                                    Console.WriteLine();
                                    eskenarUcgen.Ciz();
                                    Console.WriteLine();
                                    break;
                                case 4:
                                    Console.Write("Eskenar Ucgenin yeni kenarını giriniz : ");
                                    int yeniKenar = Convert.ToInt32(Console.ReadLine());
                                    eskenarUcgen.SetKenar(yeniKenar);
                                    break;
                                case 5:
                                    Console.WriteLine("Yeni sembolunuzu giriniz : ");
                                    char yeniSembol = Convert.ToChar(Console.ReadLine());
                                    eskenarUcgen.SetSembol(yeniSembol);
                                    break;
                                case 6:
                                    Console.WriteLine();
                                    Console.Write("Eskenar Ucgenin dolumunu değiştirmek istiyor musunuz? (true/false) : ");
                                    bool yeniDolumDurumu = Convert.ToBoolean(Console.ReadLine());
                                    eskenarUcgen.SetDoluMu(yeniDolumDurumu);
                                    Console.WriteLine("Dolum durumu güncellendi!\n");
                                    break;
                                case 7:
                                    Console.WriteLine("\n" + eskenarUcgen.OzellikYazdir() + "\n");
                                    break;
                                case 8:
                                    break; // İkinci menüden çıkış yap, birinci menüye geri dön
                                case 9:
                                    Environment.Exit(0);
                                    break; // Çıkış yap, döngüden çık
                                default:
                                    Console.WriteLine("Geçersiz seçenek!");
                                    break;
                            }
                        } while (secim != 8 && secim != 9); // 9 veya 10 seçilene kadar döngüyü sürdür
                        break;
                    case 3:
                        int eskenargen, eskenaryuk;
                        bool dolusecenek;
                        Console.Write("Eskenar Dortgenin yuksekliğini giriniz >> ");
                        eskenaryuk = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Eskenar Dortgenin genişliği giriniz >> ");
                        eskenargen = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Eskenar Dortgenin içi Dolu olsun diyorsanız (true) , Boş olsun diyorsanız (false) giriniz");
                        dolusecenek = Convert.ToBoolean(Console.ReadLine());
                        EskenarDortgen eskenarDortgen = new EskenarDortgen(eskenaryuk, eskenargen, dolusecenek);

                        do
                        {
                            Console.WriteLine("1-) Alan Hesapla");
                            Console.WriteLine("2-) Çiz");
                            Console.WriteLine("3-) Genişlik Değiştir");
                            Console.WriteLine("4-) Yükseklik Değiştir");
                            Console.WriteLine("5-) Karakter Değiştir");
                            Console.WriteLine("6-) Dolumu Değiştir");
                            Console.WriteLine("7-) Bilgileri Yazdır");
                            Console.WriteLine("8-) Üst Menü");
                            Console.WriteLine("9-) Çıkış");
                            Console.Write("Seciminiz : ");
                            secim = Convert.ToInt32(Console.ReadLine());

                            switch (secim)
                            {
                                case 1:
                                    Console.WriteLine("\nAlan : " + eskenarDortgen.AlanHesapla() + "\n");

                                    break;
                                case 2:
                                    Console.WriteLine();
                                    eskenarDortgen.Ciz();
                                    Console.WriteLine();
                                    break;
                                case 3:
                                    Console.Write("Eskenar Dortgenin yeni genişliğini giriniz : ");
                                    int yenigen = Convert.ToInt32(Console.ReadLine());
                                    eskenarDortgen.GenislikDegistir(yenigen);
                                    break;
                                case 4:
                                    Console.Write("Eskenar Dortgenin yeni yüksekliğini giriniz : ");
                                    int yeniyuk = Convert.ToInt32(Console.ReadLine());
                                    eskenarDortgen.YukseklikDegistir(yeniyuk);
                                    break;
                                case 5:
                                    Console.WriteLine("Yeni sembolunuzu giriniz : ");
                                    char yeniSembol = Convert.ToChar(Console.ReadLine());
                                    eskenarDortgen.SetSembol(yeniSembol);
                                    break;
                                case 6:
                                    Console.WriteLine();
                                    Console.Write("Eskenar Dortgenin dolumunu değiştirmek istiyor musunuz? (true/false) : ");
                                    bool yeniDolumDurumu = Convert.ToBoolean(Console.ReadLine());
                                    eskenarDortgen.SetDoluMu(yeniDolumDurumu);
                                    Console.WriteLine("Dolum durumu güncellendi!\n");
                                    break;
                                case 7:
                                    Console.WriteLine("\n" + eskenarDortgen.OzellikYazdir() + "\n");
                                    break;

                                case 8:
                                    
                                    break;
                                case 9:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Geçersiz seçenek!");
                                    break;
                            }
                        } while (secim != 8 && secim != 9); // 9 veya 10 seçilene kadar döngüyü sürdür
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
