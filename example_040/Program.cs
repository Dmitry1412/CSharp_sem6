/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
*/

System.Console.WriteLine(IsTriangle(1, 1, 9));

bool IsTriangle(int stA, int stB, int stC)
{
    return (((stA + stB) > stC) && ((stB + stC) > stA) && ((stA + stC) > stB));
}

/*
Решение через лямбда-выражение

var istriangle = (int stA, int stB, int stC) =>
    (((stA + stB) > stC) && ((stB + stC) > stA) && ((stA + stC) > stB));
System.Console.WriteLine(istriangle(6, 5, 9));
*/


/*
/// Работа с классом List - Дополнительная информация

var persons = new List<Person> {
    new Person {
        Id = 1, 
        Name = "Dima"
    }, 
    new Person {
        Id = 2, 
        Name = "Misha"
    },
};
persons.Add(new Person {
        Id = 3, 
        Name = "Vasya"
    });
System.Console.WriteLine(persons.Where(p => p.Id == 3).FirstOrDefault()?.Name); // p => p.Id дямбда-выражение (делегат)
System.Console.WriteLine(persons[1].Name);
public class Person
{
    public int Id {get; set;}
    public string Name {get; set;}
}
*/


/// https://www.youtube.com/watch?v=rPp46idEvnM&t=1s
/// Хеш-таблица — Самая Популярная Структура Данных
/// полезное видео



























