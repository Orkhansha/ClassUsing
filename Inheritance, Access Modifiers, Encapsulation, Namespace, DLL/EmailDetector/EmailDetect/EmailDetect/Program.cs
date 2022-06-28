using System;

namespace EmailDetect
{
    class Program:Detector
    {
        static void Main(string[] args)
        {
            Detector detector = new Detector();
            string mail = "cavid@code.edu.az";
            int password = 12345;

            if(Detector.DetectEmail(mail, password))
            {
                Console.WriteLine("Girish olundu");
            }
            else
            {
                Console.WriteLine("Mail ve ya password yalnishdir");
            }

        
        }
    }
}
