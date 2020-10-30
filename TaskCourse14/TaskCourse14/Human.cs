using System;
using System.Collections.Generic;
using System.Text;


/*Создайте метод, который будет выводить информацию 
 * о количестве детей у человека. Метод принимает имя человека
 * и количество (nullable). Метод должен выводить: неизвестно, 
 * нет детей и сообщение о количестве детей.
*/



namespace TaskCourse14
{
    class Human
    {
        private int? count;
        private String name;

        public Human(int? count, string name)
        {
            this.count = count;
            this.name = name;
        }

       /* public Human(string name) 
        {
            this.name = name;
        }*/


        public String Show_children() 
        {
            return (count > 0) ? (count + "  детей") : (count == 0) ? ("нет детей"):("неизвестно");
        }
    }
}
