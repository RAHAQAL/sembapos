create database SembaPOS
use SembaPOS
drop database SembaPOS

create table TBarang (
id_barang varchar(5) not null primary key,
nama_barang varchar(20) not null,
hargajual int,
satuan varchar(10),
stok int
)

INSERT INTO TBarang  VALUES('B-001','Beras',12000,'Kg',100)
INSERT INTO TBarang  VALUES('B-002','Gula',15000,'Pcs',50)
INSERT INTO TBarang VALUES('B-003','Tepung',20000,'Pcs',60)

drop table TBarang
select*from TBarang
delete from TBarang

CREATE TABLE TKaryawan (
nik varchar(18) not null  primary key,
nama varchar(30) not null,
jabatan varchar(15),
no_telp varchar(14),
alamat varchar(50)
)

insert into TKaryawan values ('11111','Fahri','Manager','082189899999','Bandung')
insert into TKaryawan values ('11112','Alen','Administrator','082179799999','Tasikmalaya')
insert into TKaryawan values ('11113','Deni','Operator','082188889999','Ciamis')
insert into TKaryawan values ('11114','Rakha','PA','082152189333','Banjar')

drop table TKaryawan
select*from TKaryawan
delete from TKaryawan

CREATE TABLE Tuser (
id_user varchar(5) not null  primary key,
nik varchar(18) not null,
password varchar(15),
roleid char(1),
CONSTRAINT id_user FOREIGN KEY (nik) REFERENCES TKaryawan (nik) 
)

--ON DELETE CASCADE

insert into Tuser values ('U-111','11111','Fahri','1')
insert into Tuser values ('U-112','11112','Alen','1')
insert into Tuser values ('U-113','11113','Deni','2')
insert into Tuser values ('U-114','11114','Rakha','2')

drop table Tuser
select*from Tuser
delete from Tuser

CREATE TABLE TJual(
    id_jual VARCHAR(13) PRIMARY KEY NOT NULL,
    tanggal VARCHAR(10) NOT NULL,
    total_harga INT ,
	keterangan VARCHAR(10) NOT NULL
);

INSERT INTO TJual VALUES('354TJKL','05/05/2024','','Tunai')
INSERT INTO TJual VALUES('987TJKL','06/05/2024','','Tunai')
INSERT INTO TJual VALUES('657TJKL','07/05/2024','','Tunai')

drop table TJual
select*from TJual
delete from TJual

CREATE TABLE TDetailJual (
    id_jual VARCHAR(13) NOT NULL,
    id_barang VARCHAR(5) NOT NULL ,
    jumlah INT NOT NULL,
    harga_jual INT NOT NULL,
	satuan VARCHAR(10) NOT NULL,
	CONSTRAINT id_jual FOREIGN KEY (id_jual) REFERENCES TJual (id_jual),
	CONSTRAINT id_barang FOREIGN KEY (id_barang) REFERENCES TBarang (id_barang)
);

INSERT INTO TDetailJual VALUES('354TJKL','B-001',1,10000,'Kg')
INSERT INTO TDetailJual VALUES('354TJKL','B-002',2,15000,'Pcs')
INSERT INTO TDetailJual VALUES('354TJKL','B-003',3,20000,'Unit')

drop table TDetailJual
select*from TDetailJual
delete from TDetailJual
