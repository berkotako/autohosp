public void doktor_dept_güncelle(int doktor_id,string new_dept){
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut="update doktorlar set poliklinik =  '"+new_dept +"'where d_id = '"+doktor_id+"'";
        MySqlCommand dnl = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (dnl.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Doktor Bilgileri Başarıyla Güncellenmiştir.");
        }
        else
        {   
             MessageBox.Show("Doktor Bilgileri Güncellenememiştir.");
        }
        baglanti.Close();   
    }
    catch (System.Exception)
    {
        MessageBox.Show("Doktor Departman Guncelleme Hatası");
        throw;
    }

}

public void doktor_goster(int poliklinik_no){
    try
    {
        string komut="select * from doktorlar where poliklinik = '"+poliklinik_no+"'";
        baglanti.Open();
        MySqlDataAdapter listele = new MySqlDataAdapter(komut, baglanti);
        DataTable oku = new DataTable();
        listele.Fill(oku);
        dataGridView1.DataSource = oku;
        baglanti.Close();  
    }
    catch (System.Exception)
    {
        MessageBox.Show("Doktor Gosterme Hatası");
        throw;
    }
}

public void hasta_rapor_güncelle(string rapor){
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut="update hastalar set raport_path =  '"+rapor+"'";
        MySqlCommand dnl = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (dnl.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Hasta Raporu Başarıyla Güncellenmiştir.");
        }
        else
        {   
            MessageBox.Show("Hasta Raporu Güncellenememiştir.");
        }
        baglanti.Close(); 
        }
    catch (System.Exception)
    {
        MessageBox.Show("Hasta Rapor Guncelleme Hatası");
        throw;
    }
}

public void hasta_recete_güncelle(string recete){
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut="update hastalar set recete_path =  '"+recete+"'";
        MySqlCommand dnl = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (dnl.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Hasta Recete Başarıyla Güncellenmiştir.");
        }
        else
        {   
            MessageBox.Show("Hasta Recete Güncellenememiştir.");
        }
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Hasta Recete Guncelleme Hatası");
        throw;
    }
}

public void hasta_isim_güncelle(string isim){
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut="update hastalar set isim =  '"+isim+"'";
        MySqlCommand dnl = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (dnl.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Hasta İsmi Başarıyla Güncellenmiştir.");
        }
        else
        {   
            MessageBox.Show("Hasta ismi Güncellenememiştir.");
        }
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Hasta İsim Guncelleme Hatası");
        throw;
    }
}

public void hasta_goster(int hasta_id){
    try
    {
        string komut="select * from hastalar where h_id = '"+hasta_id+"'";
        baglanti.Open();
        MySqlDataAdapter listele = new MySqlDataAdapter(komut, baglanti);
        DataTable oku = new DataTable();
        listele.Fill(oku);
        dataGridView1.DataSource = oku;
        baglanti.Close();  
    }
    catch (System.Exception)
    {
        MessageBox.Show("Hastaları Gosterme Hatası");
        throw;
    }
}

public void randevuları_doktorait_Goster(int doktor_id){
    try
    {
        string komut="select * from randevu where d_id = '"+doktor_id+"'";
        baglanti.Open();
        MySqlDataAdapter listele = new MySqlDataAdapter(komut, baglanti);
        DataTable oku = new DataTable();
        listele.Fill(oku);
        dataGridView1.DataSource = oku;
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Randevu Doktora Ait Gosterme Hatası");
        throw;
    }
}

public void randevuları_hastayait_Goster(int hasta_id){
    try
    {
        string komut="select * from randevu where h_id = '"+hasta_id+"'";
        baglanti.Open();
        MySqlDataAdapter listele = new MySqlDataAdapter(komut, baglanti);
        DataTable oku = new DataTable();
        listele.Fill(oku);
        dataGridView1.DataSource = oku;
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Randevu Hastaya Ait Gosterme Hatası");
        throw;
    }
}

public void randevu_tarih_güncelle(int doktor_id,Date tarih){
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut="update randevu set tarih =  '"+tarih +"'where d_id = '"+doktor_id+"'";
        MySqlCommand dnl = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (dnl.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Randevu Başarıyla Güncellenmiştir.");
        }
        else
        {   
            MessageBox.Show("randevu Güncellenememiştir.");
        }
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Randevu Tarih Guncelleme Hatası");
        throw;
    }
}

public void randevu_saat_güncelle(int doktor_id,DateTime saat){
    try
    {
        MySqlConnection baglanti = new MySqlConnection(Form1.sqlbaglanti);
        string komut="update randevu set tarih =  '"+saat +"'where d_id = '"+doktor_id+"'";
        MySqlCommand dnl = new MySqlCommand(komut, baglanti);
        baglanti.Open();
        if (dnl.ExecuteNonQuery() == 1)
        {
            MessageBox.Show("Randevu Başarıyla Güncellenmiştir.");
        }
        else
        {   
            MessageBox.Show("randevu Güncellenememiştir.");
        }
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Randevu Saat Guncelleme Hatası");
        throw;
    }
}

public void randevuları_otarihteki_Goster(Date tarih){
    try
    {
        string komut="select * from randevu where tarih = '"+tarih+"'";
        baglanti.Open();
        MySqlDataAdapter listele = new MySqlDataAdapter(komut, baglanti);
        DataTable oku = new DataTable();
        listele.Fill(oku);
        dataGridView1.DataSource = oku;
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Randevu Tarih Gosterme Hatası");
        throw;
    }
}

public void randevuları_osaatteki_Goster(DateTime saat){
    try
    {
        string komut="select * from randevu where saat = '"+saat+"'";
        baglanti.Open();
        MySqlDataAdapter listele = new MySqlDataAdapter(komut, baglanti);
        DataTable oku = new DataTable();
        listele.Fill(oku);
        dataGridView1.DataSource = oku;
        baglanti.Close(); 
    }
    catch (System.Exception)
    {
        MessageBox.Show("Randevu Saat Gosterme Hatası");
        throw;
    }
}