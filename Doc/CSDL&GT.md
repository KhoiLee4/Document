#####-----Cấu trúc dữ liệu(Data Structure) & Thuật toán(Algorithms)-----#####

#####-----Cấu trúc-----#####

*** Cấu trúc dữ liệu(Data Structure) là cách lập trình để lưu trữ dữ liệu để dữ liệu có thể 
được sử dụng một cách hiệu quả. Hầu hết mọi ứng dụng doanh nghiệp đều sử dụng nhiều kiểu 
cấu trúc dữ liệu khác nhau theo cách này hay cách khác, vì nó mang lại nhiều lợi ích rất 
lớn không chỉ cho việc lưu trữ dữ liệu.

*** Thuật toán(Algorithms) là một thủ tục từng bước, xác định một tập hợp các lệnh được 
thực hiện theo một thứ tự nhất định để có được đầu ra mong muốn.

*** Phân tích tiệm cận(Asymptotic analysis) của một thuật toán đề cập đến việc xác định giới 
hạn / khung toán học đối với hiệu suất thời gian chạy của nó. Sử dụng phân tích tiệm cận, 
chúng ta rất có thể kết luận trường hợp tốt nhất, trường hợp trung bình và trường hợp xấu 
nhất của một thuật toán.

*** Chia để trị(Divide and Conquer), bài toán được chia thành các bài toán con nhỏ hơn và 
sau đó mỗi bài toán được giải quyết độc lập. Khi chúng ta tiếp tục chia các bài toán con 
thành các bài toán con nhỏ hơn, cuối cùng chúng ta có thể đạt đến một giai đoạn mà không 
thể phân chia được nữa. Những vấn đề con nhỏ nhất có thể có “nguyên tử” (phân số) được 
giải quyết. Lời giải của tất cả các bài toán con cuối cùng được hợp nhất để có được lời 
giải của một bài toán ban đầu.

*** Giao diện(Interface) – Mỗi cấu trúc dữ liệu có một Interface(giao diện). 
Giao diện này đại diện cho tập hợp các hành động(phương thức) mà một cấu trúc dữ liệu có. 
Một giao diện(Interface) chỉ cung cấp danh sách các hành động mà nó được hỗ trợ, loại tham 
số mà chúng có thể chấp nhận và kiểu trả về của các hành động này.

*** Triển khai(Implementation) – Việc sử dụng các cấu trúc dữ liệu với các thuật toán thông 
qua việc sử dụng trong các hành động của cấu trúc dữ liệu.

*** Độ chính xác(Correctness) – Việc triển khai cấu trúc dữ liệu phải triển khai đúng 
interface(giao diện) của nó.

*** Độ phức tạp về thời gian(Time Complexity) – Thời gian chạy hoặc thời gian thực hiện các 
hoạt động của cấu trúc dữ liệu phải càng nhỏ càng tốt.

- Độ phức tạp về không gian(Space Complexity) – Việc sử dụng bộ nhớ của một hoạt động của 
cấu trúc dữ liệu càng ít càng tốt.

- Dữ liệu(Data) – Dữ liệu là các giá trị hoặc tập hợp các giá trị.

- Mục dữ liệu(Data Item) hay phần tử trong dữ liệu – Mục dữ liệu đề cập đến một đơn vị giá 
trị nào đó trong dữ liệu.

- Nhóm các mục(Group Items) hay nhóm các phần tử – Các mục dữ liệu được chia thành các 
mục con được gọi là Nhóm các Mục.

- Mục Cơ bản(Elementary Items) – Các mục dữ liệu không thể chia được gọi là Mục Cơ bản.

- Thuộc tính và thực thể(Attribute and Entity) – Thực thể(Entity) là một thực thể chứa 
các thuộc tính(Attribute) hoặc một thuộc tính nhất định, có thể được gán giá trị.

- Tập hợp các thực thể(Entity Set) – Các thực thể có các thuộc tính giống nhau tạo thành 
một tập hợp các thực thể.

- Trường(Field) – Trường là một đơn vị thông tin cơ bản đại diện cho một thuộc tính của 
một thực thể.

