using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Sys
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="Source"></param>
        /// <param name="KeySelector"></param>
        /// <param name="IsDescending"></param>
        public static IOrderedEnumerable<TSource> OrderByWithDirection<TSource, TKey>
        (this IEnumerable<TSource> Source,
         Func<TSource, TKey> KeySelector,
         bool IsDescending)
            {
                return IsDescending ? Source.OrderByDescending(KeySelector)
                                  : Source.OrderBy(KeySelector);
            }

        /// <summary>
        /// Returns the first element with result excluding elements with property Display is equals to false.
        /// </summary>
        /// <param name="element">Element where the driver will search through.</param>
        /// <param name="byList">List of search parameters.</param>
        /// <returns>IWebElement</returns>
        public static IWebElement FindWebElementCoalesce(this IWebElement element, params By[] byList)
        {

            var myElementReturn = element.FindWebElementsCoalesce(false, byList);
            if (myElementReturn != null && myElementReturn.Count > 0)
                return myElementReturn[0];

            return null;
        }
        /// <summary>
        /// Returns the first list of elements with result.
        /// </summary>
        /// <param name="element">Element where the driver will search through.</param>
        /// <param name="includeInvisibleElements">Include elements that is not displayed</param>
        /// <param name="byList">List of search parameters.</param>
        /// <returns>List of IWebElement</returns>
        public static IList<IWebElement> FindWebElementsCoalesce(this IWebElement element, bool includeInvisibleElements, params By[] byList)
        {
            foreach (var by in byList)
            {
                var myElementsReturn = element.FindElements(by);
                if (myElementsReturn.Count > 0)
                {
                    if (includeInvisibleElements)
                        return myElementsReturn;
                    else if (myElementsReturn.Any(row => row.Displayed))
                        return myElementsReturn.Where(row => row.Displayed).ToList();
                }
            }
            return null;
        }

        public static String RemoveCarriageReturn(this String InputString)
        {
            String sResult = "";
            sResult = InputString.Replace("\n\r", " ");
            sResult = sResult.Replace("\r\n", " ");
            sResult = sResult.Replace("\n", " ");
            sResult = sResult.Replace("\r", " ");
            return sResult;
        }

        public static String NormalizeNonBreakingSpace(this String InputString)
        {
            if (InputString.Contains("&nbsp;"))
            {
                InputString = InputString.Replace("&nbsp;", " ");
            }
            return InputString.Replace(Convert.ToChar(160), Convert.ToChar(32));
        }
    }
}
