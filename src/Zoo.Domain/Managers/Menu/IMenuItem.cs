namespace Zoo.Domain.Managers.Menu
{
    public interface IMenuItem
    {
        string Name { get; }

        void OnSelect();
    }
}
