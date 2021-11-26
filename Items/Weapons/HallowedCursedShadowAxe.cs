using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Weapons
{
	public class HallowedCursedShadowAxe : ModItem
	{
		//May need to adjust amounts of dust for FPS later
		//Make this have a dual use where it inflicts either cursed flame or shadowflame and changes the sprite?
		//Need to decompile source
		//https://github.com/tModLoader/tModLoader/blob/dfe30aae2a3ecc8f5f7bc45db2132e386ddb90f5/ExampleMod/Items/Weapons/ExampleDualUseWeapon.cs code reference

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Shadowflame Battleaxe");
			Tooltip.SetDefault("A dual shadowflame cursed battleaxe held together by hallowed bars.\n<left> swings with the cursed edge, <right> swings with the shadowflame edge.");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 94;
			item.height = 94;
			item.useTime = 3; // @Knight376 // fast as fuck boi
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5.85f;
			item.value = 1380;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowFlameHexDoll, 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.ShadowAnvil); Modded Anvil, add later when 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			if (player.altFunctionUse == 2)
			{
				target.AddBuff(BuffID.ShadowFlame, 180); //Gives X to target for 4 seconds. (60 = 1 second, 240 = 4 seconds)
			}
			else
			{
				target.AddBuff(BuffID.CursedInferno, 180);
			}
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			//This ones emits shadowflame particles at random sizes and intervals
			float projAI1 = Main.rand.NextFloat(2f);
			float dustScale1 = 1f;
			if (projAI1 == 0f)
				dustScale1 = 0.25f;
			else if (projAI1 == 1f)
				dustScale1 = 0.5f;
			else if (projAI1 == 2f)
				dustScale1 = 0.75f;

			if (Main.rand.NextBool(2))
			{
				Dust dust1 = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Shadowflame);
				if (Main.rand.NextBool(3))
				{
					dust1.noGravity = true;
					dust1.scale *= 3f;
					dust1.velocity.X *= 2f;
					dust1.velocity.Y *= 2f;
				}

				dust1.scale *= 1.1f;
				dust1.velocity *= 1.2f;
				dust1.scale *= dustScale1;
			}
			//This one emits cursed flame particles at random sizes and intervals
			float projAI2 = Main.rand.NextFloat(2f);
			float dustScale2 = 1f;
			if (projAI2 == 0f)
				dustScale2 = 0.25f;
			else if (projAI2 == 1f)
				dustScale2 = 0.5f;
			else if (projAI2 == 2f)
				dustScale2 = 0.75f;

			if (Main.rand.NextBool(2))
			{
				Dust dust2 = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.CursedTorch);
				if (Main.rand.NextBool(3))
				{
					dust2.noGravity = true;
					dust2.scale *= 3f;
					dust2.velocity.X *= 2f;
					dust2.velocity.Y *= 2f;
				}

				dust2.scale *= 1.1f;
				dust2.velocity *= 1.2f;
				dust2.scale *= dustScale2;
			}
		}
		//The right click effects
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.noUseGraphic = false;
				item.useTime = 30;
				item.useAnimation = 30;
				item.damage = 100;
				/*item.shoot = ModContent.ItemType<AmongUsSword>();
				item.shootSpeed = 40f;*/
			}
			else
			{
				item.useStyle = ItemUseStyleID.SwingThrow;
				item.noUseGraphic = false;
				item.useTime = 30;
				item.useAnimation = 30;
				item.damage = 100;
				/*item.shoot = ProjectileID.None;
				item.shootSpeed = 0;*/
			}
			return base.CanUseItem(player);
		}
	}
}