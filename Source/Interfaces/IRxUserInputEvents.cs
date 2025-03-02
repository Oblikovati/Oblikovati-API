namespace Oblikovati.API;

public interface IRxUserInputEvents
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    void OnStartCommand([In] CommandIDEnum CommandID);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CommandID">CommandID</param>
    void OnStopCommand([In] CommandIDEnum CommandID);
}
