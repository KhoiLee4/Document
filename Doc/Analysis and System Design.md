# ANALYSIS AND SYSTEM DESIGN

## 🤔System Analysis là gì?

**System Analysis (Phân tích hệ thống)** là giai đoạn đầu tiên trong quá trình phát triển hệ thống phần mềm hoặc hệ thống thông tin, tập trung vào việc hiểu rõ và làm rõ các yêu cầu của người dùng, cũng như xác định các vấn đề hiện có trong hệ thống hoặc các yêu cầu cho một hệ thống mới.

Mục tiêu của phân tích hệ thống là thu thập thông tin để xây dựng một cơ sở dữ liệu đầy đủ, từ đó có thể tạo ra một bản thiết kế chi tiết cho hệ thống.

### 📙Các bước chính trong phân tích hệ thống

#### 📘Thu thập yêu cầu (Requirements Gathering)

Mục tiêu: Hiểu rõ các yêu cầu của khách hàng, người dùng và các bên liên quan. Đây là bước cực kỳ quan trọng vì một khi yêu cầu được xác định rõ, các bước tiếp theo mới có thể tiến hành đúng đắn.

Phương pháp:
- Phỏng vấn: Tiếp xúc trực tiếp với người dùng, khách hàng hoặc các bên liên quan để lắng nghe những yêu cầu của họ.

- Khảo sát và bảng câu hỏi: Dùng để thu thập ý kiến từ nhiều người dùng về nhu cầu của họ đối với hệ thống.
  
- Quan sát: Quan sát người dùng làm việc với hệ thống hiện tại để hiểu rõ luồng công việc và các điểm yếu.

- Phân tích tài liệu: Nghiên cứu các tài liệu hiện có như biểu đồ, báo cáo, tài liệu kỹ thuật từ hệ thống hiện tại (nếu có).

#### 📘Phân tích hiện trạng (As-Is Analysis)

Mục tiêu: Xem xét hệ thống hiện tại (nếu có) để hiểu cách nó hoạt động, các điểm mạnh và yếu, cũng như những hạn chế. Điều này giúp xác định những cải tiến cần thiết và cung cấp bối cảnh cho hệ thống mới.

Phân tích các quy trình công việc (workflow): Phân tích quy trình hiện tại trong tổ chức hoặc trong hệ thống hiện tại để xem xét các điểm cần cải thiện hoặc hợp lý hóa.

Phân tích vấn đề: Tìm ra nguyên nhân gốc rễ của các vấn đề hiện tại, chẳng hạn như quy trình chậm, sai sót hoặc rủi ro bảo mật.

#### 📘Xác định các yêu cầu chức năng và phi chức năng (Functional and Non-functional Requirements)

**Yêu cầu chức năng**: Là những gì mà hệ thống phải thực hiện (các tính năng hoặc chức năng). Ví dụ: hệ thống phải cho phép người dùng đăng nhập, tìm kiếm sản phẩm, thực hiện giao dịch mua.

**Yêu cầu phi chức năng**: Là các yêu cầu liên quan đến hiệu suất, bảo mật, khả năng mở rộng, tính dễ sử dụng, độ tin cậy, v.v. Ví dụ: hệ thống phải có thời gian phản hồi dưới 2 giây khi thực hiện tìm kiếm.

#### 📘Mô hình hóa hệ thống (System Modeling)

Mục tiêu: Tạo các mô hình biểu diễn cách hệ thống hoạt động dựa trên các yêu cầu đã thu thập. Mô hình hóa giúp dễ dàng hình dung và giao tiếp về hệ thống.

Các công cụ và sơ đồ mô hình:
- **Sơ đồ Use Case (Use Case Diagrams)**: Mô tả các tương tác giữa người dùng và hệ thống thông qua các kịch bản sử dụng cụ thể (use cases).

- **Sơ đồ luồng dữ liệu (Data Flow Diagrams - DFD)**: Mô tả cách dữ liệu di chuyển trong hệ thống.

- **Sơ đồ quan hệ thực thể (Entity-Relationship Diagram - ERD)**: Mô tả cấu trúc của dữ liệu, các thực thể và mối quan hệ giữa chúng.

- **Sơ đồ hoạt động (Activity Diagrams)**: Mô tả quy trình xử lý công việc, cho thấy dòng công việc hoặc cách các chức năng được thực hiện.

#### 📘Phân tích khả thi (Feasibility Study)

