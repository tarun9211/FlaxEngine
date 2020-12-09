// Copyright (c) 2012-2020 Wojciech Figat. All rights reserved.

using FlaxEngine;

namespace FlaxEditor.Gizmo
{
    /// <summary>
    /// Describes objects that can own gizmo tools.
    /// </summary>
    [HideInEditor]
    public interface IGizmoOwner
    {
        /// <summary>
        /// Gets the gizmos collection.
        /// </summary>
        GizmosCollection Gizmos { get; }

        /// <summary>
        /// Gets the render task used by the owner to render the scene and the gizmos.
        /// </summary>
        SceneRenderTask RenderTask { get; }

        /// <summary>
        /// Gets a value indicating whether left mouse button is pressed down.
        /// </summary>
        bool IsLeftMouseButtonDown { get; }

        /// <summary>
        /// Gets a value indicating whether right mouse button is pressed down.
        /// </summary>
        bool IsRightMouseButtonDown { get; }

        /// <summary>
        /// Gets a value indicating whether Alt key is pressed down.
        /// </summary>
        bool IsAltKeyDown { get; }

        /// <summary>
        /// Gets a value indicating whether Control key is pressed down.
        /// </summary>
        bool IsControlDown { get; }

        /// <summary>
        /// Gets a value indicating whether snap selected objects to ground (check if user pressed the given input key to call action).
        /// </summary>
        bool SnapToGround { get; }

        /// <summary>
        /// Gets the view forward direction.
        /// </summary>
        Vector3 ViewDirection { get; }

        /// <summary>
        /// Gets the view position.
        /// </summary>
        Vector3 ViewPosition { get; }

        /// <summary>
        /// Gets the view orientation.
        /// </summary>
        Quaternion ViewOrientation { get; }

        /// <summary>
        /// Gets the view far clipping plane.
        /// </summary>
        float ViewFarPlane { get; }

        /// <summary>
        /// Gets the mouse ray (in world space of the viewport).
        /// </summary>
        Ray MouseRay { get; }

        /// <summary>
        /// Gets the mouse movement delta.
        /// </summary>
        Vector2 MouseDelta { get; }

        /// <summary>
        /// Gets a value indicating whether use grid snapping during gizmo operations.
        /// </summary>
        bool UseSnapping { get; }

        /// <summary>
        /// Gets a value indicating whether duplicate objects during gizmo operation (eg. when transforming).
        /// </summary>
        bool UseDuplicate { get; }

        /// <summary>
        /// Gets a <see cref="FlaxEditor.Undo"/> object used by the gizmo owner.
        /// </summary>
        Undo Undo { get; }
    }
}