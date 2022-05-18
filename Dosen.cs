using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{
    class Dosen
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int Nik { get; set; }
        public string gender { get; set; }
        public string course { get; set; }

        public Dosen()
        {
            this.id = 1;
            this.nama = "Kamaruddin, M.Kom";
            this.Nik = 213737123;
            this.gender = "Laki-laki";
            this.course = "Pemrograman";
        }
        public void attDosen(string name, int nik)
        {
            this.nama = name;
            this.Nik = nik;
        }
        public void addCourse(string course)
        {
            this.course = course;
        }
        public void Tampilan()
        {
            Console.WriteLine("Id     = {0}", id);
            Console.WriteLine("Nama   = {0}", nama);
            Console.WriteLine("NIK    = {0}", Nik);
            Console.WriteLine("Gender = {0}", gender);
            Console.WriteLine("Course = {0}", course);
        }
    }
}
