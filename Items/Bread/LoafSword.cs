using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Bread
{
	public class LoafSword : ModItem
	{
		public override string Texture => "Blobfish/Images/Loaf";
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Loaf");
			Tooltip.SetDefault("B R E A D  go  S L I C E");
		}

		public override void SetDefaults() 
		{
			item.damage = 3;
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 2;
			item.useAnimation = 6;
			item.useStyle = 1;
			item.knockBack = 2;
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