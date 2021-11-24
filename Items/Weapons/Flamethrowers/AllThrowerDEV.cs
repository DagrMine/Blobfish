using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Weapons.Flamethrowers
{
	public class AllThrowerDEV : ModItem
	{
		public override string Texture => "Blobfish/Items/Weapons/Flamethrowers/AllThrower";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Devthrower");
			Tooltip.SetDefault("ALL THE FIRE! (Literally, this time)");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 80;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 60000;
			item.rare = -12;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Gel;
			item.color = new Color(50, 50, 50);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Shadowflames, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ShadowFlame, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.CursedFlameFriendly, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DD2BetsyFlameBreath, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Flames, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GreekFire1, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MolotovFire, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.EyeFire, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DD2FlameBurstTowerT3Shot, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FlamesTrap, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FlamethrowerTrap, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.CursedFlameHostile, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FrostBlastFriendly, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ShadowBeamFriendly, damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<FlamethrowerProjectile>(), damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<FrostfireFlames>(), damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<ShadowFlames>(), damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.IchorSplash, damage = 10, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BallofFrost, damage = 10, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BallofFire, damage = 10, knockBack = 1, player.whoAmI);
			return true;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
		}
	}
}