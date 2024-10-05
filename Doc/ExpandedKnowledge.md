# EXEPANDED KNOWLEDGE

## BOM (Byte order mark)

## File JSON

## File XML

## File INI

## URI, URN, URL

### URI

**URI (Uniform Resource Identifier)** là một chuỗi ký tự để định vị tài nguyên (tài nguyên đó ở đâu, là gì trên internet). Các tài nguyên có để là tài liệu (document - text, html ...), hình ảnh (image) ..., tài nguyên chính là mục tiêu của HTTP Request. URI xác định tài nguyên bằng cách định vị bằng vị trí (locator - địa chỉ) hoặc bằng tên, hoặc cả hai. Từ đó URI phân ra làm hai loại là URL và URN

### URN

**URN (Uniform Resource Name)** - Định danh tài nguyên thống nhất: là một loại URI, xác định tài nguyên thông qua tên hợp lệ, duy nhất (các tài nguyên ở trường hợp này có thể là bất kỳ thứ gì). Cấu trúc của URN thường có dạng: `URN:NID:NSS`

- `URN` chuỗi cho biết đây là URN

- `NID` không gian tên (namespace) do IANA cấp (Internet Assigned Numbers Authority).

- `NSS` chuỗi xác định đối tượng cụ thể

**_Có thể đọc thêm các [NID](https://www.iana.org/assignments/urn-namespaces/urn-namespaces.xhtml)_**

### URL

**URL (Uniform Resource Locator)** - định vị tài nguyên thống nhất, nó là địa chỉ xác định tài nguyên trên internet, nó là một loại URI được dùng trong các siêu văn bản (Hypertext - HTML) và giao thức HTTP, nó được sử dụng bởi các browser (client) để lấy về hay cập nhật tài nguyên trên web. URL là địa chỉ xác định tài nguyên (trang HTML, file JS, file CSS, file ảnh ....) duy nhất trên Web.

`http:// site.yourdomain.com /path/to/page/ ?a=1&b=price #section`

Cấu trúc

- `scheme` ví dụ https://, http://, ftp:// ... cho biết giao thức sử dụng để yêu cầu tài nguyên

- `host` hoặc `domain` có thể có `port`, không cần chỉ ra nếu sử dụng cổng tiêu chuẩn (cổng 80 với http và 443 với https)

- `path` đường dẫn trên server dẫn tới tài nguyên, hiện nay không hẳn là một đường dẫn thực mà có thể là một logic ánh xạ bởi web server

- `query` là chuỗi truy vấn, nó chứa các tham số ví dụ ?a=1&b=price, bắt đầu chuỗi query là dấu ? mỗi tham số thường gồm key=value, các tham số cách nhau bởi &

- `fragment` (ví dụ `#section`), trỏ đến một phần củ thể trong tài nguyên, ví dụ một vị trí nào đó trong văn bản HTML.

Đường dẫn tương đối

- Ngoài địa chỉ URL tuyệt đối, còn có thể sử dụng địa chỉ URL tương đối - địa chỉ này không cần có scheme, host, nó cho biết tài nguyên nằm cùng trên một host của tài nguyên ban đầu, nó thường bắt đầu bằng /

- Các loại

  - `/path` : Nếu địa chỉ tương đối bắt đầu bằng `/` thì nó cùng HOST, SCHEME với URL ban đầu

  - `path` : Địa chỉ tương đối không bắt đầu bởi `/` thì tài nguyên cùng thư mục chứa tài nguyên gốc.

  - `../path` : Kí hiệu `../` cho biết địa chỉ bắt đầu lùi một cấp thư mục với tài nguyên chứa nó

  - Tương tự có thể trở về gốc 2 cấp : `../../path`

_❗Nguyên tắc này cũng có thể áp dụng với URL tới tài nguyên cục bộ (trên máy)_
