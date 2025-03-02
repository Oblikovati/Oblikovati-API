namespace Oblikovati.API;

public delegate void FileUIEventsSink_OnFileInsertDialogEventHandler( string[] FileTypes, _Document DocumentObject, int ParentHWND,out string FileName,out string RelativeFileName,out string LibraryName,ref byte[] CustomLogicalName, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileUIEventsSink_OnFileInsertNewDialogEventHandler( string TemplateDir, string[] FileTypes, _Document DocumentObject, int ParentHWND,out string TemplateFileName,out string FileName,out string RelativeFileName,out string LibraryName,ref byte[] CustomLogicalName, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileUIEventsSink_OnFileNewDialogEventHandler( string TemplateDir, int ParentHWND,out string TemplateFileName, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileUIEventsSink_OnFileNewEventHandler( DocumentTypeEnum DocumentType,ref string TemplateFileName, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileUIEventsSink_OnFileOpenDialogEventHandler( string[] FileTypes, int ParentHWND,out string FileName, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileUIEventsSink_OnFileOpenFromMRUEventHandler(ref string FullFileName, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileUIEventsSink_OnFileSaveAsDialogEventHandler( string[] FileTypes, bool SaveCopyAs, int ParentHWND,out string FileName, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileUIEventsSink_OnPopulateFileMetadataEventHandler( ObjectsEnumerator FileMetadataObjects, string Formulae, NameValueMap Context,out HandlingCodeEnum HandlingCode);
