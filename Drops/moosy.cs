using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TCSSC.Drops
{
    public class moosydrop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            {
				if(!Main.hardMode)
                if (Main.player[Main.myPlayer].ZoneOverworldHeight)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
                {
                    if (Main.rand.Next(250) == 1)      //this is the item rarity, so 9 = 1 in 10 chance that the npc will drop the item.
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Moosy_Sword"), 1);//this is where you set what item to drop ,ItemID.VileMushroom is an example of how to add vanila items , Main.rand.Next(5, 10) it's the quantity,so it will chose a number from 5 to 10
                    }
                }
				else
				 if (Main.player[Main.myPlayer].ZoneOverworldHeight)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
                {
                    if (Main.rand.Next(2000) == 1)      //this is the item rarity, so 9 = 1 in 10 chance that the npc will drop the item.
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Moosy_Sword"), 1);//this is where you set what item to drop ,ItemID.VileMushroom is an example of how to add vanila items , Main.rand.Next(5, 10) it's the quantity,so it will chose a number from 5 to 10
                    }
                }
            }
		}
	}
}	