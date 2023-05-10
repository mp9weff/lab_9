using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9_Pysachuk
{
    //Створюється клас Account, який містить метод
    //PaymentOfAScholarship, який буде викликатися
    //при зміні оцінки студента та перевіряє, чи є
    //студент притендент  на отримання стипендії
    class Account
    {
        public void PaymentOfAScholarship(bool scholarship, string studentName)
        {
            if (scholarship)
            {
                Console.WriteLine($"Student  {studentName} is eligible for scholarship");
            }
            else
            {
                Console.WriteLine($"Student  {studentName} is not eligible for scholarship");
            }
        }
    }
}
