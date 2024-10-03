using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RankPanel : BasePanel
{
    [SerializeField] private RectTransform rankPanel;
    private Vector2 _rankPanelPos;
    protected override void Awake()
    {
        PanelType = UIType.Rank;
        base.Awake();
    }

    public override void OnAwake()
    {
        _rankPanelPos = rankPanel.position;
        rankPanel.anchoredPosition = new Vector2(0, -1200);
        base.OnAwake();
    }

    public override void Show()
    {
        base.Show();
        rankPanel.DOMove(_rankPanelPos, 0.3f)
            .SetEase(UIManager.Instance.Transition);
    }

    public override void Hide()
    {
        rankPanel.DOAnchorPosY(-1200, 0.3f)
            .SetEase(UIManager.Instance.Transition)
            .OnComplete(() => base.Hide());
    }
}
