# C#

## 🤔 C# là gì?

C# là một ngôn ngữ lập trình hướng đối tượng rất tường minh, rõ ràng. C# được dùng để phát triển nhiều loại ứng dụng (Ứng dụng Windows, Linux, macOS, Web ...)
có hiệu năng cao và bảo mật thi hành trên nền tảng .NET

C# được thiết kế cho **Common Language Infrastructure (CLI)**, mà gồm **Executable Code** và **Runtime Environment**, cho phép chúng ta sử dụng các ngôn ngữ high-level đa
dạng trên các nền tảng và cấu trúc máy tính khác nhau.

Cấu trúc C# khá gần với các ngôn ngữ high-level truyền thống, C và C++, và là một ngôn ngữ lập trình hướng đối tượng. Nó có sự giống nhau mạnh mẽ với Java, nó
có nhiều đặc điểm lập trình mạnh mẽ mà làm cho nó trở nên ưa thích với các lập trình viên trên toàn thế giới:

- Điều kiện Boolean
- Tự động dọn rác bởi Garbage-Collector (GC)
- Thư viện chuẩn (Standard Library)
- Assembly
- Property và sự kiện (Event)
- Delegate Quản lý sự kiện
- Dễ dàng để sử dụng Generic
- Indexer
- Biên dịch có điều kiện (Conditional Compilation)
- Đa luồng dễ dàng (Multithreading)
- LINQ và Lambda Expression
- Tích hợp với Windows

---

## 🤔 .NET là gì?

 - .Net Framework là một nền tảng mang tính cách mạng giúp bạn viết các kiểu ứng dụng:

    - Windows application
    - Web application
    - Dịch vụ Web

 - Các ứng dụng .Net Framework là các ứng dụng đa nền tảng.

 - .Net Framework gồm một thư viện code khổng lồ được sử dụng bởi các ngôn ngữ client

 - Một số thành phần của .Net Framework:

    - Common Language Runtime (CLR)
    - .Net Framework Class Library
    - Common Language Specification
    - Common Type System
    - Metadata và Assembly
    - Windows Form
    - ASP.Net và ASP.Net AJAX
    - ADO.Net
    - Windows Workflow Foundation (WF)
    - Windows Presentation Foundation
    - Windows Communication Foundation (WCF)
    - LINQ

**_đọc thêm file DOTNET.txt_**

---

## Những điều cần lưu ý

C# là phân biệt kiểu chữ (case sensitive).

Tất cả lệnh và biểu thức phải kết thúc với một dấu chấm phảy (;).

Sự thực thi chương trình bắt đầu tại phương thức Main.

Không giống Java, tên file chương trình có thể khác tên lớp.

---

## Assembly

Trong C#, một assembly là một đơn vị logic của ứng dụng .NET và là khối xây dựng cơ bản của ứng dụng .NET

Assembly bao gồm các tệp thực thi (EXE) hoặc thư viện (DLL) và chứa mã, tài nguyên, và metadata cần thiết để chạy chương trình

Có 2 loại

- Executable Assembly (EXE): Đây là các tệp thực thi được sử dụng để chạy các ứng dụng độc lập.

- Library Assembly (DLL): Đây là các thư viện chứa mã dùng chung mà các ứng dụng khác có thể tham chiếu và sử dụng.

Thành phần + Metadata: Metadata cung cấp thông tin về các kiểu dữ liệu, thành viên, tham số, và các thông tin khác trong assembly. Metadata cho phép kiểm tra kiểu thời gian chạy,
ánh xạ, và nhiều tính năng khác.

    + Intermediate Language (IL): IL là mã trung gian mà mã nguồn C# được biên dịch thành. Khi chương trình được thực thi, IL được biên dịch thành mã máy cụ thể của nền tảng.

    + Manifest: Manifest là một phần của metadata chứa thông tin về assembly, như tên, phiên bản, văn hóa (culture), và danh sách các tệp khác (nếu có).

    + Resources: Các tài nguyên như hình ảnh, chuỗi văn bản, và các tệp khác có thể được đóng gói trong assembly

Tác dụng + Isolation and Versioning: Assembly giúp cô lập mã và tài nguyên, giúp quản lý phiên bản dễ dàng hơn.

    + Deployment: Assembly giúp đơn giản hóa quá trình triển khai bằng cách đóng gói tất cả các thành phần của ứng dụng vào một đơn vị duy nhất.

    + Security: Assembly có thể được ký số để đảm bảo tính toàn vẹn và tính xác thực của mã.

    + Reusability: Các thư viện trong dạng assembly (DLL) có thể được tái sử dụng bởi các ứng dụng khác, giúp giảm thiểu việc viết lại mã.

Ví dụ + Giả sử chúng ta có một thư viện toán học được biên dịch thành một assembly (MathLibrary.dll)

```C#
// File: MathLibrary.cs
namespace MathLibrary
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        internal int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
```

    + Assembly này có thể được sử dụng trong một ứng dụng khác
        // File: Program.cs
        using MathLibrary;

        class Program
        {
            static void Main()
            {
                Calculator calc = new Calculator();
                int sum = calc.Add(3, 4);
                Console.WriteLine("Sum: " + sum);

                // The following line would cause a compile error because Subtract is internal
                // int difference = calc.Subtract(10, 5);
            }
        }

    + phương thức Add của lớp Calculator có thể được truy cập từ bất kỳ ứng dụng nào tham chiếu đến MathLibrary.dll

    + phương thức Subtract chỉ có thể được truy cập từ bên trong cùng một assembly (MathLibrary.dll) do nó được khai báo là internal

    // phạm vi truy cập internal sẽ được nhắc đến sau

!!! Phân biệt assembly, namespace, file .cs + Một assembly không tương ứng trực tiếp với một namespace hay một file .cs duy nhất. + Một assembly có thể chứa nhiều namespaces và nhiều file .cs, và mỗi namespace cũng có thể trải dài qua nhiều file .cs và nhiều assembly. + Assembly là một đơn vị triển khai, trong khi namespace là một cách tổ chức mã nguồn logic.

## File .csproj (file cấu hình dự án)

    - Tệp .csproj của một dự án C# sử dụng định dạng XML để định nghĩa cấu trúc và thiết lập của dự án

    - Ví dụ
        <Project Sdk="Microsoft.NET.Sdk">

            <!-- 1. PropertyGroup: Cấu hình chung -->
            <PropertyGroup>
                <OutputType>Exe</OutputType>
                <TargetFramework>net7.0</TargetFramework>
                <RuntimeIdentifier>win-x64</RuntimeIdentifier>
                <RuntimeIdentifiers>win-x64;linux-x64</RuntimeIdentifiers>
                <AssemblyTitle>MyApplication</AssemblyTitle>
                <AssemblyVersion>1.0.0.0</AssemblyVersion>
                <MyCustomProperty>MyValue</MyCustomProperty>
            </PropertyGroup>

            <!-- 2. PropertyGroup: Cấu hình riêng cho chế độ Debug -->
            <PropertyGroup Condition="'$(Configuration)' == 'Debug'">
                <DefineConstants>DEBUG;TRACE</DefineConstants>
                <OutputPath>bin\Debug\</OutputPath>
            </PropertyGroup>

            <!-- 3. PropertyGroup: Cấu hình riêng cho chế độ Release -->
            <PropertyGroup Condition="'$(Configuration)' == 'Release'">
                <DefineConstants>RELEASE</DefineConstants>
                <Optimize>true</Optimize>
                <OutputPath>bin\Release\</OutputPath>
            </PropertyGroup>

            <!-- 4. ItemGroup: Tham chiếu đến các gói NuGet -->
            <ItemGroup>
                <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
            </ItemGroup>

            <!-- 5. ItemGroup: Tham chiếu đến dự án khác trong giải pháp -->
            <ItemGroup>
                <ProjectReference Include="..\OtherProject\OtherProject.csproj" />
            </ItemGroup>

            <!-- 6. ItemGroup: Tham chiếu đến thư viện DLL cụ thể -->
            <ItemGroup>
                <Reference Include="System.Data">
                <HintPath>..\libs\System.Data.dll</HintPath>
                </Reference>
            </ItemGroup>

            <!-- 7. ItemGroup: Bao gồm tài nguyên -->
            <ItemGroup>
                <EmbeddedResource Include="Resources\Strings.resx" />
            </ItemGroup>

            <!-- 8. ItemGroup: Bao gồm các tệp nội dung -->
            <ItemGroup>
                <Content Include="index.html" CopyToOutputDirectory="PreserveNewest" />
            </ItemGroup>

            <!-- 9. ItemGroup: Bao gồm các tệp không thuộc về quá trình xây dựng -->
            <ItemGroup>
                <None Include="README.md" />
            </ItemGroup>

            <!-- 10. Target: Thực hiện tác vụ tùy chỉnh sau khi xây dựng -->
            <Target Name="CustomTask" AfterTargets="Build">
                <Exec Command="echo Building the project..." />
            </Target>

            <!-- 11. Import: Nhập tệp targets -->
            <Import Project="..\common.targets" />

            <!-- 12. ItemDefinitionGroup: Định nghĩa mặc định cho Compile -->
            <ItemDefinitionGroup>
                <Compile>
                <WarningLevel>4</WarningLevel>
                </Compile>
            </ItemDefinitionGroup>

        </Project>

    - <Project> : Đây là phần gốc của tệp, bao quanh tất cả các thành phần khác và chỉ ra SDK được sử dụng.

    - <PropertyGroup> : Nhóm này chứa các thuộc tính cấu hình của dự án.
        + <OutputType> : Xác định loại đầu ra của dự án, ví dụ như Exe cho ứng dụng console hoặc Library cho thư viện.

        + <TargetFramework> : Xác định phiên bản .NET mà dự án sẽ chạy.

        + <RootNamespace> : Xác định namespace gốc cho dự án.

        + <AssemblyName> : Tên của assembly được tạo ra.

        + <LangVersion> : Phiên bản ngôn ngữ C# được sử dụng, latest sử dụng phiên bản mới nhất.

    - <ItemGroup> : Nhóm này chứa các phần tử tham chiếu, như các gói NuGet.
        + <PackageReference> : Tham chiếu đến một gói NuGet.

        + <ProjectReference> : Tham chiếu đến một dự án C# khác trong cùng solution.

        + <Reference> : Thêm một tham chiếu đến một tệp DLL cụ thể

        + <Compile> : Bao gồm các tệp mã nguồn cần biên dịch, trong ví dụ trên là tất cả các tệp .cs trong thư mục Models.

        + <Content> : Bao gồm các tệp tĩnh (static files), ví dụ tất cả các tệp trong thư mục wwwroot.

        + <None> : Tham chiếu đến các tệp không biên dịch, nhưng có thể cần sao chép đến thư mục đầu ra (output directory), ví dụ appsettings.json.

        + <DotNetCliToolReference> : Tham chiếu đến các công cụ dòng lệnh .NET CLI

        + <FrameworkReference>: Tham chiếu đến các framework assemblies cụ thể, ví dụ Microsoft.AspNetCore.App.

        + <EmbeddedResource>: Bao gồm các tài nguyên nhúng trong assembly.

        + <AdditionalProbingPath>: Xác định các đường dẫn bổ sung để tìm kiếm các gói NuGet.

    - Có thể định nghĩa các cấu hình khác nhau (ví dụ: Debug, Release) trong tệp .csproj bằng cách sử dụng các nhóm
        <PropertyGroup Condition=" '$(Configuration)' == 'Debug' ">

        <PropertyGroup Condition=" '$(Configuration)' == 'Debug' ">
            <DefineConstants>DEBUG;TRACE</DefineConstants>
            <DebugType>full</DebugType>
            <Optimization>false</Optimization>
        </PropertyGroup>

        <PropertyGroup Condition=" '$(Configuration)' == 'Release' ">
            <DefineConstants>TRACE</DefineConstants>
            <DebugType>pdbonly</DebugType>
            <Optimization>true</Optimization>
        </PropertyGroup>

## Namespace

    - Namespace là cách tổ chức nhóm code (các lớp, giao diện, cấu trúc ...) thành những nhóm, tạo ra phạm vi hoạt động của các thành phần trong nhóm.
        namespace mynamespace {
            // Định nghĩa các lớp, cấu trúc ...
        }

    !!! Hiểu đơn giản namespace giống với 1 thư viện tự định nghĩa

    - Mục đích là tổ chức code khoa học, dễ quản lý và đặc biệt là tránh xung đột về tên. Ta có thể khai báo hai lớp tên giống nhau nhưng nằm ở hai namespace khác nhau.

    - Các thành phần được khai báo trong một namespace: namespace con, các lớp (class), các giao diện interface c#, các cấu trúc - struct C#, các liệt kê enum, các deleage C#

    - using
        + Sử dụng từ khóa using ở đầu file code, để cho biết sẽ sử dụng các lớp thuộc một namespace nào đó.
            using System;

        + Chỉ thị using cũng giúp bạn đặt tên mới (tên tắt) của namespace, tên này sử dụng trong phạm vi file code
            using XYZ = System.Text;

        + Sử dụng using chỉ thị truy cập trực tiếp các phương thức tĩnh, mà không cần viết tên lớp cú pháp nạp phương thức tĩnh của lớp
            using static System.Console;  // cho biết sử dụng trực tiếp các phương thức tĩnh
            WriteLine ("Xin chào C# NET CORE!");

    - Namespace lồng nhau, nhiều cấp
        + Các namespace cũng có thể khai báo lồng nhau, nhiều cấp sau đó dùng ký hiệu . để truy cập đến namepace mong muốn
            namespace A {
                // Định nghĩa các lớp, cấu trúc ...
                namespace B {
                    // Định nghĩa các lớp, cấu trúc ...
                }
            }
            ///
            using A.B;

        + Tạo ra namespace nhiều cấp còn có thể khai báo một cách riêng rẽ nhưng phải chỉ rõ tên đầy đủ của namespace (tên namespace gốc)
            namespace A
            {
                public struct StructInA {};
            }
            namespace A.B
            {
                public struct StructInB {};
            }
            namespace A.B.C
            {
                public struct StructInC {};
            }

## Ghi chú

    - Ghi chú trên 1 dòng sử dụng
        // ...

    - Ghi chú trên nhiều dòng sử dụng
        /* ... */

    - C# XML Document : là một loại ghi chú viết theo một cấu trúc quy định - sử nhiều dòng ghi chú 1 dòng với cấu trúc quy định, nhằm hỗ trợ phát sinh Document
    (hướng dẫn) đến các đối tượng sử dụng (hàm, lớp, tham số ...)
        /// <summary>
        /// Tính tổng hai số nguyên
        /// </summary>
        /// <param name="a">số thứ nhất</param>
        /// <param name="b">số thứ hai</param>
        /// <returns>giá trị a + b</returns>

## Top-level statement // bổ sung sau

## Biến

    - Quy tắt đặt tên:
        + Tên biến có thể chứa chữ, số và ký tự _
        + Ký tự đầu tiên của tên biến không được dùng số
        + Tên biến trong C# có phân biệt chữ hoa chữ thường
        + Không đặt tên biến trùng với những từ khóa dành riêng cho câu lệnh C#
        + Hãy đặt tên biến sao cho nó ngắn gọn nhưng gọi nhớ đến thông tin dữ liệu biến đó lưu trữ.

    - Kiểu dữ liệu C# định nghĩa sẵn
        + int : kiểu số nguyên (có dấu, dùng 32 bit biểu diễn, từ -2,147,483,648 đến 2,147,483,647)
        + sbyte : kiểu số nguyên (có dấu, dùng 8 bit biểu diễn, từ -128 đến 127)
        + byte : kiểu số nguyên (không dấu, dùng 8 bit biểu diễn, từ 0 đến 255)
        + short : kiểu số nguyên (có dấu, dùng 16 bit biểu diễn, từ -32,768 đến 32,767)
        + ushort : kiểu số nguyên (không dấu, dùng 16 bit biểu diễn, từ 0 đến 65,535)
        + long : kiểu số nguyên (có dấu, dùng 64 bit biểu diễn, từ -9,223,372,036,854,775,808 đến 9,223,372,036,854,775,807)
        + ulong : kiểu số nguyên (không dấu, dùng 64 bit biểu diễn, từ 0 đến 18,446,744,073,709,551,615)
        + float : số thực chấm động (dùng 32 bit biểu diễn phù hợp số có bảy chữ số, độ chính xác số dấu chấm động 1.5 × 10−45 đến 3.4 × 1038)
        + double : số thực chấm động (dùng 64 bit biểu diễn)
        + decimal : số thực chấm động (dùng 128 bit biểu diễn)
        + char : một ký tự (dùng 16 bit biểu diễn ký tự Unicode)
        + bool : kiểu logic (chỉ nhận giá trị false hoặc true)
        + string : chuỗi (xâu) ký tự (tập hợp các ký tự theo thứ tự - một văn bản text)
        + object : đối tượng, biểu diễn các đối tượng C#, nó là kiểu cơ sở - mọi đối tượng C# đều kế thừa từ kiểu này.

        !!! kí tự thì để trong ' ', chuỗi kí tự thì để trong " "

## Xuất dữ liệu

    - Có thể sử dụng 1 số phương thức có sẵn trong lớp Console trong namespace System
        Console.writeline(value); : in value ra màn hình (có xuống dòng)
        Console.write(value); : in value màn hình (không xuống dòng)
        onsole.ForegroundColor = [màu] : thuộc tính để gán màu chữ xuất ra, nó có thể gán các màu như ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.White ...
        Console.ResetColor(); : đặt lại màu

        !!! value có thể là số có thể là chuỗi

    - Có thể dùng format string để tạo ra chuỗi in ra nhằm giảm thiểu dòng code
        string.Format("Xin chao {0}", ten) => String
        // áp dụng
        Console.writeline("Bien A = {0}, bien B = {1}, tong A + B = {2}", a, b, a + b);

    - Dùng $ ở đầu để chèn biểu thức vào chuỗi in ra (coi thêm ở mục chuỗi ký tự)
        Console.writeline($"Bien A = {a}, bien B = {b}, tong A + B = {a + b}");

## Nhập dữ liệu

    - Có thể sử dụng 1 số phương thức có sẵn trong lớp Console trong namespace System
        + Console.ReadLine() : cho phép nhập dữ liệu cho đến khi nhấn Enter, hàm này trả về chuỗi mà người dùng nhập vào
        + Console.ReadKey() : trả về ngay thông tin phím bấm khi người dùng bấm
        + Console.ReadKey().KeyChar : lấy chữ mã người dùng bấm thì viết

    - Mặc định hàm Console.ReadLine() trả về string nếu muốn chuỗi đó nhập xong chuyển thành các kiểu dữ liệu khác như int, float ... thì cần các hàm chuyển kiểu:
        + Convert.ToInt32(value) chuyển value thành kiểu int
        + Convert.ToDouble(value) chuyển value thành kiểu double
        + Convert.ToBoolean(value) chuyển value thành kiểu bool

## Hằng số (const), Kiểu ngầm định (var)

    - Hằng số lưu trữ các giá trị mà không thay đổi được nữa, dùng từ khóa const để khai báo hằng số
        const string MON = "THỨ HAI";

    - Biến var không cần chỉ rõ ngay kiểu dữ liệu của biến mà kiểu của biến được xác định theo kiểu biểu thức gán vào biến ngay sau đó.

    !!! Biến var phải được khởi tạo ngay khi khai báo
        var a; => lỗi
        var a = 123; => không lỗi

## Toán tử

    - Toán tử số học
        | + | Phép cộng                  |
        | - | Phép trừ                   |
        | * | Phép nhân                  |
        | / | Phép chia                  |
        | % | Phép chia lấy dư (modules) |

        !!! Độ ưu tiên giống với trong toán học

    - Toán tử gán
        | =  | Toán tử gán: Gán biểu thức bên phải của = vào biến bên trái |
        | += | Toán tử công thêm: a += b tương đương a = a + b	           |
        | -= | Toán tử trừ bớt: a -= b tương đương a = a - b	           |
        | *= | Toán tử nhân với: a *= b tương đương a = a * b              |
        | /= | Toán tử chia cho: a /= b tương đương a = a / b	           |
        | %= | Toán tử gán module: a %=b tương đương a = a % b             |

    - Toán tử tăng giảm
        + Toán tử ++ thêm vào biến 1 đơn vị, còn -- bớt đi một đơn vị, toán tử này có thể viết bên trái hoặc bên phải biến.

        !!! Nếu viết trước ++x thì toán tử ++ thi hành trước rồi mới áp dụng vào biểu thức, nếu viết sau dạng x++ thì biểu thức thi hành xong mới đến ++ (tương tự với --)

    - Toán tử so sánh
        | == | So sánh bằng	             |
        | >	 | So sánh lớn hơn	         |
        | >= | So sánh lớn hơn hoặc bằng |
        | <	 | So sánh nhỏ hơn	         |
        | <= | So sánh nhỏ hơn hoặc bằng |
        | != | So sánh khác	             |

    - Toán tử logic
        | && | Phép toán VÀ - trả về true nếu cả hai số hạng đều true, còn lại trả về false	      |
        | || | Phép toán HOẶC - trả về true nếu 1 trong hai số hạng là true, còn lại trả về false |
        | !	 | Viết trước số hạng, giá trị trả về true nếu số hạng là false và ngược lại.         |


    - Toán tử điều kiện (toán tử 3 ngôi)
        (điều khiện) ? biểu thức 1 : biểu thức 2 ;
        nếu điều kiện đúng thì trả về biểu thức 1, ngược lại trả về biểu thức 2

