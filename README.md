### คำสั่ง `$dotnet --version` ตรวจสอบ version ของ .NET Core


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
1. สร้างโดยใช้คำสั่ง `$dotnet new web -n dotnet-core-2x`
2. เข้าไปใน folder `$cd dotnet-core-2x`
3. พิมพ์คำสั่ง `$dotnet run` สั่งรัน application 
4. เรียกใช้งานผ่าน url http://localhost:5000 เพื่อดูผลลัพธ์จะแสดงคำว่า Hello World!

## Project Structure: dotnet-core-2x
  - ### dotnet-core-2
    - Program.cs
    - Startup.cs
    - dotnet-core-2x.csproj

# Test Project
## วิธีสร้าง fizzBuzzTest project
1. สร้างโดยใช้คำสั่ง `$dotnet new xunit -n fizzBuzzTest`
2. เข้าไปใน folder `$cd fizzBuzzTest`
3. พิมพ์คำสั่ง `$dotnet test` สั่งรัน การทดสอบ 
4. จะแสดงผลลัพธ์การทดสอบ

# สร้าง Solution
1. สร้าง folder solution ด้วยคำสั่ง `$mkdir solution`
2. เข้าไปใน folder `$cd solution`
3. สร้าง folder src ด้วยคำสั่ง `$mkdir src`
4. สร้าง folder test ด้วยคำสั่ง `$mkdir test`
5. ย้าย dotnet-core-2x ไปยัง src ด้วยคำสั่ง `$mv ../dotnet-core-2x src`
6. ย้าย fizzBuzzTest ไปยัง test ด้วยคำสั่ง `$mv ../fizzBuzzTest test`
7. สร้าง solution file  ด้วยคำสั่ง `$dotnet new sln`
8. Add dotnet-core-2x เข้าไปยัง solution 

   ด้วยคำสั่ง `$dotnet sln add src/dotnet-core-2x/dotnet-core-2x.csproj`
9. Add fizzBuzzTest เข้าไปยัง solution 
   ด้วยคำสั่ง `$dotnet sln add test/fizzBuzzTest/fizzBuzzTest.csproj`

# สร้าง Test file และ Add reference project
1. สร้างไฟล์ FizzBuzzTest.cs ใน fizzBuzzTest project 
2. สร้างไฟล์ FizzBuzz.cs ใน dotnet-core-2x project 
3. Add reference project 
   ด้วยคำสั่ง `dotnet add reference ../dotnet-core-2x/dotnet-core-2x.csproj`





