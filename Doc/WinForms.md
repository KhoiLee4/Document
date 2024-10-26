# WinForms

## 📚Control

### 📙Control cơ bản

#### 📘Label

Mục đích: Hiển thị văn bản tĩnh, làm tiêu đề hoặc mô tả cho các control khác.

Thuộc tính:
- `Text`: Thiết lập hoặc lấy văn bản hiển thị trên `label`.
- `Font`: Thay đổi kiểu và kích thước font chữ.
- `ForeColor`, `BackColor`: Thiết lập màu nền và màu chữ.

Cách sử dụng: Thường được sử dụng cùng với `TextBox` hoặc `ComboBox` để mô tả cho các trường nhập liệu.

#### 📘TextBox

Mục đích: Cho phép người dùng nhập dữ liệu dạng văn bản.

Thuộc tính:
- `Text`: Văn bản hiển thị hoặc nhập vào.
- `PasswordChar`: Hiển thị ký tự thay thế, thường dùng cho trường mật khẩu.
- `Multiline`: Cho phép nhập văn bản nhiều dòng.

Sự kiện:
- `TextChanged`: Kích hoạt khi văn bản trong `TextBox` thay đổi.
- `KeyPress`: Xử lý từng ký tự khi người dùng gõ vào `TextBox`.

#### 📘Button

Mục đích: Kích hoạt một hành động khi được nhấn.

Thuộc tính:
- `Text`: Văn bản hiển thị trên nút.
- `Enabled`: Bật hoặc tắt khả năng nhấn của nút.

Sự kiện:
- `Click`: Xử lý sự kiện khi nút được nhấn.

#### 📘ComboBox

Mục đích: Cho phép người dùng chọn một giá trị từ danh sách sổ xuống.

Thuộc tính:
- `Items`: Danh sách các mục có thể chọn.
- `SelectedIndex`, `SelectedItem`: Xác định hoặc lấy mục được chọn.

Sự kiện:
- `SelectedIndexChanged`: Kích hoạt khi mục chọn trong ComboBox thay đổi.

#### 📘CheckBox

Mục đích: Lựa chọn có/không hoặc đúng/sai.

Thuộc tính:
- `Checked`: Xác định trạng thái đã chọn hay chưa.

Sự kiện:
- `CheckedChanged`: Kích hoạt khi trạng thái chọn thay đổi.

#### 📘RadioButton

Mục đích: Lựa chọn một trong nhiều tùy chọn.

Thuộc tính:
- `Checked`: Xác định trạng thái đã chọn hay chưa.

Sự kiện:
- `CheckedChanged`: Kích hoạt khi trạng thái chọn thay đổi.

### 📙Control nâng cao

#### 📘ListBox

Mục đích: Hiển thị danh sách các mục mà người dùng có thể chọn.

Thuộc tính:
- `Items`: Danh sách các mục.
- `SelectionMode`: Cho phép chọn nhiều mục.

Sự kiện:
- `SelectedIndexChanged`: Kích hoạt khi mục chọn thay đổi.

#### 📘DataGridView

Mục đích: Hiển thị và chỉnh sửa dữ liệu dạng bảng.

Thuộc tính:
- `Columns`, `Rows`: Cấu hình và quản lý cột, hàng trong bảng.
- `DataSource`: Gắn kết dữ liệu từ nguồn (ví dụ: từ database).

Sự kiện:
- `CellClick`, `CellValueChanged`: Xử lý các thay đổi hoặc sự kiện khi nhấp vào ô trong bảng.

#### 📘PictureBox

Mục đích: Hiển thị hình ảnh.

Thuộc tính:
- `Image`: Đặt hình ảnh hiển thị.
- `SizeMode`: Kiểm soát cách hình ảnh được điều chỉnh trong PictureBox.

Sự kiện:
- `Click`: Kích hoạt khi hình ảnh được nhấn vào.

#### 📘ProgressBar

Mục đích: Hiển thị tiến trình của một tác vụ.

Thuộc tính:
- `Minimum`, `Maximum`: Xác định phạm vi giá trị của tiến trình.
- `Value`: Giá trị hiện tại của tiến trình.

