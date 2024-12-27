# Internet

## 📚Mạng máy tính

**Mạng máy tính (computer network)** là một hệ thống bao gồm các máy tính và các thiết bị khác (như máy in, bộ định tuyến, thiết bị lưu trữ, v.v.) được kết nối với nhau để chia sẻ dữ liệu và tài nguyên. Các thiết bị trong mạng máy tính có thể giao tiếp với nhau thông qua các phương tiện truyền dẫn (dây dẫn, không dây) và theo các giao thức quy định.

Thành phần chính:
- **Thiết bị đầu cuối (End devices)**: Các máy tính, điện thoại, máy in, hoặc bất kỳ thiết bị nào có thể gửi và nhận thông tin trong mạng.

- **Các thiết bị trung gian (Intermediary devices)**: Bao gồm các bộ định tuyến (routers), bộ chuyển mạch (switches), và các điểm truy cập (access points), giúp kết nối các thiết bị đầu cuối lại với nhau và điều phối quá trình truyền dữ liệu.

- **Phương tiện truyền dẫn (Transmission media)**: Là các loại cáp (cáp xoắn đôi, cáp đồng trục, cáp quang) hoặc sóng vô tuyến (mạng không dây) được sử dụng để truyền dữ liệu giữa các thiết bị.

- **Giao thức mạng (Network protocols)**: Tập hợp các quy tắc và chuẩn mực mà các thiết bị mạng phải tuân theo để có thể giao tiếp và truyền dữ liệu qua lại. Ví dụ: giao thức TCP/IP, HTTP, FTP, v.v.

Phân loại:
- **PAN (Personal Area Network)**: Mạng cá nhân với phạm vi rất nhỏ, ví dụ như kết nối giữa một máy tính và điện thoại qua Bluetooth.

- **LAN (Local Area Network)**: Mạng cục bộ, thường được sử dụng trong một khu vực nhỏ như văn phòng, tòa nhà. Các thiết bị trong mạng LAN thường được kết nối bằng cáp Ethernet hoặc qua Wi-Fi.

- **WAN (Wide Area Network)**: Mạng diện rộng, kết nối các mạng LAN ở các vị trí xa nhau, có thể giữa các thành phố hoặc quốc gia. Internet là ví dụ điển hình của WAN.

- **MAN (Metropolitan Area Network)**: Mạng đô thị, có phạm vi lớn hơn LAN nhưng nhỏ hơn WAN, thường bao phủ một thành phố hoặc khu vực đô thị.

Những giao thức chính: TCP/IP, HTTP/HTTPS, FTP, DNS (sẽ được nói cụ thể từng mục)

## 📚Internet of Things (IoT)

**Internet of Things (IoT)** là một hệ thống các thiết bị vật lý (như cảm biến, thiết bị điện tử, máy móc, xe cộ, v.v.) được kết nối với nhau qua Internet để thu thập và trao đổi dữ liệu mà không cần sự can thiệp của con người. Các thiết bị IoT có khả năng cảm nhận, ghi nhận dữ liệu từ môi trường, gửi dữ liệu về các hệ thống quản lý hoặc đến các thiết bị khác, giúp tạo ra một hệ thống tự động và thông minh.

Thành phần chính:
- **Thiết bị (Devices)**: Các thiết bị vật lý được trang bị các cảm biến và bộ điều khiển để tương tác với môi trường xung quanh. Ví dụ bao gồm máy cảm biến nhiệt độ, thiết bị đo độ ẩm, hệ thống điều khiển nhà thông minh, và xe tự hành.

- **Kết nối (Connectivity)**: Các thiết bị IoT cần kết nối với Internet hoặc các thiết bị khác để truyền tải dữ liệu. Các phương thức kết nối có thể bao gồm Wi-Fi, Bluetooth, Zigbee, LoRaWAN, và mạng di động (như 4G/5G).

- **Nền tảng IoT (IoT Platforms)**: Nền tảng IoT là phần mềm hoặc dịch vụ cho phép quản lý, lưu trữ và phân tích dữ liệu từ các thiết bị IoT. Ví dụ: AWS IoT, Microsoft Azure IoT Hub, Google Cloud IoT.

- **Dữ liệu (Data)**: Dữ liệu được thu thập từ các thiết bị IoT (như nhiệt độ, chuyển động, ánh sáng, v.v.) sẽ được xử lý và phân tích để cung cấp các thông tin hữu ích, giúp đưa ra quyết định thông minh.

- **Ứng dụng (Applications)**: Các ứng dụng IoT xử lý dữ liệu và cung cấp thông tin hữu ích cho người dùng hoặc hệ thống tự động. Ví dụ: ứng dụng nhà thông minh, quản lý giao thông, theo dõi sức khỏe từ xa, và quản lý nông nghiệp thông minh.

Giao thức: MQTT (Message Queuing Telemetry Transport), CoAP (Constrained Application Protocol), Zigbee (sẽ được nói cụ thể từng mục)

## 📚Mạng lõi và biên (core and edge)

### 📙Mạng lõi (Core Network)

**Mạng lõi** là phần trung tâm của một mạng lớn, có nhiệm vụ **vận chuyển dữ liệu giữa các mạng biên** và xử lý các tác vụ quan trọng như **định tuyến** và **quản lý lưu lượng**. Mạng lõi thường bao gồm các thiết bị mạnh mẽ như **router** và **switch** cấp cao, được tối ưu hóa để truyền tải dữ liệu với độ trễ thấp và tốc độ cao giữa các phần khác nhau của mạng.

Chức năng chính:
- **Định tuyến dữ liệu**: Mạng lõi có vai trò chính trong việc định tuyến các gói tin từ một mạng biên này sang một mạng biên khác, đảm bảo rằng dữ liệu đến đúng đích.

- **Tối ưu hóa lưu lượng**: Mạng lõi cần có khả năng xử lý khối lượng lớn dữ liệu và tối ưu hóa đường truyền để đảm bảo rằng các tài nguyên được phân bổ hợp lý.

- **Độ tin cậy cao**: Vì mạng lõi đóng vai trò quan trọng trong việc duy trì hoạt động toàn bộ mạng, nên nó được thiết kế với độ tin cậy cao, với các cơ chế dự phòng và tính sẵn sàng cao (high availability).

Đặc điểm:
- **Tốc độ và băng thông cao**: Mạng lõi cần có băng thông lớn để xử lý các lưu lượng dữ liệu lớn từ nhiều mạng biên.

- **Độ trễ thấp**: Mạng lõi thường phải đảm bảo truyền dữ liệu với độ trễ thấp để đảm bảo hiệu suất và trải nghiệm của người dùng cuối.

- **Tập trung vào việc định tuyến**: Mạng lõi không thực hiện các chức năng liên quan trực tiếp đến người dùng cuối (như xử lý các dịch vụ hoặc ứng dụng); thay vào đó, nó tập trung vào việc chuyển tiếp dữ liệu giữa các phần khác của mạng.

### 📙Mạng biên (Edge Network)

**Mạng biên** là phần mạng gần với người dùng cuối nhất, nơi các thiết bị đầu cuối (như máy tính, điện thoại thông minh, và các thiết bị IoT) kết nối với mạng. Mạng biên cũng có thể được hiểu là phần mạng nằm giữa các thiết bị người dùng và mạng lõi, nơi mà dữ liệu từ người dùng được xử lý và chuẩn bị để gửi vào mạng lõi.

Chức năng chính:
- **Kết nối người dùng cuối**: Mạng biên giúp kết nối các thiết bị người dùng cuối với mạng lõi hoặc Internet. Nó đóng vai trò là điểm truy cập cho các thiết bị trong các hệ thống mạng lớn.

- **Xử lý dữ liệu cục bộ**: Mạng biên ngày càng có xu hướng xử lý dữ liệu ngay tại chỗ trước khi gửi vào mạng lõi để giảm tải cho mạng lõi và cải thiện hiệu suất. Đây là nền tảng của khái niệm **Edge Computing**.

- **Giao tiếp với mạng lõi**: Mạng biên giao tiếp với mạng lõi để gửi các yêu cầu hoặc dữ liệu mà nó không thể xử lý cục bộ.

Đặc điểm:
- **Tập trung vào các dịch vụ người dùng**: Mạng biên thường cung cấp các dịch vụ và ứng dụng mà người dùng cuối truy cập như mạng Wi-Fi, 5G, các điểm truy cập (access points), và các máy chủ biên.

- **Giảm độ trễ**: Để cải thiện trải nghiệm người dùng, mạng biên thường được tối ưu hóa để xử lý một phần dữ liệu gần với người dùng, giúp giảm độ trễ khi tương tác với dịch vụ hoặc ứng dụng.

- **Khả năng tính toán phân tán**: Với sự phát triển của **Edge Computing**, mạng biên có thể thực hiện tính toán ngay tại biên, trước khi truyền dữ liệu vào mạng lõi hoặc đám mây. Điều này giúp giảm tải cho mạng lõi và cải thiện hiệu suất.

### 📙Cách thức hoạt động

Trong một mạng lớn (như mạng Internet hoặc mạng của một nhà cung cấp dịch vụ), người dùng cuối kết nối tới mạng thông qua các thiết bị biên. Dữ liệu từ các thiết bị này được mạng biên xử lý sơ bộ và sau đó chuyển tới mạng lõi để định tuyến và xử lý sâu hơn.

![alt text](../Image/Internet_001.jpg)

### 📙Edge Computing

**Edge Computing** là một kiến trúc tính toán phân tán, trong đó các tác vụ xử lý dữ liệu được thực hiện gần nguồn dữ liệu, tức là gần với các thiết bị đầu cuối (như cảm biến, thiết bị IoT, điện thoại thông minh, máy tính) thay vì truyền tải dữ liệu tới một trung tâm dữ liệu xa. Điều này giúp giảm độ trễ, tiết kiệm băng thông, và cải thiện hiệu suất tổng thể của các ứng dụng và dịch vụ.

Lợi ích:
- **Giảm độ trễ**: Bằng cách xử lý dữ liệu gần nguồn, Edge Computing có thể giảm đáng kể thời gian phản hồi, điều này rất quan trọng cho các ứng dụng cần thời gian thực như xe tự lái, game online, hay các ứng dụng AR/VR.

- **Tiết kiệm băng thông**: Chỉ các dữ liệu quan trọng hoặc đã được xử lý mới được gửi tới đám mây hoặc trung tâm dữ liệu, giúp tiết kiệm băng thông và chi phí liên quan.

- **Tăng cường bảo mật**: Bằng cách xử lý dữ liệu cục bộ, Edge Computing có thể giảm thiểu nguy cơ dữ liệu bị đánh cắp trong quá trình truyền tải, đồng thời cho phép thực hiện các biện pháp bảo mật tại từng thiết bị.

- **Khả năng xử lý cục bộ**: Các thiết bị tại biên có thể xử lý các tác vụ cục bộ mà không cần phụ thuộc hoàn toàn vào kết nối mạng, điều này đặc biệt quan trọng trong các môi trường có kết nối không ổn định.

*❗Tóm lại thì **Edge Computing** sẽ thực hiện việc tính toán và xử lý ngay tại thiết bị đầu cuối (nơi gần dữ liệu) trước khi gửi đi. Chỉ những dữ liệu quan trọng hoặc đã được xử lý sơ bộ mới được gửi đi, điều này cải thiện hiệu suất của các ứng dụng yêu cầu xử lý thời gian thực.*

## 📚Internet Service Provider (ISP)

**ISP (Internet Service Provider)** là một tổ chức hoặc công ty cung cấp dịch vụ kết nối Internet cho cá nhân, doanh nghiệp và các tổ chức khác. ISPs có vai trò quan trọng trong việc giúp người dùng truy cập vào mạng Internet và cung cấp các dịch vụ liên quan đến Internet.

Chức năng của ISP
- **Kết nối Internet**: ISP cung cấp kết nối đến Internet thông qua các công nghệ khác nhau như DSL, cáp quang, cáp đồng trục, không dây (Wi-Fi) hoặc vệ tinh.

- **Cung cấp địa chỉ IP**: Khi khách hàng kết nối với Internet, ISP sẽ cấp cho họ một địa chỉ IP (Internet Protocol) duy nhất, cho phép họ nhận và gửi dữ liệu trên mạng.

- **Dịch vụ lưu trữ**: Một số ISP cũng cung cấp dịch vụ lưu trữ web, cho phép người dùng lưu trữ trang web và nội dung trên máy chủ của họ.

- **Dịch vụ email**: Nhiều ISP cung cấp dịch vụ email miễn phí cho người dùng của họ, bao gồm cả địa chỉ email và không gian lưu trữ.

- **Bảo mật và hỗ trợ kỹ thuật**: ISP thường cung cấp các dịch vụ bảo mật như tường lửa (firewall), phần mềm diệt virus, cũng như hỗ trợ kỹ thuật cho khách hàng khi gặp sự cố kết nối.

Các loại ISP
- **ISP lớn (Tier 1)**: Là các nhà cung cấp dịch vụ Internet lớn nhất, có khả năng kết nối trực tiếp với các mạng khác mà không cần phải mua băng thông từ các ISP khác. Họ xây dựng và duy trì hạ tầng mạng lớn.

- **ISP cấp hai (Tier 2)**: Là các nhà cung cấp dịch vụ có thể mua băng thông từ ISP cấp một và bán lại cho khách hàng. Họ thường cung cấp kết nối đến các khu vực cụ thể và có thể có các liên kết với các ISP khác.

- **ISP cấp ba (Tier 3)**: Là các nhà cung cấp dịch vụ nhỏ hơn, thường cung cấp dịch vụ cho người dùng cá nhân hoặc doanh nghiệp nhỏ. Họ mua băng thông từ các ISP cấp hai hoặc một và bán lại cho khách hàng của mình.

## 📚Giao thức (Protocol)

**Giao thức (Protocol)** trong mạng máy tính là **tập hợp các quy tắc và quy ước** giúp các thiết bị mạng có thể giao tiếp và truyền tải dữ liệu một cách chính xác và nhất quán. Các giao thức đảm bảo rằng dữ liệu được gửi và nhận theo một trình tự và định dạng mà cả hai bên đều hiểu, bất kể thiết bị của họ khác nhau như thế nào. Nó quy định các quy tắc về:

- **Cấu trúc dữ liệu**: Định nghĩa cách dữ liệu được đóng gói, truyền tải, và giải mã.

- **Thứ tự truyền**: Xác định thứ tự dữ liệu phải được gửi và nhận.

- **Phản hồi**: Quy định cách thức phản hồi nếu một phần dữ liệu bị mất, hoặc nếu có lỗi xảy ra.

Chức năng:
- **Phân chia và tái hợp dữ liệu**: Khi một lượng lớn dữ liệu cần truyền đi, giao thức chia nhỏ dữ liệu đó thành các gói tin nhỏ, sau đó tái hợp chúng lại khi đến đích.

- **Kiểm soát lưu lượng**: Giao thức giúp điều chỉnh lưu lượng để tránh tình trạng tắc nghẽn mạng, đảm bảo các thiết bị không bị quá tải dữ liệu.

- **Kiểm tra lỗi**: Giao thức có thể phát hiện và sửa lỗi khi truyền dữ liệu, đảm bảo rằng dữ liệu đến nơi không bị sai lệch so với bản gốc.

- **Kết nối và duy trì kết nối**: Một số giao thức thiết lập kết nối giữa các thiết bị và duy trì kết nối trong suốt quá trình truyền dữ liệu.

Phân loại:
- Giao thức tầng ứng dụng (Application Layer Protocols): HTTP/HTTPS (HyperText Transfer Protocol), FTP (File Transfer Protocol), SMTP (Simple Mail Transfer Protocol), DNS (Domain Name System)

- Giao thức tầng vận chuyển (Transport Layer Protocols): TCP (Transmission Control Protocol), UDP (User Datagram Protocol)

- Giao thức tầng mạng (Network Layer Protocols): IP (Internet Protocol), ICMP (Internet Control Message Protocol)

- Giao thức tầng liên kết dữ liệu (Data Link Layer Protocols): Ethernet, Wi-Fi (Wireless Fidelity)

*❗Hiểu đơn giản mỗi khi cần kết nối hay chuyển tiếp qua các tầng mạng thì cần có 1 chuẩn quy định chung để đảm bảo sự tương thích và khi đó ta cần có **giao thức**.*

## 📚Kiến trúc tầng (Layered Architecture)

### 📙Mô hình OSI (Open Systems Interconnection)

**Mô hình OSI** được phát triển bởi **Tổ chức Tiêu chuẩn hóa Quốc tế (ISO)** vào cuối những năm 1970. Mô hình này là một khung lý thuyết để mô tả cách các hệ thống mạng truyền tải và nhận dữ liệu thông qua một cấu trúc phân tầng.

Cấu trúc:
- **Tầng vật lý (Physical Layer)**:
    - Chịu trách nhiệm về việc truyền dữ liệu thô (bits) qua các phương tiện vật lý như cáp đồng, cáp quang, sóng radio...

    - Các thiết bị ở tầng này bao gồm: cáp, hub, repeater.

- **Tầng liên kết dữ liệu (Data Link Layer)**:
    - Đảm bảo việc truyền tải dữ liệu giữa các thiết bị liền kề trong mạng, xử lý các vấn đề liên quan đến kiểm soát lỗi và kiểm soát luồng.
    
    - Các giao thức: Ethernet, PPP.
    
    - Thiết bị: switch, bridge.

- **Tầng mạng (Network Layer)**:
    - Chịu trách nhiệm định tuyến dữ liệu từ nguồn đến đích thông qua các mạng khác nhau. Cung cấp địa chỉ IP và quyết định đường đi cho các gói tin.
    
    - Giao thức: IP (IPv4, IPv6), ICMP.
    
    - Thiết bị: router.

- **Tầng vận chuyển (Transport Layer)**:
    - Đảm bảo rằng dữ liệu được truyền chính xác, đầy đủ và theo đúng thứ tự. Nó có thể sử dụng giao thức kết nối (TCP) hoặc không kết nối (UDP).
    
    - Giao thức: TCP, UDP.

- **Tầng phiên (Session Layer)**:
    - Quản lý các phiên giao tiếp giữa hai hệ thống. Tầng này mở, quản lý và kết thúc các phiên kết nối giữa hai thiết bị.

- **Tầng trình diễn (Presentation Layer)**:
    - Đảm bảo dữ liệu được chuyển đổi sang định dạng mà tầng ứng dụng hoặc người dùng có thể hiểu. Nó thực hiện các chức năng mã hóa và giải mã, nén và giải nén dữ liệu.

- **Tầng ứng dụng (Application Layer)**:
    - Đây là tầng gần nhất với người dùng. Tầng này cung cấp giao diện và các dịch vụ để các ứng dụng có thể giao tiếp qua mạng.
    
    - Giao thức: HTTP, FTP, SMTP, DNS.
  
Chức năng:
- Phân chia các tác vụ mạng thành các tầng riêng biệt để dễ dàng quản lý, triển khai và sửa chữa.

- Cung cấp một khung lý thuyết để phát triển các giao thức mới, tương thích và không phụ thuộc vào phần cứng.

- Khả năng chuẩn hóa, giúp các nhà cung cấp khác nhau phát triển sản phẩm tương thích với nhau.

### 📙Mô hình TCP/IP

**Mô hình TCP/IP** được phát triển vào cuối những năm 1970 bởi **DARPA (Cơ quan Dự án Nghiên cứu Quốc phòng Hoa Kỳ)** và được sử dụng rộng rãi cho mạng Internet hiện nay. Nó được coi là một mô hình thực tế và dựa trên các giao thức đã được ứng dụng trong thực tế.

Cấu trúc:
- **Tầng liên kết (Link Layer)**:
    - Tương đương với tầng vật lý và tầng liên kết dữ liệu trong mô hình OSI.
    
    - Xử lý việc truyền tải dữ liệu trong mạng cục bộ, kết nối trực tiếp các thiết bị liền kề.
    
    - Giao thức: Ethernet, Wi-Fi.

- **Tầng Internet (Internet Layer)**:
    - Tương đương với tầng mạng của mô hình OSI. Xử lý việc định tuyến các gói tin từ nguồn đến đích qua các mạng khác nhau.

    - Giao thức: IP, ICMP, ARP.

- **Tầng vận chuyển (Transport Layer)**:
    - Giống với tầng vận chuyển của mô hình OSI. Đảm bảo dữ liệu được truyền chính xác giữa hai hệ thống.

    - Giao thức: TCP, UDP.

- **Tầng ứng dụng (Application Layer)**:
    - Tương đương với tầng ứng dụng, trình diễn, và phiên của mô hình OSI. Cung cấp các dịch vụ và giao thức để các ứng dụng tương tác với nhau qua mạng.

    - Giao thức: HTTP, FTP, SMTP, DNS, Telnet.

Chức năng:
- Được thiết kế để hoạt động trong thực tế với các giao thức cụ thể như TCP và IP.

- Đơn giản hơn mô hình OSI, chỉ có 4 tầng và ít phân tầng chi tiết hơn.

- Được phát triển với mục đích phục vụ mạng Internet, nên có tính thực tiễn cao và dễ triển khai.

### 📙So sánh OSI và TCP/IP

| Tiêu chí         | Mô hình OSI                                       | Mô hình TCP/IP                                     |
| ---------------- | ------------------------------------------------- | -------------------------------------------------- |
| Số tầng          | 7 tầng                                            | 4 tầng                                             |
| Tính thực tiễn   | Mang tính lý thuyết, không được sử dụng rộng rãi. | Được sử dụng rộng rãi trong Internet và mạng LAN.  |
| Phát triển       | Do ISO phát triển, tập trung vào chuẩn hóa.       | Do DARPA phát triển, tập trung vào tính thực tiễn. |
| Giao thức        | Không định nghĩa các giao thức cụ thể.            | Định nghĩa cụ thể các giao thức như TCP, IP.       |
| Tính phân tầng   | Phân chia chi tiết thành 7 tầng.                  | Gộp lại thành 4 tầng, dễ áp dụng hơn.              |
| Tính tương thích | Đưa ra khung để phát triển các giao thức mới.     | Được xây dựng trên các giao thức đã có sẵn.        |
| Chức năng        | Mô tả chi tiết chức năng của từng tầng.           | Tập trung vào truyền tải và kết nối mạng.          |

*❗**Mô hình OSI**: Chủ yếu mang tính lý thuyết, cung cấp một cái nhìn chi tiết về cách mạng máy tính hoạt động, với 7 tầng phân tách rõ ràng. Mô hình này thường được sử dụng trong việc giảng dạy và nghiên cứu.*

*❗**Mô hình TCP/IP**: Đơn giản hơn và mang tính thực tiễn cao, được áp dụng rộng rãi trong các mạng hiện đại, đặc biệt là Internet.*

## 📚Chuyển mạch

### 📙Chuyển mạch gói (Packet Switching)

Trong **chuyển mạch gói**, dữ liệu được chia thành nhiều gói nhỏ (packets) và mỗi gói này được truyền đi độc lập qua mạng. Các gói tin có thể đi qua các đường khác nhau để đến đích, và sau đó được tập hợp lại theo đúng thứ tự tại điểm đích. Mỗi gói tin chứa không chỉ dữ liệu mà còn các thông tin điều khiển như địa chỉ nguồn, địa chỉ đích và số thứ tự gói để đảm bảo chúng được ghép lại đúng cách.

Đặc điểm:
- Không cần thiết lập kết nối cố định: Dữ liệu được gửi ngay lập tức mà không cần thiết lập kênh cố định.

- Linh hoạt: Các gói có thể đi qua nhiều đường khác nhau để đến đích, tùy thuộc vào tình trạng mạng tại thời điểm truyền.

- Chia sẻ tài nguyên mạng: Băng thông và các tài nguyên mạng được chia sẻ giữa nhiều kết nối. Điều này giúp mạng sử dụng tài nguyên hiệu quả hơn.

- Độ trễ thay đổi: Do các gói tin có thể đi qua nhiều đường khác nhau, thời gian đến đích của từng gói tin có thể khác nhau.

Ưu điểm:
- Sử dụng hiệu quả tài nguyên mạng: Tài nguyên mạng không bị chiếm dụng bởi một kết nối duy nhất, các kết nối khác vẫn có thể truyền dữ liệu qua cùng một đường.

- Linh hoạt và bền bỉ: Nếu một đường truyền gặp sự cố, các gói có thể chọn đường khác để đến đích.

- Tính mở rộng cao: Dễ dàng mở rộng mạng và kết nối thêm nhiều thiết bị mà không cần tăng đáng kể tài nguyên mạng.

Nhược điểm:
- Độ trễ không đều: Các gói tin có thể đến đích với độ trễ khác nhau, dẫn đến hiện tượng **jitter** (gói tin đến không đều).

- Khả năng mất gói: Nếu có tắc nghẽn mạng hoặc sự cố, các gói tin có thể bị mất và phải gửi lại, điều này có thể gây chậm trễ.

- Chất lượng dịch vụ không đảm bảo: Vì mạng chia sẻ tài nguyên, chất lượng dịch vụ có thể không được đảm bảo như trong chuyển mạch kênh.

