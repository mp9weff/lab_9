using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9_Pysachuk
{
    //Створюється клас Parent, який містить поле name -
    //ім'я батьків, а також метод OnMarkChange, який
    //буде викликатися при зміні оцінки студента
    class Parent
    {
        public string name;

        public void OnMarkChange(int mark)
        {
            Console.WriteLine($"{name} received mark {mark}");
        }
    }
}
