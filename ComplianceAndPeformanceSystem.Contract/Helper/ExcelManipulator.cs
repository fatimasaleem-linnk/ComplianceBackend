using OfficeOpenXml;
using System.Reflection;

namespace ComplianceAndPeformanceSystem.Contract.Helper;

public static class ExcelManipulator
{
    public static byte[] CreateExcel<T>(IEnumerable<T> data, string worksheetName = null) where T : class
    {
        using (ExcelPackage excelPackage = new ExcelPackage())
        {
            // Default name of workshhet
            var sheetName = "Sheet1";

            // If parameter is sent, override the default name
            if (!string.IsNullOrWhiteSpace(worksheetName))
            {
                sheetName = worksheetName;
            }

            //Create the worksheet
            var worksheet = excelPackage.Workbook.Worksheets.Add(sheetName);

            //get our column headings
            var t = typeof(T);
            List<PropertyInfo> typeProperties = new List<PropertyInfo>(t.GetProperties());
            List<PropertyInfo> filteredTypeProperties = new List<PropertyInfo>();

            int counter = 1;
            foreach (var typeProperty in typeProperties)
            {
                // Get excel attribute of this property
                var excelAttribute = typeProperty.GetCustomAttribute(typeof(ExcelExportAttribute)) as ExcelExportAttribute;
                if (excelAttribute != null)
                {
                    var displayProperty = excelAttribute.HeaderName;

                    // Fill the header
                    // If display of attribute is spcified, use it, else display the property name
                    if (!string.IsNullOrWhiteSpace(displayProperty))
                    {
                        worksheet.Cells[1, counter].Value = displayProperty;
                    }
                    else
                    {
                        worksheet.Cells[1, counter].Value = typeProperty.Name;
                    }

                    filteredTypeProperties.Add(typeProperty);
                    counter++;
                }
            }

            var rowsCount = data.Count();

            // Fill the content
            if (rowsCount > 0)
            {
                worksheet.Cells["A2"].LoadFromCollectionFiltered(data);
                //worksheet.Cells["A2"].LoadFromCollection(data);
            }

            // Format the header
            using (ExcelRange headeRange = worksheet.Cells["A1:BZ1"])
            {
                headeRange.Style.Font.Bold = true;
            }

            // If the property is datetime, format the whole column
            for (int i = 0; i < filteredTypeProperties.Count; i++)
            {
                worksheet.Column(i + 1).AutoFit();
                var prop = filteredTypeProperties[i];
                if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                {
                    worksheet.Column(i + 1).Style.Numberformat.Format = "dd/mm/yyyy";
                }
            }

            return excelPackage.GetAsByteArray();
        }
    }

    public static ExcelRangeBase LoadFromCollectionFiltered<T>(this ExcelRangeBase @this, IEnumerable<T> collection) where T : class
    {
        MemberInfo[] membersToInclude = typeof(T)
            .GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => Attribute.IsDefined(p, typeof(ExcelExportAttribute)))
            .ToArray();

        return @this.LoadFromCollection<T>(collection, false,
            OfficeOpenXml.Table.TableStyles.None,
            BindingFlags.Instance | BindingFlags.Public,
            membersToInclude);
    }
}


public class ExcelExportAttribute : Attribute
{
    public string HeaderName { get; set; }
}