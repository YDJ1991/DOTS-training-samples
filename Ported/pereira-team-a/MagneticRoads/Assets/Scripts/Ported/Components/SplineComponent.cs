﻿using System;
using Unity.Entities;
using Unity.Mathematics;

[WriteGroup(typeof(Unity.Transforms.LocalToWorld))]
public struct SplineComponent : IComponentData
{
    public SplineBufferElementData Spline;
    public bool IsInsideIntersection;
    public float t;
    public float splineSide;
    public int splineId;
}