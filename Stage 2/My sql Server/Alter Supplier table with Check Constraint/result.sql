alter table Supplier
add constraint contact check
(LEN([contact])=10)
go