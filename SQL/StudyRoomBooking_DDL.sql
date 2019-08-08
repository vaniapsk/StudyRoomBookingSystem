drop database StudyRoomBooking

create database StudyRoomBooking
use StudyRoomBooking;

 create table Student(
	StudentNumber int primary key,
	StudentName varchar(20),
	Password varchar(20)
 );

create table Administrator(
	Username	int primary key,
	Password	varchar(20));

create table Building(
	Building_ID int IDENTITY(1,1) primary key, -- IDENTITY (1,1) means auto increment by 1, starting from id 1
	BuildingName varchar (10)
);

create table Room(
	RoomNumber int primary key,
	Capacity int
);


create table RoomBuilding(
	BuildingID int  primary key references Building ON DELETE CASCADE ON UPDATE CASCADE,
	RoomNumber int foreign  key references Room ON DELETE CASCADE ON UPDATE CASCADE
);

create table Booking(
	BookingID int IDENTITY(1,1) primary key,
	RoomNumber int foreign key references Room ON DELETE CASCADE ON UPDATE CASCADE,
	StudentNumber int foreign key references Student ON DELETE CASCADE ON UPDATE CASCADE,
	date varchar(15),
	slotTime varchar(5)

);

create table availableSlots(
	roomNumber int foreign key references Room ON DELETE CASCADE ON UPDATE CASCADE,
	t8 varchar(3) default '',
	t9 varchar(3) default '',
	t10 varchar(3) default '',
	t11 varchar(3) default '',
	t12 varchar(3) default '',
	t13 varchar(3) default '',
	t14 varchar(3) default '',
	t15 varchar(3) default '',
	t16 varchar(3) default '',
	t17 varchar(3) default '',
	t18 varchar(3) default '',
	t19 varchar(3) default '',
)

