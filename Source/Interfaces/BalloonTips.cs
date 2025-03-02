namespace Oblikovati.API;

/// <summary>
/// BalloonTips Object.
/// </summary>
public interface BalloonTips : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    BalloonTip Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a new BalloonTip object.
    /// </summary>
    /// <param name="InternalName">Input String value that specifies the internal name of the BalloonTip.  This must be unique with respect to all other ballon tips.</param>
    /// <param name="Title">Input String value that specifies the title of the BalloonTip.</param>
    /// <param name="Message">Optional input String value that specifies the message for the BalloonTip. You can provide hyperlinks as part of the message using the format: &lt;Hyperlink&gt;http://www.yoursite.com&lt;/Hyperlink&gt;.</param>
    /// <returns></returns>
    [PreserveSig]
    BalloonTip Add([In] [MarshalAs(UnmanagedType.BStr)] string InternalName, [In] [MarshalAs(UnmanagedType.BStr)] string Title, [In] [MarshalAs(UnmanagedType.BStr)] string Message);
}
