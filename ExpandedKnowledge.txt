#####-----EXEPANDED KNOWLEDGE-----#####

### BOM (Byte order mark)

### File JSON


### File XML


### File INI


### Danh sách tên màu và mã hex tương ứng (148)
    black: #000000          silver: #C0C0C0             gray: #808080               grey: #808080               white: #FFFFFF                  maroon: #800000                 red: #FF0000                purple: #800080
    fuchsia: #FF00FF        green: #008000              lime: #00FF00               olive: #808000              yellow: #FFFF00                 navy: #000080                   blue: #0000FF               teal: #008080
    aqua: #00FFFF           darkblue: #00008B           mediumblue: #0000CD         darkgreen: #006400          darkcyan: #008B8B               deepskyblue: #00BFFF            darkturquoise: #00CED1      mediumspringgreen: #00FA9A
    springgreen: #00FF7F    cyan: #00FFFF               midnightblue: #191970       dodgerblue: #1E90FF         lightseagreen: #20B2AA          forestgreen: #228B22            seagreen: #2E8B57           darkslategray: #2F4F4F
    darkslategrey: #2F4F4F  limegreen: #32CD32          mediumseagreen: #3CB371     turquoise: #40E0D0          royalblue: #4169E1              steelblue: #4682B4              darkslateblue: #483D8B      mediumturquoise: #48D1CC
    indigo: #4B0082         darkolivegreen: #556B2F     cadetblue: #5F9EA0          cornflowerblue: #6495ED     rebeccapurple: #663399          mediumaquamarine: #66CDAA       dimgray: #696969            dimgrey: #696969
    slateblue: #6A5ACD      olivedrab: #6B8E23          slategray: #708090          slategrey: #708090          lightslategray: #778899         lightslategrey: #778899         mediumslateblue: #7B68EE    lawngreen: #7CFC00
    chartreuse: #7FFF00     aquamarine: #7FFFD4         skyblue: #87CEEB            lightskyblue: #87CEFA       blueviolet: #8A2BE2             darkred: #8B0000                darkmagenta: #8B008B        saddlebrown: #8B4513
    darkseagreen: #8FBC8F   lightgreen: #90EE90         mediumpurple: #9370DB       darkviolet: #9400D3         palegreen: #98FB98              darkorchid: #9932CC             yellowgreen: #9ACD32        sienna: #A0522D    
    darkgray: #A9A9A9       darkgrey: #A9A9A9           lightblue: #ADD8E6          greenyellow: #ADFF2F        paleturquoise: #AFEEEE          lightsteelblue: #B0C4DE         powderblue: #B0E0E6         firebrick: #B22222    
    mediumorchid: #BA55D3   rosybrown: #BC8F8F          darkkhaki: #BDB76B          mediumvioletred: #C71585    indianred: #CD5C5C              peru: #CD853F                   chocolate: #D2691E          tan: #D2B48C  
    lightgrey: #D3D3D3      thistle: #D8BFD8            orchid: #DA70D6             goldenrod: #DAA520          palevioletred: #DB7093          crimson: #DC143C                gainsboro: #DCDCDC          plum: #DDA0DD
    burlywood: #DEB887      lightcyan: #E0FFFF          lavender: #E6E6FA           darksalmon: #E9967A         violet: #EE82EE                 palegoldenrod: #EEE8AA          lightcoral: #F08080         khaki: #F0E68C
    aliceblue: #F0F8FF      honeydew: #F0FFF0           azure: #F0FFFF              sandybrown: #F4A460         wheat: #F5DEB3                  beige: #F5F5DC                  whitesmoke: #F5F5F5         mintcream: #F5FFFA
    ghostwhite: #F8F8FF     salmon: #FA8072             antiquewhite: #FAEBD7       linen: #FAF0E6              lightgoldenrodyellow: #FAFAD2   oldlace: #FDF5E6                magenta: #FF00FF            deeppink: #FF1493    
    tomato: #FF6347         hotpink: #FF69B4            coral: #FF7F50              darkorange: #FF8C00         lightsalmon: #FFA07A            orange: #FFA500                 lightpink: #FFB6C1          pink: #FFC0CB
    gold: #FFD700           peachpuff: #FFDAB9          navajowhite: #FFDEAD        moccasin: #FFE4B5           bisque: #FFE4C4                 mistyrose: #FFE4E1              blanchedalmond: #FFEBCD     papayawhip: #FFEFD5        
    seashell: #FFF5EE       cornsilk: #FFF8DC           lemonchiffon: #FFFACD       floralwhite: #FFFAF0        snow: #FFFAFA                   lightyellow: #FFFFE0            ivory: #FFFFF0              orangered: #FF4500
    lightgray: #D3D3D3      darkgoldenrod: #B8860B      lavenderblush: #FFF0F5      brown: #A52A2A

