namespace Oblikovati.API;

/// <summary>
/// Reference key manager object. This object provides methods to create and save reference key contexts as well as bind reference keys to their targets.
/// </summary>
public interface ReferenceKeyManager
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    /// <param name="MatchType">MatchType</param>
    [PreserveSig]
    object BindKeyToObject([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    /// <param name="MatchType">MatchType</param>
    [PreserveSig]
    object BindKeyToObject([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int KeyContext, [Out] [MarshalAs(UnmanagedType.Struct)] out object MatchType);
    /// <summary>
    /// Method to create a key context to use in the creation of reference keys.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    int CreateKeyContext();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="KeyContext">KeyContext</param>
    /// <param name="Result">Result</param>
    [PreserveSig]
    void SaveContextToArray([In] int KeyContext, [Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] Result);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ContextData">ContextData</param>
    [PreserveSig]
    int LoadContextFromArray([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ContextData);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    [PreserveSig]
    string KeyToString([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKeyString">ReferenceKeyString</param>
    /// <param name="ReferenceKey">ReferenceKey</param>
    [PreserveSig]
    void StringToKey([In] [MarshalAs(UnmanagedType.BStr)] string ReferenceKeyString, [Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    /// <param name="Object">Object</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    bool CanBindKeyToObject([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    /// <param name="Object">Object</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    bool CanBindKeyToObject([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int KeyContext, [Out] [MarshalAs(UnmanagedType.Struct)] out object Object, [Out] [MarshalAs(UnmanagedType.Struct)] out object Context);
    /// <summary>
    /// Specifies a key context to release.
    /// </summary>
    [PreserveSig]
    void ReleaseKeyContext([In] int KeyContext);
}
