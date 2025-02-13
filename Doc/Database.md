# DATABASE

## 🤔Cơ sở dữ liệu (Database) là gì?

Một tập hợp có cấu trúc của những dữ liệu có liên quan với nhau được lưu trữ trong máy tính. Một CSDL biểu diễn một phần của thế giới thực. CSDL được thiết kế, xây dựng, và lưu trữ với một mục đích xác định, phục vụ cho một số ứng dụng và người dùng.

*❗Tập ngẫu nhiên của các dữ liệu không thể xem là một CSDL*

Đặc điểm của cơ sở dữ liệu:

- Tổ chức có cấu trúc: Dữ liệu thường được lưu trữ theo dạng bảng, bản ghi (record), và trường (field) trong các **hệ quản trị cơ sở dữ liệu quan hệ (RDBMS)**.

- Tính toàn vẹn và nhất quán: Đảm bảo dữ liệu không bị sai lệch hoặc xung đột.

- Tính bảo mật: Hạn chế quyền truy cập để bảo vệ dữ liệu khỏi các truy cập trái phép.

- Khả năng truy vấn và tìm kiếm: Cho phép tìm kiếm và lọc dữ liệu nhanh chóng bằng các ngôn ngữ như SQL.

- Tính độc lập dữ liệu: Thay đổi cấu trúc dữ liệu không ảnh hưởng đến chương trình sử dụng dữ liệu.

Phân loại cơ sở dữ liệu:

- Cơ sở dữ liệu quan hệ (Relational Database - RDBMS): Sử dụng bảng (table) để lưu trữ dữ liệu. *Ví dụ: MySQL, PostgreSQL, SQL Server, Oracle.*

- Cơ sở dữ liệu phi quan hệ (NoSQL Database): Không sử dụng bảng mà dùng document, key-value, graph, hoặc column-family. *Ví dụ: MongoDB, Firebase, Cassandra, Redis.*

- Cơ sở dữ liệu phân tán (Distributed Database): Dữ liệu được lưu trữ trên nhiều máy chủ để đảm bảo hiệu suất và dự phòng lỗi. *Ví dụ: Apache Cassandra, Google Spanner.*

## 🤔Hệ quản trị CSDL (Database Management System) là gì?

Hệ quản trị cơ sở dữ liệu (DBMS) là phần mềm giúp tạo, quản lý và tương tác với cơ sở dữ liệu một cách hiệu quả. Nó cho phép người dùng lưu trữ, truy vấn, cập nhật và bảo vệ dữ liệu mà không cần thao tác trực tiếp với file dữ liệu thô.

Chức năng của DBMS:

- Quản lý dữ liệu: Lưu trữ, tổ chức và duy trì dữ liệu một cách có cấu trúc.

- Truy vấn và xử lý dữ liệu: Cho phép tìm kiếm, lọc dữ liệu bằng SQL hoặc các công cụ khác.

- Kiểm soát truy cập: Quản lý quyền của người dùng, bảo vệ dữ liệu khỏi truy cập trái phép.

- Đảm bảo tính toàn vẹn dữ liệu: Giữ cho dữ liệu không bị trùng lặp hoặc sai lệch.

- Hỗ trợ giao dịch (Transaction Management): Đảm bảo tính nhất quán khi nhiều người cùng thao tác trên dữ liệu.

- Sao lưu và khôi phục dữ liệu: Giúp phục hồi dữ liệu trong trường hợp lỗi hoặc mất dữ liệu.

Các loại hệ quản trị CSDL phổ biến:

- Hệ quản trị CSDL quan hệ (Relational DBMS - RDBMS): Lưu trữ dữ liệu dưới dạng bảng có hàng (record) và cột (field). Dữ liệu có thể liên kết với nhau thông qua khóa. *Ví dụ: MySQL, PostgreSQL, SQL Server, Oracle, MariaDB*

- Hệ quản trị CSDL phi quan hệ (NoSQL DBMS): Lưu trữ dữ liệu dưới dạng key-value, document, graph hoặc column-family, phù hợp với dữ liệu phi cấu trúc. *Ví dụ: MongoDB (document), Redis (key-value), Neo4j (graph), Cassandra (column-family)*

- Hệ quản trị CSDL hướng đối tượng (Object-Oriented DBMS - OODBMS): Dữ liệu được lưu dưới dạng đối tượng giống như trong lập trình hướng đối tượng (OOP). *Ví dụ: ObjectDB, db4o*

- Hệ quản trị CSDL phân tán (Distributed DBMS - DDBMS): Dữ liệu được lưu trữ trên nhiều máy chủ khác nhau, giúp tăng tốc độ truy xuất và khả năng chịu lỗi. *Ví dụ: Google Spanner, Apache Cassandra*

| DBMS       | Loại              | Ứng dụng thực tế                                     |
| ---------- | ----------------- | ---------------------------------------------------- |
| MySQL      | RDBMS             | Website, ứng dụng doanh nghiệp (WordPress, Facebook) |
| PostgreSQL | RDBMS             | Hệ thống phân tích dữ liệu, ứng dụng tài chính       |
| SQL Server | RDBMS             | Doanh nghiệp, quản lý dữ liệu trong tổ chức          |
| MongoDB    | NoSQL             | Ứng dụng web động, lưu trữ JSON                      |
| Redis      | NoSQL (Key-Value) | Cache dữ liệu, xử lý real-time                       |
| Firebase   | NoSQL             | Ứng dụng mobile, realtime database                   |
| Oracle     | RDBMS             | Hệ thống doanh nghiệp lớn, ngân hàng                 |

## 🤔Kiến trúc của DBMS
    
Mức trong (lược đồ trong): Mô tả cấu trúc lưu trữ vật lý CSDL
    
Mức quan niệm (lược đồ quan niệm): Mô tả cấu trúc của toàn thể CSDL cho 1 cộng đồng người sử dụng, gồm thực thể, kiểu dữ liệu, mối liên hệ và ràng buộc. Che bớt các chi tiết của cấu trúc lưu trữ vật lý.
    
Mức ngoài (lược đồ ngoài): Còn gọi là mức khung nhìn (view). Mô tả một phần của CSDL mà 1 nhóm người dùng quan tâm đến và che dấu phần còn lại của CSDL đối với nhóm người dùng đó

Kiến trúc 1 tầng (1-Tier Architecture)
Người dùng thao tác trực tiếp với cơ sở dữ liệu mà không qua trung gian.
Phù hợp với các hệ thống nhỏ, single-user như Microsoft Access.
👉 Ưu điểm: Đơn giản, dễ triển khai.
👉 Nhược điểm: Không bảo mật, không hỗ trợ nhiều người dùng.

2.2. Kiến trúc 2 tầng (2-Tier Architecture)
Gồm Client và Database Server.
Ứng dụng (Client) gửi truy vấn SQL đến Server, Server xử lý và trả kết quả.
Thường sử dụng trong ứng dụng doanh nghiệp nhỏ.
👉 Ưu điểm: Nhanh hơn so với 1 tầng, có sự tách biệt giữa giao diện và dữ liệu.
👉 Nhược điểm: Chưa tối ưu khi có nhiều người dùng.

📌 Ví dụ: Ứng dụng WinForms kết nối trực tiếp SQL Server.

