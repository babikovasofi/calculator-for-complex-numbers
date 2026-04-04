using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Contracts
{
    /// <summary>
    /// Интерфейс пользовательского взаимодействия с калькулятором
    /// </summary>
    public interface ICalculatorUI
    {
        /// <summary>
        /// Считывает комплексное число от пользователя
        /// </summary>
        IComplexNumber ReadComplexNumber(string prompt);

        /// <summary>
        /// Считывает выбранную пользователем операцию
        /// </summary>
        string ReadOperation();

        /// <summary>
        /// Отображает результат вычисления
        /// </summary>
        void DisplayResult(string result);

        /// <summary>
        /// Отображает сообщение об ошибке
        /// </summary>
        void DisplayError(string message);

        /// <summary>
        /// Запускает главный цикл приложения
        /// </summary>
        void Run();
    }
}