namespace Oblikovati.API;

public interface ISequentialStream
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pv">pv</param>
    /// <param name="cb">cb</param>
    /// <param name="pcbRead">pcbRead</param>
    void RemoteRead([Out] out byte pv, [In] uint cb, [Out] out uint pcbRead);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pv">pv</param>
    /// <param name="cb">cb</param>
    /// <param name="pcbWritten">pcbWritten</param>
    void RemoteWrite([In] ref byte pv, [In] uint cb, [Out] out uint pcbWritten);
}
