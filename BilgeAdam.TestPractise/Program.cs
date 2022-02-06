using BilgeAdam.TestPractise;
using System.Text;

//var sb = new StringBuilder();

//var name  = typeof(Product).Name;   
//var fullName = typeof(Product).FullName; 
//var interfaces = typeof(Product).GetInterfaces();
//var baseClass = typeof(Product).BaseType;

//sb.Append(name);
//sb.Append(fullName);
//sb.Append(baseClass);

//foreach (var item in interfaces)
//{
//    sb.Append(item);
//}

//Console.WriteLine(sb);

var helper = new TypeLogger();
var bs = TypeLogger.GetProperties<Product>();

Console.WriteLine(bs);
