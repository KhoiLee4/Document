#####-----JAVA-----#####

*** JAVA là gì? 
    - Java là một ngôn ngữ lập lập trình, được phát triển bởi Sun Microsystem vào năm 1995, là ngôn ngữ kế thừa trực tiếp từ C/C++ và là một ngôn ngữ lập trình hướng đối tượng.

*** JVM là gì?
    - JVM ( Java Virtual Machine- Máy ảo Java) là một máy ảo cho phép máy tính chạy chương trình Java.
    [chạy chương trình Java => biên dịch Java code thành bytecode => JVM dịch bytecode thành ngôn ngữ máy]

*** JRE là gì?
    - JRE ( Java Runtime Environment) là gói phần mềm cung cấp các thư viện lớp Java, cùng với Máy ảo Java (JVM), và các thành phần khác để chạy các ứng dụng được viết bằng lập 
    trình Java. JRE là một bộ của JVM.

*** JDK là gì?
    - JDK (Java Development Kit- Bộ công cụ phát triển Java) là một bộ công cụ phát triển phần mềm để phát triển các ứng dụng trong Java. Khi bạn tải JDK, JRE cũng được tải xuống 
    và không cần phải tải xuống riêng. Ngoài JRE, JDK cũng chứa một lượng công cụ phát triển (trình biên dịch, JavaDoc, Trình gỡ lỗi Java, v.v.).

!!! Những điều cần lưu ý 
    - Mỗi ứng dụng Java hợp lệ phải có định nghĩa lớp (khớp với tên file).
    - Hàm main phải nằm trong định nghĩa lớp.
    - Trình biên dịch thực hiện các câu lệnh bắt đầu từ hàm main.

### Quy tắc đặt tên biến trong Java
    - Bộ quy tắc và quy ước riêng để đặt tên biến:
        + Các biến trong Java phân biệt chữ hoa và chữ thường.
        + Tên của biến là một chuỗi các chữ cái và chữ số trong Unicode. Nó có thể bắt đầu bằng một chữ cái, $ hoặc _ . Tuy nhiên, người ta hay quy ước: tên biến bắt đầu bằng một 
        chữ cái. Ngoài ra, trong Java, tên biến không được chứa khoảng trắng.
        + Khi tạo các biến, nên chọn một tên có ý nghĩa. Ví dụ: các tên biến như score , number , level có ý nghĩa hơn tên biến như s , n và l.
        + Nếu bạn chọn một tên biến chỉ có một từ thì nên sử dụng tất cả các chữ cái viết thường. Ví dụ: nên sử dụng speed thay vì SPEED hoặc sPEED.
        + Nếu bạn chọn tên biến có nhiều hơn một từ thì hãy sử dụng tất cả các chữ cái viết thường cho từ đầu tiên và viết hoa chữ cái đầu tiên của mỗi từ tiếp theo. Ví dụ: speedLimit.

    - Có 4 loại biến trong ngôn ngữ lập trình Java:
        + Biến instance  (Trường không tĩnh).
        + Biến của class (Trường tĩnh).
        + Biến cục bộ.
        + Tham số.

### 8 kiểu dữ liệu cơ bản trong java
    - Kiểu boolean
        + Kiểu dữ liệu boolean có hai giá trị,  true hoặc false.
        + Chúng thường được sử dụng cho các điều kiện đúng/sai.
        + Giá trị mặc định : false.

    - Kiểu byte
        + Kiểu dữ liệu byte có thể có các giá trị từ -128 đến 127 (số nguyên bù 2 8 bit có dấu).
        + Nó được sử dụng thay cho kiểu int hoặc các kiểu dữ liệu số nguyên khác để tiết kiệm bộ nhớ nếu giá trị của biến chắc chắn nằm trong khoảng [-128, 127].
        + Giá trị mặc định: 0.

    - Kiểu short
        + Kiểu dữ liệu short có thể có các giá trị từ -32768 đến 32767 (số nguyên bù 2 16 bit có dấu).
        + Nó được sử dụng thay cho các loại dữ liệu số nguyên khác để tiết kiệm bộ nhớ nếu giá trị của biến chắc chắn nằm trong khoảng [-32768, 32767].
        + Giá trị mặc định: 0.

    - Kiểu int
        + Kiểu dữ liệu int có thể có các giá trị từ -(2^31) đến (2^31) - 1 (số nguyên bù 2 32 bit có dấu).
        + Nếu bạn đang sử dụng Java 8 trở lên, bạn có thể sử dụng số nguyên 32 bit không dấu với giá trị tối thiểu là 0 và giá trị tối đa là 2^32 - 1.
        + Giá trị mặc định: 0.

    - Kiểu long
        + Kiểu dữ liệu long có thể có các giá trị từ -(2^63) đến (2^63) - 1 (số nguyên bù 2 64 bit có dấu).
        + Nếu bạn đang sử dụng Java 8 trở lên, bạn có thể sử dụng số nguyên 64 bit không dấu với giá trị tối thiểu là 0 và giá trị tối đa là 2^64 - 1.
        + Giá trị mặc định: 0.

    - Kiểu double
        + Kiểu dữ liệu double là dấu phẩy động 64 bit chính xác kép.
        + Không nên dùng kiểu dữ liệu này cho các giá trị chính xác như tiền tệ.
        + Giá trị mặc định: 0,0 (0,0d).

    - Kiểu float
        + Kiểu dữ liệu float là dấu phẩy động 32 bit chính xác đơn.
        + Không nên được sử dụng kiểu này cho các giá trị chính xác như tiền tệ.
        + Giá trị mặc định: 0,0 (0,0f).

    - Kiểu char
        + Là ký tự Unicode 16 bit.
        + Giá trị tối thiểu của kiểu dữ liệu char là ‘\u0000′(0). Giá trị tối đa của kiểu dữ liệu char là ‘\uffff’.
        + Giá trị mặc định: ‘\u0000’.

### Literals trong Java
    - Literal là một chữ nằm trong code và có một giá trị cố định nào đó.
    - Integer literals
        + Integer literals được sử dụng để khởi tạo các biến thuộc kiểu dữ liệu nguyên như byte, short, int và long.
        + Integer literals có thể được biểu diễn trong các hệ thống số thập phân, thập lục phân và số nhị phân.
        + Các số bắt đầu bằng tiền tố 0x đại diện cho hệ thập lục phân. Tương tự, các số bắt đầu bằng tiền tố 0b đại diện cho hệ nhị phân.

                        // Error! literal 42332200000 of type int is out of range
                        long myVariable1 = 42332200000;

                        // 42332200000L is of type long, and it's not out of range
                        long myVariable2 = 42332200000L;

                        // decimal
                        int decNumber = 34;

                        // 0x represents hexadecimal
                        int hexNumber = 0x2F;

                        // 0b represents binary
                        int binNumber = 0b10010;

    - Literals số thực
        + Literals số thực được sử dụng để khởi tạo các biến của kiểu dữ liệu float và double.
        + Nếu một literal số thực kết thúc bằng f hoặc F, nó thuộc kiểu float. Còn không thì nó thuộc kiểu double. Kiểu double có thể kết thúc bằng D hoặc d. Tuy nhiên, điều này 
        là không cần thiết.
        + Chúng cũng có thể được thể hiện bằng ký hiệu khoa học bằng E hoặc e.

                        double myDouble = 3.4;
                        float myFloat = 3.4F;
                        
                        // 3.445*10^2
                        double myDoubleScientific = 3.445e2;

    - Kí tự literals và chuỗi literals
        + Có chứa các ký tự Unicode (UTF-16).
        + Đối với kí tự literals, sử dụng dấu nháy đơn. Ví dụ ‘a’, ‘\u0111’v.v.
        + Đối với chuỗi literals, sử dụng dấu nháy kép. Ví dụ , “programming”.”Java 8″
        + Java cũng hỗ trợ một vài chuỗi thoát đặc biệt. Ví dụ: \b (xóa lùi), \t (tab), \n (xuống dòng), \f (ngắt trang), \r (dấu enter), \” (nháy kép), \’ (nháy đơn) và \\ (dấu gạch chéo).

