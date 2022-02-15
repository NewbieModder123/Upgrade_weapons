using Terraria.ID;
using Terraria.ModLoader;

namespace Upgrade_weapons.Items
{
	public class copper_upgrade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Copper Enhancment");
			Tooltip.SetDefault("The essence of all things copper.");
		}

		public override void SetDefaults()
		{
			
			


			
			item.useTime = 19;
			item.useAnimation = 19;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item4;


		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 5);
			recipe.AddIngredient(ItemID.FallenStar, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}