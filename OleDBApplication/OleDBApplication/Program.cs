using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string ConnectionString = "Provider: Microsoft.Jet.OLEDB.4.0; Data Source='Abc'";
            string abc = "Select * from emp";
            using (OleDbConnection connection = new OleDbConnection(abc))
            {
                OleDbCommand command = new OleDbCommand(abc, connection);
                try
                {
                    connection.Open();
                    OleDbDataReader= command.ExecuteReader();
                  

                }
            }
        }
    }
}
