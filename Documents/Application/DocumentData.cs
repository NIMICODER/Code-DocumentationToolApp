using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DocumentsDataInfo.Interface;
using System.Reflection;

namespace Documents.Application
{
    public class DocumentData : IDocumentData
    {
        public void GetDocs()
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
                            Console.WriteLine($"Member Type: { member.MemberType}");
                            Console.WriteLine($"Name: {member.Name}");
                            Console.WriteLine($"Description: {((DocumentAttribute)attributes[0])._Description}");
                            Console.WriteLine($"Input: {((DocumentAttribute)attributes[0])._Input}");
                            Console.WriteLine($"Output: {((DocumentAttribute)attributes[0])._Output}");
                            Console.WriteLine();
                        }

                    }
                }
            }
        }

        public void GetDocss()
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Type: " + type.Name);

                var props = type.GetProperties();
                foreach (var property in props)
                {
                    Console.WriteLine("\tProperties: " + property.Name);
                }

                var meths = type.GetMethods();
                foreach (var mymeths in meths)
                {
                    Console.WriteLine("\tMethods: " + mymeths.Name);
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
