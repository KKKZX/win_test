Select  c.name as [Customers] 
from Customers c
where c.id not in (Select customerId from Orders )

