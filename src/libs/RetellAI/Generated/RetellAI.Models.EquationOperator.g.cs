
#nullable enable

namespace RetellAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum EquationOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Exists,
        /// <summary>
        /// 
        /// </summary>
        Ge,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Le,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Ne,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        NotExist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EquationOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EquationOperator value)
        {
            return value switch
            {
                EquationOperator.Contains => "contains",
                EquationOperator.Eq => "eq",
                EquationOperator.Exists => "exists",
                EquationOperator.Ge => "ge",
                EquationOperator.Gt => "gt",
                EquationOperator.Le => "le",
                EquationOperator.Lt => "lt",
                EquationOperator.Ne => "ne",
                EquationOperator.NotContains => "not_contains",
                EquationOperator.NotExist => "not_exist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EquationOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => EquationOperator.Contains,
                "eq" => EquationOperator.Eq,
                "exists" => EquationOperator.Exists,
                "ge" => EquationOperator.Ge,
                "gt" => EquationOperator.Gt,
                "le" => EquationOperator.Le,
                "lt" => EquationOperator.Lt,
                "ne" => EquationOperator.Ne,
                "not_contains" => EquationOperator.NotContains,
                "not_exist" => EquationOperator.NotExist,
                _ => null,
            };
        }
    }
}