### Toán tử (Operator)
    - Toán tử  gán

    - Toán tử số học
        | + | Toán tử cộng (cũng được sử dụng để nối chuỗi) |  
        | – | Toán tử trừ                                   |  
        | * | Toán tử nhân                                  |  
        | / | Toán tử chia                                  |  
        | % | Toán tử lấy phần dư                           |   

    - Toán tử  một ngôi
        | +  |  Cộng một ngôi (toán tử này là không cần thiết vì kể cả khi không sử dụng toán tử này, các số vẫn luôn dương) | 
        | –  |  Trừ một ngôi; đảo dấu của một biểu thức                                                                      | 
        | ++ |  Toán tử gia tăng; tăng giá trị lên 1                                                                         | 
        | -- |  Toán tử giảm; giảm giá trị đi 1                                                                              | 
        | !  |  Toán tử bổ sung logic, đảo ngược giá trị boolean                                                             |    

    - Toán tử quan hệ và toán tử bằng
        | == | 	Bằng 5 == 3 được cho kết quả là false        | 
        | != |	Không bằng 5 != 3 cho kết quả là true        |  
        | >  |	Lớn hơn	5 > 3 cho kết quả là true            |  
        | <  |	Bé hơn 5 < 3 cho kết quả là false            |   
        | >= |	Lớn hơn hoặc bằng 5 >= 5 cho kết quả là true |    
        | <= |	Bé hơn hoặc bằng 5 <= 5 cho kết quả là true  |    

    - Toán tử logic
        | || | 	Điều kiện-OR; true nếu một trong các biểu thức boolean là true	false || true trả về kết quả là true |
        | && | 	Có điều kiện-AND; true nếu tất cả các biểu thức boolean là true	false && true trả về kết quả false   |

    - Toán tử Ternary
        + Toán tử điều kiện hoặc toán tử ternary ?: là viết tắt của câu lệnh  if-then-else. Cú pháp của toán tử điều kiện là: 
            variable = Expression ? expression1 : expression2

    - Toán tử Bitwise và Bitshift
        | ~	  |  Phủ định NOT         |    
        | <<  |  Dịch trái            |  
        | >>  |  Dịch phải            |  
        | >>> |  Bỏ dịch phải         |  
        | &	  |  Toán tử AND          |  
        | ^	  |  Toán tử exclusive OR |  
        | |	  |  Toán tử OR           |  

### Nhập xuất
    - Output : System.out.print("Nội dung");
        + print() : in chuỗi bên trong dấu ngoặc kép.
        + println() : in chuỗi bên trong dấu ngoặc kép giống như hàm print(). Sau đó con trỏ di chuyển đến đầu dòng tiếp theo.
        + printf() : cung cấp định dạng chuỗi (tương tự như printf trong lập trình C / C ++ ).

    - Input
        + Cần nhập class Scanner bằng cách sử dụng câu lệnh: import java.util.Scanner;
        + Tạo đối tượng scanner: Scanner input = new Scanner(System.in);
        + Lấy giá trị của người dùng vào: int number = input.nextInt();
            * nextInt() : lấy input kiểu int
            * nextLong() : lấy input kiểu long
            * nextFloat() : lấy input kiểu float
            * nextDouble() : lấy input kiểu double
            * next() : lấy input kiểu String

### If Else If (tương tự với C/C++)

### Switch
    !!! Lưu ý rằng câu lệnh switch trong Java chỉ hoạt động với:
        - Các kiểu dữ liệu cơ bản: byte, short, char và int
        - Các kiểu liệt kê (liệt kê trong Java)
        - String class
        - Một vài class bao gồm các kiểu cơ bản: Character, Byte, Short, và Integer. 

### Vòng lặp For, For-each, While, Do-while (tương tự với C/C++)

### Câu lệnh continue, break (tương tự với C/C++)
    !!! break label; : câu lệnh break sẽ chấm dứt câu lệnh có label. Sau đó, luồng của chương trình sẽ nhảy đến câu lệnh sau câu lệnh có label.
    !!! continue label; : câu lệnh continue khác là dạng được dán nhãn, có thể sử dụng để bỏ qua (các) câu lệnh nằm ở vòng lặp bên ngoài. (KHÔNG NÊN DÙNG)

### Mảng (tương tự C/C++)
    - Java sẽ tự quản lý vùng nhớ nên chỉ cần khai báo
        int[] array = new int[số lượng];
        int[][] array = new int[sl][sl];
        int[][][] array = new int[sl][sl][sl];
    !!! Khác với mảng đa chiều trong C/C++, các hàng trong mảng ở Java có thể có kích thước khác nhau

    *** Có 2 loại copy là: 
        shallow copy: sao chép đường liên kết đến đối tượng của mảng cũ (mảng cũ thay đổi => mảng mới thay đổi) 
        deep copy: sao chép giá trị của mảng cũ để tạo đối tượng mới (mảng cũ thay đổi => mảng mới không thay đổi)

    - Sao chép mảng
        + Toán tử gán (shallow copy)
        + Vòng lặp (deep copy)
        + Hàm System.arraycopy(Object src, int srcPos, Object dest, int destPos, int length) có trong lớp System, cụ thể và tiện hơn pp vòng lặp
        + Hàm Array.copyOfRange(Object src, int srcPos, int length) có trong lớp java.util.Arrays, tương tự với arraycopy() nhưng không cần tạo mảng đích trước

### Đối tượng và lớp (tương tự C/C++)
    *** Class là bản thiết kế cho vật thể.
    
    - Phương thức 
        + Có 2 loại phương thức
            * Phương thức của thư viện chuẩn
            * Phương thức do người dùng định nghĩa

        + Cấu trúc 1 lớp:
            [public]                | lớp được truy xuất chung cho các package khác
            [abstract]              | lớp trừu tượng
            [final]                 | lớp hằng
            class ClassName         | tên lớp
            [extends SuperClass]    | lớp kế thừa
            [implements Interfaces] | giao diện được cài đặt
            { ... }                 | phần thân

        + Cấu trúc 1 phương thức
            [modifier]                | phạm vi truy cập
            [static/final]            | phương thức tĩnh, phương thức cuối cùng (không đc overrite)
            [returnType]              | kiểu trả về
            nameOfMethod (parameters) | tên phương thức và tham số
            {}                        | phần thân

    - Hàm tạo Constructor (tương tự với C/C++)

    - Từ khóa this
        + Sử dụng this để định hướng các tham chiếu biến
        + Sử dụng từ khóa this trong nạp chồng hàm tạo
        + Truyền this giống một đối số

    - Từ khóa static
        + Để sử dụng các thành viên, phương thức trong class mà không tạo ra đối tượng cụ thể thì dùng "static"
        + Tính là liên kết với class chứ không phải với đối tượng
        + Tất cả các đối tượng của lớp đều có chung một biến tĩnh, thường không dùng biến tĩnh mà dùng hằng tĩnh
        + Các khối tĩnh được sử dụng để khởi tạo các biến tĩnh. Khối tĩnh chỉ được thực hiện một lần khi lớp được tải trong bộ nhớ. Lớp được tải nếu đối tượng của 
        lớp được yêu cầu trong mã hoặc các thành viên tĩnh được yêu cầu trong code.

    - Biểu thức lambda
        + functional interface là một interface trong Java chứa một và chỉ một phương thức trừu tượng
        + Biểu thức lamda là một phương thức không có tên hay phương thức nặc danh. Biểu thức lambda không tự thực thi mà thay vào đó được sử dụng để thực thi một 
        phương thức được định nghĩa một functional interface. 
        + Khai báo
                // Phần thân với một biểu thức đơn.
                () -> System.out.println("Lambdas are great");

                // Phần thân chứa một khối code.
                () -> {
                    double pi = 3.1415;
                    return pi;
                };
        + sử dụng kết hợp với 1 functional interfaces (mục đích tương tự với template trong C/C++)
    
    - Toán tử instanceof
        + Instanceof là một toán tử nhị phân. Nó được sử dụng để kiểm tra xem một đối tượng có phải là một instance của một class cụ thể hay không.
        + Class object: tất cả các class được kế thừa từ class Object. Từ khóa extends không được sử dụng trong quá trình kế thừa của class Object. Đây là một ngoại lệ trong Java.
        + Upcasting là một đối tượng của một subclass có thể được coi là một đối tượng của superclass (tự động)
        + Downcasting là một đối tượng của superclass được coi là một đối tượng của subclass (chỉ rõ)

