using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class DataService
{
	// To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
	// To create an operation that returns XML,
	//     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
	//     and include the following line in the operation body:
	//         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
    [OperationContract]
    [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
	public string GetData()
	{
        DataHelper dhpr = new DataHelper();
        var connectionString = ConfigurationManager.AppSettings["DBCONNECTION"].ToString();
        var ds = dhpr.GetDataList(connectionString);
        var jsonString = JSONHelper.FromDataTable(ds.Tables[0]);
        return jsonString;
	}

	// Add more operations here and mark them with [OperationContract]
}
