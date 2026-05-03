using Ardalis.GuardClauses;
using Vex.Core.Abstractions.Exceptions;

namespace Vex.Core.Vectors
{
    public class Vector
    {
        public float[] Values { get; }
        public int Dimension { get; }

        public Vector(float[] values)
        {
            Guard.Against.NullOrEmpty(values, nameof(values));

            Dimension = values.Length;
            Values = values;
        }

        public float DotProduct(Vector other)
        {
            Guard.Against.Null(other, nameof(other));
            Guard.Against.NegativeOrZero(other.Dimension, nameof(other.Dimension));
            
            if (Dimension != other.Dimension)
            {
                throw new DomainException("Vectors must have the same dimension for dot product.");
            }

            var result = Values.Zip(other.Values, (a, b) => a * b).Sum();
            return result;
        }

        public float Magnitude()
        {
            float sumOfSquares = Values.Sum(v => v * v);
            return (float)Math.Sqrt(sumOfSquares);
        }
    }
}