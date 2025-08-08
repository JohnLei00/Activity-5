internal class Program
{
    private static void Main(string[] args)
    {
        List<int> grades = new List<int>();
        Console.WriteLine("Enter 7 student grades (0-100):");

        // Input grades
        for (int i = 0; i < 7; i++)
        {
            int grade;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                {
                    grades.Add(grade);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid grade. Enter a number between 0 and 100.");
                }
            }
        }

        // Classify grades using switch-case
        int aCount = 0, bCount = 0, cCount = 0, dCount = 0, fCount = 0;

        foreach (var grade in grades)
        {
            switch (grade)
            {
                case >= 90: aCount++; break;
                case >= 80: bCount++; break;
                case >= 70: cCount++; break;
                case >= 60: dCount++; break;
                default: fCount++; break;
            }
        }

        Console.WriteLine($"A: {aCount}, B: {bCount}, C: {cCount}, D: {dCount}, F: {fCount}");
    }
}