Mục tiêu: Đánh giá tính khả thi của dự án từ nhiều khía cạnh khác nhau. Điều này giúp xác định xem hệ thống có thể được xây dựng với các yêu cầu và ràng buộc hiện tại hay không.

Các loại khả thi:
- Khả thi kỹ thuật: Đánh giá xem các công nghệ hiện có có đủ để phát triển hệ thống hay không.

- Khả thi tài chính: Đánh giá chi phí phát triển hệ thống có nằm trong ngân sách không và có mang lại lợi ích kinh tế hay không.

- Khả thi vận hành: Đánh giá xem hệ thống có phù hợp với quy trình làm việc và người dùng hay không.

#### 📘Lập tài liệu yêu cầu (Requirements Documentation)

Mục tiêu: Ghi chép toàn bộ các yêu cầu đã thu thập và phân tích trong một tài liệu chính thức (có thể là tài liệu đặc tả yêu cầu – SRS).

**Tài liệu yêu cầu hệ thống (System Requirements Specification - SRS)**: Đây là một tài liệu chi tiết về mọi yêu cầu chức năng và phi chức năng, bao gồm tất cả các ràng buộc kỹ thuật, khả thi và phương pháp để đạt được mục tiêu.

> bổ sung SRS

#### 📘Xác nhận yêu cầu (Requirements Validation)

Mục tiêu: Đảm bảo rằng tất cả các yêu cầu đã được ghi nhận chính xác và phù hợp với nhu cầu của các bên liên quan. Đây là quá trình lặp lại, đòi hỏi sự đồng thuận từ khách hàng và người dùng trước khi bước sang giai đoạn thiết kế.

Hoạt động kiểm tra và xác nhận: Thảo luận lại với người dùng, kiểm tra với các chuyên gia hoặc thậm chí xây dựng các mẫu thử (prototype) để đảm bảo rằng yêu cầu là đúng và khả thi.

### 📙Các phương pháp và kỹ thuật hỗ trợ

**Phân tích hướng đối tượng (Object-Oriented Analysis - OOA)**: Sử dụng các khái niệm hướng đối tượng như đối tượng, lớp, thuộc tính, phương thức để mô hình hóa hệ thống.

**Phân tích chức năng (Functional Decomposition)**: Phân chia hệ thống thành các thành phần hoặc chức năng nhỏ hơn để hiểu rõ từng phần và quản lý tốt hơn.

**Use Case Analysis**: Xác định và mô tả các tình huống sử dụng hệ thống từ góc nhìn của người dùng cuối (actor), giúp hiểu rõ cách hệ thống được sử dụng.

### 📙Tổng kết (ý kiến KhoiLee)

Khi phân tích hệ thống cần trả lời các cấu hỏi:
- Hệ thống cần đáp ứng được những yêu cầu gì?
- Điểm mạnh, yếu và hạn chế của hệ thống?
- Hệ thống cần có chức năng gì?
- Độ bảo mật và hiệu năng của hệ thống?
- Mô hình của hệ thống?
- Hệ thống sử dụng những công cụ, công nghệ gì?
- Hệ thống được sử dụng và vận hành ra sao?

## 🤔System Design là gì?

**System Design (Thiết kế hệ thống)** là giai đoạn tiếp theo sau khi hoàn tất việc phân tích hệ thống. Trong giai đoạn này, chuyển đổi các yêu cầu của hệ thống đã được phân tích thành một kiến trúc chi tiết, chỉ rõ cách hệ thống sẽ được xây dựng, tổ chức và hoạt động.

Thiết kế hệ thống không chỉ giúp đảm bảo rằng hệ thống sẽ đáp ứng được các yêu cầu chức năng và phi chức năng, mà còn tạo cơ sở cho đội ngũ phát triển triển khai hệ thống một cách hiệu quả.

### 📙Các bước chính trong thiết kế hệ thống

#### 📘Thiết kế kiến trúc hệ thống (System Architecture Design)

Mục tiêu: Xác định cách toàn bộ hệ thống sẽ được tổ chức về mặt cấu trúc và cách các thành phần chính sẽ tương tác với nhau.

Các quyết định kiến trúc chính:
- **Kiến trúc phân lớp (Layered Architecture)**: Hệ thống được chia thành nhiều lớp khác nhau, mỗi lớp có trách nhiệm riêng biệt (ví dụ: giao diện người dùng, logic nghiệp vụ, cơ sở dữ liệu).

- **Client-Server**: Xác định hệ thống sẽ hoạt động theo mô hình máy khách-máy chủ, trong đó các thành phần máy khách (client) tương tác với máy chủ (server).

