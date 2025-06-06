-- Przykładowi użytkownicy
INSERT INTO Users (UserId, UserName, Email) VALUES
(1, 'janek', 'janek@example.com'),
(2, 'ania', 'ania@example.com');

-- Przykładowe ćwiczenia
INSERT INTO Exercises (ExerciseId, Name) VALUES
(1, 'Przysiad'),
(2, 'Martwy ciąg'),
(3, 'Wyciskanie na ławce'),
(4, 'Podciąganie'),
(5, 'Pompki');

-- Przykładowe treningi
INSERT INTO Workouts (WorkoutId, UserId, Date, Note) VALUES
(1, 1, '2025-06-01', 'Trening nóg'),
(2, 2, '2025-06-02', 'Trening górnej części ciała');

-- Przykładowe szczegóły treningów
INSERT INTO Workoutexercises (WorkoutExcerciseId, WorkoutId, ExerciseId, Sets, Reps, Weight) VALUES
(1, 1, 1, 4, 10, 80.0),   -- Janek - Przysiad
(2, 1, 2, 3, 8, 100.0),  -- Janek - Martwy ciąg
(3, 2, 3, 4, 12, 60.0),  -- Ania - Wyciskanie na ławce
(4, 2, 5, 3, 15, 0.0);   -- Ania - Pompki (bez ciężaru)
