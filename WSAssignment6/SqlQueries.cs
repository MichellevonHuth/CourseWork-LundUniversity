using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSAssignment6
{
    public class SqlQueries
    {

        public static string MetaDataForEmployeeTable()

        {
            string sqlCommand = "SELECT TABLE_CATALOG as table_catalog, TABLE_NAME as table_name, COLUMN_NAME as column_name, ORDINAL_POSITION as ordinal_position, IS_NULLABLE as is_nullable, DATA_TYPE as data_type FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'";
            return sqlCommand;
        }

        public static string EmployeeRelatives()
        {
            string sqlCommand = "SELECT [Employee No_],[Relative Code],[First Name], [Last Name], [Birth Date] FROM[CRONUS Sverige AB$Employee Relative]";
            return sqlCommand;
        }

        public static string EmployeeAbsent2004()
        {

            string sqlCommand = "SELECT [Employee No_] as Employee_Number FROM[CRONUS Sverige AB$Employee Absence] WHERE[Cause of Absence Code] = 'SJUK' AND[From Date] < '2005-01-01 00:00:00.000' GROUP BY[Employee No_]";
            return sqlCommand;
        }

        public static string EmployeeAbsentTheMost()
        {
            string sqlCommand = "SELECT TOP 1 e.[First Name] FROM[CRONUS Sverige AB$Employee] e JOIN[CRONUS Sverige AB$Employee Absence] er ON e.No_ = er.[Employee No_] GROUP BY er.[Employee No_], e.[First Name] ORDER BY COUNT(*) DESC";
            return sqlCommand;
        }

        public static string AllKeys()
        {
            string sqlCommand = "SELECT COLUMN_NAME as Column_name, CONSTRAINT_NAME as Constraint_name, type as Key_type, Type_desc, object_id as Object_id FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu JOIN sys.objects kc ON ccu.CONSTRAINT_NAME = kc.name WHERE type_desc LIKE '%KEY%'";
            return sqlCommand;
        }

        public static string AllIndexes()
        {
            string sqlCommand = "SELECT object_id,name, index_id FROM sys.indexes";
            return sqlCommand;
        }

        public static string AllTableConstraints()
        {
            string sqlCommand = "SELECT TABLE_NAME as Table_Name, CONSTRAINT_NAME as Column_Name, CONSTRAINT_TYPE as Constraint_Type FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
            return sqlCommand;
        }

        public static string AllTables1()
        {
            string sqlCommand = "SELECT TABLE_NAME as Tables FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE LIKE 'BASE TABLE' ";
            return sqlCommand;
        }

        public static string AllTables2()
        {
            string sqlCommand = "SELECT name as Tables FROM sys.tables";
            return sqlCommand;
        }

        public static string AllColumns1()
        {
            string sqlCommand = "SELECT COLUMN_NAME as Columns FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'";
            return sqlCommand;
        }

        public static string AllColumns2()
        {
            string sqlCommand = "SELECT name as Columns FROM sys.columns WHERE object_id = OBJECT_ID('dbo.CRONUS Sverige AB$Employee') ";
            return sqlCommand;
        }
    }
}