2.3. Kiến trúc 3 tầng (3-Tier Architecture)
Bao gồm Client (Giao diện) - Application Server (Logic) - Database Server (Dữ liệu).
Ứng dụng client không kết nối trực tiếp với DB mà thông qua Server trung gian (API, Web Services).
Dùng trong hệ thống lớn như Web, Mobile Apps.
👉 Ưu điểm: Bảo mật tốt, hiệu suất cao.
👉 Nhược điểm: Phức tạp hơn, cần cấu hình máy chủ trung gian.

📌 Ví dụ:

Web app: ReactJS (Client) ↔ .NET API (Server) ↔ SQL Server (DB).
Ứng dụng WinForms: WinForms ↔ Web API ↔ MongoDB.
2.4. Kiến trúc N-Tier (Multi-Tier Architecture)
Mở rộng kiến trúc 3 tầng, thêm các tầng như Load Balancer, Cache, Data Warehouse.
Được sử dụng trong các hệ thống lớn như ngân hàng, thương mại điện tử.
👉 Ưu điểm: Chia tải tốt, mở rộng dễ dàng.
👉 Nhược điểm: Cần hệ thống mạnh, chi phí cao.

📌 Ví dụ: Amazon, Google, Facebook sử dụng kiến trúc này để xử lý hàng triệu request mỗi giây.

3. So sánh các mô hình kiến trúc DBMS
Kiến trúc	Cấu trúc	Ứng dụng	Ưu điểm	Nhược điểm
1-Tier	Client ↔ DB	Hệ thống nhỏ	Đơn giản, nhanh	Bảo mật kém
2-Tier	Client ↔ DB Server	Ứng dụng doanh nghiệp nhỏ	Nhanh hơn 1-Tier	Chưa tối ưu khi mở rộng
3-Tier	Client ↔ App Server ↔ DB Server	Web App, Mobile App	Bảo mật tốt, dễ mở rộng	Cấu hình phức tạp hơn
N-Tier	Client ↔ Load Balancer ↔ App Server ↔ Cache ↔ DB	Hệ thống lớn như ngân hàng	Hiệu suất cao, chịu tải lớn	Chi phí cao

## 📚Các mô hình dữ liệu

    - Mô hình dữ liệu (Data Modling) là một quy trình được sử dụng với mục đích xác định và phân tích các yêu cầu dữ liệu cần thiết
    
    - Mô hình dữ liệu đóng vai trò quan trọng giúp tạo ra một mô hình chứa các dữ liệu cho hệ thống bằng cách áp dụng các kỹ thuật chuyên nghiệp. 
    
    - Mục đích chính của mô hình dữ liệu là tạo ra một phương pháp lưu trữ thông tin hiệu quả nhất, đồng thời cung cấp tập hợp quy trình truy cập và báo cáo hoàn chỉnh.

    - Các loại mô hình
        + Mô hình dữ liệu khái niệm
            * Các mô hình dữ liệu khái niệm mang lại cái nhìn toàn cảnh về dữ liệu. Loại mô hình dữ liệu này giải thích những thông số:
                \ Dữ liệu bên trong hệ thống
                \ Các thuộc tính dữ liệu và điều kiện hoặc ràng buộc về dữ liệu
                \ Các quy tắc kinh doanh liên quan đến dữ liệu
                \ Cách thức sắp xếp dữ liệu tốt nhất
                \ Các yêu cầu về bảo mật và tính toàn vẹn của dữ liệu

            * Các bên kinh doanh liên quan và nhà phân tích thường tạo ra mô hình khái niệm. Đó là một hình ảnh trình bày theo kiểu sơ đồ đơn giản không tuân theo quy tắc lập mô hình dữ liệu chính thức.
            * Sau khi mô hình dữ liệu khái niệm được hoàn thành, nó có thể điều chỉnh linh hoạt và chuyển sang mô hình dữ liệu logic.

        + Mô hình dữ liệu logic
            * Mô hình dữ liệu logic ánh xạ các lớp dữ liệu khái niệm với cấu trúc dữ liệu kỹ thuật. Loại mô hình này cung cấp thêm chi tiết về khái niệm dữ liệu và mối quan hệ dữ liệu phức tạp đã được xác 
            định trong mô hình dữ liệu khái niệm
                \ Các loại dữ liệu của nhiều thuộc tính khác nhau (ví dụ: chuỗi hoặc số)
                \ Mối quan hệ giữa các thực thể dữ liệu
                \ Thuộc tính chính hoặc trường chủ chốt trong dữ liệu

            * Các kiến trúc sư và nhà phân tích dữ liệu cùng nhau hợp tác để tạo ra mô hình logic. Họ tuân theo một trong số vài hệ thống lập mô hình dữ liệu chính thức để tạo ra hình ảnh trình bày. 
            * Mô hình này rất hữu ích đối với quá trình thiết kế các cơ sở dữ liệu lớn gọi là kho dữ liệu và quá trình thiết kế hệ thống báo cáo tự động.
            * Mô hình dữ liệu logic được phát triển như một nền tảng để thực thi mô hình dữ liệu vật lý.

        + Mô hình dữ liệu vật lý
            * Mô hình dữ liệu vật lý ánh xạ các mô hình dữ liệu logic với công nghệ DBMS cụ thể và sử dụng thuật ngữ của phần mềm. Loại mô hình này cung cấp chi tiết về những thông số:
                \ Loại trường dữ liệu như được biểu diễn trong DBMS
                \ Mối quan hệ dữ liệu như được biểu diễn trong DBMS
                \ Chi tiết bổ sung như tinh chỉnh hiệu suất

            * Các kỹ sư dữ liệu tạo ra mô hình vật lý trước khi triển khai bản thiết kế cuối cùng. Họ cũng tuân theo các kỹ thuật lập mô hình dữ liệu chính thức để đảm bảo đã bao quát tất cả các 
            khía cạnh của thiết kế.

    - Kĩ thuật lập mô hình dữ liệu:
        + Mô hình mạng (Network Data Model)    
        + Mô hình phân cấp (Hierachical Data Model)
        + Mô hình quan hệ (Relational Data Model)
        + Mô hình thực thể - liên kết (Entity - Relationship Model)
        + Mô hình hướng đối tượng (Object Oriented Data Model)

    - Các bước lập mô hình dữ liệu
        Bước 1: Xác định các thực thể và thuộc tính
        Bước 2: Xác định các mối quan hệ giữa những thực thể
        Bước 3: Xác định kỹ thuật lập mô hình dữ liệu
        Bước 4: Tối ưu hóa và lặp đi lặp lại

## 📚 Mô hình mạng (Network Data Model)
    - Là mô hình được biểu diễn bởi một đồ thị có hướng
    
    - Loại mẫu tin (Recorde Type) là mẫu đặc trưng cho 1 loại đối tượng riêng biệt
    
    - Loại liên kết (Set Type) là sự liên kết giữa một loại mẫu tin chủ với một loại mẫu tin thành viên
        + 1 - 1 (One-to-One): Mỗi mẫu tin của loại mẫu tin chủ chỉ liên kết với đúng 1 mẫu tin của loại mẫu tin thành viên.
        + 1 - n (One-to-Many): Mỗi mẫu tin của loại mẫu tin chủ chỉ liên kết với 1 hay nhiều mẫu tin của loại mẫu tin thành viên.
        + n -1 (Many-to-One): Nhiều mẫu tin của loại mẫu tin chủ chỉ liên kết với đúng 1 mẫu tin của loại mẫu tin thành viên.
        + Đệ quy (Recursive): Một loại mẫu tin chủ cũng có thể đồng thời là loại mẫu tin thành viên với chính nó.

    - Ưu điểm:
        + Dễ thể hiện mối liên kết M-N
        + Kiểu truy cập dữ liệu mềm dẻo hơn kiểu phân cấp

    - Nhược điểm:
        + Việc sửa đổi số liệu khó khăn.
        + Với những lập trình viên, việc thiết kế CSDL khó.
        + Dễ tạo thành chu trình

