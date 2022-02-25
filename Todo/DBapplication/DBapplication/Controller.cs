using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }


        public int NewTodo(string item , string Date)
        {
            // $ for formating
            string query = $"insert into Todo values( \'{item}\',\'{Date}\' ); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable AllTodos()
        {
            string query = "Select * from Todo";
            return dbMan.ExecuteReader(query);
        }

        public DataTable AllDone()
        {
            string query = "Select * from DoneTable";
            return dbMan.ExecuteReader(query);
        }

        //m7taga shwyt tfker de
        public int DoneTodo(string item, string Date)
        {
            // $ for formating
            string query= $""; 
            //string query = $"insert into DoneTable(Done , Date) values( (select item from Todo where item = \'{}\') ); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ClearDone()
        {
            // $ for formating
            string query = $"Delete from DoneTable";
            //string query = $"insert into DoneTable(Done , Date) values( (select item from Todo where item = \'{}\') ); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveItem(string NewTodo, string Date)
        {
            // $ for formating
            string query = $"Delete from Todo where item = \'{NewTodo}\' and Date = \'{Date}\' ";
            //string query = $"insert into DoneTable(Done , Date) values( (select item from Todo where item = \'{}\') ); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int insertTodo(string NewTodo, string Date)
        {
            // $ for formating
            string query = $"insert into Todo values (\'{NewTodo}\', \'{Date}\')";
            //string query = $"insert into DoneTable(Done , Date) values( (select item from Todo where item = \'{}\') ); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addDone(string NewTodo, string Date)
        {
            // $ for formating
            string query = $"insert into DoneTable values (\'{NewTodo}\', \'{Date}\')";
            //string query = $"insert into DoneTable(Done , Date) values( (select item from Todo where item = \'{}\') ); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
