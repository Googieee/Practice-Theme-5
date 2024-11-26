string str1 = "Доброе утро";
string str2 = "Добрый день";
string str3 = "Добрый вечер";

// Использование оператора ==
Console.WriteLine("Сравнение с помощью ==:");
Console.WriteLine(str1 == str2); // false
Console.WriteLine(str1 == str3); // true

// Использование оператора !=
Console.WriteLine("\nСравнение с помощью !=:");
Console.WriteLine(str1 != str2); // true

// Метод Equals
Console.WriteLine("\nСравнение с помощью метода Equals:");
Console.WriteLine(str1.Equals(str2)); // false
Console.WriteLine(str1.Equals(str3)); // true

// Метод Compare
Console.WriteLine("\nСравнение с помощью метода Compare:");
int result = String.Compare(str1, str3);
Console.WriteLine(result < 0 ? "str1 меньше str3" : "str1 больше или равен str3"); // -1

// Метод CompareOrdinal
Console.WriteLine("\nСравнение с помощью метода CompareOrdinal:");
result = String.CompareOrdinal(str1, str3);
Console.WriteLine(result < 0 ? "str1 меньше str3" : "str1 больше или равен str3"); // -1

// Метод IndexOf
Console.WriteLine("\nПоиск подстроки с помощью IndexOf:");
int index = str1.IndexOf("Утро");
Console.WriteLine(index != -1 ? $"Подстрока 'Утро' найдена в позиции: {index}" : "Подстрока не найдена"); // 6

// Метод Contains
Console.WriteLine("\nПроверка наличия подстроки с помощью Contains:");
Console.WriteLine(str1.Contains("Добрый") ? "'Добрый' содержится в строке" : "'Добрый' не содержится в строке"); // true
Console.WriteLine(str1.Contains("день") ? "'день' содержится в строке" : "'день' не содержится в строке"); // false
