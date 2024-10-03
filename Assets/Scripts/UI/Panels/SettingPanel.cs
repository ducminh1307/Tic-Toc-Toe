using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SettingPanel : BasePanel
{
    [SerializeField] private RectTransform settingsPanel;
    protected override void Awake()
    {
        PanelType = UIType.Setting;
        base.Awake();
    }

    public override void OnAwake()
    {
        // settingsPanel.localScale = Vector3.zero;
        base.OnAwake();
    }

    public override void Show()
    {
        base.Show();
        // settingsPanel.DOScale(Vector3.one, 0.2f)
        //     .SetEase(UIManager.Instance.Transition);
    }

    public override void Hide()
    {
        // settingsPanel.DOScale(Vector3.zero, 0.2f)
        //     .SetEase(UIManager.Instance.Transition)
        //     .OnComplete(() => base.Hide());
        base.Hide();
    }
}
