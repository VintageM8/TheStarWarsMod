using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StarWarsMod.Items.Materials
{
    public class LightsaberHilt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightsaber Hilt");
            Tooltip.SetDefault("A key componet to crafitng a lighsaber.")
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 20;
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}