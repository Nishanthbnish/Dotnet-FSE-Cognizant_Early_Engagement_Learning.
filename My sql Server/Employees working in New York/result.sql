select e.firstname,e.lastname,e.salary 
from Employee e 
join Department d on 
e.workdept=d.deptno 
where d.location="New York"
order by e.firstname
go