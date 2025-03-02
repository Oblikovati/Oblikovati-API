namespace Oblikovati.API;

public interface AssemblyEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnAssemblyChanged([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Solver">Solver</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    [PreserveSig]
    void OnAssemblySolve([In] [MarshalAs(UnmanagedType.Interface)] _AssemblySolver Solver, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Context">Context</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnAssemblyChange([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [In] EventTimingEnum BeforeOrAfter, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Occurrence">Occurrence</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewOccurrence([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Occurrence">Occurrence</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnOccurrenceChange([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.Interface)] ComponentOccurrence Occurrence, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Constraint">Constraint</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewConstraint([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.IDispatch)] object Constraint, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Relationship">Relationship</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewRelationship([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] [MarshalAs(UnmanagedType.IDispatch)] object Relationship, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="Entity">Entity</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDelete([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="NewLoadState">NewLoadState</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnLoadStateChange([In] [MarshalAs(UnmanagedType.Interface)] _AssemblyDocument DocumentObject, [In] DocumentLoadStateEnum NewLoadState, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}
