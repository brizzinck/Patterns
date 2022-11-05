using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Conveyor
    {
        public void On() => Console.WriteLine("Конвейер запущен");
        public void Off() => Console.WriteLine("Конвейер остановлен");
        public void SpeedIncrease() => Console.WriteLine("Увеличена скорость конвейре");
        public void SpeedDecrease() => Console.WriteLine("снижена скорость конвейре");
    }
}
