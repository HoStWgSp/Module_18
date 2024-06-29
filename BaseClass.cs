using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    abstract class BaseClass
    {
        public int Id { get; }
        public BaseClass(int id)
        {
            Id = id;
        }

        //  Метод для получения свойства обзекта
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Id}");
        }

        // метод для клонирования
        public abstract BaseClass Clone();
    }
}
