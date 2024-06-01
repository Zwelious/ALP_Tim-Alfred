create database if not exists db_dealership;
use db_dealership;

drop table if exists customer cascade;
drop table if exists adminn cascade;
drop table if exists accessories_sales cascade;
drop table if exists accessories_inventory cascade;
drop table if exists cars cascade;
drop table if exists carsales cascade;
drop table if exists car_inventory cascade;


create table customer (
	email varchar(50) not null primary key,
    customer_password varchar(6) not null,
    customer_name varchar(50) not null,
    customer_borndate date not null,
    customer_gender varchar(1) not null,
	constraint customer_gender check(customer_gender = 'P' or customer_gender = 'L')
);

create table adminn (
	adminn_id  varchar(5) primary key,
    adminn_password varchar(6) not null,
    adminn_name varchar(50) not null,
    adminn_borndate date not null
);

create table accessories_sales (
	accsales_id varchar(7) primary key,
	accessories_id varchar(5) references accessories_inventory(accessories_id),
    total_buying int(2),
    email varchar(50) not null references customer(email)
);

create table accessories_inventory (
	accessories_id varchar(3) primary key,
	accessories_name varchar(30),
    accessories_stock int(3),
    accessories_price int(9)
);
    
create table cars (
	car_id varchar(7) primary key,
    car_name varchar(20),
    car_type varchar(10),
    car_transmission varchar(2),
    constraint car_transmission check(car_transmission = 'AT' or car_transmission = 'MT'),
    car_price bigint(15),
    car_color varchar(10),
    car_stock int(3)
);

create table carsales (
	carsales_id varchar(4) primary key,
	email varchar(50) not null references customer(email),
    buy_date date,
    no_rangka varchar(10) references car_inventory(no_rangka),
    adminn_id varchar(5) references adminn(adminn_id)
);

create table car_inventory (
	no_rangka varchar(10) primary key,
    car_id varchar(7) references cars(car_id),
    sold tinyint(1)
);
-- carsales (id, email cus,buy date, no rangka)
insert into customer values ( "alfreddhanss@gmail.com", "123456", "Alfred Hans Witono", "2004-01-27", 'L');
insert into customer values ( "ivanindargoo@gmail.com", "987654", "Ivan Indargo", "2004-04-16", 'L');
insert into customer values ( "RoberttAlex@gmail.com", "234678","Robert Alexander","2004-07-21", 'L');
insert into customer values ( "JessicaS@gmail.com", "258123", "Jessica Sugiarto", "2001-09-12", 'P');
insert into customer values ( "IrawanHernia@gmail.com", "582346", "Hernia Irawan", "2000-11-28", 'P');
insert into customer values ( "Valentinoss@gmail.com", "589432", "Valention sinarga", "2003-02-13", 'L');
insert into customer values ( "Jenniferrs@gmail.com", "233513", "Jennifer Evelyn", "1999-05-18", 'P');
insert into customer values ( "MiguelStanley@gmail.com", "532152", "Miguel Stanley Gunawan", "2002-01-15", 'L');
insert into customer values ( "Juanns@gmail.com", "457132", "Juan Sebastian", "2004-01-16", 'L');
insert into customer values ( "KeziaaEl@gmail.com", "974313", "Kezia Elice", "1988-12-10", 'P');
insert into customer values ( "SteivanOcta@gmail.com", "218951", "Steivan Octavian", "2001-08-15", 'L');
insert into customer values ( "CelinkaaE@gmail.com", "643923", "Celinka Eira", "2000-04-09", 'P');
insert into customer values ( "ImmanuelKri@gmail.com", "547823", "Immanuel Krissianto", "1995-03-14", 'L');
insert into customer values ( "Livantyyss@gmail.com", "854324", "Livanty Elchiana", "2003-01-23", 'P');
insert into customer values ( "MarvelHannss@gmail.com", "223492", "Marvel Hans", "2004-11-24", 'L');
insert into customer values ( "PutraaSur@gmail.com", "231456", "Putra Suryana", "2001-07-03", 'L');
insert into customer values ( "FeliciaS@gmail.com", "764912", "Felicia Stevany", "1997-01-07", 'P');
insert into customer values ( "Rickyjoo@gmail.com", "960223", "Ricky Jonathan", "1998-04-15", 'L');
insert into customer values ( "KwandyChandra@gmail.com", "439094", "Kwandy Chandra", "2000-03-28", 'L');
insert into customer values ( "EdwarddS@gmail.com","123414", "Edward Suwandi", "2003-12-15", 'L');

