using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using StarWarsMod.Projectiles;

namespace StarWarsMod.Items.Weapons.Blasters
{
    public class DLT19Blaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("DLT19 Blaster");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.noMelee = true;
            item.ranged = true;
            item.autoReuse = true;
            item.knockBack = 3f;
            item.rare = ItemRarityID.Green;
            item.width = 38;
            item.height = 24;
            item.useTime = 17;
            item.useAnimation = 17;
            item.UseSound = SoundID.Item12;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.shootSpeed = 16f;
            item.shoot = ProjectileType<BlueLaser>();
            item.value = Item.sellPrice(0, 0, 70, 0);
        }
    }
}