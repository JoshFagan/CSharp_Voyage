using System;
using System.Collections.Generic;

namespace Algorithms
{
    /// <summary>
    ///     Class <c>Sort</c> Implements various type and list invariant soring methods.
    /// </summary>
    public static class Sort<T> where T : IComparable
    {
        /// <summary>
        ///     Implements the Insertion Sort method.
        /// 
        ///     <example>
        ///         For example:
        ///         <code>
        ///             string[] stringList = { "Bob", "Alice", "Foo", "Bar" };
        ///             Sort<string>.InsertionSort(stringList);
        ///         </code>
        ///         results in <c>stringList</c>'s value being [Alice, Bar, Bob, Foo].
        ///     </example>
        /// 
        ///     <param>
        ///         <c>list</c> is the list to be sorted.
        ///     </param>
        /// </summary>
        public static void InsertionSort(IList<T> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (list[j].CompareTo(list[j - 1]) == -1)
                    {
                        Switch(list, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        ///     Switches values between two indices in a list.
        ///
        ///     <param>
        ///         <c>list</c> is the list storing the values to be switched.
        ///     </param>
        ///     <param>
        ///         <c>index1</c> is the index of the first value to be switched.
        ///     </param>
        ///      <param>
        ///         <c>index2</c> is the index of the second value to be switched.
        ///     </param>
        /// </summary>
        private static void Switch(IList<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
