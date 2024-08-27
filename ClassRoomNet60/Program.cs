// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

public class Program
{
    public static void Main(string[] args)
    {
        // Opret en instans af KlasseRum
        KlasseRum klasseRum = new KlasseRum
        {
            KlasseNavn = "3B",
            SemesterStart = new DateTime(2022, 9, 1)
        };

        // Tilføj studerende til Klasseliste
        Studerende student1 = new Studerende("Thomas", 3, 15);
        Studerende student2 = new Studerende("Søren", 8, 28);
        Studerende student3 = new Studerende("Christian", 9, 17);

        klasseRum.Klasseliste.Add(student1);
        klasseRum.Klasseliste.Add(student2);
        klasseRum.Klasseliste.Add(student3);

        // Udskriv for at verificere dataene og årstiderne
        Console.WriteLine($"Klasse: {klasseRum.KlasseNavn}");
        Console.WriteLine($"Semester Start: {klasseRum.SemesterStart.ToShortDateString()}");
        Console.WriteLine("Studerende:");
        foreach (var student in klasseRum.Klasseliste)
        {
            Console.WriteLine($"{student.Navn} - Født: {student.Fødselsdag}/{student.Fødselsmåned} - Årstid: {student.Årstid()}");
        }
    }
}