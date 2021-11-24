using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Bread
{
	public class BreadToken: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Loaf Token");
			Tooltip.SetDefault("E A T  B R E A D");
		}

		public override void SetDefaults() 
		{
			item.melee = false;
			item.width = 40;
			item.height = 40;
			item.value = 100;
			item.rare = -11;
			item.maxStack = 999;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Granite, 39960);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}