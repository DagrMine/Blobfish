using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Bread
{
	public class LoafStaff : ModItem
	{
		public override string Texture => "Blobfish/Images/Loaf";
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Loaf");
			Tooltip.SetDefault("The power of  B R E A D  compels you!");
		}

		public override void SetDefaults() 
		{
			item.damage = 2;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BreadToken", 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}