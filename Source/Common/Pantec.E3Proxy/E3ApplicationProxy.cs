using Pantec.E3Proxy.Abstract;

namespace Pantec.E3Proxy
{
    /// <summary>
    /// Proxy class for Zuken E3 2022.23.10.248145
    /// </summary> 	
    public sealed class E3ApplicationProxy : E3ProxyBase
    {
        public E3ApplicationProxy(object comObject) : base(comObject)
        {
        }

        public int ActivateOutputWindow(int windowId)
        {
            return ComObject.ActivateOutputWindow(windowId);
        }

        public int AvoidAutomaticClosing(int avoid = 1)
        {
            return ComObject.AvoidAutomaticClosing(avoid);
        }

        public int BeginForeignTask()
        {
            return ComObject.BeginForeignTask();
        }

        public int BringToForeground()
        {
            return ComObject.BringToForeground();
        }

        public double CalculateCircumcircleDiameter(ref object dias)
        {
            return ComObject.CalculateCircumcircleDiameter(dias);
        }

        public void ClearOutputWindow()
        {
            ComObject.ClearOutputWindow();
        }

        public void ClearResultWindow()
        {
            ComObject.ClearResultWindow();
        }

        public int CloneWithProject(ref object ppid, string com = "", string data = "")
        {
            return ComObject.CloneWithProject(ref ppid, com, data);
        }

        public object CreateDllObject()
        {
            return ComObject.CreateDllObject();
        }

        public object CreateJobObject()
        {
            return ComObject.CreateJobObject();
        }

        public object CreateMenuItemObject()
        {
            return ComObject.CreateMenuItemObject();
        }

        public object CreateWespeObject()
        {
            return ComObject.CreateWespeObject();
        }

        public int DeleteWorkspaceConfiguration(string name = "")
        {
            return ComObject.DeleteWorkspaceConfiguration(name);
        }

        public int Display()
        {
            return ComObject.Display();
        }

        public int EnableCOM(string password)
        {
            return ComObject.EnableCOM(password);
        }

        public int EnableLogfile(int en)
        {
            return ComObject.EnableLogfile(en);
        }

        public int EndForeignTask()
        {
            return ComObject.EndForeignTask();
        }

        public int FreeLicense(string feature)
        {
            return ComObject.FreeLicense(feature);
        }

        public int FreeLicensePermanent(string feature)
        {
            return ComObject.FreezeLicensePermanent(feature);
        }

        public string fullname()
        {
            return ComObject.fullname();
        }

        public string GetActualDatabase()
        {
            return ComObject.GetActualDatabase();
        }

        public int GetAvailableLanguages(ref object languages)
        {
            return ComObject.AvailableLanguages(ref languages);
        }

        public string GetBuild()
        {
            return ComObject.GetBuild();
        }

        public object GetCloningInformation(string what)
        {
            return ComObject.GetObject(what);
        }

        public string GetComponentDatabase()
        {
            return ComObject.GetComponentDatabase();
        }

        public string GetComponentDatabaseTableSchema()
        {
            return ComObject.ComponentDatabaseTableSchema();
        }

        public string GetComponentDataView()
        {
            return ComObject.GetComponentDataView();
        }

        public string GetConfigurationDatabase()
        {
            return ComObject.GetConfigurationDatabase();
        }

        public string GetConfigurationDatabaseTableSchema()
        {
            return ComObject.GetConfigurationDatabaseTableSchema();
        }

        public string GetCurrentWorkspaceConfiguration()
        {
            return ComObject.GetCurrentWorkspaceConfiguration();
        }

        public int GetDatabaseTableSelectedComponents(ref object ComponentArray, ref object VersionArray)
        {
            return ComObject.GetDatabaseTableSelectedComponents(ref ComponentArray, ref VersionArray);
        }

        public int GetDatabaseTreeSelectedComponents(out object ComponentArray, out object VersionArray)
        {
            return ComObject.GetDatabaseTreeSelectedComponents(out ComponentArray, out VersionArray);
        }

        public int GetDatabaseTreeSelectedModels(out object ModelArray)
        {
            return ComObject.GetDatabaseTreeSelectedModels(out ModelArray);
        }

        public int GetDatabaseTreeSelectedSymbols(out object SymbolArray, out object VersionArray)
        {
            return ComObject.GetDatabaseTreeSelectedSymbols(out SymbolArray, out VersionArray);
        }

        public int GetDefinedDatabaseConnectionStrings(string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs)
        {
            return ComObject.GetDefinedDatabaseConnectionStrings(dbname, out cmp_cs, out sym_cs, out cnf_cs);
        }

