using System;
using System.Collections.Generic;
using System.Text;

namespace EmailDetect
{
    public class Detector
    {
        
        public static bool DetectEmail(string name,int password)
        {
            if (name == "cavid@code.edu.az" && password == 12345)
            {
                return true;

            }

            else
            {
                return false;
            }
                

            
        }
    
	}

}
