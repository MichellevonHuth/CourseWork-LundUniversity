CREATE TABLE Account (
username VARCHAR(100) NOT NULL,
name VARCHAR(100) NOT NULL,
surename VARCHAR(100) NOT NULL,
CONSTRAINT pk_account PRIMARY KEY(username)
)

CREATE TABLE SavingSchedule(
accountUsername VARCHAR(100) NOT NULL,
totalIncome INT,
fixedCost INT,
variableCost INT,
savingGoal INT,
savingDuration INT,
CONSTRAINT pk_savingSchedule PRIMARY KEY(accountUsername),
CONSTRAINT fk_savingSchedule  FOREIGN KEY(accountUsername) REFERENCES Account(username)
)


