namespace Oblikovati.API;

/// <summary>
/// The iMateDefinitions collection provides access to all of the objects in a part or assembly.
/// </summary>
public interface iMateDefinitions : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified iMateDefinition object from the collection.
    /// </summary>
    iMateDefinition Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new angle iMate definition. The newly created AngleiMateDefinition object is returned.
    /// </summary>
    /// <param name="Entity">Object that defines the entity. This object can be a planar face, work plane, linear edge, work axis, or a face that defines an axis.</param>
    /// <param name="DirectionReversed">Boolean that specifies whether to reverse the direction of the entity.</param>
    /// <param name="Angle">Defines the angle value. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are radians. If a string is input the units can be specified as part of the string or will default to the current angle units of the document.</param>
    /// <param name="BiasPoint">Point object that is used to help determine the initial position when this iMate definition is used. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="Name">String that specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    AngleiMateDefinition AddAngleiMateDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] bool DirectionReversed, [In] [MarshalAs(UnmanagedType.Struct)] object Angle, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
    /// <summary>
    /// Method that creates a new composite iMate definition. The newly created CompositeiMateDefinition object is returned. When iMate definition objects are used as input for a composite iMate, the iMateDefinition objects are no longer directly accessible through the iMateDefinitions collection. They are only accessible through the CompositeiMateDefinition object.
    /// </summary>
    /// <param name="iMates">Contains the iMates that are used as input for the composite iMate. The collection must contain only iMateDefinition objects. It will fail if any other object types are input or if any of the objects are a CompositeiMateDefinition object.</param>
    /// <param name="Name">Specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    CompositeiMateDefinition AddCompositeiMateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection iMates, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
    /// <summary>
    /// Method that creates a new flush iMate definition. The newly created FlushiMateDefinition object is returned.
    /// </summary>
    /// <param name="Entity">Object that defines the entity. The input object must be either a planar Face object or WorkPlane object.</param>
    /// <param name="Offset">Defines the offset value. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="BiasPoint">Point object that is used to help determine the initial position when this iMate definition is used. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="Name">String that specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    FlushiMateDefinition AddFlushiMateDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
    /// <summary>
    /// Method that creates a new mate iMate definition.
    /// </summary>
    /// <param name="Entity">Defines the entity to mate.</param>
    /// <param name="Offset">Defines the offset value. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="EntityInferredType">Enum that specifies how the geometry of the entity is to be interpreted. Depending on the geometry of the entity, different options are possible. If the entity is a cylinder this can be either kNoInferrence or kInferredLine. For kNoInferrence to be valid for a cylinder, the matching iMate must also be on a cylinder and they must be the same radius. If the entity is a sphere this can be either kNoInferrence or kInferredPoint. For kNoInferrence to be valid for a sphere, the matching iMate must also be on a sphere and they must be the same radius. If the entity is a cone this can be either kNoInferrence or kInferredLine. For kNoInferrence to be valid for a cone, the matching iMate must also be on a cone and they must have the same taper angle. If the entity is a torus this can be either kInferredLine or kInferredPoint. For a plane, only kNoInferrence is valid.</param>
    /// <param name="BiasPoint">Point object that is used to help determine the initial position when this iMate definition is used. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="Name">Specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    MateiMateDefinition AddMateiMateDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] InferredTypeEnum? EntityInferredType = InferredTypeEnum.kNoInference, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
    /// <summary>
    /// Method that creates a new insert iMate definition. The newly created InsertiMateDefinition object is returned.
    /// </summary>
    /// <param name="Entity">Object that defines the entity. This object must be a circular edge.</param>
    /// <param name="AxesOpposed">Specifies whether the direction of the axis of the input entities are in the same direction or opposed. A value of True indicates they are opposed.</param>
    /// <param name="Distance">Defines the offset value. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="BiasPoint">Used to help determine the initial position when this iMate definition is used. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="Name">Specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    InsertiMateDefinition AddInsertiMateDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] bool AxesOpposed, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
    /// <summary>
    /// Method that creates a new rotation motion iMate definition.
    /// </summary>
    /// <param name="Entity">Defines the entity and it rotation axis. The input object must be a planar Face, a revolved Face, a linear Edge, a WorkPlane, or a WorkAxis object. For planar objects the rotation axis is normal to the input face.</param>
    /// <param name="Ratio">Defines the rotation ratio value. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. The input value is unitless.</param>
    /// <param name="ForwardDirection">Defines the direction of rotation of the objects with respect to the axis direction. If the input value is True then both objects will rotate the same direction around their axes. If False, then they will rotate in opposite directions.</param>
    /// <param name="BiasPoint">Point object that is used to help determine the initial position when this iMate definition is used. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="Name">Specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    RotateRotateiMateDefinition AddRotateRotateiMateDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object Ratio, [In] bool ForwardDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
    /// <summary>
    /// Method that creates a new rotate-translate motion iMate definition.
    /// </summary>
    /// <param name="Entity">Defines the entity and its rotation axis. The input object must be a planar Face, a revolved Face, a linear Edge, a WorkPlane, or a WorkAxis object. For planar objects the rotation axis is normal to the input face.</param>
    /// <param name="Ratio">Input Variant that defines the distance of translation for every revolution of the rotated occurrence. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="ForwardDirection">Defines the direction of translation with respect to the rotation direction relative to the axes directions. If the input value is True then when the rotation object is rotated in a positive direction about its axis, the translation object will move in the positive direction of its vector, If False, it will move in the negative direction.</param>
    /// <param name="BiasPoint">Point object that is used to help determine the initial position when this iMate definition is used. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="Name">Specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    RotateTranslateiMateDefinition AddRotateTranslateiMateDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object Ratio, [In] bool ForwardDirection, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
    /// <summary>
    /// Method that creates a new tangent iMate definition.
    /// </summary>
    /// <param name="Entity">Defines the entity to use for the tangency.</param>
    /// <param name="InsideTangency">Specifies the orientation of the surfaces at the tangent contact point of the surfaces.</param>
    /// <param name="Offset">Defines the offset value. This can be either a numeric value or a string. A parameter for this value is created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input the units can be specified as part of the string or will default to the current length units of the document.</param>
    /// <param name="BiasPoint">Point object that is used to help determine the initial position when this iMate definition is used. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias points you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="Name">Specifies the name of the iMate definition. If not specified, a name is automatically generated.</param>
    /// <param name="MatchList">Array of Strings that specifies the priority order of the iMate definitions to match.</param>
    /// <returns></returns>
    [PreserveSig]
    TangentiMateDefinition AddTangentiMateDefinition([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] bool InsideTangency, [In] [MarshalAs(UnmanagedType.Struct)] object Offset, [In] [MarshalAs(UnmanagedType.Struct)] object? BiasPoint = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? MatchList = default);
}
