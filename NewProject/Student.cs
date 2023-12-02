using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Student
    {
        
        public string Name = "";
        public double Num = 0.0;
        public double Note = 0.0;

        public double CalAvarege()
        {
            return Note / Num;

        }

        public bool Aprovate()
        {
            if (Num >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemoNote(){

            if (Aprovate())
            {
                return 0.0; 
            }
            else
            {
                return 7.0 - CalAvarege();
            }
        }

        public override string ToString()
        {
            return ("Student " + Name + ", and final note: " + CalAvarege().ToString("F2", CultureInfo.InvariantCulture));       
        }
    }
}
