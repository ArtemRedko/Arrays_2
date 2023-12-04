using System.IO.Compression;

int[,] Array(int a, int b){
    Random rnd = new Random();
    int[,] matrix = new int[a,b];
    for(int i = 0; i < matrix.GetLength(0); i++){         //Генерация таблицы
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix){
   for(int i = 0; i < matrix.GetLength(0); i++){         // Вывод  таблицы
        for(int j = 0; j < matrix.GetLength(1); j++){
           if(j == matrix.GetLength(1) - 1 ){
            Console.WriteLine($"{matrix[i,j]}");
           }
           else{
            Console.Write($"{matrix[i,j]} ");
           }
       }
    }
    Console.WriteLine();
}     
void Element(int[,] matrix){
    Console.WriteLine("Введите индекс строки: ");
    int i = Convert.ToInt32(Console.ReadLine());                     //Вывод элемента массива
    Console.WriteLine("Введите индекс столбца: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if(i >= matrix.GetLength(0) || j >= matrix.GetLength(1)){
        Console.Write("Такого элемента нет!");
    }
    else{
        Console.Write($"Число: {matrix[i,j]}");
    }
}
int[,] matrix = Array(5,5);
PrintArray(matrix);
Element(matrix);