namespace Oblikovati.API;

public interface IRxApplicationAddInServer
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Automation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pAddInSite">pAddInSite</param>
    /// <param name="FirstTime">FirstTime</param>
    void Activate([In] [MarshalAs(UnmanagedType.Interface)] IRxApplicationAddInSite pAddInSite, [In] sbyte FirstTime);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Deactivate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    void ExecuteCommand(int CommandID);
}
