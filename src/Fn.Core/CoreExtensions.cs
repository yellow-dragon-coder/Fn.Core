using System;
using System.Collections.Generic;
using System.Linq;

namespace Fn.Core
{
    public static class CoreExtensions
    {
        public static bool In<T>(this T value, params T[] values) where T : IEquatable<T>
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            if (values.Length == 0)
                return false;

            foreach (var v in values)
            {
                if (value.Equals(v))
                    return true;
            }

            return false;
        }

        public static bool In<T>(this T value, IEnumerable<T> values) where T : IEquatable<T>
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            if (!values.Any())
                return false;

            foreach (var v in values)
            {
                if (value.Equals(v))
                    return true;
            }

            return false;
        }
    }
}
