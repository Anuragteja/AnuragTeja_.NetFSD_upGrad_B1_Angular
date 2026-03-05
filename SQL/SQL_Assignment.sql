
-- 1. Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>.
SELECT FIRST_NAME AS 'WORKER-NAME' FROM Worker;
-- 2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.
select upper(FIRST_NAME) FROM Worker;
-- 3. Write an SQL query to fetch unique values of DEPARTMENT from Worker table.
SELECT DISTINCT DEPARTMENT FROM Worker;

-- 4. Write an SQL query to print the first three characters of  FIRST_NAME from Worker table.
SELECT SUBSTRING(FIRST_NAME, 1, 3) as FIRST_THREE_CHARS FROM Worker;

-- 5. Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.
SELECT CHARINDEX('a', FIRST_NAME) AS Position_Of_A FROM Worker
WHERE FIRST_NAME = 'Amitabh';
-- 6. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.
SELECT RTRIM(FIRST_NAME) AS Clean_First_Name
FROM Worker;

-- 7. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.
SELECT lTRIM(DEPARTMENT) AS Clean_First_Name
FROM Worker;

-- 8. Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.
SELECT DISTINCT 
       DEPARTMENT,
       LEN(DEPARTMENT) AS Department_Length
FROM Worker;

-- 9. Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’.
SELECT REPLACE(FIRST_NAME, 'a', 'A') AS Modified_First_Name
FROM Worker;

-- 10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.
SELECT CONCAT(FIRST_NAME, ' ', LAST_NAME) AS FULL_NAME
FROM Worker;

-- 11. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.
SELECT *
FROM Worker
ORDER BY FIRST_NAME;

-- 12. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.
SELECT * FROM Worker ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;

-- 13. Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.
SELECT *  FROM Worker WHERE FIRST_NAME IN ('Vipul' , 'Satish');

-- 14. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.
SELECT * FROM Worker WHERE FIRST_NAME NOT IN ('Vipul' , 'Satish');

-- 15. Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.
SELECT * FROM Worker WHERE DEPARTMENT = 'Admin';

-- 16. Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a%' OR FIRST_NAME LIKE '%A%';

-- 17. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a' OR FIRST_NAME LIKE '%A';

-- 18. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%h' AND LEN(FIRST_NAME) = 6;

-- 19. Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.
SELECT * 
FROM Worker
WHERE SALARY BETWEEN 100000 AND 500000;

-- 20. Write an SQL query to print details of the Workers who have joined in Feb’2014.
SELECT *  FROM Worker WHERE JOINING_DATE BETWEEN '2014-02-01' AND '2014-02-28 23:59:59';

-- 21. Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000.
SELECT FIRST_NAME, LAST_NAME FROM Worker WHERE SALARY >=50000 AND SALARY <=100000;
-- 22. Write an SQL query to fetch the no. of workers for each department in the descending order.
SELECT DEPARTMENT, COUNT(*) AS No_Of_Workers
FROM Worker
GROUP BY DEPARTMENT
ORDER BY No_Of_Workers DESC;

-- 23. Write an SQL query to print details of the Workers who are also Managers
SELECT W.*
FROM Worker W
INNER JOIN Title T
ON W.WORKER_ID = T.WORKER_REF_ID
WHERE T.WORKER_TITLE = 'Manager';

-- 24.Write an SQL query to show the current date and time.
SELECT GETDATE() AS Current_Date_Time;

-- 25.Write an SQL query to show the top n (say 10) records of a table.
SELECT *
FROM Worker
ORDER BY WORKER_ID
OFFSET 0 ROWS
FETCH NEXT 10 ROWS ONLY;
