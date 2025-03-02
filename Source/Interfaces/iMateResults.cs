namespace Oblikovati.API;

/// <summary>
/// The iMateResults collection provides access to all of the objects in an assembly. It also supports the methods that allow the creation of iMateResult objects.
/// </summary>
public interface iMateResults : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns the specified iMateResult object from the collection.
    /// </summary>
    iMateResult Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new iMate result. The newly created iMateResult object is returned. If the two inputs do not define a valid iMateResult the method will fail.
    /// </summary>
    /// <param name="iMateDefinition">Input object that defines the input iMate.</param>
    /// <param name="Entity">Input object that defines the second entity. This object must be a valid geometric entity in the assembly, such as a , WorkAxis, SketchLine, etc.</param>
    /// <param name="EntityBiasPoint">Optional input object that is used to help in determining the initial position of the occurrence. The occurrences are repositioned in an attempt to make the bias point coincident with the iMate. This provides some general control over the position of the occurrence when it isn't being controlled by another constraint. An example of when the bias points are useful is the case when the first constraint on a part is a mate constraint. In the case where the mate is between two planes, the parts can be positioned anywhere along the infinite plane that defines their mating contact. Using the bias point you can define the position of the two occurrences, relative to each other. If a bias point is not given, one is calculated that is at the center of the parameter range of the input entity.</param>
    /// <param name="AngleEntityReversed">Optional input Boolean that is only used when creating an angle constraint. This argument specifies if the direction of the entity should be reversed or not. A value of True indicates it should be reversed. If this argument is not provided for an angle constraint it defaults to False. This argument is ignored for all other constraint types.</param>
    /// <returns></returns>
    [PreserveSig]
    iMateResult AddByiMateAndEntity([In] [MarshalAs(UnmanagedType.Interface)] iMateDefinition iMateDefinition, [In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object? EntityBiasPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? AngleEntityReversed = default);
    /// <summary>
    /// Method that creates a new iMate result. The newly created iMateResult object is returned.
    /// </summary>
    /// <param name="iMateDefinitionOne">Input object that defines the first input iMate.</param>
    /// <param name="iMateDefinitionTwo">Input object that defines the second input iMate.</param>
    /// <returns></returns>
    [PreserveSig]
    iMateResult AddByTwoiMates([In] [MarshalAs(UnmanagedType.Interface)] iMateDefinition iMateDefinitionOne, [In] [MarshalAs(UnmanagedType.Interface)] iMateDefinition iMateDefinitionTwo);
}
