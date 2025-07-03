using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.IO.Pipes;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Playground;

class Program
{


    public static void Main()
    {
        Quidditch quidditch = new Quidditch();
        quidditch.RedTeam.Name = "Hufflepuff";
        quidditch.BlueTeam.Name = "Ravenclaw";
        quidditch.ShowScore();
        quidditch.RedTeam.Points += 10;
        quidditch.BlueTeam.Name = "Gryffindor";
        quidditch.ShowScore();

    }


}

public class Team
{
    public string Name = "Gryffindor";
    public int Points { get; set; }


    public void PrintInfo()
    {
        Console.WriteLine($"{Name}:{Points}");
    }
}
public class Quidditch
{
    public Team RedTeam;
    public Team BlueTeam;

    public Quidditch()
    {
        RedTeam = new Team();
        BlueTeam = new Team();
    }
    public void ShowScore()
    {
        Console.WriteLine($"{RedTeam.Name}:{RedTeam.Points}");
        Console.WriteLine($"{BlueTeam.Name}:{BlueTeam.Points}");
    }
    public void RedSnitch()
    {
        RedTeam.Points += 150;
        Console.WriteLine("Red Team Won!");
    }

    public void BlueSnitch()
    {

        BlueTeam.Points += 150;
        Console.WriteLine("Blue Team Won!");
    }

}