### Hướng đối tượng
    - Quyền truy cập Access Modifier / Visibility Modifier
        *** Một package đơn giản chỉ là một chiếc thùng chứa các loại liên quan (class, giao diện, các enum và annotation).
        
        | Private	| Chỉ được try cập trong class                                 | 
        | Default	| Chỉ được truy cập bên trong package (package cá nhân)        | 
        | Protected	| Được truy cập bên trong package hoặc/và tất cá các class phụ | 
        | Public	| Có thể truy cập từ bất cứ đâu                                | 

    - Kế thừa (inheritanse)
        + Kiểu đơn kế thừa (Single inheritance) – Class b chỉ mở rộng từ class a
        + Kiểu kế thừa nhiều cấp (Multilevel inheritance) – Class b mở rộng từ class a, sau đó class c mở rộng từ class b
        + Kiểu kế thừa thứ bậc (Hierachical inheritance) – Class a là superclass cho các class b, c, và d.
        + Kiểu đa kế thừa (Multiple inheritance) – Class c mở rộng từ giao diện a và b
        + Kiểu kế thừa lai (Hybrid inheritance) – Kết hợp hai hay hiều kiểu kế thừa

        !!! Java không hỗ trợ kiểu đa kế thừa và kiểu kế thừa lai thông qua các class. Tuy nhiên, chúng ta vẫn có thể đạt được tính đa kế thừa trong Java thông qua các interface

    - Ghi đè (Overriding)
        + Cả superclass và subclass phải có cùng tên phương thức, cùng kiểu trả về và cùng danh sách tham số
        + Chúng ta không thể ghi đè phương thức được khai báo là final và static
        + Chúng ta luôn luôn nên ghi đè các phương thức trừu tượng của superclass

        !!! Chúng ta chỉ có thể sử dụng các access specifier trong subclass mà cung cấp quyền truy cập rộng hơn access specifier của superclass

    - Super
        + Dùng để truy cập các thuộc tính (dữ liệu) của superclass nếu cả superclass và subclass có các thuộc tính cùng tên với nhau.
        + Để gọi hàm tạo no-arg (default) hoặc hàm tạo được tham số hóa của superclass từ hàm tạo của subclass
        + Truy cập các phương thức bị ghi đè, các thuộc tính của supperclass
        
    - Trừu tượng (abstract)
        *** Một class trừu tượng trong Java không thể được khởi tạo (chúng ta không thể tạo ra các đối tượng cho một class trừu tượng). Trong Java, chúng ta chỉ sử dụng từ khóa abstract 
        để khai báo một class trừu tượng

        *** Chúng ta đều sử dụng từ khóa abstract để tạo các phương thức trừu tượng. Một phương thức trừu tượng được khai báo mà không cần triển khai

        !!! Điều quan trong cần ghi nhớ là một class không trừu tượng chỉ có thể chứa các phương thức không trừu tượng. Nếu một class không phải là class trừu tượng chứa các phương thức 
        trừu tượng, khi đó sẽ có lỗi biên dịch. Một class trừu tượng có thể chứa cả phương thức trừu tượng và các phương thức không trừu tượng

        + Trong Java, ghi đè các phương thức trừu tượng của superclass trong subclass là điều bắt buộc. Nếu subclass cũng được khai báo là trừu tượng, thì không bắt buộc phải ghi đè các 
        phương thức trừu tượng.

    - Giao diện (Interface)
        *** Trong Java, một interface định nghĩa một tập các đặc tả mà các class khác phải thực hiện, một giao diện tương tự như một lớp trừu tượng. Tuy nhiên, giao diện không có bất kỳ 
        phương thức không trừu tượng nào cả

        + Một interface có thể bao gồm các phương thức và hằng số trừu tượng
        + Chúng ta sử dụng từ khóa implements để thực thi các interface
        + Tương tự như các class, interface có thể mở rộng các interface khác. Các từ khóa extends được sử dụng để mở rộng interface
        + Để khai báo các phương thức default bên trong các interface, chúng tôi sử dụng từ khóa default. Các phương thức default được kế thừa như các phương thức thông thường và nó sẽ 
        không bắt buộc phải kể thừa (từ java 8)

        !!! Điều quan trọng cần lưu ý là, tất cả các phương thức bên trong một interface đều được ngầm định là public và tất cả các thuộc tính đều được ngầm định là public static final. 
        Do đó, không cần thiết phải chỉ định access specifier bên trong các interface
        
        !!! Lưu ý rằng một interface có thể mở rộng nhiều interface tương tự như một class triển khai nhiều interface.

    - Đa hình
        *** Tính đa hình là một khái niệm quan trọng của lập trình hướng đối tượng. Nó đơn giản có nghĩa là nhiều hơn một hình thức. Đó là cùng một thực thể (phương thức, toán tử hoặc 
        đối tượng) nhưng sẽ hoạt động khác nhau trong các tình huống khác nhau.

        + Đa hình lúc runtime: Trong Java, tính đa hình lúc runtime có thể đạt được thông qua việc ghi đè phương thức.
        + Đa hình lúc compiler-time: Đa hình lúc compiler-time có thể đạt được thông qua việc nạp chồng phương thức và nạp chồng toán tử trong Java.
            * Nạp chồng phương thức: Trong Java đối với một class, chúng ta có thể tạo các phương thức có cùng tên nếu chúng khác nhau về các tham số.
            * Nạp chồng toán tử: Java không hỗ trợ nạp chồng toán tử do người dùng định nghĩa.

    - Đóng gói
        *** Tính đóng gói là một trong những tính năng chính của lập trình hướng đối tượng. Đóng gói đề cập đến việc đóng gói các thuộc tính và phương thức trong một lớp duy nhất. Đóng 
        gói các thuộc tính và phương thức giống nhau trong một lớp cũng giúp ẩn bớt dữ liệu.

        + Đóng gói là một quá trình gói code giống nhau ở cùng 1 chỗ. Trong Java, chúng ta có thể gói các thuộc tính và phương thức hoạt động cùng nhau trong cùng một lớp.
        + Điều này cho phép chúng ta ẩn dữ liệu. Đóng gói trong chính nó không phải là ẩn dữ liệu.

    - Lớp trong lớp
        + Lớp lồng không tĩnh (Lớp trong): Một lớp lồng không tĩnh là một lớp trong một lớp khác. Nó có quyền truy cập vào các thành viên của lớp kèm theo (lớp ngoài). Nó thường được gọi 
        là inner class.

        !!! Chúng ta sử dụng . (toán tử dot) để tạo một thể hiện của lớp bên trong bằng cách sử dụng lớp bên ngoài.

        + Lớp lồng tĩnh: Trong Java, chúng ta cũng có thể định nghĩa một lớp static bên trong một lớp khác. Lớp như vậy được gọi là static nested class. Các lớp lồng nhau tĩnh không được 
        gọi là các lớp bên trong tĩnh.

        !!! Trong Java, chỉ các lớp lồng nhau mới được phép làm tĩnh
        !!! Java không cho phép lớp cha tĩnh

        + Lớp ẩn danh: Một lớp lồng nhau không có bất kỳ tên nào được gọi là lớp ẩn danh. Loại có thể có:
            * một lớp cha mà một lớp ẩn danh mở rộng
            * một giao diện(interface) mà một lớp ẩn danh triển khai
        class outerClass {
            // defining anonymous class
            object1 = new Type(parameterList) {
                // body of the anonymous class
            };
        }
            * Trong các lớp ẩn danh, các đối tượng được tạo bất cứ khi nào chúng được yêu cầu. Đó là, các đối tượng được tạo ra để thực hiện một số nhiệm vụ cụ thể. Các lớp ẩn danh cũng giúp 
            chúng ta làm cho mã của mình ngắn gọn.

