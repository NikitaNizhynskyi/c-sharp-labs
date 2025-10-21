using System.Security.Cryptography.X509Certificates;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        public List<Doctor> Doctors;
        public List<Patient> Patients;
        public List<HospitalRoom> Rooms;
        public List<MedicalRecord> Records;

        public Hospital()
        {
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Rooms = new List<HospitalRoom>();
            Records = new List<MedicalRecord>();
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Лікар {doctor.Name} ({doctor.Specialization}) доданий до системи");
        }
        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"Пацієнт {patient.Name}, {patient.Age} років, зареєстрований");
        }
        public void CreateRoom(HospitalRoom room)
        {
            Rooms.Add(room);
            Console.WriteLine($"Палата №{room.RoomNumber} створена (місткість: {room.Capacity})");
        }
        public void AddMedicalRecord(MedicalRecord record)
        {
            Records.Add(record);
            Console.WriteLine($"Медичний запис створено: {record.Patient.Name} -> {record.Doctor.Name}");
        }
        public void HospitalizePatient(int patientId, int roomNumber)
        {
            Patient patient = null;
            HospitalRoom room = null;

            foreach (Patient p in Patients)
            {
                if (p.Id == patientId)
                {
                    patient = p;
                    break;
                }
            }
            if (patient == null)
            {
                Console.WriteLine($"Пацієнт з ID {patientId} не знайдений!");
                return;
            }

            foreach (HospitalRoom r in Rooms)
            {
                if (r.RoomNumber == roomNumber)
                {
                    room = r;
                    break;
                }
            }
            if (room == null)
            {
                Console.WriteLine($"Палата №{roomNumber} не знайдена!");
                return;
            }

            room.AddPatient(patient);
        }

        public List<MedicalRecord> GetPatientHistory(int patientId)
        {
            List<MedicalRecord> history = new List<MedicalRecord>();

            foreach(MedicalRecord mr in Records)
            {
                if(mr.Patient.Id == patientId)
                {
                    history.Add(mr);
                }
            }

            return history;
        }

        public string GetStatistics()
        {
            int totalPatientsInRooms = 0;

            foreach(HospitalRoom r in Rooms)
            {
                totalPatientsInRooms += r.Patients.Count;
            }
            
            string stats = "=== СТАТИСТИКА ЛІКАРНІ ===\n" +
                $"Кількість лікарів: {Doctors.Count}\n" +
                $"Кількість зареєстрованих пацієнтів: {Patients.Count}\n" +
                $"Кількість палат: {Rooms.Count}\n" +
                $"Кількість пацієнтів у палатах: {totalPatientsInRooms}\n" +
                $"Кількість медичних записів: {Records.Count}";

            return stats;
        }
    }
}
