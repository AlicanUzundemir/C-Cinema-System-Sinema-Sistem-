using System;

namespace SinemaUygulamasiG012
{
    class Sinema
    {
        public string FilmAdi { get; set; }
        public int Kapasite { get; }
        public int TamBiletFiyati { get; }
        public int YarimBiletFiyati { get; }
        public int ToplamTamBiletAdedi { get; private set; }
        public int ToplamYarimBiletAdedi { get; private set; }
        public int Ciro
        {
            get
            {
                return (this.ToplamTamBiletAdedi * this.TamBiletFiyati) + (this.ToplamYarimBiletAdedi * this.YarimBiletFiyati);

            }
        }

        public int BosKoltuk
        {
            get
            {
                return this.Kapasite - this.ToplamTamBiletAdedi - this.ToplamYarimBiletAdedi;
            }
        }


        public Sinema(string filmAdi, int kapasite, int tamBiletFiyati, int yarimBiletFiyati)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tamBiletFiyati;
            this.YarimBiletFiyati = yarimBiletFiyati;
        }
        public void BiletSat(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (this.BosKoltukAdediGetir() >= (tamBiletAdedi + yarimBiletAdedi))
            {
                this.ToplamTamBiletAdedi += tamBiletAdedi;
                this.ToplamYarimBiletAdedi += yarimBiletAdedi;
                // CiroHesapla();
                Console.WriteLine("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("Yeterli boş koltuk yok.");
            }
        }

        public void BiletIade(int tamBiletAdedi, int yarimBiletAdedi)
        {
            if (this.ToplamTamBiletAdedi >= tamBiletAdedi && this.ToplamYarimBiletAdedi >= yarimBiletAdedi)
            {
                this.ToplamTamBiletAdedi -= tamBiletAdedi;
                this.ToplamYarimBiletAdedi -= yarimBiletAdedi;
                //CiroHesapla();

                Console.WriteLine("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("Geçersiz bilet adedi.");
            }
        }

        public int BosKoltukAdediGetir()
        {
            return this.Kapasite - this.ToplamTamBiletAdedi - this.ToplamYarimBiletAdedi;

        }



        //private void CiroHesapla()
        //{
        //    // this.Ciro = (this.ToplamTamBiletAdedi * this.TamBiletFiyati) + (this.ToplamYarimBiletAdedi * this.YarimBiletFiyati);
        //}



    }
}
