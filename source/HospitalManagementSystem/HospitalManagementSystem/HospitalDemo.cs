namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            // Додавання лікарів
            Console.WriteLine("\n--- ДОДАВАННЯ ЛІКАРІВ ---");

            Doctor doctor1 = new Doctor(1, "Muhammed", "Невролог");
            Doctor doctor2 = new Doctor(2, "Almaz", "Лор");
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);

            // Реєстрація пацієнтів
            Console.WriteLine("\n--- РЕЄСТРАЦІЯ ПАЦІЄНТІВ ---");

            Patient patient1 = new Patient(1, "Георгій", 24);
            Patient patient2 = new Patient(2, "Олексій", 19);
            Patient patient3 = new Patient(3, "Марія", 28);
            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);

            // Створення палат
            Console.WriteLine("\n--- СТВОРЕННЯ ПАЛАТ ---");

            hospital.CreateRoom(new HospitalRoom(101, 5));
            hospital.CreateRoom(new HospitalRoom(102, 10));

            // Госпіталізація
            Console.WriteLine("\n--- ГОСПІТАЛІЗАЦІЯ ---");

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 102);
            hospital.HospitalizePatient(3, 102);

            // Медичні записи
            hospital.AddMedicalRecord(new MedicalRecord(patient1, doctor1, new DateTime(2025, 7, 13, 15, 30, 0), "Інсульт"));
            hospital.AddMedicalRecord(new MedicalRecord(patient2, doctor2, new DateTime(2025, 7, 15, 9, 15, 45), "Отит"));
            hospital.AddMedicalRecord(new MedicalRecord(patient3, doctor2, new DateTime(2025, 7, 17, 22, 30, 15), "Запалення горла"));

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            // Статистика
            Console.WriteLine(hospital.GetStatistics());
        }

    }
}
