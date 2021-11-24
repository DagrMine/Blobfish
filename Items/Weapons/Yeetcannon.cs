using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Weapons
{
	public class Yeetcannon : ModItem
	{
		public override string Texture => "Blobfish/Items/Weapons/Flamethrowers/AllThrower";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yeetcannon");
			Tooltip.SetDefault("BIG KNOCKBACK\nDoes not CONSUME ammo but requires a bullet\nMay lag or crash your game. This is intentional.");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.ranged = true;
			item.width = 122;
			item.height = 68;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 420;
			item.value = 60000;
			item.rare = -12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.Bullet;
			item.shootSpeed = 100f;
			item.useAmmo = AmmoID.Bullet;
			item.color = Color.Cyan;
			item.crit = 0;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 172f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			//Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("TestFlame"), damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Bullet, damage = 10, knockBack = 420, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Bullet, damage = 10, knockBack = 420, player.whoAmI);
			if (type == ProjectileID.Bullet)
				type = ProjectileID.BulletHighVelocity;
			return true;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 1.0f;
		}
	}
}