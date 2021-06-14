using System;
using System.Collections.Generic;
using System.Reflection;

namespace clothes_site_sample.scripts.Bases
{
    public class EntityBase
    {
        public void SetField(IDictionary<string, object> values)
        {
            var keyList = new List<string>(values.Keys);

            foreach (var key in keyList)
            {
                FieldInfo fieldInfo = GetType().GetField(key, BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo == null)
                {
                    continue;
                }

                if (fieldInfo.FieldType.IsEnum)
                {
                    fieldInfo.SetValue(this,
                        Convert.ChangeType(values[key], Enum.GetUnderlyingType(fieldInfo.FieldType)));
                    continue;
                }

                if (fieldInfo.FieldType == typeof(DateTime))
                {
                    fieldInfo.SetValue(this, DateTime.Parse(values[key].ToString() ?? string.Empty));
                    continue;
                }

                fieldInfo.SetValue(this, Convert.ChangeType(values[key], fieldInfo.FieldType));
            }
        }

        public void SetProperty(IDictionary<string, object> values)
        {
            var keyList = new List<string>(values.Keys);

            foreach (var key in keyList)
            {
                PropertyInfo propertyInfo = GetType().GetProperty(key);
                if (propertyInfo == null)
                {
                    continue;
                }

                if (propertyInfo.PropertyType.IsEnum)
                {
                    propertyInfo.SetValue(this,
                        Convert.ChangeType(values[key], Enum.GetUnderlyingType(propertyInfo.PropertyType)), null);
                    continue;
                }

                propertyInfo.SetValue(this, Convert.ChangeType(values[key], propertyInfo.PropertyType), null);
            }
        }
    }
}