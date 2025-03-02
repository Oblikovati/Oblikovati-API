namespace Oblikovati.API;

/// <summary>
/// Object that encapsulates a given software version. Used in various contexts.
/// </summary>
public interface SoftwareVersion
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the Major release number (e.g.: Release '1', '2', ...).
    /// </summary>
    int Major { get; }
    /// <summary>
    /// Gets the Minor release number. If none, a zero is returned. (e.g.: the '5' in release 1.5).
    /// </summary>
    int Minor { get; }
    /// <summary>
    /// Gets the number of the Service Pack if this software has been updated with such. If none, a zero is returned. (e.g.: the '3' in Release 2.5 Service Pack 3).
    /// </summary>
    int ServicePack { get; }
    /// <summary>
    /// Gets the Beta version. If this is not a Beta version software, this value will be zero.
    /// </summary>
    int BetaVersion { get; }
    /// <summary>
    /// Gets a Boolean flag indicating whether this software is intended for purely internal purposes or not. Beta is considered external.
    /// </summary>
    bool NotProduction { get; }
    /// <summary>
    /// Gets the number that completely identifies a particular build of Autodesk Inventor.
    /// </summary>
    int BuildIdentifier { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _InternalBuildIdentifier { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _DebugBuildIdentifier { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _PatchBuildIdentifier { get; }
    /// <summary>
    /// Gets the human-readable, displayable name designating this particular version (e.g.: 'Autodesk Inventor (tm) Release 2.5 Service Pack 3').
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Always false in 32-bit Inventor. Use this property to find out whether your code is connected to a 64-bit version of Inventor.
    /// </summary>
    bool Is64BitVersion { get; }
    /// <summary>
    /// Gets the product edition. Only valid when SoftwareVersion is obtained from the Application.
    /// </summary>
    ProductEditionEnum ProductEdition { get; }
    /// <summary>
    /// Returns the release version displayed to users. (e.g.: '2009' for Major version 13 or '2010' for Major version 14)
    /// </summary>
    string DisplayVersion { get; }
    /// <summary>
    /// Returns whether this is an educational versions of Inventor.
    /// </summary>
    bool IsEducationVersion { get; }
    /// <summary>
    /// Gets the product name.&nbsp;Only valid when SoftwareVersion is obtained from the Application.
    /// </summary>
    string ProductName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string VersionInfoLabel { get; }
}
