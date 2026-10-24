// int dayNumber = 5; 
// switch (dayNumber)
// {
//     case 5 or 6 or 7:
//         Console.WriteLine("Выходной");
//         break;
//     default:
//         Console.WriteLine("Будний");
//         break;
// }




// int score = 78;
// switch (score)
// {
//     case >= 0 and < 40:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     case >= 40 and < 60:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case >= 60 and < 80:
//         Console.WriteLine("Хорошо");
//         break;
//     case >= 80 and <= 100:
//         Console.WriteLine("Отлично");
//         break;
//     default:
//         Console.WriteLine("Некорректный балл");
//         break;
// }









// using System.Security.Cryptography;

// int temperature = 25;
// string result = temperature switch
// {
//     < 0 => "Мороз",
//     >= 0 and <= 14 => "Прохладно",
//     >= 15 and <= 24 => "Комфортно",
//     >= 25 and <= 34 => "Жарко",
//     >= 35 => "Очень жарко",
//     _ => "Ошибка измерения"
// };
// Console.WriteLine(result);

















// string role = "teacher";
// bool confirmed = true;
// string access = role switch
// {
//     "admin" => "Полный доступ",
//     "teacher" when confirmed => "Доступ преподавателя",
//     "teacher" => "Требуется подтверждение",
//     _ => "Ограниченный доступ"
// };
// Console.WriteLine(access);








// int month = 3;
// string season = month switch
// {
//     12 or 1 or 2 => "Зима",
//     3 or 4 or 5 => "Весна",
//     6 or 7 or 8 => "Лето",
//     9 or 10 or 11 => "Осень",
//     _ => "Неверный месяц"
// };
// Console.WriteLine(season);


// int age = 35;
// string category = age switch
// {
//     < 0 => "Ошибка",
//     >= 0 and <= 6 => "Ребёнок",
//     >= 7 and <= 17 => "Подросток",
//     >= 18 and <= 64 => "Взрослый",
//     _ => "Пенсионер"
// };
// Console.WriteLine(category);








int number = 42;
string description = number switch
{
    < 0 => "Отрицательное",
    1 or 2 or 3 => "Маленькое число",
    >= 0 and <= 9 => "Однозначное",
    >= 10 and <= 99 => "Двузначное",
    _ => "Трёхзначное или больше"
};
Console.WriteLine(description);



