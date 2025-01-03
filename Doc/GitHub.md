# GIT - GITHUB

## Trạng thái file

**_modified ---> staged ---> committed_**

**modified**: file đã thay đổi nhưng chưa lưu trữ trong Database

**staged**: được đánh dấu và chuẩn bị để file commit lưu trữ

**committed**: file đã được lưu trữ an toàn trong Database

## Vùng dữ liệu

![alt text](../Image/GitHub_001.png)

**Working directory**: nơi chứa thư mục để làm việc, chỉnh sửa

**Staging area**: nơi chuẩn bị để lưu trữ

**.git directory (Repository)**: nơi chứa toàn bộ cơ sở dữ liệu kể cả Staging area

## Các trạng thái hoạt động của file

![alt text](../Image/GitHub_002.png)

**Untracked**: không được git theo dõi

**Unmodified**: không có sửa đổi gì

**Modified**: có sự thay đổi so với dữ liệu đã lưu

**Staged**: đánh dấu để chuẩn bị lưu

## Quy trình hoạt động

### Làm chủ của repository (chủ, leader)

B1: khởi tạo

- khởi tạo repository trên github trước xong clone về
- Hoặc tạo trên máy bằng git init rồi thêm remote từ github (hay dùng)

B2: Checkout new branch

- Đứng từ branch chính (master/main) rồi checkout sang nhánh làm việc mới
- Tạo nhánh mới để thực hiện công việc tránh đụng vào nhánh chính

B3: Change & commit code

- Thay đổi code theo tính năng mới
- Add tất cả code mới (git add . )
- Tạo một commit code (git commit -m )

B4: Push code lên github

- Đối với repo mà bạn là chủ: đơn giản cứ push thẳng commit vừa tạo theo remote chính
- Tạo pull request (để yêu cầu gộp code vào branch chính)

B5: Review & Update commit

- Trường hợp sau khi đã tạo pull request mà cần sửa code tiếp
- git commit --amend để đảm bảo giữ cho một pull request chỉ nên có tối đa 1 commit (cho sạch, cho clean)
- Từ lần púh code thứ 2 trên cừng 1 pull thì thêm thuộc tính -f vào (git pull <url> <branch> -f)

B6: Merge pull request

- Merge pull request vào branch chính (người có quyền mới merge code được)
- Quay về máy local checkout + pull code (cập nhật code ở branch chính)
- Xóa branch cả ở trên Github + local (lành sạch code để làm task mới)
- Quay lại B2 để tiếp tục làm tính năng mới

### Lấy từ repository của người khác (nhân viên, thành viên)

B1: khởi tạo

- Folk project về github cá nhân (làm trên github)
- Clone project vừa folk về máy local
- Add thêm remote chính từ repo của project chính (1 remote tới github cá nhân, 1 remote đến github gốc)

B2: Checkout new branch

- Đứng từ branch chính (master/main) rồi checkout sang nhánh làm việc mới
- Ttạo nhánh mới để thực hiện công việc tránh đụng vào nhánh chính

B3: Change & commit code

- Thay đổi code theo tính năng mới
- Add tất cả code mới (git add . )
- Tạo một commit code (git commit -m )

B4: Push code lên github

- Đối với repo ngoài mà bạn folk về: push commit lên theo remote cá nhân
- Mở repo gốc rồi tạo pull request

B5: Review & Update commit

- Trường hợp sau khi đã tạo pull request mà cần sửa code tiếp
- git commit --amend để đảm bảo giữ cho một pull request chỉ nên có tối đa 1 commit (cho sạch, cho clean)
- Từ lần púh code thứ 2 trên cừng 1 pull thì thêm thuộc tính -f vào (git pull <url> <branch> -f)

B6: Merge pull request

- Merge pull request vào branch chính (người có quyền mới merge code được)
- Quay về máy local checkout + pull code (cập nhật code ở branch chính)
- Xóa branch cả ở trên Github + local (lành sạch code để làm task mới)
- Quay lại B2 để tiếp tục làm tính năng mới

