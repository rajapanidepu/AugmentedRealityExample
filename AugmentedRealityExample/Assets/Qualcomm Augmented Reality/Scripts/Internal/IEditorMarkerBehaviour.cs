/*==============================================================================
Copyright (c) 2012-2013 QUALCOMM Austria Research Center GmbH.
All Rights Reserved.
Qualcomm Confidential and Proprietary
==============================================================================*/

// The editor interface for MarkerBehaviours
// to be implemented explicitly by behaviours
public interface IEditorMarkerBehaviour:IEditorTrackableBehaviour
{
    #region EDITOR_INTERFACE
    
    int MarkerID { get; }
    bool SetMarkerID(int markerID);
    void InitializeMarker(Marker marker);

    #endregion // EDITOR_INTERFACE
}