using System;
using librarysoft.Dal;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarysoft.Bul
{
    public static class Bul
    {
        //----------------------------Getir basla------------------------
        internal static DataSet uyeGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.uyeGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static DataSet kitapGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.kitapGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static DataSet oduncGetir()
        {
            try
            {
                DataSet ds = DataLayer.oduncGetir();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return null;
            }
        }

        //----------------------------Getir Son------------------------

        //---------------------------Ekleme başla----------------------

        public static bool UyeEkle(uyeler u)
        {
            try
            {
                int res = DataLayer.UyeEkle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool KitapEkle(kitaplar k)
        {
            try
            {
                int res = DataLayer.KitapEkle(k);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OduncEkle(odunc o)
        {
            try
            {
                int res = DataLayer.OduncEkle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        //----------------------Ekleme Son --------------------------

        //----------------------- Silme Başla -----------------------

        internal static bool UyeSil(string id)
        {
            try
            {
                int res = DataLayer.UyeSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool KitapSil(string id)
        {
            try
            {
                int res = DataLayer.KitapSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OduncSil(string id)
        {
            try
            {
                int res = DataLayer.OduncSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        //------------------------ Silme Son--------------------------------

        //-------------------------- Guncelleme -------------------------------

        internal static bool UyeGuncelle(uyeler u)
        {
            try
            {
                int res = DataLayer.UyeGuncelle(u);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OduncGuncelle(odunc o)
        {
            try
            {
                int res = DataLayer.OduncGuncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

    }
}
