namespace XinlangBlog
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importuser = new System.Windows.Forms.ToolStripMenuItem();
            this.adduser = new System.Windows.Forms.ToolStripMenuItem();
            this.saveuser = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importip = new System.Windows.Forms.ToolStripMenuItem();
            this.addip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveip = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.其它ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.序号1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.选择2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.序号2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP地址 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.端口 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地区 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.right_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.right_importuser = new System.Windows.Forms.ToolStripMenuItem();
            this.right_adduser = new System.Windows.Forms.ToolStripMenuItem();
            this.right_saveuser = new System.Windows.Forms.ToolStripMenuItem();
            this.right_selall = new System.Windows.Forms.ToolStripMenuItem();
            this.right_invertsel = new System.Windows.Forms.ToolStripMenuItem();
            this.right_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.right_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.right_clean = new System.Windows.Forms.ToolStripMenuItem();
            this.right_set = new System.Windows.Forms.ToolStripMenuItem();
            this.right_font = new System.Windows.Forms.ToolStripMenuItem();
            this.right_color = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.left_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.left_importip = new System.Windows.Forms.ToolStripMenuItem();
            this.left_addip = new System.Windows.Forms.ToolStripMenuItem();
            this.left_saveip = new System.Windows.Forms.ToolStripMenuItem();
            this.left_selall = new System.Windows.Forms.ToolStripMenuItem();
            this.left_invertsel = new System.Windows.Forms.ToolStripMenuItem();
            this.left_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.left_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.left_clean = new System.Windows.Forms.ToolStripMenuItem();
            this.left_set = new System.Windows.Forms.ToolStripMenuItem();
            this.left_font = new System.Windows.Forms.ToolStripMenuItem();
            this.left_color = new System.Windows.Forms.ToolStripMenuItem();
            this.importuserDialog = new System.Windows.Forms.OpenFileDialog();
            this.importipDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveuserDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveipDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem1,
            this.菜单ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.refresh,
            this.其它ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem1
            // 
            this.菜单ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem1.Name = "菜单ToolStripMenuItem1";
            this.菜单ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem1.Text = "菜单";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importuser,
            this.adduser,
            this.saveuser});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.菜单ToolStripMenuItem.Text = "账号管理";
            // 
            // importuser
            // 
            this.importuser.Image = ((System.Drawing.Image)(resources.GetObject("importuser.Image")));
            this.importuser.Name = "importuser";
            this.importuser.Size = new System.Drawing.Size(124, 22);
            this.importuser.Text = "导入用户";
            this.importuser.Click += new System.EventHandler(this.importuser_Click);
            // 
            // adduser
            // 
            this.adduser.Image = ((System.Drawing.Image)(resources.GetObject("adduser.Image")));
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(124, 22);
            this.adduser.Text = "添加用户";
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // saveuser
            // 
            this.saveuser.Image = ((System.Drawing.Image)(resources.GetObject("saveuser.Image")));
            this.saveuser.Name = "saveuser";
            this.saveuser.Size = new System.Drawing.Size(124, 22);
            this.saveuser.Text = "保存用户";
            this.saveuser.Click += new System.EventHandler(this.saveuser_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importip,
            this.addip,
            this.saveip});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.编辑ToolStripMenuItem.Text = "IP管理";
            // 
            // importip
            // 
            this.importip.Image = ((System.Drawing.Image)(resources.GetObject("importip.Image")));
            this.importip.Name = "importip";
            this.importip.Size = new System.Drawing.Size(111, 22);
            this.importip.Text = "导入IP";
            this.importip.Click += new System.EventHandler(this.importip_Click);
            // 
            // addip
            // 
            this.addip.Image = ((System.Drawing.Image)(resources.GetObject("addip.Image")));
            this.addip.Name = "addip";
            this.addip.Size = new System.Drawing.Size(111, 22);
            this.addip.Text = "添加IP";
            this.addip.Click += new System.EventHandler(this.addip_Click);
            // 
            // saveip
            // 
            this.saveip.Image = ((System.Drawing.Image)(resources.GetObject("saveip.Image")));
            this.saveip.Name = "saveip";
            this.saveip.Size = new System.Drawing.Size(111, 22);
            this.saveip.Text = "保存IP";
            this.saveip.Click += new System.EventHandler(this.saveip_Click);
            // 
            // refresh
            // 
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(44, 21);
            this.refresh.Text = "刷新";
            // 
            // 其它ToolStripMenuItem
            // 
            this.其它ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.其它ToolStripMenuItem.Name = "其它ToolStripMenuItem";
            this.其它ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其它ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于ToolStripMenuItem.Image")));
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb1.ForeColor = System.Drawing.Color.Red;
            this.lb1.Location = new System.Drawing.Point(-4, 39);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(65, 20);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "账号列表";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb2.ForeColor = System.Drawing.Color.Red;
            this.lb2.Location = new System.Drawing.Point(388, 39);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(50, 20);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "IP列表";
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.ForeColor = System.Drawing.Color.Green;
            this.btn1.Location = new System.Drawing.Point(76, 492);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 41);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "一键发布";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择,
            this.序号1,
            this.用户名,
            this.密码});
            this.dataGridView1.Location = new System.Drawing.Point(0, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(394, 382);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // 选择
            // 
            this.选择.FillWeight = 50F;
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.选择.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.选择.Width = 60;
            // 
            // 序号1
            // 
            this.序号1.HeaderText = "序号";
            this.序号1.Name = "序号1";
            this.序号1.Width = 60;
            // 
            // 用户名
            // 
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            // 
            // 密码
            // 
            this.密码.HeaderText = "密码";
            this.密码.Name = "密码";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择2,
            this.序号2,
            this.IP地址,
            this.端口,
            this.地区,
            this.状态});
            this.dataGridView2.Location = new System.Drawing.Point(392, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(587, 382);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseUp);
            // 
            // 选择2
            // 
            this.选择2.HeaderText = "选择";
            this.选择2.Name = "选择2";
            this.选择2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.选择2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.选择2.Width = 60;
            // 
            // 序号2
            // 
            this.序号2.HeaderText = "序号";
            this.序号2.Name = "序号2";
            this.序号2.Width = 60;
            // 
            // IP地址
            // 
            this.IP地址.HeaderText = "IP地址";
            this.IP地址.Name = "IP地址";
            // 
            // 端口
            // 
            this.端口.HeaderText = "端口";
            this.端口.Name = "端口";
            // 
            // 地区
            // 
            this.地区.HeaderText = "地区";
            this.地区.Name = "地区";
            // 
            // 状态
            // 
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(157, 492);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 41);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "清除所有";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.ForeColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(238, 492);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 41);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "清除账号";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.ForeColor = System.Drawing.Color.Red;
            this.btn4.Location = new System.Drawing.Point(319, 492);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 41);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "清除IP";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.right_refresh,
            this.right_importuser,
            this.right_adduser,
            this.right_saveuser,
            this.right_selall,
            this.right_invertsel,
            this.right_cancel,
            this.right_delete,
            this.right_clean,
            this.right_set});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 224);
            // 
            // right_refresh
            // 
            this.right_refresh.Image = ((System.Drawing.Image)(resources.GetObject("right_refresh.Image")));
            this.right_refresh.Name = "right_refresh";
            this.right_refresh.Size = new System.Drawing.Size(124, 22);
            this.right_refresh.Text = "刷新";
            this.right_refresh.Click += new System.EventHandler(this.right_refresh_Click);
            // 
            // right_importuser
            // 
            this.right_importuser.Image = ((System.Drawing.Image)(resources.GetObject("right_importuser.Image")));
            this.right_importuser.Name = "right_importuser";
            this.right_importuser.Size = new System.Drawing.Size(124, 22);
            this.right_importuser.Text = "导入账号";
            this.right_importuser.Click += new System.EventHandler(this.right_importuser_Click);
            // 
            // right_adduser
            // 
            this.right_adduser.Image = ((System.Drawing.Image)(resources.GetObject("right_adduser.Image")));
            this.right_adduser.Name = "right_adduser";
            this.right_adduser.Size = new System.Drawing.Size(124, 22);
            this.right_adduser.Text = "添加账号";
            this.right_adduser.Click += new System.EventHandler(this.right_adduser_Click);
            // 
            // right_saveuser
            // 
            this.right_saveuser.Image = ((System.Drawing.Image)(resources.GetObject("right_saveuser.Image")));
            this.right_saveuser.Name = "right_saveuser";
            this.right_saveuser.Size = new System.Drawing.Size(124, 22);
            this.right_saveuser.Text = "保存账号";
            this.right_saveuser.Click += new System.EventHandler(this.right_saveuser_Click);
            // 
            // right_selall
            // 
            this.right_selall.Image = ((System.Drawing.Image)(resources.GetObject("right_selall.Image")));
            this.right_selall.Name = "right_selall";
            this.right_selall.Size = new System.Drawing.Size(124, 22);
            this.right_selall.Text = "全选";
            this.right_selall.Click += new System.EventHandler(this.right_selall_Click);
            // 
            // right_invertsel
            // 
            this.right_invertsel.Image = ((System.Drawing.Image)(resources.GetObject("right_invertsel.Image")));
            this.right_invertsel.Name = "right_invertsel";
            this.right_invertsel.Size = new System.Drawing.Size(124, 22);
            this.right_invertsel.Text = "反选";
            this.right_invertsel.Click += new System.EventHandler(this.right_invertsel_Click);
            // 
            // right_cancel
            // 
            this.right_cancel.Image = ((System.Drawing.Image)(resources.GetObject("right_cancel.Image")));
            this.right_cancel.Name = "right_cancel";
            this.right_cancel.Size = new System.Drawing.Size(124, 22);
            this.right_cancel.Text = "取消";
            this.right_cancel.Click += new System.EventHandler(this.right_cancel_Click);
            // 
            // right_delete
            // 
            this.right_delete.Image = ((System.Drawing.Image)(resources.GetObject("right_delete.Image")));
            this.right_delete.Name = "right_delete";
            this.right_delete.Size = new System.Drawing.Size(124, 22);
            this.right_delete.Text = "删除";
            this.right_delete.Click += new System.EventHandler(this.right_delete_Click);
            // 
            // right_clean
            // 
            this.right_clean.Image = ((System.Drawing.Image)(resources.GetObject("right_clean.Image")));
            this.right_clean.Name = "right_clean";
            this.right_clean.Size = new System.Drawing.Size(124, 22);
            this.right_clean.Text = "清空";
            this.right_clean.Click += new System.EventHandler(this.right_clean_Click);
            // 
            // right_set
            // 
            this.right_set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.right_font,
            this.right_color});
            this.right_set.Image = ((System.Drawing.Image)(resources.GetObject("right_set.Image")));
            this.right_set.Name = "right_set";
            this.right_set.Size = new System.Drawing.Size(124, 22);
            this.right_set.Text = "设置";
            // 
            // right_font
            // 
            this.right_font.Image = ((System.Drawing.Image)(resources.GetObject("right_font.Image")));
            this.right_font.Name = "right_font";
            this.right_font.Size = new System.Drawing.Size(100, 22);
            this.right_font.Text = "字体";
            // 
            // right_color
            // 
            this.right_color.Image = ((System.Drawing.Image)(resources.GetObject("right_color.Image")));
            this.right_color.Name = "right_color";
            this.right_color.Size = new System.Drawing.Size(100, 22);
            this.right_color.Text = "风格";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.left_refresh,
            this.left_importip,
            this.left_addip,
            this.left_saveip,
            this.left_selall,
            this.left_invertsel,
            this.left_cancel,
            this.left_delete,
            this.left_clean,
            this.left_set});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(112, 224);
            // 
            // left_refresh
            // 
            this.left_refresh.Image = ((System.Drawing.Image)(resources.GetObject("left_refresh.Image")));
            this.left_refresh.Name = "left_refresh";
            this.left_refresh.Size = new System.Drawing.Size(111, 22);
            this.left_refresh.Text = "刷新";
            this.left_refresh.Click += new System.EventHandler(this.left_refresh_Click);
            // 
            // left_importip
            // 
            this.left_importip.Image = ((System.Drawing.Image)(resources.GetObject("left_importip.Image")));
            this.left_importip.Name = "left_importip";
            this.left_importip.Size = new System.Drawing.Size(111, 22);
            this.left_importip.Text = "导入IP";
            this.left_importip.Click += new System.EventHandler(this.left_importip_Click);
            // 
            // left_addip
            // 
            this.left_addip.Image = ((System.Drawing.Image)(resources.GetObject("left_addip.Image")));
            this.left_addip.Name = "left_addip";
            this.left_addip.Size = new System.Drawing.Size(111, 22);
            this.left_addip.Text = "添加IP";
            this.left_addip.Click += new System.EventHandler(this.left_addip_Click);
            // 
            // left_saveip
            // 
            this.left_saveip.Image = ((System.Drawing.Image)(resources.GetObject("left_saveip.Image")));
            this.left_saveip.Name = "left_saveip";
            this.left_saveip.Size = new System.Drawing.Size(111, 22);
            this.left_saveip.Text = "保存IP";
            this.left_saveip.Click += new System.EventHandler(this.left_saveip_Click);
            // 
            // left_selall
            // 
            this.left_selall.Image = ((System.Drawing.Image)(resources.GetObject("left_selall.Image")));
            this.left_selall.Name = "left_selall";
            this.left_selall.Size = new System.Drawing.Size(111, 22);
            this.left_selall.Text = "全选";
            this.left_selall.Click += new System.EventHandler(this.left_selall_Click);
            // 
            // left_invertsel
            // 
            this.left_invertsel.Image = ((System.Drawing.Image)(resources.GetObject("left_invertsel.Image")));
            this.left_invertsel.Name = "left_invertsel";
            this.left_invertsel.Size = new System.Drawing.Size(111, 22);
            this.left_invertsel.Text = "反选";
            this.left_invertsel.Click += new System.EventHandler(this.left_invertsel_Click);
            // 
            // left_cancel
            // 
            this.left_cancel.Image = ((System.Drawing.Image)(resources.GetObject("left_cancel.Image")));
            this.left_cancel.Name = "left_cancel";
            this.left_cancel.Size = new System.Drawing.Size(111, 22);
            this.left_cancel.Text = "取消";
            this.left_cancel.Click += new System.EventHandler(this.left_cancel_Click);
            // 
            // left_delete
            // 
            this.left_delete.Image = ((System.Drawing.Image)(resources.GetObject("left_delete.Image")));
            this.left_delete.Name = "left_delete";
            this.left_delete.Size = new System.Drawing.Size(111, 22);
            this.left_delete.Text = "删除";
            this.left_delete.Click += new System.EventHandler(this.left_delete_Click);
            // 
            // left_clean
            // 
            this.left_clean.Image = ((System.Drawing.Image)(resources.GetObject("left_clean.Image")));
            this.left_clean.Name = "left_clean";
            this.left_clean.Size = new System.Drawing.Size(111, 22);
            this.left_clean.Text = "清空";
            this.left_clean.Click += new System.EventHandler(this.left_clean_Click);
            // 
            // left_set
            // 
            this.left_set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.left_font,
            this.left_color});
            this.left_set.Image = ((System.Drawing.Image)(resources.GetObject("left_set.Image")));
            this.left_set.Name = "left_set";
            this.left_set.Size = new System.Drawing.Size(111, 22);
            this.left_set.Text = "设置";
            // 
            // left_font
            // 
            this.left_font.Image = ((System.Drawing.Image)(resources.GetObject("left_font.Image")));
            this.left_font.Name = "left_font";
            this.left_font.Size = new System.Drawing.Size(100, 22);
            this.left_font.Text = "字体";
            // 
            // left_color
            // 
            this.left_color.Image = ((System.Drawing.Image)(resources.GetObject("left_color.Image")));
            this.left_color.Name = "left_color";
            this.left_color.Size = new System.Drawing.Size(100, 22);
            this.left_color.Text = "风格";
            // 
            // importuserDialog
            // 
            this.importuserDialog.FileName = "importuserDialog";
            // 
            // importipDialog
            // 
            this.importipDialog.FileName = "importipDialog";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(979, 545);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新浪微博动态批量发布";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importip;
        private System.Windows.Forms.ToolStripMenuItem saveip;
        private System.Windows.Forms.ToolStripMenuItem importuser;
        private System.Windows.Forms.ToolStripMenuItem adduser;
        private System.Windows.Forms.ToolStripMenuItem refresh;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ToolStripMenuItem saveuser;
        private System.Windows.Forms.ToolStripMenuItem addip;
        private System.Windows.Forms.ToolStripMenuItem 其它ToolStripMenuItem;
        private System.Windows.Forms.Button btn1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem right_importuser;
        private System.Windows.Forms.ToolStripMenuItem right_adduser;
        private System.Windows.Forms.ToolStripMenuItem right_saveuser;
        private System.Windows.Forms.ToolStripMenuItem right_selall;
        private System.Windows.Forms.ToolStripMenuItem right_invertsel;
        private System.Windows.Forms.ToolStripMenuItem right_cancel;
        private System.Windows.Forms.ToolStripMenuItem right_delete;
        private System.Windows.Forms.ToolStripMenuItem right_clean;
        private System.Windows.Forms.ToolStripMenuItem right_set;
        private System.Windows.Forms.ToolStripMenuItem right_font;
        private System.Windows.Forms.ToolStripMenuItem right_color;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem left_importip;
        private System.Windows.Forms.ToolStripMenuItem left_addip;
        private System.Windows.Forms.ToolStripMenuItem left_saveip;
        private System.Windows.Forms.ToolStripMenuItem left_selall;
        private System.Windows.Forms.ToolStripMenuItem left_invertsel;
        private System.Windows.Forms.ToolStripMenuItem left_cancel;
        private System.Windows.Forms.ToolStripMenuItem left_delete;
        private System.Windows.Forms.ToolStripMenuItem left_clean;
        private System.Windows.Forms.ToolStripMenuItem left_set;
        private System.Windows.Forms.ToolStripMenuItem left_font;
        private System.Windows.Forms.ToolStripMenuItem left_color;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem right_refresh;
        private System.Windows.Forms.ToolStripMenuItem left_refresh;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog importuserDialog;
        private System.Windows.Forms.OpenFileDialog importipDialog;
        private System.Windows.Forms.SaveFileDialog saveuserDialog;
        private System.Windows.Forms.SaveFileDialog saveipDialog;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP地址;
        private System.Windows.Forms.DataGridViewTextBoxColumn 端口;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地区;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;

    }
}

