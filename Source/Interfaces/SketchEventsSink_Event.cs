namespace Oblikovati.API;

public interface SketchEventsSink_Event
{
    event SketchEventsSink_OnNewSketchEventHandler OnNewSketch;
    event SketchEventsSink_OnSketchChangeEventHandler OnSketchChange;
    event SketchEventsSink_OnNewSketch3DEventHandler OnNewSketch3D;
    event SketchEventsSink_OnSketch3DChangeEventHandler OnSketch3DChange;
    event SketchEventsSink_OnSketch3DSolveEventHandler OnSketch3DSolve;
    event SketchEventsSink_OnDeleteEventHandler OnDelete;
}
