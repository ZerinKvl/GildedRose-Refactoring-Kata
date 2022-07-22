
namespace csharp
{
    public interface ITarget
    {
        Item Item
        {
            get;
            set;
        }     
        void CalculateSellByDate();
        void CalculateQuality();
        void SpecifyQualityValue();
    }
}
