CREATE TABLE Companies (
    CompanyName NVARCHAR (50) NOT NULL,
    Department  NVARCHAR (10) NULL,
    CompanyID   INT           NOT NULL,
    PRIMARY KEY CLUSTERED (CompanyID ASC),
    CONSTRAINT U_COMP UNIQUE NONCLUSTERED (CompanyName ASC, Department ASC)
);

CREATE TABLE [dbo].[Person] (
    [Name]     NVARCHAR (50) NOT NULL,
    [Surname]  NVARCHAR (50) NOT NULL,
    [DocType]  NVARCHAR (50) NOT NULL,
    [IdNumber] NVARCHAR (50) NOT NULL,
    [PersonID] INT           NOT NULL,
    [Expiry] DATE NULL, 
    [Nationality] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(2) NULL, 
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonID] ASC),
    CONSTRAINT [UNI] UNIQUE NONCLUSTERED ([DocType] ASC, [IdNumber] ASC)
);



CREATE TABLE Users (
    Name     NVARCHAR (50) NOT NULL,
    Password NVARCHAR (50) NOT NULL,
    isAdmin  BIT           NOT NULL,
    PRIMARY KEY CLUSTERED (Name ASC),
    CONSTRAINT Enter UNIQUE NONCLUSTERED (Name ASC, Password ASC)
);

CREATE TABLE [dbo].[Visits] (
    [PersonID]        INT           NOT NULL,
    [CompanyID]       INT           NOT NULL,
    [Delivery]        BIT           NOT NULL,
    [Entrance]        DATETIME      NOT NULL,
    [Out]             DATETIME      NULL,
    [WorkerId]        INT           NOT NULL,
    [cardNumber]      INT           NULL,
    [VisitingCompany] NVARCHAR (50) NOT NULL,
    [State]           BIT           NULL,
    [Address] NVARCHAR(50) NULL, 
    [Comment] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([PersonID] ASC, [Entrance] ASC),
    FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    FOREIGN KEY ([WorkerId]) REFERENCES [dbo].[Workers] ([WorkerId]),
    FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID])
);



CREATE TABLE Workers (
    WorkerName NVARCHAR (50) NOT NULL,
    WorkerId   INT           NOT NULL,
    PRIMARY KEY CLUSTERED (WorkerId ASC)
);

CREATE TABLE WorksIn (
    WorkerId  INT NOT NULL,
    CompanyID INT NOT NULL,
    PRIMARY KEY CLUSTERED (WorkerId ASC, CompanyID ASC),
    FOREIGN KEY (CompanyID) REFERENCES Companies (CompanyID),
    FOREIGN KEY (WorkerId) REFERENCES Workers (WorkerId)
);
