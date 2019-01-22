using Microsoft.AspNet.Identity.EntityFramework;

namespace oneSolutionForum.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}


Example Link:
	MOST IMPORTANT ARTICLES RELATED VISUAL STUDIO 	
Sr.No	Address 	Description
1	https://www.aspsnippets.com/Articles/Using-TreeView-server-control-in-ASPNet-with-examples-in-C-and-VBNet.aspx	Tree view Example(DataBase Connection Master code(Method))
2	https://www.aspsnippets.com/Articles/Using-Cursor-in-SQL-Server-Stored-Procedure-with-example.aspx    http://sqltechi.blogspot.in/2012/11/sql-server-different-types-of-cursors.html	What is Cursor and how to use it?
	http://sqltechi.blogspot.in/2012/11/sql-server-different-types-of-cursors.html	What is Cursor and how to use it?
3	https://www.devarticles.com/c/a/SQL-Server/Using-Triggers-In-MS-SQL-Server/2/	What is Trigger and how to use it?
4	http://www.aspdotnet-suresh.com/2015/07/aspnet-gridview-crud-operations-insert-select-edit-update-delete-using-single-stored-procedure-example.html	CRUD opeartion using grid view with c# and VB code(Stored Procedure)
5	http://www.aspdotnet-suresh.com/2015/07/sqlserver-select-insert-update-delete-in--single-stored-procedure-query-with-example.html	CRUD opeartion using grid view with c# and VB code(Single Stored Procedure)
	http://www.dotnetlearners.com/blogs/view/20/aspnet-gridview-basic-example-for-insert-update-and-delete-the-records.aspx	Insert,Update,Delete Using GridView.(IMP)
	http://www.codescratcher.com/asp-net/insert-update-delete-data-database-using-stored-procedure/	Insert,Update,Delete with simple registration form with clear stored procedure.
6	https://www.aspsnippets.com/Articles/Simple-User-Registration-Form-Example-in-ASPNet.aspx	User Registration Form with Insert Srored Procedure.
7	https://www.aspsnippets.com/Articles/How-to-create-RDLC-report-step-by-step-in-ASPNet-using-C-and-VBNet.aspx	How to create RDLC report step by step in ASP.Net using C# and VB.Net
	http://www.mstecharticles.com/2013/04/c-building-rdlc-report-template-and.html	How to create RDLC report step by step in ASP.Net using C# and 
	http://tutorialhouse.weebly.com/reporting	How to create RDLC report step by step in ASP.Net using C# and 
8	http://www.c-sharpcorner.com/UploadFile/rohatash/binding-dropdownlist-with-database-and-display-data-in-gridv/	Binding DropDownList with Database in ASP.NET
9	http://www.aspdotnet-suresh.com/2015/04/change-gridview-row-color-based-on-data-in-aspnet-using-csharp-vbnet.html	GridView Row color change depending on data in row.
10	http://www.aspdotnet-suresh.com/2012/01/repeater-control-example-in-aspnet.html	Repeater Control.
11	http://www.aspdotnet-suresh.com/2017/03/create-installer-setup-file-for-aspnet-web-application.html	Create Installer (Setup) File for Asp.net Web Application.
12	http://www.aspdotnet-suresh.com/2011/12/search-records-in-gridview-and.html	Search Functionalites Using GridView.
	http://www.encodedna.com/gridview/tutorial/search-records-in-gridview-using-filterparameters.htm	Search Functionalites Using GridView(IMP).
13	http://www.dotnetfunda.com/articles/show/71/3-tier-architecture-in-aspnet-with-csharp	Demo of 3-Tier Architecture(UI - BAL - DAL).
	http://www.c-sharpcorner.com/UploadFile/4d9083/create-and-implement-3-tier-architecture-in-Asp-Net/	Demo of 3-Tier Architecture(UI - BAL - DAL).
	http://www.msdotnet.co.in/2014/07/how-to-implement-3-tier-architecture.html	Demo of 3-Tier Architecture(UI - BAL - DAL).(MOST IMP)
