create database sefasoft;
use sefasoft;

create table uyeler(
	uye_id  	varchar(64) 	not null,
    uye_ad		varchar(64) 	not null,
    uye_soyad 	varchar(64) 	not null,
    uye_tel 	varchar(25) 	not null,
    uye_adres 	varchar(100) 	not null,
    primary key(uye_id)
) ENGINE InnoDB;

create table kitaplar(
	kitap_id  	varchar(64) 	not null,
    kitap_ad		varchar(64) 	not null,
    kitap_tur 	varchar(64) 	not null,
    kitap_basim 	varchar(25) 	not null,
    kitap_yayin 	varchar(100) 	not null,
    kitap_sayfasayisi 	int 	not null,
    primary key(kitap_id)
) ENGINE InnoDB;

create table odunc(
	odunc_id  	varchar(64) 	not null,
    uye_id		varchar(64) 	not null,
    kitap_id  	varchar(64) 	not null,
    aldigi_tarih	datetime  	,
    verdigi_tarih 	datetime  	,
    primary key(odunc_id),
    
    foreign key(uye_id)	references uyeler(uye_id)
		on delete cascade on update cascade,
        
	foreign key(kitap_id)	references kitaplar(kitap_id)
		on delete cascade on update cascade
) ENGINE InnoDB;


-- ---------------------- STORED PROCEDURE ---------------------------

-- ------------------ getir ----------------
DELIMITER $$
CREATE PROCEDURE uyeler_hepsi ()
BEGIN
	SELECT 
			uye_id as uyeID,
			uye_ad	as uyead,
			uye_soyad as uyesoyad,
			uye_tel as uyetel ,
			uye_adres as uyeadres
    FROM uyeler;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitaplar_hepsi ()
BEGIN
	SELECT 
			kitap_id as kitapID,
			kitap_ad	as kitapad,
			kitap_tur as kitaptur,
			kitap_basim as kitapbasim ,
			kitap_yayin as kitapyayin ,
			kitap_sayfasayisi as kitapsayfasayisi 
    FROM kitaplar;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE odunc_hepsi (
)
BEGIN
SELECT   
		o.odunc_id,
        u.uye_id,
        k.kitap_id,
        CONCAT(uye_ad,' ', uye_soyad ) as `Uye Ad Soyad`,
        kitap_ad as `Kitap`,
        kitap_tur as `Tur`,
        kitap_basim as `Basım yıl`,
        aldigi_tarih as `Aldıgı tarih`,
		verdigi_tarih as `Verdigi tarih`
FROM  	uyeler u inner join  odunc o 
	on u.uye_id = o.uye_id 
		inner join kitaplar k on o.kitap_id = k.kitap_id;
END $$
DELIMITER ;
-- ---------------- Getir Son---------------

-- ---------------- Ekleme ---------------

DELIMITER $$
CREATE PROCEDURE uye_ekle (
	uye_id  	varchar(64),
    uye_ad		varchar(64),
    uye_soyad 	varchar(64),
    uye_tel 	varchar(25),
    uye_adres 	varchar(100)
)
BEGIN
	INSERT INTO uyeler
    VALUES 	(uye_id , uye_ad, uye_soyad, uye_tel, uye_adres);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitap_ekle (
	kitap_id  	varchar(64),
    kitap_ad		varchar(64),
    kitap_tur 	varchar(64),
    kitap_basim 	varchar(25),
    kitap_yayin 	varchar(100),
    kitap_sayfasayisi 	int
)
BEGIN
	INSERT INTO kitaplar
    VALUES 	(kitap_id , kitap_ad, kitap_tur, kitap_basim, kitap_yayin,kitap_sayfasayisi);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE odunc_ekle (
	odunc_id  	varchar(64),
    uye_id		varchar(64),
    kitap_id  	varchar(64),
    aldigi_tarih	datetime,
    verdigi_tarih 	datetime
)
BEGIN
	INSERT INTO odunc
    VALUES 	(odunc_id , uye_id, kitap_id, aldigi_tarih, verdigi_tarih);
END $$
DELIMITER ;
-- ---------------- Ekleme Son ---------------

-- ---------------- Silme  ---------------
DELIMITER $$
CREATE PROCEDURE uye_sil (
	uyeid			varchar(64)  
)
BEGIN
	DELETE FROM uyeler
	WHERE uye_id  = uyeid;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitap_sil (
	kitapid			varchar(64)  
)
BEGIN
	DELETE FROM kitaplar
	WHERE kitap_id  = kitapid;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE odunc_sil (
	oduncid	varchar(64)  
)
BEGIN
	DELETE FROM odunc
	WHERE odunc_id  = oduncid;
END $$
DELIMITER ;
-- ---------------- Silme son ---------------
-- ---------------- Guncelleme  ---------------

DELIMITER $$
CREATE PROCEDURE uye_guncelle (
	uyeid  	varchar(64),
    uyead		varchar(64),
    uyesoyad 	varchar(64),
    uyetel 	varchar(25),
    uyeadres 	varchar(100)
)
BEGIN
	UPDATE uyeler
    SET 
		uye_ad = uyead,
		uye_soyad 	  = uyesoyad,
		uye_tel	  = uyetel,
		uye_adres	  = uyeadres
	WHERE 
    	uye_id  	  = uyeid;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE odunc_guncelle (
	oduncid  	varchar(64),
    uyeid		varchar(64),
    kitapid  	varchar(64),
    aldigitarih	datetime,
    verdigitarih 	datetime
)
BEGIN
	UPDATE odunc
    SET 
		uye_id 	  = uyeid,
		kitap_id	  = kitapid,
		aldigi_tarih	  = aldigitarih,
		verdigi_tarih	  = verdigitarih
	WHERE 
    	odunc_id  	  = oduncid;
END $$
DELIMITER ;

-- --------------- bul ---------------
DELIMITER $$
CREATE PROCEDURE uyebul (
	filtre  varchar(32) 
)
BEGIN
	SELECT * FROM uyeler
    WHERE 
    	uye_id  	LIKE  CONCAT('%',filtre,'%') OR
		uye_ad		LIKE  CONCAT('%',filtre,'%') OR
		uye_soyad 	LIKE  CONCAT('%',filtre,'%') OR
		uye_tel 	LIKE  CONCAT('%',filtre,'%') OR
		uye_adres 	LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE kitapbul (
	filtre		varchar(32)
)
BEGIN
	SELECT * FROM kitaplar
    WHERE 
    	kitap_id  	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_ad 	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_tur LIKE  CONCAT('%',filtre,'%') OR
		kitap_basim	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_yayin	  LIKE  CONCAT('%',filtre,'%') OR
		kitap_sayfasayisi  LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;
