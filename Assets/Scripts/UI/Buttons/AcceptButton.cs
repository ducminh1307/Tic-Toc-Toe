using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptButton : BaseButton
{
    protected override void OnClick()
    {
        UIManager.Instance.GetPanel(UIType.InviteFriend).Hide();
    }
}