- Bản ghi(Record) – Bản ghi là một tập hợp các giá trị của một trường trong một thực 
thể nhất định.

- Tệp(File) – Tệp là một tập hợp các bản ghi của các thực thể trong một tập thực thể 
nhất định.

- Tìm kiếm(Search) – Thuật toán tìm kiếm một mục(phần tử) trong cấu trúc dữ liệu.

- Sắp xếp(Sort) – Thuật toán sắp xếp các mục theo một thứ tự nhất định.

- Chèn(Insert) – Thuật toán chèn mục trong cấu trúc dữ liệu.

- Cập nhật(Update) – Thuật toán cập nhật một mục hiện có trong cấu trúc dữ liệu.

- Xóa(Delete) – Thuật toán xóa một mục hiện có khỏi cấu trúc dữ liệu.

- Rõ ràng(Unambiguous) – Thuật toán phải rõ ràng và rõ ràng. Mỗi bước (hoặc giai đoạn) 
của nó, và đầu vào / đầu ra của chúng phải rõ ràng và chỉ dẫn đến một ý nghĩa.

- Đầu vào(Input) – Một thuật toán phải có 0 hoặc nhiều đầu vào được xác định rõ.

- Đầu ra(Output) – Một thuật toán phải có 1 hoặc nhiều đầu ra được xác định rõ ràng và 
phải phù hợp với đầu ra mong muốn.

- Tính hữu hạn(Finiteness) – Thuật toán phải kết thúc sau một số bước hữu hạn.

- Tính khả thi(Feasibility) – Phải khả thi với các nguồn lực sẵn có(tài nguyên, thiết bị 
hiện có).

- Độc lập(Independent) – Một thuật toán nên có hướng dẫn từng bước, điều này phải độc lập 
với bất kỳ code lập trình nào.

- Yếu tố thời gian(Time Factor) – Thời gian được đo bằng cách đếm số lượng các thao tác 
chính như việc so sánh trong thuật toán sắp xếp.

- Hệ số không gian(Space Factor) – Không gian được đo bằng cách đếm không gian bộ nhớ tối 
đa mà thuật toán yêu cầu.

- Trường hợp tốt nhất(Best Case) – Thời gian tối thiểu cần thiết để thực hiện chương trình.

- Trường hợp trung bình(Average Case ) – Thời gian trung bình cần thiết để thực hiện chương trình.

- Trường hợp xấu nhất(Worst Case) – Thời gian tối đa cần thiết để thực hiện chương trình.

- Ký hiệu tiệm cận
    Ký hiệu Big Oh, Ο (trường hợp xấu nhất)
    Ký hiệu Omega, Ω (trường hợp tốt nhất)
    Ký hiệu Theta, θ (giới hạn dưới và giới hạn trên của thời gian chạy)

- Các ký hiệu tiệm cận phổ biến
    | constant(hằng)	  | Ο(1)       |
    | logarithmic	      | Ο(log n)   |
    | linear(tuyến tính)  | Ο(n)       |
    | n log n	          | Ο(n*log n) |
    | quadratic(bậc 2)	  | Ο(n^2)     |
    | cubic(khối)	      | Ο(n^3)     |
    | polynomial(đa thức) | n^Ο(1)     |
    | exponential(mũ số)  | 2^Ο(n)     |

- Nguyên tử(Atomic) – Định nghĩa sẽ xác định một khái niệm duy nhất.

- Có thể theo dõi(Traceable) – Định nghĩa có thể được ánh xạ tới một số phần tử dữ liệu.

- Chính xác(Accurate) – Định nghĩa phải rõ ràng.

- Rõ ràng và ngắn gọn(Clear and Concise) – Định nghĩa phải dễ hiểu.

//////////////////////////////////////////
##-Danh sách liên kết đơn – Singly Linked List-##

**Mô tả**
- Một Linked List (danh sách liên kết) sẽ được biểu diễn bởi một con trỏ (pointer) trỏ đến 
node đầu tiên của Linked List đó. Node đầu tiên của Linked List được gọi là node head. 
Nếu Linked List là trống, giá trị của node head sẽ là NULL.

