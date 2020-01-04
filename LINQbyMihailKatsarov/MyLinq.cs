using System;
using System.Collections.Generic;
using System.Text;

namespace LINQbyMihailKatsarov
{
    public static class MyLinq
    {
        //Custom LINQ Where by Mihail Katsarov
        //This method is implemented by using deferred execution.
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,
                                               Func<T,bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        //Custom LINQ AVG by Mihail Katsarov
        public static double? MyAvg(this IEnumerable<int> source)
        {
            double? sum = 0;
            int totalCount = 0;
            double? result = 0;

            foreach (var number in source)
            {
                sum += number;
                totalCount += 1;
            }

            result = sum / totalCount;

            return result;
            
        }

        //Custom LINQ Max by Mihail Katsarov
        public static int MyMax(this IEnumerable<int> source)
        {
            if (source is null)
            {
                throw new ArgumentNullException("soruce");
            }

            int result = 0;
            bool hasValue = false;

            foreach (var number in source)
            {
                if (hasValue)
                {
                    if (number > result)
                    {
                        result = number;
                    }
                }
                else
                {
                    result = number;
                    hasValue = true;
                }
            }

            return result;
        }

        //Custom LINQ Min by Mihil Katsarov
        public static int? MyMinNullable(this IEnumerable<int?> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("soruce");
            }

            int? result = null;

            foreach (int? number in source)
            {
                if (number < result || result == null)
                {
                    result = number;
                }
            }

            return result;
        }

        //Custom LINQ Min by Mihil Katsarov
        //Note that it throws the exception for an empty collection
        public static int MyMin(this IEnumerable<int> source)
        {
            if(source is null) throw new ArgumentNullException("soruce");

            int result = 0;
            bool hasValue = false;

            foreach (var item in source)
            {
                if (hasValue)
                {
                    if (item < result)
                    {
                        result = item;
                    }
                }
                else
                {
                    result = item;
                    hasValue = true;
                }

            }

            return result;
        }

        //Custom LINQ Count by Mihail Katsarov
        public static int MyCount<T>(this IEnumerable<T> soruce)
        {
            int count = 0;

            foreach (var item in soruce)
            {
                count += 1;
            }

            return count;
        }
    }
}
