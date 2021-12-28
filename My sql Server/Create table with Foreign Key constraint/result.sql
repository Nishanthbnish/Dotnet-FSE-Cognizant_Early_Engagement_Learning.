create table orders(ORD_NO numeric(5),PURCH_AMT DECIMAL(8,2),ORD_DATE date,
CUTOMER_ID numeric(5),SALESMAN_ID numeric(5),
FOREIGN KEY (SALESMAN_ID) REFERENCES salesman(SALESMAN_ID)
)
GO
