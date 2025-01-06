using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus_HW5_Delegates
{
    public static class ExtensionHolder
    {
        /// <summary>
        /// Возвращает максимальный элемент коллекции
        /// </summary>
        /// <param name="convertToNumber">Метод преобразующий входной тип в число для возможности поиска максимального значения</param>
        /// <returns>Максимальный элемент коллекции</returns>
        public static T? GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            T? maxElement = null;
            float maxElementAsValue = float.MinValue;

            foreach (var item in collection)
            {
             var itemAsValue =  convertToNumber(item);
                
                if (itemAsValue > maxElementAsValue)
                {
                    maxElementAsValue = itemAsValue;
                    maxElement = item;
                }
            }
            return maxElement;
        }
    }
}
