// namespace Vex.Core.Abstractions.Guards
// {
//     public static class Guard
//     {
//         public static void AgainstNullOrEmpty(string value, string paramName)
//         {
//             if (string.IsNullOrWhiteSpace(value))
//                 throw new ArgumentException("Value cannot be null or empty", paramName);
//         }
        
//         public static void AgainstNegative(decimal value, string paramName)
//         {
//             if (value < 0)
//                 throw new ArgumentException("Value cannot be negative", paramName);
//         }

//         public static void AgainstGreaterThan(decimal value, decimal threshold, string paramName)
//         {
//             if (value > threshold)
//                 throw new ArgumentException($"Value cannot be greater than {threshold}", paramName);
//         }

//         public static void AgainstLessThan(decimal value, decimal threshold, string paramName)
//         {
//             if (value < threshold)
//                 throw new ArgumentException($"Value cannot be less than {threshold}", paramName);
//         }

//         public static void AgainstInequality(decimal value1, decimal value2, string paramName)
//         {
//             if (value1 != value2)
//                 throw new ArgumentException($"Value must be equal to {value2}", paramName);
//         }
//     }
// }