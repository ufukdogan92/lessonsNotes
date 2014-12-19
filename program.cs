using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace ConsoleApplication1
{
	
	class OgrenciHesap{
		
		public void HataVer(int herhangibinot,string tur)
		{
			string tur_txt;
			if(tur == "v")tur_txt="Vize";
			else tur_txt = "Final";
			
			if (herhangibinot < 0 || herhangibinot > 100)                
                    Console.WriteLine(tur_txt+" Notu Hatalı Girildi Lütfen Tekrar Giriniz"); 
			
		}//hataver
		
		public void OrtalamaSonuc(double notOrt)
			
		{		
			if  (notOrt<60)
      			{
            		Console.WriteLine("Kaldınız");                    
				 } else{
                    Console.WriteLine("Geçtiniz");
                }	
			 
		}//ortalama sonucu metodu
	
		public double NotOrtalama(int notvize, int notfinal)
			
		{
			double sonuc;
			sonuc = (notvize * 0.4) + (notfinal * 0.6);
			return sonuc;
	}//not ortalama
  }//ogrencihesap sınıfı

	class _Sinif{
		
		public int MevcutVer(){			
			Console.WriteLine("Sınıf Mevcudunu giriniz:");
           int  i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam " + i + " öğreninin notu girilecek");
            return i;
		}//sınıfmevcudu clası
		
	 
		public void OgrenciListele(string[] OgrenciAdlari, int[] VizeNotlari,int[] FinalNotlari,double[] Ortalama){
			int e_sayisi = OgrenciAdlari.Length;
			Console.WriteLine(" ####### NOT HESAP LİSTESİ ####### ");
			for(int e=0; e < e_sayisi; e++){
				string OAdi = OgrenciAdlari[e];
				int VNot = VizeNotlari[e];
				int FNot = FinalNotlari[e];
				double ORT  = Ortalama[e];
				
				Console.WriteLine((e+1)+". Öğrencinin  ADI: " + OAdi + " , Vizesi: "+VNot +", Finali: "+FNot+ ", Ortalaması:"+ORT);
				
			}
			
			
		}
		
		
	}//sinif classı
	
    class Program
    {
        static void Main(string[] args)
        {
        	OgrenciHesap hesapla = new OgrenciHesap();
            _Sinif sinif = new _Sinif();
            
            
            int  j, vize, final;
            double sonuc;
            string ogrenciAdi;	
            int mevcut_sayisi = sinif.MevcutVer();
            
            
            	
            
            string[] OgrenciAdlari 	= new string[mevcut_sayisi];
            int[] VizeNotlari 		= new int[mevcut_sayisi];
 			int[] FinalNotlari 		= new int[mevcut_sayisi];
 			double[] Ortalama 		= new double[mevcut_sayisi];
            	
            	
           
            for (j = 0; j < mevcut_sayisi; j++)
            {
            	Console.WriteLine((j+1)+". Öğrencinin Adını giriniz");
                 ogrenciAdi = (Console.ReadLine());
                 
                Console.WriteLine((j+1)+". Öğrencinin Vize Notunu Girin");
                vize = Convert.ToInt32(Console.ReadLine());
                hesapla.HataVer(vize,"v");// eğer not yanlış ise hata ver
          

                Console.WriteLine((j+1)+". Final Notunu Girin");
                final = Convert.ToInt32(Console.ReadLine());
                hesapla.HataVer(final,"f");// eğer not yanlış ise hata ver

                sonuc = hesapla.NotOrtalama(vize,final);//not ortalaması hesapla
                Console.WriteLine((j+1)+". Öğrencinin Not Ortalaması= "+sonuc);
                hesapla.OrtalamaSonuc(sonuc);
                
               OgrenciAdlari[j] 	= ogrenciAdi;
               VizeNotlari[j] 		= vize;
               FinalNotlari[j] 	= final;
               Ortalama[j] 		= sonuc;
                
               
            }//for
            //
            sinif.OgrenciListele(OgrenciAdlari,VizeNotlari,FinalNotlari, Ortalama);
            
            
            
             Console.ReadLine();
        }
        
        }
    }
                
