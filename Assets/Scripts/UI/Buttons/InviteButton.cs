using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InviteButton : BaseButton
{
    protected override void OnClick()
    {
        UIManager.Instance.GetPanel(UIType.InviteFriend).Show();
    }
}
