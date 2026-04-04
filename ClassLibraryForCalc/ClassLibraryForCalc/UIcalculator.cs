using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Contracts
{
    
    /// Интерфейс пользовательского взаимодействия с калькулятором
   
    public interface ICalculatorUI
    {
        
        IComplexNumber ReadComplexNumber(string prompt);

        string ReadOperation();

        void Result(string result);

        void Error(string message);

        void Run();
    }
}