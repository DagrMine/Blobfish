using Terraria.ID;
using Terraria.ModLoader;

namespace Blobfish.Items.Weapons
{
	public class Yeetbat : ModItem
	{
		public override string Texture => "Blobfish/Items/Weapons/BaseballBat";
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Yeetbat");
			Tooltip.SetDefault("Does lots of knocback yes?");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 1;
			item.knockBack = 420;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BaseballBat");
			item.autoReuse = true;
		}
	}
}