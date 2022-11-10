using System;

namespace DelegatesDemo
{
    public enum WorkType
    {
        Golf, GoToMeetings, GenerateReports
    }

    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public class Program
    {
        public static void Manager_WorkPerformed(int workHours, WorkType workType)
        {
            System.Console.WriteLine("Work performed by event handler");
            System.Console.WriteLine("Work Hours : " + workHours + " | Work Type : " + workType);
        }
        static void Main(string [] args) 
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);
            del1(10, WorkType.Golf);
        }
    }
}