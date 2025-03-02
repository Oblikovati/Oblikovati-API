namespace Oblikovati.API;

public delegate void FileAccessEventsSink_OnFileDirtyEventHandler( string RelativeFileName, string LibraryName,ref byte[] CustomLogicalName, string FullFileName, _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileAccessEventsSink_OnFileResolutionEventHandler( string RelativeFileName, string LibraryName,ref byte[] CustomLogicalName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out string FullFileName,out HandlingCodeEnum HandlingCode);
