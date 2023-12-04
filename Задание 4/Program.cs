int[,] Array(int a, int b){
    Random num = new Random();
    int[,] matrix = new int[a,b];
    for(int i = 0; i < matrix.GetLength(0); i++){         // Генерация  таблицы
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = num.Next(1, 100);
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
void NewArray(int[,] matrix){
    int x = 0; int y = 0; int min = matrix[x,y]; 
    for(int i = 0; i < matrix.GetLength(0); i++){         
        for(int j = 0; j < matrix.GetLength(1); j++){
            if(matrix[i,j] < min){
                min = matrix[i,j];                                     // Программа работает, только если минимальные числа не повторяются) Не додумал этот момент
                x = i;
                y = j;
            }
        }
    }
    for(int i = 0; i < matrix.GetLength(0); i++){         
        for(int j = 0; j < matrix.GetLength(1); j++){
            if(i == x || j == y){
                if(y == matrix.GetLength(1) - 1 && j == matrix.GetLength(1) - 1){
                    Console.WriteLine();
                }
                continue;
            }
            if(j == matrix.GetLength(1) - 1){
            Console.WriteLine($"{matrix[i,j]}");
           }
           else{
            Console.Write($"{matrix[i,j]} ");
           }                                                           // Вывод нового массива
        }
    } 
   
}
int[,] matrix = Array(4,4);
PrintArray(matrix);
NewArray(matrix);