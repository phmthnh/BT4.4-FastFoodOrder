# BT4.4 – Form Đặt Hàng Fast Food với ListBox và GroupBox

> **Môn:** Lập trình Windows Forms với C# | **Framework:** .NET 10.0

## Mục tiêu
Quản lý danh sách món ăn với **ListBox**, tính toán **tổng tiền động** và chuyển món giữa hai danh sách.

## Tính năng

| Control | Chức năng |
|---------|-----------|
| `lstMenu` | Danh sách thực đơn: Hamburger 50k · Pizza 120k · Gà Rán 35k · Pepsi 15k |
| `btnAdd` (`>`) | Chuyển món đang chọn → `lstSelected` |
| `btnRemove` (`<`) | Xóa món khỏi `lstSelected` |
| `lblTotal` | Tự động cập nhật tổng tiền sau mỗi thao tác |
| `btnOrder` | In hóa đơn chi tiết lên `MessageBox` |

## Demo

### Giao diện ban đầu
![Fast Food - Giao diện](Screenshot%202026-09-23%20164733.png)

### Thêm món & cảnh báo trùng
![Fast Food - Cảnh báo trùng món](Screenshot%202026-09-23%20164809.png)

### Hóa đơn xác nhận
![Fast Food - Hóa đơn](Screenshot%202026-09-23%20164827.png)

## Cách chạy

```bash
dotnet run
```

hoặc mở file `BT4_4_FastFoodOrder.sln` bằng **Visual Studio 2022+** và nhấn `F5`.

## Yêu cầu hệ thống
- .NET 10.0 SDK
- Windows OS (Windows Forms)
- Visual Studio 2022 (khuyến nghị)