## Cấu trúc rẻ nhánh (if else - switch case)

    - if else
        if(điểu kiện) {
            các câu lệnh
        }
        else if(điều kiện) {
            các câu lệnh
        }
        else {
            các câu lệnh
        }

        !!! điều kiện phải là giá trị boolean
        !!! nếu chỉ có 1 câu lệnh thì không cần ngoặc

    - switch case
        switch (expr)
        {
            case expr1:
                //Cách lệnh thi  hành nếu expr == expr1
            break;

            case expr2:
                //Cách lệnh thi  hành nếu expr == expr2
            break;

                // ...

            default:
                //..
            break;
        }

        !!! Sử dụng switch rõ ràng, dễ đọc hơn khi số lượng else if nhiều

## Vòng lặp (for - foreach - while - do while)

    - for
        for ( khởi_tạo; điều_kiện; cập_nhật ) {
            //Các câu lệnh trong khối
        }

        + B1 : khởi tạo biến kiểm tra
        + B2 : kiểm tra điều kiện, nếu true thì thực hiện khối lệnh, nếu false thì thoát khỏi vòng lặp
        + B3 : cập nhật lại biến kiểm tra vè quay lại B2

        + Có thể viết thiếu thành phần vẫn được
            for (; ;) {} Hoặc for (; ;);

        !!! Thiếu điều kiện có thể dẫn đến vòng lặp vô tận

    - foreach
        foreach (var e in vararry) {
            // ...
        }

        + foreach duyệt tuần tự qua các phần tử từ đầu cho đến hết
        + foreach cung cấp cách thức gọn hơn để duyệt qua các phần tử mảng

    - while
        while (điều_kiện) {
            //Lặp nếu điều_kiện bằng true
        }

        + Cách hoạt động: kiểm tra điều kiện, nếu true thì thực hiện khối lệnh, nếu false thì thoát vòng lặp
        + Biến kiểm tra được khởi tạo trước đó và cập nhật trong khối lệnh của vòng lặp

    - do while
        do
        {
            //Khối lệnh
        }
        while (điều_kiện);

        + Cách hoạt động: thực hiện khối lệnh 1 lần rồi mới bắt đầu kiểm tra như của vòng lặp while

        !!! Vòng lặp do ... while khối lệnh lặp bao giờ cũng được thực hiện ít nhất một lần.

    - break
        + Trong vòng lặp, nếu gặp break vòng lặp sẽ thoát ngay lập tức - và chuyển đến các câu lệnh sau vòng lặp.

    - continue
        + Trong vòng lặp, nếu gặp continue thì tương đương việc đến cuối khối lệnh của lần lặp đó (bắt đầu thực hiện lần lặp mới ngay).

## Mảng (Array)

    - Khai báo
        kiểu dữ liệu[] tên biến;
        int[] a;

    - Khởi tạo
        tên biến = new kiểu dữ liệu[số lượng phần tử];
        a = new int[5];

        tên biến = new kiểu dữ liệu[số lượng phần tử] {danh sách các dữ liệu};
        double[] productPrices = new double[3] {100, 200.5, 10.1};

        hoặc không cần chỉ rõ số lượng phần tử khi khởi tạo với danh sách dữ liệu
        double[] productPrices = new double[] {100, 200.5, 10.1};

        thậm chí có thể bỏ bớt chỉ cần danh sách dữ liệu là được
        double[] productPrices = {100, 200.5, 10.1};

    - Truy cập phần tử trong mảng: tên biến[chỉ số của phần tử muốn truy cập]
        a[0] hoặc a[1], ....
        chỉ số phần tử mảng bắt đầu từ 0

    - Thuộc tính và phương thức
        + Trong thư viện System.Array
            | Length	      | Thuộc tính cho biết số lượng phần tử trong mảng |
            | Rank	          | Thuộc tính cho biết số chiều mảng               |
            | Clone()	      | Copy (nhân bản) đối tượng mảng                  |
            | GetValue(index) | Lấy giá trị phần tử trong mảng                  |
            | Min()	          | Trả về giá trị nhỏ nhất trong mảng              |
            | Max()	          | Trả về giá trị lớn nhất trong mảng              |
            | Sum()	          | Trả về giá trị tổng cộng các phần tử            |

        + Trong thư viện System.Linq
            | Array.BinarySearch(array, value)	            | Tìm kiếm phần tử trong mảng đã được sắp xếp, trả về chỉ số nếu tìm thấy
            | CopyTo(array, indexStart)	                    | Sao chép phần tử mảng này sang mảng khác
            | Array.Clear(array, index, length)	            | Thiết lập phần tử mảng nhận giá trị mặc định
            | bool Exists<T> (array, Predicate<T> match);	| Kiểm tra có phần tử trong mảng thỏa mãn match
            | Fill<T> (array, value);	                    | Gán các phần tử của mảng bằng value
            | T Find<T> (array, Predicate<T> match);	    | Tìm phần tử mảng
            | int FindIndex<T> (array, Predicate<T> match);	| Tìm phần tử mảng, trả về chỉ số nếu thấy
            | T[] FindAll<T> (array, Predicate<T> match);	| Tìm tất cả phần tử mảng
            | int IndexOf(array, value)	                    | Tìm chỉ số của phần tử
            | ForEach(array, Action<T> action)	            | Thi hành action trên mỗi phần tử
            | Sort(array)	                                | Sắp xếp

    - Mảng nhiều chiều
        + khai báo
            type[, , … ,] varname = new type[size1, size2, …, sizeN];
            int[,] myvar = new int[3,4];

        + truy cập
            myvar[0,0] =  1;    // hàng 1, cột 1
            myvar[2,3] =  3;    // hàng 3, cột 4

    - Mảng trong mảng
        + khai báo dùng thêm [] để cho biết các phần tử trong mảng là những mảng khác
            int[][] myArray = new int[][] {
                                new int[] {1,2},
                                new int[] {2,5,6},
                                new int[] {2,3},
                                new int[] {2,3,4,5,5}
                               };

## Chuỗi ký tự (string)

    - Chuỗi là một tập hợp các ký tự sắp xếp có vị trí, nó chỉnh là một mảng các ký tự, kiểu dữ liệu chuỗi đó là string, lớp biểu diễn các chuỗi là System.String

    - khai báo
        string sExample = "Xin chào";       // Khai báo và khởi tạo chuỗi
        sExample += " các bạn";             // Nối chuỗi +=, trả về "Xin chào các bạn"
        sExample = sExample + "!";          // Nối chuỗi +, trả về "Xin chào các bạn!"

    - Chuỗi như là mảng mà phần tử mảng là các ký tự, nên có thể truy cập phần tử mảng bằng indexer để đọc ký tự:
        char c = sExample[1];               // c= 'i'

    - Chuỗi nguyên bản (ký hiệu @)
        + Khi viết chuỗi trong cặp dấu nháy kép "", thì các ký tự đặt biệt được xử lý với ký hiệu \
            string s = "C:\\Abc\\xyz";
            // Nếu viết string s = "C:\Abc\xyz"; sẽ lỗi

        + Nếu muốn viết chuỗi cố định, nội dung nguyên bản - cho biết sẽ không dùng \ để xử lý ký tự đặc biệt, thì thêm @ vào đầu chuỗi
            string s = @"Ký tự \ được dùng để chèn ký tự đặc biệt như \n, \r";

        + Có thể viết chuỗi trên nhiều dòng với ký hiệu @
            string s = @"Xin chào các bạn
                         Tôi đang học C#";

        !!! ngoại trừ hai ký tự "" chuyển thành một ký tự ""
            string s = "Anh ấy nói, ""Đây là C#"""; //~ Anh ấy nói "Đây là C#"

    - Chèn thêm biểu thức vào chuỗi (ký hiệu $)
        + Khi viết chuỗi có ký tự $ phía trước, thì trong chuỗi đó có thể chèn các biểu thức vào chỗ có cặp {} : {biểu-thức}
            int a = 10;
            int b = 2;
            string s = $"Kết quả {a}/{b} là {a/b}";  // "Kết quả 10/2 là 5"

        + Ngoài ra có thể căn lề, định dạng số, ngày tháng ... tương tự như chuỗi định dạng
            Console.WriteLine($"{"VòngLặp",10} {"Chẵn/Lẻ", -5}");
            for (int i = 8; i < 15; i++)
            {
                string chanle = (i%2 == 0) ? "Chẵn" : "Lẻ";
                Console.WriteLine($"{i,10} {chanle, -5}");
            }

            !!! số dương là căn lề phải, số âm là căn lề trái

    - Các phương thức cho chuỗi
        | Concat	    | Phương thức tĩnh, nối các chuỗi liệt kê ở tham số lại với nhau                                                                                                |
        | Format	    | Convert các đối tượng thành chuỗi và chèn chúng vào chuỗi định dạng được chỉ ra, cú pháp cơ bản String.Format(stringFormat, arg0, arg1 ...)                   |
        |               | Trong đó stringFormat là chuỗi định dạng, chứa mẫu và và vị trí mà arg0, arg1 ... sẽ chèn vào.                                                                |
        |               | string s = String.Format("Chào {0}, {0} ơi, hôm nay ngày {1} rồi!", "Nam", DateTime.Now.Day);                                                                 |
        | IndexOf	    | Tìm vị trí (đầu tiên) của ký tự hoặc chuỗi ký tự trong chuỗi                                                                                                  |
        | LastIndexOf	| Tìm vị trí (cuối) của ký tự hoặc chuỗi ký tự trong chuỗi                                                                                                      |
        | Insert	    | Tạo chuỗi bằng cách chèn chuỗi này vào trong chuỗi khác, vị trí chèn cần chỉ ra                                                                               |
        | PadLeft	    | Tạo chuỗi mới từ chuỗi cũ, độ dài chuỗi mới chỉ ra - nếu độ dài chuỗi mới lớn hơn chuỗi cũ thì các ký tự phía đầu được chèn khoảng trắng hoặc ký tự chỉ định. |
        | PadRight	    | Tương tự PadLeft nhưng chèn khoảng trắng bên phải                                                                                                             |
        | Replace	    | Tìm và thay thế trong chuỗi                                                                                                                                   |
        | Split	        | Trả về mảng các chuỗi con được chia từ chuỗi gốc bởi ký tự chia chỉ định, chuỗi chia chỉ định                                                                 |
        | ToLower	    | Sinh chuỗi mới bằng cách chuyển các ký tự thành chữ thường                                                                                                    |
        | ToUpper	    | Sinh chuỗi mới bằng cách chuyển các ký tự thành chữ in                                                                                                        |
        | Trim	        | Sinh chuỗi mới bằng cách loại bỏ khoảng trắng (hoặc chỉ định) ở đầu và cuối                                                                                   |
        | Substring	    | Lấy ra chuỗi con từ chuỗi chính - chuỗi con lấy từ vị trí chỉ ra đến cuối hoặc theo độ dài                                                                    |

    - StringBuilder
        + Để thi hành tối ưu hơn về tốc độ, về sử dụng bộ nhớ có thể dùng tới đối tượng StringBuilder ở namespace System.Text

        + Đối với string mỗi khi thực hiện 1 thao tác chương trình sẽ thực hiện cấp phát bộ nhớ và tạo ra 1 đối tượng mới

        + Phương thức cho StringBuilder
            | Append	    | Nối một đối tượng (chuỗi, số ...) vào StringBuilder    |
            | AppendFormat	| Nối vào một chuỗi sinh ra theo StringFormat            |
            | Insert	    | Chèn vào StringBuilder một chuỗi ở vị trí chỉ ra       |
            | Remove	    | Loại bỏ một lượng ký tự, bắt đầu từ vị trí do chỉ định |
            | Replace	    | Tìm và thay thế                                        |
            | ToString	    | Trả về chuỗi (String)                                  |

## Type casting (ép kiểu)

    - Explicit Casting (ép kiểu tường minh)
        + Được sử dụng khi bạn biết rằng kiểu bạn đang ép kiểu là tương thích. Nếu ép kiểu không thành công, một ngoại lệ sẽ được ném ra.
            double d = 123.45;
            int i = (int)d;  // i = 123

    - Implicit Casting (ép kiểu ngầm định)
        + Được sử dụng khi không có nguy cơ mất dữ liệu. Chỉ có thể sử dụng với các kiểu tương thích.
            int i = 123;
            double d = i;  // d = 123.0

    - as
        + Sử dụng để ép kiểu đối tượng sang một kiểu tham chiếu hoặc kiểu nullable. Nếu ép kiểu không thành công, biến sẽ nhận giá trị null thay vì ném ra ngoại lệ.
            object obj = "This is a string";
            string str = obj as string;

    - is
        + Kiểm tra xem đối tượng có thể được ép kiểu sang kiểu đích hay không. Từ C# 7.0 trở lên, bạn có thể ép kiểu và khai báo biến cùng lúc
            object obj = "This is a string";
            if (obj is string str) {
                Console.WriteLine("The string is: " + str);
            } else {
                Console.WriteLine("The object is not a string.");
            }

    - convert
        + Dùng các phương thức trong lớp Convert để chuyển đổi giữa các kiểu cơ bản
            string str = "123";
            int i = Convert.ToInt32(str);  // i = 123

            string strDouble = "123.45";
            double d = Convert.ToDouble(strDouble);  // d = 123.45

    - Custom Casting (ép kiểu tùy chỉnh)
        + Có thể tạo các phương thức ép kiểu tùy chỉnh trong các lớp của mình bằng cách sử dụng các toán tử implicit và explicit.
            public class Fahrenheit {
                public double Degrees { get; set; }

                public static explicit operator Celsius(Fahrenheit f) {
                    return new Celsius { Degrees = (f.Degrees - 32) * 5 / 9 };
                }
            }

            public class Celsius {
                public double Degrees { get; set; }

                public static implicit operator Fahrenheit(Celsius c) {
                    return new Fahrenheit { Degrees = (c.Degrees * 9 / 5) + 32 };
                }
            }

            // Sử dụng các phương thức ép kiểu tùy chỉnh
            Fahrenheit f = new Fahrenheit { Degrees = 98.6 };
            Celsius c = (Celsius)f;  // Explicit cast
            Fahrenheit f2 = c;       // Implicit cast

    - Parse - TryParse
        + Các phương thức Parse và TryParse được sử dụng để chuyển đổi chuỗi sang các kiểu số và kiểu khác
            string str = "123";
            int i = int.Parse(str);  // i = 123

            string strDouble = "123.45";
            if (double.TryParse(strDouble, out double d))
            {
                Console.WriteLine("The double is: " + d);  // d = 123.45
            }
            else
            {
                Console.WriteLine("The string could not be parsed.");
            }

## Phương thức (funtion)

    - Cấu trúc:
        <Access Modifiers> <return type> <name_method>(<parameters>) {
            // Các câu lệnh trong phương thức
        }

    - Access Modifiers
        + Cho biết cấp độ được phép truy cập đến hàm này
        + có các mức độ như public, private, protect, internal ...
        + Mặc định là internal nếu không chỉ rõ phạm vi

    - return type
        + kiểu trả về của hàm : int, double, string, ...
        + nếu hàm chỉ thực hiện mà không trả về 1 giá trị thì để void

    - name_method tên của phương thức do bạn đặt.

    - parameters (tham số)
        + là các tham số của hàm nếu có, các tham số khai báo theo mẫu kiểu tên như int thamso1, nhiều tham số thì cách nhau bởi dấu ,

        + có thể đặt giá trị mặc định ban đầu cho tham số bằng toán tử gán, lúc khởi tạo hàm. Lúc gọi hàm những tham số không được truyền vào thì sẽ sử dụng giá trị mặc định

        + có thể chỉ định rõ thàm số muốn truyền là gì mà không cần theo thứ tự bằng cách tên tham số: giá trị muốn truyền vào

        + loại tham số
            * tham trị là cách thức mặc định, ta đã sử dụng ở phần trên. Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ,
            còn bản thân biến bên ngoài không hề ảnh hưởng. Những kiểu dữ liệu là tham trị:
                \ Các kiểu số nguyên như int, byte, long ...
                \ Các kiểu số thực như float, double, decimal
                \ Kiểu bool, kiểu char
                \ Kiểu cấu trúc struct
                \ Kiểu liệt kê enum
                \ Kiểu Tuple

            * tham chiếu thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, nên nó có tác động trực tiếp đến biến này bên ngoài.
            Để sử dụng được tham chiếu thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref. Những kiểu dữ liệu là tham chiếu:
                \ Biến kiểu lớp (class), các lớp thư viện hoặc lớp do bạn định nghĩa
                \ Biến kiểu delegate
                \ Biến kiểu interface, các giao diện từ thư viện hoặc tự định nghĩa
                \ Biến kiểu dynamic
                \ Biến kiểu object
                \ Biến kiểu string

            !!! Tham số là các đối tượng lớp, mặc định là tham chiếu.
            !!! Khai báo ref ở tham số phương thức, bắt buộc khi gọi phải sử dụng biến làm tham số chứ không được dùng giá trị.

            * tham chiếu out, thay vì dùng ref để tạo tham chiếu ta cũng có thể dùng out. điểm khác biệt là tham chiếu out không cần khởi tạo trước (không có giá trị lúc truyền vào)
                public static void OutExample(out int x) {
                    x = 100;
                }
                public static void Main(string[] agv) {
                    int a;             // biến a chưa khởi tạo
                    OutExample(out a); // Giờ a = 100;
                }

    - Chương trình sẽ chạy đoạn code trong hàm được gọi tên từ đầu đến cuối hoặc dừng lại và thoát ra khi gặp lệnh return

    !!! khi gọi đến hàm để sử dụng cần chỉ rõ namespace.class.method, nếu sử dụng úing namespace đó thì có thể bỏ namespace, nếu nằm trong cùng class thì có thể bỏ class và chỉ cần ghi tên phương
    thức và tham số cần có

    - Khi biểu thức chỉ thực hiện 1 câu lệnh hay trả về 1 biểu thức thì có thể rút gọn bằng ký hiệu =>
        public void Print() => Console.writeline("xin chao");
        public int Tong(int a, int b) => a + b;

