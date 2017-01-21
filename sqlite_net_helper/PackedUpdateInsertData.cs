
using System.Collections.Generic;
using SQLiteDriver.Conditions;

namespace SQLiteDriver
{
    public class PackedUpdateInsertData
    {
        public string TableName { private set; get; }
        public Dictionary<string, object> StoredData { get; }
        public ConditionBuilderSQLite ConditionBuilder { get; }

        public PackedUpdateInsertData(
            string tableName, 
            Dictionary<string, object> storedData,
            ConditionBuilderSQLite conditionBuilder)
        {
            TableName = tableName;
            StoredData = storedData;
            ConditionBuilder = conditionBuilder;
        }
    }
}
