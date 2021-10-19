using System;

namespace UnityEngine
{
    /// <summary>
    /// Generic visual tile for creating different tilesets like terrain, pipeline, random or animated tiles.
    /// This is templated to accept a Neighbor Rule Class for Custom Rules.
    /// Use this for Isometric Grids. 
    /// </summary>
    /// <typeparam name="T">Neighbor Rule Class for Custom Rules</typeparam>
    public class IsometricRuleTile<T> : IsometricRuleTile
    {
        /// <summary>
        /// Returns the Neighbor Rule Class type for this Rule Tile.
        /// </summary>
        public sealed override Type m_NeighborType => typeof(T);
    }

    /// <summary>
    /// Generic visual tile for creating different tilesets like terrain, pipeline, random or animated tiles.
    /// Use this for Isometric Grids.
    /// </summary>
    [Serializable]
    [HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.tilemap.extras@latest/index.html?subfolder=/manual/RuleTile.html")]
    public class IsometricRuleTile : RuleTile
    {
        /// <summary>
        /// Isometric tile mirror in diagonal axis
        /// </summary>
        public override Vector3Int GetMirroredPosition(Vector3Int position, bool mirrorX, bool mirrorY)
        {
            if (mirrorX)
            {
                int tempx = position.x;
                position.x = position.y;
                position.y = tempx;
            }
            if (mirrorY)
            {
                int tempx = position.x;
                position.x = -position.y;
                position.y = -tempx;
            }
            return position;
        }
    }
}
