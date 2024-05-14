USE Police
GO

CREATE TABLE Violations
(
	violation_id SMALLINT NOT NULL PRIMARY KEY,
	violations_descriptor NVARCHAR(1024) NOT NULL,
	violations_start_date DATE
)