Cách sử dụng: Phù hợp với các tác vụ nền hoặc tác vụ có thời gian thực hiện dài.

#### 📘TabControl

Mục đích: Tạo giao diện nhiều tab để quản lý nội dung đa dạng.

Thuộc tính:
- `TabPages`: Danh sách các trang trong TabControl.

Sự kiện:
- `SelectedIndexChanged`: Kích hoạt khi tab được chọn thay đổi.

#### 📘TreeView

Mục đích: Hiển thị dữ liệu phân cấp dạng cây (ví dụ: các thư mục trong hệ thống file).

Thuộc tính:
- `Nodes`: Các nút con trong cây, có thể có cấu trúc lồng nhau.

Sự kiện:
- `AfterSelect`: Xử lý khi người dùng chọn một nút trong cây.

## 📚Events (Sự kiện)

Hiểu và sử dụng các sự kiện như Click, TextChanged, SelectedIndexChanged.
Các sự kiện của Form như Load, Closing, Closed.

### 📙Các thành phần chính trong Events

**Event**: Là một hành động xảy ra khi người dùng tương tác với control hoặc khi có một sự kiện từ hệ thống. Mỗi sự kiện đều có tên riêng (như `Click`, `TextChanged`, `MouseHover`).

**Event Handler**: Là một hàm (method) được gọi khi sự kiện xảy ra. Event Handler chứa mã để xử lý sự kiện và giúp bạn định nghĩa các hành động cụ thể khi sự kiện kích hoạt. Ví dụ, `button1_Click` là một Event Handler thường được dùng khi người dùng nhấn vào `button1`.

**Event Arguments**: Đối tượng `EventArgs` chứa thông tin bổ sung về sự kiện và được truyền vào Event Handler. Một số sự kiện có các đối số đặc biệt để cung cấp thông tin chi tiết hơn, ví dụ: `MouseEventArgs` chứa tọa độ của con trỏ chuột khi sự kiện `MouseClick` xảy ra.

### 📙Button Events

Click: Xảy ra khi người dùng nhấn vào nút. Thực hiện hành động cụ thể, như lưu dữ liệu hoặc chuyển đổi giao diện.

```C#
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show("Button Clicked!");
}
```

### 📙TextBox Events

TextChanged: Kích hoạt khi văn bản trong `TextBox` thay đổi. Xử lý hoặc kiểm tra dữ liệu ngay khi người dùng nhập.

```C#
private void textBox1_TextChanged(object sender, EventArgs e)
{
    if (textBox1.Text.Length > 5)
    {
        MessageBox.Show("Text is longer than 5 characters!");
    }
}
```

KeyPress: Kích hoạt khi một phím được nhấn khi `TextBox` đang hoạt động. Kiểm soát các ký tự được nhập vào, ví dụ giới hạn chỉ nhập số.

```C#
private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
{
    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
    {
        e.Handled = true; // Ngăn không cho nhập ký tự không phải số
    }
}
```

### 📙ComboBox Events

SelectedIndexChanged: Xảy ra khi mục chọn trong `ComboBox` thay đổi. Lấy giá trị được chọn và thực hiện các thay đổi liên quan.

```C#
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    MessageBox.Show("Selected item: " + comboBox1.SelectedItem.ToString());
}
```

### 📙Form Events

Load: Kích hoạt khi form được tải và hiển thị lần đầu tiên. Thiết lập các giá trị ban đầu của form hoặc khởi tạo các dữ liệu cần thiết.

```C#
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Form is loaded!");
}
```

FormClosing: Kích hoạt khi form bắt đầu đóng. Hỏi người dùng có chắc chắn muốn đóng form không hoặc thực hiện lưu trữ dữ liệu.

```C#
private void Form1_FormClosing(object sender, FormClosingEventArgs e)
{
    var result = MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo);
    if (result == DialogResult.No)
    {
        e.Cancel = true; // Ngăn không cho form đóng
    }
}
```

### 📙Mouse Events

