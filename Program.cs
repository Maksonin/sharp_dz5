// метод для вывода запроса в консоль на ввод числа и чтение числа из консоли
int Input(string text){
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

// метод для заполнения переденного массива случайными числами (по умолчанию от -10 до 10)
void SetArray(int[] array, int min_random = -10, int max_random = 10){
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++){
        array[i] = rand.Next(min_random , max_random);
    }
}

// метод для вывода значений элементов массива в консоль
void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

void Task34(){
    // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    int size = 8;
    int[] array = new int[size];

    SetArray(array,100,999);
    PrintArray(array);

    int even_num = 0;

    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0)
            even_num++;
    }

    Console.WriteLine($"Количество четных чисел в массиве - {even_num}");
}

void Task36(){
    // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    int size = 8;
    int[] array = new int[size];

    SetArray(array,0,10);
    PrintArray(array);

    int sum = 0;

    for(int i = 1; i < array.Length ; i += 2){
        sum += array[i];
    }

    Console.WriteLine($"Сумма элементов с нечётными индексами - {sum}");
}

void Task38(){
    // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
    int size = 8;
    int[] array = new int[size];

    SetArray(array,-10,20);
    PrintArray(array);

    int min;
    int max;

    if(array[1] > array[0])
        (min,max) = (array[0],array[1]);
    else
        (min,max) = (array[1],array[0]);

    for(int i = 2; i < array.Length ; i++){
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
    }

    Console.WriteLine($"Минимальное значение в массиве - {min}");
    Console.WriteLine($"Максимальное значение в массиве - {max}");
    Console.WriteLine($"Разница между ними - {max - min}");
}

// метод для вывода меню выбора задач
void Menu() {
    Console.WriteLine("1 - Задача 34");
    Console.WriteLine("2 - Задача 36");
    Console.WriteLine("3 - Задача 38");
    switch (Input("Введите номер задачи - ")){
        case 1:
            Task34();
            break;
        case 2:
            Task36();
            break;
        case 3:
            Task38();
            break;
        default:
            Console.WriteLine("Задачи с таким номером не существует");
            break;
    }
}

Menu();
