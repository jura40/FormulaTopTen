        ***********MY Formula1 Top 10 Drivers*********
we will print a list of those ten drivers on the page
where the client clicks on one of the drivers will get additional information from http://ergast.com/api/f1/drivers/peterson
and use info about races constructors and comment from our database api call. All Races For Driver. All Constructors For Driver. All Coment For Driver.
 
technology vi are using is .NET entytiFreamwork WebApplication Using RazorPages

// dependency injection using in driverController and comentController
// memoryCache using in driverController
// exception   using in driverController

// async function using in formulaFrontend driverController when vi cool on API and await response using if() statement

//dataBase SqlServer using and exempel are in formulaTopTen solution in fail fotmulaDatabase.sql

                        **********SOLUTIONS DB and API in PROJECT*************
There are 2 solution in this project, databases in SQLserver and project consuming "public API" 
******formulaTopTen           backEnd       
******formulaFrontEnd         frontEnd
******databases   SQLserver   formula
******public API              http://ergast.com/api/f1/drivers/peterson 

* Drivers table will have comment driverId, name, surName,
* Comment table will have comment comentId, description, driverId,

                           **********START UP PROJECT*************
1. First go to https://github.com/alenhorozic/formulaTopTen and download beckend file. Sen on
               https://github.com/alenhorozic/formulaFrontEnd take a frontend solution.

2. Set up connection to sqlServer you need to change conection string i appsettnings.jon file.
  in formulaTopTen solution.

3. In you terminal in Package Manager Console you need to created yours database by migration.
  Take care about columns and tables.
* add-migration "give migration a name".
* update-database.

4. After migratins is done as well refresch and check if database build correctly.

5. Execute formulaTopTen solution click on F5 or green play button formulaTopTen.

6. Execute formulaFrontEnd solution click on F5 or green play button formulaFrontEnd.

7. On Your browser startning URL is localhols adress : https://localhost:4001