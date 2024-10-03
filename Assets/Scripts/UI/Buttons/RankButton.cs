public class RankButton : BaseButton
{
    protected override void OnClick()
    {
        UIManager.Instance.GetPanel(UIType.Rank).Show();
    }
}
