USE Police
GO

CREATE TABLE Responsibilities
(
	responsibility_id SMALLINT NOT NULL PRIMARY KEY,
	responsibility_type	TINYINT NOT NULL,
	responsibility_duration DATE,
	penalty SMALLMONEY,
	CONSTRAINT FK_Resposibilities_ResponsibilityTypes 
	FOREIGN KEY (responsibility_type) REFERENCES ResponsibilityTypes (responsibilityType_id)
)