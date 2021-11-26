using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items
{
	public class ShadowFlameItem: ModItem
	{
		public override string Texture => "Blobfish/Images/ShadowFlame";
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Shadow Flame");
			Tooltip.SetDefault("Fire, but dark?");
		}

		public override void SetDefaults() 
		{
			item.width = 24;
			item.height = 26;
			item.value = Item.sellPrice(silver: 8);
			item.rare = ItemRarityID.Purple;
			item.maxStack = 999;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.ShadowFlameHexDoll, 1);
			recipe1.AddTile(TileID.Furnaces);
			recipe1.SetResult(this,6);
			recipe1.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.ShadowFlameKnife, 1);
			recipe2.AddTile(TileID.Furnaces);
			recipe2.SetResult(this,6);
			recipe2.AddRecipe();

			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(ItemID.ShadowFlameBow, 1);
			recipe3.AddTile(TileID.Furnaces);
			recipe3.SetResult(this,6);
			recipe3.AddRecipe();

			ModRecipe recipe4 = new ModRecipe(mod);
			recipe4.AddIngredient(this, 1);
			recipe4.AddIngredient(ItemID.BrightPurpleDye, 1);
			recipe4.AddTile(TileID.DyeVat);
			recipe4.SetResult(ItemID.ShadowflameHadesDye, 1);
			recipe4.AddRecipe();

		}
	}
}