using System;
using System.Collections.Generic;
using System.Reflection;

namespace BaseServices.Util
{
    public static class CodePageReflection<T>
    {
        private enum CodePage
        {
            TO_TADBIR = 1,
            FROM_TADBIR = 2,
        }

        public static T toTadbir(ICodepageConvertor codepageConvertor, T obj)
        {
            return ConvertCodePage(obj, codepageConvertor, CodePage.TO_TADBIR); ;
        }

        public static IEnumerable<T> toTadbir(ICodepageConvertor codepageConvertor, IEnumerable<T> list)
        {
            List<T> _list = new List<T>();
            foreach (var obj in list)
            {
                _list.Add(ConvertCodePage(obj, codepageConvertor, CodePage.TO_TADBIR));
            }

            return _list;
        }

        public static T fromTadbir(ICodepageConvertor codepageConvertor, T obj)
        {
            return ConvertCodePage(obj, codepageConvertor, CodePage.FROM_TADBIR);
        }

        public static List<T> fromTadbir(ICodepageConvertor codepageConvertor, IEnumerable<T> list)
        {
            List<T> _list = new List<T>();
            foreach (var obj in list)
            {
                _list.Add(ConvertCodePage(obj, codepageConvertor, CodePage.FROM_TADBIR));
            }

            return _list;
        }

        private static T ConvertCodePage(T obj, ICodepageConvertor codepageConvertor, CodePage codePage)
        {
            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var field in propertyInfos)
            {
                if (field.PropertyType == typeof(string))
                {
                    var value = (string)field.GetValue(obj);
                    bool needsToConvert = field.GetCustomAttribute<CodePageAttribute>().NeedsToConvert;

                    if (needsToConvert && value != null)
                    {
                        field.SetValue(obj, codePage == CodePage.TO_TADBIR ? codepageConvertor.toTadbir(value) : codepageConvertor.fromTadbir(value));
                    }
                }
            }
            
            return obj;
        }
    }
}