insert into adminn values("AAH01","123456","Alfred Hans","2004-01-27");
insert into adminn values("AII01","789123","Ivan Indargo","2004-03-02");
insert into adminn values("AJC01","456789","Juan Carlos","2004-05-07");
insert into adminn values("AJS02","135789","Juan Sebastian","2004-01-06");
insert into adminn values("ARA01","975321","Richard Alberto","2004-08-18");
insert into adminn values("ATC01","132465","Tsalisa Camila","2004-09-21");
-- INSERT INTO table cars("A0101AW", "Avanza", "Bensin", "Manual", 'A', 233000000, "White", 2)
-- ID: A -> huruf depan mobil; 01 -> misal 01 avanza, 02 agya, 03 alphard; 01 -> bensin 01, hybrid 02, listrik 03, diesel 04; A -> automatic/manual(M); W -> huruf depan color

insert into accessories_sales values("ACC0001","T01","1","RoberttAlex@gmail.com");
insert into accessories_sales values("ACC0002","C04","3","CelinkaaE@gmail.com");
insert into accessories_sales values("ACC0003","H01","5","Jenniferrs@gmail.com");
insert into accessories_sales values("ACC0004","B01","10","Juanns@gmail.com");
insert into accessories_sales values("ACC0005","C02","1","alfreddhanss@gmail.com");
insert into accessories_sales values("ACC0006","I01","2","KwandyChandra@gmail.com");
insert into accessories_sales values("ACC0007","C04","3","ivanindargoo@gmail.com");
insert into accessories_sales values("ACC0008","P03","4","MarvelHannss@gmail.com" );
insert into accessories_sales values("ACC0009","C03","1","FeliciaS@gmail.com");
insert into accessories_sales values("ACC0010","A01","6","ImmanuelKri@gmail.com");
insert into accessories_sales values("ACC0011","P02","1","MiguelStanley@gmail.com");
insert into accessories_sales values("ACC0012","K01","1","Livantyyss@gmail.com");
insert into accessories_sales values("ACC0013","C05","4","Rickyjoo@gmail.com");
insert into accessories_sales values("ACC0014","P01","2","SteivanOcta@gmail.com");
insert into accessories_sales values("ACC0015","D01","1","Valentinoss@gmail.com");
insert into accessories_sales values("ACC0016","S01","3","IrawanHernia@gmail.com");
insert into accessories_sales values("ACC0017","L01","1","KeziaaEl@gmail.com");
insert into accessories_sales values("ACC0018","D01","2","EdwarddS@gmail.com");
insert into accessories_sales values("ACC0019","K03","1","JessicaS@gmail.com");
insert into accessories_sales values("ACC0020","K02","2","KeziaaEl@gmail.com");


insert into accessories_inventory values("T01", "Tempat Sampah Lapis Viniyl " ,10 , 173250 );
insert into accessories_inventory values("C01", "Collapsible Box " , 20 , 545455 );
insert into accessories_inventory values("C02", "Cabin Disinfectan " , 10 , 173250 );
insert into accessories_inventory values("C03", "Cargo Net " , 15 , 282218 );
insert into accessories_inventory values("B01", "Busi Iridium " , 50 , 160000 );
insert into accessories_inventory values("I01", "Injector cleaner " , 50 , 40000 );
insert into accessories_inventory values("A01", "Air Wiper " , 50 , 55000 );
insert into accessories_inventory values("H01", "Holder HP " , 30 , 60000 );
insert into accessories_inventory values("C04", "Cas Mobil " ,10 , 199000 );
insert into accessories_inventory values("C05", "Cover Jok" ,04 , 900250 );
insert into accessories_inventory values("K01", "Karpet  Mobil", 05, 322000); 
insert into accessories_inventory values("P01", "Pewangi Mobil", 20, 35000); 
insert into accessories_inventory values("D01", "Dashcam  Mobil", 08, 2850000);
insert into accessories_inventory values("S01", "Sarung  Mobil", 12, 120000); 
insert into accessories_inventory values("L01", "Lampu Led", 02, 210000);
insert into accessories_inventory values("M01", "Mini Proyektor", 15, 1310000); 
insert into accessories_inventory values("P02", "Pengukur Tekanan Ban", 07, 401000); 
insert into accessories_inventory values("K02", "Headunit Mobil", 05, 1233000); 
insert into accessories_inventory values("P03", "Pajangan Dashboard", 25, 53010); 
insert into accessories_inventory values("K03", "Subwoofer Mobil", 07, 623040); 


