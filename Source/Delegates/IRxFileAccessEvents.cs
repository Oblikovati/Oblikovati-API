namespace Oblikovati.API;

public delegate void IRxFileAccessEvents_OnFileDirtyEventHandler( string RelativeFileName, string LibraryName, byte[] CustomLogicalName, string FullFileName, _Document DocumentObject,out HandlingCodeEnum HandlingCode);

public delegate void IRxFileAccessEvents_OnFileResolutionEventHandler( string RelativeFileName, string LibraryName, byte[] CustomLogicalName,out string FullFileName,out HandlingCodeEnum HandlingCode);