## Git version

Kiểm tra phiên bản của Git

```
$ git --v
```

## Git config

Định cấu hình các biến cấu hình chung – Nếu bạn đang làm việc với các developer khác, bạn sẽ cần biết ai đang kiểm tra mã xuất nhập và thực hiện thay đổi.

```
$ git config --g user.name "name"
$ git config --g user.email "email"
$ git config --list
```

## Git help

Nếu bạn cần hỗ trợ, hãy sử dụng các lệnh:

- Hướng dẫn bạn có thể làm được những gì, tất cả các lệnh có thể.

```
$ git help -a
```

or

```
$ git help --all
```

- Đưa bạn tới trang hướng dẫn chính thống của Git.

```
$ git config --help
```

or

```
$ git help config
```

- Xem tất cả các tùy chọn có sẵn cho lệnh cụ thể

```
$ git command -help
```

## Git mkdir

Tạo repository trong hệ thống local.

```
$ git mkdir folder_name
```

Di chuyển đến folder_name repository vừa tạo ra.

```
$ cd folder_name
```

## Git remote

Liên kết đến remote repository (local & GitHub)

```
$ git remote add origin https... <url>
```

Thay đổi địa chỉ của remote repository đã Liên kết vào địa chỉ của <new url>

```
$ git remote set-url <name> <new url>
```

Thay đổi tên của remote repository đã Liên kết

```
$ git remote rename <old> <new>
```

Hiện thị thông tin chi tiết hơn, có thêm đường dẫn đến remote Repo

```
$ git remote -v
```

Xóa một địa chỉ remote

```
$ git remote rm remote-name
```

Đổi tên địa chỉ remote

```
$ git remote rename ten-cu ten-moi
```

Xem thông tin về Remote

```
$ git remote show origin
```

## Git init

Lệnh này được dùng khi bạn muốn tạo một phiên bản git mới cho một dự án.

```
$ git init (Khởi tạo git trong thư mục dự án của bạn)
```

## Git status

Kiểm tra trạng thái của kho lưu trữ

```
$ git status
```

```
$ git status --short
```

Các trạng thái (xem các trạng thái hoạt động của file):

- ?? : Tập tin không bị theo dõi
- A : Tệp được thêm vào giai đoạn
- M : Tệp đã sửa đổi
- D : Các tệp đã xóa

## Git add

Add những thay đổi (bạn đã tạo mới hoặc chỉnh sửa) để thực hiện commit

```
$ git add .   (add tất cả)
```

```
$ git add --all  (git add -A)
```

```
$ git add index.html (có thể chỉ định trực tiếp tên tệp cần add)
```

## Git commit

Ghi lại các thay đổi vào kho lưu trữ. (Cần thêm các thông điệp rõ ràng vào mỗi mục commit)

```
$ git commit -m "Thông điệp của bạn"
```

Cập nhật commit mới vào commit cuối cùng gần nhất

```
$ git commit --amend -m "Thông điệp của bạn"
```

_❗Cách đặt tên branch hay commit nên rõ ràng, thể hiện branch đó, commit đó thực hiện feature gì hay là fix bug gì... (thường thì sẽ theo quy định của công ty)_

## Git diff

So sánh sự khác biệt kể từ lần commit cuối cùng của bạn (sự khác nhau giữa vùng làm việc và staged)

```
$ git diff
```

Kiểm tra sự khác nhau giữa vùng staged và git

```
$ git diff --staged
```

Hiển thị thông số so sánh giữa 2 commit

```
$ git diff <commit 1_id> <commit 2_id> --stat
```

## Git log

Xem lịch sử làm việc với git (lịch sử commit)

```
$ git log
```

```
$ git log --oneline (Hiển thị ngắn gọn hơn)
```

```
$ git log --oneline --graph (Hiển thị sơ đồ các nhánh)
```

## Git push

Push (đẩy) branch vào remote repository.