## 📚 Mô hình phân cấp (Hierachical Data Model)
    - Có cấu trúc cây (Tree), trong đó mỗi nút của cây biểu diễn một thực thể, giữa nút con và nút cha được liên kết với nhau theo một mối quan hệ xác định.
    
    - Loại mẫu tin: giống khái niệm mẫu tin trong mô hình dữ liệu mạng.
    
    - Loại mối liên kết: Kiểu liên kết là phân cấp, theo cách: Mẫu tin thành viên chỉ đóng vai trò thành viên của một mối liên kết duy nhất, tức là nó thuộc một chủ duy nhất. Như vậy, mối liên kết từ 
    mẫu tin chủ tới các mẫu tin thành viên là 1 - n, và từ mẫu tin thành viên với mẫu tin chủ là 1 –1.

    !!! Giữa 2 loại mẫu tin chỉ tồn tại 1 mối liên kết duy nhất.

    - Ưu điểm:
        + Thể hiện dễ dàng quan hệ 1-N.
        + Việc phân chia dữ liệu dễ thể hiện, đảm bảo an toàn dữ liệu
        + Tính độc lập của chương trình và các dữ liệu được đảm bảo
        
    - Nhược điểm:
        + Không thể hiện được mối quan hệ M-N
        + Trong một hệ thống phân cấp, dữ liệu được tổ chức như trên dẫn đến khó sửa đổi dữ liệu.

## 📚 Mô hình hướng đối tượng (Object Oriented Data Model)
\\ bổ sung OODM

## 📚 Mô hình thực thể - liên kết ER (Entity - Relationship Model)
    - Mục đích : Được dùng để thiết kế CSDL ở mức quan niệm. Biểu diễn trừu tượng cấu trúc của CSDL
    
    - Một thực thể là một đối tượng của thế giới thực  
    
    - Tập hợp các thực thể giống nhau tạo thành 1 tập thực thể 
        kí hiệu: hình chữ nhật, 1 đường
    
    - Thực thể yếu: là thực thể phụ thuộc vào sự tồn tại của thực thể khác
        kí hiệu: hình chữ nhật, 2 đường
    
    - Thuộc thính là những đặc tính riêng biệt của tập thực thể, là những giá trị nguyên tố
        kí hiệu: hình tròn hoặc eclip, 1 đường
    
    - Thuộc tính đơn (simple)/đơn trị (single-value)/nguyên tử (Atomic): chỉ có một giá trị trong một thuộc tính của một thực thể
    
    - Thuộc tính tổ hợp (Composite): được kết hợp của một số thành phần
    
    - Thuộc tính đa trị (multi-valued): có thể có nhiều giá trị tại một thời điểm.
        kí hiệu: hình tròn hoặc eclip, 2 đường
    
    - Thuộc tính suy diễn (derived attribute) là giá trị của nó có thể suy ra từ giá trị của những thuộc tính khác
        kí hiệu: hình tròn hoặc eclip, nét đứt

    - Giá trị rỗng của thuộc tính (Null Values): là thuộc tính có thể có giá trị hoặc không
    
    - Khoá (key) hay Thuộc tính định danh: là một hoặc một tập các thuộc tính xác định duy nhất một bản ghi trong một thực thể. Thuộc tính khoá hay 
    còn gọi là thuộc tính định danh luôn được gạch chân để phân biệt
        kí hiệu: hình tròn hoặc eclip, 1 đường, gạch chân tên thuộc tính
    
    - Thuộc tính khóa ngoại (Foreign Key) là một thuộc tính hoặc tập hợp các thuộc tính trong một bảng, được sử dụng để tạo liên kết giữa dữ liệu trong bảng này với dữ liệu trong một bảng khác.
        kí hiệu: hình tròn hoặc eclip, 1 đường, gạch chân nét đứt tên thuộc tính
    
    - Mối liên kết (Entity Relationship) là sự liên kết giữa 2 hay nhiều tập thực thể
        kí hiệu: hình thoi, 1 đường

    - Mối liên kết xác định (Identifying Relationship) là sự liên kết xác định giữa thực thể mạnh và thực thể yếu, thể hiện sự phụ thuộc
        kí hiệu: hình thoi, 2 đường 
    
    - Bậc của kiểu liên kết: Là số lượng các thực thể tham gia vào liên kết.
        + Kiểu liên kết bậc 1 (đệ quy) là mối quan hệ giữa cùng 1 kiểu thực thể.
        + Kiểu liên kết bậc 2 là mối liên kết giữa hai kiểu thực thể
        + Kiểu liên kết bậc 3 là mối liên kết giữa 3 kiểu thực thể
    
    - Ràng buộc liên kết gồm:
        + Liên kết/quan hệ 1-1: là mối quan hệ mà mỗi bản ghi trong thực thể E1 chỉ có nhiều nhất một bản ghi được liên kết trong thực thể E2.
        
        + Liên kết/quan hệ 1-N: là mối quan hệ mà một bản ghi trong thực thể E1 có thể không liên kết hoặc liên kết với một hay nhiều bản ghi trong 
        thực thể E2, nhưng một bản ghi trong thực thể E2 chỉ liên kết với duy nhất một bản ghi trong thực thể E1.
        
        + Liên kết/quan hệ N-M: là mối quan hệ mà một bản ghi trong thực thể có thể liên kết với nhiều bản thể trong thực thể khác và ngược lại.
        
        + Lực lượng của mối liên kết: Là số bản ghi lớn nhất và nhỏ nhất của thực thể tham gia vào liên kết đó.
            * (0,1) – không hoặc 1
            * (1,1) – duy nhất 1
            * (0,n) – không hoặc nhiều
            * (1,n) – một hoặc nhiều

            !!! Làm rõ hơn số lượng, tăng độ chính xác cho các ràng buộc liên kết khác
        
        + Thuộc tính của Liên kết/quan hệ: Mỗi mối liên kêt cũng có thể có những thuộc tính riêng của chúng.

