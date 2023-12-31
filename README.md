
# _Best Restaurants_

#### By _**Ian Bravo**, **Seth Gonzales**, **Jon Cheng**_

#### _This web application will..._

<!-- ## GitHub Page ##

https://ian-bravo.github.io/PierresBakery/ -->


## Technologies Used

* _C# 10.0_
* _HtmL_
* _.Net 6.0_
* _ASP.NET Core MVC 6.0_
* _Entity Framework Core_
* _MySQL Community Server_
* _MySQL Workbench_


## Description

This C# web application will...

## Setup/Installation Requirements

Installing/Configuring MySQL and MySQL Workbench:

1. Follow the instructions on this <a href="https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql">page</a> for installing and configuring MySQL and MySQL Workbench

Cloning the Repo:
1. Open Terminal.
2. Change your directory to where you would want the cloned directory.
3. Input the following command into your terminal:  
 `$ git clone https://github.com/ian-bravo/BestRestaurants.Solution.git`
4. Using the terminal, navigate to the production directory: "Restaurants" and create a new file called appsettings.json
5. Within appsettings.json, put in the following code, replacing the uid and pwd values with your own username and password for MySQL. 
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

Setup/Import the Database:
1. Within MySQL Workbench's Navigator > Administration window, select Data Import/Restore.
2. In Import Options select Import from Self-Contained File.
3. Navigate to `ian_bravo.sql` file within the cloned BestRestaurants.Solution repo. 
4. Under Default Schema to be Imported To, select the New button.
5. Enter "best_restaurants" and click OK.
6. Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.

Running the program:
1. Navigate to the project's production directory "Restaurants" using the terminal.
2. Within the command line, run the command `dotnet watch run` to compile and execute the console application in developer mode.


## Known Bugs

* _No known bugs_


## License

MIT License  

Copyright (c) 29-Sep-2023 Ian Bravo  

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:  

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.  

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



_For questions or concerns, please email me at bravo.ian@gmail.com_

<p align="center"> <img src="schema.png" alt="schema"> </p>
