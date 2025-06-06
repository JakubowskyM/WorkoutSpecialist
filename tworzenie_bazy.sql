-- Utworzenie bazy danych
CREATE DATABASE workout_specialist;
GO

USE workout_specialist;
GO

-- Tabela Users
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(100) NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    RegistrationDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Tabela Workouts
CREATE TABLE Workouts (
    WorkoutId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    Date DATE NOT NULL,
    Notes TEXT NULL,
    CONSTRAINT FK_Workouts_Users FOREIGN KEY (UserId) REFERENCES Users(UserId) ON DELETE CASCADE
);

-- Tabela Exercises
CREATE TABLE Exercises (
    ExerciseId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    MuscleGroup VARCHAR(100) NULL,
    Description TEXT NULL
);

-- Tabela WorkoutDetails
CREATE TABLE WorkoutDetails (
    DetailId INT IDENTITY(1,1) PRIMARY KEY,
    WorkoutId INT NOT NULL,
    ExerciseId INT NOT NULL,
    Sets INT NOT NULL,
    Reps INT NOT NULL,
    WeightKg FLOAT NOT NULL,
    CONSTRAINT FK_WorkoutDetails_Workouts FOREIGN KEY (WorkoutId) REFERENCES Workouts(WorkoutId) ON DELETE CASCADE,
    CONSTRAINT FK_WorkoutDetails_Exercises FOREIGN KEY (ExerciseId) REFERENCES Exercises(ExerciseId) ON DELETE CASCADE
);
