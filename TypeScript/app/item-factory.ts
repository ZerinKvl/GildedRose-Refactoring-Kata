import { Item } from "./gilded-rose";
import { ITarget, TargetItem } from "./target-item";
import { AgedBrieItem, BackstagePassItem, LegendaryItem, ConjuredItem } from "./gilded-rose-items";


class ItemManager {
    targetItem: ITarget;

    constructor(targetItem: ITarget) {
        this.targetItem = targetItem;
    }
}

export class ItemFactory {
    createItemInstance(item: Item): ITarget {
        if (item.name.includes("Aged Brie"))
            return new ItemManager(new AgedBrieItem(item)).targetItem;
        if (item.name.includes("Backstage"))
            return new ItemManager(new BackstagePassItem(item)).targetItem;
        if (item.name.includes("Sulfuras"))
            return new ItemManager(new LegendaryItem(item)).targetItem;
        if (item.name.includes("Conjured"))
            return new ItemManager(new ConjuredItem(item)).targetItem;
        return new ItemManager(new TargetItem(item)).targetItem;
    }
}