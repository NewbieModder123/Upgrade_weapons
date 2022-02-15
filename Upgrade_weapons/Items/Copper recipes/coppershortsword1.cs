using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Upgrade_weapons.Items
{
	public class coppershort1 : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Shortsword tier 1");
			Tooltip.SetDefault("The third most powerful weapon of them all...");
		}
		public override void SetDefaults()
		{
			item.damage = 7; //set its base damage
			item.melee = true; //says what class it is
			item.width = 5; //?
			item.height = 10; //?
			item.useTime = 12; //the time it takes to use it
			item.useAnimation = 12; //the time it takes for the animation
			item.useStyle = 3; //changes attack (1 is 3 backwards  2 is  shortsword, and 3 is overhead swing)
			item.knockBack = 13; //changes base knockback
			item.value = 1; //?
			item.rare = 1; //changes text colour
			item.UseSound = SoundID.Item1; //changes attack noise
			item.autoReuse = true; //allows you to hold down mouse instead of clicking
			item.useTurn = true;

		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddIngredient(mod, "copper_upgrade", 1);
			
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}


}