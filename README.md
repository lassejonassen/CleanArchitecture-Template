# Clean Architecture template
This repository can be used as a template when building a .NET Core Web API using the Clean Architecture.

The Domain and Application layer are feature based which means that all entities and value objects are located in a single namespace, instead of placing entities and valueobjects in separete namespaces. The feature based structure is also used in the WebApi, which uses Minimal API's.

The Persistence feature has been located into its own project called Persistence, to seperate it from the Infrastructure. I believe this is the better practice, and provide a cleaner solution. The Persistence project is has an extension called Persistence.DbUp. This project can be turned into a Docker image. Running this Docker Image before performing any actions on a attached database, would ensure that all the migrations from the Persistence project is applied to the database.

I will continue to add more features and new things to the template as time goes on. If some of the features built into the template doesn't fit your use-case, they can simply be deleted.
