int[,] Array(int a, int b){
    Random rnd = new Random();
    int[,] matrix = new int[a,b];
    for(int i = 0; i < matrix.GetLength(0); i++){         // Генерация  таблицы
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
void minSum(int[,] matrix){
    int sum = 0; int min = 0; int a = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            sum += matrix[i, j];
        }
        if (sum < min || i == 0){
            min = sum;
            a = i;                                          // Нахождение индекса строки с наименьшей суммой
        }
        sum = 0;
    }
    Console.WriteLine($"Индекс строки c наименьшей суммой: {a}");
    Console.Write($"Сумма: {min}");
}
int[,] matrix = Array(5, 5);
PrintArray(matrix);
minSum(matrix);