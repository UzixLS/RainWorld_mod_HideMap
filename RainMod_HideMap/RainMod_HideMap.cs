using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Partiality.Modloader;
using UnityEngine;

public class RainMod_HideMap : PartialityMod
{
    public RainMod_HideMap()
    {
        this.ModID = "RainMod_HideMap";
        this.Version = "0100";
        this.author = "Uzix";
    }

    public static RainMod_HideMap instance;

    public override void OnEnable()
    {
        base.OnEnable();
        //Hooks go here
        HideMap.Patch();
    }
}
