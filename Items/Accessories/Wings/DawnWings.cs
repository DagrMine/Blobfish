using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Blobfish.Items.Accessories.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    class DawnWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dawn Wings");
            Tooltip.SetDefault("This is probably a reference to somehting\nW.I.P.");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = ItemRarityID.Cyan;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 360;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.2f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 12f;
            acceleration *= 6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Trout);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
