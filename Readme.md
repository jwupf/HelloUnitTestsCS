# Setup

> mkdir HelloUnitTestCS

> cd HelloUnitTestCS

> touch Readme.md

> mkdir app

> cd app

> dotnet new console

> cd ..

> dotnet new sln

> dotnet sln add app

> mkdir lib

> mkdir lib/electronic

> dotnet new classlib -o ./lib/electronic

> dotnet sln add lib/electronic

> mv lib/electronic/class1.cs lib/electronic/resistor.cs

> git init

> echo "**/obj/*" > ./.gitignore

> echo "**/bin/*" >> ./.gitignore