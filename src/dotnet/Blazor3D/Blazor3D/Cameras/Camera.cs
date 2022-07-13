﻿using Blazor3D.Core;

namespace Blazor3D.Cameras
{
    /// <summary>
    /// <para>Abstract base class for cameras.</para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/cameras/Camera">Camera</a></para>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public abstract class Camera : Object3D
    {
        protected Camera(string type = "Camera") : base(type)
        {
        }
    }
}
