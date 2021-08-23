using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace CCAppTokenApi.Extensions
{
    public static class RequestExtension
    {
        public static Dictionary<string, string> ToDictionary<T>(this T requestSource) where T : class
        {
            var targetDic  = new Dictionary<string, string>();
            var properties = requestSource.GetType().GetProperties();
            if (properties?.Length > 0)
            {
                foreach (var propertyInfo in properties)
                {
                    if (propertyInfo.GetCustomAttribute(typeof(DescriptionAttribute)) is DescriptionAttribute description)
                    {
                        targetDic.Add(description.Description, propertyInfo.GetValue(requestSource)?.ToString());
                    }
                }
            }

            return targetDic;
        }
    }
}
