using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading.Tasks;


namespace TestFrm
{
    class DataSql
    {
        public static int EskiBorclariTabloyaAt(string plakaNo, DateTime tarih, DateTime girisSaat, DateTime cikisSaat, int bolgeId, int kulId, int tmmKullId, float ucret, int ucretsizMi, int iptalNedenId, int peronId, string cihazSeriNo, int fiyatTipiId, string plakaTipi, DateTime gercekCikisSaati, string hucreNo, int kaldigiDakika, string merkezKayitNo, string odemeTipi, int beklemedk, string takip, string islemTipi, int bolgeKontrol, string pilDurumu, int kalanDakika, int kacakOdenenBolgeId, int kacakKalanKullId, int kacakYakalanmaSayisi, int icra)
        {
            string sql = "Insert Into  dbo.BT_Hareketler(PLAKANO,TARIH,GIRISSAAT,CIKISSAAT,BOLGEID,KULLANICIID,TMMKULLID,UCRET,UCRETSIZMI,IPTALNEDENID,PERONID,CIHAZSERINO,FIYATTIPID,PLAKATIPI,GERCEKCIKISSAATI,HUCRENO,KALDIGIDAKIKA,ODEMETIPI,BEKLEMEDK,TAKIP,ISLEMTIPI,BOLGEKONTROL,PILDURUMU,KALANDAKIKA,KACAKODEMETARIHI,KACAKODENENBOLGEID,KACAKALANKULLID,KACAKYAKALANMASAYISI,ICRA) VALUES (@PLAKANO,@TARIH,@GIRISSAAT,@CIKISSAAT,@BOLGEID,@KULLANICIID,@TMMKULLID,@UCRET,@UCRETSIZMI,@IPTALNEDENID,@PERONID,@CIHAZSERINO,@FIYATTIPID,@PLAKATIPI,@GERCEKCIKISSAATI,@HUCRENO,@KALDIGIDAKIKA,@ODEMETIPI,@BEKLEMEDK,@TAKIP,@ISLEMTIPI,@BOLGEKONTROL,@PILDURUMU,@KALANDAKIKA,@KACAKODENENBOLGEID,@KACAKALANKULLID,@KACAKYAKALANMASAYISI,@ICRA)";
            DbManager2 dbManager2 = new DbManager2();

            dbManager2.DataCommand2.Parameters.Add("@PLAKANO", SqlDbType.VarChar).Value = plakaNo;
            dbManager2.DataCommand2.Parameters.Add("@TARIH", SqlDbType.DateTime).Value = tarih;
            dbManager2.DataCommand2.Parameters.Add("@GIRISSAAT", SqlDbType.DateTime).Value = girisSaat;
            dbManager2.DataCommand2.Parameters.Add("@CIKISSAAT", SqlDbType.DateTime).Value = cikisSaat;
            dbManager2.DataCommand2.Parameters.Add("@BOLGEID", SqlDbType.Int).Value = bolgeId;
            dbManager2.DataCommand2.Parameters.Add("@KULLANICIID", SqlDbType.Int).Value = kulId;
            dbManager2.DataCommand2.Parameters.Add("@TMMKULLID", SqlDbType.Int).Value = tmmKullId;
            dbManager2.DataCommand2.Parameters.Add("@UCRET", SqlDbType.Float).Value = ucret;
            dbManager2.DataCommand2.Parameters.Add("@UCRETSIZMI", SqlDbType.Int).Value = ucretsizMi;
            dbManager2.DataCommand2.Parameters.Add("@IPTALNEDENID", SqlDbType.Int).Value = iptalNedenId;
            dbManager2.DataCommand2.Parameters.Add("@PERONID", SqlDbType.Int).Value = peronId;
            dbManager2.DataCommand2.Parameters.Add("@CIHAZSERINO", SqlDbType.VarChar).Value = cihazSeriNo;
            dbManager2.DataCommand2.Parameters.Add("@FIYATTIPID", SqlDbType.Int).Value = fiyatTipiId;
            dbManager2.DataCommand2.Parameters.Add("@PLAKATIPI", SqlDbType.VarChar).Value = plakaTipi;
            dbManager2.DataCommand2.Parameters.Add("@GERCEKCIKISSAATI", SqlDbType.DateTime).Value = gercekCikisSaati;
            dbManager2.DataCommand2.Parameters.Add("@HUCRENO", SqlDbType.VarChar).Value = hucreNo;
            dbManager2.DataCommand2.Parameters.Add("@KALDIGIDAKIKA", SqlDbType.Int).Value = kaldigiDakika;
            //dbManager2.DataCommand2.Parameters.Add("@MERKEZKAYITNO",SqlDbType.VarChar).Value=merkezKayitNo;
            dbManager2.DataCommand2.Parameters.Add("@ODEMETIPI", SqlDbType.VarChar).Value = odemeTipi;
            dbManager2.DataCommand2.Parameters.Add("@BEKLEMEDK", SqlDbType.Int).Value = beklemedk;
            dbManager2.DataCommand2.Parameters.Add("@TAKIP", SqlDbType.VarChar).Value = takip;
            dbManager2.DataCommand2.Parameters.Add("@ISLEMTIPI", SqlDbType.VarChar).Value = islemTipi;
            dbManager2.DataCommand2.Parameters.Add("@BOLGEKONTROL", SqlDbType.Int).Value = bolgeKontrol;
            dbManager2.DataCommand2.Parameters.Add("@PILDURUMU", SqlDbType.Int).Value = pilDurumu;
            dbManager2.DataCommand2.Parameters.Add("@KALANDAKIKA", SqlDbType.Int).Value = kalanDakika;
            dbManager2.DataCommand2.Parameters.Add("@KACAKODENENBOLGEID", SqlDbType.Int).Value = kacakOdenenBolgeId;
            dbManager2.DataCommand2.Parameters.Add("@KACAKALANKULLID", SqlDbType.Int).Value = kacakKalanKullId;
            dbManager2.DataCommand2.Parameters.Add("@KACAKYAKALANMASAYISI", SqlDbType.Int).Value = kacakYakalanmaSayisi;
            dbManager2.DataCommand2.Parameters.Add("@ICRA", SqlDbType.Int).Value = icra;

            return dbManager2.KomutCalistir(sql);
        }

