using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWCustom;

public class HideMap
{
    public static void Patch()
    {
        On.HUD.Map.Update += Map_Update;
    }

    private static void Map_Update(On.HUD.Map.orig_Update orig, HUD.Map self)
    {
        orig.Invoke(self);
        self.visible = false;
    }
}
