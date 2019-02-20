﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._12_Events
{
    class Events
    {
        public Events()
        {
            Student student = new Student("Aurel", 320);

            student.Actions += ShowAction;
            
            student.Move(10);

            student.Read("Goat with 3 kids");

            student.MoneyData();

            student.AddMoney(25);

            student.MoneyData();

            student.SpendMoney(145);

            student.MoneyData();

            student.SpendMoney(250);

            student.MoneyData();
            
        }

        private void ShowAction(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