MouseClick: Kích hoạt khi người dùng nhấn chuột vào control.

MouseHover: Kích hoạt khi con trỏ chuột di chuyển lên control và dừng lại.

MouseMove: Kích hoạt khi con trỏ chuột di chuyển trên control.

```C#
private void button1_MouseHover(object sender, EventArgs e)
{
    button1.BackColor = Color.LightBlue; // Đổi màu khi di chuột vào
}
```

### 📙Timer Events

Tick: Kích hoạt theo chu kỳ được thiết lập, ví dụ 1 giây/lần. Thực hiện các tác vụ theo chu kỳ, như cập nhật thời gian.

```C#
private void timer1_Tick(object sender, EventArgs e)
{
    labelTime.Text = DateTime.Now.ToString("hh:mm:ss");
}
```

### 📙Đăng ký và hủy Event (Event Subscription & Unsubscription)

Đăng ký sự kiện: Sự kiện thường được tự động đăng ký khi bạn nhấn đúp vào control trong Visual Studio. Tuy nhiên, có thể thêm thủ công.

```C#
button1.Click += new EventHandler(button1_Click);
```

Hủy đăng ký sự kiện: Có thể hủy đăng ký sự kiện nếu không còn cần thiết, giúp tối ưu hiệu suất.

```C#
button1.Click -= new EventHandler(button1_Click);
```

### 📙Lưu ý

Quản lý Event Handler: Không nên thêm quá nhiều Event Handler cho một sự kiện, có thể dẫn đến hiệu suất kém hoặc kết quả không mong muốn.

Đa luồng: Khi làm việc với các thao tác nền (background tasks) như sử dụng BackgroundWorker hoặc async, cần đảm bảo Event Handler tương tác đúng với UI.

Chuyển tiếp sự kiện (Event Bubbling): WinForms không hỗ trợ "bubbling" như web, nên cần quản lý sự kiện cụ thể với từng control.

## 📚Layout và quản lý giao diện

Sử dụng Panel, GroupBox, TabControl để tổ chức các control.
Anchor và Dock để đảm bảo giao diện có thể thay đổi theo kích thước Form.
Sử dụng TableLayoutPanel và FlowLayoutPanel để tạo giao diện động.

## 📚Tổ chức code trong dự án

MVC (Model-View-Controller): Tách biệt logic xử lý (Controller), giao diện người dùng (View), và dữ liệu (Model).
MVVM (Model-View-ViewModel): Phù hợp khi muốn có logic và giao diện tách rời mạnh mẽ hơn.
Đặt các lớp và thư mục theo chức năng, ví dụ như Models, Services, Views, Utilities.

## 📚Thiết kế module:

Tạo các lớp xử lý dữ liệu (service) riêng biệt như UserService, ProductService.
Dependency Injection: Giúp các lớp dễ dàng tương tác mà không phụ thuộc lẫn nhau.

## 📚ADO.NET

**ADO.NET** là một phần của nền tảng .NET, cung cấp các thư viện cần thiết để kết nối và làm việc với các nguồn dữ liệu, như cơ sở dữ liệu quan hệ (SQL Server, Oracle, MySQL) và các dữ liệu XML.

### 📙Các thành phần chính của ADO.NET

#### 📘Connection (Kết nối)

**Connection** được sử dụng để mở một kết nối đến cơ sở dữ liệu.

Mỗi loại cơ sở dữ liệu cần một loại connection khác nhau.
- `SqlConnection` dành cho SQL Server.
- `OleDbConnection` dành cho các nguồn dữ liệu hỗ trợ OLE DB.
- `OdbcConnection` dành cho các nguồn dữ liệu hỗ trợ ODBC.

```C#
string connectionString = "Data Source=server_name;Initial Catalog=database_name;User ID=user;Password=password;";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    Console.WriteLine("Kết nối thành công!");
}
```

#### 📘Command (Lệnh)

**Command** là thành phần giúp gửi các lệnh SQL hoặc các Stored Procedure đến cơ sở dữ liệu. Command có thể thực thi các lệnh như SELECT, INSERT, UPDATE, DELETE hoặc gọi các stored procedures.

