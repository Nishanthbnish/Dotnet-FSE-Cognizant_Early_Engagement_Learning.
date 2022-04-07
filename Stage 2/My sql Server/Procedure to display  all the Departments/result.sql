create proc AvailableDepartments as
begin
    select deptname as Name from
    Department 
end
go