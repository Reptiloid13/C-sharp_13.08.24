using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Структурные_Паттерны;

public class FacadeRealInstance
{
}
/// <summary>
///    /// Фасад, скрывающий механизм работы IDE с компонентами,
/// Использующимися при разработке
/// </summary>
class IdeFacade
{
    readonly Editor _editor;
    readonly Compiller _compiler;
    readonly Runtime _runtime;
    public IdeFacade(Editor editor, Compiller compiller, Runtime runtime)
    {
        _editor = editor;
        _compiler = compiller;
        _runtime = runtime;
    }
    public void Start(string sourceCode)
    {
        // Пишет в текстовый файл
        _editor.Write(sourceCode);
        // Сохраняет текстовый файл
        _editor.Save();
        // Вызывает компилятор
        _compiler.Compile();
        // Запускает выполнение скомпилированного приложения в среде CLR
        _runtime.Execute();
    }
    // в конце IDE может остановить выполнение, вызвав команду в среде выполнения
    public void Stop()
    {
        _runtime.Finish();
    }
}
/// <summary>
/// Класс для работы с текстовым редактором
/// </summary>
class Editor
{
    // Функция написания кода
    public void Write(string sourceCode)
    {
        Console.WriteLine($"Пишем код:  {sourceCode}");
    }

    public void Save()
    {
        Console.WriteLine("Сохраняем код");
    }
}
class Compiller
{
    public void Compile()
    {
        Console.WriteLine("Компиляция приложения");
    }
}
class Runtime
{
    public void Execute()
    {
        Console.WriteLine("Выполнение приложения");
    }
    public void Finish()
    {
        Console.WriteLine("Завершение работы приложения");
    }
}