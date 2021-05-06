
public void doktor_ekle(int d_id, string isim, string soyisim, int k_id)
{
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut = "INSERT INTO Doktor SET" +
                        "D_ID = '" + d_id + "'," +
                        "K_ID = '" + k_id + "'," +
                        "Isim = '" + isim + "'," +
                        "Soyisim = '" + soyisim + "'";
        MySqlCommand mySqlCommand = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (mySqlCommand.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Doktor ekleme işlemi başarılı.");
        }
        else
        {
            MessageBox.Show("Doktor ekleme işlemi başarısız!!!");
        }
        baglanti.Close();
    }
    catch (System.Exception)
    {
        MessageBox.Show("Doktor ekleme işlemi exception oluşturdu!!!İşlem başarısız!!!");
        throw;
    }
}

public void doktor_sil(int d_id)
{
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut = "DELETE from Doktor where" +
                        "D_ID = '" + d_id + "'";
        MySqlCommand mySqlCommand = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (mySqlCommand.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Doktor silme işlemi başarılı.");
        }
        else
        {
            MessageBox.Show("Doktor silme işlemi başarısız!!!");
        }
        baglanti.Close();
    }
    catch (System.Exception)
    {
        MessageBox.Show("Doktor silme işlemi exception oluşturdu!!!İşlem başarısız!!!");
        throw;
    }
}

public void rapor_ekle(int h_id, string isim, string soyisim, string TC, string rapor_metni, string tedavi)
{
    string rapor =  "TC         = " + TC + "\n" +
                    "İsim       = " + isim + "\n" +
                    "Soyisim    = " + soyisim + "\n" +
                    "Tedavi     = " + tedavi + "\n\n" +
                    rapor_metni;
    string rapor_path;
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut = "SELECT h.Rapor_Path from Hasta h where h.H_ID = '" + h_id + "'";
        baglanti.Open();
        MySqlCommand cmd = new MySqlCommand(komut);
        int Count = Convert.ToInt32(cmd.ExecuteScalar());

        if (Count != 0)
        {
            MySqlDataReader oku = cmd.ExecuteReader();
            rapor_path = oku["Rapor_Path"].ToString();
        }
        baglanti.Close();
    }
    catch (System.Exception)
    {
        MessageBox.Show("Rapor ekleme işlemi exception oluşturdu!!!İşlem başarısız!!!");
        throw;
    }

    //pdf olusturan kutuphane yuklenince ilgili fonksiyon cagrilacak.
}

public void recete_ekle(int r_id, string recete)
{
    string TC;
    string isim;
    string soyisim;
    string recete_path;
    int h_id;
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        baglanti.Open();
        string komut = "SELECT r.H_ID from Randevu r where r.R_ID = '" + r_id + "'";
        MySqlCommand cmd = new MySqlCommand(komut);
        int Count = Conver.ToInt32(cmd.ExecuteScalar());
        
        if(Count != 0)
		{
            MySqlDataReader oku = cmd.ExecuteReader();
            h_id = oku["H_ID"].ToString();

            komut = "SELECT * from Hasta h where h.H_ID = '" + h_id + "'";
            cmd = new MySqlCommand(komut);
            Count = Convert.ToInt32(cmd.ExecuteScalar());

            if (Count != 0)
            {
                MySqlDataReader oku = cmd.ExecuteReader();
                TC = oku["TC_No"].ToString();
                isim = oku["Isim"].ToString();
                soyisim = oku["Soyisim"].ToString();
                recete_path = oku["Recete_Path"].ToString();
            }
		}

        baglanti.Close();
    }
    catch (System.Exception)
    {
        MessageBox.Show("Recete ekleme işlemi exception oluşturdu!!!İşlem başarısız!!!");
        throw;
    }

    string recete = "TC         = " + TC + "\n" +
                    "İsim        = " + isim + "\n" +
                    "Soyisim     = " + soyisim + "\n\n" +
                    "Reçete      = " + recete;
	if (!string.IsNullOrEmpty(TC))
	{
        //pdf olusturan kutuphane yuklenince ilgili fonksiyon cagrilacak.
	}
}
