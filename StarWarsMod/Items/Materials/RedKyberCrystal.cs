using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarWarsMod.Items.Materials
{
    public class RedKyberCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Kyber Crystal");
            Tooltip.SetDefault("This crystal is formed by bleeding a normal kyber crystal.")
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 20;
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.maxStack = 999;
        }
    }
}