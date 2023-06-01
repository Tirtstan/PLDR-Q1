using System;

public class Question1
{
    private static string[] studentNamesPreset = new string[10]
    {
        "Joe",
        "Mpho",
        "Kyle",
        "Susan",
        "Thando",
        "Refilwe",
        "John",
        "Katlego",
        "Joyce",
        "Sisanda"
    };
    private static int[] studentMarksPreset = new int[10]
    {
        68,
        56,
        43,
        49,
        76,
        80,
        50,
        75,
        63,
        44
    };

    private static string[] studentNames = new string[10];
    private static int[] studentMarks = new int[10];

    private static void Main()
    {
        Console.Write("Use preset marks (y/n)?: ");
        char symbol = char.Parse(Console.ReadLine());
        if (char.ToLower(symbol) == 'y')
        {
            studentNames = studentNamesPreset;
            studentMarks = studentMarksPreset;
        }
        else
        {
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.Write($"Please enter student {i + 1}'s name: ");
                studentNames[i] = Console.ReadLine();

                do
                {
                    Console.Write($"Please enter student {i + 1}'s mark: ");
                    studentMarks[i] = int.Parse(Console.ReadLine());
                } while (studentMarks[i] < 0 || studentMarks[i] > 100);
            }
        }

        Console.WriteLine("CLASS REPORT\n");
        Console.WriteLine("NAME\tMARK ACHIEVED\tCATEGORY");
        for (int i = 0; i < studentNames.Length; i++)
        {
            string category;
            int mark = studentMarks[i];
            if (mark >= 75)
                category = "Distinction";
            else if (mark < 50)
                category = "Fail";
            else
                category = "Pass";

            Console.WriteLine($"{studentNames[i]}\t{studentMarks[i]}\t\t{category}");
        }

        int total = 0;
        for (int i = 0; i < studentMarks.Length; i++)
        {
            total += studentMarks[i];
        }

        float average = total / (float)studentMarks.Length;
        Console.WriteLine($"\nAVERAGE CLASS MARK:\t{average:0.#}%");

        int highMark = studentMarks[0];
        string highStudent = studentNames[0];
        for (int i = 0; i < studentMarks.Length; i++)
        {
            if (studentMarks[i] >= highMark)
            {
                highMark = studentMarks[i];
                highStudent = studentNames[i];
            }
        }
        High(highStudent);

        int lowMark = studentMarks[0];
        string lowStudent = studentNames[0];
        for (int i = 0; i < studentMarks.Length; i++)
        {
            if (studentMarks[i] <= lowMark)
            {
                lowMark = studentMarks[i];
                lowStudent = studentNames[i];
            }
        }
        Low(lowStudent);

        Console.ReadKey();
    }

    private static void High(string student)
    {
        Console.WriteLine($"HIGHEST MARK:\t{student}");
    }

    private static void Low(string student)
    {
        Console.WriteLine($"LOWEST MARK:\t{student}");
    }
}
