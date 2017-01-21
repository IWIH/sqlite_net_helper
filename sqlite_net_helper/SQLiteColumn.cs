namespace SQLiteDriver
{
    public class SQLiteColumn
    {
        public string ColumnName = "";
        public bool PrimaryKey;
        public DbTypeSQLite DataType = new DbTypeSQLite.TEXT();
        public bool AutoIncrement;
        public bool NotNull;
        public string DefaultValue = "";

        public SQLiteColumn()
        { }

        public SQLiteColumn(string colName)
        {
            ColumnName = colName;
            PrimaryKey = false;
            DataType = new DbTypeSQLite.TEXT();
            AutoIncrement = false;
        }

        public SQLiteColumn(string colName, DbTypeSQLite dataType)
        {
            ColumnName = colName;
            PrimaryKey = false;
            DataType = dataType;
            AutoIncrement = false;
        }

        public SQLiteColumn(string colName, bool autoIncrement)
        {
            ColumnName = colName;

            if (autoIncrement)
            {
                PrimaryKey = true;
                DataType = new DbTypeSQLite.INTEGER();
                AutoIncrement = true;
            }
            else
            {
                PrimaryKey = false;
                DataType = new DbTypeSQLite.TEXT();
                AutoIncrement = false;
            }
        }

        public SQLiteColumn(string colName, DbTypeSQLite dbDataTypeSQLite, bool primaryKey, bool autoIncrement, bool notNull, string defaultValue)
        {
            ColumnName = colName;

            if (autoIncrement)
            {
                PrimaryKey = true;
                DataType = new DbTypeSQLite.INTEGER();
                AutoIncrement = true;
            }
            else
            {
                PrimaryKey = primaryKey;
                DataType = dbDataTypeSQLite;
                AutoIncrement = false;
                NotNull = notNull;
                DefaultValue = defaultValue;
            }
        }
    }
}
