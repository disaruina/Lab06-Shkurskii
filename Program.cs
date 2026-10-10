// for (int i = 10; i > 0; i--){
//     Console.WriteLine(i);
// }
// for (int i = 2; i <= 50; i+=2){
//      Console.WriteLine(i);
// }
// int sum3 = 0;
// int col7 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum3 += i;
//     }
//     if (i % 7 == 0)
//     {
//         col7 += 1;
//     }
// }
// Console.WriteLine($"Сумма кратных 3: {sum3}, Количество кратных 7: {col7}");
// int otr = 0;
// int pol = 0;
// Console.Write("пишите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 

// while (number != 0) 
// {
//     if (number < 0)
//     {
//         otr += 1;
//     }
//     else if (number > 0)
//     {
//         pol += 1;
//     }
//     Console.Write("пишите число: ");
//     number = Convert.ToInt32(Console.ReadLine()); 
// }
// Console.WriteLine($"пол чисел: {pol}");
// Console.WriteLine($"отриц числе: {otr}");
// int col = 0;
// string password;
// while (col < 3)
// {
//     Console.Write("введите пароль: ");
//     password = Console.ReadLine();
//     if (password != "qwerty")
//     {
//         col++;
//         Console.WriteLine($"не тот пароль осталось попыток: {3-col}");
//     }
//     else
//     {
//         Console.WriteLine("пароль верный");
//         break;
//     }
// }
// if (col == 3)
// {
//     Console.WriteLine("попытки закончились");
// }
// int c = 0;
// Console.Write("введите число: ");
// c = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i < 11; i++){
//     Console.Write($"\n{c} x {i} = {c*i}");
// }
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue; 
//     }
//     if (i % 10 == 0 | i > 20)
//     {
//         break; 
//     }
//     Console.WriteLine(i);
// }
int c = 0;
int secr = 42;
int pop = 5;
while(pop != 0){
    Console.Write("введите число: ");
    c = Convert.ToInt32(Console.ReadLine());
    if (c != secr && c < secr){
        
    }
}
