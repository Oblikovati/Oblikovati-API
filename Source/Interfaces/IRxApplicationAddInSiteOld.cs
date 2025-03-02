namespace Oblikovati.API;

public interface IRxApplicationAddInSiteOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandName">CommandName</param>
    /// <param name="CommandID">CommandID</param>
    /// <param name="InstallInTools">InstallInTools</param>
    object CreateCommand([In] [MarshalAs(UnmanagedType.BStr)] string CommandName, [In] int CommandID, [In] [MarshalAs(UnmanagedType.Struct)] object? InstallInTools = default);
}
