/*==============================================================================
Copyright (c) 2012-2013 QUALCOMM Austria Research Center GmbH.
All Rights Reserved.
Qualcomm Confidential and Proprietary
==============================================================================*/


public class MultiTargetImpl : TrackableImpl, MultiTarget
{
    public MultiTargetImpl(string name, int id)
        : base(name, id)
    {
        Type = TrackableType.MULTI_TARGET;
    }
}