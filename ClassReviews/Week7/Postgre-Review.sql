
create schema academic;
set search_path to academic;

 
-- students, courses, instructors, enrollments, examinations and results.

create table students(
	student_id serial primary key,
	student_name varchar(100) not null,
	email varchar(100) unique not null,
	date_of_birth date,
	department varchar(100) not null
);

insert into students (student_name, email, date_of_birth, department) values
('Kashvi', 'kashvi@gmail.com', '2005-02-20', 'CSE'),
('Aarushi', 'aarushi@gmail.com', '2003-02-09','BBA'),
('Bhumi', 'bhumi@gmail.com', '2001-02-10', 'CSE'),
('Cella', 'cella@gmail.com', '2003-02-12','CSE')


create table instructors(
	instructor_id serial primary key,
	instructor_name varchar(100) not null,
	email varchar(100) not null unique
);

insert into instructors (instructor_name, email) values
('dr. a' , 'a@gmail.com'),
('dr. b' , 'b@gmail.com'),
('dr. c' , 'c@gmail.com'),
('dr. d' , 'd@gmail.com')


create table courses(
	course_id serial primary key,
	course_code varchar(100) not null unique,
	course_name varchar(100) not null,
	credits int not null check (credits>0),
	instructor_id int not null,
	foreign key(instructor_id) references instructors(instructor_id)
);

insert into courses (course_code, course_name, credits, instructor_id) values
('CS101', 'English', 4,1),
('CS102', 'Hindi', 5,2),
('CS103', 'Maths', 2,3),
('CS104', 'Science', 2,4)



create table enrollments(
	enrollment_id serial primary key,
	student_id int not null,
	course_id int not null,
	enrollment_date date not null,
	foreign key (course_id) references courses(course_id),
	foreign key (student_id) references students(student_id),
	unique(student_id, course_id)
);
insert into enrollments (student_id, course_id, enrollment_date) values
(1,1,'2026-07-12'),
(1,2,'2026-07-12'),
(1,3,'2026-07-12'),
(1,4,'2026-07-12'),
(2,1,'2026-07-12'),
(2,2,'2026-07-12'),
(2,3,'2026-07-12'),
(2,4,'2026-05-12'),
(3,1,'2026-07-12'),
(3,2,'2026-07-12'),
(3,3,'2024-07-12'),
(3,4,'2026-07-12'),
(4,1,'2026-07-12'),
(4,2,'2026-07-12'),
(4,3,'2026-07-12'),
(4,4,'2026-07-12')



create table examinations(
	exam_id serial primary key,
	course_id int not null,
	exam_name varchar(100) not null,
	exam_date date not null,
	max_marks numeric(5,2) not null check (max_marks>0),
	foreign key(course_id) references courses(course_id)
);

insert into examinations (course_id, exam_name, exam_date, max_marks) values
(1,'English Exam', '2026-02-12', 100),
(2,'Hindi Exam', '2026-04-12', 100),
(3,'Maths Exam', '2026-06-12', 100),
(4,'Science Exam', '2026-08-12', 100)

create table results(
	result_id serial primary key,
	exam_id int not null,
	student_id int not null,
	marks numeric(5,2) not null,
	grade varchar(2),
	unique(exam_id,student_id),
	foreign key(exam_id) references examinations(exam_id),
	foreign key (student_id) references students(student_id),
	check(marks>=0 and marks<=100)
);

insert into results(exam_id,student_id, marks) values
(1,1,89),
(1,2,92),
(1,3,95),
(1,4,12),
(2,1,89),
(2,2,32),
(2,3,45),
(2,4,82),
(3,1,79),
(3,2,62),
(4,3,35),
(4,4,2)



-- Joins to display student-course-result information.
select * from students s 
join results r on s.student_id=r.student_id
join examinations e on e.exam_id=r.exam_id
join courses c on c.course_id=e.course_id
order by s.student_id;
--CTE to calculate course-wise average marks.

