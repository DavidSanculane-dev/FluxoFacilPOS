using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoFacil.Dados
{
    public class dbconnection
    {
        public FbConnection connection;
        public FbCommand cmd;
        public FbDataAdapter da;

        public string dbconnect()
        {
            string filePath = System.Environment.CurrentDirectory + "\\dir.txt";
            string caminhoDB = File.ReadAllText(filePath).Trim();
            string conn = caminhoDB;

            return conn;
        }

    }
}
