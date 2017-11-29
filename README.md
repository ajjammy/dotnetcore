# .NET Core 1.x
## วิธีสร้าง dotnet-core-1x project
1. สร้างจาก template ของ Visual Studio Project โดยใช้ [Yeoman](https://docs.asp.net/en/latest/client-side/yeoman.html)
2. สร้างโดยใช้คำสั่ง `$yo aspnet` > เลือก Empty Web Application > ตั้งชื่อ dotnet-core-1x
3. เข้าไปใน folder `$cd dotnet-core-1x`
4. พิมพ์คำสั่ง `$dotnet restore` เพื่อจัดการ dependencies ใน project
5. พิมพ์คำสั่ง `$dotnet run` สั่งรัน application
6. เรียกใช้งานผ่าน url http://localhost:5000 เพื่อดูผลลัพธ์จะแสดงคำว่า Hello World!

## Project Structure: dotnet-core-1x
  - ### dotnet-core-1x
    - .gitignore
    - Program.cs
    - README.md
    - Startup.cs
    - dotnet-core-1x.csproj
    - global.json
    - runtimeconfig.template.json
    - web.config



# .NET Core 2.x
## วิธีสร้าง dotnet-core-2x project
 `$dotnet --version` ตรวจสอบ version ของ .NET Core
1. สร้างโดยใช้คำสั่ง `$dotnet new web -n dotnet-core-2x`
2. พิมพ์คำสั่ง `$dotnet run` สั่งรัน application 
3. เรียกใช้งานผ่าน url http://localhost:5000 เพื่อดูผลลัพธ์จะแสดงคำว่า Hello World!

## Project Structure: dotnet-core-2x
  - ### dotnet-core-2
    - Program.cs
    - Startup.cs
    - dotnet-core-2x.csproj
