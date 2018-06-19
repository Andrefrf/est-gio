CREATE VIEW [dbo].AllVisits
	AS SELECT State, Name, Surname, VisitingCompany as Company, cardNumber as Card, Delivery FROM Visits inner join Person on(Person.PersonId = Visits.PersonID)