create proc EmployeesDept(@Deptno varchar) as
begin
    select lastname as Name from 
    Employee 
    where workdept='D21'
end    
go