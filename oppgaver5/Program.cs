// напигите программу которая принимает на вход трехзначное целое число и выходе
// показывает сумму первой и последней цифры этого числа
// 456 => 10

Console.WriteLine("Write number N");

int N = Convert.ToInt32(Console.ReadLine());

if (N >= 100 && N <= 999)
{

int A = N / 100;
int B = N % 10;
int result = A + B;

Console.Write(result);
}
else {
    Console.WriteLine("the number is not 3-digit");
}

// && - и
// || - или
