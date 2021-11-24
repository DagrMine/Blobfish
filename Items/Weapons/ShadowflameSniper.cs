using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Blobfish.Projectiles;

namespace Blobfish.Items.Weapons
{
	public class ShadowflameSniper : ModItem
	{
		public override string Texture => "Blobfish/Items/Weapons/MoonRifle";
		public override void SetStaticDefaults()

		{
			DisplayName.SetDefault("Shadowflame Hex Staff");
			Tooltip.SetDefault("The hex doll, but better");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.magic = true;
			item.mana = 2;
			item.width = 108;
			item.height = 108;
			item.useTime = 21;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 60000;
			item.rare = 6;
			item.UseSound = SoundID.Item2;
			item.autoReuse = true;
			item.shoot = ProjectileID.ShadowFlame;
			item.shootSpeed = 36f;
			//item.useAmmo = AmmoID.Gel;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.ShadowFlameHexDoll, 1);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.Anvils); // Change to Mythril Anvil.
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 120f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			/*Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("TestFlame"), damage = 80, knockBack = 1, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Shadowflames, damage = 10, knockBack = 1, player.whoAmI);
			if (type == ProjectileID.Bullet)
				type = ModContent.ProjectileType<FlamethrowerProjectile>();*/
			return true;
		}
	}
}