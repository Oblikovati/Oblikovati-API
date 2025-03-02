namespace Oblikovati.API;

public interface IPersistFile : IPersist
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void IsDirty();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pszFileName">pszFileName</param>
    /// <param name="dwMode">dwMode</param>
    void Load([In] [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [In] uint dwMode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pszFileName">pszFileName</param>
    /// <param name="fRemember">fRemember</param>
    void Save([In] [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [In] int fRemember);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pszFileName">pszFileName</param>
    void SaveCompleted([In] [MarshalAs(UnmanagedType.LPWStr)] string pszFileName);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ppszFileName">ppszFileName</param>
    void GetCurFile([Out] [MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);
}