### Design pattern singleton 
    - Đây là cách chúng ta có thể sử dụng singletons trong Java.
        + Tạo một hàm tạo private để tạo giới hạn một đối tượng từ bên ngoài lớp
        + Tạo một thuộc tính private để chỉ truy cập đến đối tượng singleton tại một nơi.
        + Tạo một phương thức public staticcho phép chúng ta tạo và truy cập vào đối tượng chúng ta đã tạo. Bên trong phương thức, chúng ta sẽ tạo một điều kiện hạn chế chúng ta tạo nhiều 
        hơn một đối tượng.

            class SingletonExample {

                // private field that refers to the object
                private static SingletonExample singleObject;

                private SingletonExample() {
                    // constructor of the SingletonExample class
                }

                public static SingletonExample getInstance() {
                    // write code that allows us to create only one object
                    // access the object as per our need
                }
            }

        + Singletons có thể được sử dụng trong khi làm việc với cơ sở dữ liệu. Chúng có thể được sử dụng để tạo một nhóm kết nối để truy cập cơ sở dữ liệu trong khi sử dụng lại cùng một kết nối 
        cho tất cả các máy khách.

    !!! Nên tránh sử dụng singletons nếu không chắc chắn có nên sử dụng nó hay không.

### Enum
    - Trong Java, một enum (viết tắt của liệt kê(enumeration)) là một kiểu tập hợp cố định các giá trị.
    - Trong Java, các kiểu enum được coi là một kiểu lớp đặc biệt. Nó được giới thiệu với việc phát hành Java 5. Một lớp enum có thể bao gồm các phương thức và các trường giống như các lớp thông 
    thường.Các hằng số enum luôn mặc định sẽ public static final. Khi một lớp enum được tạo, trình biên dịch cũng sẽ tạo các thể hiện (đối tượng) của từng hằng số enum.
    - Phương thức của lớp enum:
        + Phương thức ordinal() : là phương thức trả về vị trí của một hằng số enum.
        + Phương thức compareTo() : so sánh hằng enum dựa trên giá trị thứ tự của họ.
        + Phương thức toString() : trả về chuỗi đại diện của hằng enum. (có thể ghi đè)
        + Phương thức name() : trả về tên xác định một hằng số enum ở dạng chuỗi. Giá trị trả về từ phương thứcname() là final
        + Phương thức valueOf() : nhận một chuỗi và trả về một hằng số enum có tên chuỗi tương tự.
        + Phương thức values() : trả về một mảng của kiểu enum chứa tất cả các hằng số enum.
    
    !!! Các hằng số enum thường được biểu thị bằng chữ hoa.
    !!! Chúng ta không thể ghi đè phương thức name(). Đó là bởi vì name() là phương thức final.

### String
    | length()      | trả về tổng số kí tự                                       |    
    | concat()      | nối 2 chuỗi                                                | // toán tử +
    | equals()      | so sánh 2 chuỗi                                            | // toán tử == (có chút khác)
    | substring()	| trả về chuỗi con của chuỗi                                 |  
    | replace()	    | thay thế ký tự cũ được chỉ định bằng ký tự mới đã chỉ định |  
    | charAt()	    | trả về ký tự hiện diện ở vị trí đã chỉ định                |  
    | getBytes()	| chuyển đổi chuỗi thành một mảng byte                       |  
    | indexOf()	    | trả về vị trí của ký tự được chỉ định trong chuỗi          |       
    | compareTo()	| so sánh hai chuỗi theo thứ tự từ điển                      |   
    | trim()	    | xóa mọi khoảng trắng ở đầu và cuối                         |   
    | format()	    | trả về một chuỗi được định dạng                            |   
    | split()	    | ngắt chuỗi thành một mảng chuỗi                            |     
    | toLowerCase()	| chuyển đổi chuỗi thành chữ thường                          |      
    | toUpperCase()	| chuyển đổi chuỗi thành chữ hoa                             |     
    | valueOf()	    | trả về biểu diễn chuỗi của đối số được chỉ định            |     
    | toCharArray()	| chuyển đổi chuỗi thành một mảng char                       |     

    !!! Trong Java, các chuỗi là bất biến . Điều này có nghĩa là, khi chúng ta tạo một chuỗi, chúng ta không thể thay đổi chuỗi đó.

### Final
    - biến final không thể được khởi động lại bằng một giá trị khác
    - phương thức final không thể được ghi đè
    - lớp học final không thể được mở rộng

    !!! Nên sử dụng chữ hoa để khai báo các biến final trong Java.

### Collections Framework
    - Nền tảng Java bao gồm một collections framework. Framework cung cấp một bộ các interface và các class để thực hiện các cấu trúc dữ liệu và thuật toán khác nhau.
    - Interface
        + Collections interface
            * List interface: là một collection có trật tự cho phép ta thêm vào và loại bỏ các phần tử như ở trong mảng.
            * Set interface: cho phép ta lưu trữ các phần tử trong các set khác nhau, các set này  tương tự như các set ở trong toán học. Nó không thể có các phần tử trùng lặp.
            * Queue interface: được sử dụng khi chúng ta muốn để lưu trữ và truy cập tới các phần tử theo cách First In First Out (nhập trước thì xuất trước).
            * Map interface: cho phép các phần tử được lưu trữ trong các cặp key/value. Key là tên duy nhất được sử dụng để truy cập tới một phần tử cụ thể trong map. Mỗi key có một giá trị đơn liên quan đến nó.
            * Iterator interface: cung cấp các phương thức được sử dụng để truy cập các phần tử của collection.

### Collections interface
    - Collection interface là interface cha của collections framework trong Java.
    - Interface này không được sử dụng trực tiếp. Tuy nhiên, nó được sử dụng thông qua các subinterface như List, Set và Queue.

    | add()         | chèn phần tử xác định vào collection                                       |   
    | size()        | trả về kích thước của collection                                           |            
    | remove()      | xóa phần tử đã chỉ định khỏi collection                                    |         
    | iterator()    | trả về một iterator để truy cập các phần tử của collection                 |       
    | addAll()      | thêm tất cả các phần tử của một collection đã được chỉ định vào collection | 
    | removeAll()   | xóa tất cả các phần tử của một collection đã chỉ định khỏi collection      |     
    | clear()       | loại bỏ tất cả các phần tử của collection                                  |    