### Giao thức HTTP
    - HTTP (HyperText Transfer Protocol) là giao thức truyền tải siêu văn bản, giao thức HTTP dựa trên giao thức TCP/IP nó cho phép lấy về các tài nguyên ví dụ như văn bản HTML, text, 
    video, ảnh ...

    - HTTP là nền tảng dùng để trao đổi dữ liệu cho các ứng dụng Web với mô hình Client/Server

    - Các yêu cầu (request hay HTTP Request) được tạo bởi client (thường là các Web browser như chrome, firefox ...) được gửi đến server http, server sẽ gửi lại dữ liệu (response hay 
    HTTP Response) để client nhận được.

    - Các request, response là các message có cấu trúc đơn giản gọi chung nó là các HTTP Message. HTTP Message có thể đọc được mà không nhất thiết phải có công cụ phân tích riêng biệt, 
    nó giảm đi sự phức tạp khi phát triển, kiểm tra ứng dụng. 

    - HTTP là phi trạng thái (stateless), có nghĩa không có mối liên hệ nào giữa hai yêu cầu được gửi đi, dù nó là thực hiện trên cùng một kế nối - đến cùng một server.

    - Do Http là stateless nên để cung cấp khả năng chia sẻ trạng thái giữa những request của phiên làm việc cần sử dụng tới HTTP Cookie, những dữ liệu nhằm duy trì trạng thái của phiên 
    làm việc, sẽ được thêm vào phần header của HTTP Message

    - HTTP Message
        + HTTP Message (Thông điệp HTTP) là các thông tin được trao đổi qua lại giữa client và server

        + Có 2 loại:
            * HTTP Request Message (Request) được gửi đi bởi client tới server - khi server nhận được nó biết phải thực hiện nhiệm vụ nào đó

            * HTTP Response Message (Response) là trả lời từ server về cho client

        + Các Phiên bản HTTP
            * HTTP/1.0 (Phát hành vào năm 1996) : HTTP/1.0 là phiên bản đầu tiên của giao thức HTTP được chính thức chuẩn hóa. Đặc điểm chính:
                / Kết nối ngắn (Non-persistent connections): Sau mỗi yêu cầu, kết nối giữa máy khách và máy chủ sẽ bị đóng. Điều này làm tăng thời gian kết nối khi có nhiều yêu cầu.
                
                / Header đơn giản: Mỗi yêu cầu chứa thông tin cơ bản như URL, phương thức (GET, POST), và dữ liệu gửi đi.
                
                / Không hỗ trợ tính năng nén hoặc kiểm soát bộ nhớ đệm.

            * HTTP/1.1 (Phát hành vào năm 1997) : HTTP/1.1 là phiên bản phổ biến nhất và đã tồn tại trong một thời gian dài. Những cải tiến so với HTTP/1.0:
                / Kết nối dài (Persistent connections): Kết nối được duy trì lâu hơn, giảm độ trễ bằng cách cho phép nhiều yêu cầu và phản hồi trong cùng một kết nối.
                
                / Pipeline: Cho phép gửi nhiều yêu cầu mà không phải đợi phản hồi của các yêu cầu trước.
                
                / Nén nội dung: Hỗ trợ nén để giảm kích thước dữ liệu truyền tải.
                
                / Kiểm soát bộ nhớ đệm (Caching): Hỗ trợ các header giúp cải thiện hiệu quả bộ nhớ đệm.
                
                / Host header: HTTP/1.1 thêm header "Host" để hỗ trợ nhiều tên miền trên cùng một máy chủ.

            * HTTP/2 (Phát hành vào năm 2015) : HTTP/2 đã mang lại nhiều cải tiến lớn so với HTTP/1.1, đặc biệt về tốc độ và hiệu suất:
                / Multiplexing: Cho phép nhiều yêu cầu được gửi đồng thời trên cùng một kết nối mà không phải chờ đợi. Điều này cải thiện hiệu suất đáng kể.
                
                / Nén header (Header compression): HTTP/2 sử dụng nén header (HPACK) để giảm kích thước các gói tin, tiết kiệm băng thông.
                
                / Server push: Máy chủ có thể gửi trước các tài nguyên mà nó dự đoán sẽ được yêu cầu, giảm thời gian chờ đợi cho người dùng.
                
                / Binary protocol: HTTP/2 sử dụng giao thức nhị phân thay vì văn bản như HTTP/1.x, giúp tăng hiệu suất và giảm độ phức tạp trong phân tích cú pháp.

            * HTTP/3 (Đang được triển khai, dựa trên QUIC) : HTTP/3 là phiên bản mới nhất của giao thức HTTP và là bước tiến lớn nhờ việc sử dụng QUIC thay vì TCP. QUIC là giao thức 
            truyền dữ liệu được phát triển bởi Google, với các đặc điểm chính:
                / QUIC thay thế TCP: QUIC là giao thức tầng truyền tải kết hợp giữa UDP và các tính năng của TCP (như quản lý phiên kết nối, kiểm soát lỗi), giảm thời gian thiết lập 
                kết nối và độ trễ.
                
                / Giảm độ trễ: HTTP/3 giảm thiểu độ trễ khi kết nối mới được thiết lập nhờ QUIC, phù hợp hơn với các ứng dụng di động hoặc mạng không ổn định.
                
                / Chống nghẽn kết nối (Head-of-line blocking): Nếu một gói tin bị mất trong HTTP/2 (TCP), tất cả các yêu cầu khác trên cùng kết nối sẽ phải chờ. QUIC khắc phục vấn đề 
                này bằng cách truyền tải không phụ thuộc theo dòng.
                
                / Cải thiện bảo mật: HTTP/3 tích hợp mã hóa từ đầu, giúp tăng cường bảo mật mà không cần thiết lập thủ công như trong các phiên bản trước.

            * So sánh tổng quát
                | Tính năng	            | HTTP/1.0	| HTTP/1.1	| HTTP/2	            | HTTP/3             |
                | Kết nối	            | Ngắn	    | Dài	    | Dài, nhiều yêu cầu	| Dài, nhiều yêu cầu |
                | Nén dữ liệu	        | Không	    | Có	    | Có (header)	        | Có                 |
                | Định dạng dữ liệu	    | Văn bản	| Văn bản	| Nhị phân	            | Nhị phân           |
                | Multiplexing	        | Không	    | Không	    | Có	                | Có                 |
                | Server Push	        | Không	    | Không	    | Có	                | Có                 |
                | Giao thức tầng dưới	| TCP	    | TCP	    | TCP	                | QUIC (trên UDP)    |
                | Bảo mật tích hợp	    | Không	    | Không	    | Không	                | Mã hóa mặc định    |

        + Cấu trúc chung
            * Dòng đầu tiên (một dòng): Cho biết thông tin yêu cầu hoặc trạng thái (thành công hay lỗi) của response.

            * Phần header (các dòng sau dòng đầu tiên trước một dòng trắng): Nó là một tập hợp các dòng chứa thông tin về HTTP Message, thông tin về phần body
                /// Đọc thêm tại https://en.wikipedia.org/wiki/List_of_HTTP_header_fields#General_format

            * Một dòng trắng cho biết phần thông tin (dòng đầu và header) đã gửi hết

            * Phần body chứa dữ liệu đính kèm với request (như HTML Form) hoặc nội dung văn bản đính kèm cùng response. Kích cỡ dữ liệu này (size) có được xác định bởi thông tin trong header

        + Cấu trúc HTTP Request Message
            * Dòng đầu tiên: Dòng này chứa thông tin để gửi tới server, dựa vào thông tin này mà server thực thi hành động phù hợp. Dòng này nó có chứa ba thông tin cách nhau bởi khoảng trắng
                POST /html/ HTTP/1.1

                / HTTP Method (Phương thức HTTP) là thành phần thứ nhất, nó có giá trị như POST, GET, PUT, DELETE. Nó cho biết yêu cầu cần được thực hiện trên server đối với một tài 
                nguyên nào đó, cụ thể như các phương thức:
                    GET cho biết Request chỉ cần lấy dữ liệu (tài nguyên).
                    POST được sử dụng để cho biết Request là chuyển dữ liệu lên server (thương HTTP Message trường hợp này có kèm dữ liệu như HTML Form ...)
                    PUT ghi đè (thay thế) tài nguyên nào đó bằng dữ liệu trong Request.
                    DELETE xóa tài nguyên

                / Địa chỉ URL - là thành phần thứ hai. Địa chỉ tài nguyên truy vấn, có thể là URL tương đối - tuyệt đối (kể cả cổng, nếu có cổng thì viết cổng sau ký hiệu :)

                / HTTP Version Thành phần thứ ba cho biết phiên bản HTTP

            * Header của Request: Các header có cấu trúc đó là một chuỗi là tên header tiếp theo là dấu : và giá trị cho header. Mỗi header được viết trên một dòng. Có rất nhiều loại 
            header (đã chuẩn hóa hoặc header do bạn tự đặt)

            * Body của Request: Chứa dữ liệu của Request (dữ liệu này có kiểu xác định ở header Content-Type và độ dài Content-Length), không phải mọi Request đều có body, dữ liệu body 
            thường là HTML Form hay JSON

        + Cấu trúc HTTP Response Message
            * Dòng đầu tiên: còn gọi là dòng trạng thái, nó chứa ba mẩu tin gồm
                / Phiên bản HTTP
                / Mã trả về như 200, 404, 301, 302 ...
                / Đoạn text ngắn giải thích mã ví dụ OK, Not Found, Moved Permanently ...

            * Header của Response: tương tự như header của Request

            * Body của Response: Chứa dữ liệu của Respone (dữ liệu này có kiểu xác định ở header Content-Type và độ dài Content-Length), không phải mọi Response đều có body

