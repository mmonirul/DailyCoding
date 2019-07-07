using System;
using System.Collections.Generic;
using System.Linq;

// TODO: Find more optimal solution
namespace DailyCodingProblem.Solutions.Problem21
{
    public class MeetingRoomsRequired
    {
        public static void Test()
        {
            var meetings = new List<Meeting>()
            {
                //new Meeting(8, 10),
                //new Meeting(9, 10),
                //new Meeting(10, 11),
                //new Meeting(8, 12),
                new Meeting(30, 75),
                new Meeting(0, 50),
                new Meeting(60, 150)
            };

            var scheduler = new Scheduler();

            var rooms = scheduler.ScheduleMeetings(meetings);

            Console.WriteLine("Number of Rooms: {0}", rooms.Count);
            PrintDetails(rooms);

        }

        private static void PrintDetails(IEnumerable<Room> rooms)
        {
            var i = 1;
            foreach (var r in rooms)
            {
                Console.WriteLine("Room: {0}", i++);

                var j = 1;

                foreach (var m in r.Meetings)
                {
                    Console.WriteLine("\tMeeting: {0}", j++);
                    Console.WriteLine("\t\tStart: {0}", m.StartTime);
                    Console.WriteLine("\t\tStart: {0}", m.EndTime);
                }
                Console.WriteLine();
            }
        }
    }
    public struct Meeting
    {
        public decimal StartTime;
        public decimal EndTime;

        public Meeting(decimal sTime, decimal eTime)
        {
            StartTime = sTime;
            EndTime = eTime;
        }
    }

    public class Room
    {
        public IList<Meeting> Meetings;

        public Room()
        {
            Meetings = new List<Meeting>();
        }

        public bool TryScheduleMeeting(Meeting meeting)
        {
            foreach (var scheduleMeeting in Meetings)
            {
                if ((meeting.StartTime < scheduleMeeting.EndTime) && (meeting.EndTime > scheduleMeeting.StartTime))
                {
                    return false;
                }              
            }
            Meetings.Add(meeting);

            return true;
        }
    }

    public class Scheduler
    {
        public IList<Room> Rooms;

        public Scheduler()
        {
            Rooms = new List<Room>();
        }

        public IList<Room> ScheduleMeetings(List<Meeting> meetings)
        {
            foreach (var meeting in meetings)
            {
                var isMeetingScheduled = Rooms.Any(room => room.TryScheduleMeeting(meeting));

                if (isMeetingScheduled) continue;
                var newRoom = new Room();
                newRoom.TryScheduleMeeting(meeting);
                Rooms.Add(newRoom);
            }

            return Rooms;
        }
    }
}