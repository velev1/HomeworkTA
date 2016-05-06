//Write a program that creates an array containing all letters from the alphabet(A-Z).
//Read a word from the console and print the index of each of its letters in the array.

// a	b	c	d	e	f	g	h	i	j	k	l	m	n	o	p	q	r	s	t	u	v	w	x	y	z


using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] charArray =
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            // 0    1     2   3    4    5    6    7    8    9    10   11   12   13   14   15   16   17   18    19  20   21   22   23   24    25
        string input = Console.ReadLine();
        //input.ToLower();

        for (int i = 0; i < input.Length; i++)
        {
            string letterCheck = input.Substring(i, 1);
               
            for (int j = 0; j < charArray.Length; j++)
            {
                if (letterCheck == charArray[j].ToString())
                {
                    Console.WriteLine(j);
                    break;
                }
            }
        }
    }
}

