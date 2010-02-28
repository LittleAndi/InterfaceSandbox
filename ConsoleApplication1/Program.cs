using System;
using System.Reflection;

namespace InterfaceSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ladda dll-fil
            // Observera att en exakt sökväg krävs till dll-filen
            Assembly a;
            try
            {
                a = Assembly.LoadFile(@"C:\Projekt\Sandbox\Visual Studio 10\Projects\Interface\InterfaceSandbox\ModLibStd\bin\Debug\ModLibStd.dll");
                //a = Assembly.LoadFile(@"C:\Projekt\SandBox\Visual Studio 10\Projects\Interface\InterfaceSandbox\ModLibCust\bin\Debug\ModLibCust.dll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            // Sök och hämta den typ vi är intresserade av
            Type type = a.GetType("InterfaceSandbox.ModLibCalc", false, true);

            if (type != null)
            {
                Console.WriteLine("Typ: {0}", type.FullName);

                // Kontrollera så att det är en klass
                if (type.IsClass)
                {
                    // Allt ok, uppdatera medlemmar och exekvera metod för beräkning
                    ICalculations instance = (ICalculations)Activator.CreateInstance(type, false);
                    instance.Length = 2;
                    instance.Width = 3;
                    Console.WriteLine(instance.CalculateArea().ToString());
                }
            }
        }
    }
}
