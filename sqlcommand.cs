namespace kütüphane_uygulaması
{
    internal class sqlcommand
    {
        private string v;

        public sqlcommand(string v, System.Data.SqlClient.SqlConnection sqlConnection)
        {
            this.v = v;
        }

        public object Parameters { get; internal set; }
    }
}