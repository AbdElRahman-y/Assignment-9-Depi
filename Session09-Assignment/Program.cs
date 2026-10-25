namespace Session09Assignment;

internal class Program
{
    static void Main(string[] args)
    {
        // ================= Part 1 =================
        Console.WriteLine("---- Q2: class Patient ----");
        Patient patient01 = new Patient(1, "Ali Hassan", "01011112222", "Diabetes");
        Patient patient02 = new Patient(1, "Ali Hassan", "01011112222", "Diabetes");

        Console.WriteLine(patient01.GetHashCode());
        Console.WriteLine(patient02.GetHashCode());

        Console.WriteLine(patient01.Equals(patient02));

        patient01 = patient02;
        Console.WriteLine(patient01.Equals(patient02));

        Console.WriteLine("---- Q3: record PatientDto ----");
        PatientDto dto01 = new PatientDto(1, "Ali Hassan", "01011112222");
        PatientDto dto02 = new PatientDto(1, "Ali Hassan", "01011112222");

        Console.WriteLine(dto01.GetHashCode() == dto02.GetHashCode());   // true
        Console.WriteLine(dto01.Equals(dto02));                          // true
        Console.WriteLine(dto01);                                        // PatientDto { Id = 1, FullName = ..., PhoneNumber = ... }

        Console.WriteLine("---- Q4: Mapper ----");
        PatientDto mapped = PatientMapper.MapFromModelToDto(patient01);
        Console.WriteLine(mapped);

        // ================= Part 2 =================
        Console.WriteLine("---- Q6: Singleton ----");
        Console.WriteLine(AppLogger.GetLogger().GetHashCode());
        Console.WriteLine(AppLogger.GetLogger().GetHashCode());
        Console.WriteLine(AppLogger.GetLogger().GetHashCode());
        Console.WriteLine(AppLogger.GetLogger().GetHashCode());

        // ================= Part 3 =================
        Console.WriteLine("---- Q7: var & dynamic ----");
        Patient p1 = new(2, "Sara Omar", "01099998888", "None");    // target-typed new
        var p2 = new Patient(3, "Omar Khaled", "01055556666", "Asthma");
        dynamic p3 = p1;
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);

        // ================= Part 4 =================
        Console.WriteLine("---- Q8: Anonymous Types ----");
        var doctor01 = new { Name = "Sara", Specialty = "Cardiology", ExperienceYears = 8, Salary = 25_000 };
        var doctor02 = new { Name = "Sara", Specialty = "Cardiology", ExperienceYears = 8, Salary = 25_000 };

        Console.WriteLine(doctor01.Name);
        Console.WriteLine(doctor01.Specialty);
        Console.WriteLine(doctor01.GetHashCode());
        Console.WriteLine(doctor02.GetHashCode());
        Console.WriteLine(doctor01.GetType());
        Console.WriteLine(doctor01.Equals(doctor02));
        Console.WriteLine(doctor01.ToString());

        // ================= Part 5 =================
        Console.WriteLine("---- Q10: Extension Methods ----");
        Console.WriteLine("Stethoscope".IsShorterThan(5));   // false
        Console.WriteLine("Ab".Repeat(4));                   // AbAbAbAb
    }
}
