namespace SQLiteDriver.Conditions
{
    public class ConditionOperatorBaseSQLite
    {
        private readonly string _operator;
        
        public ConditionOperatorBaseSQLite(string @operator)
        {
            _operator = @operator;
        }

        public override string ToString()
        {
            return _operator;
        }

        public class AND : ConditionOperatorBaseSQLite
        {
            public AND() : base("AND") { }
        }

        public class OR : ConditionOperatorBaseSQLite
        {
            public OR() : base("OR") { }
        }
    }
}
