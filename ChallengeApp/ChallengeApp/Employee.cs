namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value.");
            }

        }

        public void AddGrade(int grade)
        {

            float value = grade;
            this.AddGrade(value);
        }

        public void AddGrade(double grade)
        {

            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(long grade)
        {

            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String isn't float.");
            }

        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0; // pętlą "do while"
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            while (index < this.grades.Count);


            //foreach (var grade in this.grades)
            //{
            //    statistics.Max = Math.Max(statistics.Max, grade);
            //    statistics.Min = Math.Min(statistics.Min, grade);
            //    statistics.Average += grade;
            //}

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

    }
}