### List
    - Trong Java, List interface là một collection có trật tự cho phép chúng ta lưu trữ và truy cập tới các phần tử một cách tuần tự. Nó được mở rộng từ Collection interface.

    !!! List có thể bao gồm các phần tử trùng lặp.

    | add()          | thêm một phần tử vào list (thêm cuối)                                                  |    
    | addAll()       | thêm tất cả các phần tử của một list này vào list khác                                 |     
    | get()          | giúp truy cập ngẫu nhiên các phần tử từ list                                           |   
    | iterator()     | trả về đối tượng iterator có thể được sử dụng để truy cập tuần tự các phần tử của list |  
    | set()          | thay đổi các phần tử của list                                                          |          
    | remove()       | xóa một phần tử khỏi list                                                              |       
    | removeAll()    | loại bỏ tất cả các phần tử khỏi list                                                   |     
    | clear()        | loại bỏ tất cả các phần tử khỏi list (hàm này hiệu quả hơn hàm removeAll())            |            
    | size()         | trả về độ dài của list                                                                 |     
    | toArray()      | chuyển đổi một list thành một mảng                                                     |   
    | contains()     | trả về true nếu một list chứa phần tử được chỉ định                                    |       

### ArrayList
    - ArrayList (đối tượng của class ArrayList) có thể tự động điều chỉnh kích cỡ của nó khi chúng ta thêm vào hoặc xóa đi các phần tử. Do đó, ArrayList còn được gọi là mảng động.

    !!! không thể tạo danh sách các mảng thuộc kiểu dữ liệu cơ bản như int, float, char, v.v Thay vào đó, ta phải sử dụng class bao bọc tương ứng của chúng.

    - sử dụng hàm asList() để chuyển Array thành ArrayList
        ArrayList<String> animals = new ArrayList<>(Arrays.asList("Cat", "Cow", "Dog"));

    - sử dụng hàm sort() trong class collection để sắp xếp (theo thứ tự bảng chữ cái hoặc giá trị tăng dần)
        Collections.sort(animals);

    - sử dụng lại các hàm của List interface

    - một số hàm thêm 
    | clone()	        | Tạo một ArrayList mới với cùng phần tử, kích thước và dung lượng.                |    
    | contains()	    | Tìm kiếm ArrayList cho phần tử đã chỉ định và trả về kết quả boolean.            |     
    | ensureCapacity()	| Chỉ định tổng phần tử mà ArrayList có thể chứa.                                  |      
    | isEmpty()	        | Kiểm tra nếu ArrayList trống.                                                    |      
    | indexOf()	        | Tìm kiếm một phần tử được chỉ định trong ArrayList và trả về chỉ số của phần tử. |  
    | trimToSize()	    | Giảm dung lượng của một ArrayList về kích thước hiện tại của nó.                 |   

### Vector
    - Class Vector triển khai List interface cho phép chúng ta tạo mảng động tương tự như ArrayList class.
    - Sử dụng hàm tương tự ArrayList

    - Điểm khác nhau:
        + Class Vector đồng bộ từng toán tử một. Điều này có nghĩa là bất cứ khi nào chúng ta muốn thực hiện toán tử trên các vector, class Vector sẽ tự động áp dụng khóa cho thao tác đó.
        + Đó là bởi vì khi một luồng đang truy cập vào một vector, đồng thời một luồng khác cố gắng truy cập vào nó, một exception tên ConcurrentModificationException sẽ được tạo ra. Do đó, 
        việc sử dụng khóa một cách liên tục cho mỗi toán tử này làm cho vector kém hiệu quả hơn.
        + Tuy nhiên, trong ArrayList, các phương thức không được đồng bộ hóa. Thay vào đó, nó sử dụng hàm Collections.synchronizedList() để đồng bộ hóa toàn bộ danh sách.

    *** ConcurrentModificationException
        + ConcurrentModificationException là một loại ngoại lệ (exception) trong Java được ném ra khi một luồng (thread) thay đổi một cấu trúc dữ liệu mà một luồng khác đang truy cập vào cùng 
        một thời điểm. Thông thường, nó xảy ra khi bạn đang duyệt qua một cấu trúc dữ liệu như một ArrayList, HashMap, HashSet bằng cách sử dụng một vòng lặp for-each hoặc Iterator, trong khi 
        một luồng khác thực hiện các thao tác thay đổi (thêm, xóa) trên cấu trúc dữ liệu đó.

        + Khi điều này xảy ra, nó thường là kết quả của việc không đồng bộ hóa (synchronization) giữa các luồng. Để tránh ConcurrentModificationException, bạn cần đảm bảo rằng tất cả các truy 
        cập vào cấu trúc dữ liệu được đồng bộ hóa (synchronized), hoặc sử dụng các cấu trúc dữ liệu có sẵn trong gói java.util.concurrent, chúng đã được thiết kế để xử lý vấn đề này một cách 
        an toàn cho luồng.
    
    !!! Nên sử dụng ArrayList thay cho Vector vì vector không phải là một luồng an toàn và nó kém hiệu quả.

### Stack
    - Collections framework trong Java có một class tên là Stack cung cấp chức năng của cấu trúc dữ liệu stack. Class Stack là một class phụ của class Vector.
        Stack extends Vector

    - Trong class stack, các phần tử được lưu trữ và truy cập theo cơ chế Last In First Out.
    - Sử dụng các hàm tương tự Vector
    - Các hàm thêm 
    | push()    | Để thêm một phần tử vào đầu stack (thêm cuối)                               |         
    | pop()     | Để loại bỏ một phần tử khỏi đỉnh stack (xóa cuối)                           |     
    | peek()    | Trả về đối tượng ở phía trên cùng của stack                                 |      
    | search()  | Để tìm kiếm một phần tử trong stack, trả về vị trí của phần tử ở đỉnh stack | 
    | empty()   | Để kiểm tra xem một stack có trống hay không                                |   

    !!! Class Stack triển khai trực tiếp cấu trúc dữ liệu stack. Tuy nhiên, chúng ta không nên sử dụng nó. Thay vào đó, nên sử dụng class ArrayDeque (class này triển khai Deque interface) để 
    triển khai cấu trúc dữ liệu stack trong Java.

### LinkedList
    - Class LinkedList của collections framework trong Java cung cấp các chức năng của cấu trúc dữ liệu LinkedList.

    - Class LinkedList triển khai các interface: List, Queue, Deque

    - Class LinkedList trong Java triển khai danh sách liên kết đôi

    - Mỗi phần tử trong một LinkedList được gọi là một nút . Nó bao gồm 3 trường:
        + Prev: Lưu địa chỉ của phần tử trước trong list. Trả về null đối với các phần tử đầu tiên.
        + Next: Lưu trữ địa chỉ của phần tử tiếp theo trong danh sách. Trả về null đối với các phần tử cuối cùng.
        + Data: Lưu trữ dữ liệu thực.

    - LinkedList sử dụng các hàm của cá interface mà nó triển khai. 
    - Điểm khác biệt là bên cạnh hàm iterator() thêm hàm listIterator() để phù hợp.
    - Hàm removeIf() để xóa các phần tử khỏi LinkedList nếu chúng thỏa mãn một điều kiện nhất định 
        animals.removeIf((Integer i)->i < 4);

