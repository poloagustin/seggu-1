USE Seggu
GO
CREATE TYPE FeeSelectionAssigmentTable AS TABLE (
	Id UNIQUEIDENTIFIER NOT NULL,
	FeeSelectionId UNIQUEIDENTIFIER NULL,
	Status INT NOT NULL
)