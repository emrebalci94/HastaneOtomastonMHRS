using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HastaneOtomasyon
{
    class KontrolIslemleri
    {
       
        public static bool TcKontrol(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Hasta h = mhrs.Hasta.Where(t => t.Tc == tc && t.IsDeleted==null).FirstOrDefault();
            Personel p = mhrs.Personel.Where(t => t.Tc == tc && t.IsDeleted==null).FirstOrDefault();
            if (h==null && p==null)
            {
                return true;
            }
            return false;
        }

        public static Hasta HastaGiris(string tc,string sifre)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Hasta h = mhrs.Hasta.Where(t => t.Tc == tc && t.Password==sifre && t.IsDeleted==null).FirstOrDefault();
            return h;
        }

        public static Personel PersonelAra(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Personel p = mhrs.Personel.Where(t => t.Tc == tc && t.IsDeleted == null).FirstOrDefault();
            return p;
        }

        public static Personel DoktorGiris(string tc,string sifre)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Personel p = mhrs.Personel.Where(t => t.Tc == tc &&t.Sifre==sifre && t.PersonelTipId==1 && t.IsDeleted == null).FirstOrDefault();
            return p;
        }

        public static bool DoktorRandevuUygunluk(int personelId,DateTime tarih)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            var p = mhrs.PersonelIzin.Where(t => t.PersonelId==personelId && tarih>=t.StartDate && tarih<=t.EndDate && t.Personel.PersonelTipId == 1 && t.IsDeleted == null).FirstOrDefault();
            if (p!=null)
            {
                return  false;
            }
            else
            {
                return true;
            }              
        }

        public static bool RandevuSaatUygunluk(string saat, DateTime tarih, int doktorId)
        {
            string tarihs = tarih.ToShortDateString();
            tarih = DateTime.Parse(tarihs);
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            var r = mhrs.Randevu.Where(p => p.PersonelId == doktorId && p.RandevuSaati == saat && p.RandevuTarihi.Value==tarih ).FirstOrDefault();
            if (r==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RandevuSaatveHastaUygunluk(string saat, DateTime tarih, int doktorId,int hastaId)
        {
            string tarihs = tarih.ToShortDateString();
            tarih = DateTime.Parse(tarihs);
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            var r = mhrs.Randevu.Where(p => p.PersonelId == doktorId &&p.HastaId==hastaId && p.RandevuTarihi.Value == tarih).FirstOrDefault();
            if (r == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Recete HastaReceteBul(int personelId,int hastaId)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Recete.Where(p => p.HastaId == hastaId && p.PersonelId == personelId).OrderBy(p => p.CreateDate).FirstOrDefault();
        }

        public static Hasta HastaBul(string Tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            return mhrs.Hasta.Where(p => p.Tc == Tc && p.IsDeleted == null).FirstOrDefault();
        }

        public static bool DoktorIzinUygunluk(int doktorId,DateTime baslangic,DateTime bitis)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();

            var saatVarmi = (mhrs.Randevu.Where(p => p.PersonelId == doktorId && p.RandevuTarihi >= baslangic && p.RandevuTarihi <= bitis && p.IsDeleted == null)).ToList();
            var personelIzinVarmi = (mhrs.PersonelIzin.Where(p => p.PersonelId == doktorId && p.EndDate >= baslangic && p.IsDeleted == null)).ToList();
            if ( personelIzinVarmi.Count > 0)
            {
                return false;
            }
            if (saatVarmi.Count > 0 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string DoktorIdDon(string tc)
        {
            MhrsDBEntitiess mhrs = new MhrsDBEntitiess();
            Personel p = mhrs.Personel.FirstOrDefault(t => t.Tc == tc);
            return p.PersonelId.ToString();
        }
    }
}
