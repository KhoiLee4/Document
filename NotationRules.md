# Notation Rules

## Tiêu đề

Markdown sử dụng dấu # để tạo các tiêu đề. Ta có thể dùng từ 1 đến 6 dấu # để biểu thị các cấp tiêu đề từ lớn đến nhỏ.

```markdown
# Tiêu đề cấp 1

## Tiêu đề cấp 2

### Tiêu đề cấp 3

#### Tiêu đề cấp 4

##### Tiêu đề cấp 5

###### Tiêu đề cấp 6
```

**Phím tắc** : `Ctrl + Shift + ]` hoặc `Ctrl + Shift + [`

## Văn bản nhấn mạnh

- In đậm (Bold) : bao văn bản bằng hai dấu \*\* hoặc \_\_.
  ```markdown
  **In đậm** hoặc **In đậm**
  ```
  **Phím tắc** : `Ctrl + B`
- In nghiên (Italic) : bao văn bản bằng một dấu \* hoặc \_.
  ```markdown
  _In nghiêng_ hoặc _In nghiêng_
  ```
  **Phím tắc** : `Ctrl + I`
- Gạch ngang (Strikethrough) : bao văn bản bằng hai dấu ~~.
  ```markdown
  ~~Văn bản gạch dưới~~
  ```
  **Phím tắc** : `Alt + S`

## Liên kết (Links)

Markdown hỗ trợ chèn liên kết bằng cú pháp [văn bản hiển thị](URL).

```markdown
[Google](https://www.google.com)
```

## Hình ảnh (Images)

Markdown hỗ trợ chèn hình ảnh bằng cú pháp ![văn bản hiển thị](URL).

```markdown
![Alt text](URL-hình-ảnh)
```

## Danh sách

- Danh sách không có thứ tự (Unordered List) : Sử dụng dấu -, \*, hoặc + để tạo danh sách không thứ tự.

  ```markdown
  - Mục 1
  - Mục 2

  * Mục 3
  ```

- Danh sách có thứ tự (Ordered List) : Sử dụng các con số kèm theo dấu chấm.
  ```
  1. Mục 1
  2. Mục 2
  ```

## Khối mã lệnh (Code Blocks)

- Mã inline : bao mã bằng dấu `.
  ```markdown
  Đây là `mã inline`.
  ```
- Khối mã (Code Block) : bao mã bằng ``` và chỉ định ngôn ngữ lập trình (tùy chọn)

  ````
    \```python
    def hello_world():
    print("Hello, World!")
    \```

    bỏ \ đi là được 😊
  ````

## Trích dẫn (Blockquotes)

Sử dụng dấu > ở đầu dòng để tạo trích dẫn.

```markdown
> Đây là một trích dẫn.
```

## Đường kẻ ngang (Horizontal Line)

Để tạo một đường kẻ ngang, sử dụng ba dấu --- hoặc \*\*\* trên một dòng.

```markdown
---
---
```

## Bảng (Tables)

Để tạo bảng, sử dụng dấu | để ngăn cách các cột và dấu - để tạo hàng tiêu đề.

```markdown
| Cột 1     | Cột 2     | Cột 3     |
| --------- | --------- | --------- |
| Dữ liệu 1 | Dữ liệu 2 | Dữ liệu 3 |
```

## Danh sách kiểm tra (Checklist)

Để tạo danh sách kiểm tra, sử dụng [ ] cho mục chưa hoàn thành và [x] cho mục đã hoàn thành.

```markdown
- [x] Mục đã hoàn thành
- [ ] Mục chưa hoàn thành
```

## Biểu thức toán học (Math)

Để chèn biểu thức toán học (nếu được hỗ trợ), sử dụng $ cho inline math và $$ cho khối công thức.

```markdown
Inline: $E = mc^2$
Block:

$$
E = mc^2
$$
```

## Mục lục

Trong Markdown, các tiêu đề được viết bằng dấu #, có thể tạo liên kết đến các tiêu đề đó bằng cách sử dụng ký tự - thay cho khoảng trắng, và viết thường toàn bộ chữ cái trong tiêu đề.

```markdown
## Mục lục

- [Tiêu đề chính](#tiêu-đề-chính)
  - [Tiêu đề phụ 1](#tiêu-đề-phụ-1)
  - [Tiêu đề phụ 2](#tiêu-đề-phụ-2)
```
