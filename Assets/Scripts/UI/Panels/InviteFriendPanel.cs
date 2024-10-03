using DG.Tweening;
using UnityEngine;

public class InviteFriendPanel : BasePanel
{
    [SerializeField] private RectTransform inviteFriendPanel;
    protected override void Awake()
    {
        PanelType = UIType.InviteFriend;
        base.Awake();
    }

    public override void OnAwake()
    {
        // inviteFriendPanel.localScale = Vector3.zero;
        base.OnAwake();
    }

    public override void Show()
    {
        // inviteFriendPanel.DOScale(Vector3.one, 0.2f)
        //     .SetEase(UIManager.Instance.Transition);
        
        base.Show();
    }

    public override void Hide()
    {
        // inviteFriendPanel.DOScale(Vector3.zero, 0.2f)
        //     .SetEase(UIManager.Instance.Transition)
        //     .OnComplete(() => base.Hide());
        base.Hide();
    }
}