## 📚 Mô hình quan hệ (Relational Data Model)
    - Các thông tin lưu trữ trong CSDL được tổ chức thành bảng (table) 2 chiều gọi là quan hệ
    
    - Quan hệ gồm:
        + Tên
        + Tập hợp các cột
            * Cố định
            * Được đặt tên
            * Có kiểu dữ liệu
        + Tập hợp các dòng
            * Thay đổi theo thời gian
    
    - Một dòng ~ Một thực thể
    
    - Quan hệ ~ Tập thực thể
    
    - Thuộc tính là các cột của quan hệ. Mô tả ý nghĩa cho các giá trị tại cột đó. Tất cả các dữ liệu trong cùng 1 một cột đều có chung kiểu dữ liệu
    
    - Bộ là các dòng của quan hệ (trừ dòng tiêu đề - tên của các thuộc tính). Thể hiện dữ liệu cụ thể của các thuộc tính trong quan hệ
    
    - Lược đồ quan hệ:
        + Tên của quan hệ
        + Tên của tập thuộc tính
            Cho A1, A2, ..., An là các thuộc tính 
            Có các miền giá trị D1, D2, ..., Dn tương ứng
            Ký hiệu R(A1:D1, A2:D2, ..., An:Dn) là một lược đồ quan hệ
        + Bậc của lược đồ quan hệ là số lượng thuộc tính trong lược đồ
    
    - Lược đồ CSDL gồm nhiều lược đồ quan hệ

    - Miền giá trị là tập các giá trị nguyên tố gắn liền với một thuộc tính

    - Các đặc trưng
        + Thứ tự các bộ trong quan hệ là không quan trọng
        + Thứ tự giữa các giá trị trong một bộ là quan trọng
        + Mỗi giá trị trong một bộ
            * Hoặc là một giá trị nguyên tố
            * Hoặc là một giá trị rỗng (null)
        + Không có bộ nào trùng nhau trong 1 quan hệ
        + Một quan hệ có một tên phân biệt với các quan hệ khác

    - Ký hiệu
        + Lược đồ quan hệ R bậc n
            R(A1, A2, ..., An)
        + Tập thuộc tính của R
            R+
        + Quan hệ (thể hiện quan hệ)
            R, S, P, Q
        + Bộ
            t, u, v
        + Miền giá trị của thuộc tính A
            DOM(A) hay MGT(A)
        + Giá trị tại thuộc tính A của bộ thứ t
            t.A hay t[A]

    !!! Các bộ trong quan hệ phải khác nhau từng đôi một
    
    - Siêu khóa (Supper key)
        + Gọi SK là một tập con khác rỗng các thuộc tính của R. SK là siêu khóa khi:
            * Siêu khóa là tập các thuộc tính dùng để xác định tính duy nhất của mỗi bộ trong quan hệ
            * Mọi lược đồ quan hệ có tối thiểu một siêu khóa

    - Khóa (Key)
        + Gọi K là một tập con khác rỗng các thuộc tính của R. K là khóa nếu thỏa đồng thời 2 điều kiện
            * K là một siêu khóa của R
            * Với mọi K' là tập con của K, K' != K, K' không là siêu khóa của R
        
        !!! Hiểu đơn giản thì Khóa là tập hợp Siêu khóa nhỏ nhất 
            VD: Kếtquả (MaSV, MaMH, LANTHI, DIEM)
                K = {MaSV, MaMH} -> K là siêu khóa
                K' = {MaSV} -> K' không là siêu khóa
                => K là Khóa

        !!! Nhận xét
            * Giá trị của khóa dùng để nhận biết một bộ trong quan hệ
            * Khóa là một đặc trưng của lược đồ quan hệ, không phụ thuộc vào thể hiện quan hệ
            * Khóa được xây dựng dựa vào ý nghĩa của một số thuộc tính trong quan hệ
            * Lược đồ quan hệ có thể có nhiều khóa

    - Khóa chính (Primary key)
        + Lược đồ quan hệ có thể có nhiều khóa, chọn 1 khóa (có ít thuộc tính hơn) để làm khóa chính
        + Các thuộc tính khóa chính phải có giá trị khác null
        + Các thuộc tính khóa chính thường được gạch dưới

    - Khóa ngoại (Foreign key)
        + Tập thuộc tính K là khoá ngoại của một quan hệ R nếu K không là khóa chính của quan hệ R nhưng lại là khóa chính của một quan hệ khác.

## 📚 Chuyển đổi mô hình ER -> mô hình quan hệ 
    - Tập thực thể
        + Các tập thực thể (trừ tập thực thể yếu) chuyển thành các quan hệ có cùng tên và tập thuộc tính/cột

    - Mối quan hệ 
        + Nhiều - Nhiều
            * Tạo một quan hệ mới có:
                \ Tên quan hệ là tên của mối quan hệ
                \ Thuộc tính là những thuộc tính khóa của các tập thực thể liên quan

        + Một - Nhiều 
            * Thêm vào quan hệ đầu nhiều thuộc tính khóa của quan hệ đầu một

        + Một - Một 
            * Thêm vào quan hệ này thuộc tính khóa của quan hệ kia hoặc ngược lại (chỉ thêm 1 bên)

        + Với mối liên kết n ngôi, n>2
            * Tạo một quan hệ mới có
                \ Tên quan hệ cùng tên với tên liên kết
                \ Thuộc tính khóa là những thuộc tính khóa của các tập thực thể liên quan
                \ Kèm theo các thuộc tính đơn liên quan (nếu có)

    - Thực thể yếu
        + Chuyển thành một quan hệ
            * Có cùng tên với thực thể yếu
            * Thêm vào thuộc tính khóa của quan hệ liên quan

    - Thuộc tính đa trị 
        + Chuyển thành một quan hệ mới
            * Chứa thuộc tính đa trị và thuộc tính khóa của quan hệ liên quan
            * Khóa chính của quan hệ mới là tổ hợp thuộc tính đa trị và thuộc tính khóa của quan hệ ban đầu

## 📚 Các phép toán cập nhật trên quan hệ
    - Phép thêm (INSERT)
        + Thêm 1 bộ giá trị mới t vào quan hệ R (A1, A2, ... An)
        + Làm cho thể hiện TR của nó tăng thêm 1 phần tử mới
        + Cú pháp:
            INSERT (R; Ai1 = v1, Ai2 = v2, ... Aim = vm)
            Ai1, Ai2, ... Aim là các thuộc tính
            v1, v2, ... vm là các giá trị thuộc MGT(Ai1), MGT(Ai2) ,..., MGT(Aim) tương ứng.
    
    - Phép xóa (DELETE)
        + Loại bỏ 1 bộ t của quan hệ R (A1, A2, ... An)
        + Lấy đi bộ t khỏi thể hiện của quan hệ.
        + Cú pháp:
            DELETE (R; Ai1 = v1 , Ai2 = v2 , ... Aim = vm)
            Aij=vj (j = 1, 2, ..., m) được coi như những điều kiện thỏa một số thuộc tính của bộ t để loại bỏ 1 bộ ra khỏi quan hệ.
                
    - Phép sửa (UPDATE)
        + Thay đổi 1 bộ t trong quan hệ R (A1, A2, ... An)
        + Cú pháp:
            UPDATE (R; Ai1 = c1, Ai2 = c2, ... Aim = cm; Ai1 = v1, Ai2 = v2 , ... Aim = vm)
            R là quan hệ cần sửa đổi
            Aij= cj (j = 1, 2, ..., m) là điều kiện tìm kiếm bộ giá trị để sửa
            Aij= vj (j = 1, 2, ..., m) là giá trị mới của bộ.

