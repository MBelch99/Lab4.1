using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    public class Student
    {      
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int nrindeksu { get; set; }
        public string wydzial { get; set; }


        public Student(string imie, string nazwisko,int nrindeksu, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nrindeksu = nrindeksu;
            this.wydzial = wydzial;
        }

        public Student()
            :this("","",0,"")
        { }
    }
}
