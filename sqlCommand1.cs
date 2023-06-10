using System;
using System.Data.SqlClient;

namespace kütüphane_uygulaması
{
    internal class sqlCommand
    {
        private string v;
        private SqlConnection sqlConnection;

        public sqlCommand(string v, SqlConnection sqlConnection)
        {
            this.v = v;
            this.sqlConnection = sqlConnection;
        }

        public object Parameters { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}