## 📚 Đại số quan hệ 
    - Các phép toán trên đại số tập hợp
        + Tính khả hợp (Union Compatibility)
            * Hai lược đồ quan hệ R(A1, A2, ..., An) và S(B1, B2, ..., Bn) là khả hợp nếu:
                \ Cùng bậc n
                \ Và có DOM(Ai) = DOM(Bi) , 1 <= i <= n

        + Phép hội (Union) : khả hợp
            * Là một quan hệ gồm các bộ thuộc R hoặc thuộc S, hoặc cả hai (các bộ trùng lặp sẽ bị loại bỏ)

        + Phép giao (Intersection) : khả hợp
            * Là một quan hệ gồm các bộ thuộc R đồng thời thuộc S

        + Phép trừ (Minus) : khả hợp
            * Là một quan hệ gồm các bộ thuộc R và không thuộc S

        + Phép tích Đề các (Cartesian)
            * Được dùng để kết hợp các bộ của các quan hệ lại với nhau
            * Kết quả trả về là một quan hệ Q
                \ Mỗi bộ của Q là tổ hợp giữa 1 bộ trong R và 1 bộ trong S
                \ Nếu R có u bộ và S có v bộ thì Q sẽ có u  v bộ
                \ Nếu R có n thuộc tính và Q có m thuộc tính thì Q sẽ có n + m thuộc tính

        + Phép chia (Division)
            * Được dùng để lấy ra một số bộ trong quan hệ R sao cho thỏa với tất cả các bộ trong quan hệ S

        + Các tính chất 
            * Giao hoán 
            * Kết hợp

    - Các phép toán trên đại số quan hệ
        + Phép chiếu (Projection)
            * Được dùng để lấy ra một vài cột của quan hệ R
            * Kết quả trả về là một quan hệ
                \ Có k thuộc tính
                \ Có số bộ luôn ít hơn hoặc bằng số bộ của R

            !!! Phép chiếu không có tính giao hoán 

        + Phép chọn (Selection)
            * Được dùng để lấy ra các bộ của quan hệ R
            * Các bộ được chọn phải thỏa mãn điều kiện chọn P
            * Kết quả trả về là một quan hệ
                \ Có cùng danh sách thuộc tính với R
                \ Có số bộ luôn ít hơn hoặc bằng số bộ của R

            !!! Phép chọn có tính giao hoán

        + Phép kết nối hai quan hệ (Join)
            * Được dùng để tổ hợp 2 bộ có liên quan từ 2 quan hệ thành 1 bộ
            * Kết quả của phép kết là một quan hệ Q
                \ Có n + m thuộc tính Q(A1, A2, ..., An, B1, B2, ..., Bm)
                \ Mỗi bộ của Q là tổ hợp của 2 bộ trong R và S, thỏa mãn một số điều kiện kết nào đó

            * Loại kết nối 
                \ Kết nối theta (theta join) là phép kết nối có điều kiện
                \ Kết nối bằng (equi join) khi C là điều kiện so sánh bằng
                \ Kết nối tự nhiên (natural join) kết quả của phép kết nối bằng bỏ bớt đi 1 cột giống nhau

## 📚 Ràng buộc toàn vẹn
    - Khái niệm
        + RBTV (Integrety Constraints) xuất phát từ những qui định hay điều kiện: Trong thực tế, Trong mô hình dữ liệu. Các thao tác làm thay đổi dữ liệu không nên được thực hiện một cách tùy tiện vì 
        có thể đưa CSDL đến một tình trạng ‘xấu’

        + RBTV là một điều kiện được định nghĩa trên một hay nhiều quan hệ khác nhau
        
        + Các RBTV là những điều kiện bất biến mà mọi thể hiện của quan hệ đều phải thỏa ở bất kỳ thời điểm nào

    - Chức năng
        + Bảo đảm tính kết dính của các thành phần cấu tạo nên CSDL
        + Bảo đảm tính nhất quán của dữ liệu
        + Bảo đảm CSDL luôn biểu diễn đúng ngữ nghĩa thực tế

    - Điều kiện
        + Điều kiện của ràng buộc toàn vẹn là sự mô tả, và biểu diễn hình thức nội dung của nó
        
        + Có thể được biểu diễn bằng:
            * Ngôn ngữ tự nhiên
            * Thuật giải (bằng mã giả - Pseudo Code, ngôn ngữ tựa Pascal)
            * Ngôn ngữ đại số tập hợp, đại số quan hệ ...
            * Các phụ thuộc hàm

    - Bối cảnh là những quan hệ có khả năng bị vi phạm RBTV khi thực hiện các phép cập nhật

    - Bảng tầm ảnh hưởng
        + Xác định thao tác cập nhật nào cần phải kiểm tra RBTV khi được thực hiện trên quan hệ bối cảnh
        + Có 2 loại
            * Bảng tầm ảnh hưởng cho một RBTV
            * Bảng tầm ảnh hưởng tổng hợp

    *** Bảng tầm ảnh hưởng một RBTV (các ràng buộc của 1 quan hệ)
        Tên_RB  | Thêm | Xóa | Sửa 
          QH1   |   +  |  -  | + (thuộc tính)
          QH2   |   -  |  +  | - 
          ...   |      |     |  
          QHn   |   -  |  +  | - 

        (+): Vi phạm RBTV
        (-): Không vi phạm RBTV
        +(A): có thể vi phạm RBTV khi sửa trên thuộc tính A
        (-(*)): Không bị vi phạm vì thao tác không thực hiện được
        
    *** Bảng tầm ảnh hưởng tổng hợp (nhiều ràng buộc cho nhiều quan hệ)
            |    QH1    |    QH2    |    ...    |    QHn    |
            | T | X | S | T | X | S | T | X | S | T | X | S |
        RB1 | + | - | + | + | - | + |   |   |   | + | - | + |
        RB2 | - | + | - |   |   |   |   |   |   |   |   |   |
        RB3 | - | - | + |   |   |   |   |   |   | - | + | - |
        ... |   |   |   |   |   |   |   |   |   |   |   |   |
        RBn |   |   |   | - | + | - |   |   |   | - | - | + |

    *** Các loại RBTV
        - Ràng buộc toàn vẹn về miền giá trị của thuộc tính
            + Ràng buộc qui định giới hạn miền giá trị trong kiểu dữ liệu cho một thuộc tính
            + Ví dụ:
                KQUẢ-THI(MASV, MAMH, LANTHI, DIEM),
                Có 2 RBTV miền giá trị:
                    Mỗi sinh viên chỉ được thi 1 môn tối đa 3 lần 
                    0 <=  Điểm thi của môn học <=10

        - Ràng buộc toàn vẹn liên thuộc tính
            + Là ràng buộc giữa các thuộc tính trong cùng quan hệ
            + Thông thường đó là các phụ thuộc tính toán, hoặc một suy diễn từ giá trị của một hay nhiều thuộc tính trong cùng một bộ giá trị
            + Ví dụ:
                NHANVIEN (Mã-NV, Họ-tên, phai, Ngày-sinh, Ngày-TD, Hệ-số-lương) 
                Với quy định 18 tuổi trở lên mới được tuyển. Ta có RBTV liên thuộc tính sau:
                    Năm của Ngày-TD - năm của Ngày-sinh >= 18

        - Ràng buộc toàn vẹn liên bộ, liên thuộc tính
            + Sự tồn tại của một hay nhiều bộ phụ thuộc vào sự tồn tại của một hay nhiều bộ khác trong cùng quan hệ
            + Trường hợp đặc biệt
                * RB khóa chính
                * RB duy nhất (unique)

            + Ví dụ:
                Trong quan hệ PHONGBAN, Tên phòng là duy nhất
        
        - Ràng buộc toàn vẹn về phụ thuộc tồn tại
            + RBTV về phụ thuộc tồn tại còn được gọi là phụ thuộc về khóa ngoại. Đây là loại RBTV phổ biến trong các CSDL.
            
            + Bộ giá trị của quan hệ này được thêm vào một cách hợp lệ nếu tồn tại một bản ghi tương ứng của 1 quan hệ khác (Thường có bối cảnh là hai quan hệ, nhưng có trường hợp suy biến thành 
            một quan hệ)
            
            + Xảy ra nếu có một trong hai trường hợp sau:
                * Có sự hiện diện của khóa ngoại.
                * Có sự lồng khóa giữa các quan hệ.

        - Ràng buộc toàn vẹn tổng hợp (liên bộ - liên quan hệ)
            + Là ràng buộc xảy ra giữa các bộ trên nhiều quan hệ khác nhau
            + Là ràng buộc xảy ra giữa các thuộc tính trên nhiều quan hệ khác nhau