14	http://www.aspdotnet-suresh.com/2012/09/show-large-image-preview-when-hover-on.html	JQuery Show Large Image Preview When Hover On Link In Asp.Net.
15	http://www.aspdotnet-suresh.com/2016/07/pass-output-parameter-to-stored-procedure-in-sql-server.html	Pass Output Parameter to Stored Procedure in SQL Server.
16	http://www.dofactory.com	The Best SQL Tutorial.
17	http://www.msdotnet.co.in/2012/06/how-to-create-setup-fileexe-file-from.html	Create Setup File for Window Form Application.
18	http://www.msdotnet.co.in/2013/05/how-to-host-aspnet-application-on.html	Host Asp.Net site on Somee Domian Free.
19	https://www.codeproject.com/articles/401903/ajax-for-beginners-part-understanding-asp-net-aj	ASP.NET AJAX Control With Example.
20	http://www.c-sharpcorner.com/article/ajax-control-toolkit-tutorial-introduction-part-one/	ASP.NET AJAX Control With Example.
21	http://www.dotnetfox.com/articles/ajax-autocomplete-example-with-database-in-Asp-Net-1079.aspx	AJAX AutoComplete example with database in ASP.NET.
22	http://www.dotnetfox.com/articles/using-jquery-ajax-to-call-Asp-Net-page-method-1107.aspx	Using jQuery AJAX to call ASP.NET page method.
	http://www.dotnetfox.com/articles/using-jquery-ajax-to-call-Asp-Net-page-method-to-execute-store-procedure-1109.aspx	Using jQuery ajax to call ASP.NET page method to execute store procedure.
23	http://www.dotnetfox.com/articles/save-data-to-database-without-postback-using-jquery-ajax-in-Asp-Net-1108.aspx	Using jQuery ajax to call ASP.NET page method to execute store procedure.
24	http://www.dotnetfox.com/articles/bind-gridview-using-jquery-in-Asp-Net-1118.aspx	Bind GridView using jQuery in ASP.NET .
25	http://www.dotnetfox.com/articles/save-data-to-database-without-postback-using-jquery-ajax-in-Asp-Net-1108.aspx	Save data to database without postback using jQuery ajax in ASP.NET.
26	http://www.dotnetfox.com/articles/facebook-login-integration-in-Asp-Net-1058.aspx	Facebook login integration in ASP.NET Facebook login integration in ASP.NET.
27	http://www.dotnetfox.com/Category.aspx?catid=15	Export one file to another in ASP.NET.
28	http://www.c-sharpcorner.com/blogs/difference-between-get-and-post1	Example of GET and POST Method.
29	https://www.aspsnippets.com/Articles/Creating-Cascading-DropDownLists-in-ASP.Net.aspx	Creating Cascading DropDownLists in ASP.Net.(MOST IMP)
	https://www.aspsnippets.com/Articles/Creating-Cascading-DropDownLists-in-ASP.Net.aspx	Dropdown List (IMP).
30	http://wpftutorial.net/XAML2009.html	WPF Tutorial (Window Development).
31	http://www.aspdotnet-suresh.com/2012/05/aspnet-gridview-examples-and-samples-in.html	GridView Related All Example.
	https://www.codeproject.com/Articles/36528/GridView-all-in-one	Concept of GridView
	http://tutorial.techaltum.com/gridview-in-asp.net.html	
32	http://www.c-sharpcorner.com/blogs/star-rating-using-ajax	Rating Functionalities using Ajax in ASP.NET. 
33	http://www.c-sharpcorner.com/UploadFile/145c93/crud-operation-using-ajax-part-1/	CRUD Operations Using Ajax - Part 1
34	http://www.tutorialsteacher.com/webapi/test-web-api/	Web API Tutorial. 
35	http://www.aspdotnet-suresh.com/2016/06/jquery-show-all-autocomplete-list-options-on-focus-example.html	jQuery Show All AutoComplete List / Options on Focus Example.
36	http://programmer2programmer.net/live_projects/project_7/steganography.aspx	Image Stegnography in C# (Full Project).
37	https://www.aspsnippets.com/Articles/Send-email-using-Gmail-SMTP-Mail-Server-in-ASPNet.aspx	Send email using Gmail SMTP Mail Server in ASP.Net.
	http://www.c-sharpcorner.com/blogs/sending-email-in-asp-net-mvc	Send email using Gmail SMTP Mail Server in ASP.Net MVC.
