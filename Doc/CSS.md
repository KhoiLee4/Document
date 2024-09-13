# CSS

## CSS là gì?

CSS (Cascading Style Sheets) là một ngôn ngữ dùng để trình bày hình thức thể hiện của các phần tử HTML. Như định dạng các phần tử văn bản (cơ chữ, font chữ, màu sắc ...), bố cục, dàn trang ... 

*❗CSS không phải là ngôn ngữ lập trình*






















## Thẻ `<a>`

- text-decoration: none; : bỏ dấu gạch chân

## thẻ <buttom>

- background-color: transparent; : màu trong suốt
- border: none; : loại bỏ viền nút
- outline: none; : loại bỏ outline
- border-radius: kich thước; : tạo bo góc
- cursor: pointer; : thay đổi trỏ chuột khi di vào

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

  - độ ưu tiên ngan nhau, ai được CSS sau (mới nhất) thì được ưu tiên

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
  - px (pixel): điểm ảnh, không bị tác động làm thay đổi
- Relative units (các đơn vị tương đối)
  - %: phụ thuộc vào thẻ chứa nó
  - rem: phụ thuộc vào thẻ <html>
  - em: phụ thuộc vào thẻ gần nhất
  - vw: phụ thuộc chiều rộng màn hình (1vw = 1%)
  - vh: phụ thuộc chiều cao màn hình

## Padding (lớp đệm giữa chữ và viền)

- làm dày đối tượng lên (tính vào kích thước đối tượng)
- cách viết:
  - padding-left, padding-right, padding-bottom, padding-top : cho từng hướng
  - padding: 10px; : cho cả 4 hướng
  - padding: 10px 5px; : top & bottom (10px), left & right (5px)
  - padding: 10px 5px 20px; : top (10px), left & right (5px), bottom (20px)
  - padding: 20px 15px 10px 5px; : top(20px), left(15px), right(10px), bottom(5px)

## Border (lớp viền)

- viền bao quanh đối tượng, làm dày đối tượng lên (tính vào kích thước đối tượng)
- cách viết:
  - border-width: 10px; : độ dày của viền (10px)
  - border-"hướng"-width: "kích thước"; : độ dày của viền theo tường hướng
  - border-style: solib; : kiểu viền (solib: nét liền)
  - border-color: black; : màu của viền (black)
  - border: 10px solid black; cho cả 4 hướng
  - border-hướng: 10px solid black; cho hướng cụ thể

## Margin (lớp đệm bên ngoài viền)

- tạo khoảng các giữa các đối tượng, không làm dày đối tượng (không tính vào kích thước đối tượng)
- cách viết: (tương tự với padding)
  - margin: 20px;

## Box-sizing

- border-box: đảm bảo kích thước của đối tượng giống ban đầu, tự động tính toán content để tổng kích thước được giữ nguyên. Khi các phần thêm vào quá lớn thì content bị đẩy ra.
  box-sizing: border-box;
- inherit: cho phép phần tử kế thừa giá trị của box-sizing từ phần tử cha của nó
  box-sizing: inherit;
- unset: hủy box-sizing
  box-sizing: unset;

## Background-clip

- quyết định màu sẽ được đỗ màu từ đâu.
  - border-box: từ lớp border
  - padding-box: từ lớp padding
  - content-box: từ lớp content

## Background-image

- url("đường dẫn ảnh"); : đặt ảnh làm background
- linear-gradient(180deg, black, white); : tạo dãy màu chuyển làm bac ground
  - 180deg: góc độ của dãy màu
  - chuyển dần từ black tới white
- background-size: kích thước của background
  - contain: lấy cạnh dài nhất, đảm bảo hình không bị che khuất
  - cover: lấy cạnh dài nhất, đảm bảo hình đủ màn hình (ngược lại với contain)
- background-repeat: lặp lại hình
  - repeat: lặp lại (mặc định)
  - no-repeat: không lặp lại

## Background-origin (đi kèm với background-image)

- giống với background-clip nhưng áp dụng với ảnh. Mặc định là padding-box

## Background-position

- di chuyển background (góc tọa độ tính từ góc trái trên)
  -cách viết: + background-position: 10px; : 1 tham số thì tham số còn lại mặc định là center + background-position: 10px 5px; + background-position: top right; : dính vào góc phải trên + background-position: top 10px right 5px;

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

  - row (mặc định): main axis nằm ngan
  - row-reverse: giống row nhưng đảo main start - end
  - column: main axis nằm dọc
  - column-reverse: giống column nhưng đảo main start - end

- flex-wrap: tác động lên trục sross axis

  - nowrap (mặc định): không xuống dòng
  - wrap: xuống hàng khi hết
  - wrap-reverse: giống wrap nhưng đảo main start - end

- flex-items: tác động lên vị trí của "các" flex item nhưng theo trục cross axis

  - flex-start: dồn flex item về cross start
  - flex-end: dồn flex item về cross end
  - center: ở giữa cross axis
  - báeline: mép dưới của content trong flex item nằm trên đường trung trực của cross axis
  - stretch: dãn hết các item ra bám hết vào start - end

- justify-content: tác động lên vị trí của flex item nhưng theo trục main axis

  - flex-start: dồn flex item về main start
  - flex-end: dồn flex item về main end
  - space-between: cách đều các item ra xa nhau nhất có thể
  - center: ở giữa main axis
  - space-around: tạo khoảng không cách đều cho mỗi item và các item (2 bên của 1 item có thêm khoảng trắng)

- align-content: giống tính năng của justify-content nhưng theo trục cross axis

// FLEX ITEM //

- align-self: giống alignnhunngw chỉ riêng từng flex item đuoccwj chỉ định
- flex-grow: làm tăng main size
- flex-shrink: làm giảm main size
- order: thay đổi thú tự của từng flex item

## BEM

- cú pháp
  - .block
  - .block\_\_element
  - .block--modifier
  - .block\_\_element--modifier