## 📚 Phụ thuộc hàm (Funtional Dependency)
    - Khái niệm
        + Là sự biểu diễn RBTV dưới hình thức toán học
        + Bảo đảm thông tin không bị tổn thất khi phân rã hoặc kết nối giữa các quan hệ.
            Quan hệ R được định nghĩa trên tập thuộc tính
            U = { A1, A2, ..., An}.
            A, B thuộc U là 2 tập con của tập thuộc tính U.
            Nếu tồn tại một ánh xạ f: A -> B thì nói rằng A xác định hàm B, hay B PTH vào A.
            A là vế trái của PTH, B là vế phải của PTH
        
            !!! PTH A -> A được gọi là PTH hiển nhiên.
        
        + Ký hiệu: A->B

    - Bao đóng (Closure)
        + Suy diễn logic các PTH
            Cho lược đồ quan hệ R với tập thuộc tính U và tập các PTH F.
            X -> Y là 1 PTH 
            X,Y là con của U
            Ta nói rằng X -> Y được suy diễn lôgic từ F nếu
            Với mọi r thuộc R, nếu r thỏa tất cả các PTH trong F thì r cũng thỏa X -> Y
            
            * Ký hiệu là: F |= X -> Y.

            * Ví dụ 
                Với F = {X -> Y, X -> Z, Y -> T }
                Thì ta có các PTH: X -> YZ và X -> T

                Hiểu đơn giản là có thể gộp các phụ thuộc hàm lại nếu nó thỏa hệ luật Armstrong
                X -> Y, X -> Z ==> X -> YZ
                X -> Y, Y -> T ==> X -> T
                Đọc thêm hệ luật dẫn Armstrong

        + Bao đóng (Closure)
            * Gọi F+ là bao đóng của F, tức là tập các PTH được suy diễn lôgic từ F.
            * Nếu F = F+ thì ta nói F là họ đầy đủ (full family) của các PTH.

            Hiểu đơn giản F+ (bao đóng) là F đã được rút gọn lại và nếu F không thể rút tức F = F+ thì F là họ đầy đủ

    - Hệ luật dẫn Armstrong (các tính chất của PTH)
        Cho lược đồ quan hệ Q với tập thuộc tính U. 
        X, Y, Z, W là con của U. PTH có các tính chất cơ bản sau:

        + Tính phản xạ:
            Nếu Y là con X thì X -> Y
        
        + Tính tăng trưởng:
            Nếu X -> Y thì XZ -> YZ 
            (Z là con U)
        
        + Tính bắc cầu:
            Nếu X -> Y và Y -> Z thì X -> Z

        + Luật giả bắc cầu:
            Nếu X -> Y và YZ -> W thì XZ -> W
       
        + Luật hợp:
            Nếu X -> Y và X -> Z thì X -> YZ
        
        + Luật tách:
            Nếu X -> YZ thì X -> Y và X -> Z

    - Bao đóng của tập thuộc tính
        + Bao đóng của tập thuộc tính X đối với tập các PTH F (ký hiệu: X+) là tập tất cả các thuộc tính A có thể suy dẫn từ X nhờ tập bao đóng của F (F+)
        
        + Thuật toán tìm bao đóng của tập thuộc tính 
            Input: Tập U hữu hạn các thuộc tính & tập các PTH F trên U & X  U.
            Output: X+

            B1: X0 = X
            B2: Lần lượt xét các PTH của F
                Nếu Y -> Z có Y là con Xi thì Xi+1 = Xi hợp với Z
            B3: Nếu ở bước 2 không tính được Xi+1 (hay Xi+1 = Xi) thì Xi chính là bao đóng của X
                Ngược lại lặp lại B2

            Hiểu đơn giản từ X (tập thuộc tính con của U, đề cho), nếu các thuộc tính của X có phụ thuộc hàm thì gộp đích các PTH đó vào X và xét lại cho đến khi không thể thêm nữa (Xi+1 = Xi)
            Nếu X = U thì X+ là bao đóng của tập thuộc tính

        + Ví dụ
            Cho R(U) với U = ABCDEG
            F = {AB -> C, C -> A, BC -> D, ACD -> B, D -> EG, BE -> C, CG -> BD, CE -> AG }
            Tính BD+

            B1: X0 = BD
            B2: X1 = X0 hợp EG = BDEG (vì D -> EG)
            X2 = X1 hợp C = BDEGC (vì BE -> C)
            X3 = X2 hợp A = BDEGCA (vì CE -> AG)
            X4 = X3
            Vậy: BD+ = U

    - Phủ tối thiểu
        + PTH tương đương
            * Gọi F và G là các tập PTH. Ta nói rằng F và G là tương đương nếu F+ = G+.
            * Nếu F và G tương đương, đôi khi còn nói F phủ G(hay G phủ F).

        + PTH có vế trái dư thừa, vế phải dư thừa
            * Hiểu đơn giản 
            AB -> C, A -> C thì A -> C là PTH đầy đủ còn AB -> C là PTH không đầy đủ (dư trái)
            nếu vế phải có hơn 2 thuộc tính gọi là dư phải => dùng luật tách để xử lý

        + Phủ tối thiểu
            * F là PTH tối thiểu (phủ tối thiểu) nếu 
                \ F là tập PTH có vế phải một thuộc tính (không dư phải)
                \ F là tập PTH có vế trái không dư thừa (không dư trái)
                \ F là tập PTH không dư thừa PTH (đưa về F+)

            * Tìm phủ tối thiểu: làm tuần tự các điều kiện

