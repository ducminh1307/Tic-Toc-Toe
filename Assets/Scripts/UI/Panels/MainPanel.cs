using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanel : BasePanel
{
    protected override void Awake()
    {
        PanelType = UIType.Main;
        base.Awake();
    }

    public override void OnAwake()
    {
        
    }
}
