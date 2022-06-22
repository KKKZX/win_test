Select firstName,lastName,city,state 
from PersonId p
left join Address a on p.personId=a.personId