insert into cars values( "A0101AR", "Agya GR Sport", "Bensin" , 'AT' ,  237500000 , "Red" , 2);
insert into cars values( "A0201MS", "Agya G", "Bensin" , 'MT' ,  175400000 , "Silver" , 3);
insert into cars values( "A0301AB", "Alphard Q", "Bensin" , 'AT' , 1552569000  , "Black" , 1);
insert into cars values( "A0401MB", "Avanza E", "Bensin" , 'MT' , 233100000 , "Black" , 2);
insert into cars values( "C0101AW", "Calya G", "Bensin" , 'AT' , 187400000 , "White" , 1);
insert into cars values( "C0202AW", "Camry Hybrid", "Hybrid" , 'AT' , 937400000 , "White" , 2);
insert into cars values( "C0301AB", "Camry V", "Bensin" , 'AT' ,  799300000 , "Black" , 0);
insert into cars values( "C0402AR", "CHR Hybrid", "Hybrid" , 'AT' ,  601000000 , "Red" , 1);
insert into cars values( "C0501AS", "Corolla Altis V", "Bensin" , 'AT' ,  237500000 , "Silver" , 3);
insert into cars values( "C0602AB", "Corolla Cross", "Hybrid" , 'AT' , 602100000 , "Black" , 1);
insert into cars values( "F0104AW", "Fortuner 4X2", "Diesel" , 'AT' ,  556300000 , "White" , 4);
insert into cars values( "F0204AB", "Fortuner 4X4", "Diesel" , 'AT' ,  723050000 , "Black" , 1);
insert into cars values( "I0102AW", "Innova Zenix Hybrid", "Hybrid" , 'AT' , 464000000 , "White" , 4);
insert into cars values( "I0102BW", "Innova Zenix Hybrid", "Hybrid" , 'AT' , 464000000 , "Black" , 1);
insert into cars values( "R0101MS", "Raize G", "Bensin" , 'MT' ,  235400000 , "Silver" , 3);
insert into cars values( "R0201MW", "Rush G", "Bensin" , 'MT' ,  280200000 , "White" , 2);
insert into cars values( "S0101AB", "Supra", "Bensin" , 'AT' , 2188400000 , "Black" , 0);
insert into cars values( "V0101AW", "Vellfire G", "Bensin" , 'AT' , 1399800000 , "White" , 2);
insert into cars values( "V0201MW", "Vios G", "Bensin" , 'MT' , 322900000 , "White" , 2);
insert into cars values( "V0301AB", "Voxy", "Bensin" , 'AT' ,  599611000 , "Black" , 3);
insert into cars values( "Y0101AS", "Yaris G", "Bensin" , 'AT' ,  297350000 , "Silver" , 1);

-- Agya GR Sport
insert into car_inventory values( "A0101AR01", "A0101AR", 1); 
insert into car_inventory values( "A0101AR02", "A0101AR", 0);
insert into car_inventory values( "A0101AR03", "A0101AR", 0);
-- Agya G
insert into car_inventory values( "A0201MS01", "A0201MS", 1);
insert into car_inventory values( "A0201MS02", "A0201MS", 1);
insert into car_inventory values( "A0201MS03", "A0201MS", 0);
insert into car_inventory values( "A0201MS04", "A0201MS", 0);
insert into car_inventory values( "A0201MS05", "A0201MS", 0);
-- Alphard Q
insert into car_inventory values( "A0301AB01", "A0301AB", 1);
insert into car_inventory values( "A0301AB02", "A0301AB", 0);
-- Avanza E
insert into car_inventory values( "A0401MB01", "A0401MB", 1);
insert into car_inventory values( "A0401MB02", "A0401MB", 1);
insert into car_inventory values( "A0401MB03", "A0401MB", 0);
insert into car_inventory values( "A0401MB04", "A0401MB", 0);
-- Calya G
insert into car_inventory values( "C0101AW01", "C0101AW", 1);
insert into car_inventory values( "C0101AW02", "C0101AW", 0);
-- Camry Hybrid
insert into car_inventory values( "C0202AW01", "C0202AW", 1);
insert into car_inventory values( "C0202AW02", "C0202AW", 0);
insert into car_inventory values( "C0202AW03", "C0202AW", 0);
-- Camry V
insert into car_inventory values( "C0301AB01", "C0301AB", 1);
-- CHR Hybrid
insert into car_inventory values( "C0402AR01", "C0402AR", 0);
-- Corolla Altis V
insert into car_inventory values( "C0501AS01", "C0501AS", 1);
insert into car_inventory values( "C0501AS02", "C0501AS", 0);
insert into car_inventory values( "C0501AS03", "C0501AS", 0);
insert into car_inventory values( "C0501AS04", "C0501AS", 0);
-- Corolla Cross
insert into car_inventory values( "C0602AB01", "C0602AB", 1);
insert into car_inventory values( "C0602AB02", "C0602AB", 0);
-- Fortuner 4x2
insert into car_inventory values( "F0104AW01", "F0104AW", 1);
insert into car_inventory values( "F0104AW02", "F0104AW", 0);    
insert into car_inventory values( "F0104AW03", "F0104AW", 0);    
insert into car_inventory values( "F0104AW04", "F0104AW", 0);    
insert into car_inventory values( "F0104AW05", "F0104AW", 0);        
-- Fortuner 4x4
insert into car_inventory values( "F0204AB01", "F0204AB", 1);
insert into car_inventory values( "F0204AB02", "F0204AB", 0);
-- Innova Zenix Hybrid (White)
insert into car_inventory values( "I0102AW01", "I0102AW", 1);
insert into car_inventory values( "I0102AW02", "I0102AW", 0);
insert into car_inventory values( "I0102AW03", "I0102AW", 0);
insert into car_inventory values( "I0102AW04", "I0102AW", 0);
insert into car_inventory values( "I0102AW05", "I0102AW", 0);
-- Innova Zenix Hybrid (Black)
insert into car_inventory values( "I0102BW01", "I0102BW", 0);
-- Raize G
insert into car_inventory values( "R0101MS01", "R0101MS", 1);
insert into car_inventory values( "R0101MS02", "R0101MS", 0);
insert into car_inventory values( "R0101MS03", "R0101MS", 0);
insert into car_inventory values( "R0101MS04", "R0101MS", 0);
-- Rush G
insert into car_inventory values( "R0201MW01", "R0201MW", 1);
insert into car_inventory values( "R0201MW02", "R0201MW", 0);
insert into car_inventory values( "R0201MW03", "R0201MW", 0);
-- Supra
insert into car_inventory values( "S0101AB01", "S0101AB", 1);
-- Vellfire G
insert into car_inventory values( "V0101AW01", "V0101AW", 0);
insert into car_inventory values( "V0101AW02", "V0101AW", 0);
-- Vios G
insert into car_inventory values( "V0201MW01", "V0201MW", 1);
insert into car_inventory values( "V0201MW02", "V0201MW", 0);
insert into car_inventory values( "V0201MW03", "V0201MW", 0);
-- Voxy
insert into car_inventory values( "V0301AB01", "V0301AB", 1);
insert into car_inventory values( "V0301AB02", "V0301AB", 0);
insert into car_inventory values( "V0301AB03", "V0301AB", 0);
insert into car_inventory values( "V0301AB04", "V0301AB", 0);
-- Yaris G
insert into car_inventory values( "Y0101AS01", "Y0101AS", 1);
insert into car_inventory values( "Y0101AS02", "Y0101AS", 0);