with course_avg as(
	select c.course_name, avg(r.marks) as avg_marks
	from courses c
	join examinations e on c.course_id =e.course_id
	join results r on r.exam_id=e.exam_id
	group by c.course_name
)
select * from course_avg; 

--Subquery to identify students scoring above the course average.
select s.student_name, c.course_name, r.marks
from students s
join results r on s.student_id=r.student_id
join examinations e on e.exam_id=r.exam_id
join courses c on e.course_id = c.course_id
where r.marks >(
	select avg(r1.marks) from results r1
	join examinations e2 on r1.exam_id= e2.exam_id
	where e2.course_id=c.course_id
);

--Temporary table containing students eligible for distinction.

create temporary table distinction_student as
	select s.student_name, c.course_name, r.marks
	from students s 
	join results r on s.student_id= r.student_id
	join examinations e on r.exam_id=e.exam_id
	join courses c on e.course_id=c.course_id
	where r.marks>=60;

select * from distinction_student;


--View for student academic performance.
create or replace view student_academic_performace as
select s.student_id, s.student_name, c.course_code, c.course_name, r.marks, r.grade
from students s
join results r on s.student_id=r.student_id
join examinations e on r.exam_id=e.exam_id
join courses c on e.course_id=c.course_id;

select * from student_academic_performace;

select * from courses;
select * from results;
select * from examinations;

--UDF to calculate grade based on marks.
create or replace function calculate_grade(p_marks numeric)
returns varchar
language plpgsql
as $$
begin
	if p_marks>=90 then return 'A+';
	elsif p_marks>=80 then return 'A';
	elsif p_marks>=70 then return 'B';
	elsif p_marks>=60 then return 'C';
	elsif p_marks>=50 then return 'D';
	else	return 'F';
	end if;
end;
$$;

select calculate_grade(30);
select calculate_grade(98);
select calculate_grade(76);



--Stored procedure to publish examination results.
create or replace procedure publish_examination_results(p_exam_id int)
language plpgsql
as $$
begin
	update results set grade= calculate_grade(marks)
	where exam_id=p_exam_id;
	
	raise notice 'Results are PUBLISHED!!!! %', p_exam_id;
end;
$$;
call publish_examination_results(1);
select * from results where exam_id=1;


--Trigger preventing marks outside the valid range.
create or replace function validate_marks()
returns trigger
language plpgsql
as 
$$
begin
	if new.marks< 0 or new.marks> 100 then 
		raise exception 'Marks must be between 0 and 100';
	end if;
	return new;
end;
$$;
create trigger trigger_validate_marks
before insert or update on results
for each row
execute function validate_marks();

insert into results(exam_id, student_id, marks)
values (1,1,110); -- failed
insert into results(exam_id, student_id, marks)
values (4,2,59); -- passed



--Cursor to generate student result summaries.
do $$
declare 
	record RECORD;
	
	student_cursor cursor for 
	select s.student_name, avg(r.marks) as avg_marks
	from students s 
	join results r on s.student_id= r.student_id
	group by s.student_name;

	
begin
	open student_cursor;
	
	loop
		fetch student_cursor into RECORD;
		exit when not found;

		raise notice 'student name: %, average marks: %', RECORD.student_name, RECORD.avg_marks;

	end loop;

	close student_cursor;
end $$;



--Indexes on student ID, course ID and enrollment.
create index index_students_student_id on students(student_id);
create index index_students_course_id on courses(course_id);
create index index_students_enrollment_id on enrollments(enrollment_id);
create index index_enrollments_student_id on enrollments(student_id);
create index index_enrollments_course_id on enrollments(course_id);


--Transaction and locking while publishing results.

select * from students;
select * from instructors;
select * from courses;
select * from enrollments;
select * from examinations;
select * from results;

begin;

select *
from results
where exam_id = 1
for update;

update results
set grade = calculate_grade(marks)
where exam_id = 1;

commit;




--Create an academic schema and configure user privileges.
create role academic_user login password 'Admin123';
grant usage on schema academic to academic_user;
grant select on students to academic_user;
revoke select on students from academic_user;


