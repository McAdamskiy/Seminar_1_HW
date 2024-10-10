using System;

    

public class Answer{
    static void CheckDivisibility(int firstNumber, int secondNumber)
    {
        if (firstNumber % secondNumber == 0)
        {
            Console.WriteLine("Divisibly");
        }
        else{
            Console.WriteLine("No divisibly");
        }
    }
    static public void Main(){
        Console.WriteLine("firstNumber: ");
        int f = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("To 0 not divise");
        Console.WriteLine("secondNumber: ");
        int s = Convert.ToInt32(Console.ReadLine());

        CheckDivisibility(f, s);
    }
}




