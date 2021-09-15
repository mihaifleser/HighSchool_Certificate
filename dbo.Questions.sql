CREATE TABLE [dbo].[Questions] (
    [Id]             INT           NOT NULL,
    [Intrebare]      NVARCHAR (50) NOT NULL,
    [Raspuns 1]      NVARCHAR (50) NOT NULL,
    [Raspuns 2]      NVARCHAR (50) NOT NULL,
    [Raspuns 3]      NVARCHAR (50) NOT NULL,
    [Raspuns 4]      NVARCHAR (50) NOT NULL,
    [Raspuns Corect] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

