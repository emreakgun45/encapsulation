using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.SoyIsim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriGetir();

            ogrenci.SinifAtlat();

            ogrenci.OgrenciBilgileriGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);

            ogrenci1.OgrenciBilgileriGetir();

            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyIsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get {return isim;}  
            set {isim = value;}
        }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set  
            {
                if (value < 1)
                {
                    System.Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif=1;
                }
                else
                {
                    sinif = value;
                }
            } 
            
        }


        public Ogrenci(string ısim, string soyIsim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            SoyIsim = soyIsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }


        public Ogrenci(){}

        public void OgrenciBilgileriGetir()
        {
            System.Console.WriteLine("********** Öğrenci Bilgileri **********");
            System.Console.WriteLine("Öğrenci Adı       :{0}",this.Isim);
            System.Console.WriteLine("Ögrenci Soyadı    :{0}",this.SoyIsim);
            System.Console.WriteLine("Öğrenci No        :{0}",this.OgrenciNo);
            System.Console.WriteLine("Öğrenci Sınıfı    :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif+1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif-1;
        }

    }    
}
