// See https://aka.ms/new-console-template for more information

using System;

namespace CalculatorExample
{
    class CalculateProcess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("간단한 사칙연산 계산기입니다");
            Console.Write("첫 번째 값을 입력해 주세요: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("사칙연산을 선택해 주세요 (+, -, *, /): ");
            char calculate = Convert.ToChar(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력해 주세요: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            
            switch (calculate)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("0으로 나눌 수 없습니다");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("현재 사칙연산만 지원합니다");
                    return;
            }

            Console.WriteLine($"{num1} {calculate} {num2} 의 계산 결과는 {result} 입니다");
        }
    }
}
