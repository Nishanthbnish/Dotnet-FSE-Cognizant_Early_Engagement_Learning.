select  d.deptname as "Worker Department",d.location as Location,e.deptname as "Manager Department"
from Department d
join Department e
on d.admrdept=e.deptno
and d.admrdept!=d.deptno
order by d.deptname
;
go