### URI, URN, URL
    - URI (Uniform Resource Identifier) là một chuỗi ký tự để định vị tài nguyên (tài nguyên đó ở đâu, là gì trên internet). Các tài nguyên có để là tài liệu (document - text, html ...), 
    hình ảnh (image) ..., tài nguyên chính là mục tiêu của HTTP Request. URI xác định tài nguyên bằng cách định vị bằng vị trí (locator - địa chỉ) hoặc bằng tên, hoặc cả hai. Từ đó URI 
    phân ra làm hai loại là URL và URN

    - URN
        + URN (Uniform Resource Name) - Định danh tài nguyên thống nhất: là một loại URI, xác định tài nguyên thông qua tên hợp lệ, duy nhất (các tài nguyên ở trường hợp này có thể 
        là bất kỳ thứ gì). Cấu trúc của URN thường có dạng: URN:NID:NSS
            * URN chuỗi cho biết đây là URN
            * NID không gian tên (namespace) do IANA cấp (Internet Assigned Numbers Authority). 
            * NSS chuỗi xác định đối tượng cụ thể 

            /// có thể đọc thêm các NID tại  https://www.iana.org/assignments/urn-namespaces/urn-namespaces.xhtml

    - URL
        + URL (Uniform Resource Locator) - định vị tài nguyên thống nhất, nó là địa chỉ xác định tài nguyên trên internet, nó là một loại URI được dùng trong các siêu văn bản 
        (Hypertext - HTML) và giao thức HTTP, nó được sử dụng bởi các browser (client) để lấy về hay cập nhật tài nguyên trên web. URL là địa chỉ xác định tài nguyên (trang HTML, 
        file JS, file CSS, file ảnh ....) duy nhất trên Web.
            http:// site.yourdomain.com /path/to/page/ ?a=1&b=price #section
        
        + Cấu trúc
            * scheme ví dụ https://, http://, ftp:// ... cho biết giao thức sử dụng để yêu cầu tài nguyên

            * host hoặc domain có thể có port, không cần chỉ ra nếu sử dụng cổng tiêu chuẩn (cổng 80 với http và 443 với https)

            * path đường dẫn trên server dẫn tới tài nguyên, hiện nay không hẳn là một đường dẫn thực mà có thể là một logic ánh xạ bởi web server

            * query là chuỗi truy vấn, nó chứa các tham số ví dụ ?a=1&b=price, bắt đầu chuỗi query là dấu ? mỗi tham số thường gồm key=value, các tham số cách nhau bởi &

            * fragment (ví dụ #section), trỏ đến một phần củ thể trong tài nguyên, ví dụ một vị trí nào đó trong văn bản HTML.
    - Đường dẫn tương đối
        + Ngoài địa chỉ URL tuyệt đối, còn có thể sử dụng địa chỉ URL tương đối - địa chỉ này không cần có scheme, host, nó cho biết tài nguyên nằm cùng trên một host của tài nguyên 
        ban đầu, nó thường bắt đầu bằng /

        +  Các loại
            * /path	: Nếu địa chỉ tương đối bắt đầu bằng / thì nó cùng HOST, SCHEME với URL ban đầu

            * path : Địa chỉ tương đối không bắt đầu bởi / thì tài nguyên cùng thư mục chứa tài nguyên gốc.

            * ../path : Kí hiệu ../ cho biết địa chỉ bắt đầu lùi một cấp thư mục với tài nguyên chứa nó

            * Tương tự có thể trở về gốc 2 cấp : ../../path

        !!! Nguyên tắc này cũng có thể áp dụng với URL tới tài nguyên cục bộ (trên máy)