- **Microservices**: Hệ thống có thể được chia thành các dịch vụ nhỏ, độc lập, mỗi dịch vụ đảm nhiệm một chức năng cụ thể và giao tiếp với nhau qua API.

- **Monolithic**: Một hệ thống nguyên khối, trong đó mọi thành phần được tích hợp chặt chẽ với nhau.

> bổ sung các kiến trúc

#### 📘Thiết kế chi tiết các thành phần (Detailed Component Design)

Mục tiêu: Phân chia hệ thống thành các module hoặc thành phần nhỏ hơn, mỗi thành phần có trách nhiệm riêng biệt và dễ quản lý.

Thiết kế module: Mỗi module sẽ đảm nhiệm một nhiệm vụ cụ thể, ví dụ: module đăng nhập, module quản lý người dùng, module xử lý thanh toán, v.v.

Thiết kế interface giữa các module: Định nghĩa cách các module tương tác với nhau, thông qua các giao diện rõ ràng (API, giao thức truyền thông, v.v.).

#### 📘Thiết kế giao diện người dùng (User Interface Design)

Mục tiêu: Xác định cách người dùng sẽ tương tác với hệ thống thông qua các màn hình, nút bấm, biểu mẫu, và các yếu tố giao diện khác.

Quy trình: Bao gồm tạo các mẫu thử (wireframes) hoặc mô hình mẫu (prototypes) của giao diện người dùng, dựa trên các yêu cầu từ phân tích hệ thống.

Nguyên tắc thiết kế UI/UX: Thiết kế phải dễ sử dụng, thân thiện với người dùng, đảm bảo tính trực quan và đáp ứng yêu cầu về tính năng.

#### 📘Thiết kế cơ sở dữ liệu (Database Design)

Mục tiêu: Xác định cách dữ liệu sẽ được lưu trữ, truy cập và quản lý trong hệ thống.

Các bước chính:
- **Thiết kế mô hình dữ liệu (Data Modeling)**: Sử dụng các **sơ đồ quan hệ thực thể** (ERD - Entity Relationship Diagram) để mô tả cấu trúc của cơ sở dữ liệu, xác định các bảng, thực thể, thuộc tính và mối quan hệ giữa chúng.

- **Bình thường hóa dữ liệu (Normalization)**: Đảm bảo rằng dữ liệu được tổ chức một cách hiệu quả và tránh sự trùng lặp không cần thiết.

- **Thiết kế lược đồ cơ sở dữ liệu**: Xác định cách dữ liệu sẽ được lưu trữ trong các bảng, chỉ mục, khóa chính và khóa ngoại, cùng với việc lựa chọn công cụ cơ sở dữ liệu (SQL Server, MongoDB, v.v.).

#### 📘Thiết kế bảo mật (Security Design)

Mục tiêu: Đảm bảo rằng hệ thống có thể bảo vệ dữ liệu và ngăn chặn các cuộc tấn công.

Các phương pháp bảo mật:
- Quản lý quyền truy cập: Sử dụng các cơ chế như kiểm soát truy cập dựa trên vai trò (**Role-Based Access Control - RBAC**) để giới hạn quyền truy cập vào các chức năng hệ thống khác nhau.

- Mã hóa dữ liệu: Sử dụng mã hóa để bảo vệ dữ liệu khi lưu trữ và truyền tải.

- Xác thực và ủy quyền: Sử dụng cơ chế xác thực mạnh (như **OAuth**, **JWT**) để đảm bảo chỉ những người dùng hợp lệ mới có quyền truy cập vào hệ thống.

> bổ sung OAuth, JWT

#### 📘Thiết kế các quy trình và thuật toán (Process and Algorithm Design)

Mục tiêu: Xác định các quy trình nội bộ và thuật toán cần thiết để thực hiện các chức năng của hệ thống.

Ví dụ: Nếu hệ thống có chức năng tìm kiếm, thuật toán tìm kiếm cần được thiết kế. Nếu có các luồng xử lý phức tạp (như quy trình đặt hàng, xử lý thanh toán), các bước chi tiết phải được xác định rõ ràng.

Mô hình hóa quy trình: **Sử dụng sơ đồ luồng công việc (workflow diagram)** hoặc **sơ đồ hoạt động (activity diagram)** để mô tả các bước và quy trình thực hiện.

#### 📘Thiết kế tích hợp và giao tiếp (Integration and Communication Design)

