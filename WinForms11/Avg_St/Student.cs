namespace Avg_St
{
    public class Student
    {
        // Клас и номер в класа
        public int Class { get; set; }
        public int Number { get; set; }

        // Име на ученика
        public string Name { get; set; }

        // Оценки по предметите
        public double Bel { get; set; }        // БЕЛ
        public double Foreign { get; set; }    // Чужд език
        public double Math { get; set; }       // Математика
        public double Physics { get; set; }    // Физика
        public double Chemistry { get; set; }  // Химия
        public double Biology { get; set; }    // Биология

        // Конструктор за удобно създаване на обект
        public Student(int cls, int number, string name,
                       double bel, double foreign, double math,
                       double physics, double chemistry, double biology)
        {
            Class = cls;
            Number = number;
            Name = name;

            Bel = bel;
            Foreign = foreign;
            Math = math;
            Physics = physics;
            Chemistry = chemistry;
            Biology = biology;
        }

        // Свойство за среден успех
        public double Average
        {
            get
            {
                return (Bel + Foreign + Math +
                        Physics + Chemistry + Biology) / 6.0;
            }
        }

        // метод, който връща средния успех
        public double GetAverage()
        {
            return Average;
        }
    }
}
