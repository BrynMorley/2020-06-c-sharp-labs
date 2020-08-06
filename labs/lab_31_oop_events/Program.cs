using System;

namespace lab_31_oop_events
{
    class Program
    {
        static void Main(string[] args)
        {
            // goal: annual event (triggered by time)

            var james = new Child("James");

            james.AnotherYearOlder();
        }
    }

    class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }

        delegate void BirthdayDelegate(int age);

        event BirthdayDelegate BirthdayEvent;

        public Child(string name)
        {
            this.Name = name;
            this.Age = 0;
            BirthdayEvent += Celebrate;
        }

        void Celebrate(int age)
        {
            Console.WriteLine($"Congratulations !!! You have reached the age of {age}!");
        }

        public void AnotherYearOlder()
        {
            this.Age++;
            BirthdayEvent(this.Age);
        }
    }
}