Mục tiêu: Xác định cách các thành phần khác nhau trong hệ thống sẽ giao tiếp và tương tác với nhau, hoặc với các hệ thống bên ngoài.

Các quyết định chính:
- API: Định nghĩa các API hoặc giao diện dịch vụ web (RESTful, SOAP) để các thành phần hoặc hệ thống khác có thể giao tiếp.

- Message Queue hoặc Event Bus: Sử dụng các cơ chế như message queue (RabbitMQ, Kafka) để quản lý việc giao tiếp không đồng bộ giữa các thành phần.

> bổ sung chi tiết

### 📙Các mô hình trong thiết kế hệ thống

**UML (Unified Modeling Language)**: UML là công cụ phổ biến được sử dụng để mô hình hóa hệ thống trong giai đoạn thiết kế. UML bao gồm nhiều loại sơ đồ giúp mô tả chi tiết các khía cạnh khác nhau của hệ thống:

- Sơ đồ lớp (Class Diagram): Mô tả các lớp đối tượng, thuộc tính và mối quan hệ giữa chúng.

- Sơ đồ trình tự (Sequence Diagram): Mô tả trình tự các tương tác giữa các đối tượng trong hệ thống theo thời gian.

- Sơ đồ trạng thái (State Diagram): Mô tả các trạng thái khác nhau của một đối tượng và các sự kiện gây ra sự thay đổi trạng thái.

- Sơ đồ hoạt động (Activity Diagram): Mô tả luồng công việc hoặc các bước trong một quy trình.

### 📙Tổng kết (ý kiến KhoiLee)

Khi thiết kế hệ thống cần xác định được:
- Hệ thống tổ trúc theo kiến trúc gì?
- Hệ thống có những module, interface nào?
- Người dùng thao tác như thế nào (trải nghiệm người dùng)?
- Tổ chức dữ liệu trong hệ thống (cơ sở dữ liệu)
- Hệ thống được phân quyền và mã hóa dữ liệu ra sao?




## 📚Quy trình phát triển hệ thống SDLC (Software Development Life Cycle)

**Software Development Life Cycle (SDLC)**, hay Quy trình phát triển phần mềm, là một quy trình có cấu trúc để phát triển phần mềm, bao gồm nhiều giai đoạn từ việc lập kế hoạch đến triển khai và bảo trì. SDLC giúp đảm bảo rằng phần mềm được phát triển đúng yêu cầu, đạt chất lượng và dễ bảo trì. Quy trình này còn giúp giảm thiểu rủi ro, tiết kiệm chi phí, và cải thiện hiệu suất làm việc của đội ngũ phát triển.

### 📙Các giai đoạn chính của SDLC

#### 📘Lập kế hoạch (Planning)

Mục tiêu: Xác định phạm vi và mục tiêu của dự án, cũng như lên kế hoạch tổng thể về nguồn lực, thời gian và chi phí.

Các hoạt động chính:
- Xác định các yêu cầu sơ bộ của dự án.

- Đánh giá tính khả thi (feasibility study), bao gồm khả thi kỹ thuật, tài chính, vận hành và thời gian.

- Xây dựng lịch trình dự án và dự toán ngân sách.

- Thiết lập đội ngũ phát triển, quản lý rủi ro và chuẩn bị tài liệu dự án.

#### 📘Phân tích yêu cầu (Requirement Analysis)

Mục tiêu: Hiểu rõ và thu thập tất cả các yêu cầu từ phía khách hàng và các bên liên quan để xác định chức năng mà hệ thống cần phải có.

Các hoạt động chính:
- Thu thập yêu cầu từ người dùng, khách hàng và các bên liên quan thông qua phỏng vấn, khảo sát, và nghiên cứu tài liệu.

- Phân tích các yêu cầu chức năng (Functional Requirements) và phi chức năng (Non-functional Requirements).

- Tạo tài liệu đặc tả yêu cầu phần mềm (SRS - Software Requirements Specification) để ghi chép chi tiết các yêu cầu.

#### 📘Thiết kế hệ thống (System Design):

Mục tiêu: Chuyển các yêu cầu đã phân tích thành bản thiết kế chi tiết, bao gồm thiết kế kiến trúc hệ thống và thiết kế chi tiết cho các thành phần.
Các hoạt động chính:
Thiết kế kiến trúc tổng thể của hệ thống, xác định các thành phần, module, và mối quan hệ giữa chúng.
Thiết kế cơ sở dữ liệu, giao diện người dùng, quy trình làm việc, và các thuật toán cần thiết.
Tạo ra các mô hình UML, sơ đồ ERD, và các bản vẽ chi tiết để thể hiện cách hệ thống sẽ hoạt động.
Đảm bảo tính bảo mật, hiệu suất, và khả năng mở rộng trong thiết kế.

