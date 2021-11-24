using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Weapons
{
	public class GrapefruitSlice : ModItem
	{
		public override string Texture => "Blobfish/Images/OrangeSlice";
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Slice of Orange"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Bop.");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.magic = true;
			item.noMelee = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = -13;
			item.UseSound = SoundID.Item2;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<GrapefruitSliceProj>();
			item.shootSpeed = 10f;
			item.color = Color.Pink;
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