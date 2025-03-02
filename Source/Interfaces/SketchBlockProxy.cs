namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface SketchBlockProxy
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns an enumerator of SketchBlocks objects found directly under this sketch block.
    /// </summary>
    SketchBlocksEnumerator ChildBlocks { get; }
    /// <summary>
    /// Property that returns the sketch block that in turn contains this sketch block. This is the same SketchBlock returned as the last item in the SketchBlockPath property. This property \returns Nothing if this sketch block does not belong to another sketch block and lives directly under a sketch.
    /// </summary>
    SketchBlock ContainingSketchBlock { get; }
    /// <summary>
    /// Gets and sets the color for the sketch block.&nbsp;Setting the property to Nothing restores the sketch block to the default color.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets and sets name of the sketch block.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the path of sketch blocks at the leaf of which this sketch block is found. The enumerator returns a count of 0 if the block lives directly under a sketch. The path does not include this sketch block itself.
    /// </summary>
    SketchBlocksEnumerator SketchBlockPath { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the transformation matrix for the sketch block.
    /// </summary>
    Matrix2d Transformation { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the constraint status of the sketch block. Possible return values are kFullyConstrainedConstraintStatus, kOverConstrainedConstraintStatus, kUnderConstrainedConstraintStatus and kUnknownConstraintStatus.
    /// </summary>
    ConstraintStatusEnum ConstraintStatus { get; }
    /// <summary>
    /// Property that returns the referenced sketch block definition.
    /// </summary>
    SketchBlockDefinition Definition { get; }
    /// <summary>
    /// Gets and sets whether this sketch block is flexible.
    /// </summary>
    bool Flexible { get; set; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Gets and sets the position of the sketch block.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Gets and sets the line type override for the sketch block.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Gets and sets the line weight override for the sketch block.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Property that returns the parent sketch of the object.
    /// </summary>
    Sketch Parent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Property that returns the referenced sketch block, if there is one. Else, the property returns Nothing.
    /// </summary>
    SketchBlock ReferencedEntity { get; }
    /// <summary>
    /// Gets and sets whether this sketch block is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    SketchBlock NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes the sketch block.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that activates the sketch block for editing by the user.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Method that causes the sketch block to return from the edit mode and into the environment specified by the input argument. If the sketch block is not currently active (i.e. this is not the same block as returned by Application.ActiveEditObject property), then this method does nothing.
    /// </summary>
    /// <param name="ExitTo">Input ExitTypeEnum that specifies the environment to exit to. Possible values are kExitToPrevious, kExitToParent and kExitToTop.</param>
    [PreserveSig]
    void ExitEdit([In] ExitTypeEnum ExitTo);
    /// <summary>
    /// Method that explodes the contents of the block and deletes the block instance. Note that the contents of the block are retained.
    /// </summary>
    [PreserveSig]
    void Explode();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that returns the corresponding object in the sketch block for the given object from it's definition.
    /// </summary>
    /// <param name="ObjectInDefinition">Input Object to get the corresponding object (in the sketch block) for. This can be one of the following objects\: SketchEntity, SketchBlock, SketchImage or TextBox.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetObject([In] [MarshalAs(UnmanagedType.IDispatch)] object ObjectInDefinition);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that sets a custom line type to the curve from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
}
