namespace CompareSimpleMaths
{
    using System;

    public class MathUtils<T>
    {
        /// <summary>
        /// sum the two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public T Sum(T firstNumber, T secondNumber)
        {
            return (dynamic)firstNumber + secondNumber;
        }

        /// <summary>
        /// from the first number subtract the second number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public T Subtract(T firstNumber, T secondNumber)
        {
            return (dynamic)firstNumber - secondNumber;
        }

        /// <summary>
        /// Increment current number by one 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public T Increment(dynamic number)
        {
            return number++;
        }

        /// <summary>
        /// multiply the two numbers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public T Multiply(T firstNumber, T secondNumber)
        {
            return (dynamic)firstNumber * secondNumber;
        }

        /// <summary>
        /// Divides the first number to second number (first / second)
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public T Divide(T firstNumber, T secondNumber)
        {
            if ((dynamic)secondNumber == 0)
            {
                throw new DivideByZeroException("The second parameter of the method cannot be zero.");
            }

            return (dynamic)firstNumber / secondNumber;
        }
    }
}