        public int GetDefinedDatabases(out object dbnames)
        {
            return ComObject.GetDefinedDatabase(out dbnames);
        }

        public int GetEnableInteractiveDialogs()
        {
            return ComObject.GetEnableInteractiveDialogs();
        }

        public int GetErrorCount()
        {
            return ComObject.GetErrorCount();
        }

        public string GetFullName()
        {
            return ComObject.GetFullName();
        }

        public int GetId()
        {
            return ComObject.GetId();
        }

        public int GetInfoCount()
        {
            return ComObject.GetInfoCount();
        }

        public int GetInstallationLanguage()
        {
            return ComObject.GetVersionLanguage();
        }

        public string GetInstallationPath()
        {
            return ComObject.GetInstallationPath();
        }

        public int GetJobCount()
        {
            return ComObject.GetJobCount();
        }

        public int GetJobIds(ref object ids)
        {
            return ComObject.GetJobIds(ref ids);
        }

        public string GetLanguageDatabase()
        {
            return ComObject.GetLanguageDatabase();
        }

        public string GetLanguageDatabaseTableSchema()
        {
            return ComObject.GetLanguageDatabaseTableSchema();
        }


        public int GetLicense(string feature)
        {
            return ComObject.GetLicense(feature);
        }

        public int GetLicensePermanent(string feature)
        {
            return ComObject.SetLicensePermanent(feature);
        }

        public string GetLogfileName(int index = 0)
        {
            return ComObject.LogfileName(index);
        }

        public object GetModalWindow()
        {
            return ComObject.ModalWindow();
        }

        public int GetMultiuserFolderPath(out object path)
        {
            return ComObject.MultiuserFolderPath(out path);
        }

        public int GetMultiuserProjects(ref object name)
        {
            return ComObject.GetMultiuserProjects(name);
        }

        public string GetMultiuserServer()
        {
            return ComObject.GetMultiuserServer();
        }

        public string GetName()
        {
            return ComObject.GetName();
        }

        public object GetPluginObject(ref object Plugin)
        {
            return ComObject.PluginObject(ref Plugin);
        }

        public int GetPrintCropMarks()
        {
            return ComObject.GetPrintCropMarks();
        }

        public int GetPrinterColour()
        {
            return ComObject.GetPrinterColour();
        }

        public double GetPrinterLinewidth()
        {
            return ComObject.GetPrinterLinewidth();
        }

        public int GetPrinterMargins(ref object top, ref object bottom, ref object left, ref object right)
        {
            return ComObject.GetPrinterMargins(ref top, ref bottom, ref left, ref right);
        }

        public string GetPrinterName()
        {
            return ComObject.GetPrinterName();
        }

        public int GetPrintPageNumbers()
        {
            return ComObject.GetPrintPageNumbers();
        }

        public int GetPrintSheetOrder()
        {
            return ComObject.GetPrintSheetOrder();
        }

        public int GetPrintSplitPages()
        {
            return ComObject.GetPrintSplitPages();
        }

        public object GetProcessProperty(string what)
        {
            return ComObject.GetProcessProperty(what);
        }

        public int GetProjectInformation(ref object filename, ref object type, ref object is_dbe)
        {
            return ComObject.GetProjectInformation(ref filename, ref type, ref is_dbe);
        }

        public string GetProjectLifecycle(string project)
        {
            return ComObject.GetProjectLifecycle(project);
        }

        public string GetProvider(string dbname)
        {
            return ComObject.GetProvider(dbname);
        }

        public string GetRegistryVersion()
        {
            return ComObject.GetRegistryVerion();
        }

        public object GetScriptArguments()
        {
            return ComObject.GetScriptArguments();
        }

        public int GetScriptReturn()
        {
            return ComObject.GetScriptReturn();
        }

        public string GetServerName()
        {
            return ComObject.GetServerName();
        }

        public int GetServerPort()
        {
            return ComObject.GetServerPort();
        }

        public string GetSymbolDatabase()
        {
            return ComObject.GetSymbolDatabase();
        }

        public string GetSymbolDatabaseTableSchema()
        {
            return ComObject.GetSymbolDatabaseTableSchema();
        }

        public string GetSymbolDataView()
        {
            return ComObject.GetSymbolDataView();
        }

        public int GetSystemMenuItemIds(ref object ids)
        {
            return ComObject.GetSystemMenuItemIds(ref ids);
        }

        public string GetTemplateFile()
        {
            return ComObject.GetTemplateFile();
        }


        public string GetTemplateFileDBE()
        {
            return ComObject.GetTemplateFileDBE();
        }


