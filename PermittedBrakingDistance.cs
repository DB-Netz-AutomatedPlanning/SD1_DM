using RCA_Model.Tier_1;
using RCA_Model.Tier_2;
namespace RCA_Model.Tier_3
{
	public class PermittedBrakingDistance : Base, Tier3
	{
		public double permittedBrakingDistance;
		public List<TrackEdgeSection> appliesToTrackEdgeSection;
		public BrakeType brakeType;
	}

}
