using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using sqlite_net_helper.Conditions;

namespace SQLiteDriver.Conditions
{
    public class ConditionBuilderSQLite : IList<ConditionClausedSqLite>
    {
        public SQLiteCommand CommandSQLite { set; get; }
        private readonly List<ConditionClausedSqLite> _clausedConditions;

        public ConditionBuilderSQLite()
        {
            _clausedConditions = new List<ConditionClausedSqLite>();
        }

        public ConditionBuilderSQLite(
            List<ConditionClausedSqLite> clausedConditions,
            SQLiteCommand commandSQLite) : this(clausedConditions)
        {
            CommandSQLite = commandSQLite;
        }

        public ConditionBuilderSQLite(List<ConditionClausedSqLite> clausedConditions)
        {
            _clausedConditions = clausedConditions;
        }

        public string GetFullConditionQuery()
        {
            return (" WHERE " + GetConditionQuery());
        }

        public string GetConditionQuery()
        {
            if (CommandSQLite == null)
                throw new NullSQLiteCommandReferenceException();

            //in case no conditionedColumnValue was assigned
            if (_clausedConditions.Count == 0)
                return null;
            if (_clausedConditions.Count == 1)
                return ExtractClausedQuery(_clausedConditions[0]);

            var strBldrConditionQuery = new StringBuilder();

            strBldrConditionQuery.Append("\r\n(");

            AppendClausedConditions(strBldrConditionQuery);

            strBldrConditionQuery.Append("\r\n) ");

            return strBldrConditionQuery.ToString();
        }

        private void AppendClausedConditions(StringBuilder strBldrConditionQuery)
        {
            var listClauses = _clausedConditions.ToList();
            var countConditions = listClauses.Count;
            for (var i = 0; i < countConditions; i++)
            {
                var conditionClaused = listClauses[i];

                if (i != 0)
                    strBldrConditionQuery.Append(conditionClaused.ConditionToClause);

                strBldrConditionQuery.Append($"\r\n{ExtractClausedQuery(conditionClaused)} ");

            }
        }

        private string ExtractClausedQuery(ConditionClausedSqLite conditionClaused)
        {
            conditionClaused.CommandSqLite = CommandSQLite;
            return conditionClaused.GetConditionQuery();
        }

        public IEnumerator<ConditionClausedSqLite> GetEnumerator()
        {
            return _clausedConditions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(ConditionClausedSqLite item)
        {
            _clausedConditions.Add(item);
        }

        public void Clear()
        {
            _clausedConditions.Clear();
        }

        public bool Contains(ConditionClausedSqLite item)
        {
            return _clausedConditions.Contains(item);
        }

        public void CopyTo(ConditionClausedSqLite[] array, int arrayIndex)
        {
            _clausedConditions.CopyTo(array, arrayIndex);
        }

        public bool Remove(ConditionClausedSqLite item)
        {
            return _clausedConditions.Remove(item);
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(ConditionClausedSqLite item)
        {
            return _clausedConditions.IndexOf(item);
        }

        public void Insert(int index, ConditionClausedSqLite item)
        {
            _clausedConditions.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _clausedConditions.RemoveAt(index);
        }

        public ConditionClausedSqLite this[int index]
        {
            get { return _clausedConditions[index]; }
            set { _clausedConditions[index] = value; }
        }
    }
}
