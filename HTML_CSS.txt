
!!! Hình dung cơ bản
	- HTML là khung sường
	- CSS là trang trí, phong cách
	- JavaScript là tính năng


#####-----HTML-----#####

*** HTML là gì?
	- HTML viết tắt của chữ HyperText Markup Language (ngôn ngữ đánh dấu siêu văn bản), nó được dùng để tạo ra các tài liệu hiện thị được trên trình duyệt

	- HTML sử dụng cách đánh dấu (markup) để chú thích cho các thành phần (phần tử HTML) như văn bản, hình ảnh ... các phần tử HTML tạo thành trang tài liệu hiện thị được 
	trong các trình duyệt. Có rất nhiều phần tử HTML như: <p>, <a>, <img>, <title>, <body> ...

	!!! Chỉ nội dung chứ không thi hành tác vụ, không phải là ngôn ngữ lập trình 

*** Web tĩnh là gì?
	- Các tài liệu HTML (trang HTML) có thể là các file (thường có phần mở rộng .html, .htm) được lưu trữ trên hệ thống file của máy chủ web (webserver), từ đó trình duyệt 
	truy cập đọc được và hiện thị.

*** Trang web động là gì?
	- Các trang HTML mà trình duyệt lấy về từ webserver được phát sinh bởi một ứng dụng chạy trên server (ứng dụng phát triển bằng các ngôn ngữ lập trình như PHP, C# ...).

*** Siêu văn bản (HyperText) là gì?
	- Ám chỉ sự liên kết giữa các trang, một trang HTML có liên kết tham chiếu đến một trang khác trên cùng một Website hay giữa các website.

### Thẻ (Tag)
	- Ngôn ngữ đánh dấu HTML nghĩa là sử dụng các thẻ(tag) để tạo ra các phần tử nhằm hình thành cấu trúc tài liệu HTML

	- Một thẻ thì có tên thẻ (không phân biệt chữ hoa, thường), sau đó nó sử dụng quy tắc đánh dấu để tạo phần tử
		<tagname>Nội dung</tagname>

	- <tagname>: gọi là mở thẻ tagname (HTML có hàng trăm thẻ như a, p, i, img, table ...), tùy thuộc vào loại thẻ mà có thể thiết lập thuộc tính cho phần tử HTML tạo ra
		<tagname thuoctinh1="giá-trị1", thuoctinhn="giá trị n">
	
	- Nội dung: Phần nội dung phần tử, tức là văn bản, hoặc các phần tử HTML khác nằm trong phần tử đang tạo ra.
	
	- </tagname>: Gọi là phần đóng thẻ HTML. Như vậy toàn bộ nội dung viết giữa mở thẻ và đóng thẻ nằm trong phần tử HTML tạo ra.

	- Có hai loại thẻ phân loại theo hình thức sử dụng
		+ Thẻ HTML chứa nội dung (có chứa nội dung, giữa mở thẻ và đóng thẻ, như thẻ <p>, <title>, <h1> ...)
		
		+ Thẻ HTML rỗng (chỉ mở thẻ, không đóng thẻ, không chứa nội dung, ví dụ như thẻ <br>, <img> ... tuy nhiên thẻ vẫn có thuộc tính)

### Thuộc tính 
	- Các thuộc tính nhằm thiết lập thêm thông tin cho các thẻ (phần tử HTML). Hầu hết thuộc tính phần tử HTML thiết lập bằng tên thuộc tính và giá trị đi cùng với nó

	- Các thuộc tính của phần tử HTML viết tại tại vị trí mở thẻ, giữa ký hiệu <tên-thẻ và ký hiệu >. Thuộc tính viết theo cặp : tên-thuộc-tính="giá trị"
		<p align="center">
              Đoạn văn được căn giữa trang.
        </p>

### Thuộc tính chung toàn cục
	- Thuộc tính toàn cục (global attribute) là các thuộc tính có thể đưa vào cho bất kỳ phần tử HTML nào, kể cả thuộc tính đó không có tác dụng gì với một số phần tử nhất định

	- Phần tử HTML khác nhau có thể có các thuộc tính khác nhau (thuộc tính này dùng được cho phần tử này nhưng chưa chắc đã dùng được cho phần tử khác). Do vậy, mỗi phần 
	tử cần xem xét các thuộc tính riêng của nó

	- class	
		+ Thiết lập một hoặc nhiều tên lớp cho phần tử. Các lớp này được dùng để CSS, Javascript lựa chọn phần tử.
			<a href="https://xuanthulab.net" class="link1 link2">HTML</a>

	- style	
		+ Viết mã CSS áp dụng ngay cho phần tử. Ví dụ phần tử P có cỡ chữ 18px (Đây là cách nhúng mã CSS dạng inline)
			<p style="font-size: 18px">Inline style sheet</p>

	- id	
		+ Thiết lập một định danh duy nhất cho phần tử HTML. Định danh này để tìm kiếm chọn phần tử trong DOM, cũng như để lựa chọn trong CSS.
			<p id="idphantup">Ví dụ</p>

	- accesskey	
		+ Chỉ ra một phím tắt kích hoạt phần tử.
			<a href="https://xuanthulab.net" accesskey="x">HTML</a>
			
	- contenteditable	
		+ Cho biết nội dung trong phần tử có thể soạn thảo biên tập lại hay không. Nếu true thì sẽ xuất hiện box soạn thảo cho phần tử
			<p contenteditable="true">Nội dung này soạn thảo được</p>

	- data-*	
		+ Thuộc tính thiết lập dữ liệu riêng cho phần tử, ký hiệu * là một tên tự đặt. data-* là chuẩn đặt tên thuộc tính dữ liệu dùng cho HTML5 
		Ví dụ phần tử đó có lưu một dữ liệu tên là abc, thì thuộc tính sẽ là data-abc. Sau này tại phần Javascript có thể đọc dữ liệu này theo tên abc, thông qua dataset của phần tử.
			<p data-abc="Đây là dữ liệu riêng">Ví dụ</p>d
			
	- raggable	
		+ Cho biết phần tử có thể kéo thả không (true, false, auto). Thuộc tính này liên quan đến sử dụng Javascript truy cập API kéo/thả. Xem Kéo / Thả trong HTML5
			<p draggable="true">Ví dụ</p>

	- hidden	
		+ Khi có thuộc tính này phần tử sẽ ẩn, có thể gán bằng true/false
			<p hidden>Ví dụ</p>

	- spellcheck	
		+ Cho trình duyệt biết có kiểm tra ngữ pháp phần tử này hay không
			<p spellcheck="true">Có kiểm tra ngữ pháp</p>

	- title	
		+ Thông tin thêm về phần tử, ví dụ để chuột lên phần tử thì hiện thông tin này - nó là tooltip
			<p title="Thông tin thêm">Đây là đoạn văn</p>

	- autofocus	
		+ Thuộc tính autofocus, để kích hoạt phần tử (đang nhận nhập liệu từ bàn phím), thường dùng với các phần tử input, textarea trong FORM. Xem HTML Form
			<input name="ip" autofocus />

### Mã ký tự HTML đặc biệt // bổ sung sau

## Chú thích 
	- Các chú thích trong HTML (comment) không hiện thị trên trình duyệt (trình duyệt bỏ qua), mục đích của chú thích là để mô tả, ghi chú, nhắc nhở về một đoạn mã nào 
	đó để sau này đọc lại có thể hiểu nhanh chóng
		<!-- nội dung -->

### Cấu trúc HTML
	- Một tài liệu (trang) HTML hoàn chỉnh có một thẻ gốc là <html>, mọi thẻ khác trình bày trong thẻ <html> này.
	
	- Trước thẻ <html> có đoạn text xác định nó là tài liệu HTML và phiên bản HTML
		<!DOCTYPE html>
		<html>
			<head>
				<title>Khoi ne!</title>
				<meta charset="UTF-8">
			</head>
			<body>
			
			</body>
		</html>

### Thẻ head
	- Thẻ <head> chứa các thành phần (phần tử HTML) hầu như là không hiện thị tới người dùng, chúng là các điều khiển, thiết lập giúp trang html được hiện thị theo một mục đích cụ thể

	!!! Một văn bản HTML chỉ dùng một thẻ <head>. Không phải mọi thẻ HTML đều có thể viết trong <head>

### Thẻ title
	- Thẻ <title> cần đặt trong thẻ <head>, nó thiết lập tiêu đề trang HTML, tiêu đề này hiện thị trên cửa sổ trình duyệt (tiêu đề tab). Mặc dù không bắt buộc nhưng mọi trang web nên có thẻ này
		<head>
			<title>Tiêu đề của trang</title>
		</head>

### Thẻ meta
	- Một trang HTML có thể đưa vào các thông tin mô tả cho trang, các thông tin này gọi là metadata (siêu dữ liệu)

	- Các dữ liệu này được trình duyệt phân tích và thực hiện một số tác vụ liên quan đến trang ... Hoặc là dữ liệu mà cách sử dụng nó do ứng dụng nào đó quy định mà bạn muốn áp dụng

	- Thẻ <meta> (là loại phần tử rỗng - chỉ mở thẻ - thiết lập dữ liệu qua các thuộc tính) cần đặt nằm trong thẻ <head>. Có rất nhiều loại dữ liệu metadata có thể thêm vào

	- Các loại metadata
		// bổ sung sau

### Thẻ body
	- Thẻ <body> nằm trong thẻ <html>, những thành phần hiện thị tới người dùng (đoạn văn, hình ảnh, liên kết ...) phải nằm trong thẻ này
		<!doctype html>
		<html>
			<head>
				... trình bày các thành phần không hiện thị ở đây
			</head>
			<body>
				... trình bày các thành phần hiện thị ở đây
			</body>
		</html>
	
	!!! Một trang HTML chỉ có 1 thẻ <body>

### Thẻ heading <h1> - <h6>
	- Trong một trang HTML (tài liệu) có thể phân chia ra thành nhiều đề mục (heading) với cấp độ khác nhau

	- Sử dụng các thẻ tạo đề mục (heading) có thể giúp cho người đọc (hoặc Search Engine) nhanh chóng nắm bắt được cấu trúc nội dung chính của bài viết (tài liệu HTML).
		<h1>This is heading 1</h1>
		<h2>This is heading 2</h2>
		<h3>This is heading 3</h3>
		<h4>This is heading 4</h4>
		<h5>This is heading 5</h5>
		<h6>This is heading 6</h6>

	!!! Sử dụng thẻ heading không chỉ với mục đích định dạng chữ to hơn, đậm hơn mà nó thể hiện cấu trúc phần quan trọng của trang, đây là nội dung mà Searchi Engine chỉ mục trang web

	!!! Phân chia đề mục phù hợp: Khi sử dụng cần sử dụng theo dúng cấp độ của đề mục - không bỏ qua đề mục (ví dụ có dùng thẻ <h3> mà không có thẻ <h2>).

	!!! Không dùng h1 - h6 để định dạng văn bản: Thẻ h1 có cỡ chỡ to nhất, thẻ h6 nhỏ nhất nhưng không vì thể cố tình sử dụng nó để định dạng văn bản thông thường: 
	như đoạn văn bản không phải là đề mục, chỉ vì muốn chữ to hơn mà dùng h1, h2 ... là sai.

	!!! Chỉ dùng một thẻ h1: H1 được dùng như là tiêu đề của cả một trang HTML, do vậy trên một trang chỉ dùng 1 thẻ H1. (Trừ trong section của HTML5).

	!!! Thẻ H1 - H6 không có thuộc tính đặc trưng riêng, chỉ có các thuộc tính toàn cục

### Thẻ <p> và <br>
	- Thẻ <p> (yaoj đoạn văn bản)
		+ Với thẻ <p>, trình duyệt tạo ra một khối (chữ nhật) để hiện thị nội dung văn bản, khối này phân cách bởi các dòng trống

		+ Trong thẻ <p> chỉ nên chứa văn bản và các phần tử dạng inline, chủ yếu là các phần tử định dạng như <i> <em> <strong> ... 
			<p>Nội dung trong thẻ ... </p>

		!!! Thẻ <p> là loại thẻ dạng block

	- Thẻ <br> (ngắt dòng)
		+ Thẻ <br> dùng để ngắt dòng, thẻ <br> là thẻ rỗng, nó không cần đóng. Có thể viết bằng <br> hoặc <br />
			<p>Những đêm hè<br>
			Khi ve ve<br>
			Đã ngủ<br>
			Tôi lắng nghe<br>
			Trên đường Trần Phú<br>
			Tiếng chổi tre</p>

### Whitespace (khoảng trắng)
	- Khoảng trắng là những ký tự (có thể gõ từ các trình soạn thảo) như: ký tự trắng, ký tự tab, ký tự xuống dòng
		+ Ký tự trắng : ký tự rỗng (space character), bạn gõ phím spacebar trên bàn phím để có ký tự này.
		
		+ Ký tự tab : nhấn phím tab trên bàn phím. Nó là phím tạo bảng, tùy thuộc các trình soạn thảo nó hiện thị với nhiều khoảng trắng.
		
		+ Ký tự xuống dòng : trong các trình soạn thảo bạn nhấn Enter. Cũng tùy thuộc trình soạn thảo xuống dòng nó là một ký tự CR (Carriage Return, mã ASCII 13) hoặc 
		là một ký tự LF (Line Feed, mã ASCII 10) hoặc là cả một chuỗi CRLF (Soạn thảo trong Windows như notepad xuống dòng là tạo ra chuỗi CRLF còn gọi là EOL)

	- Trong code HTML giữa các từ có nhiều khoảng trắng, thì trình duyệt render coi như chỉ có một khoảng khắng
		<p>Xin        chào       các bạn</p>
		// kết quả
		Xin chào các bạn

	- Ký tự Tab, CR, LF đều hiện thị như space (spacebar)
		<p>Xin
		chào

			các

			bạn</p>
		// kết quả
		Xin chào các bạn

	- Khi bạn viết HTML, mà sau khi mở thẻ là các khoảng trắng, thì các khoảng trắng này bị loại bỏ. Tương tự vậy, các khoảng trắng trước đóng thẻ bị loại bỏ
		<tag>     Nội dung     </tag>
		// tương đương
		<tag>Nội dung</tag>

	- Phía trước mở một thẻ, phía sau đóng một thẻ nếu có khoảng trắng thì coi như không có.
			<tag>Nội dung </tag>        
		// tương đương
		<tag>Nội dung</tag>

	- Nếu muốn trình duyệt không bỏ qua các khoảng trắng theo quy tắc trên, thì các ký tự khoảng trắng space chèn vào HTML cần sử dụng mã ký tự (HTML Entity) để chèn
		<p>&nbsp;&nbsp;Xin&nbsp;&nbsp;&nbsp;chào!</p>
		// kết quả
		  Xin   chào!

		// xem thêm Mã ký tự HTML đặc biệt

### Thẻ định dạng 
	- Thẻ <b> cho biết nội dung cần nhấn mạnh
	
	- Thẻ <strong> cho biết nội dung cần nhấn mạnh, trình duyệt hiện thị với chữ đậm
	
	- Thẻ <big> hiện thị với cỡ chữ lớn hơn một cấp (thẻ này đánh dấu lạc hậu không nên dùng nữa)
	
	- Thẻ <small> hiện thị chữ nhỏ hơn một cấp
	
	- Thẻ <i> hiện thị chữ in nghiêng
	
	- Thẻ <em> đánh dấu nhấn mạnh (hiện thị in nghiêng)
	
	- Thẻ <ins> đánh dấu đoạn text được chèn vào
	
	- Thẻ <del> đánh dấu đoạn text xóa đi
	
	- Thẻ <sub> tạo chỉ số dưới
	
	- Thẻ <sup> tạo chỉ số trên

		<body>
			<p>Một văn bản bình thường </p>
			<p><b> văn bản in đâm </b></p>
			<p><big> văn bản cỡ chữ lớn hơn</big></p>
			<p><i> in nghiêng văn bản </i></p>
			<p><em>nhấn mạnh (in nghiêng)</em></p>
			<p><small> văn bản chữ nhỏ hơn</small></p>
			<p><strong>nhấn mạn văn bản (hiện thị in đậm)</strong></p>
			<p>Text <sub>chỉ số dưới</sub></p>
			<p>Text <sup>chỉ số trên</sup></p>
			<p><ins> đánh dấu văn bản chèn vào </ins></p>
			<p><del> đánh dấu là văn bản được xóa </del></p>
		</body>

	!!! Thẻ <b> và thẻ <strong> in đậm văn bản như nhau, thẻ <em> và thẻ <i> in nghiêng văn bản như nhau. Nhưng khi sử dụng chúng mang ý nghĩa khác nhau: với <em>, <strong> 
	thì mang ý nghĩa quan trọng

### Thẻ <hr>
	- Thẻ <hr> được dùng để tạo đường kẻ ngang trong trang HTML, nó thường dùng để phân tách giữa các đoạn văn, các phân đoạn nội dung để dễ đọc, dễ theo dõi
		<hr width="50%">
		<hr>
		<hr width="50%"
			color="red"
			align="right"
			size="5px">
	
	- Thuộc tính riêng
		+ width : thiết lập độ rộng
		+ size : thiết lập chiều cao (đơn vị px, pixel)
		+ color : thiết lập màu đường (red, green, blue ...)
		+ align : căn lề (left, right, center)

### Thẻ <img>
	- Thẻ <img> được dùng để nhúng một hình ảnh vào trang HTML. Thẻ này có vài thuộc tính và nó không có phần đóng thẻ
		
	- Thuộc tính 
		+ src : thiết lập địa chỉ URL của ảnh, nó có thể là địa chỉ tương đối, tuyệt đối, hay đến file ảnh cục bộ trên máy tính
			<img src="image.jpg" />

		+ alt : Trong trường hợp ảnh không hiện thị được (ví dụ ảnh bị xóa ...) thì thuộc tính alt là một văn bản thay thế sẽ hiện thị thay cho ảnh
			<img src="flower.jpg" alt="" />

		+ width - height : Điều chỉnh cỡ ảnh hiện thị, chiều rộng và chiều cao của ảnh. Đơn vị sử dụng là pixel px hoặc phần trăm %
			<img src="flower.jpg" height="150px" width="150px" alt="" />
			<img src="flower.jpg" height="50%" width="50%" alt="" />

		!!! Khi sử dụng ảnh trong trang web, sẽ mất thời gian để tải ảnh về và hiện thị, nên cần lưu ý chọn cỡ ảnh gốc sao cho phù hợp với yêu cầu hiện thị của trang

		+ border : kích cỡ của đường viền theo đơn vị px. Mặc định, ảnh không có đường viền bao quanh
			 <img 
				border="4px"
				width="700px"
				src="https://w.wallha.com/ws/15/v1SOFZMT.jpg" 
				alt="vi du" />

### Thẻ <a>
	- Thẻ <a> (anchor - mỏ neo) được dùng để tạo ra các liên kết

	- Nội dung trong thẻ <a> có thể là text, hình ảnh ... cho biết trang được liên kết đến.

	- Thuộc tính 
		+ href : thuộc tính href (hyperlink reference) chỉ ra địa chỉ đích mà link mở ra
			<a href="https://wallha.com/search?q=wlop">WLOP</a>

		!!! Địa chỉ URL chỉ ra trong href có thể là địa chỉ tuyệt đối ("https://wallha.com/search?q=wlop") hoặc địa chỉ tương đối ("/wallha.com/").

		!!! href nếu là email thì viết "mailto:youremail", href là số điện thoại thì viết: "tel:phonenumber"

		+ target : xác định các xuất hiện trong của sổ trình duyệt khi người dùng nhấn vào liên kết
			_self : mở ra trong cửa sổ hiện tại của trình duyệt (giá trị mặc định)
			_blank : mở liên kết ở một Tab mới (cửa sổ mới)
				<a href="https://wallha.com/search?q=wlop" target="_blank" >Học HTML</a>

		!!! Link đến tài nguyên không phải HTML (như link đến file ,mp3, .doc ...), với các tài nguyên này tùy loại trình duyệt có loại nó sẽ tải download về, có loại có 
		thể mở ra xem ngay trên trình duyệt (ví dụ file ảnh, pdf ... có thể trình duyệt tải và mở ngay, nhưng có những file .rar, .zip, có thể nó chỉ tải về)

		+ rel="nofollow" : thuộc tính thiết lập liên quan đến công cụ tìm kiếm (như Google Search). Khi bạn liên kết tới một địa chỉ URL của một Website khác, nếu có thuộc 
		tính rel="nofollow" thì trang web đó (địa chỉ URL đó) không liên quan đến website của bạn
			<a href="https://badexamples.com/abc/xyz" rel="nofollow">Đây là địa chỉ xấu</a>

### Danh sách 
	- Danh sách là một tập hợp các phần tử. Có hai loại danh sách, danh sách có thứ tự và không có thứ tự.
		+ Danh sách có thứ tự (ordered list) được tạo ra bằng thẻ <ol>, mỗi phần tử khi xuất hiện có chỉ số ở đầu (1,2, 3 ... A, B, C ...)

		+ Danh sách không có thứ tự (unordered list) được tạo ra bằng thẻ <ul>, mỗi phần tử khi xuất hiện có thể có ký hiệu như dấu chấm, gạch ngang ... các phần tử.

	- Thẻ <li> 
		+ Thẻ <li> chứa bất kỳ nội dung HTML nào

		+ thuộc tính value có thể gán bằng một số nguyên để thiết lập giá trị chỉ số khi nằm trong danh sách có thứ tự

	- Thẻ <ol>
		+ Thẻ <ol> (ordered list) dùng để tạo danh sách có thứ tự, mỗi phần tử trong danh sách được định nghĩa bằng thẻ <li>
			<ol>
				<li>HTML</li>
				<li>CSS</li>
				<li>Javascript</li>
				<li>C#</li>
			</ol>
			// Kết quả 
			1. HTML
			2. CSS
			3. Javascript
			4. C#

		!!! Các phần tử trong danhh sách ol tự động được đánh chỉ số : 1, 2, 3 ...

		+ Thuộc tính 
			* type : gán bằng 1, a, A, i để thiết lập một số kiểu đánh số
				a : dùng chữ thường để đánh chỉ số (a, b, c ...)
				A : dùng chữ in để đánh chỉ số (A, B, C ...)
				i : hoặc I đánh theo số la mã (i, ii, iii ...)
				1 : kiểu mặc định (dùng số 1,2,3,...)

			* start : gán bằng số nguyên, để thiết lập giá trị chỉ số của phần tử đầu tiên, mặc định là 1 (phần tử tiếp theo tăng giá trị 1 đơn vị)

			* reversed : bằng true thì chỉ số đánh từ lớn xuống nhỏ

	- Thẻ <ul> 
		+ Thẻ <ul> (unordered list) dùng để tạo danh sách không có thứ tự, mỗi phần tử trong danh sách được định nghĩa bằng thẻ <li>
			<ul type="circle">
				<li>HTML</li>
				<li>CSS</li>
				<li>Javascript</li>
				<li>C#</li>
			</ul>

		+ Các phần tử trong danhh sách ul mặc định được đánh dấu đầu dòng bằng ký hiệu hình tròn

		+ Thuộc tính 
			* type : cho phép thay đổi ký hiệu này bằng các giá trị: circle, disc hoặc square

		!!! Danh sách không có thứ tự <ul> này có thể dùng thẻ <menu> thay thế, hai thẻ này tương tự nhau trên trình duyệt.

		!!! Thuộc tính type của <ol> và <ul> nên hạn chế dùng, thay vào đó hãy sử dụng CSS để thiết lập thông tin này: Thuộc tính css: list-style

		!!! li*n + tab : tạo nhanh n thẻ li (áp dụng tuong tự cho các thẻ khác)
		
		!!! ul : mặc định là dấu chấm, ol : mặc định là số (bắt đầu từ 1)

### Bảng biểu
	- Bảng biểu (table) trong HTML để trình bày dữ liệu gồm có các dòng (row), các ô bảng (cell), phần tiêu đề bảng (heading)

	- Thẻ <table>
		+ Bảng là cấu trúc phức tạp, toàn bộ nội dung của bảng được đặt vào thẻ <table>

		+ Thuộc tính
			* border : thuộc tính border để thiết lập độ rộng của các dòng kẻ của bảng (hiện giờ nên dùng CSS). Độ rộng tính bằng pixel - nếu bằng không thì bảng không 
			có các đường kẻ.
				<table border="1">
					<!-- các phần tử trong bảng -->
				</table>

	- Thẻ <td>
		+ Thẻ <td> là nơi chứa dữ liệu của bảng, nó có thể chứa các thẻ HTML khác như văn bản, hình ảnh, danh sách thậm chí chứa một bảng khác.
			<table border="1">
				<td>C1</td>
				<td>C2</td>
				<td>C3</td>
				<td>Abc1</td>
				<td>Abc2</td>
				<td>Abc3</td>
				<td>Abc4</td>
				<td>Abc5</td>
				<td>Abc6</td>
			</table>
		
		!!! 1 <td> là 1 ô trên 1 hàng

	- Thẻ <tr>
		+ Để nhóm các phần tử <td> thuộc về một dòng, thì dùng thẻ <tr>
			<table border="1">
				<tr>
					<td>C1</td>
					<td>C2</td>
					<td>C3</td>
				</tr>
				<tr>
					<td>Abc1</td>
					<td colspan="2">Abc2</td>
					<td rowspan="2">Abc3</td>
				</tr>
				<tr>
					<td>Abc4</td>
					<td>Abc5</td>
					<td>Abc6</td>
				</tr>
			</table>

		!!! 1 <tr> là 1 hàng ngang

	- Thẻ <th> 
		+ Thẻ <th> tương tự như thẻ <td> (nằm trong thẻ <tr>) được dùng để đánh dấu tiêu đề của một nhóm ô bảng (cell)
			<table border="1">
				<tr>
					<th></th>
					<th>Cột 1</th>
					<th>Cột 2</th>
					<th>Cột 3</th>
				</tr>

				<tr>
					<th>Dòng 1</th>
					<td>C1</td>
					<td>C2</td>
					<td>C3</td>
				</tr>
				<tr>
					<th>Dòng 2</th>
					<td>Abc1</td>
					<td>Abc2</td>
					<td>Abc3</td>
				</tr>
				<tr>
					<th>Dòng 3</th>
					<td>Abc4</td>
					<td>Abc5</td>
					<td>Abc6</td>
				</tr>
			</table>

		!!! Các ô <th> sẽ in đậm thể hiện ô tiêu đề

	- Thẻ <caption>
		+ Thẻ <caption> thường tạo ngay sau khi mở thẻ <table> để thiết lập tiêu đề của bảng. 
			<table border="1">
				<caption style="caption-side: top">BẢNG DỮ LIỆU</caption>
				<tr>
					<td>C1</td>
					<td>C2</td>
					<td>C3</td>
				</tr>
				<tr>
					<td>Abc1</td>
					<td>Abc2</td>
					<td>Abc3</td>
				</tr>
				<tr>
					<td>Abc4</td>
					<td>Abc5</td>
					<td>Abc6</td>
				</tr>
			</table>

		+ Vị trí tiêu đề có thể thiết lập bằng CSS với thuộc tính caption-side bằng top hoặc bottom

	- Thẻ <thead> <tfoot>
		+ Nếu muốn nhóm các dòng đánh dấu là phần đầu của các cột thì dùng thẻ <thead>

		+ Nếu muốn nhóm dòng là phần cuối của cột dùng thẻ <tfoot>
			<table border="1">
				<thead style="background: red">
					<tr>
						<th></th>
						<th>Cột 1</th>
						<th>Cột 2</th>
						<th>Cột 3</th>
					</tr>
				</thead>

				<tr>
					<th>Dòng 1</th>
					<td>C1</td>
					<td>C2</td>
					<td>C3</td>
				</tr>
				<tr>
					<th>Dòng 2</th>
					<td>Abc1</td>
					<td>Abc2</td>
					<td>Abc3</td>
				</tr>
				<tr>
					<th>Dòng 3</th>
					<td>Abc4</td>
					<td>Abc5</td>
					<td>Abc6</td>
				</tr>
			</table>

### Block và Inline
	- Các phần tử HTML thuần túy được phân loại ra thành 2 cấp độ theo cách thức mà phần tử được trình duyệt render hiện thị cho người dùng đó là những phần 
	tử cấp độ inline (hiện thị trong hàng) và những phần tử cấp độ block (hiện thị theo khối)

	- Cấp độ block
		+ Phần tử HTML cấp độ block (hiện thị dạng khối) là những phần tử sắp xếp theo chiều đứng của phần tử cha, trình duyệt luôn tạo ra một dòng mới, rồi 
		đến không gian dành cho phần tử này, và kết thúc là một dòng mới.

		+ Mặc định phần tử dạng này, có chiều rộng chiếm hết chiều rộng phẩn tử cha, chiều cao mở rộng theo nội dung của nó

		+ Các phần tử dạng block như: <h1>, <form>, <li>, <ol>, <ul>, <p>, <pre>, <table>, <div> ...

	- Cấp độ inline
		+ Phần tử HTML cấp độ inline (trong hàng) là những phần tử chiếm không gian chiều ngang theo nội dung của phần tử, không tạo ra dòng mới (xuống dòng) 
		trước và sau phần tử.

		+ Các phần tử inline như: <b>, <a>, <strong>, <img>, <input>, <em>, <span> ...

	!!! Quy tắc mô hình nội dung của HTML: phần tử cấp độ inline không được chứa phần tử cấp độ block, nó chỉ chứa dữ liệu hoặc các phần tử inline khác. Phần 
	tử block thì được chứa các phần tử block, inlinne, dữ liệu. Có một số ngoại lệ như thẻ <a> (inline) có thể chứa phần tử kiểu block.
		<a href="/html/">
			<h2>Học HTML</h2>
			<p>Các bài học HTML</p>
		</a>

### Thẻ <div> và <span>
	- Trong HTML có hai loại phần tử sử dụng với mục đích tổng quát, một phần tử cấp độ block là <div> và một phần tử cấp độ inline là <span>. Hai loại thẻ này dùng 
	rất nhiều để tạo ra cấu trúc trang HTML hiện đại

	- Thẻ <div>
		+ Thẻ <div> (viết tắt của division - chia) là phần tử cấp độ block dùng để phân nội dung thành các phân đoạn, chứa các phần tử HTML khác

		+ Thẻ <div> thường dùng CSS để thiết lập các đặc tính của nó (thông qua thiết lập class và id).
			<style>
				.divparent {background: #0b5088; padding: 5px;}
				.div1 {height: 70px; background: green;}
				.div2 {height: 70px; background: yellowgreen; margin-top: 5px}
			</style>

			<div class="divparent">
				<div class="div1">
					<p>Nội dung trong thẻ div 1</p>
				</div>
				<div class="div2">
					<p>Nội dung trong thẻ div 2</p>
				</div>
			</div>

	- Thẻ <span> 
		+ Thẻ <span> thì lại là loại thẻ cấp độ inline với mục đích dùng tổng quát, thường nó được dùng để chứa dữ liệu (văn bản), chứa phần tử inline khác

		+ Tương tự div, span cũng thường dùng CSS để định dạng trình bày
			<h4>Học <span style="color:red">HTML</span> cơ bản</h4>

	!!! Tóm lại: Thẻ <div> dùng để tạo khối block, phân chia nội dung trong HTML. Thẻ <span> tạo các phần tử dạng inline, phần văn bản dạng inline không ngắt dòng.

### Màu sắc 
	- Màu sắc sử dụng trong HTML cũng như CSS là màu RGB. Cường độ màu là số nguyên có giá trị từ 0 đến 255.
		<p style="background-color: rgb(128, 100, 200)">Màu nền rgb(128,100,200)</p>

	- Thuộc tính bgcolor
		+ Thuộc tính bgcolor dùng để thay đổi màu nền trang web

	- Thẻ <font>
		+ Khi cần thay đổi màu văn bản(màu chữ), bạn có thể dùng thẻ font kết hợp với thuộc tính color

	<html>
		<head> 
			<title>Color</title>  
		</head>
		<body bgcolor="#000099">
			<h1>
				<font color="#FFFFFF"> Chữ trắng nền đen </font>
			</h1> 
		</body>
	</html>

### Biểu mẫu
	- Biểu mẫu - web form - được tạo ra trong HTML là khu vực hình thành nên sự tương tác giữa người dùng và ứng dụng web.
	
	- Các form cho phép người dùng nhập dữ liệu vào, sau đó gửi dữ liệu đó cho web server, hoặc nhập dữ liệu vào sử lý dữ liệu ngay tại client side.

	- Bên trong form đó nó chứa một hoặc nhiều phần tử để nhập liệu gọi là các điều khiển (control)

	- Hầu hết các control (điều khiển) để người dùng nhập thông tin, dữ liệu được tạo ra bằng thẻ HTML <input> và đi cùng nó thường là phần tử <label> để tạo ra 
	nhãn (tiêu đề) cho control.

	- Thẻ <form>
		+ Thẻ <form> tạo ra biểu mẫu trong HTML 
			<form action="" method="post">
				<!--Các mã HTML, các phần tử trong form -->
			</form>

		+ Thuộc tính
			* action : thuộc tính để thiết lập URL sẽ nhận dữ liệu, là địa chỉ mà dữ liệu của form gửi đến (submit đến, post đến). Thiếu tham số này thì action bằng 
			URL đang truy cập (tức gửi thông tin form đến server theo địa chỉ đang truy cập)

			* method : thuộc tính để thiết lập HTTP Method, thường có giá trị bằng get hoặc post. Nếu không viết thuộc tính này thì method mặc định của form là get
				// xem thêm HTTP Request Message

			!!! Khi thông tin gửi tới địa chỉ máy chủ (địa chỉ trong thuộc tính action), thì dự liệu nhận được xử lý thế nào là việc của server, bạn sẽ thực hiện việc 
			sử lý này khi lập trình backend với một ngôn ngữ lập trình nào đó như php, c# ...




























































## Thẻ heading <h1> - <h6>
- h(1->6): thẻ heading (thẻ tiêu đề)
	<h1> nội dung </h1>
- p: thẻ paragraph (thẻ văn bản)
	<p> nội dung </p>
- br: xuống dòng
	<p> nội dung </p><br>
- img: thẻ image (thẻ hình ảnh)
	<img scr="đường dẫn của ảnh" alt="tên ảnh hiển thị khi bị lỗi">
- a: anchor (thẻ liên kết)
	<a href="đường dẫn"> nội dung hiển thị </a>
- ul, ol, li: unordered list, ordered list, list item (thẻ danh sách)
	<ul>
		<li> 1 </li>
		<li> 2 </li>
		<li> 3 </li>
	</ul>
	<ol>
		<li> 1 </li>
		<li> 2 </li>
		<li> 3 </li>
	</ol>
!! li*n + tab : tạo nhanh n thẻ li (áp dụng tuong tự cho các thẻ khác)
!! ul : mặc định là dấu chấm, ol : mặc định là số (bắt đầu từ 1)

- table: thẻ bảng
	+ thead: tiêu đề của bảng
		. th: ô tiêu đề
	+ tbody: 
		. tr: dòng (mỗi thẻ tr là 1 dòng)
		. td: ô theo cột
	<table>
		<thead>
			<th> tiêu đề cột 1 </th>
			<th> tiêu đề cột 2 </th>
		</thead>
		<tbody>
			<tr>
				<td> nội dung cột 1 </td>
				<td> nội dung cột 2 </td>
			</tr>
		</tbody>
	</table>

- input: thẻ đưa dữ liệu vào
	<input type="loại input">
	+ text: ô nhập chữ
	+ checkbox: ô để chọn, chọn được nhiều phương án (hình vuông)
	+ radio: ô để chọn, chỉ chọn 1 phương án (hình tròn)

- button: thẻ nút
	<button> nội dung trên nút </button>

- div: tạo khối bao quanh các phần tử khác, dùng để căn chỉnh vị trí
	<div>
		thành phần khối 
	</div>


## Thẻ <a>
- text-decoration: none; : bỏ dấu gạch chân


## thẻ <buttom>
- background-color: transparent; : màu trong suốt
- border: none; : loại bỏ viền nút
- outline: none; : loại bỏ outline
- border-radius: kich thước; : tạo bo góc
- cursor: pointer; : thay đổi trỏ chuột khi di vào


## 


## Attribute (thuộc tính)


## CSS trong HTML
- Internal: tạo css nằm trong thẻ <head> và các thuộc tính được đặt trong thẻ <style>
	<head>
		<title>Khoi ne!</title>
	   	<meta charset="UTF-8">
		<style>
			CSS
		</style>
	</head>

- External: tạo 1 file .css và link vào file .html thông qua thẻ link
	<link rel="stylesheet" href="file.css">

- Inline: viết trực tiếp vào thẻ mở bằng thuộc tính style
	<h1 style="color: red; font-size: 20px"> nội dung </h1>


## ID và CLASS
- ID: không được đặt trùng nhau (dùng # để CSS cho ID)
- CLASS: có thể đặt trùng nhau (dùng . để CSS cho CLASS)


## mức độ ưu tiên
- Internal, External
	+ độ ưu tiên ngan nhau, ai được CSS sau (mới nhất) thì được ưu tiên

- Inline(1000) > #ID(100) > .CLASS(10) > tag(1) > us&i(0)
- Equal specificty: được hiểu là cùng mức độ ưu tiên thì lệnh sau (mới nhất) sẽ được ưu tiên
- Universal selector and inherited (0): CSS chung cho tất cả các thành phần trong file .html

!! có thể cộng dồn điểm ưu tiên
	tag#id.class(111) > #id.class(110)
!! những giá trị CSS có !important thì có độ ưu tiên cao nhất (>1000)
	color: red !important;


## biến
- khơi tạo biến:
	:root {
		--text-color: violet; (biến global)
	}
	h1 {
		--my-color: red; (biến local)
	}

- lây giá trị biến: dùng hàm var(tên biến)
	h1 {
		color: var(--text-color); (violet)
	}


## CSS units (các đơn vị)
- Absolute units (các đơn vị tuyệt đối)
	+ px (pixel): điểm ảnh, không bị tác động làm thay đổi
- Relative units (các đơn vị tương đối)
	+ %: phụ thuộc vào thẻ chứa nó
	+ rem: phụ thuộc vào thẻ <html>
 	+ em: phụ thuộc vào thẻ gần nhất
	+ vw: phụ thuộc chiều rộng màn hình (1vw = 1%)
	+ vh: phụ thuộc chiều cao màn hình


## Padding (lớp đệm giữa chữ và viền)
- làm dày đối tượng lên (tính vào kích thước đối tượng)
- cách viết:
	+ padding-left, padding-right, padding-bottom, padding-top : cho từng hướng
	+ padding: 10px; : cho cả 4 hướng
	+ padding: 10px 5px; :  top & bottom (10px), left & right (5px)
	+ padding: 10px 5px 20px; : top (10px), left & right (5px), bottom (20px)
	+ padding: 20px 15px 10px 5px; : top(20px), left(15px), right(10px), bottom(5px)


## Border (lớp viền)
- viền bao quanh đối tượng, làm dày đối tượng lên (tính vào kích thước đối tượng)
- cách viết:
	+ border-width: 10px; : độ dày của viền (10px)
	+ border-"hướng"-width: "kích thước"; : độ dày của viền theo tường hướng
	+ border-style: solib; : kiểu viền (solib: nét liền)
	+ border-color: black; : màu của viền (black)
	+ border: 10px solid black; cho cả 4 hướng
	+ border-hướng: 10px solid black; cho hướng cụ thể


## Margin (lớp đệm bên ngoài viền)
- tạo khoảng các giữa các đối tượng, không làm dày đối tượng (không tính vào kích thước đối tượng)
- cách viết: (tương tự với padding)
	+ margin: 20px;


## Box-sizing
- border-box: đảm bảo kích thước của đối tượng giống ban đầu, tự động tính toán content để tổng kích thước được giữ nguyên. Khi các phần thêm vào quá lớn thì content bị đẩy ra.
	box-sizing: border-box;
- inherit: cho phép phần tử kế thừa giá trị của box-sizing từ phần tử cha của nó
	box-sizing: inherit;
- unset: hủy box-sizing
	box-sizing: unset;


## Background-clip
- quyết định màu sẽ được đỗ màu từ đâu.
	+ border-box: từ lớp border
	+ padding-box: từ lớp padding
	+ content-box: từ lớp content


## Background-image
- url("đường dẫn ảnh"); : đặt ảnh làm background
- linear-gradient(180deg, black, white); : tạo dãy màu chuyển làm bac ground
	+ 180deg: góc độ của dãy màu
	+ chuyển dần từ black tới white
- background-size: kích thước của background
	+ contain: lấy cạnh dài nhất, đảm bảo hình không bị che khuất
	+ cover: lấy cạnh dài nhất, đảm bảo hình đủ màn hình (ngược lại với contain)
- background-repeat: lặp lại hình
	+ repeat: lặp lại (mặc định)
	+ no-repeat: không lặp lại


## Background-origin (đi kèm với background-image)
- giống với background-clip nhưng áp dụng với ảnh. Mặc định là padding-box


## Background-position
- di chuyển background (góc tọa độ tính từ góc trái trên)
-cách viết:
	+ background-position: 10px; : 1 tham số thì tham số còn lại mặc định là center
	+ background-position: 10px 5px;
	+ background-position: top right; : dính vào góc phải trên
	+ background-position: top 10px right 5px;


## Cách viết tắt cảu background
	background: color/image repeat/no-repeat position / size;


## Hàm
- var(): lấy giá trị
- linear-gradient(): tạo dãy mày chuyển
- rgba(): màu có độ trong suốt
- rgb(): màu không có độ trong suốt
- calc(): tính toán
- attr(): lấy giá trị thuộc tính của thẻ chứa nó


## CSS pseudo-classes (lớp giả)
- :root : tham chiếu đến phần tử góc là thẻ html
- :hover : thay đổi CSS của đối tượng khi di chuột vào
- :active : thay đổi CSS của đối tượng khi bấm/giữ chuột vào
- :first-child : tham chiếu đến đối tượng con đầu tiên
- :last-child : tham chiếu đến đối tượng con cuối cùng


## CSS pseudo-element (phần tử giả)
- ::before : luôn là đối tượng đầu tiên
- ::after : luôn là đối tượng cuối cùng
- ::first-letter : luôn là kí tự đầu tiên
- ::firrst-line : luôn là dòng đầu tiên
- ::selection : luôn là lựa chọn (bôi đen) đầu tiên


## Position
- relative: vị trí tương đối. Lấy vị trí đang đứng làm góc tọa độ
- absolute: vị trí tuyệt đối. Lấy thẻ cha gần nhất có thuộc tính position làm góc
- fixed: phụ thuộc vào vị trí trình duyệt.
- sticky


## Flex-box
// FLEX CONTAINER //
- felx-direction: tác động lên trục main axis
	+ row (mặc định): main axis nằm ngan
	+ row-reverse: giống row nhưng đảo main start - end
	+ column: main axis nằm dọc
	+ column-reverse: giống column nhưng đảo main start - end

- flex-wrap: tác động lên trục sross axis
	+ nowrap (mặc định): không xuống dòng
	+ wrap: xuống hàng khi hết
	+ wrap-reverse: giống wrap nhưng đảo main start - end

- flex-items: tác động lên vị trí của "các" flex item nhưng theo trục cross axis
	+ flex-start: dồn flex item về cross start
	+ flex-end: dồn flex item về cross end
	+ center: ở giữa cross axis
	+ báeline: mép dưới của content trong flex item nằm trên đường trung trực của cross axis
	+ stretch: dãn hết các item ra bám hết vào start - end

- justify-content: tác động lên vị trí của flex item nhưng theo trục main axis
	+ flex-start: dồn flex item về main start
	+ flex-end: dồn flex item về main end
	+ space-between: cách đều các item ra xa nhau nhất có thể
	+ center: ở giữa main axis
	+ space-around: tạo khoảng không cách đều cho mỗi item và các item (2 bên của 1 item có thêm khoảng trắng)

- align-content: giống tính năng của justify-content nhưng theo trục cross axis
	
// FLEX ITEM //
- align-self: giống alignnhunngw chỉ riêng từng flex item đuoccwj chỉ định
- flex-grow: làm tăng main size
- flex-shrink: làm giảm main size
- order: thay đổi thú tự của từng flex item


## BEM
- cú pháp
	+ .block
	+ .block__element
	+ .block--modifier
	+ .block__element--modifier


#####-----CSS-----#####
























