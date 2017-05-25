<div dir="ltr" style="padding-left:20px;padding-right:20px"><div style="display:blocDownload"><h3 style="text-align:left"><b><font color="#45818e">Arikai - <font size="3">Javascript Pivot Table Library</font></font></b></h3>
<a href="https://bshanads.github.io/Arikai/Arikai%20Demo/SamplePage.htm">Demo Page</a>

<div><div style="display:block;text-align:left"><b style="font-size:small"><p> ARIKAI Pivottable is a javascript data summarization tool, takes JSON object as input and that automatically extracts, organizes, and summarizes them by preferred categories and forms rows and columns in effortless way. </p>
  <p>ARIKAI Pivottable brings the features of Excel’s PivotTable to web applications, and it makes easy to web programmer for generating meaningful information from raw JSON data to complex cross-table reports online.</p><p>   ARIKAI Pivottable offers edit and filter layout options. In just few clicks, it enables end users to manipulate data with different categorization and calculations, which allows users to analyze the relationship between data points dynamically online. Since it is with Javascript and Jquery, can be used in any web applications (supports ASP.Net and Java web applications)</p><br><div><p><img alt="Pivot javascript library - Arikai" border="0" src="https://sites.google.com/site/niralaakkam/home/Niral_Aakkam_Arikai_Sample1.3.JPG" style="height:200px;width:900px"></p><p><b style="font-family:arial,sans-serif;font-size:medium">Arikai Pivottable Features</b></p><div><ul><li><span style="line-height:19px;font-family:arial,sans-serif;font-size:small">Easy to plug-in any web applications, easily configurable</span></li><li><font face="arial, sans-serif" size="2"><span style="line-height:19px">Client-side; light weight; HTML, Javascript and Jquery based</span></font></li><li><font face="arial, sans-serif" size="2"><span style="line-height:19px">Supports multi browsers</span></font></li><li><font face="arial, sans-serif" size="2"><span style="line-height:19px">Ability to add multilevel row and column area fields</span></font></li><li><font face="arial, sans-serif" size="2"><span style="line-height:19px">Supports SUM, AVG, COUNT, MAX and MIN aggregate functions.</span></font></li><li><font face="arial, sans-serif" size="2"><span style="line-height:19px">Provides utility to edit and filter layout of generated report in client-side.</span></font></li><li><font face="arial, sans-serif" size="2"><span style="line-height:19px">Simple CSS style sheet</span></font></li></ul><div><br></div><div><br></div></div><div></div>
</div>

