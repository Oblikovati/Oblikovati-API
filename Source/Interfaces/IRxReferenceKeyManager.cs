namespace Oblikovati.API;

public interface IRxReferenceKeyManager
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="phKeyContext">phKeyContext</param>
    void CreateKeyContext([Out] out uint phKeyContext);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="hKeyContext">hKeyContext</param>
    /// <param name="pKeyContextStream">pKeyContextStream</param>
    void SaveKeyContext([In] uint hKeyContext, [In] [MarshalAs(UnmanagedType.Interface)] IStream pKeyContextStream);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="phKeyContext">phKeyContext</param>
    /// <param name="pKeyContextStream">pKeyContextStream</param>
    void LoadKeyContext([Out] out uint phKeyContext, [In] [MarshalAs(UnmanagedType.Interface)] IStream pKeyContextStream);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="hKeyContext">hKeyContext</param>
    /// <param name="ObjectInterfaceIID">ObjectInterfaceIID</param>
    /// <param name="dwKeySize">dwKeySize</param>
    /// <param name="pKey">pKey</param>
    /// <param name="ppPrimaryMatch">ppPrimaryMatch</param>
    /// <param name="pMatchType">pMatchType</param>
    /// <param name="ppAllMatches">ppAllMatches</param>
    void BindKeyToInterface([In] uint hKeyContext, [In] ref Guid ObjectInterfaceIID, [In] uint dwKeySize, [In] ref byte pKey, [Out] out IntPtr ppPrimaryMatch, [Out] out SolutionNatureEnum pMatchType, [Out] [MarshalAs(UnmanagedType.Interface)] out IEnumUnknown ppAllMatches);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ObjectInterfaceIID">ObjectInterfaceIID</param>
    /// <param name="TransientKey">TransientKey</param>
    /// <param name="ppMatch">ppMatch</param>
    void BindTransientKeyToInterface([In] ref Guid ObjectInterfaceIID, [In] int TransientKey, [Out] out IntPtr ppMatch);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="hKeyContext">hKeyContext</param>
    /// <param name="dwKeySize">dwKeySize</param>
    /// <param name="pKey">pKey</param>
    /// <param name="pPrimaryTransientKey">pPrimaryTransientKey</param>
    /// <param name="pMatchType">pMatchType</param>
    /// <param name="pdwNumMatches">pdwNumMatches</param>
    /// <param name="ppAllMatches">ppAllMatches</param>
    void GetTransientKeyFromKey([In] uint hKeyContext, [In] uint dwKeySize, [In] ref byte pKey, [Out] out int pPrimaryTransientKey, [Out] out SolutionNatureEnum pMatchType, [Out] out uint pdwNumMatches, [Out] out IntPtr ppAllMatches);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TransientKey">TransientKey</param>
    /// <param name="hKeyContext">hKeyContext</param>
    /// <param name="pdwKeySize">pdwKeySize</param>
    IntPtr GetKeyFromTransientKey([In] int TransientKey, [In] uint hKeyContext, [Out] out uint pdwKeySize);
}
