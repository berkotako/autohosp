create database hastane;
use hastane;
create table Klinik(
   K_ID INT NOT NULL AUTO_INCREMENT,
   Isim VARCHAR(45) NOT NULL,
   Adres VARCHAR(100),
   PRIMARY KEY ( K_ID )
);

create table Doktor(
   D_ID INT NOT NULL AUTO_INCREMENT,
   K_ID INT NOT NULL,
   Isim VARCHAR(40) NOT NULL,
   Soyisim VARCHAR(40) NOT NULL,
   PRIMARY KEY ( D_ID )
);
create table Hasta(
   H_ID INT NOT NULL AUTO_INCREMENT,
   Isim VARCHAR(100) NOT NULL,
   Soyisim VARCHAR(40) NOT NULL,
   TC_No INT NOT NULL,
   Rapor_Path VARCHAR(100)
   PRIMARY KEY ( H_ID )
);
create table Randevu(
   R_ID INT NOT NULL AUTO_INCREMENT,
   D_ID INT NOT NULL,
   H_ID INT NOT NULL,
   Tarih datetime,
   Tedavi VARCHAR(100) NOT NULL,
   Ucret decimal,
   OdemeDurumu VARCHAR(100),
   PRIMARY KEY ( R_ID )
);