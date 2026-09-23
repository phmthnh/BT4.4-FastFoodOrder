namespace BT4_4_FastFoodOrder
{
    partial class FastFoodForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle    = new System.Windows.Forms.Label();
            grpMenu     = new System.Windows.Forms.GroupBox();
            lstMenu     = new System.Windows.Forms.ListBox();
            grpSelected = new System.Windows.Forms.GroupBox();
            lstSelected = new System.Windows.Forms.ListBox();
            btnAdd      = new System.Windows.Forms.Button();
            btnRemove   = new System.Windows.Forms.Button();
            lblTotal    = new System.Windows.Forms.Label();
            btnOrder    = new System.Windows.Forms.Button();

            grpMenu.SuspendLayout();
            grpSelected.SuspendLayout();
            SuspendLayout();

            // Form
            Text          = "Đặt Hàng Fast Food";
            Size          = new System.Drawing.Size(620, 420);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox   = false;

            // lblTitle
            lblTitle.Text      = "🍔  FAST FOOD ORDER  🍕";
            lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTitle.Location  = new System.Drawing.Point(100, 12);
            lblTitle.Size      = new System.Drawing.Size(400, 32);

            // grpMenu - danh sách menu
            grpMenu.Text     = "Thực Đơn";
            grpMenu.Location = new System.Drawing.Point(20, 55);
            grpMenu.Size     = new System.Drawing.Size(200, 280);

            lstMenu.Location = new System.Drawing.Point(10, 25);
            lstMenu.Size     = new System.Drawing.Size(180, 240);
            lstMenu.Font     = new System.Drawing.Font("Segoe UI", 11F);
            grpMenu.Controls.Add(lstMenu);

            // Nút > và <
            btnAdd.Text      = ">";
            btnAdd.Location  = new System.Drawing.Point(230, 130);
            btnAdd.Size      = new System.Drawing.Size(50, 40);
            btnAdd.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Click    += btnAdd_Click;

            btnRemove.Text      = "<";
            btnRemove.Location  = new System.Drawing.Point(230, 185);
            btnRemove.Size      = new System.Drawing.Size(50, 40);
            btnRemove.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnRemove.BackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            btnRemove.ForeColor = System.Drawing.Color.White;
            btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemove.Click    += btnRemove_Click;

            // grpSelected - danh sách đã chọn
            grpSelected.Text     = "Món Đã Chọn";
            grpSelected.Location = new System.Drawing.Point(295, 55);
            grpSelected.Size     = new System.Drawing.Size(300, 280);

            lstSelected.Location = new System.Drawing.Point(10, 25);
            lstSelected.Size     = new System.Drawing.Size(280, 240);
            lstSelected.Font     = new System.Drawing.Font("Segoe UI", 11F);
            grpSelected.Controls.Add(lstSelected);

            // lblTotal
            lblTotal.Text      = "Tổng tiền: 0 VNĐ";
            lblTotal.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            lblTotal.Location  = new System.Drawing.Point(20, 350);
            lblTotal.Size      = new System.Drawing.Size(300, 28);

            // btnOrder
            btnOrder.Text      = "🛒  Đặt Hàng";
            btnOrder.Location  = new System.Drawing.Point(430, 345);
            btnOrder.Size      = new System.Drawing.Size(160, 35);
            btnOrder.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnOrder.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            btnOrder.ForeColor = System.Drawing.Color.White;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.Click    += btnOrder_Click;

            grpMenu.ResumeLayout(false);
            grpSelected.ResumeLayout(false);

            Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, grpMenu, btnAdd, btnRemove,
                grpSelected, lblTotal, btnOrder
            });

            ResumeLayout(false);
        }

        private System.Windows.Forms.Label    lblTitle, lblTotal;
        private System.Windows.Forms.GroupBox grpMenu, grpSelected;
        private System.Windows.Forms.ListBox  lstMenu, lstSelected;
        private System.Windows.Forms.Button   btnAdd, btnRemove, btnOrder;
    }
}
