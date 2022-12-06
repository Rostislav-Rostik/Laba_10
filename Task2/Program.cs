namespace Task2
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type myType = typeof(BlackBoxInteger);
            BlackBoxInteger text = new BlackBoxInteger();
            while (true)
            {
                string[] temp = Console.ReadLine().Split("_");
                if (temp[0] == "END" || temp[0] == "End")
                {
                    break;
                }
                else
                {
                    foreach (MethodInfo method in myType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        if (method.Name == temp[0])
                        {
                            var numb = typeof(BlackBoxInteger).GetMethod(temp[0], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                            numb?.Invoke(text, parameters: new object[] {int.Parse(temp[1])});
                        }
                    }
                    var name = myType.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
                    var value = name?.GetValue(text);
                    Console.WriteLine(value);
                }
            }
        }
    }
}
