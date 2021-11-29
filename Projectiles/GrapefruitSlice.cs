using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Projectiles
{
	public class GrapefruitSliceProj : ModProjectile
	{
		public override string Texture => "Blobfish/Images/GrapefruitSlice";
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Slice of Grapefruit Projectile");     //The English name of the projectile
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
		}

		public override void SetDefaults()
		{
			projectile.width = 26;               //The width of projectile hitbox
			projectile.height = 26;              //The height of projectile hitbox
			projectile.aiStyle = 3;             //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
			projectile.light = 0.5f;            //How much light emit around the projectile
			projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
			projectile.maxPenetrate = 3;
			aiType = ProjectileID.WoodenBoomerang;
		}
	}
}

