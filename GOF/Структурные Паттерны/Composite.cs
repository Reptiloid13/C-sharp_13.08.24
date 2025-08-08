using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Структурные_Паттерны;

/// <summary>
///  Composite - это структурный паттерн проектирования, который позволяет объединять объекты в древовидные структуры, представляя как простые, так и составные объекты единым образом
///  
/// Основные компоненты паттерна
/// Component — базовый интерфейс или абстрактный класс
/// Leaf — конечный элемент (листовой узел)
/// Composite — составной элемент (контейнер)
/// 
/// Когда использовать? 
/// 1. Тогда, когда объекты должны быть реализованы в виде иерархической древовидной структуры.
/// 2. Когда клиентский код должен одинаково управлять как целыми объектами, так и их составными частями, то есть и целый объект, и его структурные части должны реализовывать один и тот же интерфейс. 
/// </summary>
public class Composite
{
    public static void CompositeInstance()
    {
        // Создание корневой папки
        Component rootFolder = new Folder("Root");
        // Создание файла - компонента низшего уровня
        Component myFile = new File("MyFile.txt");
        // Создание папки с документами
        Folder documentsFolder = new Folder("MyDocuments");
        // Добавляем файл в корневую папки
        rootFolder.Add(myFile);
        // Добавляем подпапку для документов в корневую папку
        rootFolder.Add(documentsFolder);
        //показываем контент корневой папки
        rootFolder.Display();
    }
}
abstract class Component
{
    public readonly string Name;

    protected Component(string name)
    {
        this.Name = name;
    }
    #region Методы для добавления / удаления подкомпонентов
    public abstract void Display();
    public abstract void Add(Component c);
    public abstract void Remove(Component c);

    #endregion
}
//Теперь реализуем модель файла — наименьшей единицы нашей древовидной структуры. У файла нет подкомпонентов, поэтому методы Add() и Remove() тут реализованы не будут.
class File : Component
{
    // Представляет компонент самого низкого уровня
    /// Который не может содержать подкомпонентов
    public File(string name) : base(name) { }
    public override void Display()
    {
        Console.WriteLine(Name);
    }
    // Метод для добавления подкомпонентов не поддерживается
    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }
    // Метод для удаления подкомпонентов не поддерживается
    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }
}
//Представляет папку - компонент, который может содержать другие компоненты
/// Здесь реализован механизм для добавления / удаления новых компонентов
class Folder : Component
{
    List<Component> subFolders = new List<Component>();
    public Folder(string name) : base(name) { }

    public override void Add(Component component)
    {
        subFolders.Add(component);
        Console.WriteLine($"В {this.Name} добавлено: {component.Name}");
    }
    // Метод для удаления 
    public override void Remove(Component component)
    {
        subFolders.Remove(component);
        Console.WriteLine($"Из {this.Name} удалено: {component.Name} ");
    }

    // Метод для отображения нижестоящих компонентов
    public override void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"{Name} содержит:");
        foreach (Component component in subFolders)
            component.Display();
    }

}