        public int GetTestMark(int num)
        {
            return ComObject.GetTestMark(num);
        }


        public string GetTranslatedText(string text, string language)
        {
            return ComObject.GetTranslatedText(text, language);
        }

        public int GetTrigger(string name, ref object filename)
        {
            return ComObject.GetTrigger(name, ref filename);
        }

        public int GetTriggerReturn()
        {
            return ComObject.GetTriggerReturn();
        }

        public int GetUserMenuItemIds(ref object ids)
        {
            return ComObject.GetUserMenuItemIds(ref ids);
        }

        public int GetUseSheetOrientation()
        {
            return ComObject.GetUseSheetOrientation();
        }

        public int GetVerifyCount()
        {
            return ComObject.GetVerifyCount();
        }

        public string GetVersion()
        {
            return ComObject.GetVersion();
        }

        public int GetWarningCount()
        {
            return ComObject.GetErrorCount();
        }

        public int GetWorkspaceConfigurations(ref object names, string path = "")
        {
            return ComObject.GetWorkspaceConfigurations(ref names, path);
        }

        public string GetWorkspaceName()
        {
            return ComObject.GetWorkspaceName();
        }

        public int Include(string text)
        {
            return ComObject.Include(text);
        }

        public int IsBasic()
        {
            return ComObject.IsBasic();
        }

        public int IsBoard()
        {
            return ComObject.IsBoard();
        }

        public int IsCable()
        {
            return ComObject.IsCable();
        }

        public int IsCaddy()
        {
            return ComObject.IsCaddy();
        }

        public int IsCaddyBasic()
        {
            return ComObject.IsCaddyBasic();
        }

        public int IsCaddyDemo()
        {
            return ComObject.IsCaddyDemo();
        }

        public int IsCaddyEconomy()
        {
            return ComObject.IsCaddyEconomy();
        }

        public int IsDemo()
        {
            return ComObject.IsDemo();
        }

        public int IsDistDesign()
        {
            return ComObject.IsDistDesign();
        }

        public int IsEconomy()
        {
            return ComObject.IsEconomy();
        }

        public int IsFluid()
        {
            return ComObject.IsFluid();
        }

        public int IsFormboard()
        {
            return ComObject.IsFormboard();
        }

        public int IsFunctionalDesign()
        {
            return ComObject.IsFunctionalDesign();
        }

        public int IsLogic()
        {
            return ComObject.IsLogic();
        }

        public int IsMultiuser()
        {
            return ComObject.IsMultiuser();
        }

        public int IsPanel()
        {
            return ComObject.IsPanel();
        }

        public int IsRedliner()
        {
            return ComObject.IsRedliner();
        }

        public int IsSchema()
        {
            return ComObject.IsSchema();
        }

        public int IsScriptRunning()
        {
            return ComObject.IsScriptRunning();
        }


        public int IsSmallBusiness()
        {
            return ComObject.IsSmallBusiness();
        }

        public int IsStudent()
        {
            return ComObject.IsStudent();
        }

        public int IsViewer()
        {
            return ComObject.IsViewer();
        }

        public int IsViewPlus()
        {
            return ComObject.IsViewPlus();
        }

        public int IsWago()
        {
            return ComObject.IsWago();
        }

        public int IsWagoDemo()
        {
            return ComObject.IsWagoDemo();
        }

        public int IsWire()
        {
            return ComObject.IsWire();
        }

        public int IsWireWorks()
        {
            return ComObject.IsWireWorks();
        }

        public int LoadWorkspaceConfigurationFromFile(string name, string path)
        {
            return ComObject.LoadWorkspaceConfigurationFromFile(name, path);
        }

        public int Maximize()
        {
            return ComObject.Maximize();
        }

        public int Minimize()
        {
            return ComObject.Minimize();
        }

        public int PutError(int ok, string text, int item = 0)
        {
            return ComObject.PutError(ok, text, item);
        }

        public int PutErrorEx(int flags, string text, int item, int red, int green, int blue)
        {
            return ComObject.PutErrorEx(flags, text, item, red, green, blue);
        }

        public int PutInfo(int ok, string text, int item = 0)
        {
            return ComObject.PutInfo(ok, text, item);
        }

        public int PutInfoEx(int flags, string text, int item, int red, int green, int blue)
        {
            return ComObject.PutInfoEx(flags, text, item, red, green, blue);
        }

        public int PutMessage(string text, int item = 0)
        {
            return ComObject.PutMessage(text, item);
        }

        public int PutMessageEx(int flags, string text, int item, int red, int green, int blue)
        {
            return ComObject.PutMessageEx(flags, text, item, red, green, blue);
        }

