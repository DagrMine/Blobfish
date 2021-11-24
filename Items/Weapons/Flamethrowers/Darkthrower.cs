using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Weapons.Flamethrowers
{
	public class DarkThrower : ModItem
	{
		public override string Texture => "Blobfish/Items/Weapons/Flamethrowers/AllThrower";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night's Flare");
			Tooltip.SetDefault("Has absolutely nothing to do with and sword named after the night.\n35% Chance not to consume ammo.\nUses Gel for ammo\nnope, not at all.");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 122;
			item.height = 68;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 60000;
			item.rare = -12;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Gel;
			item.shoot = ProjectileID.Flames;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CrimsonFlamethrower", 1);
			recipe.AddIngredient(mod, "FieryFlamethrower", 1);
			recipe.AddIngredient(mod, "JungleFlamethrower", 1);
			recipe.AddIngredient(mod, "DungeonFlamethrower", 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 122f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			//Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Flames, damage = 80, knockBack = 1, player.whoAmI); //Not in use because it shoots this projectile by default
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<ShadowFlames>(), damage = 16, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<JungleFlames>(), damage = 16, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<CorruptFlames>(), damage = 16, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<CrimsonFlames>(), damage = 16, knockBack = 1, player.whoAmI);
			return true;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .35f;
		}
	}
}