## Lớp (class)

    - lớp (class) là một kiểu dữ liệu tham chiếu nó định nghĩa một tập hợp các biến (trường dữ liệu, thuộc tính) và phương thức (gọi chúng là các member - thành viên lớp).
    - Từ lớp đó sinh ra các đối tượng (object), các đối tượng này còn gọi là bản triển khai của lớp (instance of a class)

    - cú pháp
        <Access Modifiers> class Class_Name {
            // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
            // khai báo các thành viên  hàm (phương thức)
        }

    - Access modifiers
        + áp dụng khai báo cho lớp:
            * public (không giới hạn truy cập)
            * internal (giới hạn truy cập trong cùng assembly - chương trình)
            * private (chỉ truy cập được từ lớp chứa nó) Nếu lớp con khai báo lồng trong một lớp khác

            !!! mặc định là internal nếu không khai báo

        + áp dụng khai báo và khởi tạo thành viên dữ liệu (biến, trường dữ liếu):
            * public : không giới hạn phạm vi truy cập
            * protected : chỉ truy cập trong nội bộ lớp hay các lớp kế thừa
            * private : (mặc định) chỉ truy cập được từ các thành viên của lớp chứa nó
            * internal : chỉ truy cập được trong cùng assembly (dll, exe)
            * protected internal: truy cập được khi cùng assembly hoặc lớp kế thừa
            * private protected: truy cập từ lớp chứa nó, lớp kế thừa nhưng phải cùng assembly

        // Đọc thêm mục assembly

    - Khai báo và khởi tạo
        var ob1 = new ClassName();
        hoặc
        ClassName ob2;
        ob2 = new ClassName();

    - toán tử .
        + các đối tượng được tạo từ lớp có thể truy cập các thành phần trong class thông qua toán tử .

    - con trỏ this
        + Từ khóa this dùng trong các phương thức của lớp, nó tham chiếu đến đối tượng hiện tại sinh ra từ lớp.
        + Sử dụng this để tường minh, tránh sự không rõ ràng khi truy cập thuộc tính, phương thức hoặc để lấy đối tượng lớp làm tham số cho các thành phần khác ...

    - Thành viên tĩnh (static)
        + Các thành viên trong lớp (phương thức, biến, thuộc tĩnh) khi khai báo có từ khóa static ở đầu thì nó là thành viên tĩnh.

        + Thành viên tĩnh thì nó không thuộc về đối tượng cụ thể nào, có thể sử dùng mà không cần tạo đối tượng. Truy cập đến thành viễn tĩnh thông qua TÊN-LỚP.tên-thành-viên-tĩnh.

        !!! Do không thuộc về đối tượng nên không thể dùng con trỏ this để gọi nó

        + Đối với biến tĩnh thì dùng cho cho mọi đối tượng thuộc lớp, được khởi tạo một lần duy nhất. Nếu muốn khởi tạo thành viên tĩnh của lớp khi lần đầu truy cập có thể dùng phương
        thức khởi tạo tĩnh

    - Thành viên chỉ đọc (readonly)
        + Biến readonly có nghĩa là chỉ đọc, không sửa đổi được nữa. Tuy nhiên so với hằng số const thì có mấy điểm khác:
            * Hằng số thì phải khởi tạo ngay giá trị cho nó khi khởi tạo, biến readonly thì không khởi tạo ngay cũng được
            * Biến readonly có thể gán giá trị cho nó trong hàm khởi tạo (và giá trị gán theo kết quả của một biểu thức nào đó)

            class Student {
                // khai báo biến readonly
                public readonly string name;
                public Student(string name)
                {
                    // khởi tạo biến readonly ở hàm tạo (bắt buộc nếu biến khai báo mà chưa khởi tạo)
                    this.name = name;
                }
            }

    - phương thức khởi tạo (constructor)
        + Phương thức khởi tạo là phương thức của lớp, nó được thi hành ngay khi đối tượng được tạo (bởi toán tử new)

        + Phương thức khởi tạo có tên trùng với tên của lớp, không có kiểu trả về, nên để phạm vi public

        + Có thể tạo nhiều phương thức khởi tạo - các phương thức này đều cùng tên với tên lớp nhưng tham số khác nhau

        + Khi muốn sử dụng constructor có tham số của lớp cha thì ở lớp con dùng từ khóa base để gọi phương thức của lớp cha
            public CategoryMobile(string nameofCategory, string mota) : base(nameofCategory)
            {
                description = mota;
            }

        !!! Constructor được gọi từ lớp cha trước rồi tới lớp con

        + Constructor tĩnh : có thể xây dựng một phương thức khởi tạo không tham số có chỉ thị truy cập là static, phương thức khởi tạo này dùng để khởi tạo các thành viên dữ liệu tĩnh,
        nó tự động gọi khi truy cập một thành viên dữ liệu tĩnh lần đầu.

    - phương thức hủy (destructor)
        + Dùng phương thức hủy khi có nhu cầu dọn dẹp, giải phóng tài nguyên chiếm giữ

        + Một lớp chỉ được khai báo một phương thức hủy (trong khi có thể có nhiều phương thức tạo)

        + Không thể gọi phương thức hủy một cách chủ động được (do hệ thống quản lý NET CORE tự quyết định thi hành nó khi nào)

        + Khai báo phương thức hủy: tên trùng tên lớp, phía trước code ký hiệu ~, phương thức không được có tham số.
            class MyClass {
                ~MyClass()
                {
                    // Thân phương thức hủy
                }
            }

        + Bộ nhớ trên HEAP là nơi lưu các đối tượng được tạo ra từ lớp (toán tử new), khi đối tượng đó không còn biến nào tham chiếu (trỏ) đến thì nó sẽ được đánh dấu thu hồi - và
        khi GC thu hồi - phương thức hủy sẽ được thi hành.

    - Lớp tĩnh (static class)
        + Khi lớp có phạm vi truy cập là static thì các thành viên khai báo trong lớp đều phải khai báo là thành viên tĩnh.
        + Thường dùng lớp tĩnh đề gom các hàm tiện ích lại với nhau. Ví dụ trong C# có lớp Math là lớp tĩnh chứa các phương thức toán học dùng ngay

    - Quá tải (Overloading)
        + Kỹ thuật quá tải phương thức (Method Overloading) là cách thức triển khai khái niệm tính đa hình của lập trình hướng đối tượng.
        + Quá tải phương thức là các phương thức có cùng tên nhưng tham số khác nhau (hàm có thể trả về kiểu dữ liệu khác nhau)
            public class OverloadingExample {
                public static int Sum(int a, int b)
                {
                    return a + b;
                }

                public static double Sum(double a, double b)
                {
                    return a + b;
                }
            }

        !!! Tính đa hình (polymorphism) là cách ứng xử của đối tượng - ứng xử này là khác nhau tùy thuộc vào tình huống cụ thể.
        !!! Khai báo hai hàm cùng tên, giống nhau hoàn toàn về tham số chỉ khác kiểu trả về sẽ gây lỗi.

        + Quá tải toán tử (Operator Overloading), giúp bạn định nghĩa mới (hoặc định nghĩa lại) hoạt động của các toán tử trên những đối tượng lớp do bạn định nghĩa.
            public static MyVector operator+(MyVector a, MyVector b)
            {
                double sx = a.x + b.x;
                double sy = a.x + b.y;
                MyVector v = new MyVector(sx,sy);
                return v;
            }

    - Tính đóng gói
        + Tính đóng gói mục đích hạn chế tối đa việc can thiệp trực tiếp vào dữ liệu, hoặc thi hành các tác vụ nội bổ của đối tượng.
        + Được thực hiện thông qua phạm vi truy cập access modifiers

        !!! Khi lập trình cố gắng tối đa ẩn thông tin ra bên ngoài lớp càng nhiều càng tốt để đảm bảo tính đóng gói của kỹ thuật lập trình OOP, nó giúp cho code dễ bảo trì và giám sát lỗi.

    - Thuộc tính
        + trường dữ liệu của lớp: là biến trong lớp, nên để phạm vi private để đảm bảo an toàn và tính đóng gói

        + thuộc tính, bộ truy cập accessor setter/getter
           * thuộc tính được khai báo tương tự như trường dữ liệu nhưng có thêm bộ accessor và có phạm vi public
           * mục đính là để tạo ra các thao tác trao đổi với trường dữ liệu của class, đảm bảo sự an toàn dữ liệu

        class Student
        {
            private string name;     // Đây là trường dữ liệu

            public string Name       // Đây là thuộc tính
            {
                // set thi hành khi gán, write
                // dữ liệu gán là value
                set
                {
                    Console.WriteLine("Ghi dữ liệu <--" + value);
                    name = value;
                }

                //get thi hành ghi đọc dữ liệu
                get {
                    return "Tên là: " + name;
                }
            }
        }

        !!! Thuộc tính accessor có thể khai báo thiếu set hoặc get, nếu thiếu set nó trở thành loại chỉ đọc (readonly). Sử dụng set rất tiện lợi cho thao tác kiểm tra tính hợp lệ của dữ
        liệu khi gán, hoặc tự động thực hiện một số tác vụ mỗi khi dữ liệu được gán.

        + có thể khai báo 1 cách tự động set/get
            public string Name {set; get;}

    - Bộ đánh chỉ mục (indexer)
        + Indexer là khả năng cho cho phép truy cập đến các thành viên của lớp, thực hiện một số tác vụ thông qua ký hiệu chỉ mục [chỉ-mục] (ký hiệu chỉ mục được dùng để truy cập các phần tử mảng)
        + Để khai báo một bộ chỉ mục, khai báo gần giống như cú pháp khai báo thuộc tính lớp, setter/getter , cú pháp cơ bản
            public kiểu_trả_về this[kiểu_index index]
            {
                get {
                    // thực hiện các tác vụ và trả về dữ liệu có kiểu_trả_về
                }
                set {
                    // giá trị được truyền trong biến value, có thể lưu nó vào nơi thích hợp
                }
            }

        + Ví dụ
            class IndexerExam {
                string ho = "Nguyễn";
                string ten = "Nam";

                // Bộ chỉ mục số nguyên, chỉ mục là 0 hoặc 1 nếu khác sẽ phát sinh Exception
                public string this[int index]
                {
                    // Đọc dữ liệu theo chỉ mục
                    get {
                        if (index == 0) return ho;
                        else if (index == 1) return ten;
                        else throw new Exception("Chỉ số không tồn tại");
                    }

                    // Gán dữ liệu theo chỉ mục
                    set {
                        if (index == 0)  ho = value;
                        else if (index == 1) ten = value;
                        else throw new Exception("Chỉ số không tồn tại");
                    }
                }
            }

## Kiểu cấu trúc (Struct)

    - struct kiểu dữ liệu cấu trúc (còn gọi là structure) tạo thành khi muốn gộp các dữ liệu có liên quan thành một nhóm (đóng gói dữ liệu)

    - Trong struct có thể chứa: trường dữ liệu, thuộc tính, phương thức khởi tạo, hằng số, các phương thức, toán tử, sự kiện.

    !!! Struct là kiểu dữ liệu tham trị không phải tham chiếu như class

    !!! Phương thức khởi tạo bắt buộc phải khởi tạo toàn bộ thành viên dữ liệu (trường, thuộc tính) có trong struct.

    public struct Product {
        public Product(string _name)
        {
            name = _name;  // đồng nghĩa khởi tạo thuộc tính Name
            price = 100;
            Description = "Mô tả về sản phẩm {name}";
        }

        public string name;   // trường tên sản phẩm
        public decimal price; // trường giá sản phẩm

        // Phương thức sinh ra chuỗi thông tin
        public override string ToString() => $"{name} : {price}$";

        // Thuộc tính Name
        public string Name {set => name = value; get => name;}
        // Thuộc tính Description
        public string Description {set; get;}
    }

## Kiểu liệt kê (Enum)

    - Kiểu liệt kê (enum) khai báo một tập hợp các hằng số có tên, mặc định giá trị các hằng số này là kiểu int và bắt đầu từ 0 trở đi trong khai báo kiểu liệt kê.

    !!! Enum là kiểu dữ liệu tham trị

    - Có thể gán một tên nào đó ứng với giá trị cụ thể
        enum HocLuc {Kem, TrungBinh = 5, Kha, Gioi};
        Do TrungBinh bằng 5, nên tên tiếp theo Kha sẽ nhận 6, Giỏi là 7

    - Enum rất phù hợp khi giá trị của biến nhận một giá trị hằng số trong tập hằng số hữu hạn nào đó

    - Đặc biệt hay dùng Enum với câu lệnh switch

## Kế thừa

    - Kế thừa cho phép định nghĩa ra một lớp mới dựa trên một lớp khác có sẵn, kế thừa giúp cho việc mở rộng code - bảo trì trở nên dễ hơn.

    - Lớp cơ sở là lớp mà được lớp khác kế thừa.

    - Lớp kế thừa là lớp kế thừa lại các thuộc tính, phương thức từ lớp cơ sở.

    - Nhưng lớp mới kế thừa lại các thông tin của lớp cơ sở và thêm vào những đặc tính riêng của nó.

    !!! C# không hỗ trợ đa kế thừa (mỗi lớp kế thừa chỉ có một lớp cơ sở)

    - Lớp niêm phong (sealed)
        + Trong kỹ thuật lập trình, bạn có thể đánh dấu một lớp nào đó không bao giờ trở thành lớp cơ sở để phái sinh ra lớp khác - lớp đó gọi là bị niêm phong.
            sealed class A {
                // ....
            }

            class B : A {  // Chỗ này lỗi vì kế thừa lớp bị niêm phong
                // ....
            }

        + Dùng kỹ thuật niêm phong lớp (sealed) để đảm bảo không phái sinh các lớp kế thừa một cách thoải mái, mất kiểm soát, nhất là khi số dự án lớn, nhiều người tham gia.

    - Phương thức khởi tạo và hủy
        + Hàm khởi tạo của lớp cơ sở chạy trước, xong đến hàm khởi tạo của lớp kế thừa.

        + Đối với các phương thức hủy, khi đối tượng hủy nó sẽ thi hành phương thức hủy của lớp kế thừa trước, rồi mới đến phương thức hủy của lớp cơ sở (ngược với khởi tạo).

        + Khi phương thức khởi tạo lớp cơ sở có tham số, hoặc ấn định một phương thức khởi tạo của lớp cơ sở (nếu lớp cơ sở có quá tải nhiều phương thức khởi tạo), thì hàm tạo của lớp kế thừa
        phải chỉ định sẽ khởi chạy phương thức khởi tạo (và truyền tham số) nào của lớp cơ sở.
            class A {
                public A(string mgs) {
                    Console.WriteLine("A Init" + mgs);
                }
            }

            class B : A {
                public B(string abc) : base(abc)
                {
                    Console.WriteLine("B Init");
                }
            }

    - Chuyển kiểu
        + có thể chuyển kiểu một cách tường minh (viết tên kiểu muốn chuyển trong () trước đối tượng), hay ngầm định.
        + không thể chuyển kiểu thuận cây kế thừa -  Lớp cha không chuyển thành con được

## Partial type và Nested type

    - Partial
        + Partial là kỹ thuật phân chia code lưu ở nhiều file mã nguồn khác nhau, khi biên dịch thì nó tổng hợp lại thành một.
        + Để phân chia lớp, khai báo và định nghĩa các thành phần của lớp ở nhiều nơi khác nhau, với yêu cầu trong khai báo lớp cho thêm từ khóa partial

        // Product1.cs
            using System;

            namespace CS007B_PARTIAL
            {
                public partial class Product {
                public string Name { set; get;}

                public bool Order(int number = 0)
                {
                    return true;
                }

                }
            }

        // Product2.cs
            using System;

            namespace CS007B_PARTIAL
            {
                public partial class Product {

                    public int numberBrought()
                    {
                        return 100;
                    }

                }
            }

        !!! Trong định nghĩa ở tất cả các phần phải có từ khóa partial. Từ khóa partial có thể đặt ngay trước từ khóa class

        + Có thể dùng từ khóa partial trong khai báo các phương thức, tuy nhiên mục đích chỉ là chia làm hai nơi, một nơi như là khai báo một nơi là triển khai code, và phương thức phải
        trả về kiểu void.
        // file1.cs
            partial void myMethod();

        // file2.cs
            partial void myMethod()
            {
                // code triển khai
            }

        + Partial Method thường sinh ra bởi việc sinh mã nguồn tự động khi dùng công cụ IDE

    - Nested (Lớp lồng nhau)
        + kiểu lồng nhau (Nested Type) cho phép bạn khai báo một lớp (class), giao diện (interface), cấu trúc (struct) trong thân một lớp khác
            class MobileProduct {
                public Manufactory manufactory { set; get; }

                // Lớp Manufactory nằm trong MobileProduct
                public class Manufactory {
                    string address;
                    public Manufactory (string address) {
                        this.address = address;
                    }
                    public void ShowAddress () {
                        Console.WriteLine (address);
                    }
                }

                public void ProductInfo () {
                    manufactory.ShowAddress ();
                }
            }

            // Sử dụng
            MobileProduct product = new MobileProduct();
            product.manufactory =  new MobileProduct.Manufactory("Abc ...");
            product.ProductInfo();

## Generic

    - Generic là kiểu đại diện, nó cho phép tạo mã nguồn code không phụ thuộc vào kiểu dữ liệu cụ thể, chỉ khi code thực thi thì kiểu cụ thể mới xác định.

    - Những giải thuật giống nhau trên những kiểu dữ liệu khác nhau, để tránh việc viết nhiều lần code lặp lại thì lúc này áp dụng Generic - kiểu đại diện để xây dựng phương thức hoặc lớp.

    - Phương thức generic
        + Chỗ nào là kiểu dữ liệu cụ thể thì thay nó bằng tên kiểu Generic, tên này là tự đặt một cách thống nhất tùy chọn như A, B, T, .... Trong đó sau phần tên hàm phải liệt kê ra
        tên những kiểu Generic mà bạn sẽ sử dụng cho hàm.
            X MyFunction<X, Y> (X x, Y y)
            {
                return x;
            }

    - Lớp generic
        + Tương tự như phương thức, cũng có thể khai báo lớp với Generic - bằng liệt tên các kiểu đại diện này sau khai báo tên lớp
            class MyClass<X, Y> {
            // ...
            }

        + Xây dựng lớp với kiểu Generic phổ biến để triển khai nhiều loại giải thuật

## Anonymous Type (Kiểu vô danh)

    - Kiểu vô danh là kiểu không có tên
        var obj = new {
            thuoctinh1 = giatri1,
            thuoctinh2 = giatri2
        }

    - Bằng cú pháp như vậy, tạo ra được đối tượng chứa các thuộc tính, tạo ra đối tượng mà không cần phải khai báo lớp

    !!! các thuộc tính được khai báo là thuộc tính chỉ đọc

    - Kiểu vô danh Anonymous Type - được dùng phổ biến trong LINQ

    - Nếu truyền như tham số cho các phương thức - coi nó như các object có thể gây lỗi khi buil ứng dụng - trình biên dịch kiểm tra và báo lỗi. Để giải quyết vấn đề này có thể dùng đến
    khai báo kiểu dynamic

## Dynamic Type (kiểu động)

    - Biến kiểu động - ngầm định kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy
        dynamic myvar;
        // hoặc
        static void TestFunc(dynamic dvar) {
            Console.WriteLine(dvar.age); // ở thời điểm biên dịch - không biết dvar có thuộc tính age hay không, nhưng nó vẫn biên dịch
        }
        // Với phương thức trên, ở thời điểm chạy mà đối tượng ở tham số có thuộc tính age thì sẽ không lỗi, còn nếu không có thuộc tính age sẽ sinh ngoại lệ.

    !!! khác với kiểu ngầm định var kiểu xác định ngay thời điểm biên dịch (không cần khởi tạo giá trị từ trước)

    ## Null - Nullable
    - null là một giá trị cố định nó biểu thị không có đối tượng nào cả, có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).

    - null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), không thể gán null cho những biến có kiểu dữ liệu dạng tham trị

    - Nếu muốn sử dụng các kiểu dữ liệu nguyên tố (kiểu tham trị) như là một kiểu dữ liệu dạng tham chiếu, có thể gán giá trị null cho nó, có thể sử dụng như đối tượng thì khai báo nó có
    khả năng nullable

    - khi biến nullable có giá trị thì đọc giá trị bằng truy cập thành viên .Value
        int? bienkieuint;                 // Hoặc Nullable<int> bienkieuint;

        bienkieuint = null;               // có thể gán null cho biến
        bienkieuint = 10;                 // có thể gán giá trị cho biến

        if (bienkieuint != null)
        {
            int val = bienkieuint.Value;  // đọc giá trị trong biến nullable
        }

    !!! dạng khai báo đầy đủ của int? là Nullable<int>

    - Nullable rất tiện dụng khi lập trình các truy vấn cơ sở dữ liệu, lập trình web ...

    !!! 1 số tác dụng của toán tử ? và ??
        + sử dụng như một phần của toán tử điều kiện null (null-conditional operator), giúp tránh lỗi NullReferenceException khi truy cập vào thành viên của một đối tượng có thể null
            Person person = null;
            int? age = person?.Age; // age sẽ là null nếu person là null

        + Toán tử ?? là toán tử gộp null (null-coalescing operator), cho phép bạn cung cấp một giá trị thay thế nếu giá trị hiện tại là null
            string name = nullableString ?? "Default Name";
            // sẽ nhận giá trị của nullableString nếu nó không phải là null, ngược lại sẽ nhận giá trị "Default Name"

## Đa hình

    - Tính đa hình của nghĩa là có nhiều dạng, tính đa hình sẽ thể hiện rõ khi xây dựng các lớp kế thừa. Một phương thức được gọi, nó sẽ là phương thức cụ thể nào tùy thuộc vào đối tượng
    lúc nó thực thi.

    - Phương thức ảo (virtual funtion)
        + Một phương thức ảo trong lớp - là phương thức có thể định nghĩa lại (bị nạp chồng - bị đè) bởi lớp kế thừa
            class Product {
                protected double price = 0;

                // Phương thức ảo ProductInfo
                public virtual void ProductInfo() {
                    Console.WriteLine($"Giá sản phẩm {price}");
                }

                public void TestProduct()
                {
                    this.ProductInfo();
                }
            }

        + Hàm ảo có thể định nghĩa lại - kỹ thuật này gọi là nạp chồng (override)

    - Nạp chồng phương thức (Override)
        + Ở lớp kế thừa, có thể định nghĩa lại phương thức ảo của lớp cơ sở, việc này là thực hiện nạp chồng, để nạp chồng chỉ việc khai báo lại phương thức thêm vào từ khóa override
            class Iphone : Product {
                public Iphone() {
                    price = 500;
                }
                public override void ProductInfo() {
                    Console.WriteLine($"Điện thoại Iphone");
                    base.ProductInfo();
                }
            }

        + Để sử dụng lại hàm của lớp cơ sở dùng từ khóa base để gọi đến lớp cơ sở

        + Đối tượng được khởi tạo thuộc kiểu nào thì sẽ gọi đến hàm và thuộc tính của kiểu đó

    - Lớp / phương thức trừu tượng (abstract)
        + Lớp trừu tượng thì không được dùng để khởi tạo đối tượng trực tiếp mà chỉ làm lớp cơ sở kế thừa bởi lớp khác.

        + Trong lớp trừu tượng, còn có thể khai báo phương thức trừu tượng với từ khóa abstract, phương thức này không có thân (chỉ có tên - tham số), nó yêu cầu lớp kế thừa bắt buộc phải
        nạp chồng (override)
            abstract class Product {
                protected double price = 0;
                public abstract void ProductInfo();
                public void TestProduct()
                {
                    this.ProductInfo();
                }
            }

    - Giao diện (interface)
        + Giao diện (interface) nó có ý nghĩa gần giống với lớp abstract

        + Tất cả các phương thức đều khai báo không có thân (chỉ có tên - nghĩa là phương thức abstract)

        + Lớp triển khai giao diện (lớp kế thừa) bắt buộc phải định nghĩa lại (không cần từ khóa overrid) tất cả các phương thức này, cũng có một điều khác là lớp kế thừa có thể
        kế thừa nhiều giao diện.
            interface IProduct {
                public void ShowPrice();
            }

            interface IOrder {
                public void OrderAction(int numberProduct);
            }

            class Product : IProduct, IOrder {
                double price;
                public Product(double price) {
                    this.price = price;
                }
                public void ShowPrice() {
                    Console.WriteLine($"Price: {price}");
                }

                public void OrderAction(int numberProduct) {
                    Console.WriteLine($"Order: {numberProduct}");
                }
            }

        + Giao diện, giống như những mẫu - mà lớp triển khai bắt buộc phải có các phương thức giống nó.