38	http://www.c-sharpcorner.com/blogs/meaning-of-each-http-staus-code	HTTP Status Code.
39	http://www.c-sharpcorner.com/article/create-database-project-in-visual-studio-2015/	Create Table in SQL server without using (MS SQL SERVER MANAGEMENT STUDIO)
40	http://www.c-sharpcorner.com/article/modify-repair-and-uninstall-visual-studio-2017-using-visual-studio-installer/	Modifying,Repairing and Uninstall aftre Installation of Visual Studio.
41	http://www.c-sharpcorner.com/article/voice-login-system-using-microsoft-visual-studio/	Voice Login System Using Microsoft Visual Studio.
42	http://www.c-sharpcorner.com/article/github-with-visual-studio/	GItHub With Visual Studio.(MOST IMP)
43	http://www.c-sharpcorner.com/article/creating-a-team-project-with-git/	Creating A Team Project With Git.
44	http://www.c-sharpcorner.com/article/brief-about-team-foundation-server-tfs-2013/	Tutorial about Team Foundation Server.
	http://www.c-sharpcorner.com/article/authenticating-git-access-in-visual-studio-team-services/	Authenticating Git Access In Visual Studio.
	http://www.c-sharpcorner.com/article/creating-git-repository-under-vsts-project/	Creating Git Repository Under VSTS Project.
	http://www.c-sharpcorner.com/article/developing-with-visual-studio-team-services/	
45	http://www.c-sharpcorner.com/article/debugging-tools-in-visual-studio/	Debbuging Tool in Visual Studio.
46	http://www.aspneto.com/how-to-get-connection-string-connect-sql-database-in-asp-net.html	Get Coonection String.
47	http://www.msdotnet.co.in/2016/03/how-to-display-client-browser-languages.html	How to display Client browser languages in DropDownList using concepts of localization and Globalization
48	http://www.aspdotnet-suresh.com/2012/02/saveupload-files-in-folder-and-download.html	save/upload files in folder and download files from folder in asp.net.
49	http://www.c-sharpcorner.com/UploadFile/66489a/how-to-add-paypal-application-into-your-project/	PayPal Intigration with ASP.NET
	http://www.c-sharpcorner.com/article/user-registration-with-paypal/	User Registration with PayPal.
50	http://www.c-sharpcorner.com/article/tools-that-make-developers-life-easy/	Tools That Make Developer lives Easy.
51	http://www.c-sharpcorner.com/UploadFile/e0f9ff/integrate-selenium-with-visual-studio195/	Integrate Salanium with Visual Studio.
52	https://www.codeproject.com/Articles/1186349/Send-Email-from-a-Static-HTML	Send Email from a Static HTML Page.
53	http://asp.net-informations.com/gridview/checkbox.htm	Checkbox in ASP.NET GridbView Control.
54	http://www.encodedna.com/aspdotnet/extract-data-using-webapi-jquery-ajax-and-display-data-with-paging.htm	Fatch data using web API, jQuery, Ajax and display data with paging.
55	http://scheduler-net.com/docs/common-application-with-scheduler.html	Scheduler Demo in Asp.Net.
56	http://www.encodedna.com/jquery/check-if-checkbox-is-checked-or-not-using-jquery.htm	Ckeck if checkbox is checked or not using jQuery.
57	http://www.encodedna.com/jquery/refresh-div-contents-without-reloading-the-page-using-jquery.htm	Refresh DIV content without reloading the page using jQuery.
58	http://www.c-sharpcorner.com/article/first-know-about-the-dependency-before-di/	What is Dependancy and Dependancy Injection in ASP.NET?
59	http://www.c-sharpcorner.com/article/monitoring-our-database-when-access-from-out-side-or-application-in-sql-server/	How to Monitor our Database?
60	http://www.c-sharpcorner.com/article/get-database-backup-and-restore-the-backup-file-in-sql-server/	Get Database backup and restore the backup file in sql server.
	http://www.c-sharpcorner.com/article/automatic-daily-database-backup-to-specific-database-in-sql-server/	Automatic daily database backup to specific database in sql server.
61	http://www.c-sharpcorner.com/UploadFile/4b0136/performing-insert-update-delete-in-xml-in-Asp-Net/	Insert,Update,Delete operation using XML file.
	http://www.c-sharpcorner.com/UploadFile/c25b6d/working-with-xml-file-using-Asp-Net/	Insert and Show XML data using asp.net.