```
$ git push -u origin branch_mane
```

Push (đẩy) tất cả mọi thay đổi (đã commit) lên remote repository.

```
$ git push
```

Xóa một branch trên remote repository.

```
$ git push -d origin branch_mane
```

Push force sẽ apply toàn bộ log ở local của bạn lên branch ở repo, bất chấp log 2 nơi khác nhau.

```
$ git push -f origin branch_mane
```

_❗Xóa vĩnh viễn branch cũ Push branch mới. Dễ gây conflict cho người khác cẩn trọng trước khi dùng_

## Git branch

Đổi tên nhánh chính.

```
$ git branch -M branch_mane (main)
```

Kiểm tra các nhánh hiện có của bạn ở local.

```
$ git branch
```

Tạo một nhánh có tên “branch_mane” và hợp nhất (merge) nó với nhánh chính.

```
$ git branch -c branch_mane
```

hoặc

```
$ git checkout -b branch_mane (Tạo và chuyển luôn sang nhánh mới)
```

Khôi phục lại nhánh đã xóa

```
$ git checkout -b branch_mane <commit_id>
```

Xóa một nhánh tại local có tên: "branch_mane" (branch đã được hợp nhất (push) vào remote repository)

```
$ git branch -d branch_mane
```

Xóa một nhánh tại local có tên: "branch_mane" (branch đã commit nhưng chưa hợp nhất vào remote repository)

```
$ git branch -D branch_mane
```

Kiểm tra các branch hiện có trên remote repo của bạn.

```
$ git branch -a
```

## Git checkout

Khôi phục file quay lại bước commmit được chỉ định

```
$ git checkout <commit_id> --<file> (mã commit lấy từ git log)
```

_❗riêng commit cuối cùng không cần mã vẫn ok_

Di chuyển commit về commit chỉ định

```
$ git checkout <commit_id>
```

Tạo và chuyển luôn sang nhánh mới

```
$ git checkout -b branch_mane
```

Lệnh trên giúp di chuyển không gian làm việc, kiểm tra tệp giữa các branch_mane.

```
$ git checkout branch_mane
```

## Git restore (!!! cần chỉnh sửa lại)

Khôi phục, hủy bỏ hoặc quay lại

```
$ git restore <file>
```

hoặc

```
$ git restore --staged
```

## Git fetch (Lấy code về nhưng chưa muốn merge)

Git fetch cho phép CẬP NHẬT để xem điều gì đã thay đổi trên GitHub của bạn.

Lệnh fetch (xác nhận nội dung thay đổi trong branch của remote repository) nhưng nội dung branch của local repository không bị thay đổi.

```
$ git fetch origin
```

## Git merge (merge kết hợp nhánh hiện tại, với một nhánh được chỉ định.)

Di chuyển về branch cần hợp nhất bằng lệnh checkout.

```
$ git checkout branch_mane1 (Nhánh nhận hợp nhất or nhánh hiện tại)
```

Tiến hành hợp nhất:

```
$ git merge branch_mane2 (Nhánh chỉ định hợp nhất)
```

Nhánh hiện tại là nhánh bạn đang đứng, nhánh chỉ định là nhánh sau lệnh `$ git merge`

Lệnh trên giúp hợp nhất các branch (Hợp nhất branch_mane2 vào branch_mane1). (Chú ý xử lý xung đột code)

## Git rebase (Hợp nhất code)

Di chuyển về nhánh nhận sự hợp nhất.

```
$ git checkout branch_mane1
```

Tiến hành hợp nhất.

```
$ git rebase branch_mane2 (Code từ branch_mane2 được hợp nhất vào branch_mane1)
```

_❗Tương đồng với merge nhưng có sự khác biệt như sau:_

_**Merge**: Chỉ lấy nội dung commit cuối cùng của hai nhánh, tích hợp tạo thành commit mới. Các commit trước đó được giữ nguyên không thay đổi._

