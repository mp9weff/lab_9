using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_9_Pysachuk
{
    class Program
    {
        //В функції Main створюється об'єкт класу Student,
        //задаються його параметри (ім'я студента та список
        //його оцінок), а також об'єкт класу Account, який буде
        //використовуватися для перевірки стипендії. Також до
        //події MarkChange підписуються метод PaymentOfAScholarship
        //об'єкта account та метод OnMarkChange об'єкта parent.
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Maria Pysachuk";
            student.marks = new List<int>();

            Account account = new Account();
            student.MarkChange += new MyDel((m) =>
            {
                double averageMark = student.marks.Average();
                bool scholarship;
                if (averageMark >= 71)
                {
                    scholarship = true;
                }
                else
                {
                    scholarship = false;
                }
                account.PaymentOfAScholarship(scholarship, student.name);
            });

            Parent parent = new Parent();
            parent.name = "Bogdan Pysachuk";
            student.MarkChange += new MyDel(parent.OnMarkChange);

            Console.WriteLine($"Student name: {student.name}");
            Console.WriteLine($"Parent name: {parent.name}");

            student.AddMark(50);
            student.AddMark(71);
            student.AddMark(88);
            student.AddMark(100);

        }

    }
}
