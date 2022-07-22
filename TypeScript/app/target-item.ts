import { Item } from "./gilded-rose";

export interface ITarget {
    item: Item;
    calculateSellByDate(): void;
    calculateQuality(): void;
    specifyQualityValue(): void;
}

export class TargetItem implements ITarget {
    item: Item;
    constructor(item: Item) {
        this.item = item;
    }

    calculateSellByDate(): void {
        this.item.sellIn -= 1;
    }
    calculateQuality(): void {
        this.item.quality--;
        if (this.item.sellIn < 0) {
            this.item.quality--;
        }
    }
    specifyQualityValue(): void {
        if (this.item.quality < 0) {
            this.item.quality = 0;
        }
        else if (this.item.quality > 50) {
            this.item.quality = 50;
        }
    }
}
