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
int[,] NewArray(int[,] matrix){
    int[,] newmatrix = matrix;
    int i = 0; int x = matrix.GetLength(0) - 1; int temp;         // Замена строк
    for(int j = 0; j < matrix.GetLength(1); j++){
        temp = matrix[i,j];
        matrix[i,j] = matrix[x,j];
        matrix[x,j] = temp;
    }
    return newmatrix;
}
int[,] matrix = Array(5,5);
PrintArray(matrix);
int[,] newmatrix = NewArray(matrix);
PrintArray(newmatrix);
