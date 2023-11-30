using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_10
{
    internal class Program
    {
        static void HobbyEvent(object sender, string eventDescription)
        {
            Person person = sender as Person;
            Console.WriteLine($"{person.Name} очнь сильно рада событию '{eventDescription}'");
        }

        static List<Student> ReadStudentsFromFile(string filePath)
        {
            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Student student = new Student
                    {
                        Name = parts[0],
                        Group = parts[1],
                        ParticipatedInLastThreeEvents = bool.Parse(parts[2])
                    };
                    students.Add(student);
                }
            }

            return students;
        }

        static List<Student> SelectParticipants(List<Student> students, int count)
        {
            
            List<Student> studentsCopy = new List<Student>(students);

            studentsCopy.Sort((s1, s2) => s1.ParticipatedInLastThreeEvents.CompareTo(s2.ParticipatedInLastThreeEvents));

            List<Student> participants = studentsCopy.GetRange(0, count);

            return participants;
        }

        static void WriteParticipantsToFile(List<Student> participants, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Student participant in participants)
                {
                    writer.WriteLine(participant.Name + ";" + participant.Group);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string studentsFilePath = "student.txt";
            
            string eventFilePath = "event.txt";

            List<Student> students = ReadStudentsFromFile(studentsFilePath);
            
            Console.Write("Введите количество участников мероприятия: ");
            int participantCount = int.Parse(Console.ReadLine());

            List<Student> participants = SelectParticipants(students, participantCount);

            WriteParticipantsToFile(participants, eventFilePath);

            Console.WriteLine("Участники мероприятия записаны в файл.");



            Console.WriteLine("Задание 2");
            Console.WriteLine("Программа выводит реакцию людей на произошедшее из списка событие");
            Person person1 = new Person { Name = "Саня", Hobby = "Встреча с Никитой Соколовым" };
            Person person2 = new Person { Name = "Лиза", Hobby = "Концерт Лепса" };
            Person person3 = new Person { Name = "Динара", Hobby = "Просмотр Гарри Поттера зимой" };

            person1.HobbyEvent += HobbyEvent;
            person2.HobbyEvent += HobbyEvent;
            person3.HobbyEvent += HobbyEvent;

            Console.WriteLine("Введите событие из списка 'Встреча с Никитой Соколовым, Концерт Лепса, Просмотр Гарри Поттера зимой':");
            string userEvent = Console.ReadLine();

            if (userEvent == person1.Hobby)
            {
                person1.OnHobbyEvent($"{userEvent} произошла!");
            }
            if (userEvent == person2.Hobby)
            {
                person2.OnHobbyEvent($" {userEvent} наступил");
            }
            if (userEvent == person3.Hobby)
            {
                person3.OnHobbyEvent($"Событие '{userEvent}' произошло");
            }

            Console.ReadLine();

        }
    }
}
