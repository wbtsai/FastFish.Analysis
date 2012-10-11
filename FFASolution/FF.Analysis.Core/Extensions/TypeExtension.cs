using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF.Analysis.Core.Extensions
{
    public static class TypeExtension
    {
        public static Expected GetAttributeValue<T, Expected>(this Enum enumeration, Func<T, Expected> expression)
        where T : Attribute
        {
            T attribute = enumeration.GetType().GetMember(enumeration.ToString())[0].GetCustomAttributes(typeof(T), false).Cast<T>().SingleOrDefault();

            if (attribute == null)
                return default(Expected);

            return expression(attribute);
        } 

    }
}
