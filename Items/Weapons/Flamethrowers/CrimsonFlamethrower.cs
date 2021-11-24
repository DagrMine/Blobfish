using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Weapons.Flamethrowers
{
	public class CrimsonFlamethrower : ModItem
	{
		public override string Texture => "Terraria/Item_" + ItemID.Flamethrower;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Darkthrower");
			Tooltip.SetDefault("Shoots a mix of blood and fire, kind of gross.\n80% Chance not to consume ammo.\nUses Gel for ammo\nInflicts Ichor on enemies");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.ranged = true;
			item.width = 54;
			item.height = 16;
			item.useTime = 6;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 60000;
			item.rare = 11;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<CrimsonFlames>();
			item.shootSpeed = 6f;
			item.useAmmo = AmmoID.Gel;
			item.color = Color.DarkRed;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Flamethrower, 1);
			recipe.AddIngredient(ItemID.ShadowFlameHexDoll, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 54f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 1.0f;
		}
	}
}