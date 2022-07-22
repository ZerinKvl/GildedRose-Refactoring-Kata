using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }

        [Test]
        public void CheckBackstagePassItem_SellInIsLessThan10_QualityIncreasesBy2()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(12, Items[0].Quality);
        }

        [Test]
        public void CheckBackstagePassItem_SellInIs10_QualityIncreasesBy2()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(12, Items[0].Quality);
        }

        [Test]
        public void CheckBackstagePassItem_SellInIsLessThan5_QualityIncreasesBy3()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(23, Items[0].Quality);
        }
        
        [Test]
        public void CheckBackstagePassItem_SellInIs5_QualityIncreasesBy3()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(23, Items[0].Quality);
        } 
        
        [Test]
        public void CheckBackstagePassItem_SellInLessThan0_QualityIs0()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(0, Items[0].Quality);
        }
            
        [Test]
        public void Should_NotBe_Quality_Is_MoreThan_50()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(50, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }
        [Test]
        public void Should_NotBe_Quality_Is_Negative()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }
        
        [Test]
        public void CheckQuality_SellByDateIsPasses_QualityDegrateTwice()
        {
            //Act

            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 4 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();

            //Assert

            Assert.AreEqual(2, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }
    }
}
