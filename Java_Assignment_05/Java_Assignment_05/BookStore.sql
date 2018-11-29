DROP TABLE books CASCADE CONSTRAINTS ;
DROP TABLE sales CASCADE CONSTRAINTS ;

CREATE TABLE books (
  BookCode NUMBER GENERATED ALWAYS as IDENTITY (START with 001 INCREMENT by 1),
  Title VARCHAR2(50) NOT NULL,
  Author VARCHAR2(25) NOT NULL,
  Price DECIMAL(7,2),
  Type VARCHAR2(25),
  Subject VARCHAR2(25),
  PRIMARY KEY (BookCode)
);

CREATE TABLE sales (
  SaleID NUMBER GENERATED ALWAYS as IDENTITY (START with 001 INCREMENT by 1),
  BookCode NUMBER NOT NULL,
  SalesDate DATE NOT NULL,
  Quantity NUMBER NOT NULL,
  Price DECIMAL(7,2),
  CONSTRAINT FK_BookCode FOREIGN KEY (BookCode) REFERENCES books (BookCode)
);
INSERT INTO books (Title, Author, Price, Type, Subject) VALUES ('Servlets and JSP', 'Murach', 40.75, 'Technology', 'Software Engineering');
INSERT INTO books (Title, Author, Price, Type, Subject) VALUES ('Leaning Android 2', 'Marco', 56.97, 'Technology', 'Internet');
INSERT INTO books (Title, Author, Price, Type, Subject) VALUES ('Under the Sea', 'Johnson', 43.00, 'Science', 'Marine Life');
INSERT INTO books (Title, Author, Price, Type, Subject) VALUES ('Your Name', 'Yukihiko', 27.00, 'Fantasy', 'Anime');
INSERT INTO books (Title, Author, Price, Type, Subject) VALUES ('C# Programming', 'Mary', 112.99, 'Technology', 'Software Engineering');

INSERT INTO sales (BookCode, SalesDate, Quantity, Price) VALUES (1, '23-Sep-2018', 5, 40.75);
INSERT INTO sales (BookCode, SalesDate, Quantity, Price) VALUES (1, '14-Nov-2018', 10, 40.75);
INSERT INTO sales (BookCode, SalesDate, Quantity, Price) VALUES (3, '20-Oct-2018', 15, 56.97);
INSERT INTO sales (BookCode, SalesDate, Quantity, Price) VALUES (4, '25-Mar-2017', 4, 27.00);
INSERT INTO sales (BookCode, SalesDate, Quantity, Price) VALUES (5, '1-Dec-2018', 20, 112.99);

SELECT * FROM books;
SELECT * FROM sales;

COMMIT ;


