using System.Data;
using System.Dynamic;

public static class DynamicTable
{
    public static IEnumerable<dynamic> AsDynamicEnumerable(this DataTable self)
    {
        if (self == null)
            return Enumerable.Empty<dynamic>();
        var columns = self.Columns;
        return self.AsEnumerable().Select(x => extract(x, columns));
    }

    private static object extract(DataRow row, DataColumnCollection columns)
    {
        var expando = new ExpandoObject() as IDictionary<string, object>;
        foreach (DataColumn col in columns)
            expando.Add(col.ColumnName, row[col.ColumnName] == DBNull.Value ? null : row[col.ColumnName]);
        return expando;
    }
}