## 📚 Khóa
    - Khái niệm
        + R là lược đồ quan hệ định nghĩa trên tập các thuộc tính U = { A1, A2, ... , An}
        + Tập các Phụ thuộc hàm F = { f1, f2, ..., fm } xác định trên R.
        + K con của U là khóa của R nếu thỏa mãn hai điều kiện sau đây:
            * K -> U ( K là siêu khóa )
            * Không tồn tại K’ con của K mà K’ -> U.
    
    - Thuật toán tìm 1 khóa
        Input: R(U,F), U = A1 A2 ... An
        Output: Tập thuộc tính khóa K

        Bước 1: K = U
        Bước 2: While (Ai thuộc K)
            If ((K - Ai)+ = U) K = K – Ai
            K còn lại chính là một khóa cần tìm.

        !!! Nếu muốn tìm các khóa khác nhau (nếu có) của lược đồ quan hệ, ta có thể thay đổi thứ tự loại bỏ các phần tử của K.

    - Thuật toán tìm tất cả các khóa
        + Tập thuộc tính nguồn (TN) chứa tất cả các thuộc tính chỉ xuất hiện ở vế trái của các PTH hoặc các thuộc tính không xuất hiện ở bất kỳ PTH nào.

        + Tập thuộc tính trung gian (TG) chứa các thuộc tính xuất hiện ở cả vế phải và vế trái của PTH

        + Tập thuộc tính đích (TD) chứa các thuộc tính chỉ xuất hiện ở vế phải của PTH

        !!! Lưu ý
            - Tập nguồn luôn có mặt trong mọi khóa
            - Tập đích không xuất hiện trong mọi khóa
            - Tập trung gian có thể có hoặc không có mặt trong khóa

        + Thuật toán
            B1: Tạo tập thuộc tính nguồn (TN) và tập thuộc tính trung gian (TG)
           
            B2: Nếu TG = rỗng thì lược đồ quan hệ chỉ có 1 khóa là K = TN
                Ngược lại sang B3
    
            B3: Tìm tất cả các tập con của tập trung gian (TG)
            
            B4: Tìm các siêu khóa Si bằng cách:
                Nếu (TN hợp Xi)+ = U thì Si = (TN hợp Xi) là 1 siêu khóa
           
            B5: Tìm khóa bằng cách loại bỏ các siêu khóa không tối thiểu với mọi Si, Sj thuộc S (trong đó S là tập các siêu khóa)
                Nếu Si là con của Sj thì loại Sj ra khỏi tập siêu khóa
                Các S còn lại là tập tất cả các khóa cần tìm

        + Ví dụ
            Cho lược đồ Q(A,B,C) và tập PTH
            F = { A -> B; A -> C; B -> A }
            Tìm tất cả các khóa của Q?

            TN = {rỗng}; TG = {A,B}
            Gọi Xi là các tập con của tập TG:

            Xi | (TN hợp Xi) | (TN hợp Xi)+ | Siêu khóa | Khóa
             f |     rỗng    |     rỗng     |           |
             A |      A      |      Q+      |     A     |  A 
             B |      B      |      Q+      |     B     |  B
            AB |      AB     |      Q+      |     AB    | 

            Vậy quan hệ trên có hai khoá là : [A] và [B]

## 📚 Dạng chuẩn
    - Thuộc tính khóa
        + Thuộc tính tham gia vào bất kỳ khoá nào đó của quan hệ chứa nó.
        + Ngược lại gọi là thuộc tính không khoá.

    - Thuộc tính đơn: Miền giá trị của nó không phải là tích hợp của các miền giá trị khác

    - Thuộc tính phụ thuộc đầy đủ - phụ thuộc hàm đầy đủ: 

    - Dạng chuẩn 1 (1NF)
        + Một lược đồ quan hệ Q được gọi là đạt dạng chuẩn 1 nếu mọi thuộc tính củaQ đều là thuộc tính đơn
        + Một lược đồ CSDL được gọi là đạt dạng chuẩn 1 nếu mọi lược đồ quan hệ con Qi của nó đều đạt dạng chuẩn 1
    
    - Dạng chuẩn 2 (2NF)
        + Một lược đồ quan hệ Q ở dạng chuẩn 2 nếu:
            * Q ở dạng chuẩn 1NF
            * Mọi thuộc tính không khóa của Q đều PTH đầy đủ vào khóa
    
    - Dạng chuẩn 3 (3NF)
        + Định nghĩa 1: Một lược đồ quan hệ Q ở dạng chuẩn 3 nếu:
            * Q ở dạng chuẩn 2
            * Mọi thuộc tính không khóa của Q đều không PTH bắc cầu vào khóa bất kỳ của Q (hay mọi thuộc tính không khóa PTH trực tiếp vào khóa)

        + Định nghĩa 2: Một lược đồ quan hệ Q ở dạng chuẩn 3 nếu mọi phụ thuộc hàm X -> A thuộc F+ với A không thuộc X đều có:
            * Hoặc A là thuộc tính khóa
            * Hoặc X là siêu khóa
    
    - Dạng chuẩn Boyce–codd (BCNF)
// bổ sung dạng chuẩn

