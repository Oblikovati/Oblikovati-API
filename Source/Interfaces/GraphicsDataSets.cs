namespace Oblikovati.API;

/// <summary>
/// The GrahicsDataSets object supports methods to create the various graphics-related data objects.
/// </summary>
public interface GraphicsDataSets : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returns the parent of this object.
    /// </summary>
    GraphicsDataSetsCollection Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of GraphicDataSet objects in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    GraphicsDataSet this[int Index] { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    GraphicsDataSet ItemById { get; }
    /// <summary>
    /// Property that returns the unique identifier for the GraphicsDataSets object. The ClientId is assigned during the creation of the GraphicsDataSets object. Typically, it is a GUID in string form, but any string is valid.
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Property that returns whether to save the GraphicsDataSets with the document.
    /// </summary>
    bool SaveWithDocument { get; }
    /// <summary>
    /// Read-only property that returns whether the creation of this GraphicsDataSets object and all its associated data is non-transacting.
    /// </summary>
    bool NonTransacting { get; }
    /// <summary>
    /// Method that creates a new GraphicsCoordinateSet object. You use methods provided by the CoordinateSet object to define the coordinates.
    /// </summary>
    /// <param name="DataSetId">Input Long that specifies the unique identifier for the GraphicsDataSet object. This must be unique with respect to all other GraphicsDataSet objects within this GraphicsDataSets object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsCoordinateSet CreateCoordinateSet([In] int DataSetId);
    /// <summary>
    /// Method that creates a new GraphicsImageSet object. You use methods provided by the GraphicsImageSet object to define the images.
    /// </summary>
    /// <param name="DataSetId">Specifies the unique identifier for the GraphicsImageSet object. This must be unique with respect to all other GraphicsDataSet objects within this GraphicDataSets collection object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsImageSet CreateImageSet([In] int DataSetId);
    /// <summary>
    /// Method that creates a new GraphicsNormalSet object. You use methods provided by the NormalSet object to define the normal vectors.
    /// </summary>
    /// <param name="DataSetId">Input Long that specifies the unique identifier for the GraphicsDataSet object. This must be unique with respect to all other GraphicsDataSet objects within this GraphicsDataSets object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsNormalSet CreateNormalSet([In] int DataSetId);
    /// <summary>
    /// Method that creates a new GraphicsColorSet object. You use methods provided by the ColorSet object to define the colors.
    /// </summary>
    /// <param name="DataSetId">Input Long that specifies the unique identifier for the GraphicsDataSet object. This must be unique with respect to all other GraphicsDataSet objects within this GraphicsDataSets object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsColorSet CreateColorSet([In] int DataSetId);
    /// <summary>
    /// Method that creates a new GraphicsIndexSet object. You use methods provided by the GraphicsIndexSet object to define the indices.
    /// </summary>
    /// <param name="DataSetId">Input Long that specifies the unique identifier for the GraphicsDataSet object. This must be unique with respect to all other GraphicsDataSet objects within this GraphicsDataSets object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsIndexSet CreateIndexSet([In] int DataSetId);
    /// <summary>
    /// Method that deletes the GraphicsDataSets object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that creates a new GraphicsTextureCoordinateSet object. You use methods provided by the GraphicsTextureCoordinateSet object to define the coordinates.
    /// </summary>
    /// <param name="DataSetId">Specifies the unique identifier for the GraphicsTextureCoordinateSet object. This must be unique with respect to all other GraphicsDataSet objects within this GraphicDataSets collection object.</param>
    /// <returns></returns>
    [PreserveSig]
    GraphicsTextureCoordinateSet CreateTextureCoordinateSet([In] int DataSetId);
    /// <summary>
    /// Method that creates a new GraphicsColorMapper object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    GraphicsColorMapper CreateColorMapper();
}
