# 🍔 Bài Tập 4.4 – Form Đặt Hàng Fast Food

Bài tập xây dựng ứng dụng đặt món ăn sử dụng **ListBox** và **GroupBox**, với tính năng tính tổng tiền tự động.

---

## 📋 Mô tả

Giao diện đặt hàng cho phép người dùng chọn món từ thực đơn, chuyển sang danh sách đã chọn, và xem tổng tiền cập nhật ngay lập tức sau mỗi thao tác.

**Thực đơn có sẵn:**

| Món | Giá |
|-----|-----|
| Hamburger | 50.000 đ |
| Pizza | 120.000 đ |
| Gà Rán | 35.000 đ |
| Pepsi | 15.000 đ |

---

## 🖼️ Giao diện

### Giao diện chính
![Giao diện đặt hàng](Screenshot%202026-09-23%20164733.png)

### Cảnh báo khi chọn trùng món
![Cảnh báo món trùng](Screenshot%202026-09-23%20164809.png)

### Hóa đơn xác nhận đặt hàng
![Hóa đơn](Screenshot%202026-09-23%20164827.png)

---

## ⚙️ Các thành phần chính

| Tên Control | Chức năng |
|-------------|-----------|
| `lstMenu` | Danh sách thực đơn có sẵn |
| `lstSelected` | Danh sách món đã chọn |
| `btnAdd` (`>`) | Chuyển món từ thực đơn → danh sách đã chọn |
| `btnRemove` (`<`) | Xóa món khỏi danh sách đã chọn |
| `lblTotal` | Hiển thị tổng tiền, cập nhật tự động |
| `btnOrder` | In hóa đơn chi tiết lên MessageBox |

---

## 🚀 Cách chạy

**Bằng Visual Studio:**
1. Mở file `BT4_4_FastFoodOrder.sln`
2. Nhấn `F5` để chạy

**Bằng terminal:**
```bash
dotnet run
```

---

## 🛠️ Yêu cầu
- .NET 10.0 SDK
- Windows OS
- Visual Studio 2022 trở lên
