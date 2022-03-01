using TheSchool.Models;
using System;

namespace TheSchool
{
    class Program
    {
        static void Main(string[] args)
		{
			Supervisor[] supervisors = new Supervisor[]
			{
				new Supervisor("Igor", "Pinzari", "8736260016547", "Moscow, 24 Komsomolyskaia, flat 54", "-"),
				new Supervisor("Igor", "Mocan", "8747285600134", "Orhei, 24 Independentei, house", "078340023"),
				new Supervisor("Stanislav", "V", "8300126653926", "Orhei, 26 Independentei, house", "078340023"),
				new Supervisor("Maria", "Gusan", "9847538018012", "Chisinau, 65 Lev Tolstoi, flat 178", "060057601"),
				new Supervisor("Ion", "Palchin", "7647297627101", "Orhei, 56 Florilor, house", "078560010"),
				new Supervisor("Angela", "Mamaliga", "7693675492546", "Orhei, 34 Dumbrava, house", "069563497"),
				new Supervisor("Anastasia", "Mariuta", "9845001236754", "Chisinau, 57/2 Moscovei, flat 187", "061236754")
			};

			Student[] students = new Student[]
			{
				new Student("Ana", "Pinzari", "6538265002912", "Chisinau, 3/1 Tecuci, flat 154", "060066588",
				7, true, new Supervisor[] { supervisors[0] }),

				new Student("Dorin", "Mocan", "8753990261436", "Chisinau, 6 Ciuflea, flat 12", "078543600",
				7, false, new Supervisor[] { supervisors[1] }),

				new Student("Sergiu", "Mocan", "5628770015437", "Chisinau, 6 Ciuflea, flat 12", "078654378",
				7, false, new Supervisor[] { supervisors[1] }),

				new Student("Andrei", "Gusan", "8738001252876", "Chisinau, 24/2 Lev Tolstoi, flat 65", "068540026",
				8, false, new Supervisor[] { supervisors[3] }),

				new Student("Gleb", "Palchin", "7499002464538", "Chisinau, 56 Grigore Vieru, flat 112", "078540001",
				7, false, new Supervisor[] { supervisors[4] }),

				new Student("Roma", "V", "8437280016427", "Orhei, 26 Independentei, house", "079540027",
				8, false, new Supervisor[] { supervisors[2] }),

				new Student("Daniela", "Mamaliga", "3004528822145", "Chisinau, 56 Grigore Vieru, flat 112", "079653801",
				7, true, new Supervisor[] { supervisors[5] }),

				new Student("Dorin", "Mariuta", "8746350653725", "Chisinau, 98 Muncesti, flat 6", "069564328",
				8, false, new Supervisor[] { supervisors[6] })
			};

			#region Add students to supervisors
			supervisors[0].Students = new Student[]
			{
				students[0]
			};

			supervisors[1].Students = new Student[]
			{
				students[1],
				students[2]
			};

			supervisors[2].Students = new Student[]
			{
				students[5]
			};

			supervisors[3].Students = new Student[]
			{
				students[3]
			};

			supervisors[4].Students = new Student[]
			{
				students[4]
			};

			supervisors[5].Students = new Student[]
			{
				students[6]
			};

			supervisors[6].Students = new Student[]
			{
				students[7]
			};
			#endregion

			Teacher[] teachers = new Teacher[]
			{
				new Teacher("Maria", "Cebotari", "6593762657965", "Chisinau, 6 Milescu Spataru, flat 99", "078543401", 6724.02f),
				new Teacher("Leonid", "Macari", "3700137652975", "Chisinau, 132 Ion Creanga, flat 123", "078453276", 8230.76f)
			};

			Group[] groups = new Group[]
			{
				new Group(GroupName.A, Grade._1st,
				new Student[] { students[5], students[6], students[7] },
				new Register(
					new Mark[]
					{
						new Mark(Simester._1st, students[5], Subject.English, teachers[0], 8.02f),
						new Mark(Simester._1st, students[5], Subject.Maths, teachers[1], 5.5f),
						new Mark(Simester._2nd, students[5], Subject.English, teachers[0], 7.59f),
						new Mark(Simester._2nd, students[5], Subject.Maths, teachers[1], 5.78f)
					})),

				new Group(GroupName.B, Grade._1st,
				new Student[] { students[0], students[1], students[2], students[3], students[4] },
				new Register(
					new Mark[]
					{
						new Mark(Simester._1st, students[0], Subject.English, teachers[0], 10),
						new Mark(Simester._1st, students[0], Subject.Maths, teachers[1], 5.5f),
						new Mark(Simester._2nd, students[0], Subject.English, teachers[0], 10),
						new Mark(Simester._2nd, students[0], Subject.Maths, teachers[1], 5.78f),
						new Mark(Simester._1st, students[1], Subject.English, teachers[0], 9.08f),
						new Mark(Simester._1st, students[1], Subject.Maths, teachers[1], 10),
						new Mark(Simester._2nd, students[1], Subject.English, teachers[0], 9.29f),
						new Mark(Simester._2nd, students[1], Subject.Maths, teachers[1], 10)
					}))
			};

			#region Add marks to students
			students[0].Marks = new Mark[]
			{
				groups[1].Register.Marks[0],
				groups[1].Register.Marks[1],
				groups[1].Register.Marks[2],
				groups[1].Register.Marks[3]
			};
			students[1].Marks = new Mark[]
			{
				groups[1].Register.Marks[4],
				groups[1].Register.Marks[5],
				groups[1].Register.Marks[6],
				groups[1].Register.Marks[7]
			};
			students[5].Marks = new Mark[]
			{
				groups[0].Register.Marks[0],
				groups[0].Register.Marks[1],
				groups[0].Register.Marks[2],
				groups[0].Register.Marks[3]
			};
			#endregion

			#region Add teachers roles
			teachers[0].Roles = new TeacherRole[]
			{
				new TeacherRole(Subject.English, new Group[] { groups[0], groups[1] }),
				new TeacherRole(Subject.EnglishLanguageAndLiterature, new Group[] { groups[0], groups[1] })
			};

			teachers[1].Roles = new TeacherRole[]
			{
				new TeacherRole(Subject.Maths, new Group[] { groups[0], groups[1] })
			};
			#endregion

			Administrator administrator = new Administrator("Kiriyshka", "Pinzari", "6754209002322", "Chisinau, 3/1 Tecuci, flat 154",
				"060066599", 12580);

            School school = new School(teachers, groups, administrator);

			float[] avgMarks = CalculateAvgMarksForStudents(students, groups, school);

			for (int i = 0; i < avgMarks.Length; i++)
            {
				Console.WriteLine(avgMarks[i]);
            }

			Console.ReadKey();
		}

		private static float[] CalculateAvgMarksForStudents(Student[] students, Group[] groups, Models.School school)
		{
			var index = 0;
			var avgMarks = new float[students.Length];
			for (int i = 0; i < school.Groups.Length; i++)
			{
				for (int j = 0; j < school.Groups[i].Students.Length; j++)
				{
					var avgMark = CalculateAvgMarkForStudent(groups[i].Students[j].Id, school.Groups[i].Register);
					avgMarks[index] = avgMark;
					index++;
				}
			}
			return avgMarks;
		}

		private static float CalculateAvgMarkForStudent(string studentId, Register register)
		{
			var allMarks = register.Marks;
			var sumOfMarks = 0f;
			var numberOfMarks = 0;
			for (int i = 0; i < allMarks.Length; i++)
			{
				if (allMarks[i].Student.Id != studentId) continue;
				sumOfMarks += allMarks[i].Value;
				numberOfMarks++;
			}

			var avgMark = sumOfMarks / numberOfMarks;

			return avgMark;
		}
	}
}
    