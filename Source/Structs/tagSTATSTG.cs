﻿namespace Oblikovati.API;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct tagSTATSTG
{
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pwcsName;
	public uint Type;
	public _ULARGE_INTEGER cbSize;
	public _FILETIME mtime;
	public _FILETIME ctime;
	public _FILETIME atime;
	public uint grfMode;
	public uint grfLocksSupported;
	public Guid clsid;
	public uint grfStateBits;
	public uint Reserved;
}
