# PRN211_LAB1
Classes:
1.	People: abstract base class 
a)	Properties:
•	ID Card: is a number and has 9 digits
•	Fullname: contains alphabet character and space character, most 50 characters.
•	Birthday: 1-1-1900 <= birthday <= Today
•	Address: not be blank
•	Email: can be blank or be valid email address.
•	Phone
b)	Methods:
•	ToString(): override from ToString() method of “object” object, return  a string that contains information about people (full name, age and phone)
•	getAge(): return age of people 
•	inputPeople(): input all information of People 
•	printInfo(): abstract method, display information about full name, birthday and other information
c)	Constructors:
•	No parameter
•	1 parameter set value for full name
•	6 parameters set value for 6 properties

2.	Student: inherits from People class
a.	Properties:
•	RollNo: from A12001-A12999
•	ClassNo:  CP / DI / DM + year + month + G/H/I/J/K/F/M + xx
Example: CP201210G17 or DM201301M05
b.	Indexers: 
•	Marks: all of marks: mark in from 0 to 100
c.	Methods:
•	getAvgMark: calculate the average marks of the student
•	inputStudent(): input all information of Student (inherits from inputPeople() method of base class)
•	printInfo(): inherits from base class, display information about full name, birthday,  rollno, classno
d.	Constructors: 
•	No parameter and 1 parameter: inherit from constructors base class
•	8 parameters set value for 8 properties: inherits from constructors base class (which has 6 parameters) and modify itself.

3.	Teacher: inherits from People class
a.	Properties:
•	TeacherCode: has a number from A0001 to A9999 or B0001-B9999
•	JoinedDate: the date that the teacher started teaching.
b.	Indexers: 
•	Subjects: all of subjects that the teacher can teach
c.	Methods:
•	getWorkedYears: calculate number of years that the teacher has taught
•	inputTeacher(): input all information of Teacher (inherits from inputPeople() method of base class)
•	printInfo(): inherits from base class, display information about full name, number of year old,  workedyear
d.	Constructors: 
•	No parameter and 1 parameter: inherit from constructors base class
•	8 parameters set value for 8 properties: inherits from constructors base class (which has 6 parameters) and modify itself.

4.	Subject: 
a.	Properties:
•	SubjectCode: 6 alphabet characters
•	SubjectName: has most 50 characters
•	Theory: number of theory lessons 0<=Theory <=100
•	Practice: number of practice lessons 0<= Practice <=100
b.	Methods:
•	getTotalLessons: return total number of lessons (theory and practice)
•	ToString(): override from ToString() method of “object” object, return  a string that contains information about subject code, subject name and total number of lessons.
•	inputSubject(): enter the information of subject.
•	printInfo(): display all of information about subject.

c.	Constructors: 
•	No parameter 
•	4 parameters set value for 4 properties

5.	Marks: abstract base class
a.	Properties:
•	Marks: 0<= Marks <=100
•	PassLevel: 40<= Marks <=100
b.	Methods:
•	checkPass(): return true if the marks is pass, otherwise return false 
•	getBonus(): abstract method,  return true or false
6.	IMarks: interface
Methods:
•	inputMarks(): input information about marks
•	printMarks(): print information about marks

7.	Marks_Subject: inherits from Imarks and Marks class
a.	Properties:
•	RollNo: from A12001-A12999
•	StudentName: contains alphabet character and space character, most 50 characters.
•	Subject: not be blank
•	TestTime: 1 <= TestTime <=4
b.	Methods:
•	ToString(): override from ToString() method of “object” object, return  a string that contains information about name of student, subject and marks.
c.	Constructors: 
•	No parameter 
•	With parameters to set all values of properties’ Marks class
Main propram:
Create a menu to allow user do all of functions of the program:
•	Manage student: Input student, calculate the average mark and display information of student
•	Manage teacher:  Input teacher, display the number of years that the teacher has worked, display information of teacher
•	Manage Subject: Input subject, calculate total number of lessons and display all of information about the subject
•	Manage Marks: Input subject, calculate total number of lessons and display all of information about the subject, display the pass status of student.



