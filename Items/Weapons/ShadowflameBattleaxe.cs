using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Weapons
{
	public class ShadowflameBattleaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Shadowflame Battleaxe");
			Tooltip.SetDefault("C h o p");
		}
		public override void SetDefaults() 
		{
			item.damage = 48;
			item.melee = true;
			item.width = 76;
			item.height = 76;
			item.useTime = 20;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5.85f;
			item.value = 1380;
			item.rare = 4;
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
			target.AddBuff(BuffID.ShadowFlame, 180); //Gives X to target for 4 seconds. (60 = 1 second, 240 = 4 seconds)
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			float projAI = Main.rand.NextFloat(2f);
			float dustScale = 1f;
			if (projAI == 0f)
				dustScale = 0.25f;
			else if (projAI == 1f)
				dustScale = 0.5f;
			else if (projAI == 2f)
				dustScale = 0.75f;

			if (Main.rand.NextBool(2))
			{
				//Emit dusts when the sword is swung
				Dust dust = Dust.NewDustDirect(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Shadowflame);
				if (Main.rand.NextBool(3))
				{
					dust.noGravity = true;
					dust.scale *= 3f;
					dust.velocity.X *= 2f;
					dust.velocity.Y *= 2f;
				}

				dust.scale *= 1.1f;
				dust.velocity *= 1.2f;
				dust.scale *= dustScale;
			}
		}
    }
}