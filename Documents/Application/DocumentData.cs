using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Reflection;

namespace Documents.Application
{
    public static class DocumentData 
    {
        public static void GetDocs()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    var members = type.GetMembers();
                    foreach (var member in members)
                    {
                        var attributes = member.GetCustomAttributes(typeof(DocumentAttribute), false);
                        if (attributes.Length > 0)
                        {
                            Console.WriteLine($"Class:{type.Name}");
                            Console.WriteLine($"\tMember: { member.MemberType}");
                            Console.WriteLine($"\tName: {member.Name}");
                            Console.WriteLine($"\tDescription: {((DocumentAttribute)attributes[0])._Description}");
                            Console.WriteLine($"\tInput: {((DocumentAttribute)attributes[0])._Input}");
                            Console.WriteLine($"\tOutput: {((DocumentAttribute)attributes[0])._Output}");
                            Console.WriteLine();
                        }

                    }
                }
            }

                foreach (Foods value in Enum.GetValues(typeof(Foods)))
                {
                    var memberInfo = typeof(Foods).GetMember(value.ToString());
                    var attributes = memberInfo[0].GetCustomAttributes(typeof(EnumDescription), false);
                    var description = ((EnumDescription)attributes[0]).Description;
                    Console.WriteLine($"{value} : {description}");
                }
        }

        public static void GetDocss()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Class: " + type.Name);

                var props = type.GetProperties();
                foreach (var property in props)
                {
                    Console.WriteLine("\tProperties: " + property.Name);
                }

                var meths = type.GetMethods();
                foreach (var mymeths in meths)
                {
                    Console.WriteLine("\t\tMethods: " + mymeths.Name);
                }

                var fields = type.GetFields();
                foreach (var myFields in fields)
                {
                    Console.WriteLine("\tFields: " + myFields.Name);

                }


            }


        }

    }


}
