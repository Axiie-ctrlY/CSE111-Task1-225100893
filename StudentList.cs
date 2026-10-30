// Name: Sohaila Ahmed Elrefaey
// Student ID: 225100893

using System;
namespace Cse111Task1
{
    public class StudentList
    {
        public Student? First;
        public Student? Last;
        public int Count;

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        // Add a student at the beginning
        public void AddFront(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }

            Count++;
        }

        // Add a student at the end
        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last.Next = newStudent;
                Last = newStudent;
            }

            Count++;
        }

        // Remove the first student with the given ID
        public bool Remove(int id)
        {
            if (First == null)
                return false;

            if (First.Id == id)
            {
                First = First.Next;
                Count--;

                if (First == null)
                    Last = null;

                return true;
            }

            Student previous = First;
            Student? current = First.Next;

            while (current != null)
            {
                if (current.Id == id)
                {
                    previous.Next = current.Next;

                    if (current == Last)
                        Last = previous;

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        // Reverse the linked list
        public void Reverse()
        {
            Student? previous = null;
            Student? current = First;

            Last = First;

            while (current != null)
            {
                Student? next = current.Next;

                current.Next = previous;

                previous = current;
                current = next;
            }

            First = previous;
        }

        // Print all student IDs
        public void Print()
        {
            Student? current = First;

            while (current != null)
            {
                Console.Write(current.Id);

                if (current.Next != null)
                    Console.Write(" ");

                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
