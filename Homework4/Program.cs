// Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Усложнил задачу и сделал так чтобы можно было принять любой массив четный и нечетный до 3 знаков в числе (потом некрасиво выводит) =)

int N = Convert.ToInt32(Console.ReadLine()); // ввод размера квадратного массива
string[,] matrix = new string[N, N]; // Создаю массив в формате строки для красивого вывода на консоль.
int counter = 1; // первое число с которого начнется счет цифр в массиве. 
int length = matrix.GetLength(0); // инициализировал переменную с длиной массива
int x = -1; // инициализировал переменные x и y для управления проходом по спирали 
//-1 чтобы в конце не сбилось направление спирали, выяснил научно тыкальным путем. =) С нулем вылетаю за границы массива.
int y = 0;
for (int j = 0; j < matrix.GetLength(0) / 2; j++) // первый for делает круг и повторяет итерацию до конца массива
{
   // каждый круг массива значения длины уменьшаю таким образом, чтобы не попасть на уже записанные столбцы и строки...  
    for (int i = 0; i < length; i++) // прохожу массив вправо.  
    {
        x++; // проходим по всем элементам строки
        
        if (counter < 10) // условия для вывода "красивого" массива, повторяются в последующих for.
        {
            matrix[y, x] = "00" + Convert.ToString(counter); // записываю число в массив, повторяются в последующих for.

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter); // записываю число в массив, повторяются в последующих for.
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter); // записываю число в массив, повторяются в последующих for.
        }
        counter++; // Следующее число по порядку, повторяются в последующих for.
        
    }
    length--; // уменьшаю длину прохода чтобы записать значения вниз по колонке

    for (int i = 0; i < length; i++) // прохожу массив вниз. 
    {
        y++; // Прохожу по всем не записанным элементам столбца 
        
        if (counter < 10)
        {
            matrix[y, x] = "00" + Convert.ToString(counter);

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter);
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter);
        }    
        counter++;
    }

    for (int i = 0; i < length; i++) // прохожу массив влево. 
    {
        x--; // Прохожу по всем не записанным элементам строки 
       
        if (counter < 10)
        {
            matrix[y, x] = "00" + Convert.ToString(counter);

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter);
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter);
        }
        counter++;                        
    }
    length--;
    for (int i = 0; i < length; i++) // прохожу массив вверх.
    {
        y--; // Прохожу по всем не записанным элементам столбца 
        
        if (counter < 10) 
        {
            matrix[y, x] = "00" + Convert.ToString(counter);

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter);
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter);
        }
        counter++;                        
    }
}

if (matrix.GetLength(0) % 2 == 1) // ставлю последнюю цифру в том случае, если массив оказался не четным (а то получился бы в центре массива 0)
{
    if (counter < 10)
    {

        matrix[matrix.GetLength(1) / 2, matrix.GetLength(0) / 2] = "00" + Convert.ToString(counter);

    }
    else if (counter < 100)
    {
        matrix[matrix.GetLength(1) / 2, matrix.GetLength(0) / 2] = "0" + Convert.ToString(counter);
    }
    else
    {
        matrix[matrix.GetLength(1) / 2, matrix.GetLength(0) / 2] = Convert.ToString(counter);

    }
}


for (int i = 0; i < matrix.GetLength(0); i++) // Вывожу на консоль
{
    for (int j = 0; j < matrix.GetLength(0); j++)
        Console.Write($"{matrix[i, j]}  ");
    Console.WriteLine();
}