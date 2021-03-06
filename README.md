"# CSharpCode" 
# CSharpCode
Repository of my code samples pairing with the text C# 8.0 and .NET Core 3.0

## Summary of chapters

### Chapter 1 - Hello, C#! Welcome, .NET
Some initial background information on C# (HelloCS) and tips on how to set up your development environment.
Main editor is going to be Visual Studio Code. 
Recommended extensions to install are:

### Chapter 2 - Speaking C#
Going into more depth in basic language features:
- numbers, 
- variables, 
- null handling, 
- formatting, 
- arrays, 
- arguments (command line)

### Chapter 3 - Controlling Flowe and Converting Types
This chapter covers controlling flow and converting types with the following topics:
- Operating on variables
- Understanding selection and iteration statements
- Casting and converting between types
- Handling excepions incl. checking for overflow

### Chapter 4 - Writing, Debugging and Testing Functions
This chapter is all about writing, debugging and testing functions. It covers the following topics:
- Writing functions
- Debugging, during development
- Logging, during runtime
- Unit testing (using xUnit.net)

It also introduces use of some of the recommended VS Code extensions - C# XML Documentation Comments, SharpPad etc

### Chapter 5 - Building Your Own Types With Object-Oriented Programming
This chapter introduces use of Object Oriented Programming (OOP) techniques in C#. It covers the following topics:
- Intrdouction to OOP concepts
- Building class libraries
- Storing data with fields
- Writing and calling methods
- Controlling access with properties and indexers

This is quite a meaty chapter

### Chapter 6 - Implementing Interfaces and Inheriting Classes
This chapter is about deriving new types from existing ones using object-oriented programming (OOP). It covers the following topics:
- Setting up a class library and console application
- Simplifying methods
- Raising and handling events
- Implementing interfaces
- Making types more reusable with generics
- Managing memory with reference and value types
- Inheriting from classes
- Casting within inheritance hierarchies
- Inheriting and extending .NET types

Once again, this chapter covers quite a lot of MS-flavoured object-oriented programming (OOP).

### Chapter 7 - Understanding and Packaging .NET Types
This chapter is about how .NET Core implements the types that are defined in the .NET Standard. This chapter covers the following topics:
- Introducing .NET Core 3.0
- Understanding .NET Core components
- Publishing your aplications for deployment
- Decompiling assemblies
- Packaging your libraries for NuGet distribution
- Porting from .NET Framework to .NET Core

### Chapter 8 - Working with Common .NET Types
This chapter is about some common .NET Standard types that are included with .NET Core. This chapter covers the following topics:
- Working with numbers
- Working with text
- Pattern matching with regular expressions
- Storing multiple objects in collections
- Working with spans, indexes and ranges
- Working with network resources
- Working with types and attributes
- Internationalizing your code

### Chapter 9 - Working with Files, Streams and Serialization
This chapter is about reading and writing to files and streams, text encoding and serialization. This chapter covers the following topics:
- Managing the file system
- Reading and writing with streams
- Encoding and decoding text
- Serializing object graphs

### Chapter 10 - Protecting Your Data and Applications
This chapter is about protecting your data from being viewed by malicious users using encryption, and from being manipulated or correupted using hashing and signing. This chapter covers the following topics:
- Understatanding the vocabulary of protection
- Encrypting and decrypting data
- Hashing data
- Signing data
- Generating random numbers
- What's new in cryptography?
- Authenticating and authorizing users

### Chapter 11 - Working with Databases Using Entity Framework Core
This chapter is about reading and writing to data stores e.g. SQL server, SQLite, Azure Cosmos DB. This chapter covers the following topics:
- Understatanding modern databases
- Setting up EF Core
- Defining EF Core models
- Querying EF Core models
- Loading patterns with EF Core
- Manipulating data with EF Core

### Chapter 12 - Querying and Manipulating Data Using LINQ
This chapter is about Language INtegrated Query (LINQ), a set of language extensions that add the ability to work with sequences of items and then filter, sort, and project them into different outputs. This chapter covers the following topics:
- Writing LINQ queries
- Working with sets using LINQ
- Using LINQ with EF Core
- Sweetening LINQ syntax with syntactic sugar
- Using multiple threads with parallel LINQ
- Creating your own LINQ extension methods
- Working with LINQ to XML

### Chapter 13 - Improving Performance and Scalability Using Multitasking
This chapter is about allowing actions to occur at he same time to improve performance, scalability and user productivity for the applications you build. This chapter covers the following topics:
- Understanding processes, threads and tasks
- Monitoring performance and resource usage
- Running tasks asynchronously
- Synchronizing access to shared resources
- Understanding async and await

### Chapter 14 - Practical Applications of C# and .NET
This chapter is about building complete cross-platform applications (websites, web services, Windows desktop and mobile apps) and how to add intelligence to them with machine learning. This chapter covers the following topics:
- Understanding app models for C# and .NET
- New features in ASP.NET Core
- Understanding SignalR
- Understanding Blazor
- Understanding additional bonus chapters
- Building an entity data model for Northwind

N.B. This chapter provides foundation class libraries to be used in succeeding chapters.

### Chapter 15 - Building Websites Using ASP.NET Core Razor Pages
This chapter is about building websites with a modern HTTP architecture on the server side using Microsoft ASP.NET Core. This chapter covers the following topics:
- Understanding web development
- Understanding ASP.NET Core
- Exploring Razor pages
- Using Entity Framework Core with ASP.NET Core
- Using Razor class libraries

N.B.  The code-along does not match the code download for this book e.g. in the book we create a NorthwindEmployees folder in PracticalApps but this is not present in the code download. Also, code from P500 onwards in the book does not build or run NorthwindWeb but NorthwindWeb from the code download does build and run.

### Chapter 16 - Building Websites the Model-View-Controller Pattern
This chapter is about building websites with a modern HTTP architecture on the server side using Microsoft ASP.NET Core MVC, including the startup configuration, authentication, authorization, routes, models, views and controllers. This chapter covers the following topics:
- Setting up an ASP.NET Core MVC website
- Exploring an ASP.NET Core MVC website
- Customizing an ASP.NET Core MVC website
- Using other project templates

### Chapter 17 - Building Websites Using a Content Management System
This chapter is about building websites using a modern cross-platform Content Management System (CMS) - in this chapter we use Piranha CMS as it was the first CMS to support .NET Core. This chapter covers the following topics:
- Understanding the benefits of a CMS
- Understanding Piranha CMS
- Defining components, content types and templates
- Testing the CMS website

N.B.  Skipped majority of this chapter as dont use a CMS right now.

### Chapter 18 - Building and Consuming Web Services
This chapter is about learning ho to build web services using ASP.NET Core Web API and then consuming these services using HTTP clients of any sort. This chapter covers the following topics:
- Building web services using ASP.NET Core Web API
- Documenting and testing web services
- Consuming services using HTTP clients
- Implementing advanced features
- Understanding other communication technologies e.g. WCF 

### Chapter 19 - Building Intelligent Apps Using Machine Learning
This chapter is about embedding intelligence into your apps using machine learning algorithms. We will illusrtate this using Microsft's cross-platform ML.NET library. This chapter covers the following topics:
- Understanding machine learning
- Understanding ML.NET
- Making product recommendations







