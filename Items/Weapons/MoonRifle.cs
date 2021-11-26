using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Weapons
{
	public class MoonRifle : ModItem
	{
		public override string Texture => "Blobfish/Items/Weapons/MoonRifle";
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonshot");
			Tooltip.SetDefault("Big snipe, yes?");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 90;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 60000;
			item.rare = -12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<FlamethrowerProjectile>(); 
			item.shootSpeed = 16f;
			//item.useAmmo = AmmoID.Gel;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.CursedFlame, 10);
			recipe.AddIngredient(ItemID.ShadowFlameHexDoll, 1);
			recipe.AddIngredient(ItemID.Flamethrower, 1);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.Ichor, 10);
			recipe.AddTile(TileID.Anvils); // Change to Mythril Anvil.
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-13, 0);
		}
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			//Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("TestFlame"), damage = 80, knockBack = 1, player.whoAmI);
			//Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Shadowflames, damage = 10, knockBack = 1, player.whoAmI);
			//if (type == ProjectileID.Bullet)
			//	type = ProjectileID.CursedFlameFriendly;
			//return true;
		}*/

		/*public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .10f;
		}*/

		// What if I wanted this gun to have a 38% chance not to consume ammo?
		/*public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .38f;
		}*/
		// How can I make the shots appear out of the muzzle exactly?
		// Also, when I do this, how do I prevent shooting through tiles?
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}*/

		// How can I get a "Clockwork Assault Riffle" effect?
		// 3 round burst, only consume 1 ammo for burst. Delay between bursts, use reuseDelay
		/*	The following changes to SetDefaults()
		 	item.useAnimation = 12;
			item.useTime = 4;
			item.reuseDelay = 14;
		public override bool ConsumeAmmo(Player player)
		{
			// Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
			// We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
			return !(player.itemAnimation < item.useAnimation - 2);
		}*/

		// How can I shoot 2 different projectiles at the same time?
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.GrenadeI, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}*/
	}
}