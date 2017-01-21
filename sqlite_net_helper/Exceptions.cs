using System;

namespace SQLiteDriver
{
    public class NullConditionException : Exception
    {
        public NullConditionException() : base("No condition provided! One or more conditions are required to perform the query.")
        { }
    }
    public class NoDataDictionaryProvidedException : NullReferenceException
    {
        public NoDataDictionaryProvidedException() : base("No data dictionary provided! One or more key-value pairs are required to perform the query.")
        { }
    }

    public class NullColumnNameException : NullReferenceException
    {
        public NullColumnNameException() : base("Null column name.")
        { }
    }

    public class InaccessibleDatabaseLocationException : Exception
    {
        public InaccessibleDatabaseLocationException(string locationDatabase) :
            base($"Invalid or inaccessible database location:\r\n\"{locationDatabase}\"")
        { }
    }

    public class NullSQLiteCommandReferenceException : NullReferenceException
    {
        public NullSQLiteCommandReferenceException() : base("Null SQLiteCommand reference.")
        { }
    }
}
