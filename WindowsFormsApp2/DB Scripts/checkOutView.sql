CREATE VIEW [dbo].toCheckOut
	AS SELECT Name, Surname, Person.DocType as Type, Person.IdNumber as Document, Entrance, cardNumber as Card, VisitingCompany as Company
	FROM Person inner join Visits on (Person.PersonID = Visits.PersonID)
	where State = 0;