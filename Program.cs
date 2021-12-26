// Задача : Написать программу, которая из имеющихся целых чисел
// формирует массив из чисел, больших 8.
// Первоначальный массив может быть с клавиатуры,
// либо сгенерировать случайным образом. Рекомендуется
// не пользоваться коллекциями, лучше обойтись исключительно массивами.
//
Console.WriteLine("Введите число");
Console.WriteLine("Для завершения введите END");
int[] array = new int[30];
string? input ="";
int i = 0;
do
{
    input = Console.ReadLine()!;
    if(input.ToLower() != "end")
    {
        int num = Convert.ToInt32(input);
        if(num >8)
        {
            array[i] = num;
            i++;
        }
    }
    
}while(input.ToLower() != "end");