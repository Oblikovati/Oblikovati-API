namespace Oblikovati.API;

/// <summary>
/// ModelSurfaceTextureSymbolDefinition Object.
/// </summary>
public interface ModelSurfaceTextureSymbolDefinition
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelSurfaceTextureSymbol Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane for the symbol.
    /// </summary>
    AnnotationPlane AnnotationPlane { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the annotation plane definition for the symbol.
    /// </summary>
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    /// <summary>
    /// Gets and sets the position of the symbol on the model.
    /// </summary>
    Point Position { get; set; }
    /// <summary>
    /// Read-only property that returns the leader associated with the leader note.
    /// </summary>
    ModelLeader Leader { get; }
    /// <summary>
    /// Read-only that returns a flat collection of all the leaf nodes in the leader tree. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    ModelLeaderNodesEnumerator AllLeafNodes { get; }
    /// <summary>
    /// Read-only that returns a flat collection of all the nodes in the leader tree. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    ModelLeaderNodesEnumerator AllNodes { get; }
    /// <summary>
    /// Read-only property that returns if a root node exists for this leader. If False, there are no leader segments associated with this leader and the RootNode property will return Nothing.
    /// </summary>
    bool HasRootNode { get; }
    /// <summary>
    /// Read-only property that returns the root node of this leader. This property will return Nothing if the HasRootNode property returns False.
    /// </summary>
    ModelLeaderNode RootNode { get; }
    /// <summary>
    /// Read-write property that gets and sets the geometric entity the note is attached to.
    /// </summary>
    GeometryIntent Intent { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the surface type for the symbol.&nbsp;Possible values kBasicSurfaceType, kMaterialRemovalRequiredSurfaceType and kMaterialRemovalProhibitedSurfaceType.
    /// </summary>
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether a tail is added to the symbol.
    /// </summary>
    bool IsForceTailShown { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this symbol specifies the standard surface characteristics for the component.
    /// </summary>
    bool IsMajority { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to add the all-around indicator to the symbol.
    /// </summary>
    bool AllAroundSymbol { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the roughness value, roughness value Ra maximum, maximum roughness value, or grade number. Denoted by A' in the surface texture symbol dialog.
    /// </summary>
    string MaximumRoughness { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the roughness value, roughness value Ra minimum, minimum roughness value, or grade number. Setting this property will return an error if the MaximumRoughness property is not specified. Denoted by A in the surface texture.
    /// </summary>
    string MinimumRoughness { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the production method, treatment, or coating. If the active drafting standard is based on ANSI, this property can be used to specify a note callout. Denoted by B in the surface texture symbol dialog.
    /// </summary>
    string ProductionMethod { get; set; }
    /// <summary>
    /// Read-write property that gets and sets an additional tail for the production method if the drafting standard is based on ISO or DIN. Setting this property will return an error if the ProductionMethod property is not specified.&nbsp;Denoted by B' in the surface tex.
    /// </summary>
    string AdditionalProductionMethod { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the following: (1)the roughness cutoff or sampling length for roughness average for ANSI (2)the waviness height or sampling length for ISO or DIN (3)the cutoff value and evaluation length for JIS.
    /// </summary>
    string SamplingLength { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the following: (1)the roughness cutoff or sampling length for additional roughness value for ANSI (2)the sampling length for additional roughness value for ISO or DIN (3)the reference length and evaluation length for JIS.
    /// </summary>
    string AdditionalSamplingLength { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the direction of lay. Setting this property will return an error if the SurfaceTextureType is specified to be kMaterialRemovalProhibitedSurfaceType. Denoted by D in the surface texture symbol dialog.
    /// </summary>
    LayDirectionTypeEnum LayDirection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the machining allowance. Setting this property will return an error if the SurfaceTextureType is not kMaterialRemovalRequiredSurfaceType. Denoted by E in the surface texture symbol dialog.
    /// </summary>
    string MachiningAllowance { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the roughness value other than Ra or the parameter value other than Ra. For ANSI, this property can also be used to specify the waviness height. Denoted by F in the surface texture symbol dialog.
    /// </summary>
    string AdditionalRoughness { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the surface waviness for JIS, or general comments for BSI. This property is ignored for ANSI, ISO, or DIN standards. Denoted by F' or G in the surface texture symbol dialog.
    /// </summary>
    string SurfaceWaviness { get; set; }
    /// <summary>
    /// Gets or sets the faces the surface texture symbol is associative with.
    /// </summary>
    FaceCollection Faces { get; set; }
    /// <summary>
    /// Gets and sets the surface profile upper tolerance.
    /// </summary>
    string SurfaceProfileUpperTolerance { get; set; }
    /// <summary>
    /// Gets and sets the surface profile lower tolerance.
    /// </summary>
    string SurfaceProfileLowerTolerance { get; set; }
    /// <summary>
    /// Gets and sets the manufacturing process.
    /// </summary>
    string ManufacturingProcess { get; set; }
    /// <summary>
    /// Gets and sets the number of feature elements.
    /// </summary>
    string NumberOfFeatureElements { get; set; }
    /// <summary>
    /// Gets and sets the profile direction relative to primary surface lay direction.
    /// </summary>
    ProfileDirectionTypeEnum ProfileDirection { get; set; }
    /// <summary>
    /// Returns the standard reference type.
    /// </summary>
    SurfaceTextureStandardReferenceTypeEnum StandardReference { get; }
    /// <summary>
    /// Method that adds a leader branch with the input points. This is the equivalent of the 'Add Leader' command in the user interface. This method will succeed only if the HasRootNode property returns False (i.e. there are no existing leader segments). If there are existing leader segments, you should use the ModelLeaderNode.AddLeader method instead.
    /// </summary>
    /// <param name="Points">ObjectCollection containing a series of Point objects representing a leader branch originating at the drawing annotation or symbol. The first point indicates the position of the root node. The last item in the collection can be a GeometryIntent object indicating a geometry to attach the leader branch to. The ObjectCollection must contain at least two items, else the method will fail.  The points are projected onto the orientation plane.</param>
    [PreserveSig]
    void AddLeader([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Points);
    /// <summary>
    /// Method that creates a copy of this ModelSurfaceTextureSymbolDefinition object. The new ModelSurfaceTextureSymbolDefinition object is independent of any surface texture symbols. It can edited and used as input to edit an existing surface texture symbol or to create a new surface texture symbol.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelSurfaceTextureSymbolDefinition Copy();
}