### Queue
    - Queue interface của collections framework trong Java cung cấp các chức năng của cấu trúc dữ liệu queue. Nó là một class trong  Collection interface.

    - Các class triển khai: Class ArrayDeque, Class LinkedList, Class PriorityQueue

    - Các subinterface: Deque, BlockingQueue, BlockingDeque

    - Trong queue, các phần tử được lưu trữ và truy cập theo cách First In First Out.

    - Một số hàm thường được sử dụng trong Queue interface
    | add()             | Chèn phần tử đã chỉ định vào queue. Nếu thực hiện thành công, hàm add() trả về true, còn không thì nó sẽ ném ra một ngoại lệ (throw an exception). |  
    | Offer()           | Chèn phần tử đã chỉ định vào queue. Nếu thực hiện thành công, hàm offer() trả về true, nếu không nó sẽ trả về false.                               |       
    | element()         | Trả về phần tử đầu tiên của queue.  Nếu queue trống sẽ ném một ngoại lệ.                                                                           |                                     
    | peek()            | Trả về phần tử đầu tiên của queue. Nếu queue trống thì trả về null.                                                                                |                                
    | remove()          | Trả về và xóa phần tử đầu của queue. Nếu queue trống sẽ ném ra một ngoại lệ (throw an exception).                                                  |                         
    | poll()            | Trả về và loại bỏ phần tử đầu của queue. Nếu queue trống sẽ trả về null.                                                                           |
    | addFirst ()       | Thêm phần tử được chỉ định vào đầu deque. Nếu deque đã đầy thì ném một ngoại lệ.                                                                   |
    | addLast ()        | Thêm phần tử được chỉ định vào cuối deque. Nếu deque đã đầy thì ném một ngoại lệ.                                                                  |
    | OfferFirst ()     | Thêm phần tử được chỉ định vào đầu deque. Trả về false nếu deque đã đầy.                                                                           |
    | OfferLast ()      | Thêm phần tử được chỉ định vào cuối deque. Trả về false nếu deque đã đầy.                                                                          |
    | getFirst ()       | Trả về phần tử đầu tiên của deque. Nếu deque trống thì ném một ngoại lệ.                                                                           |
    | getLast ()        | Trả về phần tử cuối cùng của deque. Nếu deque trống thì ném một ngoại lệ.                                                                          |
    | peekFirst ()      | Trả về phần tử đầu tiên của deque. Trả về null nếu deque trống.                                                                                    |
    | peekLast ()       | Trả về phần tử cuối cùng của deque. Trả về null nếu deque trống.                                                                                   |
    | removeFirst ()    | Trả về và xóa phần tử đầu tiên của deque. Nếu deque trống thì ném một ngoại lệ.                                                                    |
    | removeLast ()     | Trả về và xóa phần tử cuối cùng của deque. Nếu deque trống thì ném một ngoại lệ.                                                                   |
    | pollFirst ()      | Trả về và loại bỏ phần tử đầu tiên của deque. Trả về null nếu deque trống.                                                                         |
    | pollLast ()       | Trả về và loại bỏ phần tử cuối cùng của deque. Trả về null nếu deque trống.                                                                        |                                  

### PriorityQueue
    - Class PriorityQueue cung cấp các hàm của cấu trúc dữ liệu đống. Nó triển khai interface Queue.

    - Không giống như các queue thông thường, các phần tử trong priority queue được lấy theo thứ tự được sắp xếp.

    !!! Điều quan trọng cần lưu ý là các phần tử của priority queue có thể không được sắp xếp. Tuy nhiên, chúng (các phần tử) luôn được lấy ra theo thứ tự sắp xếp.

    - Chúng ta có thể tùy chỉnh thứ tự các phần tử với Comparator interface

    - Class PriorityQueue triển khai tất cả các hàm có trong Queue interface

    - Các hàm thêm trong PriorityQueue
    | contains(element)	| Tìm kiếm một phần tử được chỉ định trong priority queue. Nếu phần tử được tìm thấy, hàm này trả về true, nếu không thì nó trả về false. |  
    | size()	        | Trả về độ dài của priority queue.                                                                                                       |  
    | toArray()	        | Chuyển đổi một priority queue thành một mảng và trả về nó.                                                                              |                           

### Deque
    - Deque interface của collections framework trong Java cung cấp các chức năng của một hàng đợi hai đầu. Nó được mở rộng từ Queue interface.

    - Trong một deque, chúng ta có thể chèn và loại bỏ các phần tử từ cả phía trước và phía sau.

    - Các class triển khai: ArrayDeque, LinkedList

    - Nên sử dụng Deque làm stack thay vì dùng class Stack . Đó là bởi vì các hàm trong Stack đều được đồng bộ hóa.

    - Các hàm mà Deque interface cung cấp để thực hiện stack:
    | push()    | thêm một phần tử ở đầu deque    | 
    | pop()     | loại bỏ một phần tử ở đầu deque |    
    | peek()    | trả về một phần tử ở đầu deque  |   

### BlockingQueue (java.util.concurrent.BlockingQueue)
    - BlockingQueue interface của Collections framework trong Java mở rộng Queue interface. Nó cho phép mọi thao tác chờ cho đến khi có thể thực hiện thành công.

    - Các class triển khai: ArrayBlockingQueue, LinkedBlockingQueue

    - Dựa trên việc queue đã đầy hay trống, các hàm của BlockingQueue có thể được chia thành 3 loại:
        + Các hàm ném một ngoại lệ
        | add()     | Chèn một phần tử vào BlockingQueue ở cuối queue. Ném một ngoại lệ nếu queue đã đầy. |   
        | element() | Trả về phần tử đầu của BlockingQueue. Ném một ngoại lệ nếu queue trống.             |  
        | remove()  | Loại bỏ một phần tử khỏi BlockingQueue. Ném một ngoại lệ nếu queue trống.           |   

        + Các hàm trả về một số giá trị
        | offer() | Chèn phần tử được chỉ định vào BlockingQueue ở cuối queue. Trả về false nếu queue đầy. |  
        | peek()  | Trả về phần tử đầu của BlockingQueue. Trả về null nếu queue trống.                     |  
        | poll()  | Loại bỏ một phần tử khỏi BlockingQueue. Trả về null nếu queue trống.                   | 

        !!! Các hàm offer()và poll() có thể được sử dụng với thời gian chờ
            offer(value, 100, milliseconds)
        !!! Thay vì milliseconds, chúng ta cũng có thể sử dụng các đơn vị thời gian: days, hours, minutes, seconds, microseconds và nanoseconds ở hàm offer() và poll().

        + Các hàm để chặn thao tác
        | put()  | Chèn một phần tử vào BlockingQueue. Nếu queue đầy, nó sẽ đợi cho đến khi queue có khoảng trống để chèn một phần tử.        | 
        | take() | Loại bỏ và trả về một phần tử từ BlockingQueue. Nếu queue trống, nó sẽ đợi cho đến khi queue có các phần tử để có thể xóa. | 

    - Trong Java, BlockingQueue được coi là collection an toàn luồng . Đó là bởi vì nó có thể hữu ích trong các thao tác đa luồng.

### ArrayBlockingQueue (java.util.concurrent.ArrayBlockingQueue)
    - Class ArrayBlockingQueue của Collections framework trong Java triển khai blocking queue bằng cách sử dụng mảng.

    !!! Bắt buộc phải cung cấp kích thước của mảng.

    - Sử dụng các hàm của BlockingQueue 

    | add()             | Chèn phần tử được chỉ định vào ArrayBlockingQueue. Nó ném một ngoại lệ nếu queue đã đầy.                                               |        
    | offer()           | Chèn phần tử được chỉ định vào ArrayBlockingQueue. Nó trả về false nếu queue đã đầy.                                                   |      
    | peek()            | Trả về một phần tử từ phần đầu của ArrayBlockingQueue. Nó trả về null nếu queue trống.                                                 |  
    | iterator()        | Trả về một đối tượng lặp để truy cập tuần tự các phần tử của ArrayBlockingQueue. Nó ném một ngoại lệ nếu queue trống.                  |       
    | remove()          | Trả về và xóa một phần tử đã chỉ định khỏi ArrayBlockingQueue. Nó ném một ngoại lệ nếu queue trống.                                    |   
    | poll()            | Trả về và xóa một phần tử đã chỉ định khỏi ArrayBlockingQueue. Nó trả về null nếu queue trống.                                         |  
    | clear()           | Loại bỏ tất cả các phần tử khỏi ArrayBlockingQueue.                                                                                    |       
    | put()             | Nếu ArrayBlockingQueue đã đầy, nó sẽ đợi cho đến khi có khoảng trống trong ArrayBlockingQueue để thêm một phần tử.                     |    
    | take()            | Nếu ArrayBlockingQueue trống, nó sẽ đợi cho đến khi có các phần tử trong ArrayBlockingQueue để có thể xóa.                             |  
    | contains(element) | Tìm kiếm trong ArrayBlockingQueue một phần tử được chỉ định. Nếu phần tử được tìm thấy, nó trả về true, nếu không thì nó trả về false. |  
    | size()	        | Trả về độ dài của ArrayBlockingQueue.                                                                                                  |    
    | toArray()	        | Chuyển đổi ArrayBlockingQueue thành một mảng và trả về nó.                                                                             |     
    | toString()	    | Chuyển đổi ArrayBlockingQueue thành chuỗi                                                                                              |    

    - ArrayBlockingQueue sử dụng mảng như lưu trữ nội bộ của nó. Nó được coi là một collection an toàn luồng. Do đó, nó thường được sử dụng trong các ứng dụng đa luồng. Giả sử, một luồng 
    đang chèn các phần tử vào queue và một luồng khác đang xóa các phần tử khỏi queue. Bây giờ, nếu luồng đầu tiên chậm hơn luồng thứ hai, thì ArrayBlockingQueue có thể làm cho luồng thứ 
    hai chờ cho đến khi luồng đầu tiên hoàn thành các thao tác của nó.

