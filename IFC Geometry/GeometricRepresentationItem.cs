using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFC4;
namespace IFC_Geometry
{
	public abstract class GeometricRepresentationItem
    {
		public abstract void GetMesh();
    }

	public abstract class SolidModel : GeometricRepresentationItem
	{
		
		

		public SolidModel() { }
		public SolidModel(IfcSolidModel ifc)
        {
		
        }
		public abstract override void GetMesh();
	}



	public abstract class SweptAreaSolid : SolidModel
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D

		public IfcProfileDef SweptArea { get; set; }
		public IfcAxis2Placement3D Position { get; set; }
		public abstract override void GetMesh();
	}



	public class ExtrudedAreaSolid : SweptAreaSolid
	{
		//1	SweptArea : IfcProfileDef
		//2	Position : IfcAxis2Placement3D
		//3	ExtrudedDirection : IfcDirection
		//4	Depth : IfcPositiveLengthMeasure

		public IfcDirection ExtrudedDirection { get; set; }
		public IfcPositiveLengthMeasure Depth { get; set; }

		public ExtrudedAreaSolid() { }

		public ExtrudedAreaSolid(ExtrudedAreaSolid ifc)
		{
			this.SweptArea = ifc.SweptArea;
			this.Position = ifc.Position;
			this.ExtrudedDirection = ifc.ExtrudedDirection;
			this.Depth = ifc.Depth;
		}
		public override void GetMesh() {
			
		}
	}
}