## Delegate

    - Delegate (hàm ủy quyền) là một kiểu dữ liệu, nó dùng để tham chiếu (trỏ đến) đến các hàm (phương thức) có tham số và kiểu trả về phù hợp với khai báo kiểu.

    - Delegate có thể gán vào nó một, nhiều hàm (phương thức) có sự tương thích về tham số, kiểu trả về, sau đó dùng nó để gọi hàm (giống con trỏ trong C++)

    - Delegate được dùng phổ biến khi gán các biểu thức lambda

    - Delegate thường được dùng để xây dựng các hàm callback, đặc biệt là các Event

    - Ví dụ cách sử dụng
        + Khai báo một delegate giống như cách khai báo phương thức nhưng có thêm từ khóa delegate và không có thân phương thức.
            public delegate void ShowLog(string message);

        + Khi đã có ShowLog, nó dùng như một kiểu dữ liệu để khai báo các biến, các biến này có thể gán vào nó các hàm có sự tương đồng về tham số và kiểu trả về với khai báo delegate
            ShowLog showLog;

        !!! Sau khi biến delegate được gán hàm vào, có thể dùng biến delegate để thi hành bằng cách gọi:
            varDelegate.Invoke(các-tham-số) hoặc varDelegate(các-tham-số)

        + Tạo hai phương thức Info và Warning có tham số giống với ShowLog, nghĩa là có một tham số kiểu string, trả về void:
            static public void Info(string s)
            {
                // ...
            }

            static public void Warning(string s)
            {
                // ...
            }

        + Do Info, Warning có tương đồng về tham số với delegate trên, nên hai hàm này có thể dùng để gán vào biến kiểu ShowLog
            ShowLog showLog;

            showLog = Info;         // showLog gán bằng phương thức Info
            showLog("Thông báo");   // Thi hành delegate chính là thi hành Info

            showLog = Warning;      // showLog gán bằng phương thức Warning
            showLog("Thông báo");   // Thi hành delegate chính là thi hành Info

        + Khi chạy thì showLog sẽ thực hiện nội dung các hàm mà nó được gán (cần đảm bảo biến delegate đó đã được gán phương thức - biến khác null)
            if (showLog != null) showLog("Mgs") hoặc gắn gọn hơn showLog?.Invoke("Mgs");

        + Một delegate có thể đưa vào nó nhiều phương thức để một lần gọi thi hành tất cả các phương thức nó chứa
            * Toán tử += : Nối thêm một phương thức vào delegate
                delegatevar += method1
            * Toán tử -= : Loại bỏ 1 phương ở cuối (nếu phương thức đó có trong delegate, tính từ cuối)
                delegatevar -= method1

        + Ngoài cách gán cho delegate một hàm có tên cụ thể, cũng có thể gán một phương thức Anonymou
            showLog += (x) => Console.WriteLine(string.Format("===>{0}<===", x));

        + Các delegate cùng kiểu có thể kết hợp lại với nhau bằng toán tử +
            ShowLog showLog1 = (x)=> {Console.WriteLine($"-----{x}-----");};
            ShowLog showLog2 = Warning;
            ShowLog showLog3 = Info;

            var all = showLog1 + showLog2 + showLog3 + showLog1;

    !!! Hiểu đơn giản có thể hình dung delegate như 1 mảng chứa các con trỏ hàm. Khi Khi gọi đến 1 dekegate thì nó sẽ thực hiện các hàm mà nó chứa theo thứ tự từ đầu tới cuối (thứ tự được thêm vào)
    !!! Các hàm trong 1 delegate phải có cùng kiểu trả về, cùng số lượng và kiểu các tham số truyền vào hàm

    - Có thể sử dụng delegate làm tham số của phương thức, nó có vai trò như những hàm callback linh hoạt.
        // Sử dụng Delegate làm tham số phương thức, truyền callback
        static void TinhTong(int a, int b, Action callback)
        {
            int c = a + b;
            // Gọi callback
            callback(c.ToString());
        }

        public static void TestTinhTong()
        {
            TinhTong(5,6, (x) => Console.WriteLine($"Tổng hai số là: {x}"));
            TinhTong(1,3, Logs.Info);
        }

    - Func và Action
        + Func và Action là hai mẫu delegate định nghĩa sẵn, giúp nhanh chóng tạo ra biến kiểu delegate mà không mất công khai báo

        + Func là mẫu delegate có kiểu trả về
            Func<kiểu_tham_số_1, kiểu_tham_số_2, ..., kiểu_trả_về> var_delegate;

            // Khai báo kiểu Func
            Func<int, string, bool> bien1; => biến delegate tên bien1 tương đương với hàm có 2 tham số, tham số 1 kiểu int, tham số 2 kiểu string, và hàm trả về kiểu bool

            // Khai báo delegate bình thường
            delegate bool DelegateName(int a, string b);
            DelegateName bien1;

        !!! Kiểu cuối cùng trong khai báo Func là kiểu trả về của hàm, có thể thiếu tham số nhưng không được thiếu kiểu trả về

        + Action là mẫu delegate không có kiểu trả về hay biến kiểu Action có thể gán bằng các hàm có kiểu trả về void
            Action<kiểu_tham_số_1, kiểu_tham_số_2, ... > var_delegate;

## Biểu thức lambda (Anonymous)

    - Biểu thức lambda còn gọi là biểu thức hàm nặc danh (Anonymous), một biểu thức khai báo giống phương thức (hàm) nhưng thiếu tên
        (các_tham_số) => biểu_thức;
        // Hoặc
        (các_tham_số) =>
        {
            // các câu lệnh
            // Sử dụng return nếu có giá trị trả về
        }

    - Các biểu thức lambda đều có thể chuyển đổi thành delegate, do vậy nó có thể gán cho các delegate phù hợp
        public delegate int TinhToan (int a, int b);

        static void Main (string[] args) {
            // Gán biểu thức lambda cho delegate
            TinhToan tinhtong = (int x, int y) => {
                return x + y;
            };

            int kq = tinhtong (5, 1); // kq = 6;
            Console.WriteLine(kq);
        }

        !!! Thường kết hợp với Func hoặc Action để tạo chuỗi các hành động

    - Có thể sử dụng toán tử => sau khai báo tên phương thức (loại phương thức có kiểu trả về khác void), rồi đến ngay một biểu thức (biểu thức lambda) có kết quả trả về (không dùng {}), biểu thức
    này như là định nghĩ thân của phương thức.
        int Tong(int x, int y) => x + y;
        // Tương đương
        int Tong(int x, int y)
        {
            return x + y;
        }

        !!! Hiểu là dùng để rút gọn phương thức đối với các phương thức thực hiện 1 dòng lệnh, 1 công việc ngắn có kiểu trả về (khác void)

## Event

    - Các sự kiện (Event) là cơ chế để một đối tượng (đối tượng của lớp) này thông báo đến đối tượng khác có điều gì đó mà lớp khác quan tâm vừa xảy ra.

    - Lớp mà từ đó gửi đi sự kiện gọi tên nó là publisher và các lớp nhận được sự kiện gọi là là các subsriber.

    - Các Event xây dựng với nền tảng chính là delegate

    - Giả xử sử dụng delegate để nhận và phát sự kiện từ các lớp publisher và subsriber. Nhưng delegate có thể được gán lại bằng null làm cho các sự kiện đăng ký trước đó bị hủy. Điều này
    là phá hỏng nguyên tắc hoạt động của mô hình lập trình sự kiện - phá vỡ sự đóng gói

    - Đối với Event thì không thể gán null cho kiểu dữ liệu này, giúp đảm bảo được nguyên tắc hoạt động của mô hình lập trình sự kiện

    !!! Event là Delegate nhưng khi khai báo thêm từ khóa event, dẫn tới chỉ có thể thực hiện toán tử += hoặc -= với Event

    - Event trong thư viện .Net đều xây dựng từ một delegate có tên EventHandler, nó đã định nghĩa sẵn có trong thư viện .NET với dạng:
        public delegate void EventHandler(object sender?, EventArgs e);
        public delegate void EventHandler<TEventArgs>(object sender?, TEventArgs e);

    - Ta có thể sử dụng luôn delegate EventHandler để xây dựng các Event của riêng mình sử dụng cho các Publisher, chỉ cần xây dựng các lớp phái sinh từ EventArgs với mục đích thêm vào các
    tham số riêng khi gửi sử kiện.
        // Xây dựng lớp MyEventArgs kế thừa từ EventArgs
        public class MyEventArgs : EventArgs {
            public MyEventArgs (string data) {
                this.data = data;
            }

            // Lưu dữ liệu gửi đi từ publisher
            private string data;

            public string Data {
                get { return data; }
            }
        }

        // Xây dựng lớp, phát đi sự kiện (data)
        public class ClassA {
            // Tạo Event với EventHandler
            public event EventHandler event_news;

            public void Send () {
                event_news?.Invoke (this, new MyEventArgs ("Có tin mới Abc ..."));
            }
        }

        public class ClassB {
            public void Sub (ClassA p)
            {
                p.event_news += ReceiverFromPublisher;
            }

            private void ReceiverFromPublisher (object sender, MyEventArgs e)
            {
                Console.WriteLine ("ClassB: " + e.Data);
            }
        }

        public class ClassC {
            public void Sub (ClassA p)
            {
                p.event_news += ReceiverFromPublisher;
            }

            private void ReceiverFromPublisher (object sender, MyEventArgs e)
            {
                Console.WriteLine ("ClassC: " + e.Data);
            }
        }

    !!! Hiểu đơn giản Event là 1 delegate không thể null (không nullable). Event được dùng để nhận và thực hiện 1 chuỗi thao tác thông qua các lớp publisher (lớp phát) thực hiện Event,
    lớp subsriber (lớp đăng ký) thêm thao tác vào Event.

## Extension Method (Phương thức mở rộng)

    - Các phương thức mở rộng là các phương thức thêm vào lớp, cấu trúc, giao diện có sẵn mà không cần thiết phải kế thừa lớp để tạo ra các lớp mới, không cần biên dịch lại thư viện.

    - Các phương thức mở rộng khai báo là những phương thức tĩnh, nhưng lại được gọi thông qua đối tượng lớp mà phương thức mở rộng đó khai báo.
        public static [kiểu trả về] [tên phương thức] (this [kiểu dũ liệu] tenbien, ...)
        {
            // ...
        }

    !!! kiểu dự kiệu của tham số đầu tiên là kiểu dự kiệu được mở rộng (có thêm hàm)

    - Ví dụ
        public static void Print(this string s, ConsoleColor color = ConsoleColor.Yellow)
        {
            ConsoleColor lastColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ForegroundColor = lastColor;
        }
        => các đối tượng string sẽ có thêm phương thức Print

