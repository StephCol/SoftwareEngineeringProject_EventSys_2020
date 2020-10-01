-- projectScript.sql
-- January 2020

--DROP TABLES

DROP TABLE Bookings;
DROP TABLE Events;
DROP TABLE Customers;
DROP TABLE Venues;
DROP TABLE EventType;


--VENUES TABLE


CREATE TABLE Venues (
  VenueID numeric(4) NOT NULL ,
  VenueName varchar2(30) NOT NULL,
  Street varchar2(30) NOT NULL,
  Town varchar2(20) NOT NULL,
  Capacity numeric(4) NOT NULL,
  ContactNo varchar2(14) NOT NULL,
  Email varchar2(30) NOT NULL,
  Status char(1) DEFAULT 'Y',
  Password varchar2(8) NOT NULL,
  CONSTRAINT pk_VenID PRIMARY KEY (VenueID));


INSERT INTO Venues (VenueID, VenueName, Street, Town, Capacity, ContactNo, Email, Password)  
VALUES(0001,'Blasket Bar', 'Lower Castle St.', 'Tralee', 125, '087 123 5698', 'bbar@tralee.ie', 'bbar');

INSERT INTO Venues (VenueID, VenueName, Street, Town, Capacity, ContactNo, Email, Password)  
VALUES(0002,'The Rock Inn', 'Rock St.', 'Tralee', 50, '086 223 5668', 'roundys@gmail.com', 'round');

INSERT INTO Venues (VenueID, VenueName, Street, Town, Capacity, ContactNo, Email, Password)  
VALUES(0003,'St Brigids Community Centre', 'Hawley Park', 'Tralee', 356, '083 111 5622', 'stbridgey@hotmail.co.uk', 'bridgey');

INSERT INTO Venues (VenueID, VenueName, Street, Town, Capacity, ContactNo, Email, Password)  
VALUES(0004,'The Grand Hotel', 'Denny Street', 'Tralee', 550, '087 125 9998', 'grand@hotels.ie', 'grand');

INSERT INTO Venues (VenueID, VenueName, Street, Town, Capacity, ContactNo, Email, Password)  
VALUES(0005,'Kerins Clubhouse', 'Spa Road', 'Tralee', 250, '087 111 9998', 'kerins@clubs.ie', 'kclub');


--EVENT TYPE TABLE


CREATE TABLE EventType(
  TypeID numeric(2) NOT NULL,
  Description varchar2(15) NOT NULL,
  CONSTRAINT pk_TypeID PRIMARY KEY (TypeID)
  );
  
  
INSERT INTO EventType (TypeID, Description)  VALUES ( 1, 'Dance');
INSERT INTO EventType (TypeID, Description) VALUES ( 2, 'Comedy');
INSERT INTO EventType (TypeID, Description)  VALUES ( 3, 'Charity');
INSERT INTO EventType (TypeID, Description) VALUES ( 4, 'Live Music');
INSERT INTO EventType (TypeID, Description) VALUES ( 5, 'Concert');
INSERT INTO EventType (TypeID, Description)  VALUES ( 6, 'Sport');
INSERT INTO EventType (TypeID, Description) VALUES ( 7, 'Market');
INSERT INTO EventType (TypeID, Description) VALUES ( 8, 'Family Fun Day');
INSERT INTO EventType (TypeID, Description) VALUES ( 9, 'Community');



--EVENTS TABLE


CREATE TABLE Events (
  EventID numeric(4) NOT NULL,
  VenueID numeric(4) NOT NULL,
  Title varchar2(50) NOT NULL,
  Description varchar2(140),
  TypeID numeric(4) NOT NULL,
  EventDate date NOT NULL,
  Time varchar2(5) NOT NULL,
  TicketsAvailable numeric (3),
  Price numeric(5,2),
  Status char(1) DEFAULT 'S',
  CONSTRAINT pk_EventID PRIMARY KEY (EventID),
  CONSTRAINT fk_Venue_VenID FOREIGN KEY (VenueID) REFERENCES Venues,
  CONSTRAINT fk_Type_TypeID FOREIGN KEY (TypeID) REFERENCES EventType);
  
  
INSERT INTO Events (EventID, VenueID, Title, Description, TypeID, EventDate, Time, TicketsAvailable, Price)  
VALUES(1, 4, 'Grand Dance', 'Night of Dancing and More', 1, '10-May-20', '20:00', 100, 15.00);

