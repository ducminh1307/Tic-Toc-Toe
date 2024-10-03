using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [field:SerializeField] public Ease Transition {get; private set;}
    private readonly Dictionary<UIType, BasePanel> _dictionaryPanels = new Dictionary<UIType, BasePanel>();

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        foreach (var panel in _dictionaryPanels.Values)
        {
            panel.OnAwake();
        }
    }

    public void RegisterPanel(BasePanel panel, UIType typeType)
    {
        if (!_dictionaryPanels.TryAdd(typeType, panel))
        {
            Debug.Log($"Can't register panel type {typeType}");
        }
}

    public BasePanel GetPanel(UIType typeType)
    {
        if (!_dictionaryPanels.TryGetValue(typeType, out var panel))
        {
            Debug.Log($"Can't get panel: {typeType}");
            return null;
        }
        return panel;
    }
}
