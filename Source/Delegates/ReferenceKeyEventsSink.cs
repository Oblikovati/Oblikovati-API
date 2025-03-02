namespace Oblikovati.API;

public delegate void ReferenceKeyEventsSink_OnBindKeyToObjectEventHandler(ref byte[] ReferenceKey, object Document,ref object Object,out SolutionNatureEnum MatchType, NameValueMap Context,ref HandlingCodeEnum HandlingCode);
