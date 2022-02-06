using System.Text;

namespace BilgeAdam.TestPractise
{
    public class TypeLogger
    {
        public static string GetProperties<T>()
        {
            var sb = new StringBuilder();

            Type type = typeof(T);
            var name = type.Name;
            var fullName = type.FullName;


            if (type == typeof(Enum))
            {
                sb.Append(type.ToString());
            }

            if (!(string.IsNullOrEmpty(type.BaseType.ToString())))
            {
                var baseClass = type.BaseType;
                sb.Append(baseClass.ToString());
            }

            var interfaces = type.GetInterfaces();
            if (interfaces.Length > 0)
            {
                foreach (var item in interfaces)
                {
                    sb.Append(item.ToString());
                }
            }

                return sb.ToString();
        }
    }
}
