use StudyRoomBooking

	insert into student values(1234, 'vania', '1234')
	insert into student values(5678, 'sam', '4321')

	insert into Administrator values (3300, 'databases')

	insert into room values (111, 40)
	insert into room values (222, 40)
	insert into room values (333, 40)
	insert into room values (444, 40)

	insert into availableSlots (roomNumber) values (111)
	insert into availableSlots (roomNumber) values (222)
	insert into availableSlots (roomNumber) values (333)
	insert into availableSlots (roomNumber) values (444)

	insert into Booking (RoomNumber, StudentNumber, Date, slotTime) values (222, 1234, '7/24/2019', '11:00')
	insert into Booking (RoomNumber, StudentNumber, Date, slotTime) values (111, 1234, '7/24/2019', '13:00')
	insert into Booking (RoomNumber, StudentNumber, Date, slotTime) values (222, 1234, '7/24/2019', '10:00')
	insert into Booking (RoomNumber, StudentNumber, Date, slotTime) values (333, 1234, '7/24/2019', '11:00')