62	http://www.inopinion.org/development/create-blog-in-asp-net-web-forms-1/	Create Blog in asp.net.
63	https://www.javatpoint.com/jquery-selectors	All jQuery Selector.
64	http://www.c-sharpcorner.com/blogs/different-like-operators-in-stored-procedures-in-sql-server1	Different like operator in stored procedure in sql server
65	http://www.c-sharpcorner.com/blogs/login-page-using-stored-procedure1	Login Page using Stored Procedure with Sql Parameter Class. 
66	http://www.c-sharpcorner.com/article/how-to-use-jquery-ui-for-checkbox-list-and-radio-button-list-in-asp-net/	Use jQuery UI for checkbox and radio button list in asp.net.
67	http://www.c-sharpcorner.com/UploadFile/33b051/checkbox-and-radio-button-inside-dropdownlist/	Apply checkbox and radiobutton in dropdownlist.
68	http://www.c-sharpcorner.com/article/how-to-select-all-checkbox-when-header-checkbox-is-selected/	How to select all checkbox when header checkbox is selcted.
69	http://www.c-sharpcorner.com/UploadFile/shweta1985/tip-how-to-highlight-rows-in-a-datagrid-using-a-checkbox/	How to highlights rows in a datagrid using a checkbox.
70	http://www.c-sharpcorner.com/uploadfile/jayendra/gridview-paging-and-multiple-row-delete-using-checkbox/	Gridview paging and multiple row delete using checkbox.
71	http://burnignorance.com/asp-net-developer-tips/how-to-change-an-image-periodically-with-timer-control-using-updatepanel-in-asp-net/	How to change an image periodically with timer control using updatepanel in asp.net?
72	http://burnignorance.com/asp-net-developer-tips/add-an-editor-to-your-application/	Add an editor to application.
73	http://burnignorance.com/asp-net-developer-tips/	ASP.NET developer TIPS.
74	https://www.codeproject.com/Members/Shivprasad-koirala	Shivprasad Koirala IMP Tutorial on youtube.
75	https://www.aspsnippets.com/Articles/Insert-multiple-values-from-CheckBoxList-to-Database-in-ASPNet.aspx	Insert multiple values from CHECKBOXLIST to Database in asp.net.
	https://www.aspsnippets.com/Articles/Save-Insert-CheckBox-value-to-Database-in-ASPNet-using-C-and-VBNet.aspx	Insert Single value from checkbox to database.
76	https://www.aspsnippets.com/Articles/Populate-TextBox-based-on-DropDownList-Selection-in-ASPNet-using-C-and-VBNet.aspx	Populate textbox  based on dropdownlist selction in asp.net.
77	https://www.aspsnippets.com/Articles/Alphabet-Paging-using-Alphabetical-Pager-in-ASPNet-GridView.aspx	Alphabet paging using alphabetical pager in asp.net gridview.
78	https://www.aspsnippets.com/Articles/Building-a-Custom-Paging-Control-for-GridView-using-DropDownList-Control-in-ASPNet.aspx	Custome paging control for gridview using drpdownlist control in asp.net.
79	https://www.aspsnippets.com/Articles/Display-Show-GridView-inside-jQuery-Dialog-Modal-Popup-Window-in-ASPNet-using-C-and-VBNet.aspx	Gridview shows in jquery Popup model.
80	https://www.aspsnippets.com/Articles/Disable-Mouse-Right-Click-in-ASPNet-ASPX-Page-using-JavaScript-and-jQuery.aspx	Disabled mouse right click using javascript and jquery.
81	https://stackoverflow.com/questions/21533285/why-the-ajax-script-is-not-running-on-iis-7-5-win-2008-r2-server/21617685#21617685	Debug jQuery ajax call back result.
	http://www.c-sharpcorner.com/article/debugging-with-chrome-in-visual-studio-2017/	
