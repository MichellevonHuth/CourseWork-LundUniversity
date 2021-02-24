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
            string sqlCommand = 
            return sqlCommand;
        }

        public static string EmployeeRelatives()
        {
            string sqlCommand = "SELECT [Employee No_],[Relative Code],[First Name], [Last Name], [Birth Date] FROM[CRONUS Sverige AB$Employee Relative]";
            return sqlCommand;
        }

        public static string EmployeeAbsent2004()
        {

            string sqlCommand = "UPDATE [CRONUS Sverige AB$Employee] SET [First Name] = @[First Name], [Last Name]= @[Last Name], [Job Title] = @[Job Title] WHERE[No_] = @[No_]";
            return sqlCommand;
        }

        public static string EmployeeAbsentTheMost()
        {
            string sqlCommand = "DELETE FROM [CRONUS Sverige AB$Employee] WHERE [No_] = @[No_]";
            return sqlCommand;
        }

        public static string AllKeys()
        {
            string sqlCommand = "SELECT COLUMN_NAME as Column_name, CONSTRAINT_NAME as Constraint_name, type as Key_tape, Type_desc, object_id as Object_id FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu JOIN sys.objects kc ON ccu.CONSTRAINT_NAME = kc.name WHERE type_desc LIKE '%KEY%'";
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