## Exception (ngoại lệ)

    - Ngoại lệ (exception) là vấn đề - lỗi phát sinh trong quá trình thực thi chương trình. Thường khi chương trình đang chạy mà phát sinh ngoại lệ (lỗi) thì dẫn đến chương trình
    kết thúc ngay lập tức.

    - Có vô số nguyên nhân để chương trình đang chạy mà phát sinh ngoại lệ:
        + Dữ liệu người dùng nhập sai, mà chương trình không kiểm soát được
        + Thực hiện các phép toán không được phép (như chia một số cho 0)
        + Thao tác với tài nguyên không tồn tại (như mở file không có trên đĩa, kết nối đến CSDL không tồn tại ...)
        + Thiếu bộ nhớ
        + ...

    - Khi có một lỗi phát sinh hầu hết các lỗi đều có thể quản lý bởi thư viện C# thì nó sẽ phát sinh ra một đối tượng lớp Exeption (System.System) hoặc đối tượng lớp nào đó
    kế thừa từ Exception

    - Khi một đối tượng lớp Exception sinh ra - mà chương trình không chủ động xử lý đối tượng này thì chương trình sẽ kết thúc

    - Đối tượng lớp Exception chứa trong nó các thông tin về lỗi (dòng thông báo, nguyên nhân lỗi, nơi phát sinh lỗi ...)

    - Xử lý ngoại lệ
        + xử lý ngoại lệ thì ta cần bắt lấy nó và điều hướng chương trình một cách thích hợp. Để bắt ngoại lệ ta sử dụng câu lệnh try catch:
            try {
                // Các khối code được giám sát để bắt lỗi nếu có
                // nếu có lỗi sẽ phát sinh ngoại lệ Exception
                // Ngoại lệ này bắt lại được ở khối catch
            }
            catch (Exception loi)
            {
                // Khối này thực thi khi có lỗi - đối tượng Exception bắt được lưu ở biến loi
            }

        + Đoạn code nào muốn giám sát để bắt ngoại lệ - thì đưa vào khối try

        + Nếu ngoại lệ xảy ra do code trong khối đó thì sẽ bắt được - chương trình sẽ không kết thúc mà lập tức chuyển sang khối catch

        + Tại catch có ngay đối tượng lớp Exception - cần xử lý theo logic ứng dụng điều hướng chương trình một cách thích hợp ở đây

            static void Main(string[] args)
            {
                try {
                    // khối này được giám sát để bắt lỗi - khi nó phát sinh
                    int[] mynumbers = new int[] {1,2,3};
                    int i = mynumbers[10];                  // dòng này phát sinh lỗi
                    Console.WriteLine(i);                   // dòng này không được thực thi vì lỗi trên
                }
                catch (Exception loi)
                {
                    // khối này thực thi khi bắt được lỗi
                    Console.WriteLine("Có lỗi rồi");
                    Console.WriteLine(loi.Message);
                }
            }

            => Có lỗi rồi
            => Index was outside the bounds of the array.

        + Trong .NET từ lớp cơ sở Exception nó xây dựng nên rất nhiều loại ngoại lệ khác phục vụ chi tiết cho từng loại lỗi phát sinh khác nhau. Có thể bắt nhiều ngoại lệ.

        + Để bắt cụ thể một loại ngoại lệ nào đó chỉ việc thêm một khối catch tương ứng với ngoại lệ đó

        + Trong lệnh try ... catch, có thể thêm một tùy chọn là khối finally, code trong khối này được thực thi ngay cả khi có phát sinh ngoại lệ hay không.
            int x = 10;
            int y = 0;
            int z = 0;
            try {
                z = x / y;
            }
            catch (DivideByZeroException e1) {
                Console.WriteLine(e1.Message);
            }
            finally {
                // Luôn được thi hành dù có phát sinh ngoại lệ hay không
                Console.WriteLine(z);
            }

        !!! Khối finally cơ bản để giải phóng các tài nguyên chiếm giữ.

    - Thuộc tính (hay dùng)
        + Message : chuỗi chứa nội dung thông báo lỗi
        + StackTrace : chuỗi chứa các bước thực thi chương trình cho đến khi bị lỗi (có chứa các phương thức, hàm khi thực thi gây lỗi, vị trí file lỗi ...)
        + Source : chứa tên ứng dụng hoặc đối tượng bị lỗi

    - Phát sinh ngoại lệ
        + Nếu muốn phát sinh ngoại lệ cho biết có một lỗi nào đó vừa xảy ra thì cần tạo ra một đối tượng lớp Exception hoặc đối tượng thuộc lớp nào đó kế thừa từ Exception,
        sau đó phát sinh bằng lệnh throw
            public static double Thuong(double x, double y) {
                if (y == 0) {
                    // Khởi tạo ngoại lệ, tham số là thông báo lỗi
                    Exception myexception = new Exception("Số chia không được bằng 0");

                    // phát sinh ngoại lệ, code phía sau throw không được thực thi
                    throw myexception;
                }
                return x / y;
            }
            static void Main(string[] args) {
                try {
                    double z = Thuong(100,0);
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }

    - Lớp Exeption riêng
        + Nếu muốn tạo ra các lớp để quẳng ra các lỗi khi cần thiết, thì chỉ việc kế thừa lớp Exception. Lợi ích việc tạo ra lớp riêng, nó giúp cho việc quản lý lỗi - gỡ rối tốt hơn.
            public class DataTooLongExeption : Exception {
                const string erroMessage = "Dữ liệu quá dài";
                public DataTooLongExeption() : base(erroMessage) {
                }
            }

## Collection

    - Một collection (bộ, tập hợp) là một nhóm các đối tượng có sự liên quan đến nhau. Số đối tượng trong collect có thể thay đổi tăng giảm.

    - Có nhiều loại collection, chúng được tập hợp vào namespace System.Collections. Thường thì một lớp collection có các phương thức để thêm, bớt, lấy tổng phần tử.

    - Các lớp collection kiểu Generic như: List<T>, Dictionary<TKey, TValue>, Stack<T> ... những lớp generic này ở namespace System.Collections.Generic

    - Các lớp collection mà không sử dụng generic như: ArrayList, Stack, Queue ...

    - Interface về collect
        | IEnumerable<T>	                | Triển khai nó nếu muốn duyệt phần tử bằng foreach, nó định nghĩa phương thức GetEnumerator trả về một enumerator.                              |
        | ICollection<T>	                | Giao diện này được triển khai bở các generic collection. Với nó lấy tổng phần tử bằng thuộc tính Count, copy các phần tử vào mảng bằng CopyTo, |
        |                                   | thêm bớt phần tử với Add, Remove, Clear                                                                                                        |
        | IList<T>	                        | Giao diện này kế thừa ICollection<T> là một danh sách các phần tử truy cập được theo vị trí của nó. Nó có indexer, phương thức để chèn phần tử |
        |                                   | xóa phần tử Insert RemoveAt.                                                                                                                   |
        | ISet<T>	                        | Giao diện triển khai bởi các tập hợp                                                                                                           |
        | IDictionary<TKey,TValue>	        | Giao diện để triển khai loại dữ liệu lưu trữ theo cặp key, value.                                                                              |
        | ILookup<TKey,TValue>	            | Giao diện để triển khai loại dữ liệu lưu trữ theo cặp key, value. Nhưng cho phép một key có nhiều giá trị                                      |
        | IComparer<TKey,TValue>	        | Giao diện để triển khai cho phép so sánh để sắp xếp Collection                                                                                 |
        | IEqualityComparer<TKey,TValue>	| Giao diện để triển khai cho phép so sánh bằng                                                                                                  |

## List<T>

    - Lớp collection List là lớp triển khai các giao diện IList, ICollection, IEnumerable nó quản lý danh sách các đối tượng cùng kiểu.

    - Ví dụ, xây dựng danh sách các sản phẩm, sản phẩm có kiểu Product tự định nghĩa như sau - lớp sản phẩm hỗ trợ so sánh với sản phẩm khác nên triển khai IComparable,
    cho phép hiện lấy một chuỗi thông tin bằng ToString với định dạng nào đó nên triển khai giao diện IFormattable
        using System;
        namespace CS017_Generic
        {
            public class Product : IComparable<Product>, IFormattable
            {
                public int ID {set; get;}
                public string Name {set; get;}        // tên
                public double Price {set; get;}       // giá
                public string Origin {set; get;}      // xuất xứ

                public Product(int id, string name, double price, string origin) {
                    ID = id; Name = name; Price = price; Origin = origin;
                }

                //Triển khai IComparable, cho biết vị trí sắp xếp so với đối tượng khác
                // trả về 0 - cùng vị trí; trả về > 0 đứng sau other; < 0 đứng trước trong danh sách
                public int CompareTo(Product other)
                {
                    // sắp xếp về giá
                    double delta = this.Price - other.Price;
                    if (delta > 0)      // giá lớn hơn xếp trước
                        return -1;
                    else if (delta < 0) // xếp sau, giá nhỏ hơn
                        return 1;
                    return 0;

                }

                // Triển khai IFormattable, lấy chuỗi thông tin của đối tượng theo định dạng
                // format hỗ trợ "O" và "N"
                public string ToString(string format, IFormatProvider formatProvider)
                {
                    if (format == null) format = "O";
                    switch (format.ToUpper()) {
                        case "O": // Xuất xứ trước
                            return $"Xuất xứ: {Origin} - Tên: {Name} - Giá: {Price} - ID: {ID}";
                        case "N": // Tên xứ trước
                            return $"Tên: {Name} - Xuất xứ: {Origin} - Giá: {Price} - ID: {ID}";
                        default: // Quăng lỗi nếu format sai
                            throw new FormatException("Không hỗ trợ format này");
                    }
                }

                // Nạp chồng ToString
                override public string ToString() => $"{Name} - {Price}";

                // Quá tải thêm ToString - lấy chỗi thông tin sản phẩm theo định dạng
                public string ToString(string format) => this.ToString(format, null);
            }
        }

    - Khởi tạo
        + Để khởi tạo một danh sách rỗng, dùng toán tử new
            var numbers  = new List<int>();           // danh sách số nguyên
            var products = new List<Product>();       // danh sách Product

        + Khởi tạo danh sách có sẵn một số phần tử, thì các phần tử liệt kê sau {}
            var numbers  = new List<int>() {1,2,3,4};     // khởi tạo 4 phần tử
            var products = new List<Product>()            // khởi tạo 1 phần tử
            {
                 new Product(1, "Iphone 6", 100, "Trung Quốc")
            };

    - Thêm (thêm vào cuối)
        + Thêm 1 phần tử, dùng Add
            var p = new Product(2, "IPhone 7", 200, "Trung Quốc");
            products.Add(p);                                                // Thêm p vào cuối List
            products.Add(new Product(3, "IPhone 8", 400, "Trung Quốc"));    // thêm đối tượng mới vào cuối List

        + Thêm nhiều phần tử một lúc (mảng các phần tử), dùng AddRange
            var arrayProducts = new Product[]                  // Mảng 2 phần tử
            {
                new Product(4, "Glaxy 7", 500, "Việt Nam"),
                new Product(5, "Glaxy 8", 700, "Việt Nam"),
            };
            products.AddRange(arrayProducts);                   // Nối các phần tử của mảng vào danh sách

    - Chèn
        + Chèn thêm 1 hoặc nhiều phần tử vào vị trí bất kì, dùng Insert(index, object) hoặc InsertRange(index, arrayObject)
            products.Insert(3, new Product(6, "Macbook Pro", 1000, "Mỹ"));     // chèn phần tử vào vị trí index 3, (thứ 4)

    - Đọc
        + Đọc 1 phần tử, dùng indexer
            var pro = products[2];                                             // đọc phần tử có index = 2
            Console.WriteLine(pro.ToString());

        + Đọc nhiều phần tử (duyệt danh sách), dùng for - foreach
            // products.Count = lấy tổng phần tử trong List
            for (int i = 1; i < products.Count; i++)
            {
                var pi = products[i - 1];
                Console.WriteLine(pi.ToString());
            }

            // Duyệt qua các phần tử bằng foreach
            foreach (var pi in products)
            {
                Console.WriteLine(pi.ToString());
            }

    - Xóa
        | Remove(index)             | Xóa 1 phần tử                                      |
        | RemoveRange(index, count) | Xóa nhiều phần tử                                  |
        | RemoveAll() hoặc Clear()  | Xóa toàn bộ danh sách                              |
        | Remove(object)            | Xóa 1 phần tử có tham chiếu cụ thể trong danh sách |

    - Tìm kiếm
        | IndexOf(obj)	     | Tìm index của đối tượng trong List                             |
        | LastIndexOf(obj)	 | Tìm index của phần tử cuối cùng có giá trị bằng obj trong List |
        | FindIndex	         | Tìm kiếm trả về Index                                          |
        | FindLastIndex	     | Tìm kiếm trả về Index cuối                                     |
        | Find(Predicate)	 | Tìm kiếm trả về phần tử                                        |
        | FindAll(Predicate) | Tìm kiếm trả về danh sách phần tử                              |
        | FindLast	         | Tìm kiếm trả về phần tử cuối tìm thấy                          |

        + Tham số Predicate truyền vào Find, FindAll là delegate bool Predicate<in T>(T obj) trả về true là phần tử phù hợp trả về
            // Delegate trả về true khi tên bằng "Glaxy 8"
            (Product ob) => {
                return (ob.Name == "Glaxy 8");
            }

            Product foundpr1 = products.Find(
                (Product ob) => { return (ob.Name == "Glaxy 8");}
            );
            if (foundpr1 != null)
                Console.WriteLine("(found) " + foundpr1.ToString("O"));
            // (found) Xuất xứ: Việt Nam - Tên: Glaxy 8 - Giá: 700 - ID: 5

            // tìm index của đối tượng có xuất xứ là "Trung Quốc"
            var ifound = products.FindIndex(x => x.Origin == "Trung Quốc");

            // tìm các sản phẩm có giá trên 100
            List<Product> p_100 = products.FindAll(product => product.Price > 100)

        + Muốn tùy biến cao hơn Delegate, để tìm kiếm theo tham số tùy chọn, có thể để Delegate trên vào lớp chức năng
            public class SearchNameProduct {
                string namesearch;
                public SearchNameProduct(string name) {
                    namesearch = name;
                }
                // Hàm gán cho delegage
                public bool search(Product p) {
                    return p.Name == namesearch;
                }
            }

            // Sử dụng
            Product pr1 = products.Find( (new SearchNameProduct("Glaxy 8")).search);        // Tìm sản phẩm có tên Glaxy 8
            Product pr2 = products.Find( (new SearchNameProduct("IPhone 6")).search);       // Tìm sản phẩm có tên IPhone 6

    - Sắp xếp
        + Để sắp xếp các phần tử trong danh sách, nếu phần tử đó có triển khai giao diện IComparable thì chỉ việc gọi Sort() để có danh sách theo thứ tự.
            products.Sort();

        + Có thể tùy biến cách thức sắp xếp bằng cách cung cấp hàm callback dạng deleage hai tham số kiểu cùng với kiểu phần tử cho Search
            products.Sort(
                (p1, p2) => {
                    if (p1.ID > p2.ID)
                        return 1;
                    else if (p1.ID == p2.ID)
                        return  0;
                    return   -1;
                }
            );

        !!! Trả về > 0 thì phần tử hiện tại xếp sau phần tử tham số

    - 1 số thuộc tính khác
        | Contains(obj) | kiểm tra có chứa phần tử obj |
        | Reverse()     | đảo thứ tự danh sách         |
        | ToArray()     | copy các phần tử ra mảng     |

## SortedList

    - Lớp SortedList<TKey, TValue> sắp xếp dữ liệu dựa trên một key, kiểu đề làm key là bất kỳ.

    - SortedList được định nghĩa ở namespace: System.Collections. Để sử dụng cần nạp
        using System.Collections;
        using System.Collections.Generic;

    - Một đối tượng dữ liệu lưu vào SortedList dưới dạng cặp key/value, truy cập đến phần tử thông qua key hoặc thông qua vị trí (index) của dữ liệu trong danh sách

    - Thuộc tính, phương thức
        | Count	                | Thuộc tính cho biết số phần tử                          |
        | [key]	                | Indexer truy cập đến phần tử có key                     |
        | Keys	                | Thuộc tính là danh sách các key trong danh sách sắp xếp |
        | Values	            | Thuộc tính lấy danh sách các giá trị trong danh sách    |
        | Add(key, value)	    | Thêm một phần tử vào danh sách                          |
        | Remove(key)	        | Xóa phần tử bằng key của nó                             |
        | Clear()	            | Loại bỏ tất cả các phần tử khỏi danh sách               |
        | ContainKey(key)	    | Kiểm tra có phần tử nào có khóa là key                  |
        | ContainValue(value)	| Kiểm tra có phần tử nào có giá trị là value             |
        | IndexOfKey(key)	    | Lấy chỉ số của phần tử có khóa là key                   |
        | IndexOfValue(value)	| Lấy chỉ số của phần tử có giá trị là value              |

        // Khởi tạo SortedList
        var products = new SortedList<string, string> ();
        products.Add ("Iphone 6", "P-IPHONE-6"); // Thêm vào phần tử mới (key, value)
        products.Add ("Laptop Abc", "P-LAP");
        products["Điện thoại Z"] = "P-DIENTHOAI"; // Thêm vào phần tử bằng Indexer
        products["Tai nghe XXX"] = "P-TAI";       // Thêm vào phần tử bằng Indexer

        // Duyệt qua các phần tử, mỗi phần tử lấy key/value lưu trong biến
        // kiểu KeyValuePair
        foreach (KeyValuePair<string, string> p in products) {
            Console.WriteLine ($"    {p.Key} - {p.Value}");
        }

        // Đọc value khi biết key
        string productName = "Tai nghe XXX";
        Console.WriteLine ($"{productName} có mã là {products[productName]}");

        // Cập nhật giá trị vào phần tử theo key
        products[productName] = "P-TAI-UPDATED";

        // Duyệt qua các giá trị
        foreach (var product_code in products.Values) {
            Console.WriteLine ($"--- {product_code}");
        }

        // Duyệt qua các key
        foreach (var product_name in products.Keys) {
            Console.WriteLine ($"... {product_name}");
        }

## Queue

    - Hàng đợi là mô hình FIFO (first in, first out - vào trước, ra trước hay đến trước được phục vụ trước)

    - .NET cung cấp lớp Queue<T> để giả quyết giải thuật hàng đợi

    - Thuộc tính, phương thức
        | Count	    | Thuộc tính lấy tổng số phần tử trong hàng                                         |
        | Enqueue	| vào xếp hàng - đưa phần tử vào cuối hàng đợi                                      |
        | Dequeue	| đọc - và loại ngay phần tử ở đầu hàng đợi - lỗi nếu hàng đợi không có phần tử nào |
        | Peek	    | đọc phần tử đầu hàng đợi                                                          |

        Queue<string> hoso_canxuly = new Queue<string> ();

        hoso_canxuly.Enqueue ("Hồ sơ A"); // Hồ sơ xếp thứ nhất trong hàng đợi
        hoso_canxuly.Enqueue ("Hồ sơ B"); // Hồ sơ xếp thứ hai
        hoso_canxuly.Enqueue ("Hồ sơ C");

        // Lấy hồ sơ xếp trước xử lý  trước, cho đến hết
        while (hoso_canxuly.Count > 0) {
            var hs = hoso_canxuly.Dequeue();
            Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
        }

        // Xử lý Hồ sơ A, còn lại 2
        // Xử lý Hồ sơ B, còn lại 1
        // Xử lý Hồ sơ C, còn lại 0

## Stack

    - Ngăn xếp là mô hình LIFO (last in, first out - vào sau thì ra trước)

    - .NET nó cung cấp lớp Stack<T> để thực hiện giải thuật ngăn xếp

    - Thuộc tính, phương thức
        | Count	    | Thuộc tính lấy tổng số phần tử trong hàng     |
        | Push	    | đẩy (thêm) một phần tử vào đỉnh stack         |
        | Pop	    | đọc - xóa phần tử đỉnh stack                  |
        | Peek	    | đọc phần tử đỉnh stack                        |
        | Contains	| kiểm tra một phần tử có trong stack hay không |

        Queue<string> hoso_canxuly = new Queue<string> ();

        hoso_canxuly.Enqueue ("Hồ sơ A"); // Hồ sơ xếp thứ nhất trong hàng đợi
        hoso_canxuly.Enqueue ("Hồ sơ B"); // Hồ sơ xếp thứ hai
        hoso_canxuly.Enqueue ("Hồ sơ C");

        // Lấy hồ sơ xếp trước xử lý  trước, cho đến hết
        while (hoso_canxuly.Count > 0) {
            var hs = hoso_canxuly.Dequeue();
            Console.WriteLine($"Xử lý {hs}, còn lại {hoso_canxuly.Count}");
        }

        // Bốc dỡ Sản phẩm C / còn lại 2
        // Bốc dỡ Sản phẩm B / còn lại 1
        // Bốc dỡ Sản phẩm A / còn lại 0

## LinkedList

    - .NET cung cấp lớp LinkedList<T> là loại danh sách liên kết kép (từ đây gọi tắt là danh sách liên kết)

    - Danh sách liên kết là một danh sách chứa các phần tử, mỗi phần tử trong loại danh sách này được gọi là một nút (Node). Mỗi nút ngoài dữ liệu của nút đó, nó sẽ gồm
    hai biến - một biến tham chiếu đến Node phía trước, một nút tham chiếu đến nút phía sau.

    !!! Danh sách liên kết .NET sử dụng là loại danh sách liên kết đôi

    - Thuộc tính, phương thức
        | List	             | Thuộc tính - tham chiếu (trỏ) đến LinkedList                                         |
        | Value	             | Thuộc tính - là dữ liệu của Node                                                     |
        | Next	             | Thuộc tính - tham chiếu (trỏ) đến NÚT tiếp theo (phía sau) - null thì nó là nút cuối |
        | Previous	         | Thuộc tính - tham chiếu (trỏ) đến NÚT phía trước - null thì nó là nút đầu tiên       |
        | Count	             | Số nút trong danh sách                                                               |
        | First	             | Nút đầu tiên của danh sách                                                           |
        | Last	             | Nút đầu tiên của danh sách                                                           |
        | AddFirst(T)	     | Chèn một nút có dữ liệu T vào đầu danh sách                                          |
        | AddLast(T)	     | Chèn một nút có dữ liệu T vào cuối danh sách                                         |
        | AddAfter(Node, T)	 | Chèn nút với dữ liệu T, vào sau nút Node (kiểu LinkedListNode)                       |
        | AddBefore(Node, T) | Chèn nút với dữ liệu T, vào trước nút Node (kiểu LinkedListNode)                     |
        | Clear()	         | Xóa toàn bộ danh sách                                                                |
        | Contains(T)	     | Kiểm tra xem có nút với giá trị dữ liệu bằng T                                       |
        | Remove(T)	         | Xóa nút có dữ liệu bằng T                                                            |
        | RemoveFirst()	     | Xóa nút đầu tiên                                                                     |
        | RemoveLast()	     | Xóa nút cuối cùng                                                                    |
        | Find(T)	         | Tìm một nút                                                                          |

        LinkedList<string> cacbaihoc = new  LinkedList<string>();

        cacbaihoc.AddFirst("Bài học 3");   // thêm vào đầu danh sach
        cacbaihoc.AddLast("Bài học 4");    // thêm vào cuối
        cacbaihoc.AddFirst("Bài học 2");
        cacbaihoc.AddFirst("Bài học 1");

        // Lấy phần tử đầu tiên, sau đó duyệt đến cuối
        LinkedListNode<string> node = cacbaihoc.First;
        while (node != null) {
            Console.WriteLine(node.Value);
            node = node.Next;   // node gán bằng nút sau nó
        }

        // Lấy phần tử cuối cùng, sau đó duyệt về phần tử đầu  tiên
        node = cacbaihoc.Last;
        while (node != null) {
            Console.WriteLine(node.Value);
            node = node.Previous;   // node gán bằng nút phía trước nó
        }

## Dictionary - SortedDictionary

    - Lớp Dictionary<Tkey,TValue> khá giống SortedList, Dictionary được thiết kế với mục đích tăng hiệu quả với tập dữ liệu lớn, phức tạp.

    - Một đối tượng dữ liệu lưu vào Dictionary dưới dạng cặp key/value, truy cập đến phần tử thông qua key hoặc thông qua vị trí (index) của dữ liệu trong danh sách

    - Thuộc tính, phương thức
        | Count	              | Thuộc tính cho biết số phần tử              |
        | [key]	              | Indexer truy cập đến phần tử có key         |
        | Keys	              | Thuộc tính là danh sách các key             |
        | Values	          | Thuộc tính lấy danh sách các giá trị        |
        | Add(key, value)	  | Thêm một phần tử vào Dictionary             |
        | Remove(key)	      | Xóa phần tử bằng key của nó                 |
        | Clear()	          | Loại bỏ tất cả các phần tử                  |
        | ContainKey(key)	  | Kiểm tra có phần tử nào có khóa là key      |
        | ContainValue(value) | Kiểm tra có phần tử nào có giá trị là value |

        // Khởi tạo với 2 phần tử
        Dictionary<string, int> sodem = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["tow"] = 2,
        };
        // Thêm hoặc cập nhật
        sodem["three"] = 3;

        var keys = sodem.Keys;
        foreach (var k in keys)
        {
            var value = sodem[k];
            Console.WriteLine($"{k} = {value}");
        }

    - SortedDictionary
        + Lớp SortedDictionary<Tkey,TValue> sử dụng, khai báo và khởi tạo ... giống như lớp Dictionary<Tkey,TValue>.

        + Nếu dùng SortedDictionary thì các các phần tử được lưu và sắp xếp theo key, thích hợp khi tăng tốc chèn, xóa, tìm kiếm theo key.

## HashSet

    - HashSet là tập hợp danh sách không cho phép trùng giá trị

    - HashSet<T> khác với các collection khác là nó cung cấp cơ chế đơn giản nhất để lưu các giá trị, nó không chỉ mục thứ tự và các phần tử không sắp xếp theo thứ tự nào

    - HashSet<T> cung cấp hiệu năng cao cho các tác vụ tìm kiếm, thêm vào, xóa bỏ ...

    - Thuộc tính, phương thức
        | Count	            | Thuộc tính cho biết số phần tử           |
        | Add(T)	        | Thêm phần tử vào HashSet                 |
        | Remove(T)	        | Xóa phần tử khỏi HashSet                 |
        | Clear()	        | Xóa tất cả các phần tử                   |
        | Contains(T)	    | Kiểm tra xem có phần tử trong HashSet    |
        | IsSubsetOf(c)	    | Kiểm tra xem có là tập con của HashSet c |
        | IsSupersetOf(c)	| Kiểm tra xem có chứa tập HashSet c       |
        | UnionWith(c)	    | Hợp với tập HashSet c                    |
        | IntersectWith(c)	| Giao với tập HashSet c                   |
        | ExceptWith(c)	    | Loại bỏ hết các phần tử chung với c      |

        HashSet>int< hashset1 = new HashSet>int<() {5,2,3,4};

        Console.WriteLine($"Phần tử trong hashset1 {hashset1.Count}");
        foreach (var v in hashset1)
        {
            Console.Write(v + " ");
        }

        HashSet>int< hashset2 = new HashSet>int<();
        hashset2.Add(3);
        hashset2.Add(4);
        if (hashset1.IsSupersetOf(hashset2))
            Console.WriteLine($"hashset1 là tập chứa hashset2");

## ObservableCollection

    - Lớp Generic ObservableCollection<T> là một tập hợp tương tự như List<T> ..., tức là nó mô tả một tập hợp dữ liệu có thể thay đổi số lượng bằng các phương thức quen thuộc như
    Add(), Remove(), Clear() ...

    - ObservableCollection<T> cung cấp thêm sự kiện thông báo nhi số lượng phần tử thay đổi như thêm, bớt ...(nghĩa là giám sát được biến động phần tử).

    - Các sự kiện event này có tên là CollectionChanged, trong tham số mà sự kiện gửi đến, e.Action có cho biết hành động thay đổi trên tập hợp là gì
        using System;
        using System.Collections;
        using System.Collections.Generic;
        using System.Collections.ObjectModel;
        using System.Collections.Specialized;
        namespace CS019_ObserableCollection
        {
            class Program
            {
                static void Main(string[] args)
                {
                    //Tạo tập hợp chứa các chuỗis
                    ObservableCollection obs = new ObservableCollection();

                    // Bắt sự kiện thi thay đổi obs
                    obs.CollectionChanged += change;

                    //Thay các phần tử tập hợp
                    obs.Add("ZTest1");
                    obs.Add("DTest2");
                    obs.Add("ATest3");
                    obs[2] = "AAAAA";

                    obs.RemoveAt(1);
                    obs.Clear();

                }

                // Phương thức nhận sự kiện CollectionChanged
                private static void change(object sender, NotifyCollectionChangedEventArgs e)
                {
                    switch (e.Action)
                    {
                        case NotifyCollectionChangedAction.Add:
                            foreach (String s in e.NewItems)
                                Console.WriteLine($"Thêm :  {s}");
                            break;

                        case NotifyCollectionChangedAction.Reset:
                            Console.WriteLine("Clear");
                            break;

                        case NotifyCollectionChangedAction.Remove:
                            foreach (String s in e.OldItems)
                                Console.WriteLine($"Remove :  {s}");
                            break;
                        case NotifyCollectionChangedAction.Replace:
                            Console.WriteLine("Repaced - " + e.NewItems[0]);
                        break;
                    }
                }
            }
        }

    - Ứng dụng của ObservableCollection trong WPF rất phổ biến khi binding với một controller như TreeView, ListView, DataGrid ... Khi đó việc thay đổi số phần tử trong tập hợp,
    thì hiện thị trong các controller cũng tự thêm / bớt ... theo

    - Khi kết hợp dùng INotifyPropertyChanged để xây dựng phần tử trong tập hợp, thì thay đổi thuộc tính của phần tử cũng tự động cập nhật vào các controller

    !!! Khi dùng ObservableCollection làm ItemSource cho các Controller trong WPF như TreeView, DataGrid ... thì nó đã tự động bắt các sự kiện CollectionChanged, PropertyChanged

    // WPF sẽ được nói tới sau

