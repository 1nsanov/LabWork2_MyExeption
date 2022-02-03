using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class MagazineException : Exception
    {
        public override string Message { get; }

        public MagazineException() :base("Недопустимое значение для данной переменной. Только больше нуля")
        {
        }

        public MagazineException(string message) : base(message)
        {
        }

        public MagazineException(string message, Exception innerException) : base(message, innerException)
        {
            Message = "Некорректный ввод данных...";
        }

    }
}
