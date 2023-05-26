# C# WebAPI MVC with a Postgres Database.


1. Fork this repository
2. Clone your fork to your machine
3. Open the ef.intro.sln in Visual Studio
5. Note:  There are no controllers in this project!!  A current way of writing endpoints is in the EndPoint directory.
		  See How the AuthorApi.cs & BookApi.cs both are extension methods of the WebApplication class which 
		  is returned in the Program.cs from a builder.Build() call.  This way we can call this to initialize from the 
		  extension method.  See also how the data is populated via the Seed() method call.  Note how we are 
		  randomly generating names of both authors & books!

## Key Outcomes   

further knowledge of Entity Framework
understand how to use a cloud db like ElephantSql
connect to database in a secure way


## Exercise   

Add the LibraryRepository.cs from the previous exercise.   
Setup a free account on https://www.elephantsql.com/  and connect your DataContext to this.  
Don't forget to use a secure method of storing your connection string AND ENSURE THIS DOESN'T GET POSTED TO GITHUB!
We will discuss how to to this as a group.


##  Extension

If you completed the extension in the previous exercise you can add to this repo if you wish.