        public static DataTable testHareketTabloGetir()
        {
            string sql = "select * from dbo.BT_Hareketler";
            DbManager2 dbManager2 = new DbManager2();
            return dbManager2.GetDataTable2(sql);
        }

        public static int EkleHareketlerPlakaTaksitUcret(string plakaNo, float ucret)
        {
            string sql = "insert into dbo.BT_Hareketler(PLAKANO,UCRET,BOLGEID) VALUES (@PLAKANO,@UCRET,@BOLGEID)";
            DbManager2 dbManager2 = new DbManager2();
            dbManager2.DataCommand2.Parameters.Add("@PLAKANO", SqlDbType.VarChar).Value = plakaNo;
            dbManager2.DataCommand2.Parameters.Add("@UCRET", SqlDbType.Float).Value = ucret;
            dbManager2.DataCommand2.Parameters.Add("@BOLGEID", SqlDbType.Int).Value = 85478;
            return dbManager2.KomutCalistir(sql);
        }

        public static void EkleHareketlerPlakaTaksitUcret(List<Ucret> list)
        {
            DbManager2 dbManager = new DbManager2();
            string sql = "insert into dbo.BT_Hareketler(PlakaNo, Ucret, BolgeID) VALUES (@PlakaNo, @Ucret, @BolgeID)";
            dbManager.DataCommand2.Parameters.Add("@PlakaNo", SqlDbType.VarChar);
            dbManager.DataCommand2.Parameters.Add("@Ucret", SqlDbType.Float);
            dbManager.DataCommand2.Parameters.Add("@BolgeID", SqlDbType.Int).Value = 85478;
            for (int i = 0; i < list.Count; i++)
            {
                dbManager.DataCommand2.Parameters["@PlakaNo"].Value = list[i].Plaka;
                dbManager.DataCommand2.Parameters["@Ucret"].Value = list[i].Fiyat;
                dbManager.KomutCalistir(sql);
            }
        }

    }
}
