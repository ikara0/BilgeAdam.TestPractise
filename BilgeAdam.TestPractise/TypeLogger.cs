using System.Text;

namespace BilgeAdam.TestPractise
{
    public class TypeLogger
    {
        public string GetTypeProperties<T>()
        {
            var sb = new StringBuilder();

            Type type = typeof(T);
            sb.Append(type.FullName + ",");
            sb.Append(type.Name + ",");

            if (type.IsClass) sb.Append("Class,");
            if (type.IsEnum) sb.Append("Enum,");
            if (type.IsInterface) sb.Append("Interface,");
            if (type.IsAbstract) sb.Append("Abstract,");
            if (type.IsPrimitive) sb.Append("Primitive,");
            if (type.IsValueType) sb.Append("ValueType,");
            var interfaces = type.GetInterfaces();
            if (interfaces.Any())
            {
                foreach (var item in interfaces)
                {
                    sb.Append(item.Name + ",");
                }
            }


            return sb.ToString();
        }
    }
}