82	Microsoft BOT Framework.	
83	gdPicture.Net	.Net SDK for Image Processing using C#.Net and VB.Net.
84	https://www.guru99.com/	Tutorial on different technologies.
85	https://www.codeproject.com/Tips/767067/RDLC-Report-Grouping-with-Page-Break-Table-Header	Advance RDLC Report.
86	https://www.codeproject.com/Reference/788434/List-of-rd-Party-NET-UI-Reporting-Components	List of 3rd party .NET UI & Reporting Components. 
87	http://www.c-sharpcorner.com/UploadFile/b926a6/Asp-Net-role-based-login-form-using-sql-procedure/	ASP.NET role based login form using sql procedure.
89	http://tutorial.techaltum.com/jquery-selectors.html	Jquery tutorial
90	http://javascriptbook.com/code/c07/	Best Tutorial for all Technology.
91	http://www.msi-to-exe.com/	MSI to EXE Tutorial
92	http://www.aspdotnet-suresh.com/2010/09/publish-or-deploy-website-in-our-local.html	Publish or Deploy Web site in our local machine.
93	http://www.aspdotnet-suresh.com/2011/05/aspnet-web-service-or-creating-and.html	web services.
	https://www.aspsnippets.com/Articles/Simple-database-Web-Service-Tutorial-in-ASPNet-with-Example.aspx	
	http://www.c-sharpcorner.com/UploadFile/18fc30/consuming-a-live-weather-forecast-web-service-in-Asp-Net-web/	Wather Forcasting Web service.
94	https://www.dotnetperls.com/property-vbnet	Get and Set Property()
95	http://devcenter.infragistics.com/Support/KnowledgeBaseArticle.aspx?ArticleID=5167	Toolbar Button Demo(Infragistics).
96	http://vxgrid.azurewebsites.net/	Infragistics Grid Example.
97	http://www.c-sharpcorner.com/article/create-mvc-project-step-by-step-from-scratch-part-one/	PayPal Intigration with ASP.NET
98	http://www.c-sharpcorner.com/UploadFile/66489a/shopping-cart-in-mvc-with-jquery/	Shopping Cart with jQuery.
99	http://www.c-sharpcorner.com/article/create-mvc-project-step-by-step-from-scratch-part-one/	Shopping Cart with Single Product.
	http://www.c-sharpcorner.com/article/creating-shopping-cart-application-from-scratch-in-mvc-part2/	
100	http://www.databaseanswers.org/data_models/e_commerce/index.htm	Data Base Related Quaries.
101	https://www.codeproject.com/Articles/1105184/ASP-NET-MVC-Building-Your-First-Web-Application-Pa	
102	https://www.mssqltips.com/sqlservertip/1600/auto-generated-sql-server-keys-with-the-uniqueidentifier-or-identity/	Random Unique id generated
103	https://www.mssqltips.com/sqlservertip/4828/verify-connectivity-to-sql-server/	SQL Tips
104	http://www.vertabelo.com/blog/technical-articles/database-model-for-an-online-discussion-forum-part-1	Discusion Forum
105	http://www.vertabelo.com/blog/technical-articles/database-model-for-an-online-store	Data Model for Online store
106	https://www.redweb.com/agency/blog/my-top-tools-for-productive-net-web-development	Development Tools
107	http://dorababu-meka.blogspot.in/search?q=forum	Complate Forum Application
108	http://www.aspdotnet-suresh.com/2015/11/bootstrap-autocomplete-textbox-example-in-aspnet-using-csharp-vbnet.html	Auto Complate DropDownlist
109	http://www.c-sharpcorner.com/UploadFile/302f8f/Asp-Net-mvc-5-with-angularjs-part-1/	ASP.NET MVC with Angular js
110	https://modernweb.com/8-bootstrap-alternatives/	Alternate of Boostrap
	https://exploringdata.github.io/vis/visualisingdata-census-twitter-network/	Exporing Data
	http://websystique.com/angularjs/angularjs-form-validation-example/	Angular Js Example
	http://www.dotnetcurry.com/angularjs/1062/website-using-angularjs-aspnet-webapi	
	http://cybarlab.com/crud-operations-in-angularjs-and-web-api	
	http://www.c-sharpcorner.com/UploadFile/65794e/web-api-with-angular-js/	
	http://www.dotnetfox.com/articles/crud-operation-in-Asp-Net-mvc-using-web-api-and-angularjs-1125.aspx	
	https://www.codeproject.com/Articles/1181888/Angular-in-ASP-NET-MVC-Web-API-Part	
111	http://www.c-sharpcorner.com/UploadFile/1e050f/display-number-of-online-users-in-Asp-Net/	Online User
112	https://www.codeproject.com/Articles/732190/Real-Time-Web-Solution-for-Chat-by-MVC-SignalR-H	Chat Using Single R
	http://www.c-sharpcorner.com/article/signalr-message-conversation-using-asp-net-mvc-in-real-time-scenario/	
	https://code.msdn.microsoft.com/Signalr-angular-chat-95dc8f06	Live chat app with angular and MVC
	http://swlabs.co/html/?theme=madmin-html	
