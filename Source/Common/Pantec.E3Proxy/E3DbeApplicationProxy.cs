using E3Series.Proxy.Abstract;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Pantec.E3Proxy
{
    public class E3DbeApplicationProxy : E3ProxyBase
    {
        [MethodImpl(4096, MethodCodeType = 3)]
        public E3DbeApplicationProxy(object comObject) : base(comObject)
        {
        }

        [DispId(1611137030)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int ActivateOutputWindow( int windowId);

        [DispId(1610743872)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int AvoidAutomaticClosing( int avoid = 1);

        [DispId(1610743916)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int BeginForeignTask();

        [DispId(1611137024)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int BringToForeground();

        [DispId(1610743871)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public void ClearOutputWindow();

        [DispId(1611071488)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public void ClearResultWindow();

        [DispId(1611333633)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeAttributeObject();

        [DispId(1611333632)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeComponentObject();

        [DispId(1611333638)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeGraphObject();

        [DispId(1611399168)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeModelObject();

        [DispId(1611399171)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeModelPinObject();

        [DispId(1611530240)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeNodeObject();

        [DispId(1611333634)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeSymbolObject();

        [DispId(1611333635)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object CreateDbeTextObject();

        [DispId(1610940418)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int DeleteComponent( string name,  string version);

        [DispId(1610940424)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int DeleteModel( string name);

        [DispId(1610940421)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int DeleteSymbol( string name,  string version);

        [DispId(1611268097)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int DeleteWorkspaceConfiguration( string name = "");

        [DispId(1610743816)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int Display();

        [DispId(1610940417)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int EditComponent( string name,  string version);

        [DispId(1611464705)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int EditComponentWithPreconditions( string name,  string version,  ref object preconditions,  int flags = 0);

        [DispId(1610940423)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int EditModel( string name);

        [DispId(1610940420)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int EditSymbol( string name,  string version);

        [DispId(1610743915)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int EnableCOM( string password);

        [DispId(1610743834)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int EnableLogfile( int en);

        [DispId(1610743917)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int EndForeignTask();

        [DispId(1610743839)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int FreeLicense( string feature);

        [DispId(1610743924)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int FreeLicensePermanent( string feature);

        [DispId(1610743847)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string fullname();

        [DispId(1611333639)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetActiveComponentId();

        [DispId(1611399170)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetActiveModelId();

        [DispId(1611333640)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetActiveSymbolId();

        [DispId(1610743881)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetActualDatabase();

        [DispId(1610743905)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetAvailableLanguages( ref object languages);

        [DispId(1610743866)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetBuild();

        [DispId(1610743835)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetComponentDatabase();

        [DispId(1610743894)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetComponentDatabaseTableSchema();

        [DispId(1611333636)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetComponentIds( ref object ids);

        [DispId(1610743836)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetConfigurationDatabase();

        [DispId(1610743895)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetConfigurationDatabaseTableSchema();

        [DispId(1611268101)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetCurrentWorkspaceConfiguration();

        [DispId(1611005953)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetDatabaseTableSelectedComponents(out object ComponentArray, out object VersionArray);

        [DispId(1611005954)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetDatabaseTreeSelectedComponents(out object ComponentName, out object version);

        [DispId(1611005956)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetDatabaseTreeSelectedModels(out object ModelName);

        [DispId(1611005955)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetDatabaseTreeSelectedSymbols(out object SymbolName, out object version);

        [DispId(1610743884)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetDefinedDatabaseConnectionStrings( string dbname, out object cmp_cs, out object sym_cs, out object cnf_cs);

        [DispId(1610743883)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetDefinedDatabases(out object dbnames);

        [DispId(1610743910)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetEnableInteractiveDialogs();

        [DispId(1610743842)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetErrorCount();

        [DispId(1610743810)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetFullName();

        [DispId(1610743811)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetId();

        [DispId(1610743840)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetInfoCount();

        [DispId(1610743833)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetInstallationLanguage();

        [DispId(1610743832)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetInstallationPath();

        [DispId(1610743869)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetLanguageDatabase();

        [DispId(1610743897)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetLanguageDatabaseTableSchema();

        [DispId(1610743838)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetLicense( string feature);

        [DispId(1610743923)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetLicensePermanent( string feature);

        [DispId(1610743878)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetLogfileName( int index = 0);

        [DispId(1610743914)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object GetModalWindow();

        [DispId(1611399169)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetModelIds( ref object ids);

        [DispId(1610743808)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetName();

        [DispId(1610743876)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object GetPluginObject( ref object Plugin);

        [DispId(1610809346)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPrintCropMarks();

        [DispId(1610743828)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPrinterColour();

        [DispId(1610743830)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public double GetPrinterLinewidth();

        [DispId(1610743826)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPrinterMargins( ref object top,  ref object bottom,  ref object left,  ref object right);

        [DispId(1610743824)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetPrinterName();

        [DispId(1610809348)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPrintPageNumbers();

        [DispId(1610874881)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPrintSheetOrder();

        [DispId(1610809344)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetPrintSplitPages();

        [DispId(1610743898)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object GetProcessProperty( string what);

        [DispId(1610743919)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetProjectInformation( ref object filename,  ref object type,  ref object is_dbe);

        [DispId(1610743925)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetProvider( string dbname);

        [DispId(1610743868)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetRegistryVersion();

        [DispId(1610743845)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public object GetScriptArguments();

        [DispId(1610743909)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetScriptReturn();

        [DispId(1610743837)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetSymbolDatabase();

        [DispId(1610743896)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetSymbolDatabaseTableSchema();

        [DispId(1611333637)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetSymbolIds( ref object ids);

        [DispId(1610743888)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetTemplateFileDBE();

        [DispId(1610743822)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetTestMark( int num);

        [DispId(1610743906)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetTranslatedText( string text,  string language);

        [DispId(1610743901)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetTrigger( string name,  ref object filename);

        [DispId(1610743893)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetTriggerReturn();

        [DispId(1610743889)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetUseSheetOrientation();

        [DispId(1610743809)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetVersion();

        [DispId(1610743841)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetWarningCount();

        [DispId(1611268099)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public int GetWorkspaceConfigurations( ref object names,  string path = "");

        [DispId(1610743880)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public string GetWorkspaceName();

        [DispId(1610743877)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Include( string text);

        [DispId(1610743903)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsBasic();

        [DispId(1610743875)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsBoard();

        [DispId(1610743849)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsCable();

        [DispId(55)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsCaddy();

        [DispId(57)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsCaddyBasic();

        [DispId(56)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsCaddyDemo();

        [DispId(58)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsCaddyEconomy();

        [DispId(1610743856)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsDemo();

        [DispId(1610743904)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsEconomy();

        [DispId(1610743899)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsFluid();

        [DispId(1610743900)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsFormboard();

        [DispId(1610743918)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsFunctionalDesign();

        [DispId(1610743851)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsLogic();

        [DispId(1610743852)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsMultiuser();

        [DispId(1610743853)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsPanel();

        [DispId(1610743870)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsRedliner();

        [DispId(1610743850)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsSchema();

        [DispId(1610743891)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsScriptRunning();

        [DispId(1610743855)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsSmallBusiness();

        [DispId(1610743859)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsStudent();

        [DispId(1610743857)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsViewer();

        [DispId(1610743858)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsViewPlus();

        [DispId(53)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsWago();

        [DispId(54)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsWagoDemo();

        [DispId(1610743854)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsWire();

        [DispId(1610743912)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int IsWireWorks();

        [DispId(1611268100)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int LoadWorkspaceConfigurationFromFile( string name,  string path);

        [DispId(1610743815)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Maximize();

        [DispId(1610743814)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Minimize();

        [DispId(1610940416)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int NewComponent( string name,  string version,  string baseName,  string baseVersion,  int flags = 0);

        [DispId(1611464704)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int NewComponentWithPreconditions( string name,  string version,  string baseName,  string baseVersion,  ref object preconditions,  int flags = 0);

        [DispId(1610940422)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int NewModel( string name,  string baseName,  int flags = 0);

        [DispId(1610940419)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int NewSymbol( string name,  string version,  string baseName,  string baseVersion,  int flags = 0);

        [DispId(1610743821)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutError( int ok,  string text,  int item = 0);

        [DispId(1611137025)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutErrorEx( int flags,  string text,  int item,  int red,  int green,  int blue);

        [DispId(1610743819)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutInfo( int ok,  string text,  int item = 0);

        [DispId(1611137027)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutInfoEx( int flags,  string text,  int item,  int red,  int green,  int blue);

        [DispId(1610743818)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutMessage( string text,  int item = 0);

        [DispId(1611137029)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutMessageEx( int flags,  string text,  int item,  int red,  int green,  int blue);

        [DispId(1611137028)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutVerifyEx( int flags,  string text,  int item,  int red,  int green,  int blue);

        [DispId(1610743820)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutWarning( int ok,  string text,  int item = 0);

        [DispId(1611137026)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int PutWarningEx( int flags,  string text,  int item,  int red,  int green,  int blue);

        [DispId(1610743812)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Quit();

        [DispId(1610743922)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int ResetErrorCount();

        [DispId(1610743920)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int ResetInfoCount();

        [DispId(1610743921)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int ResetWarningCount();

        [DispId(1611268098)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int RestoreWorkspaceConfiguration( string name = "");

        [DispId(1610743907)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Run( string filename,  ref object arguments);

        [DispId(1611268096)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SaveWorkspaceConfiguration( string name = "");

        [DispId(1610743848)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  object ScriptArguments();

        [DispId(1610743873)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  string ScriptFullName();

        [DispId(1610743874)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  string ScriptName();

        [DispId(1611005952)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SelectComponentFromTable( ref object ComponentName,  ref object ComponentVersion);

        [DispId(1610743882)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetActualDatabase( string dbname);

        [DispId(1611202560)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetChildWindowState( int state);

        [DispId(1610743885)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetDefinedDatabaseConnectionStrings( string dbname,  string cmp_cs,  string sym_cs,  string cnf_cs);

        [DispId(1610743911)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetEnableInteractiveDialogs( int value);

        [DispId(1610743886)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetLanguageDatabase( string dbname);

        [DispId(1610743879)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetLogfileName( string logfile,  int index = 0);

        [DispId(1610743913)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetModalWindow( ref object hWnd);

        [DispId(1610809347)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrintCropMarks( int set);

        [DispId(1610743844)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrinterCollate( int col);

        [DispId(1610743829)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrinterColour( int colour);

        [DispId(1610743843)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrinterCopies( int copies);

        [DispId(1610743831)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  double SetPrinterLinewidth( double linewidth);

        [DispId(1610743827)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrinterMargins([In] double top, [In] double bottom, [In] double left, [In] double right);

        [DispId(1610743825)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrinterName([In] string name);

        [DispId(1610809349)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrintPageNumbers([In] int set);

        [DispId(1610874880)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrintSheetOrder([In] int set);

        [DispId(1610809345)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetPrintSplitPages([In] int set);

        [DispId(1610743908)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetScriptReturn([In] int value);

        [DispId(1610743887)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetTemplateFileDBE([In] string templatefilename);

        [DispId(1610743823)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetTestMark([In] int num, [In] int value);

        [DispId(1610743902)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetTrigger(
            string name,  string filename,  int active);

        [DispId(1610743892)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetTriggerReturn( int value);

        [DispId(1610743890)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SetUseSheetOrientation( int set);

        [DispId(1610743817)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int ShowNormal();

        [DispId(1611202561)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int ShowPluginWindow( int bShowPluginWindow,  string guid);

        [DispId(1611202562)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int ShowWindow( int windowId,  int show);

        [DispId(1610743813)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int Sleep( int msec);

        [DispId(1610743846)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SortArrayByIndex( ref object array,  int rows,  int columns,  int sortindex1,  int sortindex2);

        [DispId(1610743867)]
        [MethodImpl(4096, MethodCodeType = 3)]
        public  int SortArrayByIndexEx( ref object array,  ref object options);
    }
}