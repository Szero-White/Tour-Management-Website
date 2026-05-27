# 🧳 DuLich — Ứng dụng Quản Lý & Đặt Tour (C# WinForms)

> 📌 Repo: `Szero-White/Tour-Management-Website`  
> 📂 Source chính: `Nhom5_Midterm/DuLich`  
> 🖥️ Loại ứng dụng: **Windows Desktop App (WinForms)** — *không phải website chạy trên browser*

---

## ✨ Giới thiệu
**DuLich** là ứng dụng quản lý tour du lịch viết bằng **C# (.NET 8 Windows Forms)**. Ứng dụng có màn hình **đăng nhập**, sau đó vào **trang chủ** và hiển thị các module theo dạng **UserControl** (thay đổi nội dung trong panel chính).

Ứng dụng sử dụng **SQL Server** (kết nối qua `System.Data.SqlClient`) để lưu trữ dữ liệu, đồng thời hỗ trợ thao tác dữ liệu tour (thêm/sửa/xóa/tìm kiếm) và **nhập dữ liệu tour từ Excel** (EPPlus).

---

## 🖼️ Giao diện ứng dụng

### Màn hình đăng nhập
<p align="center">
  <img src="images/login.png" alt="Màn hình đăng nhập" width="700">
</p>

### Trang chủ
<p align="center">
  <img src="images/home.png" alt="Trang chủ ứng dụng" width="700">
</p>

### Quản lý danh sách tour
<p align="center">
  <img src="images/tour-management.png" alt="Quản lý danh sách tour" width="700">
</p>

---

## 🧰 Công nghệ sử dụng
### 💻 Nền tảng
- **Ngôn ngữ:** C#
- **Framework:** `.NET 8.0 (Windows)`  
- **UI:** Windows Forms (WinForms)

### 🗄️ Cơ sở dữ liệu
- **SQL Server** (kết nối bằng `System.Data.SqlClient`)
- Connection string trong code dạng:
  - `Data Source=...\\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True`

### 📦 Thư viện/NuGet nổi bật (trích từ `DuLich.csproj`)
- 📊 Vẽ biểu đồ/thống kê: `ScottPlot`, `ScottPlot.WinForms`, `OxyPlot.WindowsForms`, `HIC.System.Windows.Forms.DataVisualization`
- 📑 Excel: `EPPlus`, `ClosedXML`, `Microsoft.Office.Interop.Excel`
- 🧾 Dữ liệu: `System.Data.SqlClient`
- 🧱 Khác: `Microsoft.Windows.Compatibility`
- (Có reference `Microsoft.Data.Sqlite` nhưng luồng chính đang dùng SQL Server trong code đã đọc)

---

## 🚀 Cách chạy dự án
### ✅ Yêu cầu môi trường
- Windows
- Visual Studio 2022 (khuyến nghị) hoặc Rider
- **.NET SDK** hỗ trợ `net8.0-windows`
- SQL Server / SQL Server Express (đang dùng `SQLEXPRESS` trong cấu hình mẫu)

### ▶️ Mở và chạy
1. Mở file solution:
   - `Nhom5_Midterm/DuLich.sln`
2. Chọn project `DuLich`
3. Bấm **Start** để chạy

> Điểm vào chương trình nằm ở `Program.cs` và form khởi chạy là **`dangnhap`**.

---

## 🔐 Đăng nhập & phân quyền
### Màn hình đăng nhập
- Form: `dangnhap`
- Khi bấm **Đăng nhập**, hệ thống kiểm tra tài khoản trong bảng:
  - `TaiKhoanDuLich (TaiKhoan, MatKhau)`
- Nếu đúng: mở form **`trangchu`**
- Nếu sai: thông báo lỗi và reset ô nhập

### Phân quyền hiển thị theo tài khoản
Trong `trangchu` có biến:
- `public static string loggedInUser`

Luồng:
- Sau khi login thành công, `loggedInUser` được gán theo `TaiKhoan` (đưa về chữ thường).
- Khi `trangchu` load:
  - Nếu `loggedInUser != "admin"` thì **ẩn**:
    - Quản lý nhân viên (`plnv`)
    - Quản lý danh sách tour (`qldst`)
  - Nếu là `admin` thì thấy đầy đủ chức năng quản trị.

