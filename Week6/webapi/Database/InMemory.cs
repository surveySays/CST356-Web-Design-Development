using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                FirstName = "Tom",
                LastName = "Jones"
            },
            new Student {
                Id = 2,
                FirstName = "Mary",
                LastName = "Smith"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Email = "hello@gmail.con",
                FirstName = "Jamy",
                LastName = "James"
            },
            new Instructor {
                Email = "hi@gmail.con",
                FirstName = "Steven",
                LastName = "Long"
            }
        };
    }
}