Các lớp `SqlCommand`, `OleDbCommand`, và `OdbcCommand` giúp thực thi các lệnh.

```C#
using (SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection))
{
    using (SqlDataReader reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine(reader["EmployeeName"].ToString());
        }
    }
}
```

#### 📘DataReader (Đọc dữ liệu)

**DataReader** là thành phần để đọc dữ liệu từ cơ sở dữ liệu theo kiểu luồng (forward-only). Nó cung cấp khả năng đọc dữ liệu rất nhanh nhưng chỉ đọc một chiều và không cho phép thay đổi dữ liệu.

Các lớp `SqlDataReader`, `OleDbDataReader`, và `OdbcDataReader` được sử dụng cho các kiểu cơ sở dữ liệu tương ứng.

```C#
SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection);
SqlDataReader reader = command.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader["EmployeeName"].ToString());
}
reader.Close();
```

#### 📘DataAdapter (Bộ chuyển đổi dữ liệu)

**DataAdapter** là cầu nối giữa `DataSet` và nguồn dữ liệu. Nó dùng để điền dữ liệu từ cơ sở dữ liệu vào `DataSet` và cập nhật ngược lại từ `DataSet` về cơ sở dữ liệu.

DataAdapter bao gồm các command như `SelectCommand`, `InsertCommand`, `UpdateCommand`, và `DeleteCommand`.

```C#
string query = "SELECT * FROM Employees";
SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
DataSet dataSet = new DataSet();
adapter.Fill(dataSet, "Employees");

foreach (DataRow row in dataSet.Tables["Employees"].Rows)
{
    Console.WriteLine(row["EmployeeName"]);
}
```

#### 📘DataSet (Tập hợp dữ liệu)

**DataSet** là một vùng lưu trữ dữ liệu trên bộ nhớ (in-memory) và có thể lưu trữ nhiều bảng cùng lúc.

DataSet không phụ thuộc vào cơ sở dữ liệu, tức là bạn có thể làm việc với dữ liệu ngay cả khi ngắt kết nối với nguồn dữ liệu.

Nó hữu ích khi làm việc với dữ liệu phức tạp hoặc nhiều bảng.

### 📙Stored Procedures

> bổ sung sau

### 📙Giao tác (Transaction)

**Giao tác** được dùng để đảm bảo các lệnh SQL thực thi một cách toàn vẹn. Nếu một lệnh thất bại, toàn bộ quá trình có thể được hồi phục (rollback). ADO.NET hỗ trợ `SqlTransaction` để quản lý giao tác.

```C#
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    SqlTransaction transaction = connection.BeginTransaction();
    SqlCommand command = connection.CreateCommand();
    command.Transaction = transaction;

    try
    {
        command.CommandText = "INSERT INTO Employees (Name) VALUES ('John')";
        command.ExecuteNonQuery();

        command.CommandText = "INSERT INTO Employees (Name) VALUES ('Jane')";
        command.ExecuteNonQuery();

        transaction.Commit(); // Xác nhận giao tác
    }
    catch
    {
        transaction.Rollback(); // Hủy giao tác nếu có lỗi
    }
}
```

### 📙Ngoại lệ thường gặp

**SqlException**: Lỗi xảy ra khi câu lệnh SQL không hợp lệ hoặc có lỗi kết nối.

**InvalidOperationException**: Lỗi xảy ra khi thực hiện các thao tác không hợp lệ với kết nối hoặc lệnh.

**TimeoutException**: Lỗi khi kết nối hoặc truy vấn mất quá nhiều thời gian để hoàn thành.

### 📙Lưu ý

Quản lý tài nguyên: Luôn đóng kết nối và giải phóng tài nguyên khi không còn sử dụng bằng using.

Parameter hóa câu lệnh SQL: Tránh lỗi SQL Injection bằng cách sử dụng các tham số (`SqlParameter`) thay vì nối chuỗi trong câu lệnh SQL.

