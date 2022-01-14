using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarWarsMod.Items.Materials
{
    public class KyberCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kyber Crystal");
            Tooltip.SetDefault("Use this to make all sorts of fun stuff")
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