<div style="padding:0 20px"><h3><b><font size="3">How to use</font></b></h3></div>
<p>Arikai easy to include in your app with few simple steps.    Arikai is using Jquery and Jquery UI library. So include it in your page.</p>
<pre style="font-family:arial;font-size:12px;border:1px dashed #cccccc;width:99%;height:auto;overflow:auto;background:#f0f0f0;padding:0px;color:#000000;text-align:left;line-height:20px"><code style="color:#000000;word-wrap:normal">&lt;script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"&gt;&lt;/script&gt;  
&lt;script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.22/jquery-ui.min.js"&gt;&lt;/script&gt;  
&lt;link rel="stylesheet" type="text/css" href=http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.9/themes/base/jquery-ui.css /&gt;  </code></pre>
 <p>Download Arikai V1.3.1.zip file and the extract the Arikai javascript file, stylesheet and icons image folders. Include extracted files Arikai.min.js to scripts folder, Ariaki.css and icons folder to Styles folder (as shown in image bellow).</p>
 <p>Then include the Arikai reference to the page for generating pivot report as shown bellow</p>
 <img alt="Arikai - Solution files" border="0" src="https://sites.google.com/site/niralaakkam/how-to-use/Niral_Aakkam_Arikai_soluionfiles.JPG">
 <pre style="font-family:arial;font-size:12px;border:1px dashed #cccccc;width:99%;height:auto;overflow:auto;background:#f0f0f0;padding:0px;color:#000000;text-align:left;line-height:20px"><code style="color:#000000;word-wrap:normal">  &lt;script src="Scripts/Arikai.min.js" type="text/javascript"&gt;&lt;/script&gt;    
 &lt;link href="Styles/Arikai.css" rel="stylesheet" type="text/css" /&gt;  </code></pre>
 <p>Arikai needs Json data to create pivot report. Restful services can be used to get it. Here a sample data is given.
 </p>
 <pre style="font-family:arial;font-size:12px;border:1px dashed #cccccc;width:99%;height:auto;overflow:auto;background:#f0f0f0;padding:0px;color:#000000;text-align:left;line-height:20px"><code style="color:#000000;word-wrap:normal">   var SampleData = [{       "Id": "210",       "Name": "Name 1",       "Category": "Permanent",       "Project": "HRMS",       "City": "Chennai",       "Department": "Testing",       "Designation": "SE",       "Salary": "16000"     }, {       "Id": "187",       "Name": "Name 2",       "Category": "Permanent",       "Project": "HRMS",       "City": "Chennai",       "Department": "Testing",       "Designation": "SE",       "Salary": "13000"     }, {       "Id": "186",       "Name": "Name 3",       "Category": "Permanent",       "Project": "HRMS",       "City": "Chennai",       "Department": "Testing",       "Designation": "SE",       "Salary": "12000"     }, {       "Id": "185",       "Name": "Name 4",       "Category": "Permanent",       "Project": "HRMS",       "City": "Bangalore",       "Department": "Development",       "Designation": "Lead",       "Salary": "18000"     }, {       "Id": "184",       "Name": "Name 5",       "Category": "Temporary",       "Project": "HRMS",       "City": "Mumbai",       "Department": "Testing",       "Designation": "SE",       "Salary": "12000"     }, {       "Id": "183",       "Name": "Name 6",       "Category": "Permanent",       "Project": "Banking",       "City": "Chennai",       "Department": "Development",       "Designation": "SSE",       "Salary": "14000"     }, {       "Id": "182",       "Name": "Name 7",       "Category": "Permanent",       "Project": "Banking",       "City": "Chennai",       "Department": "Testing",       "Designation": "SE",       "Salary": "12000"     }, {       "Id": "181",       "Name": "Name 8",       "Category": "Temporary",       "Project": "HRMS",       "City": "Bangalore",       "Department": "Development",       "Designation": "SSE",       "Salary": "15000"     }, {       "Id": "180",       "Name": "Name 9",       "Category": "Temporary",       "Project": "Banking",       "City": "Mumbai",       "Department": "Testing",       "Designation": "Lead",       "Salary": "17000"     }, {       "Id": "178",       "Name": "Name 10",       "Category": "Temporary",       "Project": "Banking",       "City": "Bangalore",       "Department": "Development",       "Designation": "SSE",       "Salary": "13000"     }];  </code></pre>
 
 <p>Add a DOM conatiner in Body part of page</p>
 <pre style="font-family:arial;font-size:12px;border:1px dashed #cccccc;width:99%;height:auto;overflow:auto;background:#f0f0f0;padding:0px;color:#000000;text-align:left;line-height:20px"><code style="color:#000000;word-wrap:normal"> &lt;div id="report"&gt;&lt;/div&gt;  </code></pre>
 
 <p>Now the real interesting part,
 add a script tag in Head tag and configure Arikai as shown</p>
 <pre style="font-family:arial;font-size:12px;border:1px dashed #cccccc;width:99%;height:auto;overflow:auto;background:#f0f0f0;padding:0px;color:#000000;text-align:left;line-height:20px"><code style="color:#000000;word-wrap:normal"> &lt;script type="text/javascript"&gt;        
 $(document).ready(function () {          
       var pv = new Arikai();  
       // initialize the pivot object        
       setTimeout(function () { 
       pv.LoadingProgress("report", true) }, 10);  
       //show loading progress        
       LoadModel(pv);        
 });  
 // all configuration values are case sensitive
 function LoadModel(pv) {              
       pv.ColulmnAreaFields = "Category";  
       // Column data field            
       pv.RowAreaFields = "Project";  
       // Row data field            
       pv.OptionFields = "City,Department,Designation";  
       //option fields for Edit layout.            
       pv.DataAreaField = "Sum(Salary)";  
       //Data area field            
       pv.DataDisplayType = DataType.Amount;  
       //Data type [Integer,Decimal,Amount]            
       pv.CustomDecimalPoint = DecimalPoint.None;  
       // Customise decimal point: [None,One,Two,Three,Four]            
       pv.ReportTitle = "Sales Report";  
       // Header for Report            
       pv.ReportData = SampleData;  
       // Json data            
       pv.ContainerElementId = "report";  
       // Container where pivot table will be appended            
       pv.Start();  
       // Create Report      
 }   &lt;/script&gt;  </code></pre>
 
 <p>Creates the object for Arikai pivot library.</p>
 <pre style="font-family:arial;font-size:12px;border:1px dashed rgb(204,204,204);width:927.6166381835938px;height:auto;overflow:auto;background-color:rgb(240,240,240);padding:0px;color:rgb(0,0,0);line-height:20px"><code style="color:rgb(0,0,0);word-wrap:normal">var pv = new Arikai();</code></pre>
 <p>is key method to generate Pivot report with given json data.</p>
 <pre style="font-family:arial;font-size:12px;border:1px dashed rgb(204,204,204);width:927.6166381835938px;height:auto;overflow:auto;background-color:rgb(240,240,240);padding:0px;color:rgb(0,0,0);line-height:20px"><code style="color:rgb(0,0,0);word-wrap:normal">pv.Start();</code></pre>
