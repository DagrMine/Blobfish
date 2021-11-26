using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Bread
{
	public class LoafGun : ModItem
	{
		public override string Texture => "Blobfish/Images/Loaf";
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Loaf");
			Tooltip.SetDefault("Are you BREADy to die?");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.ranged = true;
			item.noMelee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 1;
			item.useAnimation = 6;
			item.useStyle = 4;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<BreadShot>();
			item.shootSpeed = 4f;
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