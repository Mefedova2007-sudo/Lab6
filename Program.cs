//int x = 5;
//int y = x / 0;
//Console.WriteLine($"Результат: {y}");
//Console.WriteLine("Конец программы");
//try
//{
// int x = 5;
//}
//catch
//{
// Console.WriteLine("Возникло исключение!");
//}
//finally
//{
// Console.WriteLine("Блок finally");
//}
//Console.WriteLine("Конец программы");
//try
//{
// int x = Convert.ToInt32(Console.ReadLine());
// int y = x / 0;
// Console.WriteLine($"Результат: {y}");
//}
//catch (DivideByZeroException ex)
//{
//   Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch(FormatException ex)
//{
// Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch(Exception ex)
//{
// Console.WriteLine($"Произошла ошибка: {ex.Message}");
//}
//Console.WriteLine("Конец программы");
//Console.Write("Введите первое число:");
//double number1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите второе число:");
//double number2 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите операцию (+, -, *, /):");
//string? op = Console.ReadLine();
//double result = 0;
//if (op == "+") result = number1 + number2;
//else if (op == "+") result = number1 - number2;
//else if (op == "+") result = number1 * number2;
//else if (op == "+") result = number1 / number2;
//else Console.WriteLine("неизвестная операция!");
//switch (op)
//{
//    case "+": result = number1 + number2; break;
//    case "-": result = number1 - number2; break;
//    case "*": result = number1 * number2; break;
//    case "/": result = number1 / number2; break;
//    default: Console.WriteLine("неизвестная операция!"); return;
//}
//try
//{
//    switch (op)
//    {
//        case "+": result = number1 + number2; break;
//        case "-": result = number1 - number2; break;
//        case "*": result = number1 * number2; break;
//        case "/":
//            if (number2 == 0)
//                throw new DivideByZeroException("нельзя делить на ноль!"); return;
//            result = number1 / number2; break;
//        default: Console.WriteLine("неизвестная операция!"); return;
//    }
//}
//catch (FormatException)
//{
//    Console.WriteLine("ошибка ввода!введите корректные числа");
//}catch (DivideByZeroException ex){
//    Console.WriteLine($"ошибка:{ex.Message}");
//}catch (Exception ex){
//    Console.WriteLine($"произошла ошибка:{ex.Message}");
//}finally { 
//    Console.WriteLine("работа калькулятора завершена"); 
//}
//while  (true)
//{

//}
//int number = 12;
//Console.WriteLine(number.ToString());
//bool boolean = true;
//Console.WriteLine(boolean.ToString());
//DateTime now=DateTime.Now;
//Console.WriteLine(now.ToString());
//object me = new();
//Console.WriteLine(me.ToString());

//int age = int.Parse("27");
//DateTime birthday = DateTime.Parse("4 Jule 1980");
//Console.WriteLine("I was born{age} years ago");
//Console.WriteLine($"My birthday is {birthday}");
//Console.WriteLine($"My birthday is {birthday:D}");
//int count = int.Parse("abc");
