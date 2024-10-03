using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FriendPanel : BasePanel
{
    [SerializeField] private RectTransform friendPanel;
    protected override void Awake()
    {
        PanelType = UIType.Friend;
        base.Awake();
    }

    public override void OnAwake()
    {
        // friendPanel.localScale = Vector3.zero;
        base.OnAwake();
    }

    public override void Show()
    {
        base.Show();
        // friendPanel.DOScale(Vector3.one, .2f)
        //     .SetEase(UIManager.Instance.Transition);
    }

    public override void Hide()
    {
        // friendPanel.DOScale(Vector3.zero, .2f)
        //     .SetEase(UIManager.Instance.Transition)
        //     .OnComplete(() => base.Hide());
        base.Hide();
    }
}
