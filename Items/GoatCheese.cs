using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items
{
	public class GoatCheese: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Goat Cheese Wedge");
			Tooltip.SetDefault("A full inventory of these is enough to cheese any fight!");
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.melee = true; //No melee so KB and DMG don't matter?
			item.width = 30;
			item.height = 30;
			item.useTime = 1;
			item.useAnimation = 10;
			item.useStyle = 2;
			item.knockBack = 0;
			item.value = 100;
			item.rare = -12;
			item.UseSound = SoundID.Item2;
			item.autoReuse = false;
			item.healLife = 1;
			item.consumable = false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}