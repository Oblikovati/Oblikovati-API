namespace Oblikovati.API;

public interface IRxApplicationAddIn
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Guid ClassId { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ProgId { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ShortDisplayName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Description { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte StartUpEnabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ApplicationAddInTypeEnum AddInType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte Activated { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InterfaceIID">InterfaceIID</param>
    /// <param name="ppInterfacePtr">ppInterfacePtr</param>
    void GetInterface([In] ref Guid InterfaceIID, [Out] out IntPtr ppInterfacePtr);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Activate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    void Deactivate();
}
