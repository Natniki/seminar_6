/*Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GetNumber(string description)
{
    int number;
    Console.Write($"{description}=> ");
    while(true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
        {
            return number;
        }
        Console.WriteLine($"This number {temp} is not correct. Try again: ");
    }
}

int[] CreaArrey(int length)
{
    int[]myArrey = new int [length];
    for(int i = 0; i<myArrey.Length; i++)
    {
        myArrey[i] = GetNumber($"input {i+1} number: ");
    }

    return myArrey;
}


int CountNeg(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<0)
        {
        count +=1;
        }
       }
   return count;
}

int length = GetNumber("input numbers: ");
int[] myArrey = CreaArrey(length);
Console.WriteLine(string.Join(", ",myArrey));
int res = CountNeg(myArrey);
Console.WriteLine($"kolichestvo negativnyh elementov: -> +({res})");




