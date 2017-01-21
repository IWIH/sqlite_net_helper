namespace SQLiteDriver.Conditions
{
    public class ConditionedValue
    {
        public ConditionOperatorBaseSQLite Operator { set; get; }
        public object Value { set; get; }

        public ConditionedValue(object value, ConditionOperatorBaseSQLite @operator = null)
        {
            
            Operator = @operator ?? new ConditionOperatorBaseSQLite.OR();

            Value = value;
        }
    }
}
