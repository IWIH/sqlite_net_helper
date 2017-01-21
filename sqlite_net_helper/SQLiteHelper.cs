/*
// **************************************************************************************** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒** //
// **░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      ░  ░░░░░░░░░░░░░  ░  ░  ░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░  ░░░░░       ░  ░  ░  ░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░░░░░░  ░░░  ░         ░  ░░░░░ ░░░░  ░  ░  ░  ░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░░░░░░  ░░░  ░░░░░░░░  ░  ░░░░░       ░  ░  ░  ░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░░░░░░                 ░  ░░░░░░░░░░        ░  ░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░░░░   ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░    ░░░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░** //
// **░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **████████████████████████████████████████████████████████████████████████████████████** //
// **************************************************************************************** //
*/
//
// SQLiteExplicitHelper - API | BY: Osama Al Alwash - Iraq
// Based on adriancs' - SQLiteHelper V1.2 @ http://sh.codeplex.com

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using sqlite_net_helper.Conditions;
using SQLiteDriver.Conditions;

namespace SQLiteDriver
{

    public class SQLiteHelper : IDisposable
    {
        private readonly SQLiteCommand _commandSQLite;
        private readonly SQLiteConnection _connectionSQLite;

        public SQLiteHelper(
            string databaseLocation,
            string password = null)
        {
            try
            {
                _connectionSQLite = SQLiteConnectionGenerator(databaseLocation, password);
                _commandSQLite = new SQLiteCommand(_connectionSQLite);
            }
            catch (Exception)
            {
                throw new InaccessibleDatabaseLocationException(databaseLocation);
            }
        }

        public static SQLiteConnection SQLiteConnectionGenerator(
            string databaseFilePath,
            string databasePassword)
        {
            //generating password string
            var connectionString = ConnectionString(databaseFilePath, databasePassword);

            var sqLiteConnection = new SQLiteConnection(connectionString);
            sqLiteConnection.Open();

            return sqLiteConnection;
        }

        public static string ConnectionString(string databaseFilePath, string databasePassword)
        {
            var passwordString = string.IsNullOrEmpty(databasePassword)
                ? string.Empty
                : $"; Password='{databasePassword}';";

            var connectionString = $"Data Source='{databaseFilePath}'{passwordString}";
            return connectionString;
        }

        public SQLiteHelper(SQLiteConnection connectionSQLite)
        {
            _connectionSQLite = connectionSQLite.OpenAndReturn();
            _commandSQLite = new SQLiteCommand(connectionSQLite);
        }

        public SQLiteHelper(SQLiteCommand commandSQLite)
        {
            _commandSQLite = commandSQLite;
            _connectionSQLite = _commandSQLite.Connection.OpenAndReturn();
        }

        public bool IsConnectedToDatabase()
        {
            return ((_connectionSQLite != null) && (_commandSQLite != null));
        }

        #region DB Info

        public DataTable GetDatabaseStructure()
        {
            return DataTableExectution("SELECT * FROM sqlite_master;");
        }

        public IEnumerable<string> GetTableList()
        {
            var dt = GetDatabaseStructure();

            var listTables = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                var nameTable = row["name"].ToString();
                if (!IsSQLiteTable(nameTable))
                    listTables.Add(nameTable);
            }

            return listTables;
        }

        private bool IsSQLiteTable(string nameTable)
        {
            return ((nameTable.Contains("sqlite_autoindex_") || nameTable == "sqlite_sequence"));
        }

        public DataTable GetTableStructure(string tableName)
        {
            return DataTableExectution($"PRAGMA table_info('{tableName}');");
        }

        public DataTable ShowAllAttachedDatabases()
        {
            return DataTableExectution("PRAGMA database_list;");
        }

        #endregion

        #region Query

        public void BeginTransaction()
        {
            _commandSQLite.CommandText = "BEGIN TRANSACTION;";
            _commandSQLite.ExecuteNonQuery();
        }

        public void Commit()
        {
            ExecuteNonQuerySQLite("COMMIT;");
        }

        public void Rollback()
        {
            ExecuteNonQuerySQLite("ROLLBACK;");
        }

        private void ParametersAssigningToSQLiteCommand(Dictionary<string, object> parametersDictionary, string prefixParameterName)
        {
            _commandSQLite.Parameters.AddRange(parametersDictionary.Select(
                kv => new SQLiteParameter(prefixParameterName + kv.Key, kv.Value)
                ).ToArray());
        }

        //----------------SELECT QUERY----------------//

