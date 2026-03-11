--Assignment_1
CREATE VIEW vw_StudentDepartment AS
SELECT
s.StudentID,
s.FirstName + ' ' + s.LastName AS StudentName,
d.DepartmentName,
s.AdmissionDate
FROM Students s JOIN Departments d ON s.DepartmentID = d.DepartmentID;

SELECT * FROM vw_StudentDepartment;

SELECT * FROM vw_StudentDepartment WHERE DepartmentName = 'Computer Science';

DROP VIEW vw_StudentDepartment;

--Assignment_2
CREATE VIEW vw_StudentCourses AS
SELECT
s.StudentID,
s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
e.EnrollmentDate
FROM Students s JOIN Enrollments e ON s.StudentID = e.StudentID
JOIN Courses c ON e.CourseID = c.CourseID;

SELECT * FROM vw_StudentCourses WHERE StudentID = 5;

SELECT StudentName, COUNT(CourseName) AS TotalCourses
FROM vw_StudentCourses GROUP BY StudentName;

SELECT * FROM vw_StudentCourses WHERE EnrollmentDate > '2024-01-01';

--Assignemnt_3
CREATE VIEW vw_ExamResults AS
SELECT
s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
e.ExamType,
m.MarksObtained
FROM Students s JOIN Marks m ON s.StudentID = m.StudentID
JOIN Exams e ON m.ExamID = e.ExamID
JOIN Courses c ON e.CourseID = c.CourseID;

SELECT * FROM vw_ExamResults WHERE MarksObtained > 80;

SELECT * FROM vw_ExamResults WHERE MarksObtained =
(
SELECT MAX(MarksObtained)
FROM vw_ExamResults
);

SELECT * FROM vw_ExamResults WHERE MarksObtained < 40;

--Assignment_4
CREATE VIEW vw_DepartmentStudentCount AS
SELECT d.DepartmentName, COUNT(s.StudentID) AS TotalStudents
FROM Departments d
LEFT JOIN Students s ON d.DepartmentID = s.DepartmentID
GROUP BY d.DepartmentName;

SELECT * FROM vw_DepartmentStudentCount WHERE TotalStudents > 10;

SELECT * FROM vw_DepartmentStudentCount ORDER BY TotalStudents DESC;

--Assignment_1
CREATE PROCEDURE sp_InsertStudent
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@Gender VARCHAR(10),
@DepartmentID INT,
@AdmissionDate DATE 
AS 
BEGIN
INSERT INTO Students
(
FirstName,
LastName,
Gender,
DepartmentID,
AdmissionDate
)
VALUES
(
@FirstName,
@LastName,
@Gender,
@DepartmentID,
@AdmissionDate
);
END;

EXEC sp_InsertStudent
@FirstName = 'Ravi',
@LastName = 'Kumar',
@Gender = 'Male',
@DepartmentID = 1,
@AdmissionDate = '2024-07-10';

SELECT * FROM Students;

--Assignment_2
CREATE PROCEDURE sp_GetStudentsByDepartment
@DepartmentID INT
AS
BEGIN
SELECT
StudentID,
FirstName + ' ' + LastName AS StudentName,
AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID;
END;

EXEC sp_GetStudentsByDepartment
@DepartmentID = 2;

EXEC sp_GetStudentsByDepartment
@DepartmentID = 3;

--Assignment_3
CREATE PROCEDURE sp_EnrollStudent
@StudentID INT,
@CourseID INT
AS
BEGIN
INSERT INTO Enrollments
(
StudentID,
CourseID,
EnrollmentDate
)
VALUES
(
@StudentID,
@CourseID,
GETDATE()
);
END;

EXEC sp_EnrollStudent
@StudentID = 3,
@CourseID = 2;

SELECT * FROM Enrollments;

--Assignment_4
CREATE PROCEDURE sp_GetStudentMarks
@StudentID INT
AS
BEGIN
SELECT
s.FirstName + ' ' + s.LastName AS StudentName,
c.CourseName,
e.ExamType,
m.MarksObtained
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID
JOIN Exams e ON m.ExamID = e.ExamID
JOIN Courses c ON e.CourseID = c.CourseID
WHERE s.StudentID = @StudentID;
END;

EXEC sp_GetStudentMarks
@StudentID = 1;

SELECT * FROM Marks;

--Assignment_5
CREATE PROCEDURE sp_UpdateMarks
@MarkID INT,
@NewMarks INT
AS
BEGIN
UPDATE Marks
SET MarksObtained = @NewMarks
WHERE MarkID = @MarkID;

SELECT * FROM Marks WHERE MarkID = @MarkID;
END;

EXEC sp_UpdateMarks
@MarkID = 1,
@NewMarks = 92;

SELECT * FROM Marks;

--Assignment_6
CREATE PROCEDURE sp_DeleteEnrollment
@EnrollmentID INT
AS
BEGIN
DELETE FROM Enrollments
WHERE EnrollmentID = @EnrollmentID;
END;

EXEC sp_DeleteEnrollment
@EnrollmentID = 2;

SELECT * FROM Enrollments;

--Assignment_1
CREATE FUNCTION fn_GetGrade
(
@MarksObtained INT
)
RETURNS VARCHAR(10)
AS
BEGIN
DECLARE @Grade VARCHAR(10)

IF @MarksObtained >= 90
SET @Grade = 'A'
ELSE IF @MarksObtained >= 75
SET @Grade = 'B'
ELSE IF @MarksObtained >= 60
SET @Grade = 'C'
ELSE
SET @Grade = 'Fail'

RETURN @Grade
END;

SELECT
s.FirstName + ' ' + s.LastName AS StudentName,
m.MarksObtained,
dbo.fn_GetGrade(m.MarksObtained) AS Grade
FROM Students s
JOIN Marks m ON s.StudentID = m.StudentID;

--Assignment_2
CREATE FUNCTION fn_GetStudentAge
(
@DateOfBirth DATE
)
RETURNS INT
AS
BEGIN
DECLARE @Age INT

SET @Age = DATEDIFF(YEAR, @DateOfBirth, GETDATE())

RETURN @Age
END;

SELECT
FirstName + ' ' + LastName AS StudentName,
DateOfBirth,
dbo.fn_GetStudentAge(DateOfBirth) AS Age
FROM Students;

--Assignment_3
CREATE FUNCTION fn_GetTotalMarks
(
@StudentID INT
)
RETURNS INT
AS
BEGIN
DECLARE @TotalMarks INT

SELECT @TotalMarks = SUM(MarksObtained)
FROM Marks
WHERE StudentID = @StudentID

RETURN @TotalMarks
END;

SELECT StudentID,
dbo.fn_GetTotalMarks(StudentID) AS TotalMarks FROM Students;

--Assignment_4
CREATE FUNCTION fn_GetStudentCourses
(
@StudentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT
c.CourseName,
e.EnrollmentDate
FROM Enrollments e
JOIN Courses c
ON e.CourseID = c.CourseID
WHERE e.StudentID = @StudentID
);

SELECT * FROM dbo.fn_GetStudentCourses(1);

--Assignment_5
CREATE FUNCTION fn_GetDepartmentStudents
(
@DepartmentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT
StudentID,
FirstName + ' ' + LastName AS StudentName,
AdmissionDate
FROM Students WHERE DepartmentID = @DepartmentID
);

SELECT * FROM dbo.fn_GetDepartmentStudents(1);
