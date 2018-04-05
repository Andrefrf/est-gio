CREATE TABLE [dbo].Visits
(
	[Name] NCHAR(20) NOT NULL, 
    [Surname] NCHAR(20) NOT NULL, 
    [DocType] NCHAR(10) NOT NULL, 
    [DocNumber] NCHAR(10) NOT NULL, 
    [Gender] NCHAR(1) NOT NULL, 
    [Company] NCHAR(10) NOT NULL, 
    [Delivery] BIT NOT NULL, 
    [In] DATE NOT NULL, 
    [Out] DATE NULL,
	Primary Key (DocNumber, DocType)
)