- Mỗi node ở bên trong một Linked List sẽ bao gồm ít nhất hai thành phần sau:
1. data (dữ liệu, có thể là kiểu số, kiểu ký tự, …)
2. pointer (con trỏ) hoặc có thể hiểu là reference (tham chiếu) tới node tiếp theo trong 
Linked List.

**Ưu điểm**
1. Linked List có kích thước động.
2. Dễ dàng chèn thêm phần tử vào mảng, và xóa phần tử khỏi mảng.

**Nhược điểm**
1. Không thể thực hiện truy cập ngẫu nhiên (random access). Chúng ta phải truy cập đến các 
phần tử của Linked List một cách tuần tự, bắt đầu từ node đầu tiên. Vì vậy chúng ta sẽ 
không thể thực hiện tìm kiếm nhị phân (binary search) với Linked List một cách hiệu quả, 
đối với dạng cài đặt mặc định của Linked List.

2. Mỗi phần tử của Linked List đều chứa một con trỏ (pointer) và cần phải cấp phát bộ nhớ 
(ô nhớ) cho các con trỏ này.

3. Linked List không thân thiện với bộ nhớ cache. Bởi vì các phần tử trong Array được bố 
trí nằm liền kề, liên tiếp nhau, nên chúng ta có thể dễ dàng truy cập đến các phần tử của 
Array thông qua các vị trí tham chiếu được thể hiện bằng các chữ số, trong khi đó điều này 
là không thể đối với Linked List.

**Các hành động**
- Xem file 


//////////////////////////////////////////
##-Danh sách liên kết vòng – Circular Linked List-##

Có 2 loại:
    + danh sách liên kết vòng đơn (singly circular linked list).
    + danh sách liên kết vòng kép (doubly circular linked list).

**Mô tả**
- Danh sách liên kết vòng – Circular linked list là một danh sách liên kết (linked list) 
trong đó tất cả các nodes được kết nối với nhau để tạo thành một vòng tròn. Sẽ không có 
con trỏ NULL ở cuối danh sách liên kết vòng.

**Ưu điểm**
1. Bất kỳ node nào cũng có thể là điểm bắt đầu (starting point). Chúng ta có thể duyệt 
toàn bộ danh sách bằng cách bắt đầu tại bất kỳ điểm nào, tùy ý. Chúng ta chỉ cần dừng lại 
khi node đầu tiên được duyệt, lại được duyệt tới một lần nữa.

2. Danh sách liên kết vòng rất hữu dụng trong việc triển khai queue – hàng đợi. Khi sử 
dụng danh sách liên kết vòng để cài đặt queue, chúng ta sẽ không cần phải duy trì hai 
điểm front (điểm đầu) và rear (điểm cuối) của queue.  Chúng ta chỉ cần duy trì một con 
trỏ dành cho note mới nhất được chèn vào (nằm ở cuối danh sách), lấy node cuối cùng này 
làm mốc, ta có thể dễ dàng truy cập  tới các nodes nằm ở phần đầu danh sách.

3. Danh sách liên kết dạng vòng còn hữu dụng trong các ứng dụng phần mềm, để lặp đi lặp 
lại  danh sách. Ví dụ, khi nhiều ứng dụng đang chạy trên một Máy tính, thông thường hệ 
điều hành sẽ đặt các ứng dụng đang chạy vào một danh sách, và sau đó duyệt qua chúng, mỗi 
lần duyệt tới ứng dụng nào thì lại cho ứng dụng đó một khoảng thời gian để thực thi, và 
sau đó lại đưa chúng về trạng thái đợi trong khi CPU được cấp cho một ứng dụng khác. Vì 
thế, sẽ rất lý tưởng khi hệ điều hành sử dụng một danh sách liên kết vòng để khi duyệt 
đến cuối danh sách, nó có thể quay vòng lên phía trước danh sách/phần đầu danh sách.

4. Danh sách liên kết vòng kép (Circular Doubly Linked List) được sử dụng để cài đặt các 
cấu trúc dữ liệu nâng cao, ví dụ như Fibonacci Heap.









### Các phép toán cơ sở
    - Định giá 1 biểu thức
    - Gán, so sánh giá trị 
    - Đưa vào/truy cập 1 phần từ mảng
    - Gọi hàm
    - Trả lại giá trị cho hàm (return)


