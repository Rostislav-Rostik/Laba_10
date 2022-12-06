namespace Task1
{
    using System;
    using System.Reflection;

    public class Program
    {
        public static void Main()
        {
            Type myType = typeof(HarvestingFields);

            while (true)
            {
                string text = Console.ReadLine();
                if (text == "HARVEST")
                {
                    break;
                }
                else if (text == "public")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";
                        if (field.IsPublic)
                        {
                            modificator += "public ";
                            Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                        }
                    }
                }
                else if (text == "private")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";
                        if (field.IsPrivate)
                        {
                            modificator += "private ";
                            Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                        }
                    }
                }
                else if (text == "protected")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";
                        if (field.IsFamily)
                        {
                            modificator += "protected ";
                            Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                        }
                    }
                }
                else if (text == "all")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";

                        if (field.IsPublic)
                            modificator += "public ";
                        else if (field.IsPrivate)
                            modificator += "private ";
                        else if (field.IsAssembly)
                            modificator += "internal ";
                        else if (field.IsFamily)
                            modificator += "protected ";
                        else if (field.IsFamilyAndAssembly)
                            modificator += "private protected ";
                        else if (field.IsFamilyOrAssembly)
                            modificator += "protected internal ";
                        Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                    }

                }
            }
        }
    }
}