        public DataTable DataTableExectution(string query)
        {
            _commandSQLite.CommandText = query;

            DataTable dataTable;
            using (var dataAdapter = new SQLiteDataAdapter(_commandSQLite))
            {
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable Select(
            string tableName,
            ConditionClausedSqLite conditionClaused,
            string[] projections = null)
        {
            ConditionBuilderSQLite conditionsBuilder = null;
            if (conditionClaused != null)
                conditionsBuilder = 
                    new ConditionBuilderSQLite(new List<ConditionClausedSqLite> { conditionClaused });

            return Select(tableName, conditionsBuilder, projections);
        }

        public DataTable Select(
            string tableName,
            ConditionBuilderSQLite conditionsBuilder = null,
            string[] projections = null)
        {
            //preparing columns query
            var columnsQuery = GetColumnsQuery(projections);

            //preparing conditions query
            var fullConditionQuery = (conditionsBuilder == null) ?
                string.Empty : conditionsBuilder.GetFullConditionQuery();

            //assigning commandSQLite text to SQLiteCommand
            var query = $"SELECT {columnsQuery} FROM {tableName} {fullConditionQuery};";

            return DataTableExectution(query);
        }

        private string GetColumnsQuery(string[] projections)
        {
            var areNullProjections = (projections == null);
            areNullProjections = areNullProjections ? areNullProjections : (projections.Length == 0);

            if (areNullProjections) return "*";

            var length = projections.Length;
            var columnsQueryStrBldr = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                columnsQueryStrBldr.Append(projections[i]);

                if (i != length - 1)
                    columnsQueryStrBldr.Append(", ");
            }

            return columnsQueryStrBldr.ToString();
        }

        //----------------EXECUTE NON-QUERY----------------//
        private int ExecuteNonQuerySQLite(string query)
        {
            _commandSQLite.CommandText = query;
            var countEffectRows = _commandSQLite.ExecuteNonQuery();
            return countEffectRows;
        }

        public int ExecuteNonQuery(string query)
        {
            return ExecuteNonQuery(query, new List<SQLiteParameter>());
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> dicParameters)
        {
            IEnumerable<SQLiteParameter> lst = GetParametersList(dicParameters);
            return ExecuteNonQuery(query, lst);
        }

        public int ExecuteNonQuery(string query, IEnumerable<SQLiteParameter> parameters)
        {
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    _commandSQLite.Parameters.Add(param);
                }
            }
            return ExecuteNonQuerySQLite(query);
        }

        //----------------EXECUTE SCALAR----------------//
        private object ExecuteScalarSQLite()
        {
            var returnObj = _commandSQLite.ExecuteScalar();
            return returnObj;
        }

        public object ExecuteScalar(string sql)
        {
            _commandSQLite.CommandText = sql;
            return ExecuteScalarSQLite();
        }

        public object ExecuteScalar(string sql, Dictionary<string, object> dicParameters)
        {
            IEnumerable<SQLiteParameter> lst = GetParametersList(dicParameters);
            return ExecuteScalar(sql, lst);
        }

        public object ExecuteScalar(string sql, IEnumerable<SQLiteParameter> parameters)
        {
            _commandSQLite.CommandText = sql;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    _commandSQLite.Parameters.Add(parameter);
                }
            }
            return ExecuteScalarSQLite();
        }

        public T ExecuteScalar<T>(string sql, Dictionary<string, object> dicParameters)
        {
            List<SQLiteParameter> lst = null;
            if (dicParameters != null)
            {
                lst = new List<SQLiteParameter>();
                foreach (KeyValuePair<string, object> kv in dicParameters)
                {
                    lst.Add(new SQLiteParameter(kv.Key, kv.Value));
                }
            }
            return ExecuteScalar<T>(sql, lst);
        }

        public T ExecuteScalar<T>(string sql, IEnumerable<SQLiteParameter> parameters)
        {
            _commandSQLite.CommandText = sql;
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    _commandSQLite.Parameters.Add(parameter);
                }
            }
            return (T)Convert.ChangeType(ExecuteScalarSQLite(), typeof(T));
        }

        public T ExecuteScalar<T>(string sql)
        {
            _commandSQLite.CommandText = sql;
            return (T)Convert.ChangeType(ExecuteScalarSQLite(), typeof(T));
        }

        private IEnumerable<SQLiteParameter> GetParametersList(Dictionary<string, object> parametersDic)
        {
            var lst = new List<SQLiteParameter>();
            if (parametersDic == null) return lst;

            lst.AddRange(parametersDic.Select(kv => new SQLiteParameter(kv.Key, kv.Value)));

            return lst;
        }

        //----------------INSERT----------------//
        public int BulkInsert(IEnumerable<PackedUpdateInsertData> insertData)
        {
            BeginTransaction();

            var countInsertedRows = 0;
            try
            {
                foreach (var insertDat in insertData)
                {
                    var countInserted = Insert(
                        insertDat.TableName,
                        insertDat.StoredData);

                    if (countInserted > 0)
                        countInsertedRows++;
                }
                Commit();
            }
            catch
            {
                Rollback();
            }

            return countInsertedRows;
        }
        public int Insert(string tableName, Dictionary<string, object> dataDictionary)
        {
            if (dataDictionary.Count == 0) return -1;

            var columnsQueryStrBuilder = new StringBuilder();
            var valuesQueryStrBuilder = new StringBuilder();

            columnsQueryStrBuilder.Append("INSERT INTO ");
            columnsQueryStrBuilder.Append(tableName);
            columnsQueryStrBuilder.Append("(");

            valuesQueryStrBuilder.Append(" VALUES(");

            ColumnsAndValuesFormingInsertQuery(dataDictionary, columnsQueryStrBuilder, valuesQueryStrBuilder);

            columnsQueryStrBuilder.Append(") ");
            valuesQueryStrBuilder.Append(");");

            //addding parameters values to SQLite commandSQLite
            ParametersAssigningToSQLiteCommand(dataDictionary, "@v");

            return ExecuteNonQuerySQLite(
                columnsQueryStrBuilder.ToString() + valuesQueryStrBuilder.ToString());
        }

        public long LastInsertRowId()
        {
            return ExecuteScalar<long>("SELECT last_insert_rowid();");
        }

        private static void ColumnsAndValuesFormingInsertQuery(Dictionary<string, object> dataDictionary, StringBuilder columnsQueryStrBuilder,
            StringBuilder valuesQueryStrBuilder)
        {
            var listData = dataDictionary.ToList();
            for (var i = 0; i < listData.Count; i++)
            {
                if (i != 0)
                {
                    columnsQueryStrBuilder.Append(",");
                    valuesQueryStrBuilder.Append(", ");
                }
                //adding columns identifiers to query
                columnsQueryStrBuilder.Append("'");
                columnsQueryStrBuilder.Append(listData[i].Key);
                columnsQueryStrBuilder.Append("'");
                //adding parameters identifiers to query
                valuesQueryStrBuilder.Append("@v");
                valuesQueryStrBuilder.Append(listData[i].Key);
            }
        }

        //----------------UPDATE----------------//
        public int BulkUpdate(IEnumerable<PackedUpdateInsertData> updateDataAndConditions)
        {
            BeginTransaction();

            var countUpdatedRows = 0;
            try
            {
                foreach (var updateDataAndCondition in updateDataAndConditions)
                {
                    var indexUpdateRow = Update(
                        updateDataAndCondition.TableName,
                        updateDataAndCondition.StoredData,
                        updateDataAndCondition.ConditionBuilder);

                    if (indexUpdateRow > 0)
                        countUpdatedRows++;
                }
                Commit();
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }

            return countUpdatedRows;
        }

        public int Update(
            string tableName,
            Dictionary<string, object> updateDataDic,
            ConditionBuilderSQLite conditionsBuilder)
        {
            if (updateDataDic.Count == 0) throw new NoDataDictionaryProvidedException();
            if (conditionsBuilder.Count == 0) throw new NullConditionException();

            var dataStringBuilder = new StringBuilder();

            dataStringBuilder.Append($"UPDATE {tableName} SET");

            ValuesFormingUpdateQuery(updateDataDic, dataStringBuilder);

            conditionsBuilder.CommandSQLite = _commandSQLite;
            dataStringBuilder.Append(conditionsBuilder.GetFullConditionQuery());

            dataStringBuilder.Append(";");

            //assigning update values to corresponding variables
            ParametersAssigningToSQLiteCommand(updateDataDic, "@v");

            return ExecuteNonQuerySQLite(dataStringBuilder.ToString());
        }

        private static void ValuesFormingUpdateQuery(Dictionary<string, object> updateData, StringBuilder dataStringBuilder)
        {
            var listUpdateData = updateData.ToList();
            for (var i = 0; i < listUpdateData.Count; i++)
            {
                if (i != 0)
                    dataStringBuilder.Append(",");

                dataStringBuilder.Append($"'{listUpdateData[i].Key}' = @v{listUpdateData[i].Key}");
            }
        }

        //----------------DELETE----------------//
        public int Delete(string tablName, ConditionClausedSqLite clausedCondition)
        {
            return Delete(
                tablName,
                new ConditionBuilderSQLite(new List<ConditionClausedSqLite> { clausedCondition }));
        }

        public int Delete(string tablName, ConditionBuilderSQLite conditionBuilder)
        {
            if (conditionBuilder.Count == 0)
                throw new NullConditionException();

            conditionBuilder.CommandSQLite = _commandSQLite;
            var fullConditionQuery = conditionBuilder.GetFullConditionQuery();
            return DeleteQueryExecute(tablName, fullConditionQuery);
        }

        private int DeleteQueryExecute(string tablName, string deletionConditions)
        {
            var deletionQuery = $"DELETE FROM {tablName} {deletionConditions};";

            return ExecuteNonQuery(deletionQuery);
        }

        #endregion

        #region Utilities

        public int CreateTable(SQLiteTable table)
        {
            var queryStrBldr = new StringBuilder();
            queryStrBldr.Append($"CREATE TABLE IF NOT EXISTS '{table.TableName}' (");

            for (var i = 0; i < table.Columns.Count; i++)
            {
                var column = table.Columns[i];
                if (column.ColumnName.Trim().Length == 0)
                    throw new NullColumnNameException();

                queryStrBldr.Append(column.ColumnName);

                queryStrBldr.Append(" ");

                if (column.AutoIncrement)
                {
                    queryStrBldr.Append(" INTEGER PRIMARY KEY AUTOINCREMENT ");
                    queryStrBldr.AppendLine(" , ");
                    continue;
                }

                queryStrBldr.Append(column.DataType);

                if (column.PrimaryKey)
                    queryStrBldr.Append(" PRIMARY KEY ");

                else if (column.NotNull)
                    queryStrBldr.Append(" NOT NULL");

                else if (column.DefaultValue.Length > 0)
                {
                    queryStrBldr.Append(" DEFAULT ");

                    if (
                        column.DefaultValue.Contains(" ") ||
                        column.DataType == (new DbTypeSQLite.TEXT()) ||
                        column.DataType == (new DbTypeSQLite.DATETIME()))
                    {
                        queryStrBldr.Append($" '{column.DefaultValue}' ");
                    }
                    else
                        queryStrBldr.Append($" {column.DefaultValue} ");
                }

                if (i < (table.Columns.Count - 1))
                    queryStrBldr.AppendLine(" , ");
            }


            queryStrBldr.AppendLine(" ) ;");

            return ExecuteNonQuerySQLite(queryStrBldr.ToString());
        }

        public int RenameTable(string tableFrom, string tableTo)
        {
            var query = $"ALTER TABLE '{tableFrom}' RENAME TO '{tableTo}';";
            return ExecuteNonQuerySQLite(query);
        }

        public int CopyAllData(string originTable, string destinationTable)
        {
            var originDataTable = DataTableExectution($"SELECT * FROM '{originTable}' WHERE 1 = 2;");
            var destinationDataTable = DataTableExectution($"SELECT * FROM '{destinationTable}' WHERE 1 = 2;");

            var mutualColumnsDic = new Dictionary<string, bool>();

            foreach (DataColumn column in originDataTable.Columns)
            {
                if (destinationDataTable.Columns.Contains(column.ColumnName))
                {
                    if (!mutualColumnsDic.ContainsKey(column.ColumnName))
                    {
                        mutualColumnsDic[column.ColumnName] = true;
                    }
                }
            }

            foreach (DataColumn column in destinationDataTable.Columns)
            {
                if (originDataTable.Columns.Contains(column.ColumnName))
                {
                    if (!mutualColumnsDic.ContainsKey(column.ColumnName))
                    {
                        mutualColumnsDic[column.ColumnName] = true;
                    }
                }
            }

            var columnsQuery = new StringBuilder();

            foreach (var keyValue in mutualColumnsDic)
            {
                if (columnsQuery.Length > 0)
                    columnsQuery.Append(",");

                columnsQuery.Append($"'{keyValue.Key}'");
            }

            var query = $"INSERT INTO '{destinationTable}' ( {columnsQuery} ) SELECT {columnsQuery} FROM '{originTable}';";

            return ExecuteNonQuerySQLite(query);
        }

        public int DropTable(string table)
        {
            return ExecuteNonQuerySQLite($"DROP TABLE IF EXISTS '{table}';");
        }

        public void UpdateTableStructure(string targetTable, SQLiteTable newStructure)
        {
            newStructure.TableName = targetTable + "_temp";

            CreateTable(newStructure);

            CopyAllData(targetTable, newStructure.TableName);

            DropTable(targetTable);

            RenameTable(newStructure.TableName, targetTable);
        }

        public void AttachDatabase(string database, string alias)
        {
            ExecuteNonQuery($"ATTACH '{database}' AS {alias};");
        }

        public void DetachDatabase(string alias)
        {
            ExecuteNonQuery($"DETACH {alias};");
        }

        #endregion

        public void Dispose()
        {
            _commandSQLite?.Dispose();

            if (_connectionSQLite != null)
            {
                _connectionSQLite.Close();
                _connectionSQLite.Dispose();
            }
        }
    }
}