#####-----Giải Thuật-----#####

### Brute-force (vét cạn - vũ phu)
    - Selection Sort (sắp xếp chọn) : ý tưởng là chọn ra phần tử nhỏ nhất trong phần chưa xếp và đảo lên phần sắp xếp. chạy i từ 0 - (n-2) chọn ra min từ (i+1) - (n-1) và đổi chỗ min với i

    ALGORITHM SelectionSort(A[0..n − 1])
        //Sorts a given array by selection sort
        //Input: An array A[0..n − 1] of orderable elements
        //Output: Array A[0..n − 1] sorted in nondecreasing order
        for i ← 0 to n − 2 do
        min ← i
        for j ← i + 1 to n − 1 do
            if A[j ] < A[min] min ← j
        swap A[i] and A[min]

    - Bubble Sort (sắp xếp nổi bọt) : ý tưởng là hoán đổi 2 phần tử liền kề nếu không đúng trật tự và lặp đi lặp lại

    ALGORITHM BubbleSort(A[0..n − 1])
        //Sorts a given array by bubble sort
        //Input: An array A[0..n − 1] of orderable elements
        //Output: Array A[0..n − 1] sorted in nondecreasing order
        for i ← 0 to n − 2 do
            for j ← 0 to n − 2 − i do
                if A[j + 1] < A[j ] swap A[j ] and A[j + 1]

    - Sequential Search (tìm kiếm tuần tự) : ý tưởng là duyệt từ đầu đến cuối nến gặp giá trị phù hợp thì dừng và in vị trí, không tìm thấy thì in -1

    ALGORITHM SequentialSearch2(A[0..n], K)
        //Implements sequential search with a search key as a sentinel
        //Input: An array A of n elements and a search key K
        //Output: The index of the first element in A[0..n − 1] whose value is
        // equal to K or −1 if no such element is found
        A[n]← K
        i ← 0
        while A[i] != K do
            i ← i + 1
        if i<n return i
        else return −1

    - Brute-Force String Matching (so khớp chuỗi) : ý tưởng so sánh tường kí tự của văn bản với kí tự trong mẫu từ kí tự đầu nếu không giống thì dịch 
    chuyển sang kí tự tiếp theo trong văn bản và so sánh kí tự lại từ đầu

    ALGORITHM BruteForceStringMatch(T [0..n − 1], P[0..m − 1])
        //Implements brute-force string matching
        //Input: An array T [0..n − 1] of n characters representing a text and
        // an array P[0..m − 1] of m characters representing a pattern
        //Output: The index of the first character in the text that starts a
        // matching substring or −1 if the search is unsuccessful
        for i ← 0 to n − m do
            j ← 0
            while j < m and P[j ] = T [i + j ] do
                j ← j + 1
            if j = m return i
        return −1

    - Closest-Pair Problem (cặp gần nhất) : ý tưởng tính khoảng cách giữa Pi và Pj (i<j) và lưu lại, so sánh và lấy min

    ALGORITHM BruteForceClosestPair(P )
        //Finds distance between two closest points in the plane by brute force
        //Input: A list P of n (n ≥ 2) points p1(x1, y1), . . . , pn(xn, yn)
        //Output: The distance between the closest pair of points
        d ← ∞
        for i ← 1 to n − 1 do
            for j ← i + 1 to n do
                d ← min(d, sqrt((xi − xj)^2 + (yi − yj)^2)) //sqrt is square root
        return d

    - Convex-Hull Problem (bài toán thân lồi) : ý tưởng là tìm tập hợp các điểm cực trị để tạo đường bao (hình lồi và hình không lỗi trong toán). dùng phương trình ax + by = c 
    với a = y2 - y1, b = x1 - x2, c = x1*y2 - x2*y1 trong đó (x1,y1), (x2,y2) là tọa độ 2 điểm tạo nên đường thẳng có phương trình. các điểm nằm cùng phía thì có cùng dấu với 
    nhau tức có cùng kết quả ax + by > c hoặc ax + by < c

    - Exhaustive Search (tìm kiếm toàn diện) : (chưa hiểu)

