113	https://www.codeproject.com/Articles/1095480/Team-Foundation-Server-TFS	TFS Setup and configuration
114	http://vb.net-informations.com/datagridview/vb.net_datagridview_sort.htm	Articles on VB .NET
115	http://www.c-sharpcorner.com/UploadFile/a8024d/real-life-example-of-Asp-Net-mvc-5/	Folder Structure
116	http://www.dotnetcurry.com/aspnet/709/aspnet-web-control-clientid	Client Id
117	http://www.beansoftware.com/ASP.NET-Tutorials/Themes-Skins.aspx	Theme and skins
118	http://www.c-sharpcorner.com/article/login-functionality-with-angularjs-and-mvc/	Login Page using asp.net mvc with angular.js.
119	http://www.c-sharpcorner.com/UploadFile/093731/nodejs-for-net-developer451/	Node.js with Asp.Net MVC
120	https://www.sitepoint.com/build-real-time-signalr-dashboard-angularjs/	Real time flow data in dashboard using asp.net mvc with angular js.
121	http://anandmanisankar.com/posts/angularjs-dependency-injection-demystified/	Dependancy Injection in Angular Js
122	http://www.dotnetawesome.com/p/angularjs.html	Complete Tutorial on  Angular Js (by Sourav Mondal)
123	https://www.aspsnippets.com/Articles/Reorder-GridView-Rows-Drag-and-Drop-ordering-of-GridView-Rows-using-jQuery-in-ASPNet.aspx	Reset order of row in grid view. 
	http://www.c-sharpcorner.com/article/crud-operation-using-repository-unit-of-work-pattern/	
124	http://panictheorem.net/Blog/Repository-And-Unit-Of-Work	Best of Repository pattern and Unit of work.
	http://www.webdevelopmenthelp.net/2016/11/asp-net-mvc-shopping-cart-part2.html	
126	http://www.c-sharpcorner.com/article/deploying-a-web-application-to-aws/	Full Description on AWS web deployment 
	http://www.c-sharpcorner.com/article/assign-domain-to-application-uploaded-on-amazon-web-services/	
127	https://martinbuberl.com/blog/deploy-aspnet-mvc-on-amazon-ec2-with-web-deploy/	
128	http://pietschsoft.com/post/2009/03/ASPNET-MVC-Implement-Theme-Folders-using-a-Custom-ViewEngine	Theme and skins in asp.net mvc
129	http://www.ittutorialswithexample.com/2015/01/create-simple-comment-box-in-aspnet.html	Comment system in asp.net
130	http://codewithgeek.blogspot.in/2015/12/upload-video-to-youtube-from-c-aspnet.html	Upload video on youtube(ASP.NET MVC)
	http://docs.hangfire.io/en/latest/tutorials/send-email.html	Get notification in mail whenever new post written in blog

SQL Best Practices :
			Desc
1	Do mass updates in batches	WHILE ( 0 = 0 )	Try to update record in batch for good performance
		    BEGIN	
		        UPDATE TOP ( 10000 )	
		                Person	
		        SET     Status = 2	
		        WHERE   Status = 1	
		        IF @@ROWCOUNT = 0	
		            BREAK	
		    END	
			
			
2	FOR-EACH stored procedures		
2.1	sp_msForEachTable 	"EXEC sp_msforeachdb 'IF ''?'' <> ''tempdb'' BACKUP DATABASE ?
TO DISK=''c:\backups\?.bak'' WITH INIT'"	Backup all table except temp table using single query.
2.2	sp_msForEachDB	"EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
EXEC  sp_MSForEachTable '  IF OBJECTPROPERTY(object_id(''?''), ''TableHasForeignRef'') = 1  DELETE FROM ?  Else   TRUNCATE TABLE ?
"	Delete all data from all table after disableing foreign key.
		EXEC  sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'	
3	SQL Profiler	https://www.mssqltips.com/sqlservertutorial/3510/sql-server-profiler-examples/	Basic use of sql profiler
			
