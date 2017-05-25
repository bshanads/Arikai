using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
/// <summary>
/// Summary description for DataHelper
/// </summary>
public class DataHelper
{
    public DataHelper()
    {
        
    }


    public DataSet GetDataList(string ConnectionSring)
    {
        
        //string strSP = "Select	DateName(MM,e.BirthDate) as Month,DateName(dw,e.BirthDate) as Day,Year(e.BirthDate) as Year, Day(e.BirthDate) as DayName, MONTH(e.BirthDate) as MonthName,CASE WHEN (e.MaritalStatus) = 'M' THEN 'Married' WHEN (e.MaritalStatus) = 'S' THEN 'Single' END as MaritalStatus,		CASE WHEN (e.Gender) = 'M' THEN 'Male' WHEN (e.Gender) = 'F' THEN 'Female' END as Gender,Count(e.Title) as Count";
        //strSP += " from	HumanResources.Employee e, Person.Contact c,[HumanResources].[EmployeeDepartmentHistory] ed, [HumanResources].[Department] d, [HumanResources].Shift s";
        //strSP += " where c.ContactID = e.ContactID and ed.EmployeeID = e.EmployeeID	and ed.DepartmentID = d.DepartmentID	and s.ShiftID = ed.ShiftID";
        //strSP += " Group by e.MaritalStatus,e.Gender, DateName(MM,e.BirthDate),DateName(dw,e.BirthDate),Year(e.BirthDate),MONTH(e.BirthDate),Day(e.BirthDate) ";
        //strSP += " Order BY	MonthName,	DayName";

        string strsql = "Select ";
        strsql += " CR.Name as Country,";
        strsql += " ST.Name as Store,";
        strsql += " (SH.TotalDue) as Sales,";
        strsql += " SH.TotalDue as Sales,";
        strsql += " Year(SH.OrderDate) as [Year],";
        strsql += " MONTH(SH.OrderDate) as monthno,";
        strsql += " DateName(MM,SH.OrderDate) as [Month]";
        strsql += " from ";
        //strsql += " Sales.SalesOrderHeader SH,";
        strsql += " Sales.SalesOrderHeader SH left Outer join Sales.Store ST on SH.CustomerID = ST.CustomerID, ";
        
        strsql += " Sales.SalesTerritory STE,";
        strsql += " Person.CountryRegion CR";
        //strsql += " Sales.Store ST";
        strsql += " where";
        strsql += " SH.TerritoryID = STE.TerritoryID";
        strsql += " And";
        strsql += " STE.CountryRegionCode = CR.CountryRegionCode";
       // strsql += " And";
       // strsql += " ST.CustomerID = SH.CustomerID";
       // strsql += " Group by CR.Name, St.Name, Year(SH.OrderDate),MONTH(SH.OrderDate),DateName(MM,SH.OrderDate)";
        strsql += " order by  [Year], monthno";


        DataSet dsForumList = SqlHelper.ExecuteDataset(ConnectionSring, CommandType.Text, strsql);

        return dsForumList;
    }



    
}