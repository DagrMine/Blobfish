using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Weapons
{
	public class ProjectileSwordTest : ModItem
	{
		public override string Texture => "Blobfish/Images/RedKatana";
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Big Slash");
			Tooltip.SetDefault("Swong");
		}

		public override void SetDefaults() 
		{
			item.damage = 68;
			item.melee = true;
			item.width = 112;
			item.height = 112;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 2.4f;
			item.value = 1380;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.Arkhalis;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}