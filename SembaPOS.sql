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
INSERT INTO TBarang VALUES('B-007', 'Kopi', 30000, 'Pcs', 40);
INSERT INTO TBarang VALUES('B-008', 'Teh', 25000, 'Pcs', 45);
INSERT INTO TBarang VALUES('B-009', 'Susu', 18000, 'Ltr', 55);
INSERT INTO TBarang VALUES('B-010', 'Telur', 23000, 'Kg', 90);
INSERT INTO TBarang VALUES('B-011', 'Daging Ayam', 40000, 'Kg', 35);
INSERT INTO TBarang VALUES('B-012', 'Ikan', 35000, 'Kg', 25);
INSERT INTO TBarang VALUES('B-013', 'Sayur Mayur', 15000, 'Kg', 80);
INSERT INTO TBarang VALUES('B-014', 'Buah-buahan', 30000, 'Kg', 50);
INSERT INTO TBarang VALUES('B-015', 'Garam', 5000, 'Pcs', 100);
INSERT INTO TBarang VALUES('B-016', 'Bumbu Dapur', 10000, 'Pcs', 70);
INSERT INTO TBarang VALUES('B-017', 'Roti', 15000, 'Pcs', 60);
INSERT INTO TBarang VALUES('B-018', 'Keju', 50000, 'Pcs', 30);

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
INSERT INTO TKaryawan VALUES('11116', 'Budi', 'Supervisor', '082166699999', 'Bekasi');
INSERT INTO TKaryawan VALUES('11117', 'Ani', 'Operator', '082155599999', 'Bogor');
INSERT INTO TKaryawan VALUES('11118', 'Rizky', 'Technician', '082144499999', 'Depok');
INSERT INTO TKaryawan VALUES('11119', 'Fikri', 'Analyst', '082133399999', 'Jakarta');
INSERT INTO TKaryawan VALUES('11120', 'Joko', 'Driver', '082122299999', 'Semarang');
INSERT INTO TKaryawan VALUES('11121', 'Sari', 'Secretary', '082111199999', 'Yogyakarta');
INSERT INTO TKaryawan VALUES('11122', 'Iwan', 'Clerk', '082100099999', 'Surabaya');
INSERT INTO TKaryawan VALUES('11123', 'Mira', 'Receptionist', '082199999999', 'Bali');
INSERT INTO TKaryawan VALUES('11124', 'Rina', 'Assistant', '082188888888', 'Bandung');
INSERT INTO TKaryawan VALUES('11125', 'Tono', 'Guard', '082177777777', 'Medan');

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
insert into Tuser values ('U-112','11112','Alen','2')
insert into Tuser values ('U-113','11113','Deni','3')
insert into Tuser values ('U-114','11114','Rakha','3')

drop table Tuser
select*from Tuser
delete from Tuser

CREATE TABLE TJual(
    id_jual VARCHAR(15) PRIMARY KEY NOT NULL,
    tanggal VARCHAR(10) NOT NULL,
    total_bayar INT NOT NULL,
	kasir VARCHAR(30) NOT NULL,
	tunai int NOT NULL,
	kembalian int NOT NULL,
	note TEXT
);

INSERT INTO TJual VALUES('SP202406050001','2024/18/06','','Fahri','','','')

drop table TJual
select*from TJual
delete from TJual

CREATE TABLE TDetailJual (
    id_jual VARCHAR(15) NOT NULL,
    id_barang VARCHAR(5) NOT NULL ,
    harga_jual INT NOT NULL,
    jumlah INT NOT NULL,
	total_harga INT
	CONSTRAINT id_jual FOREIGN KEY (id_jual) REFERENCES TJual (id_jual),
	CONSTRAINT id_barang FOREIGN KEY (id_barang) REFERENCES TBarang (id_barang)
);


INSERT INTO TDetailJual VALUES('SP202406050001','B-001',12000,2,24000)


drop table TDetailJual
select*from TDetailJual
delete from TDetailJual

CREATE TRIGGER KurangStokBarang
on TDetailJual
for insert
as
update TBarang set TBarang.stok  = TBarang.stok - TDetailJual.jumlah
from TBarang join inserted TDetailJual on TBarang.id_barang=TDetailJual.id_barang
--update TBarang set TBarang.hargajual  = TDetailJual.harga_jual
--from TBarang join inserted TDetailJual on TBarang.id_barang=TDetailJual.id_barang

drop trigger KurangStokBarang

















select sum(total_bayar) as penjualan, MONTH(tanggal) as bulan 
from TJual 
where YEAR(tanggal) = YEAR(GETDATE()) 
group by MONTH(tanggal);

SELECT TOP 3
    b.nama_barang AS Nama_Barang,
    SUM(dj.jumlah) AS Total_Terjual
FROM
    TDetailJual dj
INNER JOIN
    TBarang b ON b.id_barang = dj.id_barang
GROUP BY
    b.nama_barang
ORDER BY
    Total_Terjual DESC;



