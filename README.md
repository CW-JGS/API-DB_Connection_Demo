# API-DB_Connection_Demo

#### Fork of API-DB_Connection_Demo using dotnet 6, with other optimizations

---

## issues

in the beginning I had a few gripes about the implementation of DB-API Connection.
A few of the issues I found were:

- Not storing the database credentials in an enviroment variable, even for the purpose of a demo you should still be storing them in there because it is a best practice because it stops dodgey blokes from using your database / DBMS as their own.
- Having all classes in a single file named classes, with only three classes it is somewhat not an issue but as the project scales up you will need to separate these into different files like models, middleware, repository, services, etc.
- in your controller you are recreating your database handler every time you get a request on the route, this would incur a performance overhead.
- in your controller you defined a variable called 'testdata', this is declared in the controller and is not used at all, wasting memory, I assume it was made as to show hard coding in the data

---

## Conclusion

Thank you for the demo, I took the chance to refactor it as a learning exercise, and it has taught me a lot about api's using the dotnet framework.
