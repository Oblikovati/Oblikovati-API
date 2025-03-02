namespace Oblikovati.API;

/// <summary>
/// The DrawingViews collection object provides access to the objects associated with the sheet the collection was obtained from. It also provides method to create new drawing views.
/// </summary>
public interface DrawingViews : IEnumerable
{
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    DrawingView Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Model">Model</param>
    /// <param name="Position">Position</param>
    /// <param name="Scale">Scale</param>
    /// <param name="ViewOrientation">ViewOrientation</param>
    /// <param name="ViewStyle">ViewStyle</param>
    /// <param name="ModelViewName">ModelViewName</param>
    /// <param name="ArbitraryCamera">ArbitraryCamera</param>
    /// <param name="AdditionalOptions">AdditionalOptions</param>
    [PreserveSig]
    DrawingView AddBaseView([In] [MarshalAs(UnmanagedType.Interface)] _Document Model, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] double Scale, [In] ViewOrientationTypeEnum ViewOrientation, [In] DrawingViewStyleEnum ViewStyle, [In] [MarshalAs(UnmanagedType.BStr)] string? ModelViewName = "", [In] [MarshalAs(UnmanagedType.Struct)] object? ArbitraryCamera = default, [In] [MarshalAs(UnmanagedType.Struct)] object? AdditionalOptions = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ParentView">ParentView</param>
    /// <param name="Position">Position</param>
    /// <param name="ViewOrientation">ViewOrientation</param>
    /// <param name="ViewStyle">ViewStyle</param>
    /// <param name="Scale">Scale</param>
    [PreserveSig]
    DrawingView _AddProjectedView([In] [MarshalAs(UnmanagedType.Interface)] DrawingView ParentView, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] ViewOrientationTypeEnum ViewOrientation, [In] DrawingViewStyleEnum ViewStyle, [In] [MarshalAs(UnmanagedType.Struct)] object? Scale = default);
    /// <summary>
    /// Method that creates a projected .
    /// </summary>
    /// <param name="ParentView">Input object that specifies the base parent view of the projected view.</param>
    /// <param name="Position">Input Point2d that specifies the placement point of the view on the sheet.</param>
    /// <param name="ViewStyle">Input DrawingViewStyleEnum the specifies the display style of the geometry within the view.</param>
    /// <param name="Scale">Optional input Variant that specifies the drawing view scale factor. If this argument is not specified, the scale is derived from the ParentView.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingView AddProjectedView([In] [MarshalAs(UnmanagedType.Interface)] DrawingView ParentView, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] DrawingViewStyleEnum ViewStyle, [In] [MarshalAs(UnmanagedType.Struct)] object? Scale = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Model">Model</param>
    /// <param name="Position">Position</param>
    /// <param name="Scale">Scale</param>
    /// <param name="Name">Name</param>
    [PreserveSig]
    DrawingView AddAssociativeDraftView([In] [MarshalAs(UnmanagedType.Interface)] _Document Model, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] double? Scale = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates a new draft . The newly created DrawingView is returned.
    /// </summary>
    /// <param name="Scale">Optional input Double that specifies the drawing view scale factor. If not specified, a default value of 1.0 is used.</param>
    /// <param name="Name">Optional input String that defines the editable portion of the drawing view name that is displayed within the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingView AddDraftView([In] double? Scale = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates a section drawing view.
    /// </summary>
    /// <param name="ParentView">Input DrawingView object that specifies the base parent view of the projected view.</param>
    /// <param name="SectionLineSketch">Input DrawingSketch object that contains the profile that will be used to define the section line of the view. The DrawingSketch should be associated with the parent DrawingView (i.e. from parent DrawingView.Sketches). The choice between the projected and aligned methods is made automatically based on the following rules. The method can be changed after creation using SectionDrawingView.UseAlignedMethod property.
    /// One line - Full Section View - Projected method
    /// Two perpendicular lines - Half Section View - Projected method
    /// Two non-perpendicular lines - Aligned Section View
    /// Three or more lines - Offset Section View - Projected method</param>
    /// <param name="Position">Input Point2d that specifies the placement point of the view on the sheet.</param>
    /// <param name="ViewStyle">Input DrawingViewStyleEnum the specifies the display style of the geometry within the view.</param>
    /// <param name="Scale">Optional input Double that specifies the drawing view scale factor. If this argument is not specified, the scale is derived from the ParentView.</param>
    /// <param name="ShowLabel">Optional input Boolean that specifies whether to display or hide the view label. The default is True indicating that the label will be displayed.</param>
    /// <param name="Name">Optional input String that defines the editable portion of the drawing view name that is displayed within the browser.</param>
    /// <param name="Reserved">Optional input Boolean reserved for future use.</param>
    /// <param name="FullDepth">Optional input Boolean that specifies whether to use full section depth. A value of True indicates full section depth. If False, the SectionDepth argument needs to be supplied.</param>
    /// <param name="SectionDepth">Input Variant that defines the section depth. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    SectionDrawingView AddSectionView([In] [MarshalAs(UnmanagedType.Interface)] DrawingView ParentView, [In] [MarshalAs(UnmanagedType.Interface)] DrawingSketch SectionLineSketch, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] DrawingViewStyleEnum ViewStyle, [In] [MarshalAs(UnmanagedType.Struct)] object? Scale = default, [In] bool? ShowLabel = true, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] bool? Reserved = true, [In] bool? FullDepth = true, [In] [MarshalAs(UnmanagedType.Struct)] object? SectionDepth = default);
    /// <summary>
    /// Method that creates a detail drawing view. This method fails if the parent sheet is not active.
    /// </summary>
    /// <param name="ParentView">DrawingView object that specifies the base parent view of the projected view.</param>
    /// <param name="Position">Input Point2d that specifies the placement point of the view on the sheet.</param>
    /// <param name="ViewStyle">DrawingViewStyleEnum the specifies the display style of the geometry within the view.</param>
    /// <param name="CircularFence">Boolean that specifies whether to use a circular fence or a rectangular fence. Specify True for circular and False for rectangular.</param>
    /// <param name="FenceCenterOrCornerOne">Point2d object that specifies the center point for a circular fence or the first corner for a rectangular fence.</param>
    /// <param name="FenceRadiusOrCornerTwo">Specifies the radius of a circular fence or input Point2d object that specifies the second corner for a rectangular fence.</param>
    /// <param name="AttachPoint">Optional input GeometryIntent object that specifies the geometry to attach the detail view to. If not specified, the detail view is unattached and can be moved around.</param>
    /// <param name="Scale">Optional input Double that specifies the drawing view scale factor. If this argument is not specified, the scale is derived from the ParentView.</param>
    /// <param name="ShowLabel">Optional input Boolean that specifies whether to display or hide the view label. The default is True indicating that the label will be displayed.</param>
    /// <param name="Name">Optional input String that defines the editable portion of the drawing view name that is displayed within the browser.</param>
    /// <param name="Reserved">Optional input Boolean reserved for future use.</param>
    /// <returns></returns>
    [PreserveSig]
    DetailDrawingView AddDetailView([In] [MarshalAs(UnmanagedType.Interface)] DrawingView ParentView, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] DrawingViewStyleEnum ViewStyle, [In] bool CircularFence, [In] [MarshalAs(UnmanagedType.Interface)] Point2d FenceCenterOrCornerOne, [In] [MarshalAs(UnmanagedType.Struct)] object FenceRadiusOrCornerTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? AttachPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Scale = default, [In] bool? ShowLabel = true, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] bool? Reserved = true);
    /// <summary>
    /// Method that creates an auxiliary drawing view.
    /// </summary>
    /// <param name="ParentView">Input DrawingView object that specifies the parent view of the auxiliary view.</param>
    /// <param name="OrientationEdge">Input DrawingCurve object that specifies the orientation of the auxiliary view. This must be a linear DrawingCurve from the parent view, else the method returns an error.</param>
    /// <param name="Position">Input Point2d that specifies the placement point of the view on the sheet.</param>
    /// <param name="ViewStyle">Input DrawingViewStyleEnum the specifies the display style of the geometry within the view. Valid values are kHiddenLineDrawingViewStyle, kHiddenLineRemovedDrawingViewStyle, kShadedDrawingViewStyle, kShadedHiddenLineDrawingViewStyle and kFromBaseDrawingViewStyle.</param>
    /// <param name="Scale">Optional input that specifies the drawing view scale factor. This can be either specified as a Double or a String.
    /// Examples: 2.0, "5:1", "1/2", etc.
    /// If this argument is not specified, the scale is derived from the ParentView.</param>
    /// <param name="ShowLabel">Optional input Boolean that specifies whether to display or hide the view label. The default is True indicating that the label will be displayed.</param>
    /// <param name="Name">Optional input String that defines the editable portion of the drawing view name that is displayed within the browser.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingView AddAuxiliaryView([In] [MarshalAs(UnmanagedType.Interface)] DrawingView ParentView, [In] [MarshalAs(UnmanagedType.Interface)] DrawingCurve OrientationEdge, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] DrawingViewStyleEnum ViewStyle, [In] [MarshalAs(UnmanagedType.Struct)] object? Scale = default, [In] bool? ShowLabel = true, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates an overlay drawing view.
    /// </summary>
    /// <param name="ParentView">Input DrawingView object that specifies the parent view of the overlay view. The parent view must be a base view, projected view or an auxiliary view of an assembly, else the method returns an error.</param>
    /// <param name="PositionalRepresentation">Input String that specifies the positional representation to use for the overlay view. The input string must the name of an existing position representation in the assembly referenced by the parent view. The method returns a failure if a representation with this name is not found in the referenced assembly.</param>
    /// <param name="DesignViewRepresentation">Input String that specifies the design view representation to use for the overlay view. The input string must the name of an existing design view representation in the assembly referenced by the parent view. In addition, 'Nothing Visible' and 'All Visible' can also be provided. The method returns a failure if a representation with this name is not found in the referenced assembly.</param>
    /// <param name="DesignViewAssociative">Input Boolean that indicates whether to associatively apply the design view representation. If set to True, any changes to the design view in the referenced assembly will show in this view.</param>
    /// <param name="ViewStyle">Input DrawingViewStyleEnum the specifies the display style of the geometry within the view. Valid values are kHiddenLineDrawingViewStyle, kHiddenLineRemovedDrawingViewStyle, kShadedDrawingViewStyle, kShadedHiddenLineDrawingViewStyle and kFromBaseDrawingViewStyle.</param>
    /// <param name="ShowLabel">Optional input Boolean that specifies whether to display or hide the view label. The default is True indicating that the label will be displayed.</param>
    /// <param name="Name">Optional input String that defines the editable portion of the drawing view name that is displayed within the browser. If not specified, the name of the input positional representation is used.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingView AddOverlayView([In] [MarshalAs(UnmanagedType.Interface)] DrawingView ParentView, [In] [MarshalAs(UnmanagedType.BStr)] string PositionalRepresentation, [In] [MarshalAs(UnmanagedType.BStr)] string DesignViewRepresentation, [In] bool DesignViewAssociative, [In] DrawingViewStyleEnum ViewStyle, [In] bool? ShowLabel = true, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Method that creates an overlay drawing view.
    /// </summary>
    /// <param name="ParentView">Input DrawingView object that specifies the parent view of the overlay view.  The parent view must be a base view, projected view or an auxiliary view of an assembly, else the method returns an error.</param>
    /// <param name="ModelState">Input String that specifies the model state to use for the overlay view. The input string must the name of an existing model state in the assembly referenced by the parent view.  The method returns a failure if a model state with this name is not found in the referenced assembly.</param>
    /// <param name="PositionalRepresentation">Input String that specifies the positional representation to use for the overlay view. The input string must the name of an existing position representation in the assembly referenced by the parent view.  The method returns a failure if a representation with this name is not found in the referenced assembly.</param>
    /// <param name="DesignViewRepresentation">Input String that specifies the design view representation to use for the overlay view. The input string must the name of an existing design view representation in the assembly referenced by the parent view.  In addition, “Nothing Visible” and “All Visible” can also be provided.  The method returns a failure if a representation with this name is not found in the referenced assembly.</param>
    /// <param name="DesignViewAssociative">Input Boolean that indicates whether to associatively apply the design view representation.  If set to True, any changes to the design view in the referenced assembly will show in this view.</param>
    /// <param name="ViewStyle">Input DrawingViewStyleEnum the specifies the display style of the geometry within the view.  Valid values are kHiddenLineDrawingViewStyle, kHiddenLineRemovedDrawingViewStyle, kShadedDrawingViewStyle, kShadedHiddenLineDrawingViewStyle and kFromBaseDrawingViewStyle.</param>
    /// <param name="ShowLabel">Optional input Boolean that specifies whether to display or hide the view label.  The default is True indicating that the label will be displayed.</param>
    /// <param name="Name">Optional input String that defines the editable portion of the drawing view name that is displayed within the browser.  If not specified, the name of the input positional representation is used.</param>
    /// <returns></returns>
    [PreserveSig]
    DrawingView AddOverlayView2([In] [MarshalAs(UnmanagedType.Interface)] DrawingView ParentView, [In] [MarshalAs(UnmanagedType.BStr)] string ModelState, [In] [MarshalAs(UnmanagedType.BStr)] string PositionalRepresentation, [In] [MarshalAs(UnmanagedType.BStr)] string DesignViewRepresentation, [In] bool DesignViewAssociative, [In] DrawingViewStyleEnum ViewStyle, [In] bool? ShowLabel = true, [In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Model">Model</param>
    /// <param name="Position">Position</param>
    /// <param name="Scale">Scale</param>
    /// <param name="ViewOrientation">ViewOrientation</param>
    /// <param name="ViewStyle">ViewStyle</param>
    /// <param name="ViewFileName">ViewFileName</param>
    /// <param name="ViewName">ViewName</param>
    /// <param name="ArbitraryCamera">ArbitraryCamera</param>
    /// <param name="AdditionalOptions">AdditionalOptions</param>
    [PreserveSig]
    DrawingView _AddBaseView([In] [MarshalAs(UnmanagedType.Interface)] _Document Model, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] double Scale, [In] ViewOrientationTypeEnum ViewOrientation, [In] DrawingViewStyleEnum ViewStyle, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewFileName = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ViewName = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ArbitraryCamera = default, [In] [MarshalAs(UnmanagedType.Struct)] object? AdditionalOptions = default);
}
