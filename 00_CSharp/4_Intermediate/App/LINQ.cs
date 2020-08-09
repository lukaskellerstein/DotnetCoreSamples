using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace App
{


    static class MyLINQ
    {

        public static void Run()
        {

            var (projects, persons) = InitializeCollection();

            // --------------------------------------------
            // SELECT -----------------------------------
            // --------------------------------------------
            var roleUsers = from person in persons
                            select person.role;

            // tuple - immutable
            var s1 = from person in persons
                     select (person.uid, person.name);

            // anonymous type/class = mutable
            var s2 = from person in persons
                     select new { person.uid, person.name };


            // select in select
            var s3 = from x in persons
                     from y in x.projects
                     select y;

            // --------------------------------------------
            // WHERE ------------------------------------
            // --------------------------------------------
            var roleUsers2 = from x in persons
                             where x.age > 40
                             select x.role;

            // --------------------------------------------
            // GROUP ------------------------------------
            // --------------------------------------------
            var aa = from x in persons
                     group x by x.role;

            // --------------------------------------------
            // ORDER BY ---------------------------------
            // --------------------------------------------
            var bb = from x in persons
                     orderby x.age ascending
                     select (x.name, x.age);


            // --------------------------------------------
            // JOIN ---------------------------------------
            // --------------------------------------------
            // var query = from x in projects
            //             join y in persons on x equals y.projects
            //             select new { project = x.name, person = y.name };


            var q1 = from x in persons
                     from y in projects
                     where x.projects.Contains(y.uid)
                     select new { persons = x.name, projects = y.name };

            // statistics -------------------

            // min
            var a0 = (from x in persons
                      where x.age > 20
                      select x.age).ToList().Min();

            // max
            var a1 = (from x in persons
                      where x.age > 20
                      select x.age).ToList().Max();

            // avg
            var a2 = (from x in persons
                      where x.age > 20
                      select x.age).ToList().Average();

            // sum
            var a3 = (from x in persons
                      where x.age > 20
                      select x.age).ToList().Sum();




            int i = 5;
        }

        static (List<Project> projects, List<Person> persons) InitializeCollection()
        {
            var InProjects = new List<Project>{
                    new Project{
                        uid = Guid.NewGuid().ToString(),
                        name = "Project Water sustainability"
                    },
                    new Project{
                        uid = Guid.NewGuid().ToString(),
                        name = "Project Aero"
                    },
                    new Project
                    {
                        uid = Guid.NewGuid().ToString(),
                        name = "Project Space"
                    },
                    new Project
                    {
                        uid = Guid.NewGuid().ToString(),
                        name = "Project Ground"
                    }
                };

            var InPersons = new List<Person>{
                    new Person{
                        uid = Guid.NewGuid().ToString(),
                        name = "Karel Omacka",
                        age = new Random().Next(1,100),
                        role = "Admin",
                        projects = (from x in InProjects select x.uid).ToList()
                    },
                    new Person{
                        uid = Guid.NewGuid().ToString(),
                        name = "Petr Zalesak",
                        age = new Random().Next(1,100),
                        role = "Dev",
                        projects = new List<string>{ InProjects[0].uid, InProjects[1].uid}
                    },
                    new Person
                    {
                        uid = Guid.NewGuid().ToString(),
                        name = "Jakub Vodak",
                        age = new Random().Next(1, 100),
                        role = "Dev",
                        projects = new List<string>{ InProjects[2].uid, InProjects[3].uid}
                    },
                    new Person
                    {
                        uid = Guid.NewGuid().ToString(),
                        name = "Michal Hanzal",
                        age = new Random().Next(1, 100),
                        role = "User",
                        projects = new List<string>{ InProjects[2].uid}
                    },
                    new Person
                    {
                        uid = Guid.NewGuid().ToString(),
                        name = "Karolina Ptackova",
                        age = new Random().Next(1, 100),
                        role = "User",
                        projects = new List<string>{ InProjects[3].uid}
                    }
                };

            return (
                projects: InProjects,
                persons: InPersons
            );
        }
    }

    class Person
    {
        public string uid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string role { get; set; }

        public List<string> projects { get; set; }
    }

    class Project
    {
        public string uid { get; set; }
        public string name { get; set; }
    }
}