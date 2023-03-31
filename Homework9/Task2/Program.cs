using System.Reflection;

var dz8 = Assembly.Load(File.ReadAllBytes("dz8.dll"));

var types = dz8.GetTypes();
Console.WriteLine(string.Join(' ', types.Select(x => x.Name)));

var dz8Type = dz8.GetType("dz8_namespace.Class_dz8", false, true);
Console.WriteLine($"Methods: {dz8Type.GetMethods(BindingFlags.Public).Select(x => x.Name)}");

var instance = Activator.CreateInstance(dz8Type);
Console.WriteLine($"Email: {dz8Type.GetProperty("Email").GetValue(instance, null)}");