Ứng dụng:
- Internet: Toàn bộ dữ liệu trên Internet (như email, web, video trực tuyến) được truyền tải qua chuyển mạch gói. Giao thức chính là IP (Internet Protocol).

- Mạng truyền dữ liệu hiện đại: Bao gồm các mạng LAN, WAN và mạng di động hiện đại.

### 📙Chuyển mạch kênh (Circuit Switching)

Trong **chuyển mạch kênh**, trước khi truyền dữ liệu, một kênh cố định hoặc đường dẫn sẽ được thiết lập giữa bên gửi và bên nhận. Kênh này được duy trì trong suốt quá trình truyền dữ liệu và tất cả dữ liệu sẽ đi qua cùng một đường. Kênh này giống như một đường dây riêng dành riêng cho các thiết bị giao tiếp cho đến khi quá trình truyền dữ liệu hoàn tất. Khi việc truyền tải hoàn tất, kênh sẽ bị đóng.

Đặc điểm:
- Thiết lập kết nối: Phải thiết lập kết nối cố định trước khi bắt đầu truyền dữ liệu. Kết nối này là liên tục trong suốt quá trình truyền dữ liệu.

- Đường dẫn cố định: Dữ liệu được truyền qua một kênh cố định và không thay đổi cho đến khi truyền xong.

- Tài nguyên dành riêng: Tài nguyên của mạng (băng thông) được dành riêng cho kết nối này trong suốt thời gian truyền.

- Độ trễ thấp: Sau khi thiết lập kết nối, vì không có sự chia sẻ tài nguyên mạng giữa các kết nối khác.

Ưu điểm:
- Độ tin cậy cao: Kết nối cố định, đường truyền ổn định.

- Độ trễ thấp: Vì toàn bộ dữ liệu đều đi qua cùng một kênh, không phải chuyển đổi qua nhiều nút mạng.

Nhược điểm:
- Tốn tài nguyên: Kênh được dành riêng ngay cả khi không truyền dữ liệu (ví dụ khi có khoảng dừng trong cuộc gọi điện thoại).

- Không linh hoạt: Nếu một phần của kênh bị hỏng, toàn bộ kết nối bị ảnh hưởng.

- Thiết lập lâu hơn: Cần thiết lập kết nối trước khi truyền dữ liệu.

Ứng dụng:
- Điện thoại truyền thống (PSTN): Khi thực hiện một cuộc gọi điện thoại, hệ thống sẽ thiết lập một kênh cố định giữa hai máy, và kênh này sẽ duy trì cho đến khi cuộc gọi kết thúc.

### 📙So sánh chuyển mạch gói và chuyển mạch kênh

| Tiêu chí          | Chuyển mạch kênh (Circuit Switching)                    | Chuyển mạch gói (Packet Switching)                           |
| ----------------- | ------------------------------------------------------- | ------------------------------------------------------------ |
| Thiết lập kết nối | Phải thiết lập kết nối cố định trước khi truyền dữ liệu | Không cần thiết lập kết nối, dữ liệu được chia thành các gói |
| Tài nguyên mạng   | Tài nguyên được dành riêng trong suốt kết nối           | Tài nguyên được chia sẻ giữa nhiều kết nối                   |
| Đường truyền      | Dữ liệu đi qua một đường cố định                        | Các gói có thể đi qua các đường khác nhau                    |
| Độ trễ            | Độ trễ thấp sau khi thiết lập kênh                      | Độ trễ thay đổi, có thể cao do chia sẻ tài nguyên            |
| Mất gói dữ liệu   | Không có mất gói, dữ liệu truyền liên tục               | Có khả năng mất gói, đặc biệt khi tắc nghẽn mạng             |

## 📚Băng thông (Bandwidth)

**Băng thông** đề cập đến **lượng dữ liệu tối đa** có thể được truyền qua một kênh truyền (cáp quang, cáp đồng, mạng không dây, v.v.) trong một khoảng thời gian cụ thể.

### 📙Phân loại

**Băng thông danh định (Theoretical Bandwidth)**: Đây là **mức băng thông tối đa** mà một kết nối mạng có thể hỗ trợ theo lý thuyết, dựa trên thông số kỹ thuật của phần cứng hoặc tiêu chuẩn truyền dẫn. Tuy nhiên, tốc độ thực tế thường thấp hơn nhiều so với mức này do các yếu tố như tắc nghẽn mạng, mất gói, hoặc độ trễ.

**Băng thông thực tế (Effective Bandwidth / Throughput)**: Đây là **lượng dữ liệu thực tế** mà người dùng có thể truyền tải qua mạng. **Băng thông thực tế thường nhỏ hơn băng thông danh định**, bị ảnh hưởng bởi các yếu tố như chất lượng thiết bị mạng, số lượng người dùng, và điều kiện môi trường.

**Băng thông đối xứng (Symmetrical Bandwidth)**: Là loại băng thông mà tốc độ tải xuống (download) và tải lên (upload) là như nhau. Điều này thường gặp ở các kết nối mạng quang hoặc trong các dịch vụ Internet doanh nghiệp.

**Băng thông không đối xứng (Asymmetrical Bandwidth)**: Đây là loại băng thông mà tốc độ tải xuống lớn hơn tải lên. Nó phổ biến trong các dịch vụ Internet gia đình vì người dùng thường tải xuống nhiều hơn (xem video, duyệt web) so với tải lên.

### 📙Cách tính

Băng thông thường được đo bằng **bit trên giây (bps)**, nhưng với tốc độ truyền tải dữ liệu ngày càng cao, ta thường gặp các đơn vị lớn hơn:
- 1 Mbps (Megabits per second) = 1 triệu bits trên giây
- 1 Gbps (Gigabits per second) = 1 tỷ bits trên giây
- 1 Tbps (Terabits per second) = 1 nghìn tỷ bits trên giây

### 📙Các yếu tố ảnh hưởng

**Tắc nghẽn mạng (Network Congestion)**: Khi có nhiều thiết bị cùng chia sẻ một kết nối mạng, mỗi thiết bị có thể không nhận được đủ băng thông, dẫn đến chậm mạng.

**Tốc độ thiết bị phần cứng**: Router, modem hoặc các thiết bị mạng khác có thể là *nút cổ chai*, làm giảm băng thông thực tế nếu chúng không đủ khả năng xử lý lưu lượng dữ liệu.

**Khoảng cách và nhiễu**: Đối với mạng không dây, khoảng cách giữa thiết bị và điểm truy cập, cũng như nhiễu từ các thiết bị khác, có thể làm giảm băng thông.

**Giao thức mạng và phương pháp điều khiển**: Một số giao thức hoặc phương pháp quản lý lưu lượng dữ liệu có thể làm giảm hiệu suất, khiến tốc độ mạng chậm đi.

### 📙Băng thông trong các loại mạng

Mạng có dây (Wired Networks):
- **Ethernet**: Hầu hết các mạng Ethernet hiện đại có băng thông **tối thiểu 100 Mbps**, và nhiều mạng cao cấp có thể hỗ trợ lên tới **1 Gbps hoặc 10 Gbps**.

- **Cáp quang**: Có thể cung cấp băng thông rất lớn, **lên đến Tbps** trong các mạng lưới cốt lõi (core networks).

Mạng không dây (Wireless Networks):
- **Wi-Fi**: Với chuẩn Wi-Fi 5 (802.11ac), băng thông lý thuyết có thể đạt **từ 433 Mbps đến 1.3 Gbps**. Wi-Fi 6 (802.11ax) có băng thông thậm chí cao hơn, với tốc độ **lên tới 9.6 Gbps** trong các điều kiện tối ưu.

- Mạng di động (4G/5G): Mạng 4G LTE cung cấp băng thông tối đa khoảng **100 Mbps đến 1 Gbps**, trong khi mạng 5G có thể cung cấp tốc độ **lên đến 10 Gbps hoặc hơn**.

## 📚Tốc độ truyền tải (Throughput)

**Tốc độ truyền tải** là số lượng dữ liệu được truyền thành công qua mạng trong một khoảng thời gian cụ thể.

### 📙Tính chất

**Lượng dữ liệu thực tế**: Throughput phản ánh khả năng xử lý và truyền tải dữ liệu của mạng trong điều kiện thực tế, bao gồm cả các yếu tố như tắc nghẽn mạng, mất gói, và độ trễ.

**Thay đổi theo thời gian**: Tốc độ truyền tải có thể biến đổi theo thời gian do nhiều yếu tố, chẳng hạn như số lượng người dùng truy cập cùng lúc, ứng dụng đang sử dụng, và tình trạng của thiết bị mạng.

### 📙Cách tính

Tốc độ truyền tải thường được đo bằng **bit trên giây (bps)** hoặc các đơn vị lớn hơn.
$$
Throughput = \frac{Total Data Transmitted}{Transmission Time}
$$

Ví dụ: Nếu một file có kích thước 100 MB được truyền trong 10 giây, throughput sẽ được tính như sau:
- Chuyển đổi MB sang bits: 100 MB = 800 Megabits (1 Byte = 8 bits)
- Tính toán throughput:
$$
Throughput = \frac{800 Megabits}{10 seconds} = 80 Mbps
$$
​
### 📙Các yếu tố ảnh hưởng

**Tắc nghẽn mạng**: Khi nhiều người dùng cùng truy cập mạng, lưu lượng tăng cao có thể dẫn đến giảm throughput.

**Chất lượng đường truyền**: Sự suy giảm tín hiệu do nhiễu, khoảng cách giữa các thiết bị, hoặc sự yếu kém của thiết bị mạng có thể làm giảm tốc độ truyền tải.

**Mất gói (Packet Loss)**: Khi dữ liệu bị mất trong quá trình truyền tải, gói tin cần phải được gửi lại, làm giảm throughput tổng thể.

**Độ trễ (Latency)**: Độ trễ cao có thể ảnh hưởng đến khả năng truyền tải, đặc biệt trong các ứng dụng yêu cầu thời gian phản hồi nhanh.

**Giao thức mạng**: Các giao thức khác nhau có cách xử lý và quản lý lưu lượng khác nhau, ảnh hưởng đến throughput.

## 📚Độ trễ (Latency)

**Độ trễ** là thời gian từ khi một gói tin được gửi đi từ thiết bị nguồn cho đến khi nó đến đích.

### 📙Thành phần

**Độ trễ truyền (Transmission Delay)**: Thời gian cần thiết để gửi toàn bộ gói dữ liệu qua môi trường truyền tải. Độ trễ này phụ thuộc vào kích thước gói dữ liệu và băng thông của đường truyền.
$$
Transmission Delay = \frac{Size of the packet}{Bandwidth}
$$

**Độ trễ xử lý (Processing Delay)**: Thời gian mà thiết bị mạng (router, switch) cần để xử lý gói dữ liệu, bao gồm việc kiểm tra, phân tí Thời gian này phụ thuộc vào tốc độ xử lý của thiết bị và các thuật toán được sử dụng.

**Độ trễ xếp hàng (Queueing Delay)**: Thời gian mà gói dữ liệu phải chờ trong hàng đợi ở thiết bị mạng trước khi được xử lý. Độ trễ này thay đổi theo mức độ tắc nghẽn của mạng.

**Độ trễ truyền tải (Propagation Delay)**: Thời gian mà tín hiệu cần để di chuyển qua môi trường truyền dẫn (cáp quang, không khí, v.v.). Độ trễ này phụ thuộc vào tốc độ truyền tín hiệu (thường là tốc độ ánh sáng trong cáp quang) và khoảng cách giữa hai điểm.
$$
Propagation Delay = \frac{Distance}{Propagation Speed}
$$

### 📙Cách tính

**Tổng độ trễ (Total Latency)** là tổng hợp của tất cả các độ trễ. Độ trễ có thể được đo bằng đơn vị thời gian, thường là mili giây (ms).
$$
Total Latency = Transmission Delay + Processing Delay + Queuing Delay + Propagation Delay
$$

Ví dụ: Nếu một gói tin mất 10 ms để truyền tải qua mạng, 5 ms để xử lý tại router, và 2 ms để chờ trong hàng đợi, thì độ trễ tổng cộng sẽ là:
$$
Latency = 10 + 5 + 2 = 17 ms
$$

### 📙Các yếu tố ảnh hưởng

**Khoảng cách vật lý**: Khoảng cách giữa điểm gửi và điểm nhận có ảnh hưởng lớn đến độ trễ. Khoảng cách càng xa, độ trễ càng lớn.

**Chất lượng đường truyền**: Các loại cáp truyền tải và thiết bị mạng khác nhau có thể gây ra độ trễ khác nhau. Cáp quang thường có độ trễ thấp hơn cáp đồng.

**Tình trạng mạng**: Tắc nghẽn mạng, số lượng người dùng truy cập cùng lúc, và tình trạng các thiết bị mạng cũng ảnh hưởng đến độ trễ.

**Cấu hình mạng**: Các yếu tố như cấu hình router, switch, và các thiết lập QoS (Quality of Service) cũng có thể tác động đến độ trễ.

## 📚Tấn công mạng (cyber attacks)

## 📚Phần mềm độc hại (malware)

## 📚Tầng ứng dụng (Application Layer)

**Tầng ứng dụng** là tầng mà người dùng trực tiếp tương tác với, nơi các ứng dụng mạng và giao thức hoạt động để cung cấp dịch vụ cho người dùng cuối. Tầng này thực hiện các chức năng như gửi và nhận dữ liệu, quản lý phiên kết nối, và điều phối các ứng dụng.

Chức năng chính:
- **Quản lý Phiên Kết nối (Session Management)**: Tầng ứng dụng quản lý các phiên kết nối giữa các ứng dụng trên các thiết bị khác nhau, bao gồm việc thiết lập, duy trì và kết thúc phiên.

- **Truyền Tải Dữ liệu (Data Transfer)**: Đảm bảo rằng dữ liệu được truyền tải chính xác và an toàn giữa các ứng dụng, bao gồm cả việc mã hóa và giải mã dữ liệu khi cần thiết.

- **Cung cấp Giao diện cho Người dùng**: Tầng ứng dụng cung cấp giao diện trực quan cho người dùng cuối, cho phép họ tương tác với các ứng dụng một cách dễ dàng.

- **Tương tác với Tầng dưới (Lower Layers)**: Tầng ứng dụng tương tác với các tầng dưới (tầng transport, tầng network, v.v.) để đảm bảo rằng dữ liệu được gửi đi và nhận về một cách hiệu quả.

## 📚Mô hình máy khách - máy chủ (Client-Server Model)

## 📚Mô hình P2P (Peer-to-Peer)

## 📚P2P Applications

## 📚Giao thức HTTP (Hypertext Transfer Protocol)

**HTTP (HyperText Transfer Protocol)** là giao thức truyền tải siêu văn bản, giao thức HTTP dựa trên **giao thức TCP/IP** nó cho phép lấy về các tài nguyên như văn bản HTML, text, video, ảnh ...

**HTTP** là nền tảng dùng để trao đổi dữ liệu cho các ứng dụng Web với **mô hình Client/Server**

HTTP là **phi trạng thái (stateless)**, có nghĩa không có mối liên hệ nào giữa hai yêu cầu được gửi đi, dù nó là thực hiện trên cùng một kế nối - đến cùng một server.

Do HTTP là stateless nên để cung cấp khả năng chia sẻ trạng thái giữa những request của phiên làm việc cần sử dụng tới **HTTP Cookie**, những dữ liệu nhằm duy trì trạng thái của phiên làm việc, sẽ được thêm vào phần header của HTTP Message

### 📙Các Phiên bản HTTP

**HTTP/1.0** (Phát hành vào năm 1996) : HTTP/1.0 là phiên bản đầu tiên của giao thức HTTP được chính thức chuẩn hóa. Đặc điểm chính:

- **Kết nối ngắn (Non-persistent connections)**: Sau mỗi yêu cầu, kết nối giữa máy khách và máy chủ sẽ bị đóng. Điều này làm tăng thời gian kết nối khi có nhiều yêu cầu.

- **Header đơn giản**: Mỗi yêu cầu chứa thông tin cơ bản như URL, phương thức (GET, POST), và dữ liệu gửi đi.

- Không hỗ trợ tính năng nén hoặc kiểm soát bộ nhớ đệm.

**HTTP/1.1** (Phát hành vào năm 1997) : HTTP/1.1 là phiên bản phổ biến nhất và đã tồn tại trong một thời gian dài. Những cải tiến so với HTTP/1.0:

- **Kết nối dài (Persistent connections)**: Kết nối được duy trì lâu hơn, giảm độ trễ bằng cách cho phép nhiều yêu cầu và phản hồi trong cùng một kết nối.

- **Pipeline**: Cho phép gửi nhiều yêu cầu mà không phải đợi phản hồi của các yêu cầu trước.

- **Nén nội dung**: Hỗ trợ nén để giảm kích thước dữ liệu truyền tải.

- **Kiểm soát bộ nhớ đệm (Caching)**: Hỗ trợ các header giúp cải thiện hiệu quả bộ nhớ đệm.

- **Host header**: HTTP/1.1 thêm header "Host" để hỗ trợ nhiều tên miền trên cùng một máy chủ.

**HTTP/2** (Phát hành vào năm 2015) : HTTP/2 đã mang lại nhiều cải tiến lớn so với HTTP/1.1, đặc biệt về tốc độ và hiệu suất:

- **Multiplexing**: Cho phép nhiều yêu cầu được gửi đồng thời trên cùng một kết nối mà không phải chờ đợi. Điều này cải thiện hiệu suất đáng kể.

- **Nén header (Header compression)**: HTTP/2 sử dụng nén header (HPACK) để giảm kích thước các gói tin, tiết kiệm băng thông.

- **Server push**: Máy chủ có thể gửi trước các tài nguyên mà nó dự đoán sẽ được yêu cầu, giảm thời gian chờ đợi cho người dùng.

- **Binary protocol**: HTTP/2 sử dụng giao thức nhị phân thay vì văn bản như HTTP/1.x, giúp tăng hiệu suất và giảm độ phức tạp trong phân tích cú pháp.

**HTTP/3** (Đang được triển khai, dựa trên QUIC) : HTTP/3 là phiên bản mới nhất của giao thức HTTP và là bước tiến lớn nhờ việc sử dụng QUIC thay vì TCP. QUIC là giao thức truyền dữ liệu được phát triển bởi Google, với các đặc điểm chính:

- **QUIC** thay thế TCP: QUIC là giao thức tầng truyền tải kết hợp giữa UDP và các tính năng của TCP (như quản lý phiên kết nối, kiểm soát lỗi), giảm thời gian thiết lập
  kết nối và độ trễ.

- **Giảm độ trễ**: HTTP/3 giảm thiểu độ trễ khi kết nối mới được thiết lập nhờ QUIC, phù hợp hơn với các ứng dụng di động hoặc mạng không ổn định.

- **Chống nghẽn kết nối (Head-of-line blocking)**: Nếu một gói tin bị mất trong HTTP/2 (TCP), tất cả các yêu cầu khác trên cùng kết nối sẽ phải chờ. QUIC khắc phục vấn đề
  này bằng cách truyền tải không phụ thuộc theo dòng.

- **Cải thiện bảo mật**: HTTP/3 tích hợp mã hóa từ đầu, giúp tăng cường bảo mật mà không cần thiết lập thủ công như trong các phiên bản trước.

So sánh tổng quát

| Tính năng           | HTTP/1.0 | HTTP/1.1 | HTTP/2             | HTTP/3             |
| ------------------- | -------- | -------- | ------------------ | ------------------ |
| Kết nối             | Ngắn     | Dài      | Dài, nhiều yêu cầu | Dài, nhiều yêu cầu |
| Nén dữ liệu         | Không    | Có       | Có (header)        | Có                 |
| Định dạng dữ liệu   | Văn bản  | Văn bản  | Nhị phân           | Nhị phân           |
| Multiplexing        | Không    | Không    | Có                 | Có                 |
| Server Push         | Không    | Không    | Có                 | Có                 |
| Giao thức tầng dưới | TCP      | TCP      | TCP                | QUIC (trên UDP)    |
| Bảo mật tích hợp    | Không    | Không    | Không              | Mã hóa mặc định    |

### 📙HTTP Message

Các yêu cầu (**request hay HTTP Request**) được tạo bởi client (thường là các Web browser như chrome, firefox ...) được gửi đến server http, server sẽ gửi lại dữ liệu (**response hay HTTP Response**) để client nhận được.

Các request, response là các message có cấu trúc đơn giản gọi chung nó là các **HTTP Message**. HTTP Message có thể đọc được mà không nhất thiết phải có công cụ phân tích riêng biệt, nó giảm đi sự phức tạp khi phát triển, kiểm tra ứng dụng.

*❗Hiểu đơn giản **HTTP Message (Thông điệp HTTP)** là các thông tin được trao đổi qua lại giữa client và server.*

Có 2 loại:

- **HTTP Request Message (Request)** được gửi đi bởi client tới server - khi server nhận được nó biết phải thực hiện nhiệm vụ nào đó

- **HTTP Response Message (Response)** là trả lời từ server về cho client


Cấu trúc chung

- Dòng đầu tiên (một dòng): Cho biết thông tin yêu cầu hoặc trạng thái (thành công hay lỗi) của response.

- Phần header (các dòng sau dòng đầu tiên trước một dòng trắng): Nó là một tập hợp các dòng chứa thông tin về HTTP Message, thông tin về phần body

- Một dòng trắng cho biết phần thông tin (dòng đầu và header) đã gửi hết

- Phần body chứa dữ liệu đính kèm với request (như HTML Form) hoặc nội dung văn bản đính kèm cùng response. Kích cỡ dữ liệu này (size) có được xác định bởi thông tin trong header

