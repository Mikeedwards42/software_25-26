// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
string name;
string name2;
string subject;
string phase;
string comp;
Console.WriteLine("what is your name");
name2=Console.ReadLine();
Console.WriteLine("who are you sending this letter too");
name= Console.ReadLine();
Console.WriteLine("subject of the letter");
subject=Console.ReadLine();
Console.WriteLine("what is the project or task of the letter");
phase=Console.ReadLine();
Console.WriteLine("when will you be comepleted with the project ");
comp=Console.ReadLine();
Console.WriteLine("generating letter...........");
Console.WriteLine();DateTime.Now.ToShortDateString();
Console.WriteLine($"to: {name2}");
Console.WriteLine($"Dear {name2}");
Console.WriteLine($"subject:{subject}");
Console.WriteLine($"I am writing to you today regarding the {phase}{subject} that we discussed");
Console.WriteLine("I wanted to provide a quick update on its progress.");
Console.WriteLine($"We anticipate completing the initial phase by{comp}");
Console.WriteLine("Please let me know if you have any questions or require further information.");
Console.WriteLine("sincerly");
Console.WriteLine(name);


