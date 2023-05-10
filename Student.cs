using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9_Pysachuk
{
    delegate void MyDel(int m);
    //Створюється клас Student
    //який містить поля name - ім'я студента та marks
    //- список оцінок студента, а також подію MarkChange,
    //яка буде відбуватися при додаванні оцінки студенту
    class Student
    {
        public string name;
        public List<int> marks;
        public event MyDel MarkChange;

        public void AddMark(int mark)
        {
            marks.Add(mark);
            Console.WriteLine($"Added grade  {mark} for student {name}");
            MarkChange?.Invoke(mark);


        }
    }
}
