using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButton : BaseButton
{
    protected override void OnClick()
    {
        UIManager.Instance.GetPanel(UIType.Setting).Show();
    }
}
