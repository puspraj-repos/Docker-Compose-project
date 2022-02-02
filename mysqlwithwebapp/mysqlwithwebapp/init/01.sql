CREATE TABLE Course
(
    CourseId INT,
    CourseName VARCHAR(1000),
    Rating NUMERIC(2,1)
);

INSERT INTO Course(CourseId, CourseName, Rating) VALUES
(1, "C++", 4.7),
(2,"Java", 4.6),
(3, "C Sharp", 5.2);