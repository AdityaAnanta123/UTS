using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen();
            dosen1.attDosen("Kamarudin, M.Kom",18932423);
            dosen1.addCourse("Pemrograman");
            dosen1.Tampilan();
            Console.ReadKey();
        }
    }
}
