using Terraria.ID;
using Terraria;
using StarWarsMod.Items.Materials;
using Terraria.ModLoader;

namespace StarWarsMod.Items.Weapons.Lightsabers
{
	public class GreenLightsaber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Lightsaber");
			Tooltip.SetDefault("An elegant weapon.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<GreenKyber>(), 1);
			recipe.AddIngredient(ModContent.ItemType<LightsaberHilt>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}