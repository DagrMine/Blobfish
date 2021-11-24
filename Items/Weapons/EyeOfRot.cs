using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Weapons
{
	public class EyeOfRot : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Eye of Rot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Pew.");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.magic = true;
			item.mana = 20;
			item.noMelee = true;
			item.channel = true;
			item.width = 150;
			item.height = 77;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = Item.sellPrice(gold: 2, silver: 30);
			item.rare = 8;
			item.UseSound = SoundID.Item34;
			item.shoot = ModContent.ProjectileType<CursedMissile>();
			item.shootSpeed = 10f;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BreadToken", 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 150f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}
	}
}