namespace HelloClassAndObject
{
    internal class TranslateJavaScript
    {
        public static void Demo1()
        {
            /*
             JS:
             let person1 = {
                firstName: 'Terje',
                age: 47,
             };

             let person2 = {};
             person2.firstName = 'Terje';
             person2.age = 47;
             */

            var person1 = new Person
            {
                FirstName = "Terje",
                Age = 47
            };

            var person2 = new Person();
            person2.FirstName = "Terje";
            person2.Age = 47;
        }

        public static void Demo2()
        {
            /*
            JS:
            let people1 = [
                {
                   firstName: 'Terje',
                   age: 47,
                },
                {
                   firstName: 'Per',
                   age: 27,
                },
            ];
            */

            var people1 = new Person[2];
            people1[0] = new Person
            {
                FirstName = "Terje",
                Age = 47
            };
            people1[1] = new Person
            {
                FirstName = "Per",
                Age = 27
            };

            var people = new Person[]
            {
                new Person
                {
                    FirstName = "Terje",
                    Age = 47
                },
                new Person
                {
                    FirstName = "Per",
                    Age = 27
                }
            };
        }

        public static void Demo3()
        {
            /*
            JS:
            let model = {
                currentUser: 'Terje',
                people: [
                    {
                       firstName: 'Terje',
                       age: 47,
                    },
                    {
                       firstName: 'Per',
                       age: 27,
                    },
                ],
            };
            */
            var model = new Model
            {
                CurrentUser = "Terje",
                People = new Person[]
                {
                    new Person
                    {
                        FirstName = "Terje",
                        Age = 47
                    },
                    new Person
                    {
                        FirstName = "Per",
                        Age = 27
                    }
                }
            };
        }

        public static void Demo4()
        {
            // JSON
            var searchResult = new SearchResult
            {
                total = 17,
                result = new Result[]
                {
                    new Result()
                }
            };
        }
    }
}