```C#
string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";
SqlCommand command = new SqlCommand(query, connection);
command.Parameters.AddWithValue("@EmployeeID", 1); // sử dụng Parameter

using (SqlDataReader reader = command.ExecuteReader())
{
    while (reader.Read())
    {
        Console.WriteLine(reader["EmployeeName"].ToString());
    }
}
```

Quản lý ngoại lệ (Exception Handling): Bọc các câu lệnh trong try-catch để xử lý lỗi.

### 📙Sử dụng LINQ

Khi sử dụng ADO.NET để kết nối và tải dữ liệu vào DataSet hoặc DataTable, bạn có thể sử dụng LINQ để thực hiện các truy vấn, lọc dữ liệu, hoặc sắp xếp mà không cần viết thêm câu lệnh SQL.

```C#
DataTable dataTable = new DataTable();
// Giả sử dataTable đã được tải dữ liệu bằng DataAdapter

var results = from row in dataTable.AsEnumerable()
              where row.Field<int>("Age") > 25
              select new
              {
                  Name = row.Field<string>("Name"),
                  Age = row.Field<int>("Age")
              };

foreach (var result in results)
{
    Console.WriteLine($"{result.Name} - {result.Age}");
}
```

## 📚Entity Framework (EF)

**Entity Framework (EF)** là một **ORM (Object-Relational Mapping)** mạnh mẽ của Microsoft dành cho .NET, giúp dễ dàng làm việc với cơ sở dữ liệu dưới dạng các đối tượng trong mã C# mà không cần viết câu lệnh SQL trực tiếp. 

EF tự động ánh xạ các bảng và cột trong cơ sở dữ liệu thành các lớp và thuộc tính tương ứng trong ứng dụng, giúp quản lý dữ liệu trực quan và đơn giản hơn.

### 📙Phương Pháp Tiếp Cận

**Code First**: Dùng khi tạo lớp C# trước rồi EF sẽ tự tạo cơ sở dữ liệu dựa trên các lớp này.

**Database First**: Dùng khi đã có một cơ sở dữ liệu có sẵn; EF sẽ tạo ra các lớp mô hình từ cơ sở dữ liệu.

**Model First**: Tạo một mô hình bằng công cụ thiết kế của EF, sau đó EF sẽ tự động tạo cơ sở dữ liệu và mã cho mô hình này.

### 📙Sử dụng LINQ

EF tích hợp LINQ, giúp truy vấn dữ liệu dễ dàng và hiệu quả. Cung cấp các phương thức như `Where`, `OrderBy`, `Select`,... để thực hiện các truy vấn phức tạp một cách dễ đọc.

```C#
using (var context = new AppDbContext())
{
    var developers = context.Employees
                            .Where(e => e.Position == "Developer")
                            .OrderBy(e => e.Name)
                            .ToList();
}
```

### 📙CRUD

Kết nối

```C#
public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionString");
    }
}
```

Thêm mới dữ liệu

```C#
using (var context = new AppDbContext())
{
    var employee = new Employee { Name = "Alice", Age = 28, Position = "Developer" };
    context.Employees.Add(employee);
    context.SaveChanges();
}
```

Đọc dữ liệu

```C#
using (var context = new AppDbContext())
{
    var employees = context.Employees.ToList();
    foreach (var employee in employees)
    {
        Console.WriteLine($"Name: {employee.Name}, Position: {employee.Position}");
    }
}
```

Cập nhật dữ liệu

```C#
using (var context = new AppDbContext())
{
    var employee = context.Employees.FirstOrDefault(e => e.Name == "Alice");
    if (employee != null)
    {
        employee.Position = "Senior Developer";
        context.SaveChanges();
    }
}
```

Xóa dữ liệu

```C#
using (var context = new AppDbContext())
{
    var employee = context.Employees.FirstOrDefault(e => e.Name == "Alice");
    if (employee != null)
    {
        context.Employees.Remove(employee);
        context.SaveChanges();
    }
}
```

### 📙Các Tính Năng Nâng Cao

**Lazy Loading**: Tự động tải dữ liệu liên quan khi cần (cần cẩn thận để tránh việc tải không cần thiết).