### ArrayDeque (java.util.ArrayDeque)
    - Trong Java, chúng ta có thể sử dụng lớp ArrayDeque để triển khai các cấu trúc dữ liệu hàng đợi và deque bằng cách sử dụng mảng.

    - ArrayDeque triển khai các interface: Queue, Deque

    - Sử dụng các hàm của Queue và Deque

    | add()                 | chèn phần tử được chỉ định vào cuối mảng deque                                                                            |                     
    | addFirst()            | chèn phần tử được chỉ định vào đầu mảng deque                                                                             |                    
    | addLast()             | chèn giá trị được chỉ định vào cuối mảng deque (tương đương với add())                                                    |                                             
    | offer()               | chèn phần tử được chỉ định vào cuối mảng deque                                                                            |                     
    | offerFirst()          | chèn phần tử được chỉ định vào đầu mảng deque                                                                             |                    
    | offerLast()           | chèn phần tử được chỉ định vào cuối mảng deque                                                                            |                     
    | getFirst()            | trả về phần tử đầu tiên của mảng deque                                                                                    |             
    | getLast()             | trả về phần tử cuối cùng của mảng deque                                                                                   |                                                                                                              
    | peek()                | trả về phần tử đầu tiên của mảng deque                                                                                    |             
    | peekFirst()           | trả về phần tử đầu tiên của mảng deque (tương đương với peek())                                                           |                                      
    | peekLast()            | trả về phần tử cuối cùng của mảng deque                                                                                   |              
    | remove()              | trả về và xóa một phần tử khỏi phần tử đầu tiên của mảng deque                                                            |                                     
    | remove(element)       | trả về và xóa phần tử được chỉ định khỏi phần đầu của mảng deque                                                          |                                       
    | removeFirst()         | trả về và xóa phần tử đầu tiên khỏi mảng deque (tương đương với remove())                                                 |                                                
    | removeLast()          | trả về và xóa phần tử cuối cùng khỏi mảng deque                                                                           |                      
    | poll()                | trả về và xóa phần tử đầu tiên của mảng deque                                                                             |                    
    | pollFirst()           | trả về và xóa phần tử đầu tiên của mảng deque (tương đương với poll())                                                    |                                             
    | pollLast()            | trả về và xóa phần tử cuối cùng của mảng deque                                                                            |                     
    | clear ()              | Để xóa tất cả các phần tử khỏi mảng deque                                                                                 |                
    | iterator()            | trả về một trình lặp có thể được sử dụng để lặp lại trên mảng deque                                                       |                                          
    | descendingIterator()  | trả về một trình lặp có thể được sử dụng để lặp lại trên mảng deque theo thứ tự ngược lại                                 |                                                                
    | element()	            | Trả về một phần tử từ phần đầu của mảng deque.                                                                            |                     
    | contains(element)     | Tìm kiếm mảng deque cho phần tử được chỉ định.Nếu phần tử được tìm thấy, nó sẽ trả về true, nếu không nó sẽ trả về false. |  
    | size()	            | Trả về độ dài của mảng deque.                                                                                             |    
    | toArray()	            | Chuyển đổi deque mảng thành mảng và trả về nó.                                                                            |                     
    | clone()	            | Tạo một bản sao của mảng deque và trả về nó.                                                                              |                   
    | push()                | thêm một phần tử vào đầu ngăn xếp                                                                                         |        
    | peek()                | trả về một phần tử từ trên cùng của ngăn xếp                                                                              |                   
    | pop()                 | trả về và xóa một phần tử khỏi đầu ngăn xếp                                                                               |                  

    !!! Nếu deque mảng đầy, tất cả các phương thức này: add(), addFirst()và addLast() sẽ ném ra IllegalStateException.
    
    !!! offer() , offerFirst()và offerLast() trả về true nếu phần tử được chèn thành công; nếu mảng deque đầy, các phương thức này trả về false.
    
    !!! Nếu deque mảng trống getFirst()và getLast()ném ra NoSuchElementException.
    
    !!! Nếu deque mảng rỗng, peek(), peekFirst()và getLast()ném NoSuchElementException.
    
    !!! Nếu deque mảng trống phương thứcremove(), removeFirst()và removeLast() ném ra một ngoại lệ. Ngoài ra, remove(element)ném một ngoại lệ nếu phần tử không được tìm thấy.
    
    !!! Nếu deque mảng là rỗng, poll(), pollFirst()và pollLast()sẽ trả về null nếu phần tử không được tìm thấy.
    
    *** IllegalStateException
        + IllegalStateException là một loại ngoại lệ (exception) trong Java được ném ra khi một phương thức được gọi trong một trạng thái không hợp lệ. Trạng thái không hợp lệ có 
        thể là do nhiều nguyên nhân khác nhau, nhưng thường là do một hoạt động không thể được thực hiện trong một điều kiện cụ thể.

        + Ví dụ, một IllegalStateException có thể xảy ra khi:
            * Gọi một phương thức khi đối tượng không ở trong trạng thái chấp nhận được. Ví dụ, gọi start() trên một luồng đã kết thúc.
            * Thực hiện một thao tác không hợp lệ trên một đối tượng. Ví dụ, thử ghi vào một BufferedWriter đã đóng.
            * Một thuộc tính hoặc trạng thái đã được thiết lập một cách không đồng nhất.

        + Khi một IllegalStateException được ném ra, nó thường cho biết rằng có một vấn đề trong mã của bạn cần phải được giải quyết, chẳng hạn như kiểm tra điều kiện trước khi gọi 
        phương thức hoặc đảm bảo rằng đối tượng đang ở trong trạng thái đúng để thực hiện hành động mong muốn.

    *** NoSuchElementException
        + NoSuchElementException là một loại ngoại lệ (exception) trong Java được ném ra khi bạn cố gắng truy cập một phần tử trong một cấu trúc dữ liệu có chỉ số hoặc iterator mà 
        không có phần tử nào tồn tại ở vị trí cụ thể đó.

        + Ví dụ, nếu bạn cố gắng gọi phương thức next() trên một iterator của một danh sách khi không còn phần tử nào để lặp qua, hoặc nếu bạn cố gắng gọi next() sau khi phương thức 
        hasNext() đã trả về false, một NoSuchElementException sẽ được ném ra.

        + Để tránh NoSuchElementException, bạn cần kiểm tra trước khi truy cập phần tử, bằng cách sử dụng phương thức hasNext() trong trường hợp của Iterator, hoặc kiểm tra vị trí chỉ 
        số trước khi truy cập vào một danh sách.

    - Cả hai ArrayDeque và Java LinkedList thực hiện interface Deque. Tuy nhiên, tồn tại một số khác biệt giữa chúng.
        + LinkedList hỗ trợ các phần tử null, trong khi ArrayDeque thì không.
        + Mỗi nút trong danh sách liên kết bao gồm các liên kết đến các nút khác. Đó là lý do tại sao LinkedList yêu cầu lưu trữ nhiều hơn ArrayDeque.
        + Nếu bạn đang triển khai hàng đợi hoặc cấu trúc dữ liệu deque, một ArrayDeque có thể nhanh hơn a LinkedList.

