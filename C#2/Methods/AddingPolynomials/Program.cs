using System;

class AddingPolynomials
{
    static string SumOfPolinomials(string[] firstArr, string[] secondArr)
    {
        int temp = 0;
        
        for (int i = 0; i < firstArr.Length; i++)
        {
            temp = Convert.ToInt32(firstArr[i]) + Convert.ToInt32(secondArr[i]);
            firstArr[i] = temp.ToString();
        }
        string result = string.Join(" ", firstArr);
        return result; 
    }


    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] firstArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondtArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string result = SumOfPolinomials(firstArr, secondtArr);
        Console.WriteLine(result);
    }
}

