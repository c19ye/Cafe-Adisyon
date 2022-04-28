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
    class Personel
    {
        #region Veritabanındaki Personel Bilgilerini çekme ve personel propertilerine aktarma
       Connect _connect = new Connect();
        public void personelgetir(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from Personeller ", sqlConnection);


            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Personel personel = new Personel();
                personel.personelid = Convert.ToInt32(dataReader["id"]);
                personel.personelgörevid = Convert.ToInt32(dataReader["gorevid"]);
                personel.personelad = Convert.ToString(dataReader["ad"]);
                personel.personelsoyad = Convert.ToString(dataReader["soyad"]);
                personel.personelsifre = Convert.ToInt32(dataReader["parola"]);
                personel.personeldurum = Convert.ToBoolean(dataReader["durum"]);
                personel.personelkadi = Convert.ToString(dataReader["kullaniciadi"]);
                comboBox.Items.Add(personel);
            }
            dataReader.Close();
            sqlConnection.Close();



        }
        public void personelgetirlb(ListBox PListBox)
        {
            PListBox.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from Personeller ", sqlConnection);


            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Personel personel = new Personel();
                personel.personelid = Convert.ToInt32(dataReader["id"]);
                personel.personelgörevid = Convert.ToInt32(dataReader["gorevid"]);
                personel.personelad = Convert.ToString(dataReader["ad"]);
                personel.personelsoyad = Convert.ToString(dataReader["soyad"]);
                personel.personelsifre = Convert.ToInt32(dataReader["parola"]);
                personel.personeldurum = Convert.ToBoolean(dataReader["durum"]);
                personel.personelkadi = Convert.ToString(dataReader["kullaniciadi"]);
                PListBox.Items.Add(personel);
            }
            dataReader.Close();
            sqlConnection.Close();



        }

        public void personelgetir()
        {
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from Personeller ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Personel personel = new Personel();
                personel.personelid = Convert.ToInt32(dataReader["id"]);
                personel.personelgörevid = Convert.ToInt32(dataReader["gorevid"]);
                personel.personelad = Convert.ToString(dataReader["ad"]);
                personel.personelsoyad = Convert.ToString(dataReader["soyad"]);
                personel.personelsifre = Convert.ToInt32(dataReader["parola"]);
                personel.personeldurum = Convert.ToBoolean(dataReader["durum"]);
                personel.personelkadi = Convert.ToString(dataReader["kullaniciadi"]);
                
                
            }
            dataReader.Close();
            sqlConnection.Close();



        }
        #endregion
        

        public void personelguncelle()
        {
            PersonelKayit personelKayit = new PersonelKayit();
            
            
            //string kayit = "update personeller set ad = '" + personelKayit.tbAd.Text + "',kullaniciadi = '" + personelKayit.tbKadi.Text + "',gorevid = '" + personelKayit.tbGorev.Text + "',soyad = '" + personelKayit.tbSoyad.Text + "',parola = '" + personelKayit.tbParola.Text + "' where ID = " + personelKayit.tbid.Text + "";
            
        }

        #region Personellerin Propertileri
        public int personelid;
        public int personelgörevid;
        public string personelad;
        public string personelsoyad;
        public int personelsifre;
        public string personelkadi;
        public bool personeldurum;

        public int Personelid
        {
            get { return personelid; }
            set { personelid = value; }
        }

        public int Personelgörevid
        {
            get { return personelgörevid; }
            set { personelgörevid = value; }
        }

        public string Personelad
        {
            get { return personelad; }
            set { personelad = value; }
        }

        public string Personelsoyad
        {
            get { return personelsoyad; }
            set { personelsoyad = value; }
        }

        public int Personelsifre
        {
            get { return personelsifre; }
            set { personelsifre = value; }
        }

        public string Personelkadi
        {
            get { return personelkadi; }
            set { personelkadi = value; }
        }

        public bool Personeldurum
        {
            get { return personeldurum; }
            set { personeldurum = value; }
        }
        #endregion



        

        #region Comboxtan seçilen personel bilgilerin şifreyle eşleşmesi
        public bool personelgir(int password, int id)
        {
            bool cikis = false;

            SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            SqlCommand sqlCommand = new SqlCommand("Select * from Personeller where id=@Id and parola=@password", sqlConnection);
            sqlCommand.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
            sqlCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                cikis = Convert.ToBoolean(sqlCommand.ExecuteScalar());
            }
            catch (SqlException SqlException)
            {
                string expec = SqlException.Message;
                throw;
            }

            return cikis;
        } 
        #endregion
        #region Comboboxa Personellerin Nasıl Yazılacağı
        public override string ToString()
        {
            return Personelad + " " + Personelsoyad;
        } 
        #endregion


        





    }
}
