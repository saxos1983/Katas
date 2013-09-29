using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class TupleList<T1, T2> : List<Tuple<T1, T2>> 
    {
         public void Add(T1 key, T2 value)
         {
             Add(new Tuple<T1, T2>(key, value));
         }
    }
}