        public int PutMultiuserLogMessage(string source, string text)
        {
            return ComObject.PutMultiuserLogMessage(source, text);
        }

        public int PutVerify(int ok, string text, int item = 0)
        {
            return ComObject.PutVerify(ok, text, item);
        }

        public int PutVerifyEx(int flags, string text, int item, int red, int green, int blue)
        {
            return ComObject.PutVerifyEx(flags, text, item, red, green, blue);
        }


        public int PutWarning(int ok, string text, int item = 0)
        {
            return ComObject.PutWarning(ok, text, item);
        }

        public int PutWarningEx(int flags, string text, int item, int red, int green, int blue)
        {
            return ComObject.PutWarningEx(flags, text, item, red, green, blue);
        }

        public int Quit()
        {
            return ComObject.Quit();
        }

        public int ResetErrorCount()
        {
            return ComObject.ResetErrorCount();
        }

        public int ResetInfoCount()
        {
            return ComObject.ResetInfoCount();
        }

        public int ResetVerifyCount()
        {
            return ComObject.ResetVerifyCount();
        }

        public int ResetWarningCount()
        {
            return ComObject.ResetWarningCount();
        }

        public int RestoreWorkspaceConfiguration(string name = "")
        {
            return ComObject.RestoreWorkspaceConfiguration(name);
        }

        public int Run(string filename, ref object arguments)
        {
            return ComObject.Run(filename, ref arguments);
        }

        public int SaveWorkspaceConfiguration(string name = "")
        {
            return ComObject.SaveWorkspaceConfiguration(name);
        }

        public object ScriptArguments()
        {
            return ComObject.ScriptArguments();
        }

        public string ScriptFullName()
        {
            return ComObject.ScriptFullName();
        }

        public string ScriptName()
        {
            return ComObject.ScriptName();
        }

        public int SelectComponentFromTable(ref object ComponentName, ref object ComponentVersion)
        {
            return ComObject.SelectComponentFromTable(ref ComponentName, ref ComponentVersion);
        }

        public int SetActualDatabase(string dbname)
        {
            return ComObject.SetActualDatabase(dbname);
        }

        public int SetChildWindowState(int state)
        {
            return ComObject.SetChildWindowState(state);
        }

        public int SetComponentDataView(string name)
        {
            return ComObject.SetComponentDataView(name);
        }

        public int SetDefinedDatabaseConnectionStrings(string dbname, string cmp_cs, string sym_cs, string cnf_cs)
        {
            return ComObject.SetDefinedDatabaseConnectionStrings(dbname, cmp_cs, sym_cs, cnf_cs);
        }

        public int SetEnableInteractiveDialogs(int value)
        {
            return ComObject.SetEnableInteractiveDialogs(value);
        }

        public int SetLanguageDatabase(string dbname)
        {
            return ComObject.SetLanguageDatabase(dbname);
        }

        public int SetLogfileName(string logfile, int index = 0)
        {
            return ComObject.SetLogfileName(logfile, index);
        }

        public int SetModalWindow(ref object hWnd)
        {
            return ComObject.SetModalWindow(ref hWnd);
        }

        public int SetMultiuserServer(string server)
        {
            return ComObject.SetMultiuserServer(server);
        }

        public int SetPrintCropMarks(int set)
        {
            return ComObject.SetPrintCropMarks(set);
        }

        public int SetPrinterCollate(int col)
        {
            return ComObject.SetPrinterCollate(col);
        }

        public int SetPrinterColour(int colour)
        {
            return ComObject.SetPrinterColour(colour);
        }

        public int SetPrinterCopies(int copies)
        {
            return ComObject.SetPrinterCopies(copies);
        }

        public double SetPrinterLinewidth(double linewidth)
        {
            return ComObject.SetPrinterLinewidth(linewidth);
        }

        public int SetPrinterMargins(double top, double bottom, double left, double right)
        {
            return ComObject.SetPrinterMargins(top, bottom, left, right);
        }

        public int SetPrinterName(string name)
        {
            return ComObject.SetPrinterName(name);
        }

        public int SetPrintPageNumbers(int set)
        {
            return ComObject.SetPrintPageNumbers(set);
        }

        public int SetPrintSheetOrder(int set)
        {
            return ComObject.SetPrintSheetOrder(set);
        }

        public int SetPrintSplitPages(int set)
        {
            return ComObject.SetPrintSplitPages(set);
        }

        public int SetProjectLifecycle(string project, string lifecycle)
        {
            return ComObject.SetProjectLifecycle(project, lifecycle);
        }
    }
}