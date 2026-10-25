namespace Session09Assignment;

// Q1
public class Patient(int Id, string FullName, string PhoneNumber, string MedicalHistory)
{
    public int Id { get; } = Id;
    public string FullName { get; } = FullName;
    public string PhoneNumber { get; } = PhoneNumber;
    public string MedicalHistory { get; } = MedicalHistory;

    public override string ToString() =>
        $"Id: {this.Id} :: FullName: {this.FullName} :: PhoneNumber: {this.PhoneNumber} :: MedicalHistory: {this.MedicalHistory}";
}

// Q3
public record PatientDto(int Id, string FullName, string PhoneNumber);

// ---------------- Q4: Mapper ----------------
public static class PatientMapper
{
    public static PatientDto MapFromModelToDto(Patient patient) =>
        new PatientDto(patient.Id, patient.FullName, patient.PhoneNumber);
}
