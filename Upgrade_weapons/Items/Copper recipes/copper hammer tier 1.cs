using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace Upgrade_weapons.Items
{
    public class copperham1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copper Hammer tier 1");
            
        }
        public override void SetDefaults()
        {
            item.Size = new Vector2(28);
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(silver: 10);

            item.autoReuse = true;
            item.useTime = 29;
            item.useAnimation = 29;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 8;
            item.knockBack = 1.75f;

            item.hammer = 40; 
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperHammer);
            recipe.AddIngredient(mod, "copper_upgrade", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}