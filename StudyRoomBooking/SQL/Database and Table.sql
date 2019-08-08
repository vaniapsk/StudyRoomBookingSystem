drop database if exists StudentRoomBooking;
create database StudentRoomBooking;

use StudentRoomBooking;
create table Student(
	StudentNumber	int,
	StudentName		varchar(20),
	primary key(StudentNumber) ); 

	create table users(
	username	int,
	password		varchar(20),
	primary key(username) ); 

	drop table users

insert into users values(1234, 'vania')
insert into users values(5678, 'bob')

use StudentRoomBooking

--select * from Student
--delete from users

--drop table users
