--CREATE DATABASE Isim_DB
--GO
--USE Isim_DB
--GO
--CREATE TABLE Kullanicilar
--(
--	ID INT IDENTITY(1,1),
--	Isim NVARCHAR(50) NOT NULL,
--	Soyisim NVARCHAR(50) NOT NULL,
--	CONSTRAINT pk_kullanici PRIMARY KEY (ID)
--)

INSERT INTO Kullanicilar(Isim,Soyisim) VALUES ('Altu�','Alkan')
INSERT INTO Kullanicilar(Isim,Soyisim) VALUES ('Alp','Sar�k��la')
INSERT INTO Kullanicilar(Isim,Soyisim) VALUES ('Ufuk','G�me�o�lu')
INSERT INTO Kullanicilar(Isim,Soyisim) VALUES ('Do�u�','�zt�rk')
INSERT INTO Kullanicilar(Isim,Soyisim) VALUES ('Elon','Musk')
INSERT INTO Kullanicilar(Isim,Soyisim) VALUES ('Jeff','Bezos')

SELECT * FROM Kullanicilar