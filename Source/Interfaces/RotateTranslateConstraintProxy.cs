namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface RotateTranslateConstraintProxy
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent of the object.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets/Sets the Boolean flag indicating whether this constraint is suppressed.
    /// </summary>
    bool Suppressed { get; set; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Gets/Sets the displayable name of this constraint.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that indicates the first of the geometric entities (Face, Axis, Edge, etc.) being constrained.
    /// </summary>
    object EntityOne { get; }
    /// <summary>
    /// Property that indicates the second of the geometric entities (Face, Axis, Edge, etc.) being constrained.
    /// </summary>
    object EntityTwo { get; }
    /// <summary>
    /// Property that returns the first of the two objects this constraint is between.
    /// </summary>
    ComponentOccurrence OccurrenceOne { get; }
    /// <summary>
    /// Property that returns the second of the two objects this constraint is between.
    /// </summary>
    ComponentOccurrence OccurrenceTwo { get; }
    /// <summary>
    /// Property that returns the first of the two objects affected by this constraint. This is the same as the owning occurrence obtained from the OccurrenceOne property in the case where the owning assembly is not adaptive. Else, this is the first non-adaptive occurrence in the path leading from the owning occurrence to the occurrence that contains the first of the two geometries that this constraint is between.
    /// </summary>
    ComponentOccurrence AffectedOccurrenceOne { get; }
    /// <summary>
    /// Property that returns the second of the two objects affected by this constraint. This is the same as the owning occurrence obtained from the OccurrenceTwo property in the case where the owning assembly is not adaptive. Else, this is the first non-adaptive occurrence in the path leading from the owning occurrence to the occurrence that contains the second of the two geometries that this constraint is between.
    /// </summary>
    ComponentOccurrence AffectedOccurrenceTwo { get; }
    /// <summary>
    /// Property that returns the geometry of the first of the two entities that this constraint is between. The geometry returned is in the space of the assembly and for face or work plane geometries it accounts for the orientation of the face or work plane.
    /// </summary>
    object GeometryOne { get; }
    /// <summary>
    /// Property that returns the geometry of the second of the two entities that this constraint is between. The geometry returned is in the space of the assembly and for face or work plane geometries it accounts for the orientation of the face or work plane.
    /// </summary>
    object GeometryTwo { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that indicates if this iMateResult represents a composite iMate.
    /// </summary>
    bool ResultOfiMate { get; }
    /// <summary>
    /// Property that returns the iMateResult object that resulted in the creation of this constraint.
    /// </summary>
    iMateResult iMateResult { get; }
    /// <summary>
    /// Property that indicates if this constraint is a member of a layout constraint. If True then it is a member of a layout constraint. The layout constraint can be obtained by using the LayoutConstraint property.
    /// </summary>
    bool ResultOfLayoutConstraint { get; }
    /// <summary>
    /// Property that returns the layout constraint this constraint is a member of. Returns Nothing in the case where this constraint is not a member of a layout constraint. You can also determine if a constraint is a member of a layout constraint by using the ResultOfLayoutConstraint property.
    /// </summary>
    LayoutConstraint LayoutConstraint { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DriveConstraintSettings DriveConstraintSettings { get; }
    /// <summary>
    /// Returns the DriveSettings object for the constraint.
    /// </summary>
    DriveSettings DriveSettings { get; }
    /// <summary>
    /// Indicates if the name of this constraint is the original default name or if the user has changed the name.&nbsp;A value of True indicates the name is the original default name.
    /// </summary>
    bool IsDefaultName { get; }
    /// <summary>
    /// Gets/Sets the Visible indicating whether this constraint is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Parameter Ratio { get; }
    /// <summary>
    /// Boolean property that defines the direction of rotation and translation of the objects with respect to their axes directions. If the property is True then the translation will in the same direction as the rotation with respect to the rotation and translation axes.
    /// </summary>
    bool ForwardDirection { get; }
    /// <summary>
    /// Gets the Parameter object that controls the distance of translation for every revolution of the rotated occurrence.
    /// </summary>
    Parameter Distance { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    RotateTranslateConstraint NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes the constraint.
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
    /// <summary>
    /// Method that converts the constraint to an angle constraint, and returns the AngleConstraint object. This method can also be used to edit the geometries associated with an angle constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object. This object can be a planar face, work plane, linear edge, work axis, or a face that defines an axis.</param>
    /// <param name="EntityTwo">Input object that defines the second object. This object can be a planar face, work plane, linear edge, work axis, or a face that defines an axis.</param>
    /// <param name="Angle">Input Variant that defines the angle between the two input entities. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input the units can be specified as part of the string or will default to the current angle units of the document.</param>
    /// <param name="SolutionType">Optional input AngleConstraintSolutionTypeEnum that specifies the solution type. If specified to be kDirectedSolution, the solution always applies the right hand rule. If specified to be kUndirectedSolution, the solution allows either orientation, thus resolving situations where component orientation flips during a constraint drive or drag. If specified to be kReferenceVectorSolution, the ReferenceVectorEntity argument must be provided with a third entity for the solution. The default value is kDirectedSolution.</param>
    /// <param name="ReferenceVectorEntity">Optional input object that provides a third entity to solve the angle constraint. This argument is ignored if the SolutionType argument is not kReferenceVectorSolution. This object can be a planar face, work plane, linear edge, work axis, or a face that defines an axis.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    AngleConstraint ConvertToAngleConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] AngleConstraintSolutionTypeEnum? SolutionType = AngleConstraintSolutionTypeEnum.kDirectedSolution, [In] [MarshalAs(UnmanagedType.Struct)] object? ReferenceVectorEntity = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Method that converts the constraint to a custom constraint, and returns the CustomConstraint object. This method can also be used to edit the geometries associated with a custom constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object.</param>
    /// <param name="EntityTwo">Input object that defines the second object.</param>
    /// <param name="ClientId">Input String that specifies the ClientId, typically the ClassId of the Add-in creating the constraint.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomConstraint ConvertToCustomConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.BStr)] string ClientId);
    /// <summary>
    /// Method that converts the constraint to a flush constraint, and returns the FlushConstraint object. This method can also be used to edit the geometries associated with a flush constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object. The input object must be either a planar Face object or WorkPlane object.</param>
    /// <param name="EntityTwo">Input object that defines the second object. The input object must be either a planar Face object or WorkPlane object</param>
    /// <param name="Offset">Input Variant that defines the offset between the two input entities. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    FlushConstraint ConvertToFlushConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Method that converts the constraint to an insert constraint, and returns the InsertConstraint object. This method can also be used to edit the geometries associated with an insert constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object. This object is a circular edge.</param>
    /// <param name="EntityTwo">Input object that defines the second object. This object is a circular edge.</param>
    /// <param name="AxesOpposed">Input Boolean that specifies whether the direction of the axies of the input entities are in the same direction or opposed. A value of True indicates they are opposed.</param>
    /// <param name="Distance">Input Variant that defines the offset between the two input entities. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    InsertConstraint ConvertToInsertConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] bool AxesOpposed, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Method that converts the constraint to a mate constraint, and returns the MateConstraint object. This method can also be used to edit the geometries associated with a mate constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object.</param>
    /// <param name="EntityTwo">Input object that defines the second object.</param>
    /// <param name="Offset">Input Variant that defines the offset between the two input entities. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="EntityOneInferredType">Optional input enum that specifies how the geometry of entity one is to be interpreted. Depending on the geometry of the entity one, different options are possible.
    /// If entity one is a cylinder this can be either kNoInferrence or kInferredLine. For kNoInferrence to be valid for a cylinder, entity two must also be a cylinder and they must be the same radius.
    /// If entity one is a sphere this can be either kNoInferrence or kInferredPoint. For kNoInferrence to be valid for a sphere, entity two must also be a sphere and they must be the same radius.
    /// If entity one is a cone this can be either kNoInferrence or kInferredLine. For kNoInferrence to be valid for a cone, entity two must also be a cone and they must have the same taper angle.
    /// If entity one is a torus this can be either kInferredLine or kInferredPoint.
    /// For a plane, only kNoInferrence is valid.</param>
    /// <param name="EntityTwoInferredType">Input enum that specifies how the geometry of entity two is to be interpreted. Depending on the geometry of the entity two, different options are possible.
    /// If entity two is a cylinder this can be either kNoInferrence or kInferredLine. For kNoInferrence to be valid for a cylinder, entity one must also be a cylinder and they must be the same radius.
    /// If entity two is a sphere this can be either kNoInferrence or kInferredPoint. For kNoInferrence to be valid for a sphere, entity one must also be a sphere and they must be the same radius.
    /// If entity two is a cone this can be either kNoInferrence or kInferredLine. For kNoInferrence to be valid for a cone, entity one must also be a cone and they must have the same taper angle.
    /// If entity two is a torus this can be either kInferredLine or kInferredPoint.
    /// For a plane, only kNoInferrence is valid.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    MateConstraint ConvertToMateConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] InferredTypeEnum? EntityOneInferredType = InferredTypeEnum.kNoInference, [In] InferredTypeEnum? EntityTwoInferredType = InferredTypeEnum.kNoInference, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Method that converts the constraint to a rotate-rotate constraint, and returns the RotateRotateConstraint object. This method can also be used to edit the geometries associated with a rotate-rotate constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object and its rotation axis. The input object must be a planar Face, a revolved Face, a linear Edge, a WorkPlane, or a WorkAxis object. For planar objects the rotation axis is normal to the input face.</param>
    /// <param name="EntityTwo">Input object that defines the second object and its rotation axis. The input object must be a planar Face, a revolved Face, a linear Edge, a WorkPlane, or a WorkAxis object.</param>
    /// <param name="Ratio">Input Variant that defines the rotation ratio between the two input entities. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. The input value is unitless.</param>
    /// <param name="ForwardDirection">Input Boolean that defines the direction of rotation of the objects with respect to the axis direction. If the input value is True then both objects will rotate the same direction around their axes. If False, then they will rotate in opposite directions.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    RotateRotateConstraint ConvertToRotateRotateConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Ratio, [In] bool ForwardDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Method that converts the constraint to a rotate-translate constraint, and returns the RotateTranslateConstraint object. This method can also be used to edit the geometries associated with a rotate-translate constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object and its rotation axis. The input object must be a planar Face, a revolved Face, a linear Edge, a WorkPlane, or a WorkAxis object. For planar objects the rotation axis is normal to the input face.</param>
    /// <param name="EntityTwo">Input object that defines the second object and its translation axis. The input object must be a planar Face, a revolved Face, a linear Edge, a WorkPlane, or a WorkAxis object. For planar objects the translation axis is normal to the input face.</param>
    /// <param name="Ratio">Input Variant that defines the distance of translation for every revolution of the rotated occurrence. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="ForwardDirection">Input Boolean that defines the direction of translation with respect to the rotation direction relative to the axes directions. If the input value is True then when the rotation object is rotated in a positive direction about its axis, the translation object will move in the positive direction of its vector, If False, it will move in the negative direction.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    RotateTranslateConstraint ConvertToRotateTranslateConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Ratio, [In] bool ForwardDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Method that converts the constraint to a tangent constraint, and returns the TangentConstraint object. This method can also be used to edit the geometries associated with a tangent constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object.</param>
    /// <param name="EntityTwo">Input object that defines the second object. This object is a circular edge.</param>
    /// <param name="InsideTangency">Input Boolean that specifies the orientation of the surfaces at the tangent contact point of the surfaces.</param>
    /// <param name="Offset">Input Variant that defines the offset between the two input entities. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    TangentConstraint ConvertToTangentConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] bool InsideTangency, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Method that converts the constraint to a transitional constraint, and returns the TransitionalConstraint object. This method can also be used to edit the geometries associated with a transitional constraint without changing its type, in which case the same object is returned by the method.
    /// </summary>
    /// <param name="FaceOne">First input face that defines the initial face that is used in repositioning the parts. Once the constraint is placed it can move along any of the faces of the part.</param>
    /// <param name="FaceTwo">Second input face that defines the initial face that is used in repositioning the parts. Once the constraint is placed it can move along any of the faces of the part.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    TransitionalConstraint ConvertToTransitionalConstraint([In] [MarshalAs(UnmanagedType.Interface)] Face FaceOne, [In] [MarshalAs(UnmanagedType.Interface)] Face FaceTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntityOne">EntityOne</param>
    /// <param name="EntityTwo">EntityTwo</param>
    /// <param name="SymmetryPlane">SymmetryPlane</param>
    /// <param name="EntityOneInferredType">EntityOneInferredType</param>
    /// <param name="EntityTwoInferredType">EntityTwoInferredType</param>
    [PreserveSig]
    AssemblySymmetryConstraint _ConvertToSymmetryConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.IDispatch)] object SymmetryPlane, [In] InferredTypeEnum? EntityOneInferredType = InferredTypeEnum.kNoInference, [In] InferredTypeEnum? EntityTwoInferredType = InferredTypeEnum.kNoInference);
    /// <summary>
    /// Converts the constraint to a symmetry constraint, and returns the AssemblySymmetryConstraint object.
    /// </summary>
    /// <param name="EntityOne">Input entity that is to be symmetric.</param>
    /// <param name="EntityTwo">Input entity that is to be symmetric.</param>
    /// <param name="SymmetryPlane">Input planar entity that defines the symmetry plane. This can either be a planar face or a work plane.</param>
    /// <param name="EntityOneInferredType">Optional input constant that specifies how the geometry of entity one is to be interpreted. Depending on the geometry of the entity one, different options are possible.
    /// If entity one is a linear entity this can be either kNoInference or kInferredPoint, for kInferredPoint the mid-point of the linear entity is used for the constraint. If entity one is a circular/elliptical sketch entity, this can be either kInferredPiont or kInferredLine. If entity one is a cylindrical, elliptic-cylindrical, conical face this can be kNoInference or kInferredLine. If entity one is a toroidal face this can be either kInferredLine or kInferredPoint. If entity one is a spherical face this can be kInferredPoint. For a plane, only kNoInference is valid.</param>
    /// <param name="EntityTwoInferredType">Optional input enum that specifies how the geometry of entity two is to be interpreted. Depending on the geometry of the entity two, different options are possible. If entity two is a linear entity this can be either kNoInference or kInferredPoint, for kInferredPoint the mid-point of the linear entity is used for the constraint. If entity two is a circular/elliptical sketch entity, this can be either kInferredPiont or kInferredLine. If entity two is a cylindrical, elliptic-cylindrical, conical face this can be kNoInference or kInferredLine. If entity two is a toroidal face this can be either kInferredLine or kInferredPoint. If entity two is a spherical face this can be kInferredPoint. For a plane, only kNoInference is valid.</param>
    /// <param name="NormalsOpposed">This argument only applies when the two entities are planar (planar face or work plane) and defines if the normal of the planar entities are oriented so they are opposed or aligned.  If the input entities are not planar, this argument is ignored.  If they are planar and this argument is not specified they will defined to be opposed.</param>
    /// <returns></returns>
    [PreserveSig]
    AssemblySymmetryConstraint ConvertToSymmetryConstraint([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.IDispatch)] object SymmetryPlane, [In] InferredTypeEnum? EntityOneInferredType = InferredTypeEnum.kNoInference, [In] InferredTypeEnum? EntityTwoInferredType = InferredTypeEnum.kNoInference, [In] bool? NormalsOpposed = true);
    /// <summary>
    /// Converts the constraint to a mate constraint, and returns the MateConstraint object.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first geometry.</param>
    /// <param name="EntityTwo">Input object that defines the second geometry</param>
    /// <param name="Offset">Input Variant that defines the offset between the two input entities.  This can be either a numeric value or a string.  A parameter for this value is created and the supplied string or value is assigned to the parameter.  If a value is input, the units are centimeters.  If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="EntityOneInferredType">Optional input enum that specifies how the geometry of entity one is to be interpreted.  Depending on the geometry of the entity one, different options are possible.
    /// If entity one is a cylinder this can be either kNoInferrence or kInferredLine.  For kNoInferrence to be valid for a cylinder, entity two must also be a cylinder and they must be the same radius.
    /// If entity one is a sphere this can be either kNoInferrence or kInferredPoint.  For kNoInferrence to be valid for a sphere, entity two must also be a sphere and they must be the same radius.
    /// If entity one is a cone this can be either kNoInferrence or kInferredLine.  For kNoInferrence to be valid for a cone, entity two must also be a cone and they must have the same taper angle.
    /// If entity one is a torus this can be either kInferredLine or kInferredPoint.
    /// For a plane, only kNoInferrence is valid.</param>
    /// <param name="EntityTwoInferredType">Optional input enum that specifies how the geometry of entity two is to be interpreted.  Depending on the geometry of the entity two, different options are possible.
    /// If entity two is a cylinder this can be either kNoInferrence or kInferredLine.  For kNoInferrence to be valid for a cylinder, entity one must also be a cylinder and they must be the same radius.
    /// If entity two is a sphere this can be either kNoInferrence or kInferredPoint.  For kNoInferrence to be valid for a sphere, entity one must also be a sphere and they must be the same radius.
    /// If entity two is a cone this can be either kNoInferrence or kInferredLine.  For kNoInferrence to be valid for a cone, entity one must also be a cone and they must have the same taper angle.
    /// If entity two is a torus this can be either kInferredLine or kInferredPoint.
    /// For a plane, only kNoInferrence is valid.</param>
    /// <param name="SolutionType">Optional input MateConstraintSolutionTypeEnum that specifies the solution type for the mate constraint. If not provided this defaults to kOpposedSolutionType.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence.  The occurrences are repositioned in an attempt to make the two bias points coincident.  This provides some general control over the position of the occurrence when it isn’t being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint.  In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact.  Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence.  The occurrences are repositioned in an attempt to make the two bias points coincident.  This provides some general control over the position of the occurrence when it isn’t being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint.  In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact.  Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    MateConstraint ConvertToMateConstraint2([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] InferredTypeEnum? EntityOneInferredType = InferredTypeEnum.kNoInference, [In] InferredTypeEnum? EntityTwoInferredType = InferredTypeEnum.kNoInference, [In] MateConstraintSolutionTypeEnum? SolutionType = MateConstraintSolutionTypeEnum.kOpposedSolutionType, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
    /// <summary>
    /// Converts the constraint to an insert constraint, and returns the InsertConstraint object.
    /// </summary>
    /// <param name="EntityOne">Input object that defines the first object. This object is a circular edge.</param>
    /// <param name="EntityTwo">Input object that defines the second object. This object is a circular edge.</param>
    /// <param name="AxesOpposed">Input Boolean that specifies whether the direction of the axies of the input entities are in the same direction or opposed. A value of True indicates they are opposed.</param>
    /// <param name="Distance">Input Variant that defines the offset between the two input entities. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="LockRotation">Optional input Boolean that specifies whether to lock the rotation freedom or not.</param>
    /// <param name="BiasPointOne">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="BiasPointTwo">Optional input Point object that is used help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the two bias points coincident. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint.
    /// An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other.
    /// If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <returns></returns>
    [PreserveSig]
    InsertConstraint ConvertToInsertConstraint2([In] [MarshalAs(UnmanagedType.IDispatch)] object EntityOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object EntityTwo, [In] bool AxesOpposed, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.Struct)] object? LockRotation = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointOne = default, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPointTwo = default);
}
