namespace Oblikovati.API;

/// <summary>
/// The iFeatureTemplateDescriptor object describes the iFeature file that was used to create the iFeature.
/// </summary>
public interface iFeatureTemplateDescriptor
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the name of the iFeature file (.ide) used to create this iFeatureTemplateDescriptor.
    /// </summary>
    string LastKnownSourceFileName { get; }
    /// <summary>
    /// Gets the Internal Name (a GUID) for this document.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Method that flags the ReferenceComponent corresponding to the iFeature as being out of date. The next time this part is opened a message will be displayed to the user notifying them that the iFeature is out of date and allowing them to update it using the file specified.
    /// </summary>
    /// <param name="NewSourceFilename">Input String value that specifies the name of the file to use during the replacement of the iFeatureTemplateDescriptor.</param>
    [PreserveSig]
    void DelayReplaceAll([In] [MarshalAs(UnmanagedType.BStr)] string NewSourceFilename);
}
