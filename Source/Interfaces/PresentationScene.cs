namespace Oblikovati.API;

/// <summary>
/// PresentationScene object.
/// </summary>
public interface PresentationScene
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    _PresentationDocument Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the presentation scene name.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Read-only property that returns active presentation snapshot view.
    /// </summary>
    PresentationSnapshotView ActiveSnapshotView { get; }
    /// <summary>
    /// Read-only property that returns PresentationSnapshotViews collection object.
    /// </summary>
    PresentationSnapshotViews SnapshotViews { get; }
    /// <summary>
    /// Read-only property that returns the top PresentationComponent object in the presentation scene.
    /// </summary>
    PresentationComponent TopSceneComponent { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the publication design view is associative or not.
    /// </summary>
    bool DesignViewAssociative { get; set; }
    /// <summary>
    /// Read-only property that gets the GraphicsDataSetsCollection.
    /// </summary>
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    /// <summary>
    /// Read-only property that gets the ClientGraphicsCollection.
    /// </summary>
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    /// <summary>
    /// Method that makes this presentation scene the active one.
    /// </summary>
    [PreserveSig]
    void Activate();
}