## IDisposable

    - Trong thư viện .NET đưa ra một giao diện interface có tên là IDisposable (System.IDisposable). Giao diện này chỉ có định nghĩa một phương thức:
        public void Dispose ();

    - Trong .NET hầu hết các loại tài nguyên là được quản lý bởi CLR của hệ thống .NET, nên các tài nguyên, đối tượng không còn tham chiếu đến nó sẽ tự động được CLR thu hồi (GC)

    - Vẫn có những loại tài nguyên mà CLR .NET không quản lý được như:
        + Mở file - stream
        + Các kết nối mạng, kết nối đến CSDL ...
        + Những vùng bộ nhớ không quản lý được, các font chữ ...

    - Với những loại tài nguyên này, .NET không biết tự giải phóng nó thế nào, nên phải có một cơ chế chủ động làm việc này khi không còn dùng đến nữa.

    - Mục đich code viết trong phương thức Dispose() là các thao tác để giải phóng các tài nguyên chiếm giữ - khi đối tượng bị hủy (cụ thể là các dữ liệu không được CLT quản lý)

    - Khi một lớp nào đó, triển khai giao diện IDisposable thì có thể dùng với using
        using (obj_1, obj_2 ... obj_n) {
            //các câu lệnh trong Using
        }

        + các obj_1, obj_2 ... là các đối tượng của những lớp triển khai giao diện IDisposabe
            class A : IDisposable {
                bool resource = true;
                public void Dispose() {
                    Console.WriteLine("Phương thức này gọi tự động khi hết using");
                    resource = false; // giải phóng tài nguyên
                }
            }

            // Sử dụng Using với lớp trên
            using (var a = new A()) {
                Console.WriteLine("Do something ...");
            }

            // Kết quả
            Do something ...
            Phương thức này gọi tự động khi hết using

    !!! phương thức Dispose() sẽ tự động chạy khi hết using

    - Khi sử dụng đối tượng triển khai IDisposable mà không dùng using, thì phải chủ động gọi thủ công Dispose khi tài nguyên không dùng đến

    - Khi một lớp vừa có hàm hủy vừa có Dispose() - tức triển khai IDisposable là: thao tác giải phóng tài nguyên có thể thực hiện hai lần - một lần khi ra khỏi
    using - một lần đối tượng mất tham chiếu. Hoặc khi đối tượng chủ động gọi Dispose nhiều lần. Điều này có thể dẫn đến lỗi.

    - Cách giải quyết là cần có biến lưu lại trạng thái cho biết Dispose đã được thi hành hay chưa.
        public class WriteData : IDisposable {
            // trường lưu trạng thái Dispose
            private bool m_Disposed = false;

            private StreamWriter stream;

            public WriteData (string filename) {
                stream = new StreamWriter (filename, true);
            }

            // Phương thức triển khai từ giao diện
            public void Dispose () {
                Dispose (true);
                GC.SuppressFinalize (this);
            }

            // Nếu disposing = true -> Được thi hành do gọi trực tiếp (do Dispose gọi) tài nguyên managed, unmanaged được giải phóng
            // nếu disposing = fale -> Được thi hành bởi phương thức hủy, chỉ cần giải phóng các tài nguyên unmanaged.
            protected virtual void Dispose (bool disposing) {
                if (!m_Disposed) {
                    if (disposing) {
                        // các đối tượng có Dispose gọi ở đây
                        stream.Dispose();
                    }

                    // giải phóng các tài nguyên không quản lý được cửa lớp (unmanaged)
                    m_Disposed = true;
                }
            }

            ~WriteData () {
                Dispose(false);
            }
        }

## File

    - DriveInfo (đọc thông tin ổ đĩa)
        + Thư viện .NET cung cấp lớp DriveInfo tại namespace System.IO giúp đọc thông tin các ổ đĩa có trong hệ thống

        + Phương thức DriveInfo.GetDrives() trả về mảng gồm các đối tượng DriveInfo, mỗi đối tượng chứa thông tin về một ổ đĩa

        + Thuộc tính
            | IsReady	         | true ổ đĩa ở trạng thái sẵn sàng (hoạt động) - ví dụ ổ đĩa CD nếu không có đĩa thì không sẵn sàng false |
            | DriveType	         | kiểu ổ đĩa (System.IO.DriveType) : CDRom, Fixed, Network, NoRootDirectory, Ram, Removable, Unknown      |
            | VolumeLabel	     | Nhãn đĩa                                                                                                |
            | DriveFormat	     | Chuỗi cho biết định dạng đĩa: NTFS, FAT32, FAT, devfs ...                                               |
            | AvailableFreeSpace | Số byte có hiệu lực còn trống (theo hạn ngạch người dùng)                                               |
            | TotalFreeSpace	 | Số byte còn trống                                                                                       |
            | TotalSize	         | Tổng số byte trên đĩa                                                                                   |

    - Path (hỗ trợ làm việc với đường dẫn)
        + Hỗ trợ quản lý, tạo các đường dẫn đến file, thư mục - nhất là hỗ trợ cross-platform (đa nền tảng) thì lớp tĩnh System.IO.Path chứa các phương thức (tĩnh) với mục đích đó

        + Thuộc tính, phương thức
            | Path.DirectorySeparatorChar | Thuộc tính chứa ký tự phân cách đường dẫn thư mục (\ trên Windows, / trên *nix)                                                  |
            | Path.PathSeparator	      | Thuộc tính chứa ký tự phân chia thư mục trong biến môi trường                                                                    |
            | Combine	                  | Kết hợp các chuỗi thành dường dẫn : var path = Path.Combine("home", "ReadMe.txt");    // "home/ReadMe.txt"                       |
            | ChangeExtension	          | Thay đổi phần mở rộng của đường dẫn : var path = Path.ChangeExtension("/home/abc/ReadMe.txt", "md");    // "/home/abc/ReadMe.md" |
            | GetDirectoryName	          | Lấy đường dẫn đến file (thư mục) : var path = Path.GetDirectoryName("/home/abc/zyz/ReadMe.txt");    // "/home/abc/zyz"           |
            | GetExtension	              | Lấy phần mở rộng : var path = Path.GetExtension("/home/ReadMe.txt");    // ".txt"                                                |
            | GetFileName	              | Lấy tên file : var path = Path.GetFileName("/home/abc/ReadMe.txt");    // "ReadMe.txt"                                           |
            | GetFileNameWithoutExtension | Lấy tên file : var path = Path.GetFileNameWithoutExtension("/home/ReadMe.txt");    // "ReadMe"                                   |
            | GetFullPath	              | Lấy đường dẫn đầy đủ - từ đường dẫn tương đối : var path = Path.GetFullPath("ReadMe.txt");                                       |
            | GetPathRoot	              | Lấy gốc của đường dẫn                                                                                                            |
            | GetRandomFileName	          | Tạo tên file ngẫu nhiên : var path = Path.GetRandomFileName();                                                                   |
            | GetTempFileName	          | Tạo file duy nhất, rỗng : var path = Path.GetTempFileName();                                                                     |

        + Lấy đường dẫn đến một số thư mục đặc biệt của hệ thống dùng Environment.GetFolderPath
            var path_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    - File
        + Lớp System.IO.File cung cấp cho bạn cách thức đơn giản để làm việc với các tệp

        + File.WriteAllText
            * Tạo ra file mới (nếu đã có file thì bị ghi đè), ghi vào nó một nội dung text, rồi đóng file luôn
                static void testWriteAllText () {
                    var filename = "test.txt";
                    string contentfile = "Xin chào! xuanthulab.net";

                    // Lấy thư mục Document của User trên hệ thống
                    var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    var fullpath = Path.Combine(directory_mydoc, filename);

                    File.WriteAllText (filename, contentfile);
                }

        + File.AppendAllText
            * Nối thêm nội dung vào nội dung có sẵn trong file thay vì ghi đè
                static void testAppendAllText() {
                    var filename = "test.txt";
                    string contentfile = "\nXin chào! xuanthulab.net - " + DateTime.Now.ToString ();

                    var directory_mydoc = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
                    var fullpath = Path.Combine (directory_mydoc, filename);

                    if (File.Exists (fullpath)) {
                        // File đã tồn tại - nối thêm nội dung
                        File.AppendAllText (fullpath, contentfile);
                    } else {
                        // tạo mới vì chưa tồn tại file
                        File.WriteAllText (fullpath, contentfile);
                    }
                }

        + File.ReadAllText : Đọc nội dung trong file
        + File.Create(filename) : tạo file
        + File.Delete(filename) : xóa file
        + File.Exists(filename) : kiểm tra file có tồn tại
        + File.Copy(path_src, path_des) : copy file
        + File.Move(path_src, path_des) : di chuyển file

    - Directory
        + Lớp System.IO.Directory cung cấp các phương thức chuyên tương tác với các thư mục

        + Phương thức
            | Exists(path)	        | Kiểm tra xem thư mục có tồn tại (true) hay không (false)                      |
            | CreateDirectory(path) | Tạo thư mục, trả về đối tượng System.IO.DirectoryInfo chứa thông tin thư mục. |
            | Delete(path)	        | Xóa thư mục.                                                                  |
            | GetFiles(path)	    | Lấy các file trong thư mục.                                                   |
            | GetDirectories(path)  | Lấy các thư mục trong thư mục.                                                |
            | Move(src, des)	    | Di chuyển thư mục.                                                            |

        + Ví dụ đệ quy liệt kê tất cả các file, thư mục con trong một thư mục
            static void ListFileDirectory(string path)
            {
                String[] directories = System.IO.Directory.GetDirectories(path);
                String[] files = System.IO.Directory.GetFiles(path);
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
                foreach (var directory in directories)
                {
                    Console.WriteLine(directory);
                    ListFileDirectory(directory); // Đệ quy
                }
            }

## Stream

    - Một luồng (stream) là một đối tượng được sử dụng để truyền dữ liệu

    - Khi dữ liệu truyền từ các nguồn bên ngoài vào ứng dụng ta gọi đó là đọc stream

    - Khi dữ liệu truyền từ chương trình ra nguồn bên ngoài ta gọi nó là ghi stream

    - Nguồn bên ngoài thường là các file, tuy nhiên tổng quát thì nó có thể từ nhiều loại như đọc/ghi dữ liệu thông qua một giao thức mạng để trao đổi dữ liệu với một máy remote khác

    - Một số stream chỉ cho đọc, một số chỉ cho ghi, một số lại cho phép truy cập nhẫu nhiên chứ không chỉ truy cập tuần tự (cho phép thay đổi vị trí con trỏ đọc dữ liệu trong luồng)

    - Lấy thông tin về stream - khi có đối tượng lớp System.IO.Stream có một số thuộc tính để tra cứu thông tin về stream

    - Thuộc tính
        | CanRead	   | Cho biết stream hỗ trợ việc đọc hay không                                                      |
        | CanWrite	   | Cho biết stream hỗ trợ việc ghi hay không                                                      |
        | CanSeek	   | Cho biết stream hỗ trợ dịch chuyển con trỏ hay không                                           |
        | CanTimeout   | Cho biết stream có đặt được time out                                                           |
        | Length	   | Cho biết kích thước (byte) của stream                                                          |
        | Position	   | Đọc hoặc thiết lập vị trí đọc (thiết lập thì stream phải hỗ trợ Seek)                          |
        | ReadTimeout  | Đọc hoặc thiết lập giá trị (mili giây) danh cho tác vụ đọc stream trước khi time out phát sinh |
        | WriteTimeout | Đọc hoặc thiết lập giá trị (mili giây) danh cho tác vụ ghi stream trước khi time out phát sinh |

    - Phương thức
        | ReadByte  | Đọc từng byte, trả về int (cast 1 byte) hoặc -1 nếu cuối file.                                                      |
        | Read	    | Đọc một số byte, từ vị trí nào đó, kết quả đọc lưu vào mảng byte. Trả về số lượng byte đọc được, 0 nếu cuối stream. |
        | WriteByte | Lưu 1 byte vào stream                                                                                               |
        | Write	    | Lưu mảng bytes vào stream                                                                                           |
        | Seek	    | Thiết lập vị trí trong stream                                                                                       |
        | Flush	    | Giải phóng các bộ đêm                                                                                               |

## FileStream

    - Lớp FileStream tạo ra các đối tượng để đọc và ghi dữ liệu ra file.

    - Để tạo ra một stream file, để trao đổi dữ liệu cần 4 thông tin:
        + path đường dẫn đến file

        + mode kiểu liệt kê FileMode, nó cho biết bạn muốn mở file như thế nào, như:
            FileMode.CreateNew : tạo file mới
            FileMode.Create : tạo mới, nếu file đang có bị ghi đè
            FileMode.Open : mở file đang tồn tại
            FileMode.OpenOrCreate : mở file đang tồn tại, tạo mới nếu không có
            FileMode.Truncate : mở file đang tồn tại và làm rỗng file
            FileMode.Append : mở file đang tồn tại và tới cuối file, hoặc tạo mới

        + access kiểu liệt kê FileAccess, cho biết muốn truy cập file như thế nào
            FileAccess.Read : chỉ đọc
            FileAccess.Write : chỉ ghi
            FileAccess.ReadWrite : đọc và ghi

        + share kiểu liệt kê FileShare, cho phép thiết lập chia sẻ truy cập file
            FileShare.None : không chia sẻ - tiến trình khác truy cập file sẽ lỗi cho đến khi tiến trình mở file đóng nó lại.
            FileShare.Read : cho tiến trình khác mở đọc file.
            FileShare.Write : cho tiến trình khác mở ghi file.
            FileShare.ReadWrite : cho tiến trình khác mở đọc ghi file.
            FileShare.Delete : cho tiến trình khác xóa file.

    - Lớp File hỗ trợ tạo FileStream. File.OpenRead(filename) tạo stream để đọc, File.OpenWrite(filename) tạo stream để ghi.

    - Lấy thông tin về stream
        + khi có đối tượng lớp System.IO.Stream có một số thuộc tính để tra cứu thông tin về stream
            | Name          | Trả về đường dẫn của stream                                                                                                             |
            | Length        | Khi được ghi đè trong lớp dẫn xuất, lấy chiều dài của dòng tính bằng byte                                                               |
            | Position      | Khi được ghi đè trong lớp dẫn xuất, lấy hoặc đặt vị trí hiện tại trong dòng                                                             |
            | CanRead       | Cho biết liệu dòng có hỗ trợ đọc hay không                                                                                              |
            | CanWrite      | Cho biết liệu dòng có hỗ trợ ghi hay không                                                                                              |
            | CanSeek       | Cho biết liệu dòng có hỗ trợ tìm kiếm (seeking) hay không, tức là liệu có thể đặt vị trí hiện tại trong dòng hay không                  |
            | CanTimeout    | Cho biết liệu dòng có hỗ trợ timeout khi đọc và ghi hay không                                                                           |
            | ReadTimeout   | Khi được ghi đè trong lớp dẫn xuất, lấy hoặc đặt khoảng thời gian (tính bằng mili giây) mà dòng sẽ cố gắng đọc trước khi timeout xảy ra |
            | WriteTimeout  | Khi được ghi đè trong lớp dẫn xuất, lấy hoặc đặt khoảng thời gian (tính bằng mili giây) mà dòng sẽ cố gắng ghi trước khi timeout xảy ra |

    - Encodeing file text (mã hóa file text)
        + Khi đọc các file text (không phải file nhị phân), đầu tiên cần xác định encoding của nó (UTF8, Unicode, UTF32 ...)

        + Thông tin về encoding được lưu ở vài byte đầu tiên của file nó gọi là BOM - Preamble
        // BOM (byte order mark) sẽ được tìm hiểu trong ExpandedKnowledge.txt

        + Tùy thuộc vào giá trị của khoảng 5 byte đầu tiên này mà xác định được encoding.
            public static Encoding GetEncoding (Stream stream) {
                byte[] BOMBytes = new byte[4]; // mảng chứa 4 byte để làm bộ nhớ lưu byte đọc được
                int offset = 0; // vị trí (index) trong buffer - nơi ghi byte đầu tiên đọc được
                int count = 4; // đọc 4 byte
                int numberbyte = stream.Read (BOMBytes, offset, count); // bắt đầu đọc 4 đầu tiên lưu vào buffer

                if (BOMBytes[0] == 0xfe && BOMBytes[1] == 0xff) {
                    stream.Seek (2, SeekOrigin.Begin); // Di chuyển về vị trí bắt đầu của dữ liệu (đã trừ BOM)
                    return Encoding.BigEndianUnicode;
                }
                if (BOMBytes[0] == 0xff && BOMBytes[1] == 0xfe) {
                    stream.Seek (2, SeekOrigin.Begin); // Di chuyển về vị trí bắt đầu của dữ liệu (đã trừ BOM)
                    return Encoding.Unicode;
                }

                if (BOMBytes[0] == 0xef && BOMBytes[1] == 0xbb && BOMBytes[2] == 0xbf) {
                    stream.Seek (3, SeekOrigin.Begin);
                    return Encoding.UTF8;
                }
                if (BOMBytes[0] == 0x2b && BOMBytes[1] == 0x2f && BOMBytes[2] == 0x76) {
                    stream.Seek (3, SeekOrigin.Begin);
                    return Encoding.UTF7;
                }
                if (BOMBytes[0] == 0xff && BOMBytes[1] == 0xfe && BOMBytes[2] == 0 && BOMBytes[3] == 0) {
                    stream.Seek (4, SeekOrigin.Begin);
                    return Encoding.UTF32;
                }
                if (BOMBytes[0] == 0 && BOMBytes[1] == 0 && BOMBytes[2] == 0xfe && BOMBytes[3] == 0xff) {
                    stream.Seek (4, SeekOrigin.Begin);
                    return Encoding.GetEncoding (12001);
                }

                stream.Seek (0, SeekOrigin.Begin);
                return Encoding.Default;
            }

        + ASCII dùng 7 bit biểu diễn các ký tự - đủ biểu diễn bảng chữ cái tiếng Anh (in hoa, thường, số ký tự đặc biệt) - 1 byte biểu diễn 1 ký tự

        + UTF-16 dùng 2 byte biểu diễn 1 ký tự

        + UTF-32 dùng 4 byte biểu diễn 1 ký tự

        + UTF-8 (dùng nhiều ngày nay) - dùng biến để xác định bao nhiêu byte cho mỗi ký tự cụ thể - mỗi ký tự có thể từ 1 - 6 byte

    - Ghi file text
        + Ghi file text (tạo mới, ghi đè) - chọn file có Encoding UTF8

        + Đầu tiên phải ghi các bytes BOM, lấy mảng bytes DOM bằng cách gọi encoding.GetPreamble()

        + Sau đó chuyển chuỗi thành mảng bytes (đã encoding) - rồi lưu ra stream bằng Write
            using (var stream = new FileStream( path:filepath, mode: FileMode.Create, access: FileAccess.Write, share: FileShare.None))
            {
                //Write BOM - UTF8
                Encoding encoding = Encoding.UTF8;
                byte[] bom = encoding.GetPreamble();
                stream.Write(bom, 0, bom.Length);

                string s1 = "Xin chào các bạn! \n";
                string s2 = "Ví dụ - ghi file text bằng stream";

                // Encode chuỗi - lưu vào mảng bytes
                byte[] buffer = encoding.GetBytes(s1);
                stream.Write(buffer, 0, buffer.Length);  // lưu vào stream

                buffer = encoding.GetBytes(s2);
                stream.Write(buffer, 0, buffer.Length);  // lưu vào stream
            }

    - Đọc file text
        + Đầu tiên xác định Encoding của file text

        + Sau đó đọc từng khối byte vào buffer (mảng byte), rồi thực hiện Encoding để xác định chuỗi
            int SIZEBUFFER = 256;
            using (var stream = new FileStream( path:filepath, mode: FileMode.Open, access: FileAccess.ReadWrite, share: FileShare.Read))
            {
                Encoding encoding = GetEncoding(stream);
                Console.WriteLine(encoding.ToString());
                byte[] buffer = new byte[SIZEBUFFER];
                bool endread = false;
                do
                {
                    int numberRead = stream.Read(buffer, 0, SIZEBUFFER);
                    if (numberRead == 0) endread = true;
                    if (numberRead < SIZEBUFFER)
                    {
                        Array.Clear(buffer, numberRead, SIZEBUFFER - numberRead);
                    }
                    string s = encoding.GetString(buffer, 0, numberRead);
                    Console.WriteLine(s);
                } while (!endread);
            }

    - Copy file text
        + Tạo 2 stream, một để đọc - một để lưu
            int SIZEBUFFER = 5;   // tăng lên đọc sẽ nhanh
            using (var streamwrite = File.OpenWrite(filepath_des))
            using (var streamread = File.OpenRead(filepath_src))
            {
                byte[] buffer = new byte[SIZEBUFFER];
                bool endread = false;
                do
                {
                    int numberRead = streamread.Read(buffer, 0, SIZEBUFFER);
                    if (numberRead == 0) endread = true;
                    else {
                        streamwrite.Write(buffer, 0, numberRead);
                    }
                } while (!endread);
            }

