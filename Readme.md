# Setup

> git init

> echo "**/obj/*" > ./.gitignore

> echo "**/bin/*" >> ./.gitignore

> mkdir HelloUnitTestCS

> cd HelloUnitTestCS

> touch Readme.md

> dotnet new sln

> dotnet new console -o app

> dotnet sln add app

> dotnet new classlib -o ./lib/electronic

> mv lib/electronic/class1.cs lib/electronic/resistor.cs

> dotnet sln add lib/electronic

> dotnet add app/app.csproj reference lib/electronic/electronic.csproj

> dotnet new mstest -o tests/electronicTests

> mv tests/electronicTests/UnitTest1.cs tests/electronicTests/resistorUnitTest.cs   

> dotnet sln add tests/electronicTests

> dotnet add tests/electronicTests reference lib/electronic 

> dotnet test tests/electronicTests

> dotnet run --project app

> dotnet build ...