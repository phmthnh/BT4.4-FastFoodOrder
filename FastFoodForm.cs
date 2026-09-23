using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BT4_4_FastFoodOrder
{
    public partial class FastFoodForm : Form
    {
        // Dictionary lưu giá món ăn (đơn vị: nghìn đồng)
        private readonly Dictionary<string, int> menuPrices = new()
        {
            { "Hamburger",  50 },
            { "Pizza",     120 },
            { "Gà Rán",    35  },
            { "Pepsi",     15  }
        };

        public FastFoodForm()
        {
            InitializeComponent();
            LoadMenu();
        }

        // Nạp danh sách món vào lstMenu
        private void LoadMenu()
        {
            foreach (var item in menuPrices)
                lstMenu.Items.Add(item.Key);
        }

        // Nút > : Chuyển món sang lstSelected
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = lstMenu.SelectedItem.ToString()!;

            // Tránh thêm trùng
            if (!lstSelected.Items.Contains(selectedItem))
            {
                lstSelected.Items.Add(selectedItem);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show($"Món '{selectedItem}' đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút < : Xóa món khỏi lstSelected
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstSelected.Items.Remove(lstSelected.SelectedItem);
            UpdateTotal();
        }

        // Tự động cập nhật tổng tiền
        private void UpdateTotal()
        {
            int total = 0;
            foreach (string item in lstSelected.Items)
            {
                if (menuPrices.ContainsKey(item))
                    total += menuPrices[item];
            }
            lblTotal.Text = $"Tổng tiền: {total}.000 VNĐ";
        }

        // Nút Đặt Hàng
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lstSelected.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn món nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var items = new List<string>();
            int total = 0;
            foreach (string item in lstSelected.Items)
            {
                items.Add($"  • {item}: {menuPrices[item]}.000 VNĐ");
                total += menuPrices[item];
            }

            string receipt = "===== HÓA ĐƠN =====\n" +
                             string.Join("\n", items) + "\n" +
                             "--------------------\n" +
                             $"Tổng cộng: {total}.000 VNĐ";

            MessageBox.Show(receipt, "Xác Nhận Đặt Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
