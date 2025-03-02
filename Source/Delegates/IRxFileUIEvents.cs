namespace Oblikovati.API;

public delegate void IRxFileUIEvents_OnFileInsertDialogEventHandler( string[] FileTypes, _Document DocumentObject, int ParentHWND,out string FileName,out string RelativeFileName,out string LibraryName,out byte[] CustomLogicalName,out HandlingCodeEnum HandlingCode);

public delegate void IRxFileUIEvents_OnFileInsertNewDialogEventHandler( string TemplateDir, string[] FileTypes, _Document DocumentObject, int ParentHWND,out string TemplateFileName,out string FileName,out string RelativeFileName,out string LibraryName,out byte[] CustomLogicalName,out HandlingCodeEnum HandlingCode);

public delegate void IRxFileUIEvents_OnFileNewDialogEventHandler( string TemplateDir, int ParentHWND,out string TemplateFileName,out HandlingCodeEnum HandlingCode);

public delegate void IRxFileUIEvents_OnFileOpenDialogEventHandler( string[] FileTypes, int ParentHWND,out string FileName,out HandlingCodeEnum HandlingCode);

public delegate void IRxFileUIEvents_OnFileSaveAsDialogEventHandler( string[] FileTypes, bool SaveCopyAs, int ParentHWND,out string FileName,out HandlingCodeEnum HandlingCode);
