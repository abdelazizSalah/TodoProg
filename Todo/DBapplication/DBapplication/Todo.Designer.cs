
namespace DBapplication
{
    partial class Todo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Todo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DoneList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TodoList = new System.Windows.Forms.DataGridView();
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TodoItem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FinishTodo = new System.Windows.Forms.Button();
            this.ClearTodo = new System.Windows.Forms.Button();
            this.AddTodo = new System.Windows.Forms.Button();
            this.RemoveTodo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoneList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodoList)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DoneList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TodoList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DatePick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TodoItem, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 527);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DoneList
            // 
            this.DoneList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoneList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoneList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoneList.Location = new System.Drawing.Point(436, 51);
            this.DoneList.Name = "DoneList";
            this.DoneList.RowHeadersWidth = 51;
            this.DoneList.RowTemplate.Height = 24;
            this.DoneList.Size = new System.Drawing.Size(428, 473);
            this.DoneList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todo";
            // 
            // TodoList
            // 
            this.TodoList.AllowUserToAddRows = false;
            this.TodoList.AllowUserToDeleteRows = false;
            this.TodoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TodoList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TodoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoList.Location = new System.Drawing.Point(3, 51);
            this.TodoList.Name = "TodoList";
            this.TodoList.ReadOnly = true;
            this.TodoList.RowHeadersWidth = 51;
            this.TodoList.RowTemplate.Height = 24;
            this.TodoList.Size = new System.Drawing.Size(427, 473);
            this.TodoList.TabIndex = 4;
            // 
            // DatePick
            // 
            this.DatePick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePick.Location = new System.Drawing.Point(436, 25);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(428, 22);
            this.DatePick.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(436, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Done";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TodoItem
            // 
            this.TodoItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoItem.Location = new System.Drawing.Point(3, 25);
            this.TodoItem.Name = "TodoItem";
            this.TodoItem.Size = new System.Drawing.Size(427, 22);
            this.TodoItem.TabIndex = 7;
            this.TodoItem.Click += new System.EventHandler(this.TodoItem_Click_1);
            this.TodoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TodoItem_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.12791F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.87209F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel2.Controls.Add(this.FinishTodo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClearTodo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddTodo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemoveTodo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 527);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(0, 47);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(867, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // FinishTodo
            // 
            this.FinishTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinishTodo.Location = new System.Drawing.Point(435, 3);
            this.FinishTodo.Name = "FinishTodo";
            this.FinishTodo.Size = new System.Drawing.Size(206, 41);
            this.FinishTodo.TabIndex = 11;
            this.FinishTodo.Text = "FinishTodo";
            this.FinishTodo.UseVisualStyleBackColor = true;
            this.FinishTodo.Click += new System.EventHandler(this.FinishTodo_Click);
            // 
            // ClearTodo
            // 
            this.ClearTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearTodo.Location = new System.Drawing.Point(647, 3);
            this.ClearTodo.Name = "ClearTodo";
            this.ClearTodo.Size = new System.Drawing.Size(217, 41);
            this.ClearTodo.TabIndex = 10;
            this.ClearTodo.Text = "ClearDoneList";
            this.ClearTodo.UseVisualStyleBackColor = true;
            this.ClearTodo.Click += new System.EventHandler(this.ClearTodo_Click);
            // 
            // AddTodo
            // 
            this.AddTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTodo.Location = new System.Drawing.Point(3, 3);
            this.AddTodo.Name = "AddTodo";
            this.AddTodo.Size = new System.Drawing.Size(206, 41);
            this.AddTodo.TabIndex = 9;
            this.AddTodo.Text = "AddTodo";
            this.AddTodo.UseVisualStyleBackColor = true;
            this.AddTodo.Click += new System.EventHandler(this.add_click);
            // 
            // RemoveTodo
            // 
            this.RemoveTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveTodo.Location = new System.Drawing.Point(215, 3);
            this.RemoveTodo.Name = "RemoveTodo";
            this.RemoveTodo.Size = new System.Drawing.Size(214, 41);
            this.RemoveTodo.TabIndex = 8;
            this.RemoveTodo.Text = "RemoveTodo";
            this.RemoveTodo.UseVisualStyleBackColor = true;
            this.RemoveTodo.Click += new System.EventHandler(this.RemoveTodo_Click);
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(867, 577);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Todo";
            this.Text = "TodoZ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoneList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodoList)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DoneList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TodoList;
        private System.Windows.Forms.DateTimePicker DatePick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button FinishTodo;
        private System.Windows.Forms.Button ClearTodo;
        private System.Windows.Forms.Button AddTodo;
        private System.Windows.Forms.Button RemoveTodo;
        private System.Windows.Forms.TextBox TodoItem;
    }
}