#### 📘Phát triển/triển khai (Development/Implementation):

Mục tiêu: Xây dựng hệ thống dựa trên thiết kế đã được phê duyệt.
Các hoạt động chính:
Lập trình các thành phần của hệ thống, bao gồm các module, giao diện người dùng, cơ sở dữ liệu và tích hợp các dịch vụ.
Sử dụng các công nghệ, ngôn ngữ lập trình, công cụ và frameworks phù hợp.
Đảm bảo rằng các mã nguồn tuân theo các chuẩn mã hóa và yêu cầu kỹ thuật.
Đặt nền móng cho việc kiểm thử (testing), như việc viết các trường hợp kiểm thử tự động (unit tests).

#### 📘Kiểm thử (Testing):

Mục tiêu: Đảm bảo rằng phần mềm hoạt động chính xác, không có lỗi và đáp ứng các yêu cầu đề ra.
Các hoạt động chính:
Thực hiện các loại kiểm thử khác nhau như kiểm thử đơn vị (unit testing), kiểm thử tích hợp (integration testing), kiểm thử chức năng (functional testing), kiểm thử hệ thống (system testing), và kiểm thử chấp nhận người dùng (user acceptance testing - UAT).
Kiểm tra hiệu suất, bảo mật và khả năng chịu tải của hệ thống.
Ghi nhận và sửa các lỗi phát sinh.
Kiểm thử hồi quy (regression testing) để đảm bảo rằng không có lỗi mới phát sinh sau khi sửa lỗi cũ.

#### 📘Triển khai (Deployment):

Mục tiêu: Đưa phần mềm vào môi trường sản xuất và giao cho người dùng cuối.
Các hoạt động chính:
Chuẩn bị môi trường triển khai, có thể là trên máy chủ cục bộ hoặc trên nền tảng đám mây (cloud).
Cài đặt và cấu hình phần mềm, cơ sở dữ liệu, và các thành phần cần thiết.
Di chuyển dữ liệu (nếu có) từ hệ thống cũ sang hệ thống mới.
Đảm bảo rằng phần mềm hoạt động tốt trên môi trường sản xuất.
Đào tạo người dùng và cung cấp tài liệu hướng dẫn sử dụng.

#### 📘Bảo trì (Maintenance):

Mục tiêu: Duy trì, cải tiến và sửa chữa phần mềm sau khi triển khai.
Các hoạt động chính:
Theo dõi hoạt động của phần mềm để phát hiện các lỗi hoặc sự cố.
Cập nhật, vá lỗi và tối ưu hóa hiệu suất của phần mềm khi cần.
Phát triển các tính năng mới dựa trên yêu cầu thay đổi của người dùng hoặc nhu cầu kinh doanh.
Quản lý các bản phát hành, cập nhật và triển khai các thay đổi.

## Phân tích Yêu cầu Hệ thống
### Yêu cầu chức năng và phi chức năng
### Use Case Diagrams
### User Stories
### MoSCoW Prioritization

## BFD (Business Function Diagram)

## DFD (Data Flow Diagram)

## Lucidchart, Microsoft Visio

## Thiết kế Hệ thống Hướng Đối Tượng (OOAD)
### Khái niệm OOP (Object-Oriented Programming): Các nguyên lý hướng đối tượng như Encapsulation, Inheritance, Polymorphism, và Abstraction.
### Phân tích hướng đối tượng
### Class Diagrams, Sequence Diagrams, State Diagrams

## UML (Unified Modeling Language)
### Use Case Diagrams
### Class Diagrams
### Sequence Diagrams
### Enterprise Architect, Visual Paradigm.

## Thiết kế Cơ sở Dữ liệu
### ERD (Entity-Relationship Diagram)
### Chuẩn hóa cơ sở dữ liệu

## Thiết kế Giao diện Người dùng (UI/UX)
### Nguyên lý thiết kế giao diện
### Wireframing và Prototyping
### Figma, Adobe XD.

## Kiểm thử và Đánh giá Hệ thống
### Unit Testing
### Integration Testing
### User Acceptance Testing (UAT)

## Quản lý Dự án và Phát triển Phần mềm
### Agile/Scrum
### Kanban
### JIRA, Trello.





































