namespace Oblikovati.API;

public interface DebugInstrumentationSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cookie">Cookie</param>
    void ObjectCreated([In] int Cookie);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cookie">Cookie</param>
    void ObjectDestroyed([In] int Cookie);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cookie">Cookie</param>
    /// <param name="ToReferenceCount">ToReferenceCount</param>
    void ObjectAddRefd([In] int Cookie, [In] int ToReferenceCount);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cookie">Cookie</param>
    /// <param name="ToReferenceCount">ToReferenceCount</param>
    void ObjectReleased([In] int Cookie, [In] int ToReferenceCount);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cookie">Cookie</param>
    /// <param name="InterfaceIID">InterfaceIID</param>
    /// <param name="Successful">Successful</param>
    void ObjectQueryInterfaced([In] int Cookie, [In] [MarshalAs(UnmanagedType.BStr)] string InterfaceIID, [In] bool Successful);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cookie">Cookie</param>
    /// <param name="MemberName">MemberName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Result">Result</param>
    void OnMemberInvoke([In] int Cookie, [In] [MarshalAs(UnmanagedType.BStr)] string MemberName, [In] EventTimingEnum BeforeOrAfter, [In] int Result);
}