## LINQ (ngôn ngữ truy vấn tích hợp)

    - LINQ (Language Integrated Query) - ngôn ngữ truy vấn tích hợp - tích hợp cú pháp truy vấn (gần giống các câu lệnh SQL) vào bên trong ngôn ngữ lập trình C#,
    cho C# khả năng truy cập các nguồn dữ liệu khác nhau (SQL Db, XML, List ...) với cùng cú pháp.

    - LINQ hoạt động trên những kiểu tập hợp có khả năng duyệt qua

    - Nguồn dữ liệu phục vụ cho LINQ, phải là các đối tượng lớp triển khai giao diện (interface) IEnumerable và IEnumerable<T> tức là các mảng, danh sách thuộc Collection

    - Câu truy vấn LINQ thường bắt đầu bằng mệnh đề from và kết thúc bằng mệnh đề select hoặc group, giữa chúng là những mệnh đề where, orderby, join, let

    - from in
        + Mệnh đề from để xác định nguồn dữ liệu mà truy vấn sẽ thực hiện

        + Nguồn dữ liệu là tập hợp những phần tử lưu trong đối tượng có kiểu lớp triển khai giao diện IEnumerable như mảng Array, List ...
            from [biến chứa] in [nguồn dữ liệu]

    - select
        + Mệnh đề select chỉ ra các dữ liệu được lấy ra (xuất ra) của câu lệnh LINQ
            var ketqua = from product in products
            // trả về collection gồm các phần tử Product
            select product;

            // trả về một collection gồm các phần tử chuỗi
            select product.Name;

            // trả về những đối tượng phức tạp mà dữ liệu được trích xuất ra from ... in ... hay những dữ liệu do tính toán ...
            select new {
                ten = product.Name.ToUpper(),
                mausac = string.Join(',', product.Colors)
             };

    - where
        + Mệnh đề where để lọc dữ liệu, sau từ khóa where là biểu thức logic xác định các phần tử lọc ra
            where product.Price == 500

            where (product.Price >= 600 && product.Price < 700) || product.Name.StartsWith("Bàn")

        + Trong một truy vấn có thể viết nhiều mệnh đề where
            var ketqua = from product in products
                where product.Price >= 500
                where product.Name.StartsWith("Giường")
                select product;

    - from kết hợp
        + Để lọc dữ liệu phức tạp hơn, có thể dùng From kết hợp để lọc phức tạp và chi tiết hơn
            var ketqua = from product in products
                from color in product.Colors   // product.Colors là 1 thuộc tính danh sách các màu sắc của 1 phần tử
                where product.Price < 500
                where color == "Vàng"
                select product;

    - orderby
        + Mệnh đề orderby viết sau mệnh đề where nếu có, dùng để sắp xếp kết quả
            orderby thuoctinh  // sắp xếp tăng dần
            orderby thuoctinh descending  // sắp xếp giảm dần

        + Cũng có thể sắp xếp theo nhiều dữ liệu, viết cách nhau bởi ,
            orderby thuoctinh1 descending, thuoctinh2, thuoctinh3 descending ...

    - group by
        + Mệnh đề group được dngf thay cho mệnh đề select

        + Trả về theo từng nhóm (nhóm lại theo trường dữ liệu nào đó), mỗi phần tử của cấu truy vấn trả về là kiểu IGrouping<TKey,TElement>, chứa các phần tử thuộc một nhóm
            var ketqua = from product in products
                where product.Price >=400 && product.Price <= 500
                group product by product.Price;

            // 400
            //     Bàn trà - 400
            //     Tranh treo - 400
            // 500
            //     Đèn trùm - 500
            //     Giường ngủ - 500

        + Sử dụng into để lưu tạm group trong truy vấn vào một biến, sau đó thi hành các mệnh đề khác trên biến tạm và dùng mệnh đề select để trả về kết quả
            var ketqua = from product in products
                where product.Price >=400 && product.Price <= 500
                group product by product.Price into gr
                orderby gr.Key descending
                select gr;

    - let
        + let dùng để thêm biến vào LINQ, lưu kết quả của một biểu thức tính toán nào đó
            let tenvien = biểu_thức

            var ketqua = from product in products                  // các sản phẩm trong products
             group product by product.Price into gr    // nhóm thành gr theo giá
             let count = gr.Count()                    // số phần tử trong nhóm
             select new {                              // trả về giá và số sản phầm có giá này
                price = gr.Key,
                number_product = count
             };

    - join
        + join là thực hiện kết hợp hai nguồn dữ liệu lại với nhau để truy vấn thông tin

        + Để kết nối, dùng mệnh đề join để chỉ ra nguồn (nguồn bên phải join) sẽ kết nối với nguồn của from (nguồn bên trái join), tiếp theo chỉ ra sự dàng buộc các phần tử bằng từ khóa on
            var ketqua = from product in products
                join brand in brands on product.Brand equals brand.ID
                select new {
                    name  = product.Name,
                    brand = brand.Name,
                    price = product.Price
                };

        !!! join trong C# là kiểu inner join (tức giá trị liên kết có ở cả 2 nguồn)
        // Đọc thêm về join trong CTDL-SQL.txt

        + Nếu muốn sử dụng join như kiểu left join có nghĩa nguồn bên trái lấy không phụ thuộc vào bên phải thì lấy thêm DefaultIfEmpty() của nguồn bên trái
            var ketqua = from product in products
                join brand in brands on product.Brand equals brand.ID into t
                from brand in t.DefaultIfEmpty()
                select new {
                    name  = product.Name,
                    brand = (brand == null) ? "NO-BRAND" : brand.Name,
                    price = product.Price
                };

## Asynchronous

    - Lập trình bất đồng bộ (asynchronous) là một cách thức mà khi gọi nó chạy ở chế độ nền (liên quan đến một tiến trình, task), trong khi đó tiến trình gọi nó không bị khóa - block

    - Trong .NET có triển khai một số mô hình lập trình bất đồng bộ như Asynchronous pattern, mẫu bất đồng bộ theo sự kiện và theo tác vụ (TAP - task-based asynchronous pattern)

    - .NET có thư viện tên Task Parallel Library (TPL) - TPL giúp lập trình chạy song song (đa luồng) dễ dàng hơn. Trong C# đồng thời có thêm vào hai từ khóa là async và await, đây
    là hai từ khóa chính để sử dụng trong lập trình bất đồng bộ.

    - synchronous
        + Bình thường, khi lập trình gọi một phương thức nào đó thì phương thức đó chạy và kết thúc thì các dòng code tiếp theo sau lời gọi phương thức đó mới được thực thi, đó là
        chạy đồng bộ, có nghĩa là thread gọi phương thức bị khóa lại cho đến khi phương thức kết thúc

        + Việc khóa thread thực hiện hàm làm cho các dòng code tiếp theo phải chờ, nếu hàm đó thi hành mất nhiều thời gian (đặc biệt là các thao tác đọc stream - đọc file, kết nối
        web, kết nối CSDL ...) - trong khi tài nguyên vẫn đủ để làm các việc khác - thì chương trình vẫn cứ phải chờ phương thức trên kết thúc thì mới thi hành được tác vụ khác,
        đặt biệt là khi gọi phương thức trong các tiến trình UI, giao diện người dùng không tương tác được.

        + Để giải quyết vấn đề này, chương trình vẫn thi hành được các tác vụ khác thì cần đến kỹ thuật lập trình bất đồng bộ (trước đây gọi là lập trình đa tiến trình, đa luồng)

    - Task
        + Lớp Task nó biểu thị tác vụ bất đồng bộ, từ đó ta chạy được code bất đồng bộ

        + Nếu tác vụ bất đồng bộ đó thi hành xong có kiểu trả về thì dùng Task<T> với T là kiểu trả về
            using System.Threading;
            using System.Threading.Tasks;

        + Để tạo ra một Task cần tham số là một hàm delegate ( Func hoặc Action)
            // Nếu myfunc trả về kiểu T (tức là một Func)
            Func<T> myfunc = () => {
                // code ...
                return ...;
            };
            Task<T> task = new  Task<T>(myfunc);

            // object là đối tượng tham số truyền cho myfunc
            Func<object, T> myfunc = (object thamso) => {
                // code ...
                return ...;
            };
            Task<T> task = new  Task<T>(myfunc, thamso);

            // Nếu myfunc không trả về giá trị (tức là Action)
            Action myfunc = () => {
                // code ...
            };
            Task task = new  Task(myfunc);

        + Start() : phương thức để chạy Task của đối tượng

        + Result : thuộc tính kết quả trả về

        + Wait() : chờ cho task hoàn thành

    - async, await
        + Khi muốn lấy kết quả của Task, thì trả về thuộc tính Result. Nhưng điều này làm cho thread chạy Task bị khóa lại vì Result sẽ trả về khi Task hoàn thành.
        Điều này làm mất đi lợi ích đa luồng và bất đồng bộ

        + Để có thể trả về ngay lập tức mà không khóa thread của Task đó lại thì dùng đến cặp từ khóa async và await

        + Thêm vào khai báo tên hàm từ khóa async, nó cho trình biên dịch biết đây là hàm bất đồng bộ - khi gọi nó - nó trả về ngay lập tức

        + Trong thân của hàm, phải có đoạn code chờ task hoàn thành
            public static async Task<T> async (thamso){
                // code ...
                await task;
                // code ...
            }

        + code phía sau await chỉ được chạy khi Task chạy xong

        !!! await phải dùng với Task và chỉ được viết trong hàm có khai báo async

        !!! Có thể hình dung khi hàm được gọi để thực thi thì nó sẽ tạo ra thread (luồng) để thực thi các Task (hàm, công việc trong hàm), hàm main cũng có thread để chạy
        và đó là thread chính của chương trình. Trong chương trình đồng bộ thì các hàm cùng chạy trên 1 thread chính của hàm main (nói đúng hơn là thread chính bị chuyển
        hướng sang chạy thread của hàm được gọi), còn trong chương trình bất đồng bộ thì hàm nào chạy thread hàm đó.

        + Khi khai báo hàm với async nến tránh dùng kiểu trả về void (dù được phép, không await được) mà hãy dùng Task nếu không có kiểu trả về hoặc Task<T> khi có kiểu trả về T

        + Do 1 phương thức cũng là 1 task, nên có thể await ở 1 phương thức async khác thì phương thức đó cũng phải là async

    - CancellationToken
        // bổ sung sau

## Multi thread sử dụng Parallel chạy song song

    - Parallel
        + Lớp Parallel thuộc namespace System.Threading.Tasks, nó trừu tượng hóa các thread, lớp này có phương thức tĩnh Parallel.For, Parallel.ForEach để thực hiện
        vòng lặp for và foreach để chạy song song các tác vụ

        + Parallel.Invoke để thực hiện một Action có khả năng chạy song song

    - Parallel.For
        + Parallel.For có nhiều quá tải
            ParallelLoopResult result = Parallel.For(i1, i2, task);

        + Vòng lặp chạy (biến chạy) từ số nguyên i1 đến i2, mỗi lần lặp nó sẽ thực hiện Action task, task là một delegate, kiểu Action<int> có nghĩa nó làm phương thức
        trả về void, có một tham số kiểu int, tham số này là biến chạy
            Action<int> action = (int x) => {
                // Doing somthing here ...
            };

        + result đối tượng lớp ParallelLoopResult trả về từ Paralell.For, thuộc tính ParallelLoopResult.IsCompleted cho biết vòng lặp đã được duyệt qua hết, tất cả các task đã khởi chạy.

        + Lệnh Parallel.For khởi chạy song song nhiều tác vụ (thời điểm bắt đầu của mỗi tác vụ không giống nhau, có những tác vụ đã kết thúc thì tác vụ sau mới chạy, nó có thể
        phụ thuộc vào tài nguyên hệ thống RAM, CPU ...)

        + Một task nó có chạy trên một thread nào đó (chứ không phải mỗi task một thread), một thread có thể sử dụng bởi nhiều task

        + Bản thân vòng lặp Parallel.For, khi các Action chạy, mặc dù chúng chạy trên những Task và Thread, nhưng khi tất cả các Action hoàn hành thì vòng lặp mới hoàn thành.
        Dẫn đến Parallel.For khóa(block) thread gọi nó. Để không bị khóa, có thể chuyển các Action là async

    - Parallel.ForEach
        + Cũng giống với Parallel.For nhưng duyệt qua các Collection tương tự như vòng lặp foreach
            ParallelLoopResult result = Parallel.ForEach(source, RunTask);

        + Trong đó source là một Collection như mảng, List. RunTask là Action, có 1 tham số có kiểu giống kiểu phần tử trong source, giá trị tham số này là giá trị phần tử
        trong source trong mỗi vòng lặp

    - Parallel.Invoke
        + Với For và ForEach, thì các tác vụ định nghĩa trọng một Action, nhưng nếu muốn chạy song song nhiều loại Action (phương thức) một lúc thì dùng Paralell.Invoke
            Parallel.Invoke(action1, action2, action3);

    !!! Tóm lại Parallel là để chạy đa luồng nhiều action
        + For là duyệt các kiểu nguyên thủy truyền vào action
        + ForEach là duyệt các kiểu collection truyền vào action
        + Invoke là dùng cho danh sách các action khác nhau

## Type

    - Lớp Type dùng để biểu thị sự khai báo của: định nghĩa của lớp, mảng, enum, interface ...
        ob = new ...
        Type type = ob.GetType();
        // hoặc
        Type type = typeof(kiểu dữ liệu);

    - Lớp Type với các phương thức, thuộc tính của nó, nó trở thành lớp cơ bản của kỹ thuật Reflection trong .Net

    - Thuộc tính
        | Assembly      | Lấy đối tượng Assembly chứa khai báo cho kiểu hiện tại.                                           |
        | BaseType      | Lấy đối tượng Type đại diện cho lớp cơ sở trực tiếp của kiểu hiện tại.                            |
        | FullName      | Lấy tên đầy đủ của kiểu, bao gồm cả không gian tên.                                               |
        | Namespace     | Lấy không gian tên của kiểu hiện tại.                                                             |
        | IsClass       | Trả về giá trị boolean cho biết liệu kiểu hiện tại có phải là lớp hay không.                      |
        | IsInterface   | Trả về giá trị boolean cho biết liệu kiểu hiện tại có phải là interface hay không.                |
        | IsValueType   | Trả về giá trị boolean cho biết liệu kiểu hiện tại có phải là kiểu giá trị hay không.             |
        | IsEnum        | Trả về giá trị boolean cho biết liệu kiểu hiện tại có phải là kiểu liệt kê (enum) hay không.      |
        | IsAbstract    | Trả về giá trị boolean cho biết liệu kiểu hiện tại có phải là lớp trừu tượng hay không.           |
        | IsSealed      | Trả về giá trị boolean cho biết liệu kiểu hiện tại có phải là lớp sealed hay không.               |
        | IsGenericType | Trả về giá trị boolean cho biết liệu kiểu hiện tại có phải là kiểu tổng quát (generic) hay không. |
        | Name          | Lấy tên của kiểu.                                                                                 |

    - Phương thức
        | GetMethods()                 | Trả về một mảng các đối tượng MethodInfo đại diện cho tất cả các phương thức công khai của kiểu hiện tại.   |
        | GetMethod(string name)       | Trả về một đối tượng MethodInfo đại diện cho phương thức công khai có tên xác định.                         |
        | GetProperties()              | Trả về một mảng các đối tượng PropertyInfo đại diện cho tất cả các thuộc tính công khai của kiểu hiện tại.  |
        | GetProperty(string name)     | Trả về một đối tượng PropertyInfo đại diện cho thuộc tính công khai có tên xác định.                        |
        | GetFields()                  | Trả về một mảng các đối tượng FieldInfo đại diện cho tất cả các trường (field) công khai của kiểu hiện tại. |
        | GetField(string name)        | Trả về một đối tượng FieldInfo đại diện cho trường công khai có tên xác định.                               |
        | GetInterfaces()              | Trả về một mảng các đối tượng Type đại diện cho tất cả các giao diện được triển khai bởi kiểu hiện tại.     |
        | GetConstructor(Type[] types) | Trả về một đối tượng ConstructorInfo đại diện cho constructor có tham số xác định.                          |
        | IsAssignableFrom(Type c)     | Xác định xem một phiên bản của kiểu hiện tại có thể được gán cho một biến của kiểu đã xác định.             |

    - Đối tượng PropertyInfo được trả về từ hàm GetProperty có thể đọc giá trị và thiết lập giá trị các thuộc tính mà đối tượng chứa
        //Lấy tên và giá trị các thuộc tính có trong a
        foreach (PropertyInfo property in a.GetType().GetProperties())
        {
            string property_name = property.Name;         // Lấy tên thuộc tính
            object property_value = property.GetValue(a); // Đọc giá trị thuộc tính đối tượng a
            Console.WriteLine($"Thuộc tính {property_name} giá trị là {property_value}");
        }

## Attribute Annotation

    - Một thuộc tính chú thích (Annotation / Attribute) tác động vào một thành phần nào đó của chương trình (lớp, phương thức, thuộc tính) - là một phần của siêu dữ liệu
    (metadata - loại dữ liệu cung cấp thêm thông tin về đối tượng nào đó)

    - Annotation giúp thêm thông tin vào lớp, phương thức, thuộc tính những đoạn code mở rộng

    !!! Tính năng này trong Java gọi là Annotation, trong C# gọi là Attribute.

    - Các thuộc tính chú thích có thể được truy xuất tra cứu ở thời điểm thực thi bằng kỹ thuật gọi là reflection

    - Để sử dụng chỉ cần viết tên Attribute trong dấu [] trước đối tượng áp dụng như lớp, phương thức, thuộc tính lớp (có tham số như hàm, nếu Attribute đó yêu cầu).
        [AttributeName(param1, param2 ...)]

        public class MyClass {
            [Obsolete ("Phương thức này lỗi thời, hãy  dùng phương thức Abc")]      // Obsolete đánh dấ 1 thành phần nào đó đã lạc hậu
            public static void Method1 () {
                Console.WriteLine ("Phương thức chạy");
            }
        }
        // nếu sử dụng phương thức Method1 thì trình biên dịch sẽ đưa ra cảnh báo do đã Obsolete

    - Để tạo Attribute chỉ cần tạo 1 lớp kế thừa từ System.Attribute
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]     // xác định Attribute sẽ được áp dụng cho thành phần nào
        public class MotaAttribute : Attribute      // có thể đặt tên Mota thay cho MotaAttribute
        {
            // Phương thức khởi tạo
            public MotaAttribute(string v) => Description = v;

            public string Description {set; get;}
        }

        // áp dụng
        [MotaAttribute("Lớp biểu diễn người dùng")]                  // thêm Attribute cho lớp
        public class User
        {
            [MotaAttribute("Thuộc tính lưu tuổi")]                   // thêm Attribute cho thuộc tính lớp
            public int age {set; get;}

            [MotaAttribute("Phương thức này hiện thị age")]          // thêm Attribute cho phương thức
            public void ShowAge() {}
        }

    - Để đọc Attribute sử dụng Type trên đối tượng với phương thức GetCustomAttributes
        var a = new User ();

        // Đọc các Attribute của lớp
        foreach (Attribute attr in a.GetType ().GetCustomAttributes (false)) {
            MotaAttribute mota = attr as MotaAttribute;
            if (mota != null) {
                Console.WriteLine ($"{a.GetType().Name,10} : {mota.Description}");
            }
        }

        // Đọc Attribute của từng thuộc tính lớp
        foreach (var thuoctinh in a.GetType ().GetProperties ()) {
            foreach (Attribute attr in thuoctinh.GetCustomAttributes (false)) {
                MotaAttribute mota = attr as MotaAttribute;
                if (mota != null) {
                    Console.WriteLine ($"{thuoctinh.Name,10} : {mota.Description}");
                }
            }
        }

        // Đọc Attribute của phương thức
        foreach (var m in a.GetType ().GetMethods ()) {
            foreach (Attribute attr in m.GetCustomAttributes (false)) {
                MotaAttribute mota = attr as MotaAttribute;
                if (mota != null) {
                    Console.WriteLine ($"{m.Name,10} : {mota.Description}");
                }
            }
        }

        !!! Tham số bool truyền vào GetCustomAttributes để xác định có lấy các thuộc tính kế thừa từ lớp cơ sở không

    - Data Annotation / Attribute
        + Các Data Annotation/Attribute trong C# định nghĩa trong namespace System.ComponentModel.DataAnnotations
            * Các Attribute để kiểm tra dữ liệu (Validation Attribute)
            * Các Attribute hiện thị (Display Attribute), điều khiển dữ liệu trong lớp hiện thị thế nào trong UI
            * Modelling Attribute

        | Required	    | Dữ liệu phải được thiết lập (!=null)                                                                          |
        |               | [Required (ErrorMessage="{0} cần thiết lập")]                                                                 |
        | StringLength	| Thiết lập độ dài trường dữ liệu                                                                               |
        |               | [StringLength (20,MinimumLength=3, ErrorMessage="Phải dài 3 đến 20 ký tự")]                                   |
        | DataType	    | Chỉ ra dữ liệu phải liên kết phù hợp với một kiểu nào đó                                                      |
        |               | [DataType(DataType.Text)]                                                                                     |
        |               | [DataType(DataType.PhoneNumber)]                                                                              |
        |               | [DataType(DataType.EmailAddress)]                                                                             |
        |               | /.. Date, DateTime, Html, ImageUrl, MultilineText, Password, Time, Url                                        |
        | Range	        | Chỉ ra dữ liệu phải trong khoảng nào đó                                                                       |
        |               | [Range(18,99, ErrorMessage="Tuổi từ 18 đến 99")]                                                              |
        |               | [Range(typeof(DateTime), "1/2/2004", "3/4/2004", ErrorMessage = "Value for {0} must be between {1} and {2}")] |
        | Phone	        | [Phone] dữ liệu phải là dạng số điện thoại                                                                    |
        | EmailAddress	| [EmailAddress] dữ liệu phải là dạng email                                                                     |

    - Để kiểm tra các dữ liệu phù hợp thiết lập bởi Attribute, thì dùng lớp ValidationContext
        ValidationContext context = new ValidationContext(user, null, null);

        // results - lưu danh sách ValidationResult, kết quả kiểm tra
        List<ValidationResult> results = new List<ValidationResult>();

        // thực hiện kiểm tra dữ liệu
        bool valid = Validator.TryValidateObject(user, context, results, true);