### LinkedBlockingQueue (java.util.concurrent.LinkedBlockingQueue)
    - Class LinkedBlockingQueue của Collections framework trong Java  triển khai blocking queue bằng cách sử dụng LinkedList.

    !!! Không bắt buộc phải đưa ra kích thước của LinkedList. mặc định sẽ là 2^(31-1)

    - Sử dụng các hàm của BlockingQueue
    | add()             | Chèn một phần tử được chỉ định vào LinkedBlockingQueue. Nó ném một ngoại lệ nếu queue đã đầy.                                                                                |                                                         
    | offer()           | Chèn một phần tử được chỉ định vào LinkedBlockingQueue. Nó trả về false nếu queue đã đầy.                                                                                    |                                                     
    | peek()            | Trả về một phần tử ở phần đầu của LinkedBlockingQueue. Nó trả về null nếu queue trống.                                                                                       |                                                  
    | iterator()        | Trả về một đối tượng lặp để truy cập tuần tự một phần tử từ LinkedBlockingQueue. Nó ném một ngoại lệ nếu queue trống.                                                        |                                                                                 
    | remove()          | Trả về và xóa một phần tử đã chỉ định khỏi LinkedBlockingQueue. Nó ném một ngoại lệ nếu queue trống.                                                                         |                                                                
    | poll()            | Trả về và xóa một phần tử đã chỉ định khỏi LinkedBlockingQueue. Nó trả về null nếu queue trống.                                                                              |                                                           
    | clear()           | Loại bỏ tất cả các phần tử khỏi LinkedBlockingQueue.                                                                                                                         |                
    | put()             | Để chèn phần tử được chỉ định vào cuối LinkedBlockingQueue. Nếu LinkedBlockingQueue đã đầy, nó sẽ đợi cho đến khi có khoảng trống trong LinkedBlockingQueue để chèn phần tử. |  
    | take()            | Để trả về và xóa một phần tử từ phía trước LinkedBlockingQueue. Nếu LinkedBlockingQueue trống, nó sẽ đợi cho đến khi có các phần tử trong LinkedBlockingQueue để có thể xóa. |  
    | contains(element) | Tìm kiếm phần tử được chỉ định trong LinkedBlockingQueue. Nếu phần tử được tìm thấy, nó trả về true, nếu không nó trả về false.                                              |                                                                                           
    | size()	        | Trả về độ dài của LinkedBlockingQueue.                                                                                                                                       |  
    | toArray()	        | Chuyển đổi LinkedBlockingQueue thành một mảng và trả về mảng.                                                                                                                |                         
    | toString()	    | Chuyển đổi LinkedBlockingQueue thành chuỗi                                                                                                                                   |      

    *** InterruptedException 
        + InterruptedException là một loại ngoại lệ (exception) trong Java được ném ra khi một luồng (thread) đang trong trạng thái đang chờ (waiting), ngủ (sleeping) hoặc đang trong một 
        hoạt động blocked (chặn) khác bị gián đoạn bởi một luồng khác gọi phương thức interrupt() trên luồng đó.
        
        + Các hoạt động như Thread.sleep(), Object.wait(), Thread.join() đều có thể ném ra ngoại lệ InterruptedException nếu luồng đang trong trạng thái chờ bị gián đoạn. Điều này thường 
        xảy ra khi một luồng khác muốn kết thúc một luồng khác hoặc yêu cầu nó hủy bỏ (cancel).
        
        + Khi một InterruptedException được ném ra, luồng sẽ thoát khỏi trạng thái đang chờ và thường là cần phải xử lý nó một cách cẩn thận. Có thể xử lý nó bằng cách sử dụng các phương 
        thức như Thread.currentThread().interrupt() để đặt lại cờ interrupt hoặc xử lý nó theo cách phù hợp với logic ứng dụng của bạn.

### Map (java.util.Map)
    - Map interface của collections framework trong Java cung cấp các chức năng của cấu trúc dữ liệu map. Nó triển khai Collection interface.

    - Trong Java, các phần tử của Map được lưu trữ trong các cặp key/ value. Key là các giá trị duy nhất được liên kết với các value riêng lẻ. Một map không thể chứa các key trùng lặp. Mỗi 
    key được liên kết với một giá trị duy nhất.

    !!! Map interface duy trì 3 bộ khác nhau:
        + Bộ key
        + Bộ value
        + Bộ liên kết key/value (map)

    - Các class triển khai Map: HashMap, EnumMap, LinkedHashMap, WeakHashMap, TreeMap

    - Các subinterface: SortedMap, NavigableMap, ConcurrentMap

    - Sử dụng các hàm của Collection interface và các hàm thêm

    | put (K, V)                        | Chèn liên kết của key K và value V vào map. Nếu key đã có sẵn, value mới sẽ thay thế value cũ.           |                                                        
    | putAll ()                         | Chèn tất cả các mục từ map đã chỉ định vào map hiện tại.                                                 |                  
    | putIfAbsent (K,V)                 | Chèn liên kết nếu key K chưa được liên kết với value V.                                                  |                 
    | get (K)                           | Trả về value được liên kết với key K được chỉ định. Nếu không tìm thấy key, nó sẽ trả về null.           | 
    | getOrDefault (K, defaultValue)    | Trả về value được liên kết với key k được chỉ định. Nếu không tìm thấy key, nó sẽ trả về value mặc định. |  
    | containsKey (K)                   | Kiểm tra xem key được chỉ định K đã có trong map chưa.                                                   |                
    | containsValue (V)                 | Kiểm tra xem value v được chỉ định đã có trong map chưa.                                                 |                  
    | replace (K, V)                    | Thay thế value của key K với value v được chỉ định mới.                                                  |                 
    | replace (K, oldValue, newValue)   | Thay thế value của key K với value mới là newValue nếu key K được liên kết với value oldValue.           |                                                        
    | remove (K)                        | Xóa mục được đại diện bởi key K khỏi map.                                                                |   
    | remove (K, V)                     | Xóa mục có key K liên kết với value V khỏi map.                                                          |         
    | keyset ()                         | Trả về một tập hợp gồm tất cả các key có trong map.                                                      |             
    | value ()                          | Trả về tập hợp tất gồm cả các value có trong map.                                                        |           
    | entryset ()                       | Trả về tập hợp gồm tất cả cặp key / value có trong map.                                                  |                 

### HashMap (java.util.HashMap)
    - Class HashMap của collections framework trong Java triển khai bảng băm của Map interface
            HashMap<Key, Value> numbers = new HashMap<>(8, 0.6f);

        + capacity  – Dung lượng của HashMap này là 8. Ý nghĩa: nó có thể lưu trữ 8 mục. (mặc định là 16)
        + loadFactor – Hệ số tải của hashmap này là 0,6. Điều này có nghĩa là bất cứ khi nào bảng băm của chúng ta được lấp đầy 60%, các mục mới sẽ được chuyển sang bảng băm mới có kích thước 
        gấp đôi bảng băm ban đầu. (mặc định là 0.75)

















