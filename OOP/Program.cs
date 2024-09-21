using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Drawing;

// () называется конструктором
// { Width = 20, Height = 4 } называется инициализатором
// 1) Если ты задаешь параметры через инициализатор, тогда для чего тебе конструктор ?
// 2) Методы должны начинаться с глагола. Название "Area" мало о чем говорит. Что нужно сделать с этой площадью ? Удалить ? Создать ? Посчитать ? Вывести в консоль ? Поэтому нужен глагол
// 3) Сделать еще один такой же метод, чтобы он был статическим

var square = new Rectangle() { Width = 20, Height = 4 };
Console.WriteLine(square.Area());

struct Rectangle
{
    public int Width, Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area()
    {
        return Width * Height;
    }
}