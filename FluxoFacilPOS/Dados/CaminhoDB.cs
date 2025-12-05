using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoFacil.Dados
{
    internal class CaminhoDB
    {

        public string dir;
        public string location;

        public String GetDir()
        {
            return location;
        }

        public void SaveDir()
        {
            StreamWriter sw = new StreamWriter("dir.txt");
            dir = location;
            sw.WriteLine(dir);
            sw.Close();
        }

        public void LoadDir()
        {
            StreamReader sR = new StreamReader("dir.txt");
            dir = sR.ReadLine();
            sR.Close();
        }
    }
}
