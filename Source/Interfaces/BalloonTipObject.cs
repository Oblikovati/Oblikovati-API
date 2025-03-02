namespace Oblikovati.API;

public interface BalloonTipObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    UserInterfaceManager Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Interval { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Message { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ClientData { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Message">Message</param>
    [PreserveSig]
    void Display([In] [MarshalAs(UnmanagedType.BStr)] string? Message = "");
}
