using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacjaperson

    {
        enum Gender
        {
            Male,
            Female,
            No_Gender
        }

        class person1
        {

            private DateTime Birth;

            private Gender Gender;


            public person1()
            {

                Random n = new Random();

                int day = n.Next(1, 31);
                int month = n.Next(1, 13);
                int year = n.Next(1920, 2024);

                this.Birth = new DateTime(year, month, day);

                Array genders = Enum.GetValues(typeof(Gender));
                this.Gender = (Gender)genders.GetValue(n.Next(genders.Length));
            }

            public DateTime BirthDate
            {
                get { return this.Birth; }
                set { this.Birth = value; }
            }

            public Gender GetGender
            {
                get { return this.Gender; }
                set { this.Gender = value; }
            }
        }
    }
