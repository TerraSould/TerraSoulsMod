using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraSouls.Items.Weapons
{
    public class TowerKnightsSpear : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Копье Рыцаря Башни";
            item.damage = 99;
            item.toolTip = "Копье одного из могучих демонов - Рыцаря Башни. Он охранял замок Террарии от иноземцев и врагов. \nКопье имеет очень сильный урон по пешим войскам, но, тем не менее, очень тяжелое.";
            item.melee = true;
            item.width = 36;
            item.height = 36;
            item.scale = 1.1f;
            item.maxStack = 1;
            item.useTime = 45;
            item.useAnimation = 45;
            item.knockBack = 6f;
            item.useSound = 1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.useTurn = true;
            item.useStyle = 5;
            item.rare = 3;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.shoot = mod.ProjectileType("TowerKnight`Spear");
            item.shootSpeed = 7f;
        }
    }
}
