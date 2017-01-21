namespace SQLiteDriver
{
    public class DbTypeSQLite
    {
        private readonly string _dataType;

        public DbTypeSQLite(string dataType)
        {
            _dataType = dataType;
        }

        public override string ToString()
        {
            return _dataType;
        }

        public class TEXT : DbTypeSQLite
        {
            public TEXT() : base("TEXT") { }
        }

        public class DATETIME : DbTypeSQLite
        {
            public DATETIME() : base("DATETIME") { }
        }

        public class BLOB : DbTypeSQLite
        {
            public BLOB() : base("BLOB") { }
        }

        public class REAL : DbTypeSQLite
        {
            public REAL() : base("REAL") { }
        }

        public class INTEGER : DbTypeSQLite
        {
            public INTEGER() : base("INTEGER") { }
        }
    }
}
