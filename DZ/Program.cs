
        
  

using System;

 class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
      int  firstNumber=Convert.ToInt32 (Console.ReadLine());
      int  secondNumber=Convert.ToInt32 (Console.ReadLine());
      
      if (firstNumber<secondNumber)
      {
   
  Console.WriteLine($"Первое число`{firstNumber}` меньше чем второе число`{secondNumber}`");
       }
      else if (firstNumber==secondNumber)
      {
  Console.WriteLine ($"Первое число`{firstNumber}`больше чем второе число`{secondNumber}`");
      }
        
        
        
  // Не удаляйте и не меняйте метод Main! 
    static  void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

     
        CompareNumbers(firstNumber, secondNumber); 
    
    }

    } }  