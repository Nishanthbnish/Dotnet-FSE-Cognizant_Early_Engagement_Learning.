
select concat(a.lastname," works for ",b.lastname) as Hierarchy
from (select e.lastname,e.empno,e.job,d.mgrno from Employee e
join Department d on e.workdept=d.deptno) as a join 
(select e.lastname,e.empno,e.job,d.mgrno from Employee e 
join Department d on e.workdept=d.deptno) as b 
on a.mgrno=b.empno
where a.mgrno!=a.empno
order by a.lastname;
go


