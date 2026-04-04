using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Contracts
{
    /// <summary>
    /// Интерфейс комплексного числа и операций над ним
    /// </summary>
    public interface IComplexNumber
    {
        // ===== Свойства =====

        /// <summary>
        /// Действительная часть (Re)
        /// </summary>
        double Real { get; }

        /// <summary>
        /// Мнимая часть (Im)
        /// </summary>
        double Imaginary { get; }

        /// <summary>
        /// Модуль комплексного числа: √(Re² + Im²)
        /// </summary>
        double Magnitude { get; }

        // ===== Арифметические операции =====

        /// <summary>
        /// Сложение: this + other
        /// </summary>
        IComplexNumber Add(IComplexNumber other);

        /// <summary>
        /// Вычитание: this - other
        /// </summary>
        IComplexNumber Subtract(IComplexNumber other);

        /// <summary>
        /// Умножение: this * other
        /// </summary>
        IComplexNumber Multiply(IComplexNumber other);

        /// <summary>
        /// Деление: this / other
        /// Выбрасывает исключение при делении на ноль
        /// </summary>
        IComplexNumber Divide(IComplexNumber other);

        // ===== Сравнение =====

        /// <summary>
        /// Проверка на равенство (совпадают Re и Im)
        /// </summary>
        bool Equals(IComplexNumber other);

        /// <summary>
        /// Сравнение по модулю: this > other
        /// </summary>
        bool IsGreaterThan(IComplexNumber other);

        /// <summary>
        /// Сравнение по модулю: this < other
        /// </summary>
        bool IsLessThan(IComplexNumber other);

        /// <summary>
        /// Сравнение по модулю: this >= other
        /// </summary>
        bool IsGreaterOrEqual(IComplexNumber other);

        /// <summary>
        /// Сравнение по модулю: this <= other
        /// </summary>
        bool IsLessOrEqual(IComplexNumber other);

        // ===== Представление =====

        /// <summary>
        /// Строковое представление вида "a + bi"
        /// </summary>
        string ToString();
    }
}