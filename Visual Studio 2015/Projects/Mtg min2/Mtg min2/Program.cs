using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mtg_min2
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Spacer();

            Menu();
        }
        static void Header()
        {
            Console.WriteLine("Meeting Minutes Management Software");

        }
        static void Meeting()
        {

            Spacer();

            Console.WriteLine("Enter team Member Recording Meeting Minutes:");
            string minuteRecorder = Console.ReadLine();

            Spacer();
            Console.WriteLine("Enter Team Member Leading Meeting: ");
            string meetingLeader = Console.ReadLine();
            Spacer();
            Console.WriteLine("Enter Date of Team Meeting (Enter date in \"MMDDYY\" format):");
            string meetingDate = Console.ReadLine();
            string meetingName= ("Minutes" + meetingDate);

            //meeting list
            List<string> meetingType = new List<string>();
            meetingType.Add("Development");
            meetingType.Add("Marketing ");
            meetingType.Add("Production");
            meetingType.Add("Distribution");
            meetingType.Add("Legal");
            meetingType.Add("All");

            Console.WriteLine("Please Select a Meeting Type from the options below");

            Console.WriteLine("1 | Development");
            Console.WriteLine("2 | Marketing");
            Console.WriteLine("3 | Production");
            Console.WriteLine("4 | Distribution");
            Console.WriteLine("5 | Legal ");
            Console.WriteLine("6 | All");
            int meetingOption = int.Parse(Console.ReadLine());

            Spacer();
            string meetType = "";
                        
            switch (meetingOption)
            {
                case 1:
                    meetType = meetingType[0];
                    break;
                case 2:
                    meetType = meetingType[1];
                    break;
                case 3:
                    meetType = meetingType[2];
                    break;
                case 4:
                    meetType = meetingType[3];
                    break;
                case 5:
                    meetType = meetingType[4];
                    break;
                case 6:
                    meetType = meetingType[5];
                    break;
                default:
                    break;

            }
            string topAnswer = "N";
            List<string> meetingTopic = new List<string>();
            List<string> meetingNotes = new List<string>();
            string txtName = meetingName + ".txt";

            StreamWriter write = new StreamWriter(txtName);

            using (write)
            {
                write.WriteLine("Muse Media Group ");
                write.WriteLine("3316 Dream Ave\n Cleveland Oh 44118");
                write.WriteLine("\r\n");

                write.WriteLine("meeting Minutes");
                write.WriteLine("\r\n");
                write.WriteLine("Recorder:" + minuteRecorder);
                write.WriteLine("Leader:" + meetingLeader);

                int counter = 0;
                do
                {
                    Console.WriteLine("Enter Meeting Topic:");
                    meetingTopic.Add(Console.ReadLine());
                    write.WriteLine("Meeting Topic:" + meetingTopic[counter]);

                    Console.WriteLine("Enter meeting Notes for {0}:", meetingTopic[counter]);

                    meetingNotes.Add(Console.ReadLine());
                    write.WriteLine("Meeting Notes:" + meetingNotes[ counter]);
                    spacer();

                    counter++;


                }



            }









        }
    }
}
