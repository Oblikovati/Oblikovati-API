namespace Oblikovati.API;

public interface IEnumUnknown
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="celt">celt</param>
    /// <param name="rgelt">rgelt</param>
    /// <param name="pceltFetched">pceltFetched</param>
    void RemoteNext([In] uint celt, [Out] [MarshalAs(UnmanagedType.IUnknown)] out object rgelt, [Out] out uint pceltFetched);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="celt">celt</param>
    void Skip([In] uint celt);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Reset();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppEnum">ppEnum</param>
    void Clone([Out] [MarshalAs(UnmanagedType.Interface)] out IEnumUnknown ppEnum);
}
