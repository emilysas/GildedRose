﻿using System.Collections.Generic;

namespace GildedRose.Console
{
    public class ItemUpdater
    {
        public void UpdateItems(List<Item> items)
        {
            foreach (var item in items)
            {
                UpdateQuality(item);
                UpdateSellIn(item);
            }
        }

        private void UpdateQuality(Item item)
        {
            if (item.SellIn < 1)
            {
                item.Quality -= 2;
            }
            else {item.Quality -= 1;}
        }

        private void UpdateSellIn(Item item)
        {
            item.SellIn -= 1;
        }
    }
}