**_Đọc thêm tại [HTTP Message](https://en.wikipedia.org/wiki/List_of_HTTP_header_fields#General_format)_**

Cấu trúc HTTP Request Message

```bash
GET /index.html HTTP/1.1
Host: example.com
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/117.0.0.0 Safari/537.36
Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8
Accept-Language: en-US,en;q=0.5
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
Upgrade-Insecure-Requests: 1
```
- Dòng đầu tiên: Dòng này chứa thông tin để gửi tới server, dựa vào thông tin này mà server thực thi hành động phù hợp. Dòng này nó có chứa ba thông tin cách nhau bởi khoảng trắng

  - HTTP Method (Phương thức HTTP) là thành phần thứ nhất, nó có giá trị như POST, GET, PUT, DELETE. Nó cho biết yêu cầu cần được thực hiện trên server đối với một tài nguyên nào đó, cụ thể như các phương thức:

    - GET cho biết Request chỉ cần lấy dữ liệu (tài nguyên).
    - POST được sử dụng để cho biết Request là chuyển dữ liệu lên server (thương HTTP Message trường hợp này có kèm dữ liệu như HTML Form ...)
    - PUT ghi đè (thay thế) tài nguyên nào đó bằng dữ liệu trong Request.
    - DELETE xóa tài nguyên
    - HEAD tương tự như GET nhưng chỉ yêu cầu các header mà không lấy body. Thường được sử dụng để kiểm tra tính khả dụng của tài nguyên.

  - Địa chỉ URL - là thành phần thứ hai. Địa chỉ tài nguyên truy vấn, có thể là URL tương đối - tuyệt đối (kể cả cổng, nếu có cổng thì viết cổng sau ký hiệu :)

  - HTTP Version Thành phần thứ ba cho biết phiên bản HTTP

- Header của Request: Các header có cấu trúc đó là một chuỗi là tên header tiếp theo là dấu : và giá trị cho header. Mỗi header được viết trên một dòng. Có rất nhiều loại header (đã chuẩn hóa hoặc header do bạn tự đặt)

- Body của Request: Chứa dữ liệu của Request (dữ liệu này có kiểu xác định ở header Content-Type và độ dài Content-Length), không phải mọi Request đều có body, dữ liệu body thường là HTML Form hay JSON

Cấu trúc HTTP Response Message

```PHP
HTTP/1.1 200 OK
Date: Sun, 06 Oct 2024 09:00:00 GMT
Server: Apache/2.4.29 (Ubuntu)
Last-Modified: Mon, 01 Oct 2024 12:00:00 GMT
Content-Type: text/html
Content-Length: 2345
Connection: keep-alive

<!DOCTYPE html>
<html>
<head>
    <title>Example Page</title>
</head>
<body>
    <h1>Welcome to Example.com!</h1>
    <p>This is a sample webpage.</p>
</body>
</html>
```
- Dòng đầu tiên: còn gọi là dòng trạng thái, nó chứa ba mẩu tin gồm

  - Phiên bản HTTP
  - Mã Trạng thái HTTP (HTTP Status Codes)
    - 1xx (Informational): Chỉ thị rằng yêu cầu đã được nhận và đang xử lý.
    - 2xx (Success): Chỉ thị rằng yêu cầu đã được xử lý thành công. Ví dụ:
        - 200 OK: Yêu cầu thành công.
        - 201 Created: Tài nguyên mới đã được tạo.
    - 3xx (Redirection): Chỉ thị rằng yêu cầu cần được chuyển hướng tới một URL khác.
        - 301 Moved Permanently: Tài nguyên đã chuyển đến một vị trí mới.
    - 4xx (Client Error): Chỉ thị rằng có lỗi từ phía khách hàng.
        - 404 Not Found: Tài nguyên không được tìm thấy.
    - 5xx (Server Error): Chỉ thị rằng có lỗi từ phía máy chủ.
        - 500 Internal Server Error: Máy chủ gặp lỗi không xác định.
  - Đoạn text ngắn giải thích mã ví dụ OK, Not Found, Moved Permanently ...

- Header của Response: tương tự như header của Request

- Body của Response: Chứa dữ liệu của Respone (dữ liệu này có kiểu xác định ở header Content-Type và độ dài Content-Length), không phải mọi Response đều có body


## 📚Cookies và quản lý phiên (Session Management)

### 📙Cookies

**Cookies** là các đoạn dữ liệu nhỏ được máy chủ web gửi tới trình duyệt của người dùng và được lưu trữ trên máy tính của người dùng. Cookies cho phép máy chủ nhận diện và theo dõi người dùng trong các lần truy cập sau.

Chức năng:

- **Nhận diện người dùng**: Cookies thường được sử dụng để duy trì nhận diện người dùng khi họ truy cập vào một trang web nhiều lần. Điều này giúp cho các trang web nhớ các thông tin như giỏ hàng, phiên đăng nhập, hay các tùy chỉnh cá nhân.

- **Lưu trữ trạng thái ứng dụng**: Cookies có thể lưu trữ các thông tin trạng thái của phiên (session state) để giúp các trang web hoạt động liên tục mà không yêu cầu người dùng phải đăng nhập lại khi tải lại trang.

- **Theo dõi hoạt động**: Các trang web và bên thứ ba có thể sử dụng cookies để theo dõi hoạt động của người dùng nhằm phân tích và cá nhân hóa quảng cáo.

Cách thức hoạt động:
- Khi người dùng truy cập một trang web lần đầu tiên, máy chủ có thể tạo và gửi một cookie tới trình duyệt của họ. Cookie này sẽ được lưu trên máy của người dùng.
- Khi người dùng quay lại trang web trong tương lai, trình duyệt sẽ gửi lại cookie đó cho máy chủ, cho phép máy chủ xác định người dùng đó là ai và khôi phục thông tin liên quan.

```yaml
HTTP/1.1 200 OK
Set-Cookie: session_id=38afes7w8f83; Expires=Wed, 09 Oct 2024 23:12:40 GMT; Path=/; Secure; HttpOnly
Content-Type: text/html
Content-Length: 1234
```

### 📙Quản lý phiên (Session Management)

**Session (phiên làm việc)** là một chuỗi các tương tác giữa client và server trong khoảng thời gian nhất định. Mỗi phiên làm việc bắt đầu khi người dùng kết nối với ứng dụng và kết thúc khi phiên được đóng (khi người dùng thoát ra hoặc khi có thời gian chờ hết hạn).

Phiên thường được sử dụng để duy trì trạng thái của người dùng trong các trang web, đặc biệt là các ứng dụng yêu cầu đăng nhập hoặc có quá trình làm việc dài hạn (như giỏ hàng trong các trang web thương mại điện tử).

**Cách thức Quản lý Phiên (Session Management)**: Quản lý phiên làm việc thường yêu cầu máy chủ giữ trạng thái của phiên đó. Do HTTP là giao thức không trạng thái (stateless), nghĩa là mỗi yêu cầu HTTP là độc lập, session management giúp theo dõi các phiên làm việc này và duy trì thông tin trạng thái giữa các yêu cầu liên tiếp.

**Session Timeout (thời gian hết hạn của phiên)** thường được sử dụng để bảo mật. Khi người dùng không tương tác với trang web trong một khoảng thời gian nhất định, phiên sẽ tự động hết hạn và người dùng phải đăng nhập lại.

Phương pháp Quản lý Phiên:
- **Sử dụng Cookies**: Cookie có thể lưu trữ một **Session ID**, và server sẽ sử dụng Session ID này để nhận diện người dùng và theo dõi phiên làm việc của họ. Ví dụ, khi người dùng đăng nhập vào trang web, server sẽ tạo một Session ID duy nhất và lưu trữ nó trong cookie. Mỗi khi người dùng gửi yêu cầu mới, cookie này sẽ được gửi kèm, cho phép server khôi phục phiên làm việc.

- **Sử dụng URL Rewriting (URL mã hóa)**: Trong một số trường hợp, nếu không thể sử dụng cookies (do người dùng tắt cookies), máy chủ có thể nhúng Session ID vào URL của trang web. Ví dụ: http://example.com/index.html?session_id=abc123.

- **Sử dụng Web Storage (HTML5 Storage)**: HTML5 giới thiệu các kỹ thuật lưu trữ như **localStorage** và **sessionStorage** để giúp quản lý thông tin phiên làm việc một cách linh hoạt hơn phía client.

## 📚Giao thức FTP (File Transfer Protocol)


Giao thức FTP (File Transfer Protocol) là một trong những giao thức quan trọng nhất để truyền tệp (file transfer) giữa hai máy tính trong mạng. FTP sử dụng mô hình client-server, nơi client gửi yêu cầu tới server để thực hiện các tác vụ như tải tệp lên (upload), tải tệp xuống (download), xóa, đổi tên, hoặc liệt kê các tệp trên server. FTP được định nghĩa từ những ngày đầu của Internet và vẫn được sử dụng phổ biến trong các ứng dụng và hệ thống quản lý tệp trực tuyến.

**Port mặc định**: FTP sử dụng hai cổng: **Port 21** để truyền lệnh và **Port 20** để truyền dữ liệu.

### 📙Cách thức hoạt động của FTP

FTP sử dụng hai kênh kết nối giữa client và server:

- **Kênh điều khiển (Control Connection)**: Kênh này được sử dụng để gửi các lệnh FTP từ client tới server và nhận lại các thông báo trạng thái. Nó được thiết lập qua Port 21 và duy trì trong suốt phiên FTP.

- **Kênh dữ liệu (Data Connection)**: Kênh này được thiết lập mỗi khi cần truyền dữ liệu (như tải tệp lên hoặc xuống) qua Port 20.

FTP có hai chế độ chính:

- **Active Mode (Chế độ chủ động)**: Máy chủ mở kết nối tới client để gửi dữ liệu. Client mở cổng ngẫu nhiên và thông báo cho server để server kết nối và truyền dữ liệu.

- **Passive Mode (Chế độ bị động)**: Client mở kết nối tới server để nhận dữ liệu. Đây là chế độ mà client khởi tạo cả hai kết nối (điều khiển và dữ liệu), thường được sử dụng khi client nằm sau tường lửa (firewall).

FTP hỗ trợ hai chế độ truyền dữ liệu:

- **ASCII mode**: Được sử dụng để truyền tệp văn bản. Trong chế độ này, dữ liệu được truyền dưới dạng ký tự ASCII, và server có thể chuyển đổi ký tự dòng mới giữa các hệ thống khác nhau (ví dụ: giữa Unix và Windows).

- **Binary mode**: Được sử dụng để truyền tệp nhị phân (binary), chẳng hạn như hình ảnh, video, hoặc các tệp phần mềm. Trong chế độ này, dữ liệu được truyền nguyên vẹn mà không có sự thay đổi.

### 📙Các lệnh FTP

- **USER**: Gửi tên người dùng đến máy chủ FTP.
- **PASS**: Gửi mật khẩu đến máy chủ để xác thực người dùng.
- **LIST**: Liệt kê các tệp và thư mục trong thư mục hiện tại trên máy chủ.
- **RETR**: Tải một tệp từ máy chủ xuống client.
- **STOR**: Tải một tệp từ client lên máy chủ.
- **QUIT**: Kết thúc phiên làm việc FTP.

Client mở kết nối tới Port 21 của server và gửi lệnh xác thực.
```css
220 Welcome to the FTP service
USER john
331 Username ok, need password
PASS secretpassword
230 Login successful
```

Sau khi xác thực thành công, client có thể sử dụng lệnh RETR để tải tệp từ server.
```yaml
RETR example.txt
150 Opening data connection for example.txt (file size: 1024 bytes)
226 Transfer complete
```

Khi quá trình tải hoàn tất, client có thể sử dụng lệnh QUIT để đóng kết nối.
```
QUIT
221 Goodbye
```

### 📙Bảo mật trong FTP

**FTP không mã hóa** các dữ liệu truyền qua mạng, bao gồm cả thông tin xác thực (username và password). Điều này tạo ra một rủi ro lớn khi sử dụng FTP qua mạng không an toàn (như Internet), vì bất kỳ ai cũng có thể đánh cắp dữ liệu nếu họ có thể truy cập vào kết nối.

Các phiên bản an toàn của FTP đã được phát triển:

- **FTPS (FTP Secure)**: Sử dụng SSL/TLS để mã hóa cả kênh điều khiển và kênh dữ liệu, giúp bảo mật thông tin xác thực và dữ liệu truyền.

- **SFTP (SSH File Transfer Protocol)**: Đây là một giao thức hoàn toàn khác so với FTP nhưng cung cấp chức năng tương tự. SFTP sử dụng SSH (Secure Shell) để bảo mật việc truyền tệp, cung cấp mã hóa cho cả lệnh và dữ liệu.

Với sự xuất hiện của các giao thức bảo mật hơn như FTPS và SFTP, FTP truyền thống hiện ít được sử dụng trong các môi trường cần bảo mật cao. Nhưng nó vẫn phổ biến trong các mạng nội bộ hoặc các hệ thống không yêu cầu bảo mật nghiêm ngặt.

### 📙Ưu điểm và nhược điểm của FTP
Ưu điểm:
- Truyền tải tệp hiệu quả: FTP hỗ trợ truyền tệp lớn và nhiều tệp một cách hiệu quả.
- Quản lý tệp từ xa: Người dùng có thể quản lý tệp trên server từ xa bằng cách sử dụng các lệnh FTP như xóa, đổi tên, hoặc di chuyển tệp.

Nhược điểm:
- Thiếu bảo mật: FTP không cung cấp mã hóa mặc định, làm cho nó dễ bị tấn công khi truyền qua mạng không an toàn.
- Phức tạp trong việc cấu hình tường lửa: Do sử dụng nhiều cổng, FTP có thể gặp khó khăn khi thiết lập qua các tường lửa hoặc NAT (Network Address Translation).

## 📚Giao thức SMTP (Simple Mail Transfer Protocol)

**Giao thức SMTP (Simple Mail Transfer Protocol)** là một giao thức được sử dụng để gửi và truyền tải email qua mạng. SMTP hoạt động theo mô hình client-server, trong đó máy khách gửi lệnh và dữ liệu email đến máy chủ, máy chủ sẽ tiếp nhận và chuyển tiếp email đó đến hệ thống đích hoặc lưu trữ trong hộp thư của người nhận.

Port mặc định: 
- **Port 25** là cổng chính thức được sử dụng để truyền email qua giao thức SMTP.
- **Port 587** thường được sử dụng để truyền email từ máy khách đến máy chủ SMTP, đặc biệt khi sử dụng kết nối bảo mật (TLS/SSL).

### 📙Cách thức hoạt động của SMTP

SMTP làm việc dựa trên **mô hình push** (đẩy), trong đó thư điện tử được "đẩy" từ máy khách đến máy chủ. Không giống như một số giao thức email khác (**POP3**, **IMAP**), SMTP chỉ hỗ trợ việc gửi thư chứ không phải nhận thư.

**Bước 1**: Thiết lập kết nối SMTP
- Máy khách (client) khởi tạo kết nối TCP tới máy chủ SMTP thông qua cổng mặc định (Port 25 hoặc 587).
- Sau khi kết nối được thiết lập, máy chủ SMTP trả về một thông điệp 220 để thông báo rằng máy chủ đã sẵn sàng nhận email.

*❗Thông điệp được máy chủ gửi về:*
- 220: Máy chủ SMTP sẵn sàng tiếp nhận yêu cầu.
- 250: Lệnh được thực hiện thành công.
- 354: Máy chủ sẵn sàng nhận dữ liệu từ client.
- 221: Máy chủ ngắt kết nối sau khi phiên làm việc kết thúc.

**Bước 2**: Trao đổi lệnh và dữ liệu
- Máy khách gửi các lệnh SMTP tới máy chủ theo các bước sau:
    - HELO hoặc EHLO: Lệnh này giới thiệu client tới server, máy chủ sẽ trả về mã trạng thái 250 (OK).
    - MAIL FROM: Client thông báo địa chỉ email người gửi.
    - RCPT TO: Client cung cấp địa chỉ email người nhận.
    - DATA: Client thông báo rằng thông điệp email sắp được gửi. Sau khi gửi lệnh DATA, client sẽ gửi nội dung của email (bao gồm tiêu đề, thân thư, và các file đính kèm nếu có).
    - QUIT: Sau khi quá trình gửi email hoàn tất, client sẽ gửi lệnh QUIT để kết thúc phiên làm việc.

**Bước 3**: Truyền tải email
- Sau khi máy chủ SMTP nhận được thông điệp email, nó sẽ chuyển tiếp email này tới máy chủ đích (nếu cần thiết) hoặc lưu trữ trong hộp thư của người nhận.

Ví dụ:

1. Kết nối và khởi tạo:

```makefile
S: 220 smtp.example.com Simple Mail Transfer Service Ready
C: HELO client.example.com
S: 250 smtp.example.com
```

2. Xác định người gửi và người nhận:

```ruby
C: MAIL FROM:<alice@example.com>
S: 250 OK
C: RCPT TO:<bob@example.com>
S: 250 OK
```

3. Gửi nội dung email:

```vbnet
C: DATA
S: 354 Start mail input; end with <CRLF>.<CRLF>
C: Subject: Greetings

C: Hi Bob, how are you?
C: .
S: 250 OK
```

4. Kết thúc phiên:

```makefile
C: QUIT
S: 221 Bye
```

### 📙Cấu trúc email trong SMTP

**Header (tiêu đề)**: Chứa thông tin về người gửi, người nhận, chủ đề, thời gian gửi, v.v. Ví dụ:

```yaml
From: alice@example.com
To: bob@example.com
Subject: Test email
Date: Fri, 06 Oct 2024 12:00:00 +0000
```

**Body (nội dung)**: Đây là phần chứa nội dung thư, bao gồm cả văn bản và các file đính kèm (nếu có).

### 📙Bảo mật và mở rộng

SMTP nguyên bản không hỗ trợ bảo mật, vì vậy email gửi qua SMTP ban đầu được truyền tải dưới dạng văn bản thuần túy và dễ bị nghe lén (eavesdropping). Tuy nhiên, hiện nay có các biện pháp mở rộng để bảo vệ các kết nối SMTP:

- **SMTPS (SMTP Secure)** là phiên bản mở rộng của SMTP, trong đó các kết nối SMTP được mã hóa bằng **TLS (Transport Layer Security)**. SMTPS đảm bảo rằng email và thông tin xác thực (username, password) không bị đánh cắp khi truyền qua mạng.

- **STARTTLS** là một cơ chế nâng cấp kết nối không mã hóa thành kết nối mã hóa bằng cách khởi tạo quá trình đàm phán mã hóa (TLS) trên một kết nối SMTP thông thường. Đây là phương thức phổ biến để tăng cường bảo mật cho các phiên SMTP hiện tại.

Để cải thiện hiệu suất và khả năng của SMTP, nhiều phần mở rộng đã được thêm vào giao thức qua các năm, bao gồm:

- **SMTP-AUTH**: Cho phép xác thực người dùng trước khi gửi email, giúp ngăn chặn spam và các email giả mạo.

- **ESMTP (Extended SMTP)**: Một phiên bản mở rộng của SMTP, được định nghĩa trong RFC 1869, bổ sung thêm các tính năng mới như hỗ trợ các tập tin lớn, xác thực người dùng, và cung cấp trạng thái chi tiết hơn cho email.

### 📙Ưu điểm và nhược điểm của SMTP

Ưu điểm:
- Đơn giản và hiệu quả: SMTP là giao thức đơn giản và dễ thực hiện, giúp truyền tải email một cách nhanh chóng.
- Khả năng tương thích cao: SMTP là giao thức tiêu chuẩn được hỗ trợ bởi hầu hết các dịch vụ email.

Nhược điểm:
- Thiếu bảo mật: SMTP nguyên bản không hỗ trợ mã hóa, làm cho email dễ bị nghe lén nếu không được bổ sung thêm các biện pháp bảo mật như TLS.
- Dễ bị spam: SMTP không có cơ chế mặc định để ngăn chặn spam, nên cần các phần mở rộng như SMTP-AUTH để hỗ trợ.

## 📚Giao thức POP3 (Post Office Protocol - Version 3)

**POP3 (Post Office Protocol - Version 3)** là một giao thức tiêu chuẩn được sử dụng để lấy email từ một máy chủ email về máy khách. POP3 là một giao thức đơn giản và phổ biến trong việc xử lý email, đặc biệt là trong các ứng dụng email offline, nơi người dùng tải email về máy tính của mình và quản lý chúng cục bộ. Sau đó email có thể bị xóa khỏi máy chủ (mặc định) hoặc giữ lại tùy theo thiết lập.

Port mặc định:
- **Port 110** cho kết nối không mã hóa
- **Port 995** cho kết nối an toàn thông qua POP3S (POP3 Secure) sử dụng TLS/SSL.

### 📙Cách thức hoạt động
**Thiết lập kết nối**: Khi người dùng mở ứng dụng email và kiểm tra email, máy khách (client) sẽ thiết lập kết nối với máy chủ POP3 (mail server) qua TCP.

**Xác thực người dùng**: Máy khách gửi tên người dùng và mật khẩu để xác thực (thông qua lệnh USER và PASS).

**Truy vấn và tải email**: Sau khi xác thực thành công, máy khách sẽ dùng các lệnh POP3 để liệt kê và tải các email về. Email được tải về sẽ được lưu trên máy tính hoặc thiết bị cục bộ của người dùng.

**Xóa email (tùy chọn)**: Sau khi tải về, mặc định POP3 sẽ xóa email khỏi máy chủ. Tuy nhiên, người dùng có thể cấu hình để giữ lại bản sao trên máy chủ.

**Kết thúc kết nối**: Sau khi các lệnh được thực hiện, kết nối giữa máy khách và máy chủ sẽ bị đóng lại.

### 📙Các lệnh POP3

- **USER**: Gửi tên người dùng để xác thực.
- **PASS**: Gửi mật khẩu người dùng để xác thực.
- **STAT**: Kiểm tra trạng thái hộp thư, bao gồm số lượng email và tổng dung lượng.
- **LIST**: Liệt kê các email trong hộp thư, kèm theo kích thước của chúng.
- **RETR**: Tải một email cụ thể từ máy chủ.
- **DELE**: Đánh dấu một email để xóa khỏi máy chủ sau khi phiên làm việc kết thúc.
- **QUIT**: Kết thúc phiên làm việc và xóa các email đã được đánh dấu để xóa.

### 📙Ưu điểm và nhược điểm của POP3

Ưu điểm
- Hoạt động ngoại tuyến: POP3 cho phép người dùng tải email về máy tính và sau đó có thể quản lý email ngoại tuyến, không cần kết nối liên tục với máy chủ.

- Đơn giản và phổ biến: POP3 là giao thức rất đơn giản và đã được triển khai rộng rãi, hỗ trợ trên nhiều ứng dụng email như Outlook, Thunderbird, Apple Mail, v.v.

- Tiết kiệm dung lượng trên máy chủ: POP3 giúp giảm tải cho máy chủ bằng cách xóa email sau khi tải về, tránh việc tốn tài nguyên trên máy chủ email.

Nhược điểm
- Không đồng bộ đa thiết bị: Vì email thường bị xóa khỏi máy chủ sau khi tải về, các email đã tải xuống không thể được truy cập từ nhiều thiết bị khác nhau. Điều này khiến POP3 không phù hợp cho người dùng sử dụng nhiều thiết bị (như máy tính, điện thoại, tablet) để quản lý email.

- Không quản lý thư mục: POP3 không hỗ trợ việc quản lý thư mục trên máy chủ. Điều này có nghĩa là nếu người dùng tổ chức email theo thư mục trên máy khách, cấu trúc đó không được phản ánh trên máy chủ.

- Bảo mật yếu (nếu không dùng SSL/TLS): POP3 gửi tên người dùng và mật khẩu dưới dạng văn bản không mã hóa trừ khi sử dụng phiên bản bảo mật POP3S qua SSL hoặc TLS.

## 📚Giao thức IMAP (Internet Message Access Protocol)

**IMAP (Internet Message Access Protocol)** là một giao thức tầng ứng dụng được sử dụng để truy cập và quản lý email trên một máy chủ từ một ứng dụng email hoặc trình duyệt web. Không giống như POP3, IMAP cho phép quản lý email trực tiếp trên máy chủ mà không cần tải chúng xuống máy khách, giúp duy trì sự đồng bộ giữa nhiều thiết bị.

Port mặc định:
- **Port 143** cho kết nối không mã hóa
- **Port 993** cho kết nối bảo mật thông qua IMAPS (IMAP Secure) sử dụng SSL/TLS.

**IMAPS (IMAP Secure)**: Để đảm bảo tính bảo mật, IMAP có thể được sử dụng với SSL/TLS để mã hóa kết nối giữa máy khách và máy chủ. Điều này giúp bảo vệ dữ liệu như tên người dùng, mật khẩu và nội dung email không bị đánh cắp khi truyền qua mạng.

### 📙Cách thức hoạt động

**Thiết lập kết nối**: Khi người dùng mở ứng dụng email, ứng dụng sẽ thiết lập kết nối với máy chủ IMAP qua TCP.

**Xác thực người dùng**: Máy khách gửi tên người dùng và mật khẩu đến máy chủ để xác thực (thường thông qua các lệnh như LOGIN).

**Quản lý email trên máy chủ**: Sau khi xác thực thành công, máy khách có thể truy cập hộp thư (inbox) và các thư mục khác (như Sent, Drafts) trực tiếp trên máy chủ. Các email không cần phải tải xuống cục bộ nếu người dùng chỉ xem nội dung.

**Đồng bộ hóa**: Khi người dùng xóa, di chuyển, hoặc gắn thẻ email, các thay đổi này sẽ được đồng bộ hóa trên máy chủ. Điều này đảm bảo rằng mọi thay đổi đều hiển thị trên tất cả các thiết bị khác khi người dùng truy cập email.

**Ngắt kết nối**: Sau khi thực hiện các thao tác, máy khách sẽ ngắt kết nối với máy chủ, nhưng email vẫn được lưu trữ trên máy chủ để truy cập từ các thiết bị khác.

### 📙Các lệnh IMAP

- **LOGIN**: Xác thực người dùng với tên đăng nhập và mật khẩu.
- **LIST**: Liệt kê các thư mục (như Inbox, Sent, Trash) có trên máy chủ.
- **SELECT**: Chọn một hộp thư để thực hiện các thao tác như đọc hoặc xóa email.
- **FETCH**: Lấy nội dung email hoặc một phần của email (chẳng hạn như tiêu đề hoặc nội dung).
- **STORE**: Cập nhật các thuộc tính của một email, như đánh dấu đã đọc hoặc chưa đọc.
- **DELETE**: Đánh dấu email để xóa.
- **EXPUNGE**: Xóa vĩnh viễn các email đã được đánh dấu để xóa.

### 📙Ưu điểm và nhược điểm của POP3
Ưu điểm
- Đồng bộ hóa đa thiết bị: IMAP giữ email trên máy chủ, giúp dễ dàng đồng bộ hóa email trên nhiều thiết bị (như máy tính, điện thoại di động, và máy tính bảng). Mọi thay đổi được thực hiện trên một thiết bị sẽ được phản ánh trên các thiết bị khác.

- Quản lý trực tiếp trên máy chủ: Người dùng có thể quản lý email và thư mục ngay trên máy chủ mà không cần tải chúng về cục bộ. Điều này giúp tiết kiệm dung lượng lưu trữ cục bộ và dễ dàng truy cập từ mọi nơi.

- Truy cập có chọn lọc: IMAP cho phép người dùng chỉ tải xuống những phần của email mà họ cần, như tiêu đề hoặc một phần nội dung, thay vì phải tải toàn bộ email.

- Phân loại và thư mục: IMAP hỗ trợ quản lý email theo thư mục và gắn nhãn, giúp người dùng dễ dàng tổ chức hộp thư của mình.

Nhược điểm
- Yêu cầu kết nối Internet liên tục: Vì IMAP giữ email trên máy chủ, người dùng cần có kết nối Internet để truy cập và quản lý email. Tuy nhiên, nhiều ứng dụng email hiện đại hỗ trợ chế độ offline với IMAP, cho phép người dùng làm việc ngoại tuyến và đồng bộ hóa sau.

- Sử dụng nhiều tài nguyên máy chủ: IMAP giữ toàn bộ email trên máy chủ, điều này có thể dẫn đến tình trạng đầy hộp thư nếu người dùng không quản lý tốt hoặc nếu máy chủ email có giới hạn về dung lượng lưu trữ.

- Tốc độ phụ thuộc vào mạng: Do cần tương tác thường xuyên với máy chủ, hiệu suất làm việc với email có thể bị ảnh hưởng bởi tốc độ kết nối mạng.

## 📚Giao thức truyền phát video và âm thanh

## 📚DNS (Domain Name System)

**DNS (Domain Name System)** là một hệ thống quan trọng trong mạng máy tính, đặc biệt là Internet, cho phép ánh xạ các tên miền (domain name) dễ nhớ thành các địa chỉ IP mà máy tính sử dụng để định tuyến và giao tiếp với nhau. Không có DNS, người dùng sẽ phải nhớ địa chỉ IP của từng trang web thay vì tên miền như example.com.

**DoH (DNS over HTTPS)** và **DoT (DNS over TLS)**: Các giao thức này mã hóa truy vấn DNS để bảo mật quyền riêng tư của người dùng và ngăn chặn việc theo dõi, điều chỉnh truy vấn DNS bởi các bên thứ ba (như ISP).

**CDN và DNS**: DNS thường được tích hợp với **Content Delivery Networks (CDN)** để điều phối lưu lượng truy cập đến các máy chủ gần nhất với người dùng, giúp giảm độ trễ và tăng tốc độ tải trang.

### 📙Cấu trúc phân cấp của DNS
**Root DNS Servers**: Đây là lớp trên cùng của hệ thống DNS, xử lý các yêu cầu từ các máy chủ DNS địa phương và chỉ dẫn đến các máy chủ TLD.

**Top-Level Domain (TLD) Servers**: Quản lý tên miền cấp cao nhất, như .com, .org, .net, .vn.

**Authoritative DNS Servers**: Chứa các bản ghi DNS thực tế cho các tên miền cụ thể và có thể trả về địa chỉ IP của máy chủ đích.

### 📙Cách thức hoạt động

**Gửi yêu cầu phân giải**: Khi người dùng nhập một tên miền vào trình duyệt (ví dụ: www.example.com), trình duyệt sẽ gửi một yêu cầu phân giải tên miền đến máy chủ DNS cục bộ (của ISP hoặc máy chủ DNS đã được thiết lập).

**Cache DNS**: Trước tiên, máy chủ DNS sẽ kiểm tra bộ nhớ đệm (cache) của nó để xem liệu tên miền đã được phân giải gần đây hay chưa. Nếu có, nó sẽ trả về địa chỉ IP mà không cần tiếp tục yêu cầu.

**Recursive DNS query**: Nếu máy chủ DNS không có câu trả lời, nó sẽ gửi yêu cầu tiếp tục tới các máy chủ DNS khác theo mô hình phân cấp. Quá trình này có thể bao gồm các bước:

- **Root server**: Máy chủ DNS sẽ gửi yêu cầu đến một trong các máy chủ DNS gốc. Máy chủ gốc không biết địa chỉ IP cuối cùng nhưng có thể hướng dẫn đến các máy chủ TLD (Top-Level Domain), chẳng hạn như máy chủ .com, .org, .net.

- **TLD server**: Máy chủ TLD sẽ hướng dẫn máy chủ DNS đến các authoritative name servers (máy chủ có thẩm quyền), nơi lưu trữ thông tin địa chỉ IP chính xác cho tên miền đó.

**Authoritative DNS server**: Máy chủ DNS có thẩm quyền cung cấp địa chỉ IP tương ứng với tên miền được yêu cầu.

**Trả kết quả**: Sau khi nhận được kết quả từ máy chủ DNS có thẩm quyền, máy chủ DNS cục bộ sẽ trả về địa chỉ IP cho trình duyệt, và địa chỉ này sẽ được sử dụng để kết nối đến máy chủ đích.

### 📙Các loại bản ghi DNS (DNS Records)

- **A Record**: Ánh xạ tên miền với địa chỉ IPv4.

- **AAAA Record**: Ánh xạ tên miền với địa chỉ IPv6.

- **MX Record**: Chỉ định máy chủ thư điện tử (mail server) cho tên miền.

- **NS Record**: Chỉ ra máy chủ DNS có thẩm quyền cho tên miền.

- **CNAME Record**: Chuyển hướng một tên miền sang một tên miền khác.

- **TXT Record**: Lưu trữ thông tin văn bản liên quan đến tên miền, thường được sử dụng cho các mục đích xác minh.

### 📙DNS Caching

**DNS caching** giúp tăng tốc quá trình phân giải tên miền bằng cách lưu trữ các kết quả phân giải trước đó trong bộ nhớ đệm của máy khách hoặc máy chủ DNS. Khi người dùng truy cập một trang web, nếu tên miền đó đã được phân giải trước đó, máy sẽ sử dụng thông tin từ cache thay vì gửi lại yêu cầu phân giải, giúp tiết kiệm thời gian và tài nguyên mạng.

## 📚Socket Programming

**Socket**: Là một giao diện lập trình mạng, điểm kết nối giữa hai thiết bị trên mạng. Mỗi socket có một địa chỉ IP và một cổng (port) để giao tiếp với các socket khác trên cùng một mạng.

**Socket Programming (lập trình socket)** là một kỹ thuật lập trình mạng cho phép các ứng dụng giao tiếp với nhau thông qua mạng máy tính. Sockets là điểm cuối trong quá trình giao tiếp giữa hai thiết bị. Lập trình socket thường được sử dụng để phát triển các ứng dụng mạng như máy chủ (server) và máy khách (client), truyền tải dữ liệu qua giao thức TCP hoặc UDP.

### 📙Phân loại

TCP Socket:
- Sử dụng giao thức TCP (Transmission Control Protocol), là một giao thức hướng kết nối (connection-oriented).

- Đảm bảo dữ liệu được truyền chính xác và theo đúng thứ tự.

- Dữ liệu được gửi đi dưới dạng dòng (stream) và yêu cầu thiết lập kết nối giữa hai thiết bị trước khi truyền dữ liệu.

UDP Socket:
- Sử dụng giao thức UDP (User Datagram Protocol), là một giao thức không hướng kết nối (connectionless).

- Không đảm bảo tính toàn vẹn của dữ liệu hoặc thứ tự gói tin.

- Dữ liệu được gửi đi dưới dạng các gói độc lập (datagram), thích hợp cho các ứng dụng yêu cầu tốc độ nhanh và không cần thiết phải đảm bảo tất cả các gói tin đều được nhận (ví dụ: truyền video, trò chơi trực tuyến).

### 📙Quy trình lập trình Socket

#### 📘TCP

**Server Side (máy chủ)**:
- Tạo socket: Sử dụng hàm hệ thống để tạo socket.

- Gắn (bind) socket với địa chỉ và cổng: Máy chủ phải gắn socket với một địa chỉ IP và cổng cụ thể để nhận các yêu cầu từ client.

- Lắng nghe (listen): Máy chủ chuyển sang chế độ chờ, lắng nghe các yêu cầu từ client.

- Chấp nhận kết nối (accept): Khi một client gửi yêu cầu kết nối, máy chủ chấp nhận kết nối đó.

- Trao đổi dữ liệu: Sau khi kết nối được thiết lập, máy chủ và client có thể trao đổi dữ liệu thông qua socket.

- Đóng socket: Sau khi hoàn tất trao đổi dữ liệu, máy chủ đóng socket.

```python
import socket

# Tạo socket (IPv4, TCP)
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Gắn socket với địa chỉ IP và cổng
server_socket.bind(('localhost', 8080))

# Lắng nghe kết nối từ client
server_socket.listen(1)
print("Đang lắng nghe...")

# Chấp nhận kết nối
client_socket, client_address = server_socket.accept()
print(f"Client {client_address} đã kết nối")

# Trao đổi dữ liệu
message = client_socket.recv(1024).decode()
print(f"Nhận được từ client: {message}")

# Gửi phản hồi
response = "Xin chào từ máy chủ!"
client_socket.send(response.encode())

# Đóng kết nối
client_socket.close()
server_socket.close()
```

**Client Side (máy khách)**:
- Tạo socket: Tạo socket trên máy khách.

- Kết nối đến máy chủ: Máy khách sử dụng địa chỉ IP và cổng của máy chủ để kết nối.

- Trao đổi dữ liệu: Sau khi kết nối được thiết lập, máy khách có thể gửi và nhận dữ liệu từ máy chủ.

- Đóng socket: Sau khi hoàn tất trao đổi, máy khách đóng socket.

```python
import socket

# Tạo socket (IPv4, TCP)
client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Kết nối đến máy chủ (localhost) và cổng 8080
client_socket.connect(('localhost', 8080))

# Gửi dữ liệu
message = "Xin chào từ client!"
client_socket.send(message.encode())

# Nhận phản hồi từ server
response = client_socket.recv(1024).decode()
print(f"Nhận được từ máy chủ: {response}")

# Đóng kết nối
client_socket.close()
```

#### 📘UDP

Do UDP không yêu cầu kết nối, quy trình sẽ đơn giản hơn TCP, không cần "lắng nghe" và "chấp nhận" kết nối.

**Server Side (máy chủ)**:
```python
import socket

# Tạo socket (IPv4, UDP)
server_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

# Gắn socket với địa chỉ IP và cổng
server_socket.bind(('localhost', 8080))

# Nhận dữ liệu từ client
message, client_address = server_socket.recvfrom(1024)
print(f"Nhận được từ client: {message.decode()}")

# Gửi phản hồi
response = "Xin chào từ máy chủ!"
server_socket.sendto(response.encode(), client_address)

# Đóng socket
server_socket.close()
```

**Client Side (máy khách)**:
```python
import socket

# Tạo socket (IPv4, UDP)
client_socket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

# Gửi dữ liệu đến server
message = "Xin chào từ client!"
client_socket.sendto(message.encode(), ('localhost', 8080))

# Nhận phản hồi từ server
response, server_address = client_socket.recvfrom(1024)
print(f"Nhận được từ máy chủ: {response.decode()}")

# Đóng socket
client_socket.close()
```

### 📙Ứng dụng của Socket Programming

Giao tiếp giữa các thiết bị qua mạng: Ví dụ, một máy chủ trò chơi trực tuyến cần trao đổi dữ liệu với nhiều người chơi.

Xây dựng các ứng dụng như web server, FTP server, email client: Các giao thức như HTTP, FTP, SMTP đều dựa trên lập trình socket.

Truyền phát video, âm thanh trực tuyến: Các ứng dụng streaming như Netflix, YouTube sử dụng lập trình socket qua giao thức UDP để truyền video tới người dùng.

## 📚Tầng vận chuyển (Transport Layer)

**Tầng vận chuyển (Transport Layer)** chịu trách nhiệm cung cấp truyền tải dữ liệu giữa các ứng dụng trên hai hệ thống mạng khác nhau. Tầng này thực hiện việc phân chia dữ liệu thành các gói nhỏ, kiểm soát việc gửi nhận, đảm bảo dữ liệu được truyền đi một cách đáng tin cậy và đúng thứ tự.

### 📙Chức năng chính
**Phân đoạn và tái hợp dữ liệu**: Tầng vận chuyển chia dữ liệu thành các phân đoạn nhỏ trước khi truyền đi (gọi là **segments** trong TCP và **datagrams** trong UDP). Sau đó, nó tái hợp lại dữ liệu khi nhận về từ tầng dưới.

**Kiểm soát luồng (Flow Control)**: Tầng vận chuyển điều chỉnh tốc độ truyền dữ liệu giữa máy gửi và máy nhận, tránh tình trạng quá tải.

**Kiểm soát lỗi (Error Control)**: Nó kiểm tra và đảm bảo dữ liệu được truyền đi không bị lỗi, và yêu cầu truyền lại nếu xảy ra lỗi.

**Quản lý kết nối (Connection Management)**: Trong giao thức hướng kết nối như TCP, tầng vận chuyển thiết lập, duy trì và kết thúc kết nối giữa hai thiết bị.

**Đa luồng (Multiplexing/Demultiplexing)**: Cho phép nhiều ứng dụng trên cùng một máy tính có thể sử dụng cùng một kết nối mạng bằng cách phân biệt các ứng dụng qua cổng (port).

### 📙Quá trình truyền tải dữ liệu trong tầng vận chuyển
Máy gửi:
- Dữ liệu từ tầng ứng dụng (Application Layer) được phân chia thành các đoạn (segments) hoặc gói (datagrams).

- Tầng vận chuyển thêm vào các thông tin điều khiển (như số thứ tự, cổng nguồn, cổng đích).

- Các đoạn này sau đó được gửi xuống tầng mạng để truyền đi.

Máy nhận:
- Tầng vận chuyển nhận các phân đoạn từ tầng mạng.

- Sau đó, nó kiểm tra các thông tin điều khiển, tái hợp dữ liệu và gửi lên tầng ứng dụng để xử lý.

## 📚Multiplexing và Demultiplexing

### 📙Multiplexing (Ghép kênh)

**Multiplexing** là quá trình kết hợp dữ liệu từ nhiều ứng dụng khác nhau hoặc nhiều nguồn khác nhau trên một máy tính vào một đường truyền chung để gửi qua mạng. Điều này giúp tiết kiệm tài nguyên mạng, vì nhiều ứng dụng có thể sử dụng chung một kết nối mạng duy nhất.

Cách thức hoạt động
- Khi các ứng dụng trên máy tính cần truyền dữ liệu qua mạng, tầng vận chuyển (Transport Layer) sẽ nhận dữ liệu từ các ứng dụng này.

- Tầng vận chuyển sẽ thêm thông tin về cổng (port) vào các gói dữ liệu, tạo thành các phân đoạn (segments) hoặc gói (datagrams) để chuyển xuống tầng mạng.

- Mỗi ứng dụng được xác định bởi một số cổng (port number), giúp tầng vận chuyển biết được ứng dụng nào đã gửi dữ liệu.

### 📙Demultiplexing (Phân kênh)

**Demultiplexing** là quá trình ngược lại của multiplexing. Khi dữ liệu đến đích, tầng vận chuyển sẽ nhận các gói tin từ tầng mạng và phân loại, chuyển chúng đến đúng ứng dụng tương ứng dựa trên thông tin cổng được thêm vào bởi tầng vận chuyển ở phía gửi.

Cách thức hoạt động
- Khi nhận được các phân đoạn dữ liệu từ tầng mạng, tầng vận chuyển sẽ đọc thông tin cổng đích (destination port number) từ mỗi phân đoạn.

- Dựa vào thông tin cổng này, tầng vận chuyển biết được dữ liệu này thuộc về ứng dụng nào và sẽ chuyển dữ liệu đó đến đúng ứng dụng trên hệ thống.

### 📙Số cổng (Port Numbers)

**Số cổng nguồn (Source Port)**: Là số cổng của ứng dụng gửi dữ liệu trên máy nguồn.

**Số cổng đích (Destination Port)**: Là số cổng của ứng dụng nhận dữ liệu trên máy đích.

Các cổng này được chia thành 3 loại:
- **Well-known Ports (Cổng được biết đến)**: Từ 0 đến 1023, được chỉ định cho các dịch vụ hệ thống và ứng dụng mạng phổ biến. Ví dụ:
    - HTTP: Cổng 80
    - HTTPS: Cổng 443
    - FTP: Cổng 21

- **Registered Ports (Cổng đã đăng ký)**: Từ 1024 đến 49151, dành cho các ứng dụng được đăng ký.

- **Dynamic/Private Ports**: Từ 49152 đến 65535, được sử dụng tạm thời cho các kết nối không yêu cầu cổng cố định.

### 📙Tầm quan trọng

- Tận dụng tài nguyên mạng: Multiplexing giúp tiết kiệm băng thông và tài nguyên mạng bằng cách ghép nhiều dòng dữ liệu vào một kết nối.

- Phân phối dữ liệu đúng chỗ: Demultiplexing giúp đảm bảo rằng dữ liệu đến đúng ứng dụng đích, tránh lẫn lộn giữa các ứng dụng đang chạy trên cùng một máy.

- Khả năng mở rộng: Các cơ chế này cho phép nhiều ứng dụng và dịch vụ có thể hoạt động đồng thời trên một thiết bị mà không cần nhiều kết nối vật lý riêng biệt.

## 📚Điều khiển lưu lượng (Flow Control)

**Điều khiển lưu lượng (Flow Control)** là một cơ chế quan trọng trong tầng vận chuyển của các mô hình mạng, như TCP/IP, giúp điều chỉnh tốc độ truyền dữ liệu giữa hai thiết bị (máy gửi và máy nhận) để tránh tình trạng quá tải (overload) tại thiết bị nhận dữ liệu.

### 📙Cơ chế hoạt động

Điều khiển lưu lượng đảm bảo rằng máy gửi không gửi quá nhiều dữ liệu trước khi máy nhận có thể xử lý. Cơ chế này đặc biệt quan trọng trong các giao thức hướng kết nối như TCP.

Có hai cơ chế chính thường được sử dụng để kiểm soát lưu lượng: Sliding Window (Cửa sổ trượt), Stop-and-Wait Protocol

### 📙Stop-and-Wait Protocol

**Stop-and-Wait** là một giao thức điều khiển truyền tải đơn giản nhất, trong đó máy gửi sẽ truyền một gói tin (packet), sau đó dừng lại và chờ nhận **tín hiệu xác nhận (ACK)** từ máy nhận trước khi gửi gói tin tiếp theo.

Cách thức hoạt động:

- Máy gửi gửi một gói dữ liệu đến máy nhận.

- Sau khi gửi gói tin, máy gửi dừng lại và chờ tín hiệu xác nhận (ACK) từ máy nhận.

- Khi nhận được ACK, máy gửi tiếp tục gửi gói dữ liệu tiếp theo.

- Nếu không nhận được ACK trong một khoảng thời gian nhất định, máy gửi sẽ giả định rằng gói tin bị mất và sẽ gửi lại gói tin đó.

Ưu điểm:

- Đơn giản: Dễ triển khai và không đòi hỏi nhiều bộ nhớ.

- Đảm bảo tính toàn vẹn dữ liệu: Từng gói tin được xác nhận trước khi gửi gói tiếp theo, giảm nguy cơ mất mát dữ liệu.

Nhược điểm:

- Hiệu suất thấp: Máy gửi phải chờ ACK cho mỗi gói tin trước khi gửi tiếp. Điều này dẫn đến việc tốn thời gian chờ, đặc biệt khi độ trễ mạng cao.

- Lãng phí băng thông: Không tận dụng tối đa khả năng truyền tải của đường truyền, vì thời gian chờ giữa các gói tin là quá dài.

### 📙Sliding Window (Cửa sổ trượt)

**Sliding Window** là một cơ chế tiên tiến hơn Stop-and-Wait. Trong Sliding Window, máy gửi có thể gửi nhiều gói dữ liệu trước khi cần nhận **tín hiệu xác nhận (ACK)** từ máy nhận. Số lượng gói tin có thể gửi mà không chờ ACK được quy định bởi kích thước cửa sổ.

- **Cửa sổ truyền (Send Window)**: Lượng dữ liệu mà máy gửi có thể truyền mà không cần chờ xác nhận từ máy nhận.

- **Cửa sổ nhận (Receive Window)**: Lượng dữ liệu mà máy nhận có thể tiếp nhận trong bộ đệm mà không bị quá tải.

Cách thức hoạt động:

- Cửa sổ là khoảng thời gian hoặc số lượng gói tin mà máy gửi có thể gửi mà không cần phải chờ ACK.

- Khi máy gửi bắt đầu truyền, nó sẽ gửi một số gói tin (tối đa bằng kích thước cửa sổ).

- Trong khi máy gửi tiếp tục gửi các gói tin tiếp theo, nó cũng nhận các ACK từ máy nhận cho các gói đã được gửi trước đó.

- Khi máy gửi nhận được ACK cho một gói tin, cửa sổ sẽ "trượt" đi, cho phép máy gửi tiếp tục gửi các gói tin mới.

- Nếu một gói tin không được xác nhận (ACK) sau một khoảng thời gian, gói tin đó sẽ được gửi lại.

Ưu điểm:

- Hiệu suất cao hơn: Máy gửi không cần phải chờ ACK sau mỗi gói tin, giúp giảm thời gian chờ và tăng tốc độ truyền dữ liệu.

- Sử dụng tối đa băng thông: Sliding Window tận dụng băng thông tốt hơn, vì máy gửi có thể truyền nhiều gói tin liên tiếp mà không phải chờ ACK cho mỗi gói.

- Điều chỉnh linh hoạt: Cửa sổ có thể thay đổi kích thước dựa trên khả năng của máy nhận hoặc điều kiện mạng, giúp tối ưu hóa truyền thông.

Nhược điểm:

- Phức tạp hơn Stop-and-Wait: Cần phải theo dõi nhiều gói tin cùng một lúc và quản lý nhiều ACK, làm cho việc triển khai và quản lý phức tạp hơn.

- Tăng khả năng lỗi nếu không đồng bộ: Nếu một trong các gói tin bị mất, máy gửi cần phải truyền lại các gói tin chưa nhận được ACK, có thể gây ra tình trạng truyền lại không cần thiết.

### 📙So sánh giữa Stop-and-Wait và Sliding Window
| Tiêu chí                | Stop-and-Wait                                | Sliding Window                                    |
| ----------------------- | -------------------------------------------- | ------------------------------------------------- |
| Tốc độ truyền           | Chậm, vì phải chờ ACK cho từng gói tin       | Nhanh hơn, vì có thể gửi nhiều gói tin cùng lúc   |
| Hiệu suất băng thông    | Sử dụng băng thông thấp do thời gian chờ ACK | Sử dụng băng thông tốt hơn                        |
| Độ phức tạp             | Đơn giản, dễ triển khai                      | Phức tạp hơn, cần theo dõi nhiều gói tin          |
| Khả năng truyền dữ liệu | Từng gói một, mỗi gói tin chờ ACK            | Truyền nhiều gói tin mà không chờ ACK             |
| Tính ứng dụng           | Ít sử dụng trong các mạng hiện đại           | Được sử dụng rộng rãi trong các giao thức như TCP |

### 📙Tầm quan trọng của Flow Control

Tránh mất mát dữ liệu: Giảm nguy cơ quá tải tại máy nhận, giúp hạn chế việc mất mát dữ liệu do không đủ bộ nhớ đệm.

Tối ưu hóa băng thông: Bằng cách điều chỉnh lưu lượng truyền tải, flow control giúp tối ưu hóa việc sử dụng băng thông, đảm bảo dữ liệu được truyền nhanh và hiệu quả.

Tăng hiệu suất: Đảm bảo tốc độ truyền phù hợp với khả năng xử lý của máy nhận, từ đó tăng hiệu suất truyền thông.

## 📚Điều khiển tắc nghẽn (Congestion Control)

**Điều khiển tắc nghẽn (Congestion Control)** là một cơ chế quan trọng trong việc quản lý lưu lượng mạng nhằm tránh hiện tượng **tắc nghẽn (congestion)** khi có quá nhiều dữ liệu lưu thông trong mạng, vượt quá khả năng xử lý của các thiết bị hoặc các liên kết mạng. Nếu không có điều khiển tắc nghẽn, tình trạng tắc nghẽn có thể dẫn đến việc mất gói tin, truyền lại dữ liệu không cần thiết, làm giảm hiệu suất và độ tin cậy của mạng.

### 📙Nguyên nhân gây tắc nghẽn

Quá nhiều thiết bị truyền dữ liệu đồng thời: Khi nhiều thiết bị trong mạng cùng gửi dữ liệu đến một nút mạng, nếu tốc độ truyền dữ liệu vượt quá khả năng xử lý của nút, sẽ xảy ra tắc nghẽn.

Băng thông hạn chế: Băng thông của liên kết giữa các nút mạng không đủ để truyền lượng dữ liệu lớn, gây ra hàng đợi và mất gói tin.

Bộ đệm (Buffer) đầy: Các router và switch sử dụng bộ đệm để lưu trữ tạm thời các gói tin, nhưng khi bộ đệm bị đầy, các gói tin sẽ bị loại bỏ hoặc phải chờ, gây ra độ trễ.

### 📙Congestion Control trong TCP

Slow Start (Khởi đầu chậm)

- Khi một kết nối TCP mới bắt đầu, nó không biết rõ dung lượng của mạng và tốc độ truyền tải tối ưu. Do đó, TCP bắt đầu truyền dữ liệu ở mức rất thấp.

- Kích thước cửa sổ cwnd (Congestion Window) sẽ tăng dần theo thời gian. Cứ sau mỗi lần nhận được ACK, kích thước cửa sổ sẽ tăng gấp đôi. Quá trình này tiếp tục cho đến khi xảy ra mất gói tin hoặc đạt tới một ngưỡng nhất định.

- Mục tiêu của Slow Start là để tránh tình trạng tắc nghẽn từ ban đầu, khi máy gửi chưa biết khả năng của mạng.

Congestion Avoidance (Tránh tắc nghẽn)

- Khi kích thước cửa sổ đạt tới một mức ngưỡng nhất định (threshold), thay vì tiếp tục tăng gấp đôi, TCP sẽ chỉ tăng kích thước cửa sổ một cách tuyến tính. Điều này giúp giảm tốc độ tăng trưởng của lượng dữ liệu được gửi đi, tránh gây tắc nghẽn.

- Khi tắc nghẽn xảy ra, TCP sẽ giảm kích thước cửa sổ để phù hợp với dung lượng thực tế của mạng.

Fast Retransmit (Truyền lại nhanh)

- Nếu máy nhận phát hiện rằng một gói tin đã bị mất (ví dụ không nhận được ACK sau một khoảng thời gian), nó sẽ gửi ngay một yêu cầu truyền lại (Duplicate ACK).

- Thay vì chờ đợi một khoảng thời gian dài để phát hiện mất gói tin (Timeout), Fast Retransmit cho phép truyền lại ngay lập tức khi phát hiện tắc nghẽn.

Fast Recovery (Phục hồi nhanh)

- Sau khi máy gửi nhận được một tín hiệu mất gói tin (Duplicate ACK), thay vì giảm cửa sổ quá mạnh, TCP chỉ giảm một nửa kích thước cửa sổ và tiếp tục truyền dữ liệu.

- Điều này giúp phục hồi nhanh hơn sau tắc nghẽn mà không phải khởi động lại từ đầu (như trong Slow Start).

### 📙RED (Random Early Detection)

**RED** là một kỹ thuật điều khiển tắc nghẽn được sử dụng tại các nút mạng (như router) để phát hiện và xử lý tắc nghẽn sớm trước khi bộ đệm đầy.

- Khi bộ đệm của router bắt đầu đầy, RED sẽ ngẫu nhiên loại bỏ (drop) một số gói tin trước khi tắc nghẽn xảy ra.

- Khi phát hiện có nguy cơ tắc nghẽn, router sẽ gửi tín hiệu cho các thiết bị gửi dữ liệu để yêu cầu chúng giảm tốc độ truyền.

- RED ngăn chặn tình trạng tắc nghẽn xảy ra một cách đột ngột bằng cách giảm tốc độ truyền dữ liệu dần dần.

### 📙Congestion Window (Cwnd) và Receive Window (Rwnd)

Sự kết hợp giữa **Cwnd** và **Rwnd** giúp điều chỉnh lưu lượng dữ liệu, đảm bảo máy gửi và nhận không quá tải mạng hoặc bộ đệm.

- **Cwnd**: Đây là cửa sổ tắc nghẽn, do máy gửi quản lý. Nó xác định số lượng dữ liệu mà máy gửi có thể gửi đi mà không phải chờ xác nhận (ACK) từ máy nhận. Cwnd thay đổi tùy thuộc vào mức độ tắc nghẽn trong mạng.

- **Rwnd**: Cửa sổ nhận, do máy nhận quản lý. Nó thông báo cho máy gửi biết dung lượng bộ đệm hiện tại của nó, để đảm bảo máy gửi không truyền quá nhiều dữ liệu cùng lúc.

### 📙Các giai đoạn của điều khiển tắc nghẽn trong TCP

**Điều khiển tắc nghẽn (Congestion Control)** là một phần quan trọng của các giao thức mạng, đặc biệt là **TCP**, giúp đảm bảo rằng dữ liệu được truyền một cách hiệu quả mà không gây quá tải cho mạng.

- Slow Start: Bắt đầu truyền tải với tốc độ chậm, tăng tốc dần dần.

- Congestion Avoidance: Khi đạt đến một mức ngưỡng, tốc độ truyền tải được tăng một cách tuyến tính để tránh tắc nghẽn.

- Fast Retransmit: Truyền lại nhanh khi phát hiện mất gói tin mà không cần chờ hết thời gian timeout.

- Fast Recovery: Giảm nhẹ tốc độ truyền tải sau khi phát hiện tắc nghẽn, nhưng không giảm quá mạnh như trong Slow Start.

## 📚Truyền dữ liệu đáng tin cậy

Trong các mạng truyền thông, dữ liệu có thể bị lỗi hoặc mất mát do nhiều nguyên nhân, chẳng hạn như nhiễu trong mạng không dây, độ trễ, hay quá tải tại các nút mạng. Để đảm bảo tính toàn vẹn của dữ liệu, các hệ thống mạng sử dụng các cơ chế để phát hiện lỗi, truyền lại dữ liệu bị mất, và xác nhận dữ liệu đã nhận thành công.

Các yếu tố chính của truyền dữ liệu đáng tin cậy:

- **Xác nhận (Acknowledgment - ACK)**: Máy nhận gửi tín hiệu xác nhận rằng dữ liệu đã được nhận chính xác.

- **Kiểm tra lỗi (Error Detection)**: Sử dụng các phương pháp như **checksum** hoặc **CRC (Cyclic Redundancy Check)** để phát hiện các lỗi xảy ra trong quá trình truyền.

- **Truyền lại (Retransmission)**: Nếu dữ liệu bị mất hoặc có lỗi, máy gửi sẽ truyền lại các gói tin cần thiết.

## 📚Giao thức ARQ (Automatic Repeat Request)

**ARQ (Automatic Repeat Request)** là một loại giao thức kiểm soát lỗi sử dụng cho truyền dữ liệu đáng tin cậy. ARQ kết hợp giữa việc phát hiện lỗi và yêu cầu truyền lại gói tin nếu phát hiện thấy lỗi. Trong giao thức ARQ, nếu máy nhận phát hiện lỗi trong một gói tin hoặc không nhận được gói tin, nó sẽ yêu cầu máy gửi gửi lại gói tin đó.

### 📙Stop-and-Wait ARQ

**Stop-and-Wait ARQ** là phiên bản đơn giản nhất của ARQ. Trong giao thức này, máy gửi sẽ gửi một gói dữ liệu và chờ nhận ACK từ máy nhận trước khi gửi gói tiếp theo.

Cách thức hoạt động:
- Máy gửi gửi một gói dữ liệu.

- Sau khi gửi, máy gửi dừng lại và chờ nhận tín hiệu ACK từ máy nhận.

- Nếu máy gửi nhận được ACK, nó sẽ tiếp tục gửi gói tin tiếp theo.

- Nếu không nhận được ACK sau một khoảng thời gian xác định (timeout), máy gửi sẽ truyền 

- lại gói dữ liệu đó.

Ưu điểm:
- Đơn giản: Giao thức này dễ hiểu và dễ triển khai.

Nhược điểm:
- Hiệu suất thấp: Máy gửi phải chờ ACK sau mỗi gói tin, gây lãng phí thời gian và băng thông.

### 📙Go-Back-N ARQ

**Go-Back-N ARQ** cải tiến hiệu suất của Stop-and-Wait bằng cách cho phép máy gửi truyền nhiều gói tin liên tiếp mà không cần chờ ACK cho mỗi gói tin. Tuy nhiên, nếu một gói tin bị mất hoặc có lỗi, máy gửi sẽ phải truyền lại tất cả các gói tin từ gói tin bị lỗi đó.

Cách thức hoạt động:
- Máy gửi có thể gửi nhiều gói tin liên tiếp, được xác định bởi một giá trị gọi là cửa sổ (window size).

- Máy gửi không cần chờ ACK cho mỗi gói tin, nhưng nếu một gói tin bị mất, máy nhận sẽ bỏ qua các gói tin sau đó.

- Nếu máy nhận phát hiện một gói tin bị mất hoặc có lỗi, nó sẽ yêu cầu máy gửi truyền lại gói tin đó và các gói tin sau nó (Go-Back-N).

Ưu điểm:
- Hiệu suất cao hơn Stop-and-Wait: Cho phép gửi nhiều gói tin liên tiếp, không cần chờ ACK sau mỗi gói.

Nhược điểm:
- Lãng phí tài nguyên: Nếu có lỗi xảy ra ở một gói tin, tất cả các gói tin tiếp theo đều phải truyền lại, ngay cả khi các gói đó đã được gửi đúng.

### 📙Selective Repeat ARQ

**Selective Repeat ARQ** là phiên bản nâng cao của Go-Back-N ARQ, giúp tối ưu hơn bằng cách chỉ truyền lại những gói tin bị mất hoặc có lỗi, thay vì truyền lại tất cả các gói sau gói lỗi.

Cách thức hoạt động:
- Máy gửi truyền nhiều gói tin liên tiếp.

- Máy nhận sẽ chỉ yêu cầu truyền lại các gói tin bị mất hoặc có lỗi.

- Máy gửi sẽ truyền lại những gói tin cụ thể bị yêu cầu, không phải toàn bộ chuỗi gói tin.

Ưu điểm:
- Hiệu suất tối ưu: Chỉ những gói tin bị lỗi hoặc mất mới cần truyền lại, giảm lãng phí tài nguyên.

- Tốc độ nhanh hơn Go-Back-N: Không cần truyền lại tất cả các gói sau gói bị mất, giúp tối ưu băng thông.

Nhược điểm:
- Phức tạp hơn: Cần quản lý và theo dõi nhiều gói tin khác nhau cùng một lúc.

### 📙So sánh các giao thức ARQ
| Giao thức            | Cách hoạt động                                                | Ưu điểm                          | Nhược điểm                           |
| -------------------- | ------------------------------------------------------------- | -------------------------------- | ------------------------------------ |
| Stop-and-Wait ARQ    | Gửi một gói, chờ ACK, rồi gửi tiếp                            | Đơn giản                         | Hiệu suất thấp                       |
| Go-Back-N ARQ        | Gửi nhiều gói liên tiếp, nếu lỗi thì truyền lại từ gói bị lỗi | Hiệu suất cao hơn Stop-and-Wait  | Truyền lại nhiều gói không cần thiết |
| Selective Repeat ARQ | Chỉ truyền lại gói tin bị mất hoặc lỗi                        | Tối ưu băng thông, hiệu suất cao | Phức tạp hơn trong việc quản lý      |

## 📚Giao thức UDP (User Datagram Protocol)

**UDP** là một giao thức **không kết nối** và **không đảm bảo** (unreliable), nghĩa là nó không cung cấp cơ chế xác nhận, điều khiển lưu lượng, hay truyền lại dữ liệu nếu xảy ra mất gói. Do đó, UDP thường được sử dụng cho các ứng dụng yêu cầu tốc độ truyền tải nhanh hơn là độ tin cậy.

### 📙Đặc điểm

Không kết nối (Connectionless):
- UDP không thiết lập kết nối giữa hai máy trước khi truyền dữ liệu, mỗi gói tin (datagram) được gửi độc lập.

- Điều này có nghĩa là các gói tin có thể đến đích theo thứ tự bất kỳ hoặc thậm chí không đến được đích mà không có cơ chế nào để phát hiện hoặc khắc phục điều đó.

Không đảm bảo tính toàn vẹn dữ liệu (Unreliable):
- UDP không cung cấp bất kỳ sự đảm bảo nào rằng dữ liệu sẽ được nhận chính xác. Không có cơ chế xác nhận (ACK), kiểm soát lỗi hay truyền lại gói tin bị mất.

- Nếu một gói tin bị mất hoặc bị lỗi trong quá trình truyền, nó sẽ không được truyền lại.

Không phân đoạn và tái lắp ráp (No Segmentation and Reassembly):
- UDP không phân đoạn các gói tin lớn thành các mảnh nhỏ. Nếu dữ liệu quá lớn để phù hợp với một gói tin, nó sẽ được xử lý bởi tầng dưới hoặc bị loại bỏ.

Tốc độ cao, độ trễ thấp:
- Vì không có cơ chế kiểm tra và xác nhận gói tin, UDP nhanh hơn TCP. Độ trễ của UDP thường rất thấp, làm cho nó phù hợp với các ứng dụng thời gian thực như truyền phát video, âm thanh, và các ứng dụng game trực tuyến.

### 📙Cấu trúc của gói UDP

Mỗi gói tin UDP có cấu trúc rất đơn giản, với phần tiêu đề (header) chỉ chứa 8 byte. Cấu trúc bao gồm:
- Source Port (2 byte): Cổng nguồn.
- Destination Port (2 byte): Cổng đích.
- Length (2 byte): Độ dài của toàn bộ gói tin (bao gồm cả tiêu đề và dữ liệu).
- Checksum (2 byte): Kiểm tra lỗi cho gói tin (tùy chọn).

Phần dữ liệu (payload) sẽ theo sau tiêu đề, chứa nội dung cần truyền tải.

### 📙Ứng dụng

Do tính chất không kết nối và không đảm bảo của UDP, nó thường được sử dụng trong các ứng dụng yêu cầu tốc độ truyền nhanh, ít phụ thuộc vào việc gói tin bị mất hoặc thứ tự của các gói tin. Một số ứng dụng phổ biến của UDP bao gồm:

- Truyền phát video và âm thanh trực tuyến (Streaming Media)

- Truyền phát dữ liệu thời gian thực (Real-time data streaming)

- Game trực tuyến (Online Gaming)

- Domain Name System (DNS)

- Truyền phát các file nhỏ hoặc các đoạn dữ liệu đơn giản

## 📚Giao thức TCP (Transmission Control Protocol)

**TCP** được thiết kế để cung cấp **truyền tải dữ liệu đáng tin cậy**, **tuần tự**, và có cơ chế **điều khiển lưu lượng** và **điều khiển tắc nghẽn**. Giao thức này được sử dụng cho các ứng dụng yêu cầu độ tin cậy cao, như truyền tải tập tin, email, và duyệt web.

### 📙Đặc điểm chính của TCP

Kết nối (Connection-Oriented):
- TCP yêu cầu thiết lập một kết nối trước khi bắt đầu truyền dữ liệu giữa hai thiết bị. Kết nối này được duy trì trong suốt quá trình truyền và chỉ được giải phóng khi hoàn tất. Điều này đảm bảo rằng hai thiết bị có thể trao đổi dữ liệu một cách có tổ chức và đáng tin cậy.

Truyền dữ liệu đáng tin cậy (Reliable Data Transfer):
- TCP đảm bảo rằng tất cả các gói dữ liệu được truyền đi đều đến đích, và các gói này đến đúng thứ tự. Nếu có gói tin bị mất, TCP sẽ truyền lại gói tin đó. Điều này được thực hiện thông qua cơ chế **ACK (Acknowledgment)** và **Retransmission (truyền lại)**.

Điều khiển lưu lượng (Flow Control):
- TCP sử dụng cơ chế điều khiển lưu lượng để đảm bảo rằng máy gửi không gửi quá nhiều dữ liệu cùng một lúc mà máy nhận không thể xử lý kịp. Cơ chế này giúp tránh tình trạng máy nhận bị quá tải, gây mất mát dữ liệu.

Điều khiển tắc nghẽn (Congestion Control):
- TCP có cơ chế phát hiện và điều chỉnh tốc độ truyền dữ liệu dựa trên điều kiện của mạng (như tắc nghẽn mạng). Khi phát hiện có tắc nghẽn, TCP sẽ giảm tốc độ truyền để tránh gây thêm quá tải cho mạng.

Truyền dữ liệu theo luồng (Stream-Oriented):
- TCP là một giao thức hướng luồng, nghĩa là dữ liệu được truyền dưới dạng một luồng byte liên tục thay vì các gói dữ liệu rời rạc như UDP. Điều này giúp TCP có thể đảm bảo rằng dữ liệu được gửi và nhận theo đúng thứ tự.

### 📙Cấu trúc của gói TCP
Mỗi gói TCP có một phần tiêu đề (header) khá phức tạp, bao gồm các trường giúp điều khiển và quản lý truyền dữ liệu:

- Source Port (2 byte): Cổng nguồn.
- Destination Port (2 byte): Cổng đích.
- Sequence Number (4 byte): Số thứ tự của byte đầu tiên trong gói tin hiện tại.
- Acknowledgment Number (4 byte): Số thứ tự của byte tiếp theo mà máy nhận mong đợi.
- Data Offset (4 bit): Độ dài của phần tiêu đề.
- Flags (6 bit): Các cờ điều khiển, như SYN (đồng bộ hóa), ACK (xác nhận), FIN (kết thúc).
- Window Size (2 byte): Kích thước cửa sổ nhận, dùng để điều khiển lưu lượng.
- Checksum (2 byte): Kiểm tra lỗi.
- Urgent Pointer (2 byte): Chỉ định dữ liệu khẩn cấp.

### 📙Three-Way Handshake

Để thiết lập một kết nối TCP giữa hai thiết bị, quá trình **Three-Way Handshake (bắt tay ba bước)** được sử dụng. Đây là quá trình mà hai thiết bị (máy gửi và máy nhận) đồng ý về các thông số và đồng bộ hóa các trình tự số trước khi truyền dữ liệu.

Các bước trong Three-Way Handshake:
- SYN (Synchronize): Máy gửi gửi một gói tin SYN đến máy nhận, đề xuất thiết lập kết nối và cung cấp số thứ tự ban đầu (Initial Sequence Number - ISN).

- SYN-ACK (SYN Acknowledgment): Máy nhận đáp lại bằng cách gửi một gói SYN-ACK, trong đó SYN là đồng bộ hóa từ máy nhận và ACK là sự xác nhận gói SYN từ máy gửi.

- ACK (Acknowledgment): Máy gửi gửi một gói ACK cuối cùng để xác nhận nhận được SYN-ACK từ máy nhận. Kết nối TCP được thiết lập thành công và quá trình truyền dữ liệu có thể bắt đầu.

Quá trình kết thúc kết nối TCP yêu cầu **Four-Way Handshake (bắt tay bốn bước)**, trong đó cả hai bên đồng ý đóng kết nối.

### 📙Ứng dụng sử dụng TCP
Do tính chất đảm bảo và tin cậy, TCP được sử dụng trong các ứng dụng mà việc truyền tải chính xác và đầy đủ dữ liệu là rất quan trọng. Một số ứng dụng điển hình sử dụng TCP bao gồm:

- HTTP/HTTPS: Giao thức truyền tải web, đảm bảo các trang web và tài nguyên được tải chính xác.
- FTP (File Transfer Protocol): Truyền tải các tệp lớn qua mạng.
- SMTP (Simple Mail Transfer Protocol): Giao thức gửi email, đảm bảo email được gửi đi chính xác.
- POP3 và IMAP: Giao thức nhận email.

## 📚So sánh giữa TCP và UDP
| Tính chất                                 | TCP (Transmission Control Protocol)      | UDP (User Datagram Protocol)     |
| ----------------------------------------- | ---------------------------------------- | -------------------------------- |
| Kết nối (Connection)                      | Có kết nối (Connection-oriented)         | Không kết nối (Connectionless)   |
| Đảm bảo (Reliability)                     | Đảm bảo (Reliable)                       | Không đảm bảo (Unreliable)       |
| Thứ tự gói tin (Ordering)                 | Đảm bảo thứ tự gói tin                   | Không đảm bảo thứ tự gói tin     |
| Truyền lại gói tin                        | Có cơ chế truyền lại gói tin bị mất      | Không có cơ chế truyền lại       |
| Điều khiển lưu lượng (Flow Control)       | Có                                       | Không có                         |
| Điều khiển tắc nghẽn (Congestion Control) | Có                                       | Không có                         |
| Ứng dụng chính                            | Giao dịch dữ liệu quan trọng, email, web | Truyền phát thời gian thực, game |

## 📚Tầng mạng (Network Layer)

**Tầng mạng (Network Layer)** chịu trách nhiệm chính cho việc định tuyến (routing) và chuyển tiếp gói tin (packet forwarding) từ thiết bị gửi đến thiết bị nhận qua một hoặc nhiều mạng trung gian.

### 📙Chức năng chính

**Định tuyến (Routing)**: Tầng mạng chịu trách nhiệm tìm đường (route) tốt nhất cho dữ liệu đi từ nguồn đến đích. Việc này rất quan trọng khi gói tin phải đi qua nhiều mạng trung gian, chẳng hạn từ một máy tính ở Việt Nam đến một máy chủ ở Mỹ.

**Địa chỉ hóa (Addressing)**: Tầng mạng sử dụng **địa chỉ logic (logical addressing)**, chẳng hạn **địa chỉ IP (Internet Protocol)**, để định danh các thiết bị trong mạng. Mỗi thiết bị phải có một địa chỉ duy nhất trong mạng.

**Phân đoạn và hợp nhất dữ liệu (Fragmentation and Reassembly)**: Nếu gói tin lớn hơn kích thước tối đa mà mạng hỗ trợ, tầng mạng sẽ chia gói tin thành các phân đoạn nhỏ hơn (fragmentation) và hợp nhất chúng lại ở phía nhận (reassembly).

**Chuyển tiếp gói tin (Packet Forwarding)**: Khi gói tin đi qua một router trung gian, tầng mạng xác định bước tiếp theo (next hop) để tiếp tục gửi gói tin đến đích.

### 📙Quá trình hoạt động của tầng mạng

- Gắn địa chỉ IP nguồn và đích vào gói tin.
- Kiểm tra bảng định tuyến trên router để tìm đường đi đến đích.
- Nếu cần, chia nhỏ gói tin và gửi qua mạng trung gian.

## 📚Packet (Gói tin)

**Packet (Gói tin)** là đơn vị dữ liệu cơ bản được sử dụng trong quá trình truyền thông qua mạng. Nó là "mảnh" của dữ liệu được tầng mạng (Network Layer) tạo ra bằng cách đóng gói các **phân đoạn (segments)** từ tầng giao vận.

## 📚TTL (Time-to-Live)

**TTL (Time-to-Live)** là một giá trị trong phần header của gói tin IP, được sử dụng để giới hạn thời gian sống hoặc số bước (hops) mà một gói tin có thể tồn tại trên mạng.

### 📙Chức năng của TTL

TTL đảm bảo rằng gói tin không bị kẹt trong mạng vô thời hạn nếu gặp phải vòng lặp định tuyến (routing loop). Mỗi lần gói tin đi qua một router, giá trị TTL giảm đi 1. Khi TTL giảm về 0, router sẽ loại bỏ gói tin và gửi một thông báo lỗi ICMP (Internet Control Message Protocol) về nguồn, thường là một thông điệp "Time Exceeded".

Thông điệp ICMP "Time Exceeded" bao gồm:
- Địa chỉ IP của router: Giúp xác định router đã loại bỏ gói tin.
- Thông tin về gói tin bị loại: Một phần của gói tin bị loại bỏ được gửi kèm thông báo.

### 📙Cách hoạt động của TTL
Tại điểm gửi (Source): Khi gói tin được tạo tại nguồn, giá trị TTL ban đầu được đặt (ví dụ: 64, 128 hoặc 255 tùy theo hệ điều hành hoặc thiết bị).

Trong mạng: Mỗi khi gói tin đi qua một router, router sẽ giảm TTL đi 1.
Router kiểm tra giá trị TTL sau khi giảm. Nếu TTL = 0, gói tin sẽ bị hủy bỏ và thông báo lỗi được gửi về nguồn.

Tại đích (Destination): Nếu gói tin đến được đích trước khi TTL = 0, dữ liệu sẽ được xử lý bình thường.

TTL ban đầu mặc định của các hệ điều hành phổ biến
- Linux/Unix: 64
- Windows: 128
- Cisco Routers: 255
- macOS: 64

### 📙Ý nghĩa của TTL trong mạng
**Tránh vòng lặp định tuyến (Routing Loop)**: Khi mạng xảy ra lỗi định tuyến, các gói tin có thể chạy vòng lặp vô hạn giữa các router. TTL ngăn chặn điều này.

**Kiểm soát thời gian tồn tại của gói tin**: TTL đảm bảo rằng gói tin không đi quá xa hoặc tồn tại lâu hơn dự kiến.

**Công cụ đo khoảng cách mạng**: TTL được sử dụng trong các công cụ như traceroute để xác định đường đi của gói tin qua các router.

### 📙TTL và công cụ Traceroute

Traceroute là một công cụ mạng sử dụng TTL để phát hiện đường đi của gói tin qua mạng:
- Gói tin đầu tiên được gửi với TTL = 1. Router đầu tiên giảm TTL thành 0 và gửi thông báo "Time Exceeded" về nguồn.
- Gói tin tiếp theo được gửi với TTL = 2, và router thứ hai trả về thông báo.
- Quá trình này lặp lại cho đến khi gói tin đến đích.
- Dựa trên các thông báo trả về, Traceroute xây dựng danh sách các router mà gói tin đi qua.

## 📚Chuyển tiếp và định tuyến (Forwarding vs Routing)

### 📙Chuyển tiếp (Forwarding)

**Chuyển tiếp** là quá trình chuyển một gói tin từ một giao diện đầu vào (input interface) của router đến một giao diện đầu ra (output interface) phù hợp để gói tin tiếp tục hành trình đến đích.

Mục tiêu: Di chuyển gói tin từ điểm này sang điểm khác trong mạng một cách nhanh chóng.

Thời gian: Xử lý ở mức micro-giây đến mili-giây, vì đây là quá trình xảy ra tại từng router.

Cách thức:
- Router nhận một gói tin từ giao diện đầu vào.
- Dựa trên bảng chuyển tiếp (forwarding table), router tra cứu để xác định giao diện đầu ra tương ứng với địa chỉ IP đích.
- Gói tin được gửi qua giao diện đầu ra phù hợp.

Lưu ý: Chuyển tiếp chỉ tập trung vào xử lý gói tin hiện tại, không đưa ra quyết định dài hạn về đường đi của gói tin.

### 📙Định tuyến (Routing)

**Định tuyến** là quá trình xác định đường đi tốt nhất (optimal path) mà gói tin nên đi qua để đến được đích.

Mục tiêu: Xây dựng và duy trì bảng định tuyến (routing table), từ đó hỗ trợ quá trình chuyển tiếp.

Thời gian: Xử lý ở mức giây đến phút, vì đây là quá trình liên quan đến việc cập nhật thông tin mạng và điều chỉnh đường đi.

Cách thức:
- Router giao tiếp với các router khác trong mạng để chia sẻ thông tin định tuyến.
- Thuật toán định tuyến (routing algorithms) được sử dụng để tính toán đường đi tốt nhất dựa trên các yếu tố như khoảng cách, thời gian trễ, hoặc chi phí.
- Cập nhật bảng định tuyến định kỳ hoặc khi có thay đổi trong mạng.

### 📙So sánh giữa Chuyển tiếp và Định tuyến

| Đặc điểm          | Chuyển tiếp (Forwarding)                                  | Định tuyến (Routing)                                           |
| ----------------- | --------------------------------------------------------- | -------------------------------------------------------------- |
| Định nghĩa        | Xử lý và chuyển gói tin từ giao diện đầu vào sang đầu ra. | Tìm đường đi tối ưu cho gói tin trong mạng.                    |
| Mục tiêu          | Xử lý nhanh gói tin hiện tại.                             | Xây dựng và duy trì bảng định tuyến.                           |
| Thời gian xử lý   | Micro-giây đến mili-giây.                                 | Giây đến phút.                                                 |
| Đối tượng xử lý   | Gói tin hiện tại.                                         | Toàn bộ đường đi trong mạng.                                   |
| Thuật toán        | Không sử dụng thuật toán phức tạp.                        | Sử dụng thuật toán định tuyến (ví dụ: Dijkstra, Bellman-Ford). |
| Công cụ liên quan | Bảng chuyển tiếp (Forwarding Table).                      | Bảng định tuyến (Routing Table).                               |
| Tính động         | Tĩnh hơn, phụ thuộc vào bảng chuyển tiếp hiện có.         | Động hơn, cập nhật liên tục khi mạng thay đổi.                 |

### 📙Cách hoạt động phối hợp

Định tuyến:
- Định tuyến tính toán các đường đi khả thi và xây dựng **bảng định tuyến**.
- **Bảng định tuyến** cung cấp thông tin để xây dựng **bảng chuyển tiếp**.

Chuyển tiếp:
- Khi một gói tin đến router, **bảng chuyển tiếp** được sử dụng để xác định giao diện đầu ra.
- Gói tin được chuyển tiếp mà không cần thực hiện lại quá trình định tuyến.

Tóm lại:
- Định tuyến là chiến lược: Nó quyết định "làm thế nào để đi đến đích."
- Chuyển tiếp là hành động: Nó thực hiện việc "gửi gói tin đến đích."

## 📚Mô hình dịch vụ của tầng mạng

Mô hình dịch vụ của tầng mạng mô tả các chức năng mà tầng mạng cung cấp cho tầng transport để đảm bảo dữ liệu được truyền qua mạng một cách hiệu quả.

### 📙Dịch vụ Không Kết Nối (Connectionless Service)

Đặc điểm:
- Dữ liệu được gửi dưới dạng các gói tin độc lập, không có bất kỳ mối liên hệ nào giữa các gói tin.
- Mỗi gói tin được định tuyến một cách độc lập qua mạng, có thể đi qua các đường khác nhau để đến đích.
- Không có bước thiết lập trước (no setup) giữa nguồn và đích trước khi gửi dữ liệu.
- Tầng mạng không đảm bảo gói tin sẽ đến đích đúng thứ tự hoặc thậm chí có thể bị mất.

Ưu điểm:
- Đơn giản, không cần duy trì trạng thái kết nối.
- Phù hợp với các hệ thống mạng có độ phức tạp cao như Internet.

Nhược điểm:
- Tầng transport hoặc ứng dụng phải tự xử lý các vấn đề như mất gói tin, trễ hoặc gói tin đến sai thứ tự.

### 📙Dịch vụ Kết Nối (Connection-Oriented Service)

Đặc điểm:
- Yêu cầu thiết lập một kết nối logic giữa nguồn và đích trước khi dữ liệu được gửi.
- Dữ liệu được truyền qua mạng theo một đường đi cố định (circuit).
- Đảm bảo dữ liệu đến đúng thứ tự, không bị mất và không bị trùng lặp.

Ưu điểm:
- Cung cấp độ tin cậy cao hơn do có sự quản lý kết nối.
- Phù hợp với các ứng dụng yêu cầu dữ liệu được truyền ổn định, liên tục, và theo thứ tự.

Nhược điểm:
- Yêu cầu thêm tài nguyên để duy trì trạng thái kết nối.
- Quá trình thiết lập kết nối có thể gây trễ.

### 📙Dịch vụ Đảm Bảo (Guaranteed Service)

Đặc điểm: Đảm bảo các yếu tố về chất lượng dịch vụ (QoS) như:
- Tốc độ truyền (Throughput): Đảm bảo một lượng băng thông tối thiểu.
- Độ trễ (Latency): Đảm bảo dữ liệu được truyền với độ trễ nhỏ nhất.
- Độ tin cậy (Reliability): Đảm bảo không mất gói tin trong quá trình truyền.

Ưu điểm:
- Phù hợp cho các ứng dụng thời gian thực như video streaming, VoIP, hoặc hội nghị trực tuyến.

Nhược điểm:
- Cần sử dụng thêm tài nguyên mạng để đảm bảo QoS, do đó có thể không hiệu quả trên các mạng quy mô lớn.

### 📙Dịch vụ Không Đảm Bảo (Best-Effort Service)

Đặc điểm:
- Không cung cấp bất kỳ đảm bảo nào về việc dữ liệu sẽ đến đích, thời gian đến đích, hoặc dữ liệu đến đúng thứ tự.
- Gói tin được xử lý với mức độ nỗ lực cao nhất của mạng, nhưng không có cam kết nào từ tầng mạng.

Ưu điểm:
- Dễ triển khai, không cần tài nguyên mạng phức tạp.
- Phù hợp với các ứng dụng không yêu cầu cao về chất lượng truyền tải, như email hoặc duyệt web.

Nhược điểm:
- Không đảm bảo được các tiêu chí quan trọng như tốc độ, độ tin cậy.

### 📙So sánh Các Mô Hình Dịch Vụ

| Dịch vụ       | Kết nối       | Đảm bảo QoS | Ứng dụng phổ biến                           |
| ------------- | ------------- | ----------- | ------------------------------------------- |
| Không kết nối | Không         | Không       | Internet (IP), truyền dữ liệu thông thường. |
| Kết nối       | Có            | Có thể      | Mạng ATM, MPLS, hội nghị truyền hình.       |
| Đảm bảo       | Không/Kết nối | Có          | Video streaming, VoIP, IoT.                 |
| Không đảm bảo | Không         | Không       | Email, duyệt web, gửi file thông thường.    |

Internet hiện đại:
- Dịch vụ tầng mạng thường sử dụng mô hình không kết nối và không đảm bảo, vì Internet dựa trên giao thức IP.
- Độ tin cậy và đảm bảo thứ tự dữ liệu được tầng transport (TCP) hoặc ứng dụng xử lý.

Mạng doanh nghiệp hoặc chuyên dụng:
- Sử dụng dịch vụ kết nối và đảm bảo để đáp ứng yêu cầu cao về chất lượng và độ tin cậy.

## 📚Giao thức IP (Internet Protocol)

Giao thức IP là một giao thức không kết nối (connectionless) và không đảm bảo (best-effort) trong bộ giao thức TCP/IP, được sử dụng để định địa chỉ và chuyển tiếp các gói tin qua mạng.

### 📙Vai trò 

Định địa chỉ (Addressing):
- Gắn địa chỉ IP nguồn và địa chỉ IP đích vào mỗi gói tin.
- Đảm bảo rằng dữ liệu được chuyển đúng đến thiết bị đích trong mạng.

Chuyển tiếp gói tin (Packet Forwarding):
- Xác định đường đi của gói tin qua các mạng trung gian dựa trên bảng định tuyến (routing table).

Phân mảnh và hợp nhất (Fragmentation and Reassembly):
- Chia nhỏ gói tin nếu kích thước của nó lớn hơn khả năng xử lý của mạng trung gian.
- Thiết bị đích hợp lại các mảnh gói tin thành dữ liệu hoàn chỉnh.

IP là nền tảng của Internet, chịu trách nhiệm chính trong việc định tuyến và chuyển tiếp gói tin qua các mạng khác nhau.

IPv4 vẫn được sử dụng rộng rãi, nhưng IPv6 đang dần thay thế để đáp ứng nhu cầu về địa chỉ IP và các cải tiến hiện đại.

### 📙Đặc điểm

Không kết nối (Connectionless):
- Không thiết lập kết nối trước khi truyền dữ liệu.
- Mỗi gói tin được xử lý độc lập và có thể đi qua các đường khác nhau để đến đích.

Không đảm bảo (Best-Effort Delivery):
- Không cam kết rằng gói tin sẽ đến đích.
- Gói tin có thể bị mất, đến sai thứ tự, hoặc bị trùng lặp.

Phụ thuộc vào tầng transport:
- Độ tin cậy được đảm bảo bởi các giao thức tầng transport, như TCP.

### 📙Cấu trúc gói tin IP

| Trường                 | Kích thước (bit) | Chức năng                                                         |
| ---------------------- | ---------------- | ----------------------------------------------------------------- |
| Version                | 4                | Xác định phiên bản IP (IPv4 hoặc IPv6).                           |
| Header Length          | 4                | Độ dài phần tiêu đề.                                              |
| Type of Service (TOS)  | 8                | Định nghĩa cách gói tin được xử lý (ưu tiên hoặc QoS).            |
| Total Length           | 16               | Độ dài toàn bộ gói tin (header + payload).                        |
| Identification         | 16               | Dùng để nhận diện các mảnh của gói tin trong quá trình phân mảnh. |
| Flags                  | 3                | Cờ kiểm soát (phân mảnh hoặc không phân mảnh).                    |
| Fragment Offset        | 13               | Vị trí của mảnh trong gói tin ban đầu.                            |
| TTL (Time-to-Live)     | 8                | Giới hạn số lần gói tin được chuyển tiếp qua các router.          |
| Protocol               | 8                | Xác định giao thức tầng trên (ví dụ: TCP, UDP).                   |
| Header Checksum        | 16               |                                                                   | Giá trị kiểm tra lỗi của phần tiêu đề. |
| Source IP Address      | 32               | Địa chỉ IP nguồn.                                                 |
| Destination IP Address | 32               | Địa chỉ IP đích.                                                  |
| Options (tùy chọn)     | Biến             | Các tùy chọn bổ sung (không bắt buộc).                            |
| Payload (Dữ liệu)      | Biến             | Dữ liệu được gửi từ tầng trên (tầng transport).                   |

### 📙Các phiên bản

IPv4 (Internet Protocol Version 4):
- Địa chỉ dài 32 bit (2³² = ~4,3 tỷ địa chỉ).
- Dùng rộng rãi nhưng đang dần hết địa chỉ.

IPv6 (Internet Protocol Version 6):
- Địa chỉ dài 128 bit (2¹²⁸ địa chỉ, rất lớn).
- Hỗ trợ nhiều tính năng mới, cải thiện hiệu suất và bảo mật.

### 📙Quá trình xử lý của giao thức IP

Thiết bị nguồn:
- Tầng transport tạo dữ liệu và chuyển cho tầng mạng.
- Giao thức IP đóng gói dữ liệu vào gói tin IP (IP packet).
- Thêm địa chỉ IP nguồn và đích, sau đó gửi gói tin.

Router trung gian:
- Nhận gói tin IP, kiểm tra địa chỉ IP đích.
- Tìm đường đi đến thiết bị đích dựa vào bảng định tuyến.
- Chuyển tiếp gói tin tới mạng kế tiếp.

Thiết bị đích:
- Nhận gói tin IP.
- Kiểm tra địa chỉ IP đích để đảm bảo gói tin đúng nơi.
- Loại bỏ tiêu đề IP, chuyển dữ liệu lên tầng transport.

### 📙Ưu và nhược điểm của giao thức IP
Ưu điểm:
- Đơn giản, dễ triển khai trên mạng toàn cầu.
- Linh hoạt, hỗ trợ nhiều giao thức tầng trên như TCP, UDP.
- Cho phép truyền dữ liệu qua các mạng khác nhau (inter-networking).

Nhược điểm:
- Không đảm bảo dữ liệu đến đích.
- Không có tính năng bảo mật (dữ liệu có thể bị chặn hoặc thay đổi).
- Không hỗ trợ QoS tốt trong môi trường truyền dữ liệu thời gian thực.

## 📚Checksum

**Checksum** là một giá trị được tính toán từ dữ liệu gói tin để kiểm tra xem gói tin có bị lỗi trong quá trình truyền qua mạng hay không. Đây là cơ chế đơn giản và hiệu quả để phát hiện lỗi dữ liệu trong các giao thức như IP, TCP, và UDP.

### 📙Vai trò của Checksum

Phát hiện lỗi:
- Kiểm tra xem dữ liệu có bị thay đổi trong quá trình truyền dẫn hay không.
- Nếu giá trị checksum không khớp tại đầu nhận, gói tin hoặc đoạn dữ liệu sẽ bị từ chối hoặc yêu cầu gửi lại (nếu giao thức hỗ trợ).

Hiệu quả:
- Phát hiện lỗi nhanh chóng mà không cần phân tích toàn bộ dữ liệu.

### 📙Cách tính toán Checksum

Chia dữ liệu thành các khối nhỏ:
- Mỗi khối thường có kích thước 16 bit.

Cộng các khối dữ liệu:
- Cộng dồn giá trị nhị phân của từng khối dữ liệu lại với nhau.
- Nếu phép cộng vượt quá 16 bit (có "carry"), cộng phần dư này quay lại vào tổng.

Bù hai (One's Complement):
- Lấy phần bù hai của kết quả tổng.
- Phần bù hai được tạo bằng cách đảo ngược tất cả các bit.

Checksum:
- Kết quả cuối cùng là giá trị checksum.
- Giá trị này được chèn vào tiêu đề gói tin trước khi gửi.

### 📙Hoạt động của Checksum trong giao thức IP

Tại thiết bị gửi:
- Giao thức IP tạo tiêu đề gói tin.
- Tính toán giá trị checksum dựa trên tiêu đề.
- Chèn giá trị checksum vào trường Header Checksum trong tiêu đề.

Tại mỗi router trung gian:
- Router kiểm tra giá trị checksum của tiêu đề gói tin.
- Nếu checksum không khớp, gói tin bị loại bỏ.

Tại thiết bị nhận:
- Checksum được tính toán lại và so sánh với giá trị trong tiêu đề.
- Nếu khớp, gói tin được xử lý tiếp. Nếu không, gói tin bị bỏ

### 📙Giới hạn của Checksum

Không phát hiện được tất cả các lỗi: Nếu dữ liệu bị thay đổi theo cách mà tổng các giá trị không đổi (ví dụ: hoán đổi các bit), checksum có thể không phát hiện lỗi.

Không đảm bảo an ninh: Checksum chỉ phát hiện lỗi ngẫu nhiên, không phải lỗi cố ý (ví dụ: tấn công làm thay đổi gói tin).

IP:
- Chỉ kiểm tra lỗi trong phần tiêu đề gói tin.
- Dữ liệu không được kiểm tra bằng checksum ở tầng IP.

TCP/UDP:
- Sử dụng checksum để kiểm tra cả tiêu đề và dữ liệu.
- Đảm bảo dữ liệu nhận được chính xác.

### 📙Khác biệt giữa Checksum và CRC (Cyclic Redundancy Check)

| Tiêu chí      | Checksum                      | CRC                                        |
| ------------- | ----------------------------- | ------------------------------------------ |
| Độ phức tạp   | Đơn giản                      | Phức tạp hơn                               |
| Phát hiện lỗi | Tốt với lỗi ngẫu nhiên nhỏ    | Tốt hơn với lỗi phức tạp và liên tiếp      |
| Ứng dụng      | Giao thức mạng (IP, TCP, UDP) | Hệ thống lưu trữ, truyền dữ liệu, Ethernet |

## 📚DHCP (Dynamic Host Configuration Protocol)

**DHCP** là một giao thức trong mạng máy tính, giúp tự động cấp phát địa chỉ IP cho các thiết bị (host) khi chúng kết nối vào mạng. Điều này giúp giảm bớt sự cần thiết phải cấu hình thủ công địa chỉ IP cho từng thiết bị trong mạng.

### 📙Vai trò của DHCP

**Cấp phát địa chỉ IP tự động**: DHCP cho phép máy tính và thiết bị khác nhận được địa chỉ IP một cách tự động từ máy chủ DHCP.

**Cấu hình thông tin mạng**: Bên cạnh địa chỉ IP, DHCP còn cấp phát các thông tin như subnet mask, gateway, và DNS server.

**Quản lý tập trung**: Việc cấp phát và quản lý địa chỉ IP được thực hiện ở máy chủ DHCP, giúp đơn giản hóa quản lý mạng.

### 📙Cách thức hoạt động của DHCP

Quá trình cấp phát địa chỉ IP diễn ra qua 4 bước chính:

- DHCP Discover: Khi một thiết bị (client) mới kết nối vào mạng và không có địa chỉ IP, nó sẽ phát ra một gói tin DHCP Discover trên mạng để tìm máy chủ DHCP.

- DHCP Offer: Các máy chủ DHCP lắng nghe gói tin Discover và gửi lại gói tin DHCP Offer cho client, chứa một địa chỉ IP mà máy chủ DHCP dự định cấp phát cho client.

- DHCP Request: Client nhận được nhiều gói DHCP Offer từ các máy chủ DHCP (nếu có nhiều máy chủ DHCP trên mạng). Client sẽ chọn một trong số chúng và gửi gói DHCP Request để yêu cầu cấp phát địa chỉ IP từ một máy chủ DHCP cụ thể.

- DHCP Acknowledgement (ACK): Máy chủ DHCP nhận được yêu cầu từ client và gửi lại một gói tin DHCP ACK, xác nhận rằng địa chỉ IP đã được cấp phát cho client và cung cấp thêm thông tin cấu hình như gateway và DNS server.

### 📙Các thành phần của DHCP

DHCP Server: Máy chủ này có nhiệm vụ cấp phát địa chỉ IP và cấu hình cho các thiết bị trong mạng.

DHCP Client: Các thiết bị yêu cầu địa chỉ IP từ máy chủ DHCP.

DHCP Lease: Thời gian mà một địa chỉ IP được cấp cho một thiết bị. Sau khi thời gian này hết, địa chỉ IP có thể được tái sử dụng cho thiết bị khác.

### 📙Các thông tin được cấp phát bởi DHCP

Ngoài địa chỉ IP, máy chủ DHCP còn cấp phát các thông tin khác cho client:
- Subnet Mask: Để xác định phạm vi mạng.
- Default Gateway: Để định tuyến đến mạng ngoài.
- DNS Server: Để giải quyết tên miền thành địa chỉ IP.

### 📙Quản lý địa chỉ IP với DHCP

DHCP Lease Time: Thời gian mà một thiết bị có thể sử dụng địa chỉ IP được cấp phát. Sau khi hết thời gian lease, thiết bị phải yêu cầu cấp phát lại.

Reservation: Máy chủ DHCP có thể được cấu hình để dành một địa chỉ IP cố định cho một thiết bị cụ thể dựa trên địa chỉ MAC của thiết bị đó. Điều này giúp đảm bảo rằng thiết bị luôn nhận được cùng một địa chỉ IP mỗi khi kết nối vào mạng.

### 📙Lợi ích của DHCP

Tiết kiệm thời gian: Quá trình cấp phát địa chỉ IP tự động giúp giảm bớt công việc cấu hình thủ công.

Dễ dàng quản lý: DHCP giúp dễ dàng quản lý địa chỉ IP trong mạng mà không cần phải kiểm tra và cập nhật thủ công.

Hỗ trợ mở rộng mạng: Khi thêm nhiều thiết bị vào mạng, DHCP sẽ tự động cấp phát địa chỉ IP mà không cần thay đổi cấu hình thủ công.

### 📙Các loại DHCP

DHCP truyền thống (Dynamic DHCP): Cấp phát địa chỉ IP tự động và không cố định.

DHCP với đối tượng (DHCP Reservation): Cấp phát địa chỉ IP cố định cho các thiết bị dựa trên địa chỉ MAC.

DHCP Relay: Khi client và server DHCP không cùng một mạng con, router hoặc thiết bị trung gian sẽ đóng vai trò là DHCP Relay để chuyển tiếp các gói tin DHCP giữa client và server.

### 📙Sự cố phổ biến với DHCP

Hết dải IP: Nếu số lượng địa chỉ IP trong dải cấp phát DHCP không đủ, các thiết bị mới sẽ không nhận được địa chỉ IP.

Cấu hình sai: Nếu máy chủ DHCP bị cấu hình sai, client có thể không nhận được địa chỉ IP đúng hoặc bị cấp phát sai thông tin (ví dụ: DNS, gateway).

Mất kết nối với DHCP Server: Nếu máy chủ DHCP bị lỗi hoặc không thể truy cập, các thiết bị sẽ không thể nhận địa chỉ IP tự động.

## 📚Giao thức IPv4 (Internet Protocol version 4)

**IPv4 (Internet Protocol version 4)** là phiên bản đầu tiên của giao thức IP được triển khai rộng rãi. Đây là một trong những giao thức lõi của Internet, chịu trách nhiệm định tuyến và chuyển tiếp gói tin từ thiết bị nguồn đến thiết bị đích qua mạng.

### 📙Đặc điểm chính của IPv4

**Địa chỉ IP 32-bit**: Mỗi địa chỉ IPv4 có 32 bit, thường được biểu diễn dưới dạng 4 số thập phân, cách nhau bằng dấu chấm (dot-decimal notation), ví dụ: `192.168.0.1`.

**Không kết nối (Connectionless)**: IPv4 không thiết lập kết nối trước khi gửi gói tin. Mỗi gói tin được xử lý độc lập.

**Tốt nhất có thể (Best-effort Delivery)**: IPv4 không đảm bảo rằng gói tin sẽ đến được đích, không đảm bảo thứ tự gói tin, và không cung cấp cơ chế khôi phục lỗi.

**Hỗ trợ phân mảnh**: Nếu gói tin lớn hơn khả năng truyền tải của một mạng trung gian, nó sẽ được phân mảnh thành các phần nhỏ hơn.

### 📙Phân mảnh và tái lắp ghép (Fragmentation & Reassembly)

Khi gói tin lớn hơn MTU (Maximum Transmission Unit) của mạng, IPv4 sẽ chia gói tin thành các phân mảnh.

Các phân mảnh có các trường đặc biệt:
- Identification: Để nhận biết các phân mảnh thuộc cùng một gói tin.
- Fragment Offset: Đánh dấu vị trí của phân mảnh trong gói tin ban đầu.
- MF (More Fragments): Cờ báo hiệu phân mảnh tiếp theo (MF = 1 nếu còn, MF = 0 nếu là phân mảnh cuối cùng).

Router không tái lắp ghép phân mảnh. Việc tái lắp ghép được thực hiện ở thiết bị đích.

### 📙Định tuyến trong IPv4

IPv4 sử dụng các thuật toán định tuyến để chọn đường đi cho gói tin:
- Forwarding: Router kiểm tra địa chỉ đích và chuyển gói tin đến bước tiếp theo.
- Routing: Xây dựng bảng định tuyến dựa trên các giao thức định tuyến như RIP, OSPF, BGP.

### 📙Hạn chế của IPv4

Không đủ địa chỉ: IPv4 chỉ cung cấp khoảng 4.3 tỷ địa chỉ (2³²), không đủ cho số lượng thiết bị ngày càng tăng.

Thiếu bảo mật: Không có cơ chế bảo mật tích hợp (như mã hóa hoặc xác thực).

Phân mảnh tốn kém: Phân mảnh và tái lắp ghép tiêu tốn nhiều tài nguyên tính toán.

Không hỗ trợ QoS (Quality of Service) đầy đủ: Khả năng ưu tiên lưu lượng mạng rất hạn chế.

## 📚Giao thức IPv6 (Internet Protocol version 6)

**IPv6** là phiên bản tiếp theo của **giao thức IP** được phát triển để khắc phục những hạn chế của **IPv4**, đặc biệt là vấn đề thiếu hụt địa chỉ. Nó mang đến nhiều cải tiến về khả năng mở rộng, hiệu năng, và bảo mật.

### 📙Đặc điểm chính của IPv6

**Địa chỉ IP 128-bit**:
- IPv6 sử dụng địa chỉ dài 128 bit, cung cấp số lượng địa chỉ gần như không giới hạn (2¹²⁸ địa chỉ). 
- Được viết dưới dạng 8 nhóm số thập lục phân, cách nhau bằng dấu hai chấm (`:`), ví dụ: `2001:0db8:85a3:0000:0000:8a2e:0370:7334`.

**Cấu trúc tiêu đề đơn giản**: Tiêu đề IPv6 được thiết kế đơn giản hơn IPv4 để cải thiện hiệu năng xử lý.

**Không phân mảnh tại router**: Chỉ thiết bị gửi mới có thể phân mảnh, giúp giảm gánh nặng cho các router.

**Hỗ trợ bảo mật tích hợp**: IPv6 tích hợp sẵn IPsec, một giao thức đảm bảo bảo mật cho các gói tin.

**Tích hợp QoS tốt hơn**: IPv6 hỗ trợ các trường như Flow Label để cung cấp chất lượng dịch vụ (QoS) tốt hơn.

**Không cần NAT (Network Address Translation)**: Với số lượng địa chỉ khổng lồ, mỗi thiết bị có thể có địa chỉ IP công khai riêng.

### 📙Địa chỉ IPv6
Địa chỉ IPv6 được phân thành các loại chính sau:
- **Unicast**: Gửi dữ liệu từ một nguồn đến một đích duy nhất.
- **Multicast**: Gửi dữ liệu từ một nguồn đến nhiều đích.
- **Anycast**: Gửi dữ liệu từ một nguồn đến đích gần nhất (trong số nhiều đích).

Viết gọn địa chỉ IPv6:
- Loại bỏ các số 0 liên tiếp: `2001:0db8:0000:0000:0000:ff00:0042:8329 → 2001:db8::ff00:42:8329`.
- Một nhóm `::` chỉ xuất hiện một lần trong địa chỉ.

### 📙Định tuyến trong IPv6

Không phân mảnh tại router: Các router chỉ chuyển tiếp gói tin mà không thực hiện phân mảnh. Thiết bị nguồn phải đảm bảo gói tin phù hợp với MTU (Maximum Transmission Unit).

Cải thiện hiệu năng xử lý: Tiêu đề đơn giản giúp router xử lý nhanh hơn.

Sử dụng giao thức định tuyến hiện đại: IPv6 hỗ trợ các giao thức định tuyến tiên tiến như OSPFv3, IS-IS, và BGP.

### 📙Chuyển đổi từ IPv4 sang IPv6

Do sự phổ biến của IPv4, quá trình chuyển đổi sang IPv6 diễn ra dần dần. Một số kỹ thuật được sử dụng:
- Dual-Stack: Các thiết bị và mạng hỗ trợ cả IPv4 và IPv6.
- Tunneling: Gói tin IPv6 được đóng gói trong gói IPv4 để truyền qua mạng chỉ hỗ trợ IPv4.
- Translation: Dịch địa chỉ IPv6 sang IPv4 và ngược lại (ví dụ: NAT64).

### 📙So sánh IPv4 và IPv6

| Đặc điểm                 | IPv4                       | IPv6                                 |
| ------------------------ | -------------------------- | ------------------------------------ |
| Địa chỉ                  | 32-bit (~4.3 tỷ địa chỉ)   | 128-bit (số địa chỉ rất lớn)         |
| Phân mảnh                | Tại router và thiết bị gửi | Chỉ tại thiết bị gửi                 |
| Bảo mật tích hợp         | Không                      | Tích hợp IPsec                       |
| Chất lượng dịch vụ (QoS) | Hạn chế                    | Hỗ trợ tốt hơn với trường Flow Label |
| Cấu trúc tiêu đề         | Phức tạp hơn               | Đơn giản, hiệu quả hơn               |

## 📚Giao thức ARP (Address Resolution Protocol)

**ARP** là một giao thức thuộc tầng mạng (Network Layer) trong mô hình TCP/IP. Nó chịu trách nhiệm tìm kiếm và **ánh xạ địa chỉ IP (logical address) thành địa chỉ MAC (physical address)** trong một mạng LAN.

### 📙Chức năng của ARP

Giải quyết địa chỉ: ARP được sử dụng khi một thiết bị muốn gửi dữ liệu đến một thiết bị khác trong cùng mạng LAN nhưng chỉ biết địa chỉ IP của thiết bị đó. ARP sẽ ánh xạ địa chỉ IP này sang địa chỉ MAC để truyền dữ liệu.

### 📙Cách thức hoạt động của ARP

ARP Request (Yêu cầu ARP):
- Thiết bị gửi một gói tin phát quảng bá (broadcast) trên mạng LAN để hỏi: "Ai là chủ của địa chỉ IP này?".
- Gói ARP Request bao gồm: Địa chỉ MAC và IP của thiết bị gửi cùng với địa chỉ IP của thiết bị cần tìm.

ARP Reply (Phản hồi ARP):
- Thiết bị đích nhận được ARP Request sẽ phản hồi bằng cách gửi gói ARP Reply trở lại, trong đó có địa chỉ MAC của nó.
- Gói ARP Reply được gửi theo **phương thức unicast** trực tiếp đến thiết bị yêu cầu.

### 📙Bảng ARP (ARP Cache)

Sau khi ánh xạ địa chỉ IP thành địa chỉ MAC, thiết bị sẽ lưu thông tin này vào bảng ARP (ARP Cache) để tái sử dụng trong tương lai, giảm thiểu số lần gửi yêu cầu ARP.

Bảng ARP có thời gian tồn tại nhất định (thường vài phút đến vài giờ) trước khi các bản ghi bị xóa.

### 📙Cấu trúc gói tin ARP

| Trường                  | Mô tả                                                       |
| ----------------------- | ----------------------------------------------------------- |
| Hardware Type           | Loại phần cứng (Ethernet = 1).                              |
| Protocol Type           | Loại giao thức (IPv4 = 0x0800).                             |
| Hardware Address Length | Độ dài địa chỉ MAC (thường là 6 byte).                      |
| Protocol Address Length | Độ dài địa chỉ IP (thường là 4 byte).                       |
| Operation               | Loại gói tin (ARP Request = 1, ARP Reply = 2).              |
| Sender MAC Address      | Địa chỉ MAC của thiết bị gửi.                               |
| Sender IP Address       | Địa chỉ IP của thiết bị gửi.                                |
| Target MAC Address      | Địa chỉ MAC của thiết bị đích (để trống trong ARP Request). |
| Target IP Address       | Địa chỉ IP của thiết bị đích.                               |

### 📙Một số vấn đề liên quan đến ARP

**ARP Spoofing**: Đây là một cuộc tấn công bảo mật, trong đó kẻ tấn công gửi các gói ARP giả mạo để ánh xạ địa chỉ IP của thiết bị hợp pháp với địa chỉ MAC của nó. Điều này cho phép kẻ tấn công nghe lén hoặc chặn dữ liệu.

**Broadcast Overhead**: Nếu mạng có nhiều thiết bị, việc phát quảng bá ARP liên tục có thể làm tăng tải trên mạng.

**Proxy ARP**: Một router có thể sử dụng Proxy ARP để phản hồi các yêu cầu ARP thay mặt cho thiết bị khác, giúp kết nối giữa các mạng khác nhau.

## 📚Giao thức RARP (Reverse Address Resolution Protocol)

**RARP (Reverse Address Resolution Protocol)** là một giao thức thuộc tầng mạng, được thiết kế để **ánh xạ ngược từ địa chỉ MAC (Media Access Control) sang địa chỉ IP**. Nó thường được sử dụng trong các thiết bị không có khả năng lưu trữ địa chỉ IP, như các thiết bị đầu cuối hoặc máy trạm không ổ cứng.

### 📙Mục đích của RARP

Trong mạng, một thiết bị biết địa chỉ MAC của chính mình nhưng không biết địa chỉ IP. RARP giúp thiết bị yêu cầu máy chủ RARP cung cấp địa chỉ IP tương ứng với địa chỉ MAC của nó.

RARP thường được sử dụng trong các hệ thống không ổ cứng (diskless systems), ví dụ: các máy trạm trong mạng LAN.

### 📙Cách thức hoạt động của RARP

RARP Request (Yêu cầu RARP):
- Thiết bị gửi một gói tin phát quảng bá (broadcast) RARP Request lên mạng LAN, trong đó chứa địa chỉ MAC của chính nó.
- Yêu cầu: "Tôi là thiết bị có địa chỉ MAC XYZ. Xin cung cấp địa chỉ IP tương ứng cho tôi."

RARP Reply (Phản hồi RARP):
- Máy chủ RARP trên mạng (thường là một server có bảng ánh xạ MAC → IP) nhận được yêu cầu, tra cứu trong bảng ánh xạ, và gửi lại gói RARP Reply đến thiết bị yêu cầu.
- Gói phản hồi chứa địa chỉ IP tương ứng với địa chỉ MAC được cung cấp.

### 📙Yêu cầu cần thiết để RARP hoạt động

Máy chủ RARP: Phải tồn tại một máy chủ RARP trong mạng, được cấu hình sẵn với bảng ánh xạ giữa địa chỉ MAC và địa chỉ IP.

Bảng ánh xạ MAC → IP: Máy chủ cần lưu trữ thông tin ánh xạ của các thiết bị trong mạng để trả lời các yêu cầu RARP.

### 📙Cấu trúc gói tin RARP

| Trường                  | Mô tả                                                       |
| ----------------------- | ----------------------------------------------------------- |
| Hardware Type           | Loại phần cứng (Ethernet = 1).                              |
| Protocol Type           | Loại giao thức (IPv4 = 0x0800).                             |
| Hardware Address Length | Độ dài địa chỉ MAC (thường là 6 byte).                      |
| Protocol Address Length | Độ dài địa chỉ IP (thường là 4 byte).                       |
| Operation               | Loại gói tin (RARP Request = 3, RARP Reply = 4).            |
| Sender MAC Address      | Địa chỉ MAC của thiết bị gửi.                               |
| Sender IP Address       | Địa chỉ IP của thiết bị gửi (trống trong RARP Request).     |
| Target MAC Address      | Địa chỉ MAC của thiết bị yêu cầu ánh xạ.                    |
| Target IP Address       | Địa chỉ IP của thiết bị yêu cầu (trống trong RARP Request). |

### 📙Ưu và nhược điểm của RARP

Ưu điểm:
- Cung cấp địa chỉ IP động cho các thiết bị không lưu trữ được địa chỉ IP.
- Hoạt động đơn giản, dựa trên phát quảng bá trong mạng LAN.

Nhược điểm:
- Khả năng mở rộng thấp: RARP chỉ hoạt động trong mạng LAN cục bộ và không hỗ trợ cấu hình qua mạng rộng (WAN).
- Phụ thuộc vào máy chủ RARP: Nếu không có máy chủ RARP hoặc máy chủ bị lỗi, giao thức sẽ không hoạt động.
- Khả năng ánh xạ hạn chế: RARP chỉ ánh xạ địa chỉ MAC → IP, không hỗ trợ các cấu hình mạng phức tạp (như subnet mask, default gateway).

### 📙Tổng kết

RARP là một giao thức đơn giản và hữu ích trong các mạng LAN nhỏ, nhưng ngày nay nó đã không còn được sử dụng phổ biến do sự ra đời của các giao thức linh hoạt và mạnh mẽ hơn như DHCP.

Do các hạn chế của RARP, các giao thức mới đã được phát triển và thay thế nó:
- BOOTP: Hỗ trợ cấu hình đầy đủ hơn, bao gồm địa chỉ IP, subnet mask, gateway, và tên máy chủ.
- DHCP: Tiến hóa từ BOOTP, cung cấp cấu hình địa chỉ IP động và khả năng mở rộng cao hơn.

## 📚Giao thức NAT (Network Address Translation)

**NAT (Network Address Translation)** là một kỹ thuật được sử dụng trong các bộ định tuyến (router) hoặc tường lửa để thay đổi địa chỉ IP trong các gói tin khi chúng di chuyển qua mạng. NAT đóng vai trò quan trọng trong việc quản lý địa chỉ IP và bảo mật mạng.

### 📙Mục đích của NAT

**Tiết kiệm địa chỉ IPv4**: Do địa chỉ IPv4 đang thiếu hụt, NAT cho phép nhiều thiết bị trong mạng nội bộ sử dụng một địa chỉ IP công cộng duy nhất để giao tiếp với Internet.

**Bảo mật mạng**: NAT ẩn địa chỉ IP nội bộ, giúp các thiết bị trong mạng nội bộ không bị truy cập trực tiếp từ bên ngoài.

**Kết nối mạng nội bộ với Internet**: NAT cho phép mạng nội bộ sử dụng các địa chỉ IP riêng (private IP) và vẫn có thể giao tiếp với mạng Internet.

### 📙Cách thức hoạt động của NAT

NAT thực hiện **ánh xạ giữa địa chỉ IP nội bộ (private IP) và địa chỉ IP công cộng (public IP)**. Khi một thiết bị trong mạng nội bộ gửi dữ liệu ra Internet, NAT thay đổi địa chỉ IP nguồn trong gói tin từ IP nội bộ thành IP công cộng của router.

Thiết bị nội bộ gửi gói tin:
- Thiết bị nội bộ (với IP riêng) gửi gói tin đến router NAT.
- Địa chỉ IP nguồn ban đầu là địa chỉ IP riêng của thiết bị.

Router NAT thay đổi địa chỉ IP:
- Router NAT thay thế địa chỉ IP nguồn bằng địa chỉ IP công cộng của nó.
- Nếu cần, NAT cũng thay đổi số cổng (port) nguồn để phân biệt các kết nối.

Router gửi gói tin ra Internet:
- Gói tin với địa chỉ IP công cộng được gửi đến đích qua Internet.

Phản hồi từ máy chủ:
- Khi máy chủ đích phản hồi, gói tin sẽ quay về địa chỉ IP công cộng của router NAT.

Router NAT chuyển gói tin về thiết bị nội bộ:
- Router NAT kiểm tra bảng ánh xạ địa chỉ (NAT table) để xác định thiết bị nội bộ ban đầu và gửi gói tin phản hồi đến nó.

### 📙Các loại NAT
Static NAT (NAT tĩnh):
- Ánh xạ một địa chỉ IP nội bộ cố định sang một địa chỉ IP công cộng cố định.
- Sử dụng khi cần truy cập thiết bị nội bộ từ bên ngoài Internet.

Dynamic NAT (NAT động):
- Ánh xạ các địa chỉ IP nội bộ với một nhóm địa chỉ IP công cộng (pool of public IP addresses).
- Địa chỉ IP công cộng được gán động từ nhóm này.

PAT (Port Address Translation) - NAT Nạp Cổng:
- Là một loại NAT động phổ biến.
- Cho phép nhiều thiết bị nội bộ sử dụng chung một địa chỉ IP công cộng bằng cách phân biệt các kết nối qua số cổng (port).
- Đây là loại NAT thường được sử dụng trong mạng gia đình hoặc mạng doanh nghiệp nhỏ.

### 📙Bảng ánh xạ NAT (NAT Table)

NAT sử dụng một bảng ánh xạ để theo dõi các kết nối đang hoạt động. Mỗi mục trong bảng bao gồm:
- IP nội bộ và cổng nguồn.
- IP công cộng và cổng nguồn đã thay đổi.
- IP đích và cổng đích.

### 📙Ưu điểm và nhược điểm

Ưu điểm:
- Tiết kiệm địa chỉ IPv4 công cộng.
- Tăng cường bảo mật bằng cách ẩn địa chỉ IP nội bộ.
- Hỗ trợ nhiều thiết bị trong mạng nội bộ truy cập Internet qua một địa chỉ IP duy nhất.

Nhược điểm:
- Làm tăng độ trễ vì router phải xử lý thêm bước ánh xạ địa chỉ.
- Không hỗ trợ tốt các giao thức yêu cầu địa chỉ IP nguồn cố định (ví dụ: IPsec).
- Giới hạn kết nối đồng thời trong mạng lớn khi sử dụng PAT.

## 📚Định địa chỉ IP

Định địa chỉ IP (IP Addressing) là quá trình gán một địa chỉ IP duy nhất cho mỗi thiết bị trong mạng để xác định và giao tiếp với nhau. Địa chỉ IP là một dãy số được sử dụng trong giao thức Internet để xác định vị trí của một thiết bị trong mạng.

### 📙Địa chỉ IP là gì?
IP (Internet Protocol): Giao thức Internet, cho phép các thiết bị giao tiếp qua mạng.

Địa chỉ IP: Một chuỗi số duy nhất được gán cho mỗi thiết bị để định danh trong mạng.

Cấu trúc: Địa chỉ IP gồm 2 phần:
- Network ID: Xác định mạng mà thiết bị thuộc về.
- Host ID: Xác định thiết bị cụ thể trong mạng đó.

### 📙Vai trò của định địa chỉ IP

Định danh thiết bị: Mỗi thiết bị có một địa chỉ IP duy nhất để phân biệt.

Định tuyến: Địa chỉ IP nguồn và đích trong gói tin giúp xác định đường đi qua mạng.

Giao tiếp: Địa chỉ IP cho phép các thiết bị giao tiếp với nhau trong mạng LAN hoặc qua Internet.

### 📙Phân loại địa chỉ IP

Địa chỉ IPv4

- IPv4 được chia thành 5 lớp: A, B, C, D, và E. Trong đó:
    - Lớp A, B, C: Sử dụng cho mục đích thương mại.
    - Lớp D: Sử dụng cho multicast (truyền tin nhóm).
    - Lớp E: Dành riêng cho mục đích nghiên cứu.

| Lớp | Dải địa chỉ                 | Network ID | Host ID | Số mạng con | Thiết bị/ mạng |
| --- | --------------------------- | ---------- | ------- | ----------- | -------------- |
| A   | 0.0.0.0 - 127.255.255.255   | 8 bit      | 24 bit  | 2⁷          | 16 triệu       |
| B   | 128.0.0.0 - 191.255.255.255 | 16 bit     | 16 bit  | 2¹⁴         | 65 nghìn       |
| C   | 192.0.0.0 - 223.255.255.255 | 24 bit     | 8 bit   | 2²¹         | 256            |
| D   | 224.0.0.0 - 239.255.255.255 | N/A        | N/A     | N/A         | Multicast      |
| E   | 240.0.0.0 - 255.255.255.255 | N/A        | N/A     | N/A         | Nghiên cứu     |

Địa chỉ Private và Public

- Private IP: Sử dụng trong mạng nội bộ, không truy cập trực tiếp được từ Internet.
    - Lớp A: `10.0.0.0 - 10.255.255.255`
    - Lớp B: `172.16.0.0 - 172.31.255.255`
    - Lớp C: `192.168.0.0 - 192.168.255.255`

- Public IP: Sử dụng để truy cập Internet. Do tổ chức IANA quản lý và phân phối.

Địa chỉ đặc biệt

- Loopback address: `127.0.0.1` dùng để kiểm tra thiết bị nội bộ.
- Broadcast address: Dùng để gửi dữ liệu đến tất cả thiết bị trong mạng (ví dụ: `192.168.1.255`).
- APIPA (Automatic Private IP Addressing): `169.254.0.0 - 169.254.255.255` tự động gán khi không tìm được DHCP.

### 📙Gán địa chỉ IP

Tĩnh (Static):
- Địa chỉ IP được gán cố định bởi quản trị viên.
- Phù hợp cho các máy chủ, router hoặc thiết bị yêu cầu địa chỉ cố định.

Động (Dynamic):
- Địa chỉ IP được gán tự động bởi DHCP (Dynamic Host Configuration Protocol).
- Phù hợp cho các thiết bị thông thường trong mạng.

### 📙Subnet Mask, Subnetting

#### 📘Subnet Mask là gì?

**Subnet Mask (Mặt nạ mạng con)** là một giá trị được dùng để phân chia địa chỉ IP thành **phần mạng (Network)** và **phần host (Host)**.

Một Subnet Mask thường đi kèm với địa chỉ IP và giúp xác định:
- Phần mạng: Các thiết bị cùng nằm trong mạng này.
- Phần host: Các thiết bị cụ thể trong mạng đó.

#### 📘Vai trò của Subnet Mask

**Xác định phần mạng**: Giúp phân biệt thiết bị nào cùng nằm trong một mạng.

**Chia nhỏ mạng**: Subnet Mask được sử dụng để chia một mạng lớn thành các mạng con (subnet).

**Định tuyến**: Router dựa vào Subnet Mask để quyết định cách chuyển tiếp gói tin đến đúng mạng.

#### 📘Subnetting là gì?

Subnetting (Chia nhỏ mạng) là quá trình chia một mạng lớn thành nhiều mạng con nhỏ hơn để:
- Sử dụng tài nguyên địa chỉ IP hiệu quả hơn.
- Tăng cường bảo mật và phân đoạn mạng.
- Giảm lưu lượng trong mỗi mạng con, cải thiện hiệu suất.

#### 📘Cách hoạt động của Subnetting

Subnetting sử dụng Subnet Mask để chia địa chỉ IP thành:
- Phần mạng: Giữ nguyên.
- Phần subnet: Dùng để tạo các mạng con.
- Phần host: Dùng để xác định thiết bị trong mạng con.

Ví dụ cơ bản
- Địa chỉ IP: `192.168.1.0/24`
- Subnet Mask ban đầu: `255.255.255.0`
- `/24` nghĩa là 24 bit đầu là phần mạng, còn 8 bit là phần host.
- Có thể chứa: $2^8 − 2 = 254$ thiết bị (trừ 2 địa chỉ đặc biệt: broadcast và network ID).

Subnetting chia mạng
- Giả sử chia mạng thành 4 mạng con.
- Số bit cần mượn từ phần host để tạo subnet: $2^n ≥ 4 ⇒ n = 2$.
- Subnet Mask mới: `255.255.255.192` hoặc `/26` (24 + 2 bit).

| Subnet | Địa chỉ IP Subnet | Phạm vi địa chỉ               | Broadcast Address |
| ------ | ----------------- | ----------------------------- | ----------------- |
| 1      | 192.168.1.0/26    | 192.168.1.1 - 192.168.1.62    | 192.168.1.63      |
| 2      | 192.168.1.64/26   | 192.168.1.65 - 192.168.1.126  | 192.168.1.127     |
| 3      | 192.168.1.128/26  | 192.168.1.129 - 192.168.1.190 | 192.168.1.191     |
| 4      | 192.168.1.192/26  | 192.168.1.193 - 192.168.1.254 | 192.168.1.255     |

#### 📘Công thức tính Subnetting

Tính số subnet
- Công thức: $𝑆=2^n$
- n: Số bit mượn từ phần host.
- S: Số subnet tạo ra.

Tính số host trong mỗi subnet
- Công thức: $𝐻 = 2^ℎ − 2$
- ℎ: Số bit còn lại dành cho phần host.
- 𝐻: Số host khả dụng trong mỗi subnet.

Tính Subnet Mask
- Công thức: $𝑆𝑢𝑏𝑛𝑒𝑡𝑀𝑎𝑠𝑘 = 32 − (số bit phần hót mới)$

#### 📘Ưu và nhược điểm của Subnetting

Ưu điểm:
- Tối ưu hóa tài nguyên: Sử dụng không gian địa chỉ IP hiệu quả.
- Cải thiện bảo mật: Tách biệt các mạng con, giảm rủi ro lan truyền tấn công.
- Giảm tắc nghẽn mạng: Hạn chế lưu lượng trong từng mạng con.

Nhược điểmđiểm:
- Tăng phức tạp: Quản lý các subnet đòi hỏi kỹ năng cao.
- Tốn tài nguyên: Số lượng subnet tăng có thể làm giảm hiệu quả nếu không được quản lý đúng.

### 📙CIDR (Classless Inter-Domain Routing)

CIDR là một cách biểu diễn địa chỉ IP linh hoạt, không giới hạn bởi lớp (classless). CIDR sử dụng một hậu tố `/` để chỉ số bit mạng.

Ví dụ: `192.168.1.0/24` thay vì `192.168.1.0 255.255.255.0`
- Địa chỉ CIDR: `192.168.1.0/24`
- `/24` chỉ rằng 24 bit đầu là phần mạng, 8 bit còn lại là phần host.

## 📚Giao thức ICMP (Internet Control Message Protocol)

ICMP (Internet Control Message Protocol) là một giao thức thuộc tầng mạng trong bộ giao thức TCP/IP, được sử dụng để gửi các thông báo lỗi, trạng thái hoặc thông tin giữa các thiết bị mạng (như router, host).

ICMP không dùng để truyền dữ liệu ứng dụng mà hỗ trợ vận hành mạng bằng cách cung cấp phản hồi về các vấn đề trong giao tiếp mạng.

### 📙Chức năng của ICMP

Chẩn đoán lỗi:
- Báo lỗi khi gói tin không thể được truyền đến đích (ví dụ: không tìm thấy đích, TTL hết hạn).
- Thông báo cho nguồn về lý do gói tin không thể được xử lý.

Cung cấp thông tin:
- Thông tin trạng thái về hoạt động mạng (như báo hiệu mạng quá tải hoặc không khả dụng).
- Dùng trong các công cụ chẩn đoán như `ping` và `traceroute`.

### 📙Cấu trúc gói tin ICMP

Một gói tin ICMP có cấu trúc đơn giản, thường gồm các phần:
- Type (Loại thông điệp): Xác định loại thông điệp ICMP (ví dụ: báo lỗi, yêu cầu echo).
- Code (Mã): Cung cấp thêm chi tiết cho loại thông điệp.
- Checksum (Kiểm tra lỗi): Dùng để kiểm tra tính toàn vẹn của gói tin ICMP.
- Thông tin bổ sung: Phụ thuộc vào loại thông điệp (ví dụ: địa chỉ IP lỗi, TTL)

Các loại thông điệp ICMP phổ biến
| Type | Code | Chức năng                                          |
| ---- | ---- | -------------------------------------------------- |
| 0    | 0    | Echo Reply (Phản hồi từ lệnh ping).                |
| 3    | 0-15 | Destination Unreachable (Đích không thể truy cập). |
| 8    | 0    | Echo Request (Yêu cầu từ lệnh ping).               |
| 11   | 0-1  | Time Exceeded (TTL hết hạn).                       |
| 5    | 0-3  | Redirect (Chuyển hướng gói tin đến router khác).   |

### 📙Ứng dụng thực tế của ICMP

Công cụ Ping:
- Gửi gói tin ICMP Echo Request đến một thiết bị và nhận Echo Reply.
- Kiểm tra kết nối mạng và thời gian phản hồi (round-trip time).

Công cụ Traceroute:
- Sử dụng ICMP Time Exceeded để xác định đường đi của gói tin qua các router.

Chẩn đoán và xử lý lỗi mạng:
- Phát hiện và khắc phục các vấn đề như mạng bị quá tải, router không khả dụng, hoặc TTL hết hạn.

### 📙ICMP trong IPv4 và IPv6

ICMPv4: Được dùng trong IPv4 với các thông báo truyền thống.

ICMPv6: Được dùng trong IPv6, ngoài các chức năng cơ bản, nó còn hỗ trợ các tính năng mới như:
- Neighbor Discovery Protocol (NDP).
- Thông báo Multicast Listener Discovery (MLD).

## 📚Routing Algorithms (Thuật toán định tuyến)

**Thuật toán định tuyến** là các phương pháp được sử dụng để tìm đường đi tốt nhất (hoặc hiệu quả nhất) giữa các thiết bị trong mạng từ nguồn đến đích. Chúng là thành phần cốt lõi của các **giao thức định tuyến** và quyết định cách các gói tin được chuyển tiếp qua mạng.

### 📙Mục tiêu của thuật toán định tuyến

**Tối ưu hóa đường đi**: Tìm đường dẫn nhanh nhất, ngắn nhất hoặc hiệu quả nhất.

**Đảm bảo độ tin cậy**: Đảm bảo gói tin luôn đến đích ngay cả khi có sự cố trên đường.

**Hiệu quả tài nguyên**: Giảm thiểu việc sử dụng băng thông và tài nguyên mạng.

**Thích nghi**: Phản ứng nhanh với các thay đổi trong cấu trúc mạng hoặc trạng thái mạng.

### 📙Phân loại thuật toán định tuyến

#### 📘Theo cấu trúc

Thuật toán tĩnh (Static Routing):
- Đường đi được cấu hình trước, cố định và không thay đổi theo thời gian.
- Thường dùng trong các mạng nhỏ hoặc đơn giản.
- Ưu điểm: Dễ cấu hình, không tốn nhiều tài nguyên.
- Nhược điểm: Không linh hoạt khi mạng thay đổi.
- Ví dụ: Static Routes trong router.

Thuật toán động (Dynamic Routing):
- Tự động thay đổi đường đi dựa trên trạng thái hiện tại của mạng.
- Sử dụng các giao thức định tuyến động như OSPF, RIP, hoặc BGP.
- Ưu điểm: Linh hoạt, phản ứng nhanh với sự thay đổi.
- Nhược điểm: Phức tạp hơn, tốn tài nguyên hơn.

#### 📘Theo phạm vi hoạt động

Thuật toán tập trung (Centralized Routing):
- Một thiết bị trung tâm có thông tin toàn bộ mạng và quyết định đường đi.
- Nhược điểm: Điểm lỗi duy nhất (single point of failure).

Thuật toán phân tán (Distributed Routing):
- Mỗi nút trong mạng tự ra quyết định dựa trên thông tin cục bộ và thông điệp từ các nút lân cận.
- Tính mở rộng cao và không có điểm lỗi duy nhất.

#### 📘Theo phương pháp tối ưu hóa

Thuật toán khoảng cách (Distance Vector):
- Mỗi router duy trì một bảng định tuyến, chỉ chứa thông tin về khoảng cách và hướng đến các đích.
- Router chia sẻ thông tin định tuyến với các router lân cận định kỳ.
- Ưu điểm: Dễ triển khai.
- Nhược điểm: Hội tụ chậm, dễ gặp vấn đề vòng lặp định tuyến (routing loop).
- Ví dụ: RIP (Routing Information Protocol).

Thuật toán trạng thái liên kết (Link State):
- Mỗi router có thông tin đầy đủ về toàn bộ mạng (dựa trên trạng thái của các liên kết).
- Dựa vào thuật toán Dijkstra để tìm đường đi ngắn nhất.
- Ưu điểm: Hội tụ nhanh, hiệu quả hơn.
- Nhược điểm: Yêu cầu nhiều tài nguyên tính toán.
- Ví dụ: OSPF (Open Shortest Path First).

Thuật toán lai (Hybrid):
-  Kết hợp các đặc điểm của Distance Vector và Link State.
-  Ví dụ: EIGRP (Enhanced Interior Gateway Routing Protocol).

### 📙Các thuật toán định tuyến phổ biến

| Thuật toán     | Đặc điểm                                                                                        |
| -------------- | ----------------------------------------------------------------------------------------------- |
| Dijkstra       | Tìm đường đi ngắn nhất từ một nút đến tất cả các nút khác trong mạng (sử dụng trong OSPF).      |
| Bellman-Ford   | Sử dụng trong thuật toán Distance Vector (như RIP), cho phép xử lý chi phí âm.                  |
| Floyd-Warshall | Tìm đường đi ngắn nhất giữa mọi cặp nút (ít dùng cho mạng động vì tính toán nặng).              |
| Path Vector    | Được sử dụng trong BGP (Border Gateway Protocol) để xác định đường đi giữa các hệ thống tự trị. |

### 📙So sánh Distance Vector và Link State

| Tiêu chí                   | Distance Vector                         | Link State                            |
| -------------------------- | --------------------------------------- | ------------------------------------- |
| Kiến thức mạng             | Chỉ biết khoảng cách và hướng đến đích. | Biết trạng thái đầy đủ của toàn mạng. |
| Chia sẻ thông tin          | Định kỳ chia sẻ với router lân cận.     | Phát sóng thông tin đến toàn mạng.    |
| Hội tụ (Convergence)       | Chậm.                                   | Nhanh hơn.                            |
| Tài nguyên yêu cầu         | Ít (tính toán và bộ nhớ thấp).          | Cao (nhiều tài nguyên hơn).           |
| Vấn đề vòng lặp định tuyến | Dễ xảy ra.                              | Ít xảy ra.                            |

### 📙Giao thức định tuyến phổ biến

RIP (Routing Information Protocol):
- Sử dụng thuật toán Distance Vector.
- Phù hợp với mạng nhỏ, hội tụ chậm.
- Hạn chế: Giới hạn 15 hops.

OSPF (Open Shortest Path First):
- Sử dụng thuật toán Link State.
- Tính mở rộng cao, hội tụ nhanh.
- Thường dùng trong các mạng lớn.

BGP (Border Gateway Protocol):
- Sử dụng thuật toán Path Vector.
- Được sử dụng để định tuyến giữa các hệ thống tự trị (Autonomous Systems).

EIGRP (Enhanced Interior Gateway Routing Protocol):
- Giao thức định tuyến lai, nhanh và hiệu quả hơn RIP.

## 📚Routing in the Internet (Định tuyến trên Internet)

## 📚Multicast Routing (Định tuyến đa hướng)

## 📚Tầng liên kết (Link Layer)

Tầng liên kết (Link Layer) chịu trách nhiệm về việc truyền dữ liệu qua một liên kết vật lý giữa hai thiết bị trong cùng một mạng cục bộ (Local Area Network - LAN).

### 📙Vai trò của tầng liên kết

Cung cấp các cơ chế truyền dữ liệu tin cậy giữa các thiết bị trong cùng một mạng.

Đóng gói dữ liệu từ tầng trên (tầng mạng) vào frame (khung dữ liệu).

Điều khiển truy cập phương tiện (Medium Access Control - MAC) để đảm bảo rằng nhiều thiết bị có thể chia sẻ môi trường truyền dẫn (như cáp hoặc sóng radio) một cách hiệu quả.

Phát hiện và sửa lỗi trong quá trình truyền dữ liệu.

### 📙Thành phần chính của tầng liên kết

LLC (Logical Link Control):
- Điều khiển luồng dữ liệu giữa các thiết bị.
- Cung cấp giao diện với tầng mạng và quản lý các giao thức liên quan.

MAC (Media Access Control):
- Quản lý việc truy cập môi trường truyền dẫn.
- Gán địa chỉ MAC cho các thiết bị để định danh chúng trong mạng.

### 📙Hoạt động của tầng liên kết

Đóng gói dữ liệu:
- Dữ liệu từ tầng mạng (gói tin IP) được đóng gói vào khung dữ liệu (frame).
- Thêm địa chỉ MAC nguồn và đích vào header của frame.

Truyền dữ liệu:
- Dữ liệu được gửi qua môi trường vật lý (cáp mạng, sóng không dây).
- Tầng MAC đảm bảo rằng chỉ một thiết bị truyền dữ liệu tại một thời điểm (giải quyết xung đột truyền).

Phát hiện và sửa lỗi:
- Sử dụng các phương pháp kiểm tra lỗi như CRC để đảm bảo dữ liệu không bị hỏng trong quá trình truyền.
- Nếu phát hiện lỗi, tầng liên kết có thể yêu cầu truyền lại dữ liệu (nếu giao thức cho phép).

Nhận dữ liệu:
- Thiết bị nhận kiểm tra địa chỉ MAC đích của frame.
- Nếu địa chỉ MAC trùng khớp, frame sẽ được chuyển lên tầng mạng.

### 📙Giao thức tầng liên kết

Một số giao thức phổ biến ở tầng liên kết bao gồm:
- Ethernet: Giao thức mạng LAN phổ biến nhất.
- Wi-Fi (802.11): Giao thức mạng không dây.
- PPP (Point-to-Point Protocol): Được sử dụng trong kết nối điểm-điểm (ví dụ: kết nối Internet qua modem).
- Frame Relay: Sử dụng trong mạng diện rộng (WAN).
- ATM (Asynchronous Transfer Mode): Một công nghệ mạng tốc độ cao.

### 📙Các vấn đề phổ biến ở tầng liên kết

Xung đột truy cập: Khi nhiều thiết bị cố gắng truyền dữ liệu cùng lúc (đặc biệt trong Ethernet hoặc Wi-Fi).

Lỗi trong truyền dữ liệu: Dữ liệu có thể bị hỏng do nhiễu hoặc lỗi phần cứng.

Tắc nghẽn mạng cục bộ: Khi có quá nhiều thiết bị trong cùng một mạng LAN, hiệu năng có thể giảm.

## 📚Frame (khung dữ liệu)

**Frame** là đơn vị dữ liệu cơ bản được sử dụng ở tầng liên kết (Link Layer) trong mô hình OSI và TCP/IP. Nó bao gồm thông tin điều khiển cần thiết để truyền dữ liệu qua một liên kết vật lý từ thiết bị nguồn đến thiết bị đích trong mạng.

Một frame bao gồm:
- Header: Chứa thông tin điều khiển, địa chỉ MAC nguồn và đích.
- Payload: Dữ liệu từ tầng mạng (thường là một gói tin IP).
- Trailer: Thường chứa thông tin kiểm tra lỗi (CRC - Cyclic Redundancy Check).

## 📚Địa chỉ MAC

**Địa chỉ MAC** là một địa chỉ vật lý duy nhất được gán cho mỗi **card mạng (Network Interface Card - NIC)** khi thiết bị được sản xuất. Đây là địa chỉ ở tầng liên kết dữ liệu (Link Layer) trong mô hình OSI, được sử dụng để nhận diện các thiết bị trong mạng cục bộ (LAN hoặc WAN).

### 📙Cấu trúc của Địa chỉ MAC

Địa chỉ MAC có độ dài 48-bit (6 byte), thường được biểu diễn dưới dạng 12 ký tự hexadecimal và được chia thành hai phần:

- OUI (Organizationally Unique Identifier): 24-bit đầu tiên (3 byte): Xác định nhà sản xuất thiết bị. VD: `00:1A:2B`: Dell, `68:5B:35`: Cisco

- NIC Specific: 24-bit cuối (3 byte): Là số duy nhất do nhà sản xuất gán cho từng thiết bị.

- Cách biểu diễn: Địa chỉ MAC thường được viết theo các định dạng sau:
    - Hexadecimal với dấu hai chấm (:): `00:1A:2B:3C:4D:5E`
    - Hexadecimal với dấu gạch ngang (-): `00-1A-2B-3C-4D-5E`

### 📙Đặc điểm của Địa chỉ MAC

**Duy nhất**: Mỗi thiết bị mạng đều có một địa chỉ MAC duy nhất.

**Cố định**: Địa chỉ MAC được gán trong quá trình sản xuất và thường không thay đổi. Tuy nhiên, một số thiết bị cho phép "thay đổi" địa chỉ MAC (MAC Spoofing).

**Tầm cục bộ**: Chỉ được sử dụng trong mạng cục bộ (LAN) để truyền dữ liệu giữa các thiết bị.

### 📙Vai trò của Địa chỉ MAC

**Xác định thiết bị**: Địa chỉ MAC giúp nhận diện thiết bị khi gửi và nhận dữ liệu trong mạng LAN.

**Truyền dữ liệu**: Tầng liên kết sử dụng địa chỉ MAC để truyền các khung dữ liệu (frames) giữa các thiết bị trong mạng cục bộ.

**Kiểm soát truy cập**: Địa chỉ MAC thường được sử dụng trong các hệ thống kiểm soát truy cập (ví dụ: lọc MAC trong router).

### 📙Quá trình sử dụng Địa chỉ MAC

Gửi dữ liệu:
- Thiết bị nguồn gắn địa chỉ MAC của mình (MAC nguồn) và địa chỉ MAC của thiết bị nhận (MAC đích) vào frame.

Chuyển dữ liệu qua switch:
- Switch trong mạng LAN sử dụng địa chỉ MAC để chuyển frame đến thiết bị nhận dựa trên bảng địa chỉ MAC (MAC Address Table).

Nhận dữ liệu:
- Thiết bị đích kiểm tra MAC đích trong frame.
- Nếu địa chỉ MAC trùng khớp, thiết bị sẽ xử lý dữ liệu.

### 📙So sánh Địa chỉ MAC và Địa chỉ IP
| Đặc điểm       | Địa chỉ MAC                         | Địa chỉ IP                                  |
| -------------- | ----------------------------------- | ------------------------------------------- |
| Tầng hoạt động | Tầng liên kết (Link Layer)          | Tầng mạng (Network Layer)                   |
| Độ dài         | 48-bit (6 byte)                     | IPv4: 32-bit; IPv6: 128-bit                 |
| Mục đích       | Xác định thiết bị trong mạng cục bộ | Xác định vị trí thiết bị trên mạng toàn cầu |
| Tĩnh/Dynamic   | Thường cố định (hardware address)   | Có thể thay đổi (dynamic address)           |
| Phạm vi        | Mạng cục bộ (LAN)                   | Mạng toàn cầu (WAN)                         |

### 📙Ứng dụng của Địa chỉ MAC

**Lọc MAC**: Nhiều router hoặc switch cho phép cấu hình lọc MAC để giới hạn quyền truy cập mạng.

**Theo dõi thiết bị**: Địa chỉ MAC có thể được sử dụng để theo dõi hoặc nhận diện thiết bị trong mạng.

**Chẩn đoán mạng**: Sử dụng địa chỉ MAC để xác định lỗi trong mạng LAN.

### 📙Lưu ý

**MAC Spoofing**: Kỹ thuật thay đổi địa chỉ MAC để giả mạo thiết bị khác.

**Sử dụng trong ARP**: Địa chỉ MAC được sử dụng trong giao thức ARP để ánh xạ địa chỉ IP sang địa chỉ MAC trong mạng.

## 📚Chức năng và dịch vụ của tầng liên kết

## 📚Các giao thức tầng liên kết

## 📚Phát hiện lỗi và sửa lỗi

## 📚Multiple Access Protocols (Các giao thức truy cập nhiều nút)

## 📚Mạng LAN và Ethernet

## 📚Switching và Frame Forwarding

## 📚Virtual LANs (VLANs)

## 📚Spanning Tree Protocol (STP)

## 📚Mạng không dây (Wireless Networks)

## 📚PPP (Point-to-Point Protocol)

## 📚ATM (Asynchronous Transfer Mode)








---
---

## 💡Tổng quan quy trình hoạt động trong mạng máy tính

Khi dữ liệu được truyền từ máy nguồn đến máy đích qua một mạng máy tính, dữ liệu này sẽ đi qua các tầng khác nhau của mô hình **OSI (Open Systems Interconnection)** hoặc mô hình **TCP/IP**. Quá trình này được gọi là **encapsulation** và **decapsulation**, và tại mỗi tầng sẽ có những chức năng riêng để xử lý dữ liệu.

### 📙Máy nguồn (Sender)
Tầng 7: Application Layer (Tầng Ứng dụng)
    
- Tại tầng ứng dụng, dữ liệu bắt nguồn từ các ứng dụng mà người dùng sử dụng (ví dụ: trình duyệt web, email client, hoặc ứng dụng truyền file). 
- Ví dụ, khi bạn gửi một email, nội dung của email sẽ được chuẩn bị tại tầng ứng dụng. 
- Các giao thức phổ biến ở tầng này bao gồm HTTP, SMTP, FTP, DNS, v.v.

Tầng 6: Presentation Layer (Tầng Trình bày)

- Tầng này chịu trách nhiệm chuyển đổi định dạng dữ liệu (nếu cần), chẳng hạn như mã hóa, nén hoặc giải mã dữ liệu. 
- Ví dụ, nếu dữ liệu cần được mã hóa trước khi truyền, tầng này sẽ thực hiện việc đó. 
- Nó đảm bảo rằng dữ liệu từ máy nguồn có thể được trình bày chính xác tại máy đích.

Tầng 5: Session Layer (Tầng Phiên)
    
- Tầng này thiết lập, quản lý và kết thúc các phiên kết nối giữa hai máy. Nó giúp duy trì trạng thái của phiên kết nối, đảm bảo rằng hai ứng dụng có thể giao tiếp mà không bị gián đoạn.
- Tầng phiên cũng chịu trách nhiệm xử lý việc đồng bộ hóa và phục hồi nếu kết nối bị gián đoạn.

Tầng 4: Transport Layer (Tầng Giao vận/ Tầng Vận chuyển)
    
- Tầng giao vận chia nhỏ dữ liệu lớn thành các phân đoạn nhỏ hơn để dễ dàng truyền qua mạng. Hai giao thức phổ biến nhất ở tầng này là **TCP** (giao thức tin cậy, đảm bảo dữ liệu được nhận đầy đủ và đúng thứ tự) và **UDP** (giao thức không tin cậy, không có kiểm soát lỗi và không đảm bảo dữ liệu được nhận đầy đủ). 
- Nếu sử dụng TCP, tầng này sẽ đánh số các phân đoạn và đảm bảo mỗi phân đoạn được nhận đúng tại máy đích. Nó cũng xử lý việc điều khiển lưu lượng và kiểm soát lỗi.

Tầng 3: Network Layer (Tầng Mạng)

- Tầng mạng xử lý việc định tuyến dữ liệu từ máy nguồn đến máy đích qua các mạng trung gian. Tại tầng này, các phân đoạn từ tầng giao vận sẽ được gắn thêm một **địa chỉ IP (Internet Protocol)** để đảm bảo rằng dữ liệu được gửi đúng đến đích.
- Các thiết bị như router hoạt động tại tầng này để chuyển tiếp các gói dữ liệu dựa trên địa chỉ IP đích.

Tầng 2: Data Link Layer (Tầng Liên kết Dữ liệu)
    
- Tại tầng liên kết dữ liệu, các gói dữ liệu từ tầng mạng sẽ được đóng gói thành các frame và gắn thêm **địa chỉ MAC (Media Access Control)** để truyền qua liên kết vật lý (như cáp Ethernet hoặc Wi-Fi).
- Tầng này đảm bảo rằng dữ liệu có thể được truyền từ thiết bị nguồn đến thiết bị gần nhất trong mạng (ví dụ: từ máy tính đến switch hoặc router).

Tầng 1: Physical Layer (Tầng Vật lý)
    
- Đây là tầng thấp nhất, chịu trách nhiệm truyền tải dữ liệu thực tế dưới dạng các tín hiệu điện tử, quang học, hoặc sóng vô tuyến qua các phương tiện vật lý như cáp đồng, cáp quang, hoặc không dây. 
- Dữ liệu được chuyển đổi thành các tín hiệu tín hiệu bit 0 và 1 để truyền qua dây hoặc qua không gian không dây.

### 📙Trên đường truyền qua các thiết bị mạng

Khi dữ liệu di chuyển qua mạng, nó sẽ đi qua nhiều thiết bị trung gian như switch, router. Các switch hoạt động ở tầng liên kết dữ liệu (tầng 2), còn router hoạt động ở tầng mạng (tầng 3). Mỗi thiết bị sẽ xử lý dữ liệu và chuyển tiếp nó dựa trên các thông tin ở các tầng tương ứng.

### 📙Máy đích (Receiver)

Tầng 1: Physical Layer (Tầng Vật lý)

- Máy đích sẽ nhận các tín hiệu từ liên kết vật lý và chuyển đổi chúng trở lại thành các bit nhị phân.

Tầng 2: Data Link Layer (Tầng Liên kết Dữ liệu)

- Các frame từ tầng liên kết dữ liệu sẽ được xử lý, loại bỏ địa chỉ MAC, và chuyển tiếp dữ liệu lên tầng mạng nếu địa chỉ MAC trùng khớp với máy đích.

Tầng 3: Network Layer (Tầng Mạng)

- Tầng này sẽ kiểm tra địa chỉ IP của gói dữ liệu để xác nhận rằng nó được gửi đến đúng địa chỉ IP của máy đích. Sau đó, nó sẽ loại bỏ địa chỉ IP và chuyển tiếp dữ liệu lên tầng giao vận.

Tầng 4: Transport Layer (Tầng Giao vận)

- Nếu sử dụng giao thức TCP, tầng giao vận sẽ kiểm tra số thứ tự của các phân đoạn và đảm bảo rằng tất cả các phân đoạn được nhận đúng thứ tự. Nếu thiếu một phân đoạn, tầng này sẽ yêu cầu gửi lại. Sau khi hoàn thành, nó sẽ ghép các phân đoạn lại thành một dữ liệu hoàn chỉnh và chuyển lên tầng phiên.

Tầng 5-7: Session, Presentation, and Application Layers

- Dữ liệu sẽ tiếp tục được xử lý qua các tầng phiên và trình bày, như giải mã hoặc giải nén (nếu cần). Cuối cùng, dữ liệu sẽ đến tầng ứng dụng, nơi ứng dụng như trình duyệt web hoặc email client sẽ hiển thị nội dung cho người dùng.

### 📙Lưu ý

| Tầng    | Application Layer                        | Tầng giao vận (Transport Layer)                                                         | Tầng mạng (Network Layer)                            | Tầng liên kết dữ liệu (Data Link Layer)                     | Tầng vật lý (Physical Layer) |
| ------- | ---------------------------------------- | --------------------------------------------------------------------------------------- | ---------------------------------------------------- | ----------------------------------------------------------- | ---------------------------- |
| Dữ liệu | Dữ liệu tầng ứng dụng (Application Data) | Các phân đoạn (segments) hoặc gói (datagrams) với thông tin về cổng (Port) và giao thức | Gói tin (packet) chứa dữ liệu, địa chỉ IP nguồn/đích | Các khung (frames) chứa địa chỉ MAC, địa chỉ IP, và dữ liệu | Tín hiệu vật lý              |






















































































