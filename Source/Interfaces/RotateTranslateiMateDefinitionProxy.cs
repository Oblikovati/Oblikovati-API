namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface RotateTranslateiMateDefinitionProxy
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
    /// Property that returns the internal unique identifier for this iMateDefinition.
    /// </summary>
    string Identifier { get; }
    /// <summary>
    /// Gets the name of this iMateDefinition.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets the index of this iMateDefinition.
    /// </summary>
    int SequenceIndex { get; set; }
    /// <summary>
    /// Gets the boolean flag that indicates whether this iMateDefinition is suppressed or not.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets an array of strings that specifies the priority order for iMate definition matches.
    /// </summary>
    object MatchList { get; set; }
    /// <summary>
    /// Gets the object this entity is dependent on.
    /// </summary>
    iMateDefinition ReferencedEntity { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Property that returns the Parameter object that controls the ratio of the iMate definition.
    /// </summary>
    Parameter Ratio { get; }
    /// <summary>
    /// Property that returns the direction of rotation and translation of the objects with respect to their axes' directions. If the property is True then the translation will be in the same direction as the rotation with respect to the rotation and translation axes.
    /// </summary>
    bool ForwardDirection { get; }
    /// <summary>
    /// Property that returns the entity used for the iMate definition.
    /// </summary>
    object Entity { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    iMateDefinition NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Property that gets whether this object is consumed in the
    /// context of the active assembly/part/sketch.
    /// </summary>
    bool IsConsumed { get; }
    /// <summary>
    /// Method that deletes the iMateDefinition.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
