drop table comm_shipping;
drop table comm_address;
drop table comm_credit_card;
drop table comm_cart_item;
drop table comm_order_item;
drop table comm_shopping_cart;
drop table comm_order;
drop table comm_customer;
drop table comm_product;
drop table comm_category;

create table comm_category 
(cat_code char(3), 
cat_desc varchar2(20),
constraint commcategory_catcode_pk primary key (cat_code));

create table comm_product
(product# number(4),
product_name varchar2(20) not null,
cost number(8,2),
price number(8,2),
cat_code char(3),
color varchar2(10),
psize varchar2(3),
constraint commproduct_product#_pk primary key(product#),
constraint commproduct_catcode_fk foreign key (cat_code) 
    references comm_category(cat_code),
constraint commproduct_cost_ck check(cost >= 0),
constraint commproduct_price_ck check(price >= 0));

create table comm_customer
(cust# number(3),
first_name varchar2(30) not null,
last_name varchar2(30) not null,
email varchar2(30) not null,
phone varchar2(15),
constraint commcustomer_cust#_pk primary key(cust#));


create table comm_shopping_cart
(cart# number(3),
cust# number(3),
checkout char(1),
active char(1),
expire_on date,
constraint commshoppingcart_cart#_pk primary key(cart#),
constraint commshoppingcart_cust#_fk foreign key(cust#)
    references comm_customer(cust#),
constraint commshoppingcart_checkout_ck check(checkout in ('y', 'n')),
constraint commshoppingcart_active_ck check(active in ('y', 'n')));

create table comm_cart_item
(cart# number(3),
item# number(3),
product# number(4),
quantity number(2) not null,
price number(8, 2) not null,
constraint commcartitem_cart#item#_pk primary key(cart#, item#),
constraint commcartitem_cart#_fk foreign key(cart#)
    references comm_shopping_cart(cart#),
constraint commcartitem_product#_fk foreign key(product#)
    references comm_product(product#),
constraint commcartitem_price_ck check(price >= 0),
constraint commcartitem_quantity_ck check(quantity >= 0));
    
create table comm_order
(order# number(4),
cust# number(3),
order_date date not null,
constraint commorder_order#_pk primary key(order#),
constraint commorder_cust#_fk foreign key(cust#)
    references comm_customer(cust#));

create table comm_order_item
(order# number(4),
item# number(3),
product# number(4),
quantity number(2) not null,
price number(8, 2) not null,
constraint commorderitem_order#item#_pk primary key(order#, item#),
constraint commorderitem_order#_fk foreign key(order#)
    references comm_order(order#),
constraint commorderitem_product#_fk foreign key(product#)
    references comm_product(product#),
constraint commorderitem_price_ck check(price >= 0),
constraint commorderitem_quantity_ck check(quantity > 0));

create table comm_address
(address# number(4),
cust# number(3),
address1 varchar2(30) not null,
address2 varchar2(30),
city varchar2(20),
state varchar2(20),
zip varchar2(6),
constraint commaddress_address#_pk primary key(address#),
constraint commaddress_cust#_pk foreign key(cust#)
    references comm_customer(cust#));

create table comm_credit_card
(card# char(16),
cust# number(3) not null,
holder_name varchar2(40),
expire_date date,
constraint commcreditcard_card#_pk primary key(card#),
constraint commcreditcard_cust#_fk foreign key(cust#)
    references comm_customer(cust#));

create table comm_shipping
(shipping# number(5),
order# number(4) not null,
address# number(4),
ship_date date,
ship_status varchar2(20) not null,
ship_method varchar2(10),
constraint commshipping_shipping#_pk primary key(shipping#),
constraint commshipping_order#_fk foreign key(order#)
    references comm_order(order#),
constraint commshipping_address#_fk foreign key(address#)
    references comm_address(address#),
constraint comm_shipstatus_ck check
    (ship_status in ('at warehouse', 'out for delivery', 'delivered')));



--insert data to customer
insert into comm_customer values(100, 'hoang', 'ha', 'hoang@cencol.leader', 1234567890);
insert into comm_customer values(101, 'harry', 'porter', 'harry@hogwarts.uk', 1234567891);
insert into comm_customer values(102, 'clark', 'kent', 'clark@krypton.ca', 1234567892);
insert into comm_customer values(103, 'tony', 'stark', 'tony@stark.com', 1234567893);
insert into comm_customer values(104, 'bruce', 'wayne', 'bruce@bat.com', null);
insert into comm_customer values(105, 'peter', 'parker', 'peter@cbc.ca', 1234567894);
insert into comm_customer values(106, 'steve', 'rogers', 'steve@fbi.us', 1234567895);
insert into comm_customer values(107, 'alan', 'scott', 'alan@nowhere.com', 1234567896);
insert into comm_customer values(108, 'harley', 'quinn', 'harley@hospital.ca', 1234567897);
insert into comm_customer values(109, 'goku', 'son', 'goku@saiya.sy', null);

--insert to product category
insert into comm_category values('fmg', 'consumer goods');
insert into comm_category values('clo', 'clothes');
insert into comm_category values('vhc', 'vehicles');
insert into comm_category values('drg', 'drugs');
insert into comm_category values('sho', 'shoes');
insert into comm_category values('ele', 'electric goods');
insert into comm_category values('fur', 'furnitures');
insert into comm_category values('boo', 'books');
insert into comm_category values('spt', 'sport goods');
insert into comm_category values('oth', 'others');

--insert into product
insert into comm_product 
values(1000, 'samsung s6 edge plus', 1099, 1299, 'ele', 'black', '64G');
insert into comm_product 
values(1001, 'dell latitude e7450', 1200, 1399.99, 'ele', 'black', null);
insert into comm_product 
values(1002, 'norco crd1000 bike', 400, 600, 'spt', 'black, red', 'S');
insert into comm_product 
values(1003, 'adidas running shoes', 49, 69.99, 'sho', 'grey', 'M');
insert into comm_product 
values(1004, 'colgate toothpaste', 3.5, 6.5, 'fmg', 'red', null);
insert into comm_product 
values(1005, 'ford ranger pickup', 25000, 30142, 'vhc', 'red orange', null);
insert into comm_product 
values(1006, 'fish oil', 8, 15, 'drg', null, 'L');
insert into comm_product 
values(1007, 'ikea wood table', 30, 55.5, 'fur', 'brown', 'M');
insert into comm_product 
values(1008, 'oracle 12c', 40.65, 56.14, 'boo', null, null);
insert into comm_product 
values(1009, 'C# 2015', 39.67, 50.32, 'boo', null, null);
insert into comm_product 
values(1010, 'python programming', 54.35, 73.43, 'boo', null, null);
insert into comm_product 
values(1011, 'perfume for man', 99, 125, 'oth', 'black', '100');

--insert into shopping_cart
insert into comm_shopping_cart
values(200, 100, 'n', 'y', '01-sep-2018');
insert into comm_shopping_cart
values(201, 101, 'y', 'n', '04-sep-2018');
insert into comm_shopping_cart
values(202, 102, 'y', 'y', '30-oct-2018');
insert into comm_shopping_cart
values(203, 103, 'n', 'n', '10-nov-2018');
insert into comm_shopping_cart
values(204, 104, 'y', 'y', '27-dec-2018');
insert into comm_shopping_cart
values(205, 105, 'n', 'n', '03-oct-2018');
insert into comm_shopping_cart
values(206, 106, 'y', 'y', '01-oct-2018');
insert into comm_shopping_cart
values(207, 107, 'y', 'n', '13-sep-2018');
insert into comm_shopping_cart
values(208, 108, 'n', 'n', '03-dec-2018');
insert into comm_shopping_cart
values(209, 109, 'y', 'y', '25-sep-2018');

--insert into cart_item
insert into comm_cart_item
values(200, 001, 1000, 1, 1199);
insert into comm_cart_item
values(200, 002, 1001, 1, 1399.99);
insert into comm_cart_item
values(200, 003, 1002, 2, 550);
insert into comm_cart_item
values(201, 001, 1004, 5, 6.5);
insert into comm_cart_item
values(201, 002, 1010, 2, 70.99);
insert into comm_cart_item
values(202, 001, 1005, 1, 30000);
insert into comm_cart_item
values(203, 001, 1003, 3, 69.99);
insert into comm_cart_item
values(203, 002, 1007, 2, 55.5);
insert into comm_cart_item
values(204, 001, 1011, 10, 90.12);
insert into comm_cart_item
values(205, 001, 1009, 1, 48.23);
insert into comm_cart_item
values(206, 001, 1000, 2, 1100);
insert into comm_cart_item
values(207, 001, 1001, 1, 1200);
insert into comm_cart_item
values(208, 001, 1006, 5, 13.23);
insert into comm_cart_item
values(208, 002, 1011, 3, 120);
insert into comm_cart_item
values(208, 003, 1010, 2, 70.23);

--insert into order
insert into comm_order
values(1000, 100, '02-aug-2018');
insert into comm_order
values(1001, 100, '28-jul-2018');
insert into comm_order
values(1002, 101, '20-jul-2018');
insert into comm_order
values(1003, 101, '04-jun-2018');
insert into comm_order
values(1004, 102, '06-may-2018');
insert into comm_order
values(1005, 103, '30-jul-2018');
insert into comm_order
values(1006, 103, '10-jul-2018');
insert into comm_order
values(1007, 104, '21-jun-2018');
insert into comm_order
values(1008, 104, '13-jun-2018');
insert into comm_order
values(1009, 105, '23-jul-2018');
insert into comm_order
values(1010, 105, '12-jul-2018');
insert into comm_order
values(1011, 105, '07-jun-2018');
insert into comm_order
values(1012, 106, '05-aug-2018');
insert into comm_order
values(1013, 108, '04-aug-2018');
insert into comm_order
values(1014, 109, '28-jul-2018');

--insert into order_item
insert into comm_order_item
values(1000, 001, 1000, 1, 1199);
insert into comm_order_item
values(1000, 002, 1001, 1, 1399.99);
insert into comm_order_item
values(1001, 001, 1004, 5, 6.5);
insert into comm_order_item
values(1001, 002, 1005, 1, 30100);
insert into comm_order_item
values(1002, 001, 1003, 1, 69.99);
insert into comm_order_item
values(1003, 001, 1002, 1, 590);
insert into comm_order_item
values(1003, 002, 1006, 3, 13);
insert into comm_order_item
values(1004, 001, 1011, 2, 120);
insert into comm_order_item
values(1004, 002, 1010, 1, 73.43);
insert into comm_order_item
values(1005, 001, 1009, 2, 50.32);
insert into comm_order_item
values(1006, 001, 1005, 1, 30142.34);
insert into comm_order_item
values(1007, 001, 1002, 2, 550);
insert into comm_order_item
values(1008, 001, 1005, 1, 30000);
insert into comm_order_item
values(1009, 001, 1002, 1, 600);
insert into comm_order_item
values(1010, 001, 1004, 4, 6);
insert into comm_order_item
values(1011, 001, 1002, 1, 1199);
insert into comm_order_item
values(1012, 001, 1003, 2, 65);
insert into comm_order_item
values(1013, 001, 1004, 4, 6);
insert into comm_order_item
values(1014, 001, 1005, 1, 30000);

--insert into address
insert into comm_address
values(4000, 100, '29 Rosebank Drive', null, 'Scarborough', 'ON', 'M1B5Y7');
insert into comm_address
values(4001, 101, '941 Progress', '10 Milner', 'Scarborough', 'ON', 'M1B8U1');
insert into comm_address
values(4002, 102, '29 ABC street', null, 'Montreal', 'QC', 'M1B5Y7');
insert into comm_address
values(4003, 103, '30 QWETRY street', null, 'St John', 'NB', 'T1B5E7');
insert into comm_address
values(4004, 104, '31 Markham road', null, 'Scarborough', 'ON', 'E1B5W7');
insert into comm_address
values(4005, 105, '221 warden street ', null, 'Hamilton', 'AB', 'R1Y5O7');
insert into comm_address
values(4006, 106, '44 finch avenue', null, 'Vancouver', 'BC', 'M1B5Y7');
insert into comm_address
values(4007, 107, '29 XYZ street', null, 'Scarborough', 'NV', 'X2WE5T');
insert into comm_address
values(4008, 108, '3553 IUYY Drive', null, 'Scarborough', 'MB', 'M1B5Y7');
insert into comm_address
values(4009, 109, '234 idontknow street', null, 'Scarborough', 'NB', 'M1B5Y7');

--insert into credit_card
insert into comm_credit_card
values('4111111111111111', 100, 'Hoang Ha', '31-aug-2021');
insert into comm_credit_card
values('4222222222222222', 101, 'Harry Porter', '31-aug-2022');
insert into comm_credit_card
values('5333333333333333', 102, 'Clark Kent', '31-aug-2023');
insert into comm_credit_card
values('5555555555555555', 103, 'Tony Stark', '31-aug-2024');
insert into comm_credit_card
values('5666666666666666', 104, 'Bruce Wayne', '31-aug-2025');

--insert into shipping
insert into comm_shipping
values(50000, 1000, 4000, '05-aug-2018', 'delivered', 'DHL' );
insert into comm_shipping
values(50001, 1001, 4000, '06-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50002, 1002, 4001, '07-aug-2018', 'delivered', 'Ca Post' );
insert into comm_shipping
values(50003, 1003, 4001, null, 'at warehouse', 'UPS' );
insert into comm_shipping
values(50004, 1004, 4001, '07-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50005, 1005, 4002, '08-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50006, 1006, 4003, '09-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50007, 1007, 4003, '10-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50008, 1008, 4004, '11-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50009, 1009, 4004, '12-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50010, 1010, 4005, '13-aug-2018', 'delivered', 'UPS' );
insert into comm_shipping
values(50011, 1011, 4005, null, 'at warehouse', 'UPS' );
insert into comm_shipping
values(50012, 1012, 4005, null, 'out for delivery', 'UPS' );
insert into comm_shipping
values(50013, 1013, 4006, null, 'at warehouse', 'UPS' );
insert into comm_shipping
values(50014, 1014, 4008, null, 'out for delivery', 'UPS' );

commit;

--5 querries
select first_name, order#, product_name
from comm_customer c join comm_order o using(cust#)
join comm_order_item using(order#)
join comm_product using(product#)
where last_name = 'ha';

select first_name, last_name
from comm_customer c left join comm_order o using(cust#)
where order# is null
order by first_name, last_name;

select state, product_name  
from comm_address a join comm_customer c using(cust#) 
join comm_order o using(cust#)
join comm_order_item oi using(order#)
join comm_product p using(product#)
where state = 'ON' or state = 'QC';

select avg(oi.price - p.cost) as "AvgProf-Ontario-Electronics" 
from comm_address a, comm_customer c, comm_order o, 
comm_order_item oi, comm_product p
where 
a.cust# = c.cust# 
and c.cust# = o.cust#
and o.order# = oi.order#
and oi.product# = p.product#
and state = 'ON'
and cat_code = 'ele';

select first_name, order#, order_date
from comm_customer join comm_order using(cust#)
join comm_shipping using(order#)
where order_date between '01-jul-2018' and '31-jul-2018'
and ship_date is null;

select product_name --products show up in both cart and order
from comm_order_item join comm_product using(product#)
join comm_cart_item using(product#);

select count(order#) from comm_order
where order_date > '01-aug-2018'
and order_date < '05-aug-2018';

