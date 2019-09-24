using System.Text;
using DatabaseDiscoveryTool.UI.WinForms.Models;

namespace DatabaseDiscoveryTool.UI.WinForms.Helpers
{
    public static class SqlHelper
    {
        public static string GetQuery(this SearchConditions model)
        {
            string cmdtext;
            if (!string.IsNullOrEmpty(model.SearchValue))
            {
                LookupForValueQuery query = new LookupForValueQuery();
                cmdtext = query.GetQueryText(model.SearchValue, model.Search1 ?? "");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(model.Search2))
                {
                    cmdtext = string.Format(
                        @"DECLARE @search nvarchar(40)
set @search = '%{0}%'
SELECT COLUMN_NAME, TABLE_SCHEMA, TABLE_NAME  FROM INFORMATION_SCHEMA.COLUMNS WHERE (COLUMN_NAME LIKE @search or TABLE_NAME like @search) ORDER BY TABLE_NAME",
                        model.Search1);
                }
                else
                {
                    cmdtext = string.Format(
                        @"DECLARE @search1 nvarchar(40), @search2 nvarchar(40)
set @search1 = '%{0}%'
set @search2 = '%{1}%'
SELECT COLUMN_NAME, TABLE_SCHEMA, TABLE_NAME  FROM INFORMATION_SCHEMA.COLUMNS WHERE (COLUMN_NAME LIKE @search1 or TABLE_NAME like @search1) AND (COLUMN_NAME LIKE @search2) ORDER BY TABLE_NAME",
                        model.Search1, model.Search2);
                }
            }
            return cmdtext;
        }

        public static string GetQueryAsDisplayText(this SearchConditions model)
        {
            var text = model.GetQuery();
            return string.Format(
@"USE {0}
GO
{1}", model.Database, text);
        }

        
    }
    class LookupForValueQuery
    {
        #region constants
        private const string DeclareResults = @"DECLARE @Results TABLE ([TABLE] nvarchar(370),[COLUMN] nvarchar(370), [COLUMN_VALUE] nvarchar(3630))";
        private const string DeclareVars = @"DECLARE @TableName nvarchar(256), @ColumnName nvarchar(128),@SearchStr nvarchar(128),@SearchStr2 nvarchar(140)";
        private const string SetSearchStr = @"
Set @SearchStr = '%{0}%'
SET @SearchStr2 = QUOTENAME('%' + @SearchStr + '%','''')
";
        private const string SetInitialTableName = @"Set @TableName = '{0}'";
        private const string WhileLoop = @"WHILE @TableName IS NOT NULL
BEGIN
    SET @ColumnName = ''
    SET @TableName =     ({0})

    {1}    
END

SELECT [TABLE],[COLUMN], [COLUMN_VALUE] FROM @Results
";
        private const string SetTableName = @"SELECT MIN(QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME))
        FROM     INFORMATION_SCHEMA.TABLES
        WHERE TABLE_TYPE = 'BASE TABLE'
            AND    QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME) > @TableName
            AND    OBJECTPROPERTY(OBJECT_ID(QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME)), 'IsMSShipped') = 0";

        private const string While2Loop = @"
WHILE (@TableName IS NOT NULL) AND (@ColumnName IS NOT NULL)
    BEGIN
        SET @ColumnName = ({0})
            IF @ColumnName IS NOT NULL 
                BEGIN
                    INSERT INTO @Results
                    EXEC(  {1}  )            
                END
    END
";
        private const string SetColumnName = @"SELECT MIN(QUOTENAME(COLUMN_NAME)) FROM     INFORMATION_SCHEMA.COLUMNS
            WHERE  TABLE_SCHEMA  = PARSENAME(@TableName, 2)  AND    TABLE_NAME    = PARSENAME(@TableName, 1)
            AND    DATA_TYPE IN ({0}) AND    QUOTENAME(COLUMN_NAME) > @ColumnName";

        private const string Exec = @"'SELECT '''+@TableName+''', '''+@ColumnName+''', LEFT('+@ColumnName+', 3630) FROM ' + @TableName + ' (NOLOCK) WHERE ' + @ColumnName + ' LIKE ' + @SearchStr2 "; 
        #endregion
        private string DATA_TYPES_IN = @"'char', 'varchar', 'nchar', 'nvarchar', 'int', 'decimal','bigint','money','float','date','time','smalldatetime','datetime','datetime2'";

        public string GetQueryText(string searchValue, string initialTableName="")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SET NOCOUNT ON");
            sb.AppendLine(DeclareResults);
            sb.AppendLine(DeclareVars);
            sb.AppendFormat(SetSearchStr, searchValue);
            sb.AppendLine();
            sb.AppendFormat(SetInitialTableName, initialTableName);
            sb.AppendLine();
            var whileLoopStatement = string.Format(While2Loop, string.Format(SetColumnName,DATA_TYPES_IN),Exec);
            sb.AppendFormat(WhileLoop, SetTableName, whileLoopStatement);
            return sb.ToString();
        }


    }


    

   
}