---

## 🧩 Các phân hệ/chức năng chính (theo menu Trang Chủ)
Form `trangchu` điều hướng bằng cách nhúng **UserControl** vào panel `main`:

- 🏠 **Trang chính**: `trangchinh`
- 👥 **Quản lý khách hàng**: `quanlykhachhang`
- 🗓️ **Quản lý lịch trình**: `quanlylichtrinh`
- 📊 **Báo cáo / Thống kê**: `thongke`
- 👨‍💼 **Quản lý nhân viên** *(admin)*: `quanlynhanvien`
- 🗂️ **Quản lý danh sách tour** *(admin)*: `quanlydanhsachtour`
- 🎫 **Đặt tour du lịch**: `dattourdulich`
- 🚪 **Đăng xuất**: quay lại form `dangnhap`

---

## 🗂️ Quản lý danh sách tour (Admin) — Chi tiết
UserControl: `quanlydanhsachtour`

### 📌 Dữ liệu hiển thị
- Load dữ liệu từ bảng **`Tour`** với các cột:
  - `MaTour`, `TenTour`, `GiaTour`, `PhuongTien`, `LoaiTour`, `NgayDi`, `NgayKetThuc`, `HinhAnh1`, `HinhAnh2`
- Dữ liệu hiển thị qua `DataGridView` (bảng danh sách tour)

### ➕ Thêm tour
- Kiểm tra nhập đủ thông tin (tên tour, loại tour, giá, phương tiện, ngày đi, ngày kết thúc)
- Thêm bản ghi vào bảng `Tour`
- Có chọn ảnh 1/ảnh 2 bằng `OpenFileDialog` và lưu đường dẫn vào `HinhAnh1/HinhAnh2`

### 📝 Sửa/Lưu chỉnh sửa
- Cho phép sửa trực tiếp trên dòng đang chọn trong `DataGridView`
- Nhấn **Lưu** sẽ `UPDATE Tour ... WHERE MaTour = ...`

### 🗑️ Xóa tour
- Xóa theo `MaTour` của dòng đang chọn
- Có hộp thoại xác nhận trước khi xóa

### 🔎 Tìm kiếm/Lọc tour
Cho phép lọc theo:
- `TenTour` (LIKE)
- `LoaiTour`
- `PhuongTien`
- `GiaTour` (số)

### 📥 Nhập dữ liệu từ Excel
- Chọn file `.xlsx`
- Đọc sheet đầu tiên
- Từ dòng 2 → hết:
  - Lấy các cột: Tên tour, Ngày đi, Ngày kết thúc, Loại tour, Giá, Phương tiện, Hình 1, Hình 2
- Insert vào bảng `Tour`
- Thư viện sử dụng: **EPPlus**
- Có cấu hình LicenseContext NonCommercial ở `Program.cs`

---

## 🗃️ Cấu trúc thư mục (phần liên quan)
```text
Nhom5_Midterm/
├─ DuLich.sln
└─ DuLich/
   ├─ DuLich.csproj
   ├─ Program.cs                 # Entry point -> chạy form dangnhap
   ├─ dangnhap.cs                # Form đăng nhập
   ├─ trangchu.cs                # Form trang chủ + điều hướng UserControls
   ├─ ThanhToan.cs               # Form thanh toán (có file .Designer/.resx)
   ├─ QR.cs                      # Form QR (có file .Designer/.resx)
   └─ UserControls/
      ├─ quanlydanhsachtour.cs   # CRUD + import Excel
      ├─ quanlykhachhang.cs
      ├─ quanlylichtrinh.cs
      ├─ quanlynhanvien.cs
      ├─ thongke.cs
      ├─ dattourdulich.cs
      └─ trangchinh.cs
```

---

## ⚠️ Lưu ý cấu hình (quan trọng để chạy được)
- Hiện tại **connection string đang hard-code trong code** (ví dụ trong `dangnhap.cs`, `trangchu.cs`, `quanlydanhsachtour.cs`) theo máy:
  - `Data Source=NguyenCongToan\\SQLEXPRESS;Initial Catalog=DuLich;...`
- Khi chạy trên máy khác, bạn cần sửa `Data Source` cho đúng SQL Server instance của bạn.

---

