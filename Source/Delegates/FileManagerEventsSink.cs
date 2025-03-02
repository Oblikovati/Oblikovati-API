namespace Oblikovati.API;

public delegate void FileManagerEventsSink_OnFileCopyEventHandler( string SourceFullFileName, string DestinationFullFileName, bool Copy, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void FileManagerEventsSink_OnFileDeleteEventHandler( string FullFileName, NameValueMap Context,out HandlingCodeEnum HandlingCode);
