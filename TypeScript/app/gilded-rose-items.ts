
import { Item } from "./gilded-rose";
import { TargetItem } from "./target-item";

export class ConjuredItem extends TargetItem {
    constructor(item: Item) {
        super(item);
    }

    calculateQuality(): void {
        this.item.quality--;
        if (this.item.sellIn < 0) {
            this.item.quality -= 1;
        }
    }
}
export class AgedBrieItem extends TargetItem {
    constructor(item: Item) {
        super(item);
    }

    calculateQuality(): void {
        this.item.quality++;
        if (this.item.sellIn < 0) {
            this.item.quality++;

        }
    }
}
export class BackstagePassItem extends TargetItem {
    constructor(item: Item) {
        super(item);
    }

    calculateQuality(): void {
        if (this.item.sellIn < 10 && this.item.sellIn >= 5) {
            this.item.quality += 1;
        }

        if (this.item.sellIn < 5 && this.item.sellIn >= 0) {
            this.item.quality += 2;
        }

        this.item.quality += 1;


        if (this.item.sellIn < 0) {
            this.item.quality = 0;
        }
    }
}

export class LegendaryItem extends TargetItem {
    constructor(item: Item) {
        super(item);
    }

    calculateSellByDate(): void {

    }  
    
    calculateQuality(): void {

    }

    specifyQualityValue(): void {
        this.item.quality = 80;
    }
}