## Dependency injection (DI)

    - Dependency (phụ thuộc)
        + Lớp classA có sử dụng một chức năng từ đối tượng lớp classB (classA hoạt động dựa vào classB). Lúc đó classB gọi là phụ thuộc (dependency) của classA

    - Inversion of Control (IoC) / Dependency inversion
        + Inversion of Control (IoC - Đảo ngược điều khiển) là một nguyên lý thiết kế trong công nghệ phần mềm trong đó các thành phần nó dựa vào để làm việc bị đảo ngược quyền điều
        khiển khi so sánh với lập trình hướng thủ thục truyền thống

    - Hoạt động của IoC
        + Truyền thống : Có lớp class A có sử dụng một chức năng (gọi hàm ào đó) của class B, lớp class B lại tham chiếu và gọi các chức năng có trong class C. Ta thấy class A dựa vào
        class B để hoạt động, class B dựa vào class C. Nên class A có tham chiếu trực tiếp (cứng) đến class B và trong class B có tham chiếu đến class C

        + IoC : Ở thời điểm thực thi thì class A vẫn gọi được hàm có class B, class B vẫn gọi hàm có class C nghĩa là kết quả không đổi. Tuy nhiên, khi thiết kế ở thời điểm viết code
        (trong code) class A không tham chiếu trực tiếp đến class B mà nó lại sử dụng interface (hoặc lớp abstruct) mà classB triển khai. Điều này dẫn tới sự phụ thuộc lỏng lẻo giữa
        classA và classB

        !!! Hiểu đơn giản cách truyền thống thì lớp phụ thuộc (A) tham chiếu trực tiếp đên lớp bị thuộc (B,C) còn IoC thì lớp phụ thuộc (A) sẽ tham chiếu đến 1 Interface hoặc lớp abstruct
        nên A sẽ phụ thuộc vào lớp triển khai interface hoặc lớp abstruct chứ không tham chiếu trực tiếp đến 1 đối tượng cự thể. Việc này làm cho code dễ quản lý, sửa đổi

    - Dependency injection (DI) là một kỹ thuật trong lập trình, là một hình thức cụ thể của Inverse of Control (Dependency Inverse)

    - DI thiết kế sao cho các dependency (phụ thuộc) của một đối tượng CÓ THỂ được đưa vào, tiêm vào đối tượng đó (Injection) khi nó cần tới (khi đối tượng khởi tạo)
        + Xây dựng các lớp (dịch vụ) có sự phụ thuộc nhau một cách lỏng lẻo, và dependency có thể tiêm vào đối tượng (injection) - thường qua phương thức khởi tạo constructor, property, setter

        + Xây dựng được một thư viện có thể tự động tạo ra các đối tượng, các dependency tiêm vào đối tượng đó, thường là áp dụng kỹ thuật Reflection của C#

        !!! Việc tự phát triển thường khá phức tạp nên có thể sử dụng những thư viên có sẵn như: Microsoft.Extensions.DependencyInjection, Windsor, Unity Ninject, ...

    - Các kiểu Dependency Injection
        + Inject thông qua phương thức khởi tạo: cung cấp các Dependency cho đối tượng thông qua hàm khởi tạo - tập trung vào cách này vì thư viện .NET hỗ trợ sẵn

        + Inject thông qua setter: tức các Dependency như là thuộc tính của lớp, sau đó inject bằng gán thuộc tính cho Depedency object.denpendency = obj;

        + Inject thông qua các Interface - xây dựng Interface có chứa các phương thức Setter để thiết lập dependency, interface này sử dụng bởi các lớp triển khai, lớp triển khai
        phải định nghĩa các setter quy định trong interface

    - DI Container
        + Mục đích sử dụng DI, để tạo ra các đối tượng dịch vụ kéo theo là các Dependency của đối tượng đó

        + DependencyInjection là DI Container mặc định của ASP.NET Core

        + Phải đảm bảo tích hợp Package Microsoft.Extensions.DependencyInjection vào dự án
            dotnet add package Microsoft.Extensions.DependencyInjection
            // đọc thêm về file .csproj

        + Sử dụng namespace
            using  Microsoft.Extensions.DependencyInjection;

        + Lớp ServiceCollection
            * ServiceCollection là lớp triển khai giao diện IServiceCollection nó có chức năng quản lý các dịch vụ (đăng ký dịch vụ - tạo dịch vụ - tự động inject - và các
            dependency của địch vụ ...).

            * ServiceCollection là trung tâm của kỹ thuật DI, nó là thành phần rất quan trọng trong ứng dụng ASP.NET

            * Khởi tạo đối tượng ServiceCollection, sau đó đăng ký (lớp) các dịch vụ vào ServiceCollection. Từ ServiceCollection phát sinh ra đối tượng ServiceProvider, từ đối tượng này
            truy vấn lấy ra các dịch vụ cụ thể khi cần.

            * Phương thức
                / AddSingleton<ServiceType, ImplementationType>() : Đăng ký dịch vụ kiểu Singleton
                !!! Nếu ServiceType giống ImplementationType thì ghi AddSingleton<ServiceType>()

                / AddTransient<ServiceType, ImplementationType>() : Đăng ký dịch vụ thuộc loại Transient, luôn tạo mới mỗi khi có yêu cầu lấy dịch vụ.
                !!! Hoặc AddTransient<ServiceType>()

                / AddScoped<ServiceType, ImplementationType>() : Đăng ký vào hệ thống dịch vụ kiểu Scoped

                / BuildServiceProvider() : Tạo ra đối tượng lớp ServiceProvider, đối tượng này dùng để triệu gọi, tạo các dịch vụ thiết lập ở trên.

            !!! ServiceType : Kiểu (tên lớp) dịch vụ

            !!! ImplementationType : Kiểu (tên lớp) sẽ tạo ra đối tượng dịch vụ theo tên ServiceType, cần đảm bảo ImplementationType là một lớp triển khai / kế thừa từ
            ServiceType, hoặc chính là ServiceType

            !!! Các phương thức AddSingleton, AddTransient, AddScoped còn có bản quá tải mà tham số là một callback delegate tạo đối tượng. Nó là cách triển khai pattern factory

        + ServiceLifetime
            * Mỗi dịch vụ (lớp) khi đăng ký vào ServiceCollection thì có một đối tượng ServiceDescriptor chứa thông tin về dịch vụ đó, căn cứ vào ServiceDescriptor để ServiceCollection
            khởi tạo dịch vụ khi cần

            * Trong ServiceDescriptor có thuộc tính Lifetime để xác định dịch vụ tạo ra tồn tại trog bao lâu. Lifetime có kiểu ServiceLifetime (kiểu enum) có các giá trị cụ thể:
                | Scoped	| 1	| Một bản thực thi (instance) của dịch vụ (Class) được tạo ra cho mỗi phạm vi, tức tồn tại cùng với sự tồn tại của một đối tượng kiểu ServiceScope |
                |           |   | (đối tượng này tạo bằng cách gọi ServiceProvider.CreateScope, đối tượng này hủy thì dịch vụ cũng bị hủy).                                        |
                | Singleton	| 0	| Duy nhất một phiên bản thực thi (instance of class) (dịch vụ) được tạo ra cho hết vòng đời của ServiceProvider                                   |
                | Transient	| 2	| Một phiên bản của dịch vụ được tạo mỗi khi được yêu cầu                                                                                          |

        + Lớp ServiceProvider
            * Lớp ServiceProvider cung cấp cơ chế để lấy ra (tạo và inject nếu cần) các dịch vụ đăng ký trong ServiceCollection.

            * Đối tượng ServiceProvider được tạo ra bằng cách gọi phương thức BuildServiceProvider() của ServiceCollection
                var serviceprovider = services.BuildServiceProvider();

            * Phương thức
                | GetService<ServiceType>()	      | Lấy dịch vụ có kiểu ServiceType - trả về null nếu dịch vụ không tồn tại                |
                | GetRequiredService(ServiceType) | Lấy dịch vụ có kiểu ServiceType - phát sinh Exception nếu dịch vụ không tồn tại        |
                | CreateScope()	                  | Tạo một phạm vi mới, thường dùng khi sử dụng những dịch vụ có sự ảnh hưởng theo Scoped |

            * Ví dụ
                // ClassA
                // IClassB -> ClassB,  ClassB1
                // IClassC -> ClassC,  ClassC1

                ServiceCollection services = new ServiceCollection();

                services.AddSingleton<ClassA, ClassA>();
                services.AddSingleton<IClassC, ClassC>();
                services.AddSingleton<IClassB, ClassB>();

                var provider = services.BuildServiceProvider();

                ClassA service_a = provider.GetService<ClassA>();

                service_a.ActionA();

    - Sử dụng delegate / factory
        + delegate
            * Các phương thức để đăng dịch vụ vào ServiceCollection như AddSingleton, AddSingleton, AddTransient còn có phiên bản (nạp chồng) nó nhận tham số là delegate trả về
            đối tượng dịch vụ có kiểu ImplementationType
                services.AddSingleton<ServiceType>((IServiceProvider provider) => {
                    // các chỉ thị
                    // ...
                    return (đối tượng kiểu ImplementationType);
                });

            * Delegate nhận tham số là IServiceProvider (chính là đối tượng được sinh ra bởi ServiceCollection.BuildServiceProvider()), Delegate phải trả về một đối tượng
            triển khai từ ServiceType

            * Ví dụ
                class ClassB2 : IClassB
                {
                    IClassC c_dependency;
                    string message;
                    public ClassB2(IClassC classc, string mgs)
                    {
                        c_dependency = classc;
                        message = mgs;
                        Console.WriteLine("ClassB2 is created");
                    }
                    public void ActionB()
                    {
                        Console.WriteLine(message);
                        c_dependency.ActionC();
                    }
                }

                // Lớp trên khi khởi tạo cần có hai tham số. Nhưng tham số khởi tạo IClassC được inject, trong khi đó tham số chuỗi string không đăng ký sẽ dẫn tới lỗi
                services.AddSingleton<IClassB, ClassB2>(); // lỗi

                // có thể đăng ký với Delegate và truyền chuỗi khởi tạo cụ thể
                services.AddSingleton<IClassB>((IServiceProvider serviceprovider) => {
                    var service_c = serviceprovider.GetService<IClassC>();
                    var sv = new ClassB2(service_c, "Thực hiện trong ClassB2");
                    return sv;
                });

                // nếu lấy ra dịch vụ IClassB (hoặc khi nó Inject vào dịch vụ khác) , nếu dịch vụ đó chưa có nó sẽ thi hành Delegate để tạo dịch vụ

        + factory
            * Delegate có thể khai báo thành một phương thức, một phương thức cung cấp cơ chế để tạo ra đối tượng mong muốn gọi là Factory.
                // Factory nhận tham số là IServiceProvider và trả về đối tượng địch vụ cần tạo
                public static ClassB2 CreateB2Factory(IServiceProvider serviceprovider)
                {
                    var service_c = serviceprovider.GetService<IClassC>();
                    var sv = new ClassB2(service_c, "Thực hiện trong ClassB2");
                    return sv;
                }

                // có thể sử dụng Factory trên để đăng ký IClassB.
                services.AddSingleton<IClassB>(CreateB2Factory);

    - Sử dụng Options
        + Để tách bạch giữa các dịch vụ và các thiết lập truyền vào để khởi tạo dịch vụ thì trong ServiceCollection hỗ trợ sử dụng giao diện IOptions

        + Cần thêm package Microsoft.Extensions.Options
            dotnet add package Microsoft.Extensions.Options

        + Các thiết lập cho một dịch vụ thường thiết kế là một lớp chứa các thuộc tính
            public class MyServiceOptions {
                public string data1 { get; set; }
                public int data2 { get; set; }
            }

        + Để có thể Inject MyServiceOptions vào MyService theo nguyên tắc của ServiceCollection thì lớp MyService thiết kế sử dụng IOption làm tham số khởi tạo
            public class MyService {
                public string data1 { get; set; }
                public int data2 { get; set;}

                // Tham số khởi tạo là IOptions, các tham số khởi tạo khác nếu có khai báo như bình thường
                public MyService(IOptions<MyServiceOptions> options) {
                    // Đọc được MyServiceOptions từ IOptions
                    MyServiceOptions opts = options.Value;
                    data1 = opts.data1;
                    data2 = opts.data2;
                }

                public void PrintData() => Console.WriteLine($"{data1} / {data2}");
            }

        + Khi tham số khởi tạo có kiểu IOptions, thì nó được Inject vào từ một tập hợp các IOptions riêng biệt với các dịch vụ
            services.Configure<T>(
                (T options)
                {
                    // T là tên lớp chứa các thiết lập
                    // Hãy thiết lập các giá trị cho options
                }
            );

            // ví dụ
            services.Configure<MyServiceOptions>(
                options => {
                    options.data1 = "Xin chao cac ban";
                    options.data2  = 2021;
                }
            );

            // sử dụng
            services.AddSingleton<MyService>();
            var provider = services.BuildServiceProvider();

            var myservice = provider.GetService<MyService>();
            myservice.PrintData();

            // Kết quả:
            // Xin chao cac ban / 2021

        !!! nếu muốn lấy đối tượng lớp MyServiceOptions trong DI Container, thì:
            var config = serviceprovider.GetService<IOptions<MyServiceOptions>>()
            MyServiceOptions myServiceOptions = config.Value;

        !!!  nếu muốn tạo trực tiếp đối tượng IOptions<MyServiceOptions>, dành cho trường hợp muốn tạo MyService trực tiếp không thông qua DI Container.
        Thì dùng phương thức Factory Options.Create(obj)
            var opts = Options.Create(new MyServiceOptions() {
                data1 = "DATA-DATA-DATA-DATA-DATA",
                data2 = 12345
            });
            MyService myService = new MyService(opts);
            myService.ShowData();

    - Sử dụng cấu hình từ file
        + Ở trên, các giá trị dữ liệu trong MyServiceOptions (như data1, data2) có thể lưu ở file sau đó nạp vào khi chương trình thực thi

        + Các file cấu hình này hỗ trợ nhiều định dạng như XML, INI, JSON ... (cần cài đặt gói tương ứng)
            // gói cần thiết để nạp
            dotnet add package Microsoft.Extensions.Configuration
            dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions

            // các gói tướng ứng với loại file
            dotnet add package Microsoft.Extensions.Configuration.Json
            dotnet add package Microsoft.Extensions.Configuration.Ini
            dotnet add package Microsoft.Extensions.Configuration.Xml

            // ví dụ Sử dụng namespace với kiểu file Json
            using Microsoft.Extensions.Configuration;
            using Microsoft.Extensions.Configuration.Json;

            // đọc thêm các file định dạng như XML, INI, JSON trong ExPandendKnowledge.txt

        + ConfigurationBuilder
            * Lớp ConfigurationBuilder, giúp nạp các cấu hình lưu trong file config, từ đó build ra đối tượng ConfigurationRoot, đối tượng này truy cập đến các cấu hình
            bằng chỉ toán tử chỉ số [key]

            * ví dụ lấy cấu hình lưu tại file appsettings.json, thì nạp cấu hình đó để có được ConfigurationRoot
                var configBuilder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())      // file config ở thư mục hiện tại
                        .AddJsonFile("appsettings.json");                  // nạp config định dạng JSON
                var configurationroot = configBuilder.Build();             // Tạo configurationroot

            * lấy một Section nào đó bằng phương thức GetSection(key), nó trả về đối tượng biểu diễn nút cấu hình (JSON), giá trị của nút truy cập bằng thuộc tính Value
                // file appsettings.json
                {
                    "MyServiceOptions" : {
                        "data1" : "ABCDE",
                        "data2" : 123456
                    },

                    "Option2" : {
                        "key1" : "Test",
                        "Key2" : 789
                    }
                }

                // Truy cập config
                var cf1 = configurationroot.GetSection("Option2").GetSection("key1").Value; // Test
                var cf2 = configurationroot.GetSection("Option2").GetSection("key2").Value; // 789
                var cf3 = configurationroot.GetSection("Option2").GetSection("key3").Value; // null, không tồn tại

        + nạp config vào IOption
            * Trong file JSON có một Section có tên MyServiceOptions, ta có thể gán các giá trị trong Section đó vào MyServiceOptions trong ServiceCollection
                // Nạp mở phương thức mở rộng
                services.AddOptions();
                services.Configure<MyServiceOptions>(configurationroot.GetSection("MyServiceOptions"));

                // Lưu ý: phải cài package  ConfigurationExtensions
                // dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions

            * ví dụ hoàn chỉnh
                var configBuilder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())      // file config ở thư mục hiện tại
                        .AddJsonFile("appsettings.json");                  // nạp config định dạng JSON
                var configurationroot = configBuilder.Build();             // Tạo configurationroot

                ServiceCollection services = new ServiceCollection();

                services.AddOptions();
                services.Configure<MyServiceOptions>(configurationroot.GetSection("MyServiceOptions"));

                services.AddSingleton<MyService>();

                var provider = services.BuildServiceProvider();

                var myservice = provider.GetService<MyService>();
                myservice.PrintData();

                // Kết quả:
                // ABCDE / 123456

    !!! Kỹ thuật DI với thư viện DependencyInjection ở trên là kiến thức rất quan trọng cần nắm vững, nó là cơ sở để học các các mô hình lập trình hiện đại, nhất là sau này
    áp dụng với Asp.Net Core

## Nuget (thư viện lớp) // bổ sung sau

## Uri, Dns, Ping

    - Lớp Uri
        + System.Uri là lớp biểu diễn về địa chỉ URI (URL) (xem thêm Tìm hiểu URI, URL), nó giúp cho nhanh chóng lấy thông tin các thành phần của URL như host, path, query ...

        + Đối tượng Uri còn sử dụng trong tham số để thực hiện các truy vấn HTTP Request ở các phần sau.
            string url = "https://www.youtube.com/watch?v=2w97mmTYR68";
            var uri = new Uri(url);
            var uritype = typeof(Uri);
            uritype.GetProperties().ToList().ForEach(property => {
                Console.WriteLine($"{property.Name, 15} {property.GetValue(uri)}");
            });
            Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");

    - Lớp Dns và lớp IPHostEntry
        + Lớp Dns (System.Net.Dns) cung cấp các phương thức tính để lấy thông tin về host (địa chỉ website, server cung cấp các dịch vụ mạng) từ hệ thống phân giải tên miền (Dns)

        + Các thông tin truy vấn được nó trả về một đối tượng giao diện IPHostEntry
            string url = "https://www.bootstrapcdn.com/";
            var uri = new Uri(url);
            var hostEntry = Dns.GetHostEntry(uri.Host);
            Console.WriteLine($"Host {uri.Host} có các IP");
            hostEntry.AddressList.ToList().ForEach(ip => Console.WriteLine(ip));

        + Phương thức lớp Dns
            | GetHostName()	           | Lấy hostname của máy local                                    |
            | GetHostEntry(String)     | Phân giải host hoặc IP thành đối tượng IPHostEntry.           |
            | GetHostEntry(IPAddress)  | Đối tượng kiểu IPHostEntry nó chứa thông tin địa chỉ về host. |                                                                                                                 |

        + Thuộc tính IPHostEntry
            | HostName	    | Chuỗi chứa hostname của Server                      |
            | AddressList	| Mảng các phần tử kiểu IPAddress chứa các địa chỉ IP |

    - Lớp Ping
        + Lớp Ping (System.Net.NetworkInformation.Ping), lớp này cho phép ứng dụng xác định một máy từ xa (như server, máy trong mạng ...) có phản hồi không.
            var ping = new Ping();
            var pingReply = ping.Send("google.com.vn");
            Console.WriteLine(pingReply.Status);
            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine(pingReply.RoundtripTime);
                Console.WriteLine(pingReply.Address);
            }

## HttpClient

## Tổng kết (ý hiểu cá nhân)

    - Các tính chất OOP
        + Inheritance (kế thừa) : Các đọan code trùng lặp về tính năng, chức năng được tái sử lại thông qua việc kế thừa giữa các lớp. Tính kế thừa giúp giảm số lượng code trùng lặp, dễ thực
        hiện việc quản lý, bảo trì, phát triển và sửa đổi. (Kế thừa giữa các lớp)

        + Abstraction (trừu tượng) : Tạo ra những khung code mẫu thể hiện các chức năng của 1 lớp, 1 giao diện, 1 hàm (cần hiện thực cụ thể). Tính trừu tượng giúp dev dễ hình dung, hệ thống
        các đoạn code; điều chỉnh, hạn chế thiếu sót trong quá trình hiện thực ý tưởng ban đầu. (Lớp/phương thức trừu tượng - abstract, giao diện - interface)

        + Polymorphism (đa hình) : Thực hiện, tổng quát hóa các tính năng, chức năng để phù hợp với nhiều trường hợp đầu vào khác. Tính đa hình làm giảm số lượng code có cùng chức năng, giúp code dễ
        quản lý, bảo trì, phát triển và sửa đổi. (Quá tải - overload, ghi đè/nạp chồng - override, generic)

        + Encapsulation (đóng gói) : Gôm các đoạn code có cùng điểm chung vào 1 khu vực và phân chia các giới hạn truy cập (các namespace, các class). Tính đóng gói hệ thống lại code trong dự án;
        giúp dễ quản lý, bảo trì, phát triển, sửa đổi; tăng tính bảo mật thông qua phạm vi truy cập. (Xây dựng các namespace, class, phân chia file code)
