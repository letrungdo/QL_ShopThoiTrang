using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class SQL_Query
    {
        ConnectDB dB = new ConnectDB();

        /*
         *  INSERT INTO table_name (column1, column2, column3, ...)
            VALUES (value1, value2, value3, ...);
        */
        public int Insert(string tableName,string cols, string values)
        {
            return dB.ExecuteNonQuery("Insert Into " + tableName + "(" + cols + ") Values (" + values + ")");
        }

        /*
            INSERT INTO table_name
            VALUES (value1, value2, value3, ...);
        */
        public int Insert (string tableName, string values)
        {
            return dB.ExecuteNonQuery("Insert Into " + tableName + " Values (" + values + ")");
        }



        /*
         *  UPDATE table_name
            SET column1 = value1, column2 = value2, ...
            WHERE condition; 
        */
        public int Update (string tableName, string setCol_Value, string conditionWhere)
        {
            return dB.ExecuteNonQuery("Update " + tableName + " Set " + setCol_Value + " Where " + conditionWhere + "");
            
        }


        //DELETE FROM table_name
        //WHERE condition;
        public int Delete (string tableName, string conditionWhere)
        {
            return dB.ExecuteNonQuery("Delete From " + tableName + " Where " + conditionWhere + "");
        }


        //Kiểm tra khóa chính
        public int KiemTraKhoaChinh(string tableName, string conditionWhere)
        {
            return dB.ExecuteNonQuery("Select Count(*) From " + tableName + " Where " + conditionWhere + "");
        }

        
    }
}