4	SQL Explor	"https://www.red-gate.com/simple-talk/sql/database-administration/exploring-your-sql-server-databases-with-t-sql/
http://www.sqlservice.se/exploring-sql-server-management-studio-data-classification-feature/"	
4.1	Basic Server Information	Select @@SERVERNAME as [Server\Instance]; 	
		Select @@VERSION as SQLServerVersion; 	
		Select @@ServiceName AS ServiceInstance;	
		Select DB_NAME() AS CurrentDB_Name;	
4.2	"How long has your server been
 running since the last SQL Server  startup"	"SELECT  @@Servername AS ServerName ,create_date AS ServerStarted ,DATEDIFF(s, create_date, GETDATE()) / 86400.0 AS DaysRunning ,DATEDIFF(s, create_date, GETDATE()) AS SecondsRunnigFROM    sys.databases
 WHERE   name = 'tempdb'; "	
5	List of Database	" SELECT  @@SERVERNAME AS Server ,
         d.name AS DBName ,
         create_date ,
         compatibility_level ,
         m.physical_name AS FileName
 FROM    sys.databases d
         JOIN sys.master_files m ON d.database_id = m.database_id
 WHERE   m.[type] = 0 
 ORDER BY d.name; 
 GO"	
6	Last Database Backup		
7	Last modify database object	"SELECT * 
FROM sys.objects
WHERE type = 'P'
ORDER BY modify_date desc"	
8	Modify size of TempDb Database	"use master
go
---
alter database tempdb modify file
(name = tempdev,
size = 8192MB,
maxsize = 10241MB,
filegrowth = 2048MB)
go
alter database tempdb modify file
(name = templog,
size = 512MB,
maxsize = 1025MB,
filegrowth = 256MB)
go
checkpoint
go"	
9	Database File Location	" EXEC sp_Helpfile; 
 --OR 
 SELECT  @@Servername AS Server ,
         DB_NAME() AS DB_Name ,
         File_id ,
         Type_desc ,
         Name ,
         LEFT(Physical_Name, 1) AS Drive ,
         Physical_Name ,
         RIGHT(physical_name, 3) AS Ext ,
         Size ,
         Growth
 FROM    sys.database_files
 ORDER BY File_id; 
 GO"	
10	Table Information	" SELECT  @@Servername AS ServerName ,
         DB_NAME() AS DBName ,
         t.Name AS TableName,
         t.[Type],
         t.create_date
 FROM    sys.tables t
 ORDER BY t.Name;
 GO
OR
 SELECT  @@Servername AS ServerName ,
         TABLE_CATALOG ,
         TABLE_SCHEMA ,
         TABLE_NAME
 FROM    INFORMATION_SCHEMA.TABLES
 WHERE   TABLE_TYPE = 'BASE TABLE'
 ORDER BY TABLE_NAME ;"	
11	Column from Across all Table	"SELECT t.name AS table_name,
SCHEMA_NAME(schema_id) AS schema_name,
c.name AS column_name
FROM sys.tables AS t
INNER JOIN sys.columns c ON t.OBJECT_ID = c.OBJECT_ID
WHERE c.name LIKE '%Presc%'
ORDER BY schema_name, table_name desc;"	
12	Reporting Service	"select * from ExecutionLog order by TimeStart desc
 select Name,* from Catalog where ItemID= '1BFC9DDC-FF5B-4227-9816-F340E1973C13'"	
	XML Report	"select c.name,c.path,CONVERT(xml,CONVERT(varbinary(max),c.content)) as reportXML,c.content from Catalog c
 where ItemID = '371C629B-1214-4E30-8FB7-D5C0561213F7'"	
13	"Drop  Temp Table Before Insert
 Record "	"IF OBJECT_ID('tempdb..#TempTable') IS NOT NULL               
 DROP TABLE #TempTable;"	
14	Drop Procedure IF Already Exists.	"IF(select 1 from sys.objects where object_Id=OBJECT_ID('Procedure Name') and type('P','PC'))
DROP PROCEDURE Procedure Name"	
15	Drop Function IF Already Exists.	select * from sys.objects where type in (N'FN', N'IF', N'TF', N'FS', N'FT' )	
16	Drop Trigger IF Already Exists.	IF  EXISTS (SELECT 1 FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[Trigger_Name]'))	
17	Find SP which has Cursor	select * from sys.sql_modules where definition like '%CURSOR FOR %'	