insert into carsales values ( "P001", "alfreddhanss@gmail.com" , "2022-08-21" , "A0101AR01", "AAH01");
insert into carsales values ( "P002", "CelinkaaE@gmail.com" , "2022-09-15" , "C0602AB01", "AJC01");
insert into carsales values ( "P003", "ImmanuelKri@gmail.com" , "2022-10-07" , "C0301AB01","AII01");
insert into carsales values ( "P004", "KwandyChandra@gmail.com" , "2022-10-27" , "Y0101AS01", "AJC01");
insert into carsales values ( "P005", "Jenniferrs@gmail.com" , "2022-11-11" , "R0101MS01", "AJS02");
insert into carsales values ( "P006", "KeziaaEl@gmail.com" , "2022-11-27" , "A0301AB01", "AAH01");
insert into carsales values ( "P007", "Livantyyss@gmail.com" , "2022-12-15" ,"F0204AB01", "ARA01");
insert into carsales values ( "P008", "ivanindargoo@gmail.com" , "2022-12-25" , "S0101AB01", "AAH01");
insert into carsales values ( "P009", "PutraaSur@gmail.com" ,"2023-01-01" , "A0401MB02", "ATC01");
insert into carsales values ( "P010", "Rickyjoo@gmail.com" , "2023-01-14" , "A0201MS01", "AJS02");
insert into carsales values ( "P011", "FeliciaS@gmail.com" , "2023-01-29", "A0201MS02","AJC01");
insert into carsales values ( "P012", "IrawanHernia@gmail.com" , "2023-02-14", "V0301AB01", "AII01");
insert into carsales values ( "P013", "JessicaS@gmail.com" , "2023-02-26" , "C0202AW01", "ATC01");
insert into carsales values ( "P014", "Valentinoss@gmail.com" , "2023-02-28" , "R0201MW01", "AAH01");
insert into carsales values ( "P015", "FeliciaS@gmail.com" , "2023-03-03" , "V0201MW01", "AJS02");
insert into carsales values ( "P016", "ivanindargoo@gmail.com" , "2023-03-09" , "A0401MB01", "AII01");
insert into carsales values ( "P017", "RoberttAlex@gmail.com" , "2023-03-17" , "I0102AW01", "AAH01");
insert into carsales values ( "P018", "MarvelHannss@gmail.com" , "2023-04-09" , "F0104AW01", "AII01");
insert into carsales values ( "P019", "KeziaaEl@gmail.com" , "2023-04-18" , "C0501AS01", "ARA01");
insert into carsales values ( "P020", "Juanns@gmail.com" , "2023-04-24" , "C0101AW01", "AAH01");