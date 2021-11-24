using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Weapons
{
	public class AmongUsSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Imposter");
			Tooltip.SetDefault("SUS!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?");
		}

		public override void SetDefaults() 
		{
			item.damage = 5000;
			item.melee = true;
			item.width = 30;
			item.height = 40;
			item.useTime = 100;
			item.useAnimation = 100;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AMOGUS");
			item.autoReuse = false;
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