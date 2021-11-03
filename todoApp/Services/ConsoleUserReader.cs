using System;
using Services.Interfaces;

namespace Services
{
    public class ConsoleUserReader : IUserInputReader
    {
        public string Read() => Console.ReadLine();
    }
}