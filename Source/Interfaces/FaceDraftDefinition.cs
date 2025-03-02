namespace Oblikovati.API;

/// <summary>
/// The FaceDraftDefinition object represents the definition for a FaceDraftFeature.
/// </summary>
public interface FaceDraftDefinition
{
    /// <summary>
    /// Read-write property that gets and sets whether the draft angle of the face draft is absolute against the pull direction.
    /// </summary>
    bool AbsoluteDraftAngle { get; set; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets whether include the blended features in the face draft feature.
    /// </summary>
    bool AutomaticBlending { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to cut material or not when create a draft face feature using parting tool. This is applicable only when the DefinitionType is&nbsp;kPartingToolFaceDraftDefinitionType.
    /// </summary>
    bool CutMaterial { get; set; }
    /// <summary>
    /// Read-only property that returns the FaceDraftDefinitionTypeEnum indicating which face draft type the definition is.
    /// </summary>
    FaceDraftDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Read-write property that gets and sets the draft angle of the face draft. For parting line face draft, this DraftAngle will be the minimum draft angle value for the two sides face draft.
    /// </summary>
    object DraftAngle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the draft angle constraint type for the face draft.
    /// </summary>
    DraftAngleConstraintTypeEnum DraftAngleConstraintType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the draft angle two of the face draft. This property is applicable only when the DraftAngleConstraintType is set to kAsymmetricDraftAngles.
    /// </summary>
    object DraftAngleTwo { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the fixed edges on the input faces.&nbsp;This property is applicable when the DefinitionType is kFixedEdgeFaceDraftDefinitionType or kPartingToolFaceDraftDefinitionType and the CutMaterial is False.
    /// </summary>
    EdgeCollection FixedEdges { get; set; }
    /// <summary>
    /// Read-write property that specifies the faces used to create the feature.
    /// </summary>
    FaceCollection InputFaces { get; set; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    FaceDraftFeature Parent { get; }
    /// <summary>
    /// Read-only property that specifies the object used to determine the pull direction.&nbsp;For a fixed edge face draft this could be a planar Face, an Edge, a WorkPlane or a WorkAxis.&nbsp;For a fixed plane face draft this could either be a planar Face or a WorkPlane.
    /// </summary>
    object PullDirection { get; }
    /// <summary>
    /// Read-write property that gets and sets whether reverse the pull direction.
    /// </summary>
    bool PullDirectionReversed { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a copy of this FaceDraftDefinition object.&nbsp;The new FaceDraftDefinition object is independent of any feature.&nbsp;It can be edited and used as input to edit an existing feature or to create a new face draft feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    FaceDraftDefinition Copy();
    /// <summary>
    /// Method that set the face draft definition to be kFixedEdgeFaceDraftDefinitionType with input values.
    /// </summary>
    /// <param name="InputFaces">Input FaceCollection object that specifies the faces to draft.</param>
    /// <param name="FixedEdges">Input EdgeCollection object that specifies the fixed edges for face draft.</param>
    /// <param name="PullDirection">Input Object that specifies an object to define the pull direction. This could be a planar Face, an Edge, a WorkPlane or a WorkAxis.</param>
    /// <param name="DraftAngle">Input Variant value that specifies the draft angle for face draft.  A numeric or string value can be supplied for this property and a parameter will be automatically created after the face draft feature is created. If a numeric value is supplied, the value is in radian, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document angle unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a angle “d1+3 deg”.</param>
    /// <param name="PullDirectionReversed">Optioanl input Boolean that specifies whether reverse the pull direction.</param>
    /// <param name="AbsoluteDraftAngle">Optioanl input Boolean that specifies whether the DraftAngle is absolute angle or relative angle against the pull direction. This defaults to True indicating the draft angle is absolute angle value.</param>
    [PreserveSig]
    void SetFixedEdge([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection InputFaces, [In] [MarshalAs(UnmanagedType.Interface)] EdgeCollection FixedEdges, [In] [MarshalAs(UnmanagedType.IDispatch)] object PullDirection, [In] [MarshalAs(UnmanagedType.Struct)] object DraftAngle, [In] bool? PullDirectionReversed = false, [In] bool? AbsoluteDraftAngle = true);
    /// <summary>
    /// Method that set the face draft definition to be kFixedPlaneFaceDraftDefinitionType with input values.
    /// </summary>
    /// <param name="InputFaces">Input FaceCollection object that specifies the faces to draft.</param>
    /// <param name="FixedPlane">Input object that specifies the fixed plane for face draft.  This can be a planar Face, or a WorkPlane.</param>
    /// <param name="DraftAngle">Input Variant value that specifies the draft angle for face draft.  A numeric or string value can be supplied for this property and a parameter will be automatically created after the face draft feature is created. If a numeric value is supplied, the value is in radian, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document angle unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a angle “d1+3 deg”.</param>
    /// <param name="DraftAngleConstraintType">Optioanl input DraftAngleConstraintTypeEnum that specifies how the draft angle will be applied to the draft faces on two sides of the fixed plane. Valid inputs are kOneWayDraftAngle ,kSymmetricDraftAngles and kAsymmetricDraftAngles. This defaults to kOneWayDraftAngle. When the kAsymmetricDraftAngles is specified for this argument the DraftAngleTwo is required to specify the draft angle two for the face draft feature.</param>
    /// <param name="DraftAngleTwo">Optional input Variant value that specifies the draft angle two for face draft.  A numeric or string value can be supplied for this property and a parameter will be automatically created after the face draft feature is created. If a numeric value is supplied, the value is in radian, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document angle unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a angle “d1+3 deg”.
    /// This is ignored if the DraftAngleConstraintType is not equal to kAsymmetricDraftAngles.</param>
    /// <param name="AbsoluteDraftAngle">Optioanl input Boolean that specifies whether the DraftAngle is absolute angle or relative angle against the pull direction. This defaults to True indicating the draft angle is absolute angle value.</param>
    [PreserveSig]
    void SetFixedPlane([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection InputFaces, [In] [MarshalAs(UnmanagedType.IDispatch)] object FixedPlane, [In] [MarshalAs(UnmanagedType.Struct)] object DraftAngle, [In] DraftAngleConstraintTypeEnum? DraftAngleConstraintType = DraftAngleConstraintTypeEnum.kOneWayDraftAngle, [In] [MarshalAs(UnmanagedType.Struct)] object? DraftAngleTwo = default, [In] bool? AbsoluteDraftAngle = true);
    /// <summary>
    /// Method that set the face draft definition to be kPartingToolFaceDraftDefinitionType with input values.
    /// </summary>
    /// <param name="InputFaces">Input FaceCollection object that specifies the faces to draft.</param>
    /// <param name="PartingTool">Input object that specifies the parting tool for face draft.  This can be a 2D&3D sketch profile or work plane or work surface. Valid parting tool should be intersecting with the input faces for drafting.</param>
    /// <param name="PullDirection">Input Object that specifies an object to define the pull direction. This could be a planar Face, an Edge, a WorkPlane or a WorkAxis.</param>
    /// <param name="DraftAngle">Input Variant value that specifies the draft angle for face draft.  A numeric or string value can be supplied for this property and a parameter will be automatically created after the face draft feature is created. If a numeric value is supplied, the value is in radian, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document angle unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a angle “d1+3 deg”.</param>
    /// <param name="CutMaterial">Optioanl input Boolean that specifies whether the draft face feature is to cut material. This defaults to True indicating the draft face feature is to cut material.</param>
    /// <param name="FixedEdges">Optioanl input EdgeCollection object that specifies the fixed edges for face draft.  This is ignored if the CutMaterial is True.</param>
    /// <param name="DraftAngleConstraintType">Optioanl input DraftAngleConstraintTypeEnum that specifies how the draft angle will be applied to the draft faces on two sides of the parting tool. When the CutMaterial is True you can specify the kSymmetricDraftAngles and kAsymmetricDraftAngles, and the kSymmetricDraftAngles is default value in this case. While the CutMaterial is False, valid input values are kSideOneMinDraftAngle, kSideTwoMinDraftAngle and kBothSidesMinDraftAngle, and the kSideOneMinDraftAngle is default value in this case.</param>
    /// <param name="DraftAngleTwo">Optional input Variant value that specifies the draft angle two for face draft.  A numeric or string value can be supplied for this property and a parameter will be automatically created after the face draft feature is created. If a numeric value is supplied, the value is in radian, and the parameter is set to the value specified. If a string value is supplied it will be used as the expression for the newly created parameter, if the value is supplied without a unit qualifier it will default to the current document angle unit. The following is a valid entry for it, assuming the parameter d1 already exists and defines a angle “d1+3 deg”.</param>
    /// <param name="PullDirectionReversed">Optioanl input Boolean that specifies whether reverse the pull direction.</param>
    /// <param name="AbsoluteDraftAngle">Optioanl input Boolean that specifies whether the DraftAngle is absolute angle or relative angle against the pull direction. This defaults to True indicating the draft angle is absolute angle value.</param>
    [PreserveSig]
    void SetPartingTool([In] [MarshalAs(UnmanagedType.Interface)] FaceCollection InputFaces, [In] [MarshalAs(UnmanagedType.IDispatch)] object PartingTool, [In] [MarshalAs(UnmanagedType.IDispatch)] object PullDirection, [In] [MarshalAs(UnmanagedType.Struct)] object DraftAngle, [In] bool? CutMaterial = true, [In] [MarshalAs(UnmanagedType.Struct)] object? FixedEdges = default, [In] DraftAngleConstraintTypeEnum? DraftAngleConstraintType = DraftAngleConstraintTypeEnum.kSymmetricDraftAngles, [In] [MarshalAs(UnmanagedType.Struct)] object? DraftAngleTwo = default, [In] bool? PullDirectionReversed = false, [In] bool? AbsoluteDraftAngle = true);
}
