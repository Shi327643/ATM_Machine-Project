create database ATM;
use ATM;

Create table  Card(
Transaction_Date datetime  not null,
AccNo bigint,
CardNo bigint NOT NULL,
Transaction_Mode varchar(20) not null,
Account_Type varchar(20) not null,
Ammount numeric(7,2) ,
pin int,
foreign key (CardNo) references User(CardNo)

);

Insert into Card values("2022-08-13",36987412356,1564324187787896,"Withdraw" ,"savings",5000,3214);
Insert into Card values("2022-08-13",36987412356,1564324187787896,"Withdraw" ,"savings",9000,3214);
Insert into Card values("2022-08-23",36987412356,1564324187787896,"Withdraw" ,"savings",3600,3214);
Insert into Card values("2022-08-23",36987412356,1564324187787896,"Withdraw" ,"savings",5000,3214);
Insert into Card values("2022-07-24",25698741023,5243321666783214, "Withdraw","current",3000,9632);
Insert into Card values("2022-10-15",45639874522,3698741233011001, "Deposit","savings",10000,7896);
Insert into Card values("2022-06-21",36254198700,9879654223654145, "Deposit","current",15000,1001);
Insert into Card values("2022-12-25",33221144658,3698852332569789, "Withdraw","savings",2000,1230);

CREATE TABLE User
       (
       CardNo bigint NOT NULL Primary Key,
       FirstName  VARCHAR(30),
	   LastName VARCHAR(30),
	    pin int,
        AccNo bigint NOT NULL,
        ContactNo bigint ,
        Balance decimal(10,2) 
        );
        
        Insert into User Values(1564324187787896,"Shivam","Sharma",3214,36987412356,9632587412,20000);
        Insert into User Values(5243321666783214,"Anwari","Khan",9632,25698741023,7896325412,25000);
        Insert into User Values(3698741233011001,"Rutuja","Jadav",7896,45639874522,8879632541,30000);
        Insert into User Values(9879654223654145,"Sahil","Radye",1001,36254198700,9992156314,20000);
        Insert into User Values(3698852332569789,"Sagar","Sharma",1230,33221144658,7412369854,35000);


select * from Card;

select * from User;




