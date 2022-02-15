using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace Upgrade_weapons.Items
{
    public class copperpick3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copper Pickaxe tier 3");

        }
        
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(silver: 10);

            item.autoReuse = true;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 25;
            item.knockBack = 1.75f;

            item.pick = 53; 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "copperpick2", 1);
            recipe.AddIngredient(mod, "copper_upgrade", 3);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}