**Eager Loading**: Dùng phương thức `Include` để tải trước các dữ liệu liên quan:

```C#
var employeesWithDepartments = context.Employees.Include(e => e.Department).ToList();
```

**Transactions**: Cho phép thực hiện nhiều thao tác dữ liệu trong một giao tác để đảm bảo tính toàn vẹn của dữ liệu.

```C#
using (var transaction = context.Database.BeginTransaction())
{
    try
    {
        // Các thao tác dữ liệu
        context.SaveChanges();
        transaction.Commit();
    }
    catch
    {
        transaction.Rollback();
    }
}
```

Sử dụng `AsNoTracking` khi chỉ cần đọc dữ liệu để tăng hiệu năng

```C#
using (var context = new AppDbContext())
{
    // Truy vấn không theo dõi
    var employees = context.Employees
                           .AsNoTracking()
                           .Where(e => e.Age > 25)
                           .ToList();

    foreach (var employee in employees)
    {
        Console.WriteLine($"{employee.Name} - {employee.Age}");
    }
}
```

## 📚Data Binding và hiển thị dữ liệu

 
## 📚BackgroundWorker và Task

### 📙BackgroundWorker

`BackgroundWorker` là một công cụ trong WinForms dành cho các tác vụ chạy nền, thường được sử dụng cho các công việc dài như tải dữ liệu từ cơ sở dữ liệu, tính toán phức tạp hoặc xử lý tệp mà không làm đóng băng giao diện người dùng.

#### 📘Sự kiện chính

`DoWork`: Được kích hoạt khi bắt đầu chạy `BackgroundWorker`, và là nơi thực hiện các công việc nặng.

`ProgressChanged`: Dùng để báo cáo tiến độ. Điều này hữu ích khi bạn muốn cập nhật giao diện người dùng (ví dụ: ProgressBar).

`RunWorkerCompleted`: Được kích hoạt khi `DoWork` hoàn thành hoặc bị hủy. Đây là nơi bạn thực hiện các công việc sau khi hoàn thành, như hiển thị thông báo hoặc xử lý kết quả.

```C#
BackgroundWorker backgroundWorker = new BackgroundWorker
{
    WorkerReportsProgress = true,
    WorkerSupportsCancellation = true
};

backgroundWorker.DoWork += (sender, e) =>
{
    for (int i = 0; i <= 100; i++)
    {
        if (backgroundWorker.CancellationPending)
        {
            e.Cancel = true;
            return;
        }
        // Công việc cần thực hiện
        System.Threading.Thread.Sleep(50); // Giả lập thời gian xử lý
        backgroundWorker.ReportProgress(i);
    }
};

backgroundWorker.ProgressChanged += (sender, e) =>
{
    progressBar.Value = e.ProgressPercentage; // Cập nhật giao diện người dùng
};

backgroundWorker.RunWorkerCompleted += (sender, e) =>
{
    if (e.Cancelled)
    {
        MessageBox.Show("Đã hủy tác vụ.");
    }
    else
    {
        MessageBox.Show("Hoàn thành tác vụ.");
    }
};

// Khởi chạy tác vụ
backgroundWorker.RunWorkerAsync();
```

#### 📘Ưu điểm

Dễ sử dụng cho các tác vụ đơn giản hoặc xử lý nền cần báo cáo tiến độ.

Được thiết kế riêng cho WinForms, có sự kiện `ProgressChanged` để dễ dàng cập nhật giao diện người dùng.

#### 📘Nhược điểm

Hạn chế khi xử lý tác vụ phức tạp hoặc nhiều tác vụ song song.

Không linh hoạt bằng `Task`, và không phù hợp cho các ứng dụng hiện đại như WPF hay ASP.NET Core.

### 📙Task (System.Threading.Tasks)

`Task` là một phần của Thư viện **Task Parallel Library (TPL)** trong .NET và cung cấp khả năng xử lý bất đồng bộ hiện đại, mạnh mẽ. `Task` rất linh hoạt, có thể xử lý tác vụ song song, đợi các tác vụ hoàn thành, xử lý ngoại lệ và dễ dàng kết hợp với từ khóa `async`/`await`.

