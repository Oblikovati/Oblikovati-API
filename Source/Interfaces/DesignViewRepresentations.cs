namespace Oblikovati.API;

/// <summary>
/// The DesignViewRepresentations collection object provides access to all the design view representations in the assembly and provides methods to create new ones.
/// </summary>
public interface DesignViewRepresentations : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DesignViewRepresentation object from the collection.
    /// </summary>
    DesignViewRepresentation this[object Index] { get; }
    /// <summary>
    /// Method that creates a new DesignViewRepresentation. The new created DesignViewRepresentation is returned.
    /// </summary>
    /// <param name="Name">Optional input string that specifies the name of the design view representation to create. If not specified, Inventor assigns a name to the representation.</param>
    /// <param name="Reserved">Optional input Boolean reserved for future use. Currently ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    DesignViewRepresentation Add([In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] bool? Reserved = false);
}
