﻿using System;
using System.Reflection;
using System.Linq;   // To use OrderByDescending
using static System.Console;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Assembly metadata:");
            var assembly = Assembly.GetEntryAssembly();
            WriteLine($"  Fullname: {assembly.FullName}");
            WriteLine($"  Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();
            WriteLine($"  Attributes:");
            foreach(Attribute a in attributes)
            {
                WriteLine($"    {a.GetType() }");
            }
            // Ask for attributes explicitly
            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            WriteLine($"  Version: {version.InformationalVersion}");
            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            WriteLine($"  Company: {company.Company}");

            WriteLine();
            WriteLine($"* Types:");
            Type[] types = assembly.GetTypes();
            foreach(Type type in types)
            {
                WriteLine();
                WriteLine($"Type: {type.FullName}");
                MemberInfo[] members = type.GetMembers();
                foreach(MemberInfo member in members)
                {
                    WriteLine("{0}: {1} ({2})",
                    arg0: member.MemberType,
                    arg1: member.Name,
                    arg2: member.DeclaringType.Name);

                    var coders = member.GetCustomAttributes<CoderAttribute>().OrderByDescending(c => c.LastModified);

                    foreach(CoderAttribute coder in coders)
                    {
                        WriteLine("-> Modified by {0} on {1}",
                        coder.Coder,
                        coder.LastModified.ToShortDateString());
                    }
                }
            }

        }
        [Coder("Mark Price", "22 August 2019")]
        [Coder("Johnni Rasmussen", "13 September 2019")]
        public static void DoStuff()
        {
            
        }

    }
}