INSERT INTO Events (EventID, VenueID, Title, Description, TypeID, EventDate, Time, TicketsAvailable, Price)  
VALUES(2, 3, 'Community Games', 'Family Fun Day', 8, '15-Jun-20', '12:00', 356, 0.00);

INSERT INTO Events (EventID, VenueID, Title, Description, TypeID, EventDate, Time, TicketsAvailable, Price)  
VALUES(3, 2, 'Comic Book Heroes', 'A night of great music', 4, '26-Jul-20', '19:00', 50, 5.00);

INSERT INTO Events (EventID, VenueID, Title, Description, TypeID, EventDate, Time, TicketsAvailable, Price)  
VALUES(4, 1, 'Open Mic Night', 'Dutch courage required', 4, '21-Aug-20', '20:00', 100, 5.00);

INSERT INTO Events (EventID, VenueID, Title, Description, TypeID, EventDate, Time, TicketsAvailable, Price)  
VALUES(5, 5, 'Family Fun Day', 'In aid of Kerry Hospice', 8, '28-Jun-20', '13:00', 250, 5.00);

INSERT INTO Events (EventID, VenueID, Title, Description, TypeID, EventDate, Time, TicketsAvailable, Price)  
VALUES(6, 1, 'Comedy Club', 'Surprise Guest', 2, '01-Sep-20', '19:00', 80, 15.00);


--CUSTOMERS TABLE


CREATE TABLE Customers (
  CustID numeric(6) NOT NULL,
  FName varchar2(20) NOT NULL,
  SName varchar2(20) NOT NULL,
  Email varchar2(30) NOT NULL UNIQUE,
  Password varchar2(8)NOT NULL,
  ContactNo varchar2(14) NOT NULL,
  Balance numeric(6,2) DEFAULT 0,
  CONSTRAINT pk_CustID PRIMARY KEY (CustID)
  );
  
  
INSERT INTO Customers (CustID, FNAme, SName, Email, Password, ContactNo, Balance)  
VALUES(1, 'Mary', 'Murphy', 'mmurphy@gmail.com', 'murphy13', '0831254569', 45.00);

INSERT INTO Customers (CustID, FNAme, SName, Email, Password, ContactNo)  
VALUES(2, 'Grace', 'O Sullivan', 'gos@gmail.com', 'graceos', '0831159569');

INSERT INTO Customers (CustID, FNAme, SName, Email, Password, ContactNo)  
VALUES(3, 'Steph', 'Collins', 'stephc@hotmail.com', 'stephC', '0836953256');

INSERT INTO Customers (CustID, FNAme, SName, Email, Password, ContactNo)  
VALUES(4, 'Joe', 'Bloggs', 'jBloggs@hotmail.com', 'jb', '08369888256');

--BOOKINGS TABLE


CREATE TABLE Bookings (
  BookingID numeric(8) NOT NULL,
  CustID numeric(6) NOT NULL,
  EventID numeric(4) NOT NULL,
  BookingDate date DEFAULT sysdate,
  NoTickets numeric (1) NOT NULL,
  BookingTotal numeric(6,2),
  CONSTRAINT pk_BookingID PRIMARY KEY (BookingID),
  CONSTRAINT fk_Customers_CustID FOREIGN KEY (CustID) REFERENCES Customers,
  CONSTRAINT fk_Event_EventID FOREIGN KEY (EventID) REFERENCES Events
  );
  
  
INSERT INTO Bookings (BookingID, CustID, EventID, NoTickets, BookingTotal)  
VALUES(1, 2, 1, 3, 45.50);

INSERT INTO Bookings (BookingID, CustID, EventID, NoTickets, BookingTotal)  
VALUES(2, 1, 3, 4, 22.00);

INSERT INTO Bookings (BookingID, CustID, EventID, NoTickets, BookingTotal)  
VALUES(3, 3, 2, 4, 0.00);

INSERT INTO Bookings (BookingID, CustID, EventID, NoTickets, BookingTotal)  
VALUES(4, 1, 1, 2, 30.50);

INSERT INTO Bookings (BookingID, CustID, EventID, NoTickets, BookingTotal)  
VALUES(5, 2, 5, 2, 30.50);

INSERT INTO Bookings (BookingID, CustID, EventID, NoTickets, BookingTotal)  
VALUES(6, 4, 4, 3, 30.50);


COMMIT;