## 📚 Ngôn ngữ dữ liệu SQL (truy vấn dữ liệu)
    - Bảng ~ quan hệ
    
    - Cột ~ thuộc tính
    
    - Dòng ~ bộ

    !!! SQL không phân biệt chữ hoa hay chữ thường

    - Kiểu dữ liệu
        + Số (numeric): INTEGER, SMALLINT, NUMERIC, NUMERIC(p), NUMERIC(p,s), DECIMAL, DECIMAL(p), DECIMAL(p,s), REAL, DOUBLE PRECISION, FLOAT, FLOAT(p)
        + Chuỗi ký tự (character string): CHARACTER, CHARACTER(n), CHARACTER VARYING(x)
        + Chuỗi bit (bit string): BIT, BIT(x), BIT VARYING(x)
        + Ngày giờ (datetime)
            * DATE gồm ngày, tháng và năm
            * TIME gồm giờ, phút và giây
            * TIMESTAMP gồm ngày và giờ

    - Toán tử 
        + Các toán tử số học:
            ^ (luỹ thừa),*(nhân),/ (chia), mod (phần dư), +(cộng), - (trừ)
       
        + Các toán tử luận lý:
            not (phủ định), and (phép hội), or (phép tuyển)

        + Các toán tử tập hợp:
            * In (danh sách các giá trị),
            * LIKE, NOT LIKE,
            * union (phép hợp), intersect (phép giao), minus (phép trừ)

        + Các toán tử so sánh :
            =, <>, >, <, >=, <=

    - SELECT
        + SELECT distinct /*/ danh sách thuộc tính / <biểu thức>,... : Tên các cột cần được hiển thị trong kết quả truy vấn
       
        + Phát biểu Select với AS: Đặt lại tên Field khi hiển thị kết quả
            <Tên cột của bảng> AS <tên mới>
            !!! Nếu tên có chứa các ký tự đặc biệt và/hoặc khoảng trắng thì viết tên đó trong cặp dấu ngoặc vuông

        + Phát biểu Select với TOP N: Cho phép lấy ra chỉ một số mẫu tin nào đó theo 1 tiêu chuẩn nhất định.
            SELECT TOP 10 *

        + Có thể dùng các phép toán số học +,-,*,/, ^,%, các hàm tính toán đối với các cột kiểu số trong mệnh đề SELECT
            SELECT MaH, Slton*10

    - FROM 
        + FROM <danh sách các quan hệ>
        !!! khi mệnh đề From chỉ ra từ hai quan hệ trở lên, nếu có một thuộc tính ở mệnh đề select là thuộc tính của nhiều hơn một quan hệ thì cần phải chỉ rõ thuộc tính đó thuộc về quan hệ nào 
        theo cú pháp
            tênquanhệ.tênthuộctính

    - WHERE
        + WHERE <biểu thức điều kiện>
        + Biểu thức boolean xác định dòng nào sẽ được rút trích
        + Nối các biểu thức: AND, OR, và NOT
        + Phép toán: <, >, <=, >=, !=, =, LIKE và BETWEEN,...
       
        !!! Nếu điều kiện này chỉ liên quan đến một quan hệ thì gọi là điều kiện chọn, nếu điều kiện liên quan đến từ hai quan hệ trở lên thì gọi là điều kiện kết.

        + Toán tử BETWEEN: nắm trong 1 miền
            WHERE Slton Between 50 and 100

        + Toán tử LIKE: phép toán so sánh gần giống, sử dụng dấu các ký tự đại diện như _ (1 ký tự), % (1 chuỗi bất kỳ)
            WHERE diachi like ‘H%’

        + Toán tử IN: phép toán so sánh trong 1 tập hợp, 1 danh sách
            WHERE Diachi IN (‘Cần Thơ’, ‘An Giang’, ‘Kiên Giang’)

    - ORDER BY
        + ORDER BY <danh sách các cột> [ASC/DESC]
        + Dùng để hiển thị kết quả câu truy vấn theo một thứ tự nào đó
        + ASC: tăng (mặc định); DESC: giảm
            ORDER BY MA_NVIEN DESC, SODA

    - GROUP BY
        + GROUP BY <tên cột 1>,<tên cột 2>,...
    
        + Dùng để nhóm các bản ghi có giá trị giống nhau trên các cột được liệt kê sau từ khóa GROUP BY.
            Group By Sohd

        + Một số hàm thông dụng tính toán trên nhóm bản ghi
            * COUNT (*| <tên cột>): đếm số bản ghi có giá trị xác định tại cột được cho bởi <tên cột>
            * SUM (<biểu thức>): tìm tổng giá trị các biểu thức
            * MIN (<biểu thức>): tìm giá trị nhỏ nhất
            * MAX (<biểu thức>): tìm giá trị lớn nhất
            * AVG (<biểu thức>): tính giá trị trung bình của biểu thức dựa trên các bản ghi của các nhóm.

    - HAVING 
        + HAVING theo sau GROUP BY dùng để kiểm tra điều kiện nhóm. Nhóm nào thoả mãn điều kiện sau HAVING thì mới được hiển thị
            Having count(MaKH) > 15

        + Chỉ kiểm tra điều kiện trên nhóm, không là điều kiện lọc trên từng bộ
        
        + Dữ liệu được nhóm trước rồi mới kiểm tra điều kiện sau HAVING.
            
    !!! Thứ tự thực hiện câu truy vấn
        FROM -> WHERE -> GROUP BY -> HAVING -> SELECT -> ORDER BY

    - Truy vấn nhiều bảng
        + Khi thông tin cần lấy ra có từ nhiều bảng khác nhau, cần thực hiện truy vấn từ nhiều bảng

        !!! Lưu ý:
            + Cần kết nối các bảng lại với nhau. Với n bảng cần có n-1 điều kiện liên kết.
            + Các tên cột cùng có ở nhiều bảng cần ghi rõ theo dạng: [Tên Bảng].[Tên cột]

        + Các bảng được liên kết với nhau qua phép kết nối của từ khóa FROM hoặc thông qua điều kiện của từ khóa WHERE của câu lệnh SELECT
            * WHERE
                \ WHERE Tenquanhe1.TTKN = Tenquanhe2.TTKN
                    Where (KHACH.MaKH = HOADON.MaKH) and (year(NgayHD) = 2019)
            
            * FROM
                \ Liên kết bảng với nhau qua phép kết nối của từ khóa FROM sử dụng phép kết nối nội Inner join:
                \ Quanhe1 Inner join Quanhe2 On Quanhe1.TT1 = Quanhe2.TT2
                    From KHACH Inner Join HOADON On KHACH.MaKH = HOADON.MaKH

    - Truy vấn lồng
        + Là những câu lệnh mà trong mệnh đề WHERE hoặc HAVING (thường là trong mệnh đề WHERE) có chứa thêm một câu lệnh Select khác nữa. 
        
        + Câu lệnh này thường gặp khi cần sử dụng kết quả của 1 câu truy vấn để làm điều kiện cho 1 câu truy vấn khác
            
            SELECT <danh sách các cột>
            FROM <danh sách các bảng>
            WHERE <so sánh tập hợp> (
                SELECT <danh sách các cột>
                FROM <danh sách các bảng>
                WHERE <điều kiện>)

        + Khi thực hiện, truy vấn con sẽ được thực hiện trước, rồi lấy kết quả để thực hiện truy vấn cha

        + Câu truy vấn con thường trả về một tập các giá trị. Các câu lệnh SELECT có thể lồng nhau ở nhiều mức
        
        + Các câu truy vấn con trong cùng một mệnh đề WHERE được kết hợp bằng phép nối logic

        + Mệnh đề WHERE của câu truy vấn cha
            * <biểu thức> <so sánh tập hợp> <truy vấn con>

            * So sánh tập hợp thường đi cùng với một số toán tử
                \ IN, NOT IN
                \ ALL
                \ ANY hoặc SOME

            * Kiểm tra sự tồn tại
                \ EXISTS
                \ NOT EXISTS

    - Lệnh cập nhật
        + INSERT (bổ sung bộ mới)
            * Dùng để thêm 1 hay nhiều dòng vào bảng
                INSERT INTO <tên bảng>(<danh sách các thuộc tính>)
                VALUES (<danh sách các giá trị>)

            !!! Nhận xét 
                + Thứ tự các giá trị phải trùng với thứ tự các cột
                + Có thể thêm giá trị NULL ở những thuộc tính không là khóa chính và NOT NULL
        
            * Dùng để thêm 1 danh sách vào bảng
                INSERT INTO <tên bảng> [(<danh sách các thuộc tính>)]
                    <câu truy vấn con>

        + DELETE (xóa bộ)
            * Dùng để xóa các dòng
                DELETE FROM <tên bảng>
                [WHERE <điều kiện>]

            !!! Nhận xét 
                + Số lượng số dòng bị xóa phụ thuộc vào điều kiện ở mệnh đề WHERE
                + Nếu không chỉ định điều kiện ở mệnh đề WHERE, tất cả các dòng trong bảng sẽ bị xóa

        + UPDATE
            * Dùng để thay đổi giá trị của thuộc tính cho các dòng của bảng 
                UPDATE <tên bảng>
                SET <tên thuộc tính>=<giá trị mới>,
                    <tên thuộc tính>=<giá trị mới>,
                    ...
                [WHERE <điều kiện>]

            !!! Nhận xét
                + Những dòng thỏa điều kiện tại mệnh đề WHERE sẽ được cập nhật giá trị mới
                + Nếu không chỉ định điều kiện ở mệnh đề WHERE, tất cả các dòng trong bảng sẽ bị cập nhật

    - Lệnh cấu trúc
        + CREATE TABLE (tạo bảng)
            * Cần có: Tên bảng, Tên thuộc tính, Kiểu dữ liệu, Các RBTV trên thuộc tính

                CREATE TABLE <Tên_bảng> (
                    <Tên_cột 1> <Kiểu_dữ_liệu> [<RBTV>],
                    <Tên_cột 2> <Kiểu_dữ_liệu> [<RBTV>],
                    ...
                    [<RBTV>]
                )
            
            * Ràng buộc toàn vẹn: NOT NULL, NULL, UNIQUE, DEFAULT, PRIMARY KEY, FOREIGN KEY / REFERENCES, CHECK
                CONSTRAINT <Ten_RBTV> <RBTV> 
                (đọc thêm trong mục ràng buộc toàn vẹn)
            
        + DROP TABLE (xóa bảng)
            * Được dùng để xóa cấu trúc bảng, tất cả dữ liệu của bảng cũng bị xóa.
                DROP TABLE <Tên_bảng>

        + ALTER TABLE (sửa bảng)
            * ADD (thêm cột) : cột chưa có trong bảng
                ALTER TABLE <Tên_bảng> ADD <Tên_cột> <Kiểu_dữ_liệu> [<RBTV>]

            * DROP (xóa cột)
                ALTER TABLE <Tên_bảng> DROP COLUMN <Tên_cột>

            * COLUMN (mở rộng cột) : cột đã có sẵn trong bảng
                ALTER TABLE <Tên_bảng> ALTER COLUMN <Tên_cột> <Kiểu_dữ_liệu_mới>
        
        + CREATE DOMAIN (tạo miền giá trị)

        + CREATE DATABASE 













