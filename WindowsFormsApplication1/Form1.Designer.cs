namespace WindowsFormsApplication1
{
    partial class SharpCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plus = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.delete = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(171, 37);
            this.plus.Margin = new System.Windows.Forms.Padding(0);
            this.plus.Name = "plus";
            this.plus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.plus.Size = new System.Drawing.Size(57, 37);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.display, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.05882F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.94118F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 255);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.delete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.divide, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearEntry, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plusMinus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.equals, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.point, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.clear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.num0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.num2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.num1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.num3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.multi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.num5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.subtract, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.num9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.num8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.plus, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 187);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delete.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1462139661_backspace;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(114, 0);
            this.delete.Margin = new System.Windows.Forms.Padding(0);
            this.delete.Name = "delete";
            this.delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete.Size = new System.Drawing.Size(57, 37);
            this.delete.TabIndex = 19;
            this.delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(171, 0);
            this.divide.Margin = new System.Windows.Forms.Padding(0);
            this.divide.Name = "divide";
            this.divide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.divide.Size = new System.Drawing.Size(57, 37);
            this.divide.TabIndex = 18;
            this.divide.Text = "÷";
            this.divide.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.divide.UseVisualStyleBackColor = false;
            // 
            // clearEntry
            // 
            this.clearEntry.AutoSize = true;
            this.clearEntry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clearEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntry.FlatAppearance.BorderSize = 0;
            this.clearEntry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clearEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntry.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry.Location = new System.Drawing.Point(0, 0);
            this.clearEntry.Margin = new System.Windows.Forms.Padding(0);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearEntry.Size = new System.Drawing.Size(57, 37);
            this.clearEntry.TabIndex = 17;
            this.clearEntry.Text = "CE";
            this.clearEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // plusMinus
            // 
            this.plusMinus.AutoSize = true;
            this.plusMinus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plusMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusMinus.FlatAppearance.BorderSize = 0;
            this.plusMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.plusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.plusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusMinus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusMinus.Location = new System.Drawing.Point(0, 148);
            this.plusMinus.Margin = new System.Windows.Forms.Padding(0);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.plusMinus.Size = new System.Drawing.Size(57, 39);
            this.plusMinus.TabIndex = 16;
            this.plusMinus.Text = "±";
            this.plusMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.plusMinus.UseVisualStyleBackColor = false;
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.equals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.equals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(171, 148);
            this.equals.Margin = new System.Windows.Forms.Padding(0);
            this.equals.Name = "equals";
            this.equals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equals.Size = new System.Drawing.Size(57, 39);
            this.equals.TabIndex = 15;
            this.equals.Text = "=";
            this.equals.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.button13_Click);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.BackColor = System.Drawing.Color.WhiteSmoke;
            this.point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.point.FlatAppearance.BorderSize = 0;
            this.point.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.point.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(114, 148);
            this.point.Margin = new System.Windows.Forms.Padding(0);
            this.point.Name = "point";
            this.point.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.point.Size = new System.Drawing.Size(57, 39);
            this.point.TabIndex = 14;
            this.point.Text = ".";
            this.point.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.button14_Click);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(57, 0);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clear.Size = new System.Drawing.Size(57, 37);
            this.clear.TabIndex = 13;
            this.clear.Text = "C";
            this.clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button15_Click);
            // 
            // num0
            // 
            this.num0.AutoSize = true;
            this.num0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(57, 148);
            this.num0.Margin = new System.Windows.Forms.Padding(0);
            this.num0.Name = "num0";
            this.num0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num0.Size = new System.Drawing.Size(57, 39);
            this.num0.TabIndex = 12;
            this.num0.Text = "0";
            this.num0.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.button16_Click);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(57, 111);
            this.num2.Margin = new System.Windows.Forms.Padding(0);
            this.num2.Name = "num2";
            this.num2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num2.Size = new System.Drawing.Size(57, 37);
            this.num2.TabIndex = 11;
            this.num2.Text = "2";
            this.num2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.button9_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(0, 111);
            this.num1.Margin = new System.Windows.Forms.Padding(0);
            this.num1.Name = "num1";
            this.num1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num1.Size = new System.Drawing.Size(57, 37);
            this.num1.TabIndex = 10;
            this.num1.Text = "1";
            this.num1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.button10_Click);
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(114, 111);
            this.num3.Margin = new System.Windows.Forms.Padding(0);
            this.num3.Name = "num3";
            this.num3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num3.Size = new System.Drawing.Size(57, 37);
            this.num3.TabIndex = 9;
            this.num3.Text = "3";
            this.num3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button11_Click);
            // 
            // multi
            // 
            this.multi.AutoSize = true;
            this.multi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.multi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multi.FlatAppearance.BorderSize = 0;
            this.multi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.multi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multi.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(171, 111);
            this.multi.Margin = new System.Windows.Forms.Padding(0);
            this.multi.Name = "multi";
            this.multi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.multi.Size = new System.Drawing.Size(57, 37);
            this.multi.TabIndex = 8;
            this.multi.Text = "×";
            this.multi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.button12_Click);
            // 
            // num5
            // 
            this.num5.AutoSize = true;
            this.num5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(57, 74);
            this.num5.Margin = new System.Windows.Forms.Padding(0);
            this.num5.Name = "num5";
            this.num5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num5.Size = new System.Drawing.Size(57, 37);
            this.num5.TabIndex = 7;
            this.num5.Text = "5";
            this.num5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.button5_Click);
            // 
            // subtract
            // 
            this.subtract.AutoSize = true;
            this.subtract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subtract.FlatAppearance.BorderSize = 0;
            this.subtract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.subtract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.subtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtract.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(171, 74);
            this.subtract.Margin = new System.Windows.Forms.Padding(0);
            this.subtract.Name = "subtract";
            this.subtract.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subtract.Size = new System.Drawing.Size(57, 37);
            this.subtract.TabIndex = 6;
            this.subtract.Text = "-";
            this.subtract.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.subtract.UseVisualStyleBackColor = false;
            this.subtract.Click += new System.EventHandler(this.button6_Click);
            // 
            // num4
            // 
            this.num4.AutoSize = true;
            this.num4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(0, 74);
            this.num4.Margin = new System.Windows.Forms.Padding(0);
            this.num4.Name = "num4";
            this.num4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num4.Size = new System.Drawing.Size(57, 37);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.button7_Click);
            // 
            // num6
            // 
            this.num6.AutoSize = true;
            this.num6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(114, 74);
            this.num6.Margin = new System.Windows.Forms.Padding(0);
            this.num6.Name = "num6";
            this.num6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num6.Size = new System.Drawing.Size(57, 37);
            this.num6.TabIndex = 4;
            this.num6.Text = "6";
            this.num6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.button8_Click);
            // 
            // num7
            // 
            this.num7.AutoSize = true;
            this.num7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(0, 37);
            this.num7.Margin = new System.Windows.Forms.Padding(0);
            this.num7.Name = "num7";
            this.num7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num7.Size = new System.Drawing.Size(57, 37);
            this.num7.TabIndex = 3;
            this.num7.Text = "7";
            this.num7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.button4_Click);
            // 
            // num9
            // 
            this.num9.AutoSize = true;
            this.num9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(114, 37);
            this.num9.Margin = new System.Windows.Forms.Padding(0);
            this.num9.Name = "num9";
            this.num9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num9.Size = new System.Drawing.Size(57, 37);
            this.num9.TabIndex = 2;
            this.num9.Text = "9";
            this.num9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.button3_Click);
            // 
            // num8
            // 
            this.num8.AutoSize = true;
            this.num8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(57, 37);
            this.num8.Margin = new System.Windows.Forms.Padding(0);
            this.num8.Name = "num8";
            this.num8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num8.Size = new System.Drawing.Size(57, 37);
            this.num8.TabIndex = 1;
            this.num8.Text = "8";
            this.num8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.button2_Click);
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(3, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(222, 68);
            this.display.TabIndex = 2;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SharpCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.tableLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "SharpCalculator";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Sharp Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.Label display;
    }
}