_**Rebase**: Lấy code từ branch_mane2, từ những commit ở branch_mane2 tích hợp đồng thời tái tạo lại commit mới ở branch_mane1 (Các commit đã tồn tại bị bỏ đi)._

## Git pull (Hợp nhất từ xa)

Git pull kéo tất cả các thay đổi từ main về local.

```
$ git pull origin main
```

Git pull kéo tất cả các thay đổi từ branch_mane về local.

```
$ git pull
```

Git pull kéo tất cả các thay đổi từ kho lưu trữ từ xa vào branch bạn đang làm việc. (pull là sự kết hợp của 2 lệnh khác nhau: fetch và merge)

```
$ git pull origin
```

Cách pull chống xung đột

```
$ git pull --rebase
```

## Git clone

Clone dự án có sẵn trên GitHub.

```
$ git clone <url> folder_name
```

Clone đồng thời đổi tên dự án theo ý bạn khi save vào local.

```
$ git clone <url>  (Địa chỉ dự án bạn muốn Clone)
```

## Git stash

Lưu lại công việc đang làm ở branch này để chuyển sang branch khác (Khi bạn chưa muốn commit code)

```
$ git stash save #
```

hoặc

```
$ git stash
```

Xem lại lịch sử thay đổi.

```
$ git stash list
```

Xem lại lịch sử thay đổi cụ thể của lần stash save{n}.

```
$ git stash show stash@{n}
```

Apply thay đổi của lần stash save{n}.

```
$ git stash apply stash@{1}
```

Xoá toàn bộ stash.

```
$ git stash clear
```

## Git revert:

Lệnh này tạo commit đảo ngược commit có commit_id được chọn.

```
$ git revert <commit_id>
```

Lệnh này xoá toàn bộ các commit trước đó, đưa branch về trạng thái của commit_id được chọn.

```
$ git reset –hard <commit_id>
```

Đưa branch về trạng thái của commit_id được chọn. Giữ nguyên tất cả thay đổi của file và các thay đổi ở stage. (Được khuyến khích sử dụng)

```
$ git reset –soft <commit_id>
```

_❗Note:_

_Nhấn phím mũi tên chỉ xuống để đọc tiếp nội dung bị che khuất phía dưới._

_Nhấn phím chữ 'q' để thoát khỏi chế độ xem, đưa bạn về dấu nhắc lệnh branch hiện tại._

## Git cherry pick

> cập nhật sau

## Deploy web bằng github

> cập nhật sau

## Thay đổi tài khoản trong Git ở local

Vào Credential Manager

Remove kết nối cũ

Đăng nhập lại vào Git

Kiểm tra và thay đổi lại user.name, user.email

## Đổi Git commit author

Chưa commit code

- Set config git user cho project:

```
$ git config user.name "Dev"
$ git config user.email "dev@haposoft.com"
```

- Set global, mặc định cho tất cả các project nếu không set trong project thì author sẽ ăn theo config này:

```
$ git config --global user.name "Dev"
$ git config --global user.email "dev@haposoft.com"
```

Đã có 1 commit, cần change author cho commit này

```
$ git commit --amend --author="Dev <dev@haposoft.com>" --no-edit
```

Đã có 1 dãy các commit, cần change tất cả:

- A-B-C-D-E-F, F là HEAD

- Chọn ra điểm rebase:

```
$ git rebase -i B
$ git rebase -i --root (chọn A)
```

- Bắt đầu rebase từ C:

```
$ git commit --amend --author="Dev <dev@haposoft.com>" --no-edit
```

- Tiếp tục rebase sang D

```
$ git rebase --continue
```

```
$ git commit --amend --author="Dev <dev@haposoft.com>" --no-edit
```

```
$ git rebase --continue
```

- Nếu đã push lên remote server thì dùng:

```
$ git push -f
```

## Githup profile (tạo profile trên github cho đẹp cho nghệ)

> cập nhật sau

- Tạo 1 repsitory trùng với tên user
- Dùng file README.md để trang trí

## Git ignore
