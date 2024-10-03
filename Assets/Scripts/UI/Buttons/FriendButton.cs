public class FriendButton : BaseButton
{
    protected override void OnClick()
    {
        UIManager.Instance.GetPanel(UIType.Friend).Show();
    }
}