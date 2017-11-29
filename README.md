# .NET Core command-line interface (CLI) tools
+ `$dotnet --version` ตรวจสอบ version ของ .NET Core
+ [คำสั่งอื่นๆ](https://github.com/ajjammy/dotnetcore/wiki/NET-Core-command-line-interface-(CLI)-tools)



# .NET Core 1.x
# yoweb-core1
+ สร้างจาก template ของ Visual Studio Project โดยใช้ [Yeoman](https://docs.asp.net/en/latest/client-side/yeoman.html)
+ สร้างโดยใช้คำสั่ง `$yo aspnet` > เลือก Empty Web Application > ตั้งชื่อ yoweb-core1
+ เข้าไปใน folder `$cd yoweb-core1`
+ พิมพ์คำสั่ง `$dotnet restore` เพื่อจัดการ dependencies ใน project
+ พิมพ์คำสั่ง `$dotnet run` สั่งรัน application
+ เรียกใช้งานผ่าน url http://localhost:5000 เพื่อดูผลลัพธ์จะแสดงคำว่า Hello World!

## Project Structure of yoweb-core1
  - ### yoweb-core1
    - .gitignore
    - Program.cs
    - README.md
    - Startup.cs
    - global.json
    - runtimeconfig.template.json
    - web.config
    - yoweb-core1.csproj



# .NET Core 2.x
# dotnet-new-core2
+ `$dotnet --version` ตรวจสอบ version ของ .NET Core
+ สร้างโดยใช้คำสั่ง `$dotnet new web`
+ พิมพ์คำสั่ง `$dotnet run` สั่งรัน application 
+ เรียกใช้งานผ่าน url http://localhost:5000 เพื่อดูผลลัพธ์จะแสดงคำว่า Hello World!

## Project Structure of dotnet-new-core2
  - ### dotnet-new-core2
    - Program.cs
    - Startup.cs
    - dotnet-new-core2.csproj
