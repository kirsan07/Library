USE Police
GO

CREATE TABLE ViolationsResponsibilitiesRelations
(
	violation SMALLINT NOT NULL,
	responsibility SMALLINT NOT NULL,
	CONSTRAINT PK_VRR PRIMARY KEY (violation, responsibility),
	CONSTRAINT FK_ViolationsResponsibilitiesRelation_Violations
	FOREIGN KEY (violation) REFERENCES Violations(violation_id),
	CONSTRAINT FK_ViolationsResponsibilitiesRelation_Responsibilities
	FOREIGN KEY (responsibility) REFERENCES Responsibilities(responsibility_id)
)
