using System;

namespace TEdit.RenderWorld
{
    [Flags]
    public enum FramePlacement
    {
        None        = 0x00,
        
        Floor       = 0x01,
        Surface     = 0x02,
        Ceiling     = 0x04,
        Wall        = 0x08,
        Float       = 0x10,
        MustHaveAll = 0x20,

        FloorSurface        = Floor | Surface,
        FloorCeiling        = Floor | Ceiling,          // currently not encountered in Terraria
        FloorSurfaceCeiling = FloorSurface | Ceiling,   // currently not encountered in Terraria
        WallCeiling         = Wall  | Ceiling,          // currently not encountered in Terraria
        WallFloor           = Wall  | Floor,
        WallFloorCeiling    = Wall  | FloorCeiling,
        WallFloorSurface    = Wall  | FloorSurface,     // currently not encountered in Terraria

        AnySurface = WallFloorCeiling | Surface,        // currently not encountered in Terraria
        Any        = AnySurface       | Float,
        CFBoth     = FloorCeiling     | MustHaveAll,

        All              = Any              | MustHaveAll  // only used as a bitwise tautology/disjunction
    }
}
