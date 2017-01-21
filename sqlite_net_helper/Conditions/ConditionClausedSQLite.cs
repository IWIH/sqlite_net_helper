using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using SQLiteDriver;
using SQLiteDriver.Conditions;

namespace sqlite_net_helper.Conditions
{
    public class ConditionClausedSqLite : IDictionary<string, ConditionedValue>
    {
        public SQLiteCommand CommandSqLite { set; get; }
        public ConditionOperatorBaseSQLite ConditionToClause { set; get; }
        [NotNull]
        private readonly Dictionary<string, ConditionedValue> _conditionsDictionary;

        public ConditionClausedSqLite()
        {
            _conditionsDictionary = new Dictionary<string, ConditionedValue>();
            Count = new int();
            IsReadOnly = false;
            Keys = new List<string>();
            Values = new List<ConditionedValue>();
        }

        public ConditionClausedSqLite(
            SQLiteCommand commandSqLite,
            ConditionOperatorBaseSQLite conditionToClause,
            Dictionary<string, ConditionedValue> conditionsDictionary) : this(conditionToClause, conditionsDictionary)
        {
            CommandSqLite = commandSqLite;
        }

        public ConditionClausedSqLite(
            ConditionOperatorBaseSQLite conditionToClause,
            Dictionary<string, ConditionedValue> conditionsDictionary) : this(conditionsDictionary)
        {
            ConditionToClause = conditionToClause;
        }

        public ConditionClausedSqLite(Dictionary<string, ConditionedValue> conditionsDictionary)
        {
            _conditionsDictionary = conditionsDictionary ?? new Dictionary<string, ConditionedValue>();

            //initialize IDictionary - NotNull memebers
            var conditionsCount = _conditionsDictionary.Count;
            var conditionsCountLargerThanZero = conditionsCount > 0;
            Keys = conditionsCountLargerThanZero ? new List<string>(conditionsCount) : new List<string>();
            Values = conditionsCountLargerThanZero ? new List<ConditionedValue>(conditionsCount) : new List<ConditionedValue>();
        }

        public string GetFullConditionQuery()
        {
            return (" WHERE " + GetConditionQuery());
        }
        public string GetConditionQuery()
        {
            if (CommandSqLite == null) throw new NullSQLiteCommandReferenceException();

            //in case no conditionedColumnValue was assigned
            if (_conditionsDictionary.Count == 0) throw new NullConditionException();

            var strBldrConditionQuery = new StringBuilder();

            strBldrConditionQuery.Append("\r\n(");

            AppendConditionsToQuery(strBldrConditionQuery);

            strBldrConditionQuery.Append("\r\n) ");

            return strBldrConditionQuery.ToString();
        }

        private void AppendConditionsToQuery(StringBuilder strBldrConditionQuery)
        {
            var listConditions = _conditionsDictionary.ToList();
            var countConditions = listConditions.Count;
            for (var i = 0; i < countConditions; i++)
            {
                var conditionAndValue = listConditions[i].Value;

                if (i != 0)
                    strBldrConditionQuery.Append(conditionAndValue.Operator);

                var columnName = listConditions[i].Key;
                var parameterName = "@VAR" + GenerateParameterName(columnName);

                strBldrConditionQuery.Append($"\r\n{columnName} = {parameterName} ");

                CommandSqLite.Parameters.Add(new SQLiteParameter(parameterName, conditionAndValue.Value));
            }
        }

        private string GenerateParameterName(string initialName)
        {
            if (!CommandSqLite.Parameters.Contains(initialName))
                return initialName;

            long parameterPostfix = 0;
            var newName = initialName + parameterPostfix;

            while (CommandSqLite.Parameters.Contains(newName))
            {
                parameterPostfix++;
                newName = initialName + parameterPostfix;
            }

            return newName;
        }

        public IEnumerator<KeyValuePair<string, ConditionedValue>> GetEnumerator()
        {
            return _conditionsDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<string, ConditionedValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Clear()
        {
            _conditionsDictionary.Clear();
        }

        public bool Contains(KeyValuePair<string, ConditionedValue> item)
        {
            return _conditionsDictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, ConditionedValue>[] array, int arrayIndex)
        {
            _conditionsDictionary.ToList().CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<string, ConditionedValue> item)
        {
            return _conditionsDictionary.Remove(item.Key);
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public bool ContainsKey(string key)
        {
            return _conditionsDictionary.ContainsKey(key);
        }

        public void Add(string key, ConditionedValue value)
        {
            _conditionsDictionary.Add(key, value);
        }

        public bool Remove(string key)
        {
            return _conditionsDictionary.Remove(key);
        }

        public bool TryGetValue(string key, out ConditionedValue value)
        {
            return _conditionsDictionary.TryGetValue(key, out value);
        }

        public ConditionedValue this[string key]
        {
            get { return _conditionsDictionary[key]; }
            set { _conditionsDictionary[key] = value; }
        }

        public ICollection<string> Keys { get; }
        public ICollection<ConditionedValue> Values { get; }
    }
}
