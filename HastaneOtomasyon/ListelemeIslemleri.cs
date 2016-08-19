using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Collections;
namespace HastaneOtomasyon
{
    class ListelemeIslemleri
    {
        public static void personelTipComboDoldur(ComboBox c)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            c.DataSource = mhrs.PersonelTip.Select(p => new { p.PersonelTipId, p.Ad }).ToList();
            c.ValueMember = "PersonelTipId";
            c.DisplayMember = "Ad";
        }
        public static object  personelTcArama( string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return  mhrs.Personel.Where(p => p.Tc.Contains(tc) && p.IsDeleted==null).Select(p => new { TC=p.Tc, AD=p.Ad, SOYAD=p.Soyad, PERSONELTİP = p.PersonelTip.Ad, KAYIT_TARİHİ=p.CreateDate }).ToList();
        }

        public static object personelAdArama(string ad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Personel.Where(p => p.Ad.Contains(ad) && p.IsDeleted == null).Select(p => new { TC = p.Tc, AD = p.Ad, SOYAD = p.Soyad, PERSONELTİP = p.PersonelTip.Ad, KAYIT_TARİHİ = p.CreateDate }).ToList();
        }

        public static object personelSoyadArama(string soyad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Personel.Where(p => p.Soyad.Contains(soyad) && p.IsDeleted == null).Select(p => new { TC = p.Tc, AD = p.Ad, SOYAD = p.Soyad, PERSONELTİP = p.PersonelTip.Ad, KAYIT_TARİHİ = p.CreateDate }).ToList();
        }
        public static void DoktorlarComboAt(ComboBox c)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            c.DataSource = mhrs.Personel.Where(t => t.IsDeleted == null && t.PersonelTipId == 1).Select(p=>new { p.PersonelId,ADSOYAD=(p.Ad+" "+p.Soyad)}).ToList();
            c.DisplayMember = "ADSOYAD";
            c.ValueMember = "PersonelId";
        }

        public static object HastaTumRandevu(int hastaId)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Randevu.Where(p => p.HastaId == hastaId).Select(p => new {DOKTOR=(p.Personel.Ad+p.Personel.Soyad),p.RandevuTarihi,p.RandevuSaati }).ToList();
        }

        public static object HastaIkıTarihRandevu(int hastaId,DateTime tarih1,DateTime tarih2)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Randevu.Where(p => p.HastaId==hastaId &&p.RandevuTarihi >tarih1 && p.RandevuTarihi<tarih2).Select(p => new { DOKTOR = (p.Personel.Ad + p.Personel.Soyad), p.RandevuTarihi, p.RandevuSaati }).ToList();
        }
        public static object HastaDoktorAdRandevu(int hastaId, string ad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Randevu.Where(p => p.HastaId == hastaId && p.Personel.Ad.Contains(ad)).Select(p => new { DOKTOR = (p.Personel.Ad + p.Personel.Soyad), p.RandevuTarihi, p.RandevuSaati }).ToList();
        }

        public static object DoktorBugunkuRandevu(int doktorId,string aranacak)
        {
            string tarihs = DateTime.Now.ToShortDateString();
            DateTime tarih = DateTime.Parse(tarihs);
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Randevu.Where(p => p.PersonelId == doktorId && p.Hasta.Ad.Contains(aranacak) && p.RandevuTarihi == tarih && p.IsDeleted==null).Select(p => new { p.Hasta.Tc, p.Hasta.Ad, p.Hasta.Soyad, p.RandevuTarihi, p.RandevuSaati }).ToList(); 
        }

        public static object DoktorGelecekRandevu(int doktorId, string aranacak)
        {
            string tarihs = DateTime.Now.ToShortDateString();
            DateTime tarih = DateTime.Parse(tarihs);
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Randevu.Where(p => p.PersonelId == doktorId && p.Hasta.Ad.Contains(aranacak)  && p.RandevuTarihi > tarih && p.IsDeleted == null).Select(p => new { p.Hasta.Tc, p.Hasta.Ad, p.Hasta.Soyad, p.RandevuTarihi, p.RandevuSaati }).ToList();
        }

        public static void IlacComboDoldur( ComboBox c)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            c.DataSource = mhrs.Ilaclar.Where(t => t.IsDeleted == false  ).Select(p => new { p.IlacId, p.Ad }).ToList();
            c.DisplayMember = "Ad";
            c.ValueMember = "IlacId";
        }
        public static object HastaAramaTc(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Hasta.Where(p => p.Tc.Contains(tc) && p.IsDeleted != true).ToList();
        }

        public static object HastaAramaAd(string ad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Hasta.Where(p => p.Ad.Contains(ad) && p.IsDeleted != true).ToList();
        }

        public static object DoktorHastam(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return  (from hasta in mhrs.Hasta where hasta.Tc == tc && hasta.IsDeleted != true join receteBilgi in mhrs.Recete on hasta.HastaId equals receteBilgi.HastaId join personel in mhrs.Personel on receteBilgi.PersonelId equals personel.PersonelId  select new { hasta.Tc, hasta.Ad, hasta.Soyad, hasta.Cinsiyet, PERSONELAD = (personel.Ad + " " + personel.Soyad), receteBilgi.Teshis, receteBilgi.CreateDate }).Take(1).ToList();

            
          //  return (from hasta in mhrs.Hasta where hasta.Tc== tc join receteBilgi in mhrs.Recete on hasta.HastaId equals receteBilgi.HastaId join personel in mhrs.Personel on receteBilgi.PersonelId equals personel.PersonelId select new { hasta.Tc, hasta.Ad, hasta.Soyad, hasta.Cinsiyet, PERSONELAD = (personel.Ad + " " + personel.Soyad), receteBilgi.Teshis, receteBilgi.CreateDate }).ToList();
        }

        public static object DoktorAdGoreArama(string ad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Personel.Where(p => p.IsDeleted == null && p.Ad.Contains(ad) && p.PersonelTipId==1).Select(p => new { p.Tc, p.Ad, p.Soyad, İşeBaşlangıçTarihi = p.CreateDate })).ToList();
        }

        public static object DoktorTcGoreArama(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Personel.Where(p => p.IsDeleted == null && p.Tc.Contains(tc) && p.PersonelTipId == 1).Select(p => new { p.Tc, p.Ad, p.Soyad, İşeBaşlangıçTarihi = p.CreateDate })).ToList();
        }

        public static object SilinmisPersoneller()
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Personel.Where(p => p.IsDeleted ==true).Select(p => new { p.Tc, p.Ad, p.Soyad, p.CreateDate ,p.Sifre, Mesleği = p.PersonelTip.Ad, p.IsDeleted }).ToList());
        }

        public static object SilinmisPersoneller( string ad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Personel.Where(p => p.IsDeleted == true && p.Ad.Contains(ad)).Select(p => new { p.Tc, p.Ad, p.Soyad, p.CreateDate, p.Sifre, Mesleği = p.PersonelTip.Ad, p.IsDeleted }).ToList());
        }
        public static object TumPersoneller(string ad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Personel.Where(p => p.Ad.Contains(ad)).Select(p=>new { p.Tc,p.Ad,p.Soyad,p.CreateDate,p.Sifre, Mesleği = p.PersonelTip.Ad, p.IsDeleted }).ToList());
        }
        public static object TumPersonellerTc(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Personel.Where(p => p.Tc.Contains(tc)).Select(p => new { p.Tc, p.Ad, p.Soyad, p.CreateDate, p.Sifre, Mesleği = p.PersonelTip.Ad, p.IsDeleted }).ToList());
        }
        public static object PersonelTipineGore(string tipAdi)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Personel.Where(p =>  p.PersonelTip.Ad.Contains(tipAdi)).Select(p => new { p.Tc, p.Ad, p.Soyad, p.CreateDate, p.Sifre,Mesleği=p.PersonelTip.Ad,p.IsDeleted }).ToList());
        }

        public static object HastaRaporAl(string ad)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Hasta.Where(p => p.Ad.Contains(ad) && p.IsDeleted == null).Select(p => new { p.Tc, p.Ad, p.Soyad, p.DogumTarihi, p.CreateDate, p.Password })).ToList();
        }
        public static object HastaRaporAlTc(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return (mhrs.Hasta.Where(p => p.Tc.Contains(tc) && p.IsDeleted == null).Select(p => new { p.Tc, p.Ad, p.Soyad, p.DogumTarihi, p.CreateDate, p.Password })).ToList();
        }
    }
}   
