using System;

namespace SinemaUygulamasiG012
{
    class Uygulama
    {
        Sinema Salon;
        public void Calistir()
        {


            Kurulum();
            Menu();
            while (true)
            {
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine().ToUpper();
                Console.WriteLine();
                switch (secim)
                {
                    case "1":
                        BiletSat();
                        break;
                    case "2":
                        BiletIade();
                        break;
                    case "3":
                        DurumBilgisi();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine();
            }





        }

        public void Menu()
        {
            Console.WriteLine("1 - Bilet Sat(S)     ");
            Console.WriteLine("2 - Bilet İade(İ)    ");
            Console.WriteLine("3 - Durum Bilgisi(D) ");
            Console.WriteLine("4 - Çıkış(X)         ");
            Console.WriteLine();
        }

        public void Kurulum()
        {
            Console.WriteLine("-----------  ******** Sinema Salonu ********  -------------");
            Console.WriteLine("------Film Adı,Kapasitesi ve Bilet Fiyatları Girisi--------");
            Console.Write("Film adı: ");
            string ad = Console.ReadLine();
            Console.Write("Kapasite: ");
            int kap = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı: ");
            int tam = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı: ");
            int yarim = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Salon.FilmAdi = ad;
            //Salon.Kapasite = kap;
            //Salon.TamBiletFiyati = tam;
            //Salon.YarimBiletFiyati = yarim;
            Salon = new Sinema(ad, kap, tam, yarim);


        }


        public void BiletSat()
        {
            Console.WriteLine("Bilet Sat:");
            Console.Write("Tam Bilet Adedi: ");
            int tam = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi: ");
            int yarim = int.Parse(Console.ReadLine());
            Salon.BiletSat(tam, yarim);

        }



        public void BiletIade()
        {
            Console.WriteLine("Bilet İade:");
            Console.Write("Tam Bilet Adedi: ");
            int tam = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi: ");
            int yarim = int.Parse(Console.ReadLine());
            Salon.BiletIade(tam, yarim);
        }
        public void DurumBilgisi()
        {


            Console.WriteLine("Durum Bilgisi");
            Console.WriteLine("Film : " + Salon.FilmAdi);
            Console.WriteLine("Kapasite : " + Salon.Kapasite);
            Console.WriteLine("Tam Bilet Fiyatı : " + Salon.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı : " + Salon.YarimBiletFiyati);
            Console.WriteLine("Tam Bilet Adedi : " + Salon.ToplamTamBiletAdedi);
            Console.WriteLine("Yarım Bilet Adedi : " + Salon.ToplamYarimBiletAdedi);
            Console.WriteLine("Ciro : " + Salon.Ciro);
            Console.WriteLine("Boş Koltuk Adedi : " + Salon.BosKoltukAdediGetir());



        }

    }
}
