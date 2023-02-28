
string[] FiltrToThreeSign(string[] arrayStart,string[] arrayFinish){
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if (arrayStart[i].Length<=3)
        {
            arrayFinish[count] = arrayStart[i];
            count++;
        }
    }
    return arrayFinish;
}
void PrintArray(string[] arrayFinish){
    for (int i = 0; i < arrayFinish.Length; i++)
    {
        Console.Write($"{arrayFinish[i]} ");
    }
}
string[] arrayStart = new string [] {"124","1111","1"};
string[] arrayFinish = new string [arrayStart.Length];
string[] result = FiltrToThreeSign(arrayStart,arrayFinish);
Console.Write($"Дан массив: ");
PrintArray(arrayStart);
Console.WriteLine();
Console.Write($"массив, где элемент меньше либо равно трем: ");
PrintArray(result);