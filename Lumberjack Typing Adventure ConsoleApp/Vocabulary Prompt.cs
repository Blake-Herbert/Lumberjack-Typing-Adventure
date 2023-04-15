using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Lumberjack_Typing_Adventure
{
	public class Prompt
	{
		public string RandomSingleWord()

		{
			var random = new Random();
			int index = random.Next(singleWordPrompts.Count());
			return (singleWordPrompts[index]);

		}


		List<string> singleWordPrompts = new List<string> { "Wood", "Chop", "Cut", "Sawdust", "Leaf", "Axe", "Lumber", "Stump", "Camps", "Hooks", "Whistle", "Climber", "Topper", "Spar", "Cutter", "Chainsaw", "Lumberjill", "Cross-cut", "Demand", "Scandinavia", "Canada", "Migration", "Yarder", "Operator", "Skidders", "Sawmill", "Pride", "Felling", "Helicopter", "Trucks", "Danger", "America", "Forestry", "Transportation", "Silviculture", "Ecosystem", "Harvesting", "Deforestation", "Clearfelling", "Delimbed", "Landing", "Bucked", "Slash", "Harvester", "Sorting", "Wilderness", "Strength", "Woodsman", "Trapper", "Warden", "Diesel", "Protection", "Chaps", "Boots", "Profession", "Skill", "Experience", "Loggersports", "Lumberjack", "Flannel", "Folklore", "Arborist", "Arboriculture", "Shrubs", "Vines", "Air quality", "Caulks", "Corks"};

		//List<string> phrasePrompts = new List<string> { "If a tree falls...", "... and no one is around to hear it fall", "Does it make a sound?", "Chop it down! Chop it with your axe!", "Sawed in half", "All bark no bite", "Limb from limb", "Leaf me alone", "Unbe-leaf-able", "Axe you a question", "Lumbering around", "Lumber camps", "Climbing hooks", "Whistle punk", "High climber", "Tree topper", "Block and tackle", "Spar tree", "Logging sites", "Shanty boy", "Timber cutter", "River pig", "River rat", "Cross-cut saw", "Vast forests", "Follow the demand for wood", "Family tradition", "Westward migration", "Division of labor", "Choker setters", "Yarder operator", "Fallers and buckers", "Steam-powered equipment", "Animal-powered equipment", "Haul logs", "Logging wheels", "Log fume", "Log rolling", "Spiked boots", "Corduroy road", "Log road", "Timber trackway", "Industrial development", "Take pride in your craft", "Rugged individualism", "Tie hacking", "Felling trees", "Broad-axe", "Railroad ties", "Clear cutting", "Selective cutting", "Selective logging", "Work instability", "Low wages", "Logging is the most dangerous job", "Timber mafia", "Illegal logging", "Biodiversity loss", "High grading", "Underwater logging", "Timber recovery", "Standing trees", "Reserve trees", "Shelterwood cutting", "Group selective", "Single selective", "Seed-tree cutting", "Patch cut", "Retention cutting", "Tree length logging", "Stem only harvesting", "Whole-tree logging", "Cut-to-length logging", "Paper mill", "Paper pulp", "Rail line", "Timber rafting", "Log driving", "High-wheel loader", "The Bunyan Buggie", "National Forests", "Plant life", "Riparian zone", "Heli-logging", "Ski lift", "Horse logging", "Balloon logging", "Logging related injuries", "Heavy equipment", "Situational awareness", "Resistance to modernization", "Fire warden", "The U.S. Foresty Service", "King of the Lumberjacks", "Folk hero", "French-Canadian", "Feller-bunchers", "Consuming large amounts of food", "Modern technology", "Ear protection", "Hard hat", "Steeltoe boots", "Eye protection", "Long sleeves", "Logs and trees", "Double cut competition", "Natural enviornment", "Caulk books", "Tall tales", "Work songs", "Air quality", "Fresh air", "Work ethic", "Tree surgeon"};

		



	}
}