```C#
private async void StartTaskButton_Click(object sender, EventArgs e)
{
    progressBar.Value = 0;
    try
    {
        int result = await Task.Run(() => PerformLongTask());
        MessageBox.Show($"Tác vụ hoàn tất với kết quả: {result}");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Lỗi xảy ra: {ex.Message}");
    }
}

private int PerformLongTask()
{
    for (int i = 0; i <= 100; i++)
    {
        // Giả lập công việc
        System.Threading.Thread.Sleep(50); // Công việc xử lý lâu
        this.Invoke((MethodInvoker)delegate
        {
            progressBar.Value = i; // Cập nhật giao diện người dùng
        });
    }
    return 100; // Giá trị trả về ví dụ
}
```

#### 📘Ưu điểm

Dễ kết hợp với `async`/`await`: Giúp mã dễ đọc hơn và không cần nhiều sự kiện như `BackgroundWorker`.

Linh hoạt: `Task` phù hợp cho nhiều kiểu ứng dụng khác nhau, từ WinForms đến các ứng dụng ASP.NET Core, WPF.

Hỗ trợ song song: `Task` cho phép thực hiện nhiều tác vụ đồng thời bằng cách sử dụng `Task.WhenAll` hoặc `Task.WhenAny`.

#### 📘Nhược điểm

Không có sẵn sự kiện `ProgressChanged`: phải tự cập nhật thủ công giao diện người dùng nếu muốn báo cáo tiến độ.

Khó khăn khi làm việc với giao diện người dùng: Các thay đổi trực tiếp trên UI từ các Task cần phải được gọi bằng cách chuyển về UI thread, ví dụ như sử dụng `Invoke`.

*Đọc thêm [Asynchronous](CSharp.md#Asynchronous)*

## 📚ProgressBar và Loading Indicator

Kết hợp với ProgressBar để hiển thị tiến trình xử lý dữ liệu lớn hoặc tác vụ mạng.

## 📚Lập trình bất đồng bộ (Async/Await)

## 📚File Handling:

## 📚Quản lý trạng thái của ứng dụng:

Sử dụng các biến toàn cục hoặc lớp lưu trữ dữ liệu tạm thời để quản lý trạng thái ứng dụng.
Sử dụng lớp App.config để lưu trữ các cấu hình cần thiết.

## 📚Form đa tầng (Multi-layered Form):

Làm việc với nhiều form, truyền dữ liệu giữa các form và quản lý hành vi các form.
Tạo ứng dụng đa tầng (ví dụ: tầng UI, tầng Service, tầng Model) để tách biệt các chức năng và tổ chức dự án một cách chuyên nghiệp.

## 📚Sử dụng API:

Gửi các yêu cầu HTTP với HttpClient trong C#.
Đọc và xử lý dữ liệu JSON từ các dịch vụ web.
REST API: Tìm hiểu về các phương thức GET, POST, PUT, và DELETE.

## 📚Tích hợp với Web API:

## 📚Xây dựng ứng dụng WinForms với SignalR:

## 📚OAuth và xác thực người dùng:

Tích hợp đăng nhập bằng Google hoặc Facebook với thư viện OAuth.
Sử dụng token để xác thực và bảo mật các yêu cầu API.


## 📚Bảo mật ứng dụng:

Mã hóa thông tin nhạy cảm và sử dụng App.config để lưu trữ các thông tin cấu hình bảo mật.
Quản lý quyền truy cập và sử dụng xác thực người dùng trong các ứng dụng WinForms

## 📚Đóng gói ứng dụng:

Tạo file cài đặt (.exe hoặc .msi) để người dùng có thể cài đặt ứng dụng.
Sử dụng ClickOnce hoặc Windows Installer để tạo các bản phát hành.

## 📚Triển khai và bảo trì:

Các cách cập nhật phần mềm sau khi triển khai.
Lập kế hoạch cho việc bảo trì và cập nhật các tính năng mới.