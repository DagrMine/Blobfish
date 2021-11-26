using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Weapons
{
	public class LunarLongbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moon bow thing");
			Tooltip.SetDefault("Does extra damage when shooting downwards");
		}
		//maybe make it so it holds you in the air while shooting
		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 144;
			item.height = 144;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 60000;
			item.rare = -12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("MoonArrow");
			item.shootSpeed = 16f;
			//item.useAmmo = AmmoID.Gel;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CursedFlame, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		//public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		//{
		//Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("TestFlame"), damage = 80, knockBack = 1, player.whoAmI);
		//Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Shadowflames, damage = 10, knockBack = 1, player.whoAmI);
		//if (type == ProjectileID.Bullet)
		//	type = ProjectileID.CursedFlameFriendly;
		//return true;
		//}
		/*public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            base.ModifyHitNPC(player, target, ref damage, ref knockBack, ref crit);
        }*/
		public override void ModifyManaCost(Player player, ref float reduce, ref float mult)
		{
			double currentTime = Main.time;
			// The time at which it changes from day to night and vice versa.
			double maxTime = Main.dayTime ? Main.dayLength : Main.nightLength;
			// More mana during day, less at night
			int direction = Main.dayTime ? 1 : -1;
			// Sine goes from 0 to 1 to 0 over a period of pi, so we match that to the length of the day/night.
			float timeMult = (float)Math.Sin(currentTime / maxTime * Math.PI);
			// Then we multiply by direction so it goes between 1 and -1 through the entire day, then multiply by 0.5 and add 1 to make it go between 1.5 and 0.5.
			timeMult = 1 + timeMult * direction * 0.5f;
			// Last, we multiply the current mana cost multiplier of the item by our multiplier.
			mult *= timeMult;
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
		}
	}
}