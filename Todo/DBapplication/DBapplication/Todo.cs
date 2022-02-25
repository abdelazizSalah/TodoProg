using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Todo : Form
    {
        Controller CS = new Controller();
        public Todo()
        {
            InitializeComponent();
            TodoList.DataSource = CS.AllTodos();
            TodoItem.Text = "NewTodo"; 
        }

        private void add_click(object sender, EventArgs e)
        {
            if (TodoItem.Text != "")
            {
                CS.insertTodo(TodoItem.Text, DatePick.Text);
                TodoList.DataSource = CS.AllTodos();
                TodoItem.Text = "New Todo ";
            }
            else
                MessageBox.Show("insert a Todo");
        }

        private void RemoveTodo_Click(object sender, EventArgs e)
        {
            int RowIndex = TodoList.CurrentCell.RowIndex;
            CS.RemoveItem(TodoList.Rows[RowIndex].Cells[0].Value.ToString(), TodoList.Rows[RowIndex].Cells[1].Value.ToString());
            TodoItem.Text = "New Todo ";
            TodoList.DataSource = CS.AllTodos();
        }

        private void FinishTodo_Click(object sender, EventArgs e)
        {
            int RowIndex = TodoList.CurrentCell.RowIndex;
            CS.RemoveItem(TodoList.Rows[RowIndex].Cells[0].Value.ToString(), TodoList.Rows[RowIndex].Cells[1].Value.ToString());
            CS.addDone(TodoList.Rows[RowIndex].Cells[0].Value.ToString(), TodoList.Rows[RowIndex].Cells[1].Value.ToString());
            TodoItem.Text = "New Todo ";
            TodoList.DataSource = CS.AllTodos();
            DoneList.DataSource = CS.AllDone();
        }

        private void ClearTodo_Click(object sender, EventArgs e)
        {
            CS.ClearDone();
            TodoItem.Text = "New Todo ";
            DoneList.DataSource = CS.AllDone();
        }


        private void TodoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                this.add_click(sender, e);
            }
        }

        private void TodoItem_Click_1(object sender, EventArgs e)
        {
            TodoItem.Text = "";
        }
    }
}
