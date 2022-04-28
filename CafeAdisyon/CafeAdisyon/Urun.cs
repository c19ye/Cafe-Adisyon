using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CafeAdisyon
{
    class Urun
    {
      
        
        Connect _connect = new Connect();
        #region UrunProperty
        public int kategoriid { get; set; }
        public string urunadi { get; set; }
        public int urunid { get; set; }

        public int fiyat { get; set; }
        public int durum { get; set; }
        public int fiyattoplam { get; set; }

        public int masaid { get; set; }
        public int kisisayisi { get; set; }
        public string musteriadi { get; set; }
        public int musteriid { get; set; }
        public string tarih { get; set; }
        public string tur { get; set; }
        public string Tur
        {
            get { return tur; }
            set { tur = value; }
        }
        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        public int Musteriid
        {
            get { return musteriid; }
            set { musteriid = value; }
        }
        public int Masaid
        {
            get { return masaid; }
            set { masaid = value; }
        }

        public int Kisisayisi
        {
            get { return kisisayisi; }
            set { kisisayisi = value; }
        }

        public string Musteriadi
        {
            get { return musteriadi; }
            set { musteriadi = value; }
        }

        public int Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        public int Fiyattoplam
        {
            get { return fiyattoplam; }
            set { fiyattoplam = value; }
        }

        public int Kategoriid
        {
            get { return kategoriid; }
            set { kategoriid = value; }
        }

        public int Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }

        public string Urunadi
        {
            get { return urunadi; }
            set { urunadi = value; }
        }


        public int Urunid
        {
            get { return urunid; }
            set { urunid = value; }
        }
        #endregion


        #region ÜrünGetirmeListeleme
        public void ürüngetir()
        {
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);


            }
            dataReader.Close();
            sqlConnection.Close();



        }



        public void ürüngetirlb(ListBox UListBox)
        {
            UListBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                UListBox.Items.Add(urun);


            }
            dataReader.Close();
            sqlConnection.Close();



        }
        public void ürüngetirlbb1(ListBox ListBoxürün)
        {
            ListBoxürün.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler where kategoriid=1 ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                ListBoxürün.Items.Add(urun);



            }
            dataReader.Close();
            sqlConnection.Close();



        }
        public void ürüngetirlbb2(ListBox ListBoxürün)
        {
            ListBoxürün.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler where kategoriid=2 ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                ListBoxürün.Items.Add(urun);


            }
            dataReader.Close();
            sqlConnection.Close();



        }
        public void ürüngetirlbb3(ListBox ListBoxürün)
        {
            ListBoxürün.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler where kategoriid=3 ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                ListBoxürün.Items.Add(urun);


            }
            dataReader.Close();
            sqlConnection.Close();



        }
        public void ürüngetirlbb4(ListBox ListBoxürün)
        {
            ListBoxürün.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler where kategoriid=4 ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                ListBoxürün.Items.Add(urun);


            }
            dataReader.Close();
            sqlConnection.Close();



        }
        public void ürüngetirlbb5(ListBox ListBoxürün)
        {
            ListBoxürün.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler where kategoriid=5 ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                ListBoxürün.Items.Add(urun);


            }
            dataReader.Close();
            sqlConnection.Close();



        }
        public void ürüngetirlbb6(ListBox ListBoxürün)
        {
            ListBoxürün.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from ürünler where kategoriid=6 ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                ListBoxürün.Items.Add(urun);


            }
            dataReader.Close();
            sqlConnection.Close();



        } 
        #endregion
        public override string ToString()
        {
            return Urunadi;
        }
    }
}
