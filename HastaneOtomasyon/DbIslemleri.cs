using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon
{
    class DbIslemleri
    {
       
        public static void HastaKaydet(Hasta h)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            mhrs.Hasta.Add(h);
            mhrs.SaveChanges();
        }
        public static void PersonelKayit(Personel p)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            mhrs.Personel.Add(p);
            mhrs.SaveChanges();
        }
 
        public static void PersonelSil(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Personel p = mhrs.Personel.FirstOrDefault(t => t.Tc == tc && t.IsDeleted == null);
            p.IsDeleted = true;
            mhrs.SaveChanges();
        }
        public static void PersonelGuncelle(string tc,string ad,string soyad,int personelTip,string resimYol,string sifre)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Personel p = mhrs.Personel.FirstOrDefault(t => t.Tc==tc && t.IsDeleted == null);
            p.Ad = ad;
            p.Soyad = soyad;
            p.PersonelTipId = personelTip;
            p.FotoPath = resimYol;
            p.Sifre = sifre;
            mhrs.SaveChanges();
        }

        public static void HastaGuncelle(Hasta h)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Hasta ha = mhrs.Hasta.Where(p => p.HastaId == h.HastaId && p.IsDeleted!=true).FirstOrDefault();
            ha.Ad = h.Ad;
            ha.Soyad = h.Soyad;
            ha.DogumTarihi = h.DogumTarihi;
            ha.Password = h.Password;
            mhrs.SaveChanges();
        }
        public static void RandevuEkle(Randevu r)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            mhrs.Randevu.Add(r);
            mhrs.SaveChanges();
        }

        public static void ReceteEkle(Recete r)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            mhrs.Recete.Add(r);
            mhrs.SaveChanges();
        }

        public static void ReceteGuncelle(Recete r)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Recete re = mhrs.Recete.Where(p => p.ReceteId == r.ReceteId).FirstOrDefault();
            re.Teshis = r.Teshis;
            re.Durum = r.Durum;
            mhrs.SaveChanges();
        }

        public static void IlacEkle(Ilaclar i)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            mhrs.Ilaclar.Add(i);
            mhrs.SaveChanges();
        }

        public static void ReceteIlacEKle(ReceteIlac i)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
          ReceteIlac bak=   mhrs.ReceteIlac.Where(p => p.IlacId == i.IlacId && p.ReceteId == i.ReceteId).FirstOrDefault();
            if (bak==null)
            {
                mhrs.ReceteIlac.Add(i);
                mhrs.SaveChanges();
            }
           
        }

        public static void DoktorProfilGuncelle(Personel p)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Personel pa = mhrs.Personel.FirstOrDefault(t => t.IsDeleted != true && t.Tc == p.Tc);
            pa.Ad = p.Ad;
            pa.Soyad = p.Soyad;
            pa.FotoPath = p.FotoPath;
            pa.Sifre = p.Sifre;
            mhrs.SaveChanges();
        }

        public static void DoktorIzinVer(PersonelIzin i)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            mhrs.PersonelIzin.Add(i);
            mhrs.SaveChanges();
        }
    }
}
