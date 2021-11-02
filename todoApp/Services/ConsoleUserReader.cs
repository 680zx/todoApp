using System;
using todoApp.Services.Interfaces;

namespace todoApp.Services
{
    public class ConsoleUserReader : IUserInputReader
    {
        public string Read() => Console.ReadLine();
    }
}