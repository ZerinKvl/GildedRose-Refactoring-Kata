
namespace csharp
{
    public class ItemManager
    {
        public ITarget targetItem;

        public ItemManager(ITarget targetItem)
        {
            this.targetItem = targetItem;
        }
